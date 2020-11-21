Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto

Public Class frmPIDPanel
    Inherits frmMax

    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1CtlPanel)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("CtlPanel"), Me.btnAddPanel, Me.btnDelPanel)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            Dim objModel As frmPIDPanelModel = Me.InitData("frmPIDPanelModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then
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
                Me.DoRefresh = True
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnRenamePanel_Click(sender As Object, e As EventArgs) Handles btnRenamePanel.Click
        If Me.frmMode = EnumfrmMode.acEditM Then
            If myView.mainGrid.myGrid.ActiveRow Is Nothing Then
                WinFormUtils.AddError(Me.UltraGrid1CtlPanel, "Select Panel")
            Else
                Dim NewPanelCode As String = InputBox("Please enter new panel code", myWinApp.Vars("appname"))
                Dim Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@pidunitid", frmIDX, GetType(Integer), False))
                Params.Add(New clsSQLParam("@OldPanelCode", "'" & myUtils.cStrTN(myView.mainGrid.myGrid.ActiveRow.Cells("PanelCode").Value) & "'", GetType(String), False))
                Params.Add(New clsSQLParam("@NewPanelCode", "'" & myUtils.cStrTN(NewPanelCode) & "'", GetType(String), False))
                Dim oRet As clsProcOutput = Me.GenerateParamsOutput("rename", Params)
                If oRet.Success Then
                    Me.PrepForm(Me.pView, Me.frmMode, Me.frmIDX, Me.Controller.Data.VarBagXML(Me.vBag))
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

End Class
