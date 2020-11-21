Imports risersoft.app.mxform.eto

Public Class frmPIDCtlCopy
    Inherits frmMax
    Friend PanelCode As String

    Private Sub InitForm()
        myView.SetGrid(UltraGrid1)
        WinFormUtils.SetButtonConf(Me.btnOK)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("PidCtl"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If frmMode = EnumfrmMode.acEditM Then
            strXML = "<PARAMS PanelCode=""" & myUtils.cStrTN(PanelCode) & """/>"
            Dim objModel As frmPIDCtlCopyModel = Me.InitData("frmPIDCtlCopyModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then
                Me.Text = "Control Items for " & myRow("PidInfo")
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnSelMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelMB.Click
        myUtils.ChangeAll(myView.mainGrid.myDS.Tables(0).Select, "sysincl=1")
        myView.mainGrid.HighlightRows()
    End Sub
End Class
