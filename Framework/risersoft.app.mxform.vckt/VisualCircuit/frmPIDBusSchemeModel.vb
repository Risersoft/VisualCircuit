Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDBusSchemeModel
    Inherits clsFormDataModel
    Dim myViewBT1, myViewDev As clsViewModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("CtlBus")
        myViewBT1 = Me.GetViewModel("BT1")
        myViewDev = Me.GetViewModel("Dev")
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
        If frmMode = EnumfrmMode.acEditM Then
            Dim Sql As String = "select * from deslistpidunittot() where pidunitid = " & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

            Me.vBag = Me.PrepVBag(strXML, oView.ContextRow, "LOCATION,PIDCTLBUSID")
            Dim Location As String = Me.vBag("LOCATION")
            Dim PidCtlBusId As Integer = Me.vBag("PIDCTLBUSID")

            myViewDev.MainGrid.MainConf("sortcolsasc") = "ctlcat,legend"
            myViewDev.MainGrid.QuickConf("select pidctlid, Location, CtlCat, Legend from desListPIDCtl() where pidunitid=" & prepIDX & " and location='" & Location & "'", True, "1-1", , "Devices in this Scheme")

            myViewBT1.MainGrid.MainConf("sortcolsasc") = "legend,terminalname"
            Sql = "select panelcode,pidctlid,location,paneltype,istb,pidctltermid,pidctlbusid,Ctlcat,Legend, TerminalName,WireNum from desListPIDCtlTerm() where pidunitid=" & frmIDX & " and location='" & Location & "'"
            Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            myViewBT1.MainGrid.BindGridData(ds, 0)
            myViewBT1.MainGrid.QuickConf("", True, "1-1-1", , "Wire nos. used by this device")

            Sql = "select panelcode,pidctlid,location,paneltype,istb,pidctltermid,pidctlbusid,Ctlcat,Legend, TerminalName,WireNum from desListPIDCtlTerm() where pidunitid=" & frmIDX & " and location='" & Location & "' and pidctlbusid=" & PidCtlBusId
            myView.MainGrid.QuickConf(Sql, True, "1-1-1", , "Devices using the selected wire bus no.")

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim lastmode As EnumfrmMode = frmMode
        VSave = False
        If Me.Validate Then
            Try
                myContext.Provider.objSQLHelper.SaveResults(myView.MainGrid.myDS.Tables(0), "select pidctltermid,pidctlbusid from pidctlterm where pidctltermid=0")
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class

