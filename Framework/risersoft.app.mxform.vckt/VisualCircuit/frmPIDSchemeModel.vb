Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxengg
Imports Infragistics.Win
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDSchemeModel
    Inherits clsFormDataModel
    Dim myCtl As New clsCtlScheme(myContext)
    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim vlist1 As New clsValueList
        vlist1.Add("Printer")
        vlist1.Add("PDF")
        Me.ValueLists.Add("Mode", vlist1)
        Me.AddLookupField("Mode", "Mode")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        Dim oRet As clsProcOutput = Me.GetRowLock(prepMode, "PidUnitId", prepIDX)
        If prepMode = EnumfrmMode.acEditM AndAlso oRet.Success Then
            Dim Sql As String = "Select * from desListPidUnittot() where PidUnitId = " & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

            Dim dic As New clsCollecString(Of String)
            dic.Add("PidCtl", "Select * from PidCtl where PidUnitId=" & frmIDX)
            dic.Add("PidCtlPanel", "Select * from PidCtlPanel where PidUnitId=" & frmIDX)
            Me.AddDataSet("Scheme", dic)

            Me.FormPrepared = True
        Else
            Me.AddError("", Nothing, 0, "", "", oRet.Message)
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "delete"
                Dim dic As New clsCollecString(Of String)
                dic.Add("PIDCtl", "delete from PidCtl where PidUnitId = " & myUtils.cValTN(frmIDX))
                dic.Add("PidCtlBus", "delete from PidCtlBus where  PidUnitId=" & myUtils.cValTN(frmIDX))
                dic.Add("PIDCtlCable", "delete from PIDCtlCable where PidUnitId = " & myUtils.cValTN(frmIDX))
                dic.Add("PIDCtlPanel", "delete from PIDCtlPanel where PidUnitId = " & myUtils.cValTN(frmIDX))

                Try
                    Dim sql = myUtils.MakeCSV(dic.Values.ToList, ";")
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                Catch ex As Exception
                    oRet.AddException(ex)
                End Try
            Case "ctltermbus"
                Dim dic As New clsCollecString(Of String)
                dic.Add("PIDCtlTerm", "select panelcode,pidctlid,location,paneltype,istb,pidctltermid,pidctlbusid,Ctlcat,Legend, TerminalName,WireNum from desListPIDCtlTerm() where PidUnitId=" & frmIDX)
                dic.Add("PidCtlBus", "select * from pidctlbus where  pidunitid=" & frmIDX)
                Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)

                For Each r1 As DataRow In ds.Tables(1).Select
                    r1("multitfmb") = myCtl.SetBusType(ds.Tables(1), ds.Tables(0), r1("pidctlbusid"))
                Next
                myContext.Provider.objSQLHelper.SaveResults(ds.Tables(1), "select pidctlbusid,multitfmb from pidctlbus where pidctlbusid =0")
            Case "panel"
                Dim Sql As String = "select panelcode as PanelSrc, '' as PanelDes from pidctlpanel where pidunitid=" & frmIDX
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            Case "ic"
                Dim dic As New clsCollecString(Of String)
                dic.Add("ic", "select * from ctslistpidcable() where pidunitid = " & frmIDX & " and paneltype2 <> 4")
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As New clsViewModel(vwState, myContext)
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "pidctlcable"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("select distinct Loc1,Loc2 from pidctlcable where PidUnitID=@PidUnitID", Params)
                    Model.MainGrid.QuickConf(sql, True, "1-1", True)
                Case "pidcable"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("select loc1,loc2,device1,device2,terminal1,terminal2,CableDescrip,Term1,WireNum,Term2 from ctsListPIDCable() where PidUnitID=@PidUnitID", Params)
                    Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                    Model.MainGrid.BindGridData(dt1.DataSet, 0)
                    Model.MainGrid.MainConf("FORMATXML") = "<COL KEY=""CableDescrip"" CAPTION=""Cable""/>"
                    Model.MainGrid.MainConf("defaultgroupon") = "CableDescrip"
                    Model.MainGrid.MainConf("sortcolsasc") = "Loc1,Device1,Terminal1,Loc2,Device2,Terminal2"
                    Model.MainGrid.QuickConf("", True, "1-1-1", True)
            End Select
        End If
        Return Model
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "save"
                    Dim PidUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitID", Params))
                    Dim RefPidUnitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@RefPidUnitID", Params))
                    Dim PanelSrcCSV As String = myContext.SQL.ParamValue("@PanelSrcCSV", Params)
                    Dim PanelDesCSV As String = myContext.SQL.ParamValue("@PanelDesCSV", Params)

                    Dim dsSource, dsTarget As DataSet, sql As String
                    sql = "select * from pidctlbus where pidunitid=" & RefPidUnitID & ";select * from ctslistpidctlterm() where pidunitid= " & RefPidUnitID
                    dsSource = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

                    sql = "select * from pidctlbus where pidunitid=" & PidUnitID & ";select * from ctslistpidctlterm() where pidunitid= " & PidUnitID
                    dsTarget = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
                    myContext.Tables.SetAuto(dsTarget.Tables(0), dsTarget.Tables(1), "pidctlbusid", "_pidctlbus")

                    For Each r1 As DataRow In dsSource.Tables(0).Select()
                        Dim nr As DataRow = Nothing, rr() As DataRow
                        rr = dsTarget.Tables(0).Select("wirenum='" & r1("wirenum") & "'")
                        If rr.Length = 0 Then
                            nr = myUtils.CopyOneRow(r1, dsTarget.Tables(0))

                            Dim arr() As String = Split(PanelSrcCSV, ",")
                            Dim arr1() As String = Split(PanelDesCSV, ",")

                            For Each r2 As DataRow In dsSource.Tables(1).Select("pidctlbusid=" & r1("pidctlbusid"))
                                Dim desloc As String = ""
                                Dim i As Integer = Array.IndexOf(arr, "'" & r2("location").ToString.ToUpper & "'")
                                If arr1(i).ToString.Length > 0 Then
                                    For Each r3 As DataRow In dsTarget.Tables(1).Select(myUtils.CombineWhere(False, "legend='" & r2("legend") & "'", "terminalname='" & r2("terminalname") & "'", "location=" & arr1(i)))
                                        If myUtils.NullNot(r3("pidctlbusid")) Then
                                            r3("pidctlbusid") = nr("pidctlbusid")
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
                    myUtils.ChangeAll(dsTarget.Tables(0).Select, "pidunitid=" & PidUnitID)
                    myContext.Provider.objSQLHelper.SaveResults(dsTarget.Tables(0), "select * from pidctlbus where pidctlbusid=0")
                    myContext.Provider.objSQLHelper.SaveResults(dsTarget.Tables(1), "select pidctltermid, pidctlbusid from pidctlterm where pidctlid=0")
            End Select
        End If
        Return oRet
    End Function
End Class
