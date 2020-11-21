Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDBusCtlModel
    Inherits clsFormDataModel
    Dim myViewBT1, myViewBT2, myViewDev As clsViewModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("CtlBus")
        myViewBT1 = Me.GetViewModel("BT1")
        myViewBT2 = Me.GetViewModel("BT2")
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
            Dim Sql As String = "select * from desListPidUnittot() where PidUnitId = " & prepIDX
            Me.InitData(Sql, "", oView, prepMode, prepIDX, strXML)

            myView.MainGrid.MainConf("showrownumber") = True
            myView.MainGrid.MainConf("sortcolsasc") = "wirenum"
            myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""Color"" VLIST=""Red|Yellow|Blue|Black;Black (AC)|Grey;Grey (DC)|Green;Green (Earth)""/>"
            myView.MainGrid.QuickConf("select pidctlbusid, multitfmb,pidunitid, WireNum, SQMM, Color from PIDCtlBus where pidunitid=" & myUtils.cValTN(frmIDX), True, "1-1-1.5", True)
            myView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""PidCtlBus"" IDFIELD=""PIDCTLBUSID""><COL KEY=""pidunitid, WireNum, SQMM, Color,multitfmb""/></BAND>", EnumEditType.acCommandAndEdit)

            Sql = "select panelcode,pidctlid,paneltype,istb,pidctltermid,pidctlbusid,Ctlcat,Location,Legend, TerminalName,WireNum from desListPIDCtlTerm() where pidunitid=" & frmIDX
            Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
            myViewBT1.MainGrid.BindGridData(ds, 0)
            myViewBT1.MainGrid.QuickConf("", True, "1-1-1-1-0", , "Devices using the selected wire bus no.")

            myViewBT2.MainGrid.BindGridData(ds, 0)
            myViewBT2.MainGrid.QuickConf("", True, "1-1", , "Wire nos. used by this device")

            myViewDev.MainGrid.QuickConf("select pidctlid, Location, CtlCat, Legend from desListPIDCtl() where PidUnitId=" & prepIDX, True, "1-1", , "Devices in this Scheme")
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        myView.MainGrid.CheckValid("WireNum")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim lastmode As EnumfrmMode = frmMode
        VSave = False
        If Me.Validate Then
            Try
                Me.myView.MainGrid.SaveChanges(, "PidUnitId=" & frmIDX)
                VSave = True
            Catch e As Exception
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
