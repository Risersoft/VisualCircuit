Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDSchemePanelModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("PidCTL")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Me.IgnorefRow = True

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Me.InitData("", "", oView, prepMode, prepIDX)
        Me.vBag = Me.PrepVBag(strXML, oView.ContextRow, "PanelCode,PanelType")
        Dim ds As DataSet = GenerateDataSet(myUtils.cValTN(Me.vBag("PanelType")), myUtils.cStrTN(Me.vBag("PanelCode")), myUtils.cValTN(frmIDX))
        myView.MainGrid.BindGridData(ds, 0)
        myView.MainGrid.QuickConf("", True, "1-3.5-1.25-0.75-1.5-0.75-0.5-0.5", True)
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        myView.MainGrid.CheckValid("PanelCode,PanelName,PanelType")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Try
                myView.MainGrid.SaveChanges(, "PidUnitId=" & frmIDX)
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Dim PidUnitId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitId", Params))
            Dim PanelType As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PanelType", Params))
            Dim PanelCode As String = myUtils.cStrTN(myContext.SQL.ParamValue("@PanelCode", Params))
            Select Case dataKey.Trim.ToLower
                Case "deleterefresh"
                    Dim PidCtlId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PidCtlId", Params))
                    Dim sql As String = "delete from pidctl where pidctlid = " & PidCtlId & ""
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                    oRet.Data = GenerateDataSet(myUtils.cValTN(PanelType), myUtils.cStrTN(PanelCode), myUtils.cValTN(PidUnitId))
                Case "refresh"
                    oRet.Data = GenerateDataSet(myUtils.cValTN(PanelType), myUtils.cStrTN(PanelCode), myUtils.cValTN(PidUnitId))
            End Select
        End If
        Return oRet
    End Function

    Private Function GenerateDataSet(PanelType As Integer, PanelCode As String, PidUnitId As Integer) As DataSet
        Dim Sql, Str1 As String
        If PanelType = 2 Then Str1 = "MtgCP" Else Str1 = "MtgMB"
        Sql = "select pidctlid, descripprefix,descripsuffix, pidunitid,ctlitemid, ItemCode, Item, Spec, Make, SuppSpec, Legend, " & Str1 & ", Qty from deslistpidctl() where (location='" & PanelCode & "') and PidUnitId=" & myUtils.cValTN(PidUnitId)
        Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
        Return ds
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As New clsViewModel(vwState, myContext)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "pidctlbus"
                    Model.MainGrid.MainConf("showrownumber") = True
                    Model.MainGrid.MainConf("sortcolsasc") = "wirenum"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("select pidctlbusid, multitfmb,pidunitid, WireNum, SQMM, Color from PIDCtlBus where PidUnitID=@PidUnitID", Params)
                    Model.MainGrid.QuickConf(sql, True, "1-1-1.5", True)
                Case "pidctlpanel"
                    Model.MainGrid.MainConf("showrownumber") = True
                    Dim sql As String = myContext.SQL.PopulateSQLParams("select pidctlpanelid, pidunitid, sortindex, PanelCode, PanelName from PIDCtlPanel where PidUnitID=@PidUnitID order by PanelCode", Params)
                    Model.MainGrid.QuickConf(sql, True, "1-1", True)
            End Select
        End If
        Return Model
    End Function

    Public Overrides Function GenerateDataParamsOutput(dataKey As String, ds As DataSet, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey
            Case "copymb"
                Dim PidUnitId As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitId", Params))
                Dim PanelCode As String = myUtils.cStrTN(myContext.SQL.ParamValue("@PanelCode", Params))

                Dim sql As String = myContext.SQL.PopulateSQLParams("select * from PidCtl where pidunitid=@RefPIDUnitID;select * from pidctlterm where PidCtlId in (select PidCtlId from PidCtl where PidUnitId=@RefPIDUnitID)", Params)
                Dim ds1 As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
                Dim dt1 As DataTable = ds1.Tables(0).Clone, dt2 As DataTable = ds1.Tables(1).Clone
                myContext.Tables.SetAuto(dt1, dt2, "PidCtlId", "_pidctl")

                For Each r1 As DataRow In ds.Tables("CopyCtl").Select("sysincl=1")
                    Dim nr As DataRow = Nothing, rr() As DataRow = New DataRow() {}
                    If myUtils.cStrTN(r1("legend")).Trim.Length > 0 Then
                        rr = ds.Tables("PIDCtl").Select("legend='" & r1("legend") & "'")
                    End If
                    If rr.Length = 0 Then
                        nr = myUtils.CopyOneRow(ds1.Tables(0).Select("PidCtlId=" & r1("PidCtlId"))(0), dt1)
                        nr("location") = PanelCode
                        For Each r2 As DataRow In ds1.Tables(1).Select("PidCtlId=" & r1("PidCtlId"))
                            Dim nr2 As DataRow = myContext.Tables.AddNewRow(dt2)
                            nr2("PidCtlId") = nr("PidCtlId")
                            For Each str2 As String In New String() {"ctlitemtermsetid", "terminalname", "sortindexctl"}
                                nr2(str2) = r2(str2)
                            Next
                        Next
                    End If
                Next
                Try
                    myUtils.ChangeAll(dt1.Select, "PidUnitId=" & PidUnitId)
                    myContext.Provider.objSQLHelper.SaveResults(dt1, "select * from pidctl where PidCtlId=0")
                    myContext.Provider.objSQLHelper.SaveResults(dt2, "select * from pidctlterm where PidCtlId=0")
                Catch ex As Exception
                    oRet.AddException(ex)
                End Try
        End Select
        Return oRet
    End Function
End Class
