Imports Infragistics.Win.UltraWinGrid
Imports System.Windows.Forms
Imports risersoft.app.mxform.eto

Public Class frmPIDMultiBusList
    Inherits frmMax
    Dim dicBus As New clsCollecString(Of frmPIDMultiBus)

    Private Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim f1 As frmPIDMultiBus
        Me.FormPrepared = False
        If frmMode = EnumfrmMode.acEditM Then
            Dim objModel As frmPIDMultiBusListModel = Me.InitData("frmPIDMultiBusListModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then
                Me.Text = "Control Scheme for " & myRow("pidinfo")
                Dim dt1 As DataTable = Me.Model.DatasetCollection("PidCtlBus").Tables(0)

                For Each r1 As DataRow In dt1.Select("", "wirenum")
                    f1 = New frmPIDMultiBus
                    f1.pidctlbusid = r1("pidctlbusid")

                    uTab = Me.UltraTabControl2.Tabs.Add(myUtils.cStrTN(r1("pidctlbusid")), r1("wirenum"))
                    f1.AddtoTab(Me.UltraTabControl2, uTab.Key, True)
                    f1.PrepForm(myView, EnumfrmMode.acEditM, frmIDX)

                    dicBus.Add(r1("pidctlbusid"), f1)
                Next
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        For Each f1 As frmPIDMultiBus In dicBus.Values
            f1.ValidateData()
        Next
        If Me.CanSave Then
            cm.EndCurrentEdit()
            For Each f1 As frmPIDMultiBus In dicBus.Values
                f1.VSave()
            Next
            VSave = True
        End If
    End Function
End Class
