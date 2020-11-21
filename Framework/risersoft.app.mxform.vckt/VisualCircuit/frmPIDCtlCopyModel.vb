Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmPIDCtlCopyModel
    Inherits clsFormDataModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("PidCtl")
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

            Me.vBag = Me.PrepVBag(strXML, oView.ContextRow, "PanelCode")
            Dim PanelCode As String = Me.vBag("PanelCode")

            myView.Mode = EnumViewMode.acSelectM : myView.MultiSelect = True
            myView.MainGrid.MainConf("formatxml") = "<COL KEY='ctlitem' CAPTION='Item'/>"
            myView.MainGrid.QuickConf("select pidctlid, descripprefix,descripsuffix, pidunitid,ctlitemid, ItemCode, Item, Spec, Make, SuppSpec, Legend, Mtg, Qty from deslistpidctl() where location='" & PanelCode & "' and pidunitid=" & myUtils.cValTN(frmIDX), True, "1-3.5-1.25-0.75-1.5-0.75-0.5-0.5", True)
            myView.MainGrid.PrepEdit("<BAND INDEX=""0""/>", EnumEditType.acEditOnly)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            VSave = True
        End If
    End Function
End Class
