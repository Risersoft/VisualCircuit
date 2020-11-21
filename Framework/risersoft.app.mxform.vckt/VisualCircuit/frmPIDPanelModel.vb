Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDPanelModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("CtlPanel")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            Dim oRet As clsProcOutput = Me.GetRowLock(prepMode, "pidunitid", prepIDX)
            If oRet.Success Then
                Dim Sql As String = "select * from deslistpidunittot() where pidunitid = " & prepIDX
                Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

                Sql = "select pidctlpanelid, pidunitid,Sortindex, PanelCode, PanelName, PanelType,FieldIns from pidctlpanel where pidunitid =  " & prepIDX
                myView.MainGrid.QuickConf(Sql, True, "1-2-4-2-2", True)
                Dim str1 As String = "<BAND INDEX=""0"" TABLE=""PIDCtlPanel"" IDFIELD=""PIDCtlPanelID""><COL KEY=""pidunitid""/><COL KEY=""sortindex"" CAPTION=""Index""/><COL KEY=""PanelCode"" CAPTION=""Code""/><COL KEY=""PanelName"" CAPTION=""Name""/><COL KEY=""PanelType"" VLIST=""1;Outdoor Panel|2;Indoor Panel|3;Bought Out Panel|4;Field Area""/><COL KEY=""FieldIns"" CAPTION=""Installation"" VLIST=""False;Factory|True;Field""/></BAND>"
                myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)
                Me.FormPrepared = True
            Else
                Me.AddError("", Nothing, 0, "", "", oRet.Message)
            End If
        End If
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
                myView.MainGrid.SaveChanges(, "pidunitid=" & frmIDX)
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        Dim PidunitID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@pidunitid", Params))
        Dim OldPanelCode As String = "'" & myUtils.cStrTN(myContext.SQL.ParamValue("@oldpanelcode", Params)) & "'"
        Dim NewPanelCode As String = "'" & myUtils.cStrTN(myContext.SQL.ParamValue("@newpanelcode", Params)) & "'"
        If oRet.Success Then
            Select Case dataKey.Trim.ToLower
                Case "rename"
                    Dim dic As New clsCollecString(Of String)
                    dic.Add("PIDCtl", "Update PIDCtl set Location = " & NewPanelCode & " where Location = " & OldPanelCode & " and PIDUnitID = " & PidunitID & "")
                    dic.Add("PIDCtlPanel", "Update PIDCtlPanel set PanelCode = " & NewPanelCode & " where PanelCode = " & OldPanelCode & " and PIDUnitID = " & PidunitID & "")
                    dic.Add("PIDCtlBusTerm", "Update PIDCtlBusTerm set PanelCode = " & NewPanelCode & " where PanelCode = " & OldPanelCode & " and Pidctlbusid IN (SELECT Pidctlbusid FROM PIDCTLBUS where PIDUnitID = " & PidunitID & ")")
                    dic.Add("PIDCtlBusPanel", "Update PIDCtlBusPanel set PanelCode = " & NewPanelCode & " where PanelCode = " & OldPanelCode & " and Pidctlbusid IN (SELECT Pidctlbusid FROM PIDCTLBUS where PIDUnitID = " & PidunitID & ")")
                    Try
                        Dim sql = myUtils.MakeCSV(dic.Values.ToList, ";")
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                    Catch ex As Exception
                        oRet.AddException(ex)
                    End Try
            End Select
        End If
        Return oRet

    End Function

End Class
