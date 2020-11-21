Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto
Imports risersoft.app.mxent
Public Class frmPIDCtlItem
    Inherits frmMax
    Public Sub initForm()
        myView.SetGrid(Me.UltraGrid1)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.DoRefresh = False
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("items"))

            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPIDCtlItemModel = Me.InitData("frmPIDCtlItemModel", oview, prepMode, prepIdx, strXML)
        Me.combosubcat.Value = DBNull.Value
        If Me.BindModel(objModel, oview) Then
            myWinSQL.AssignCmb(Me.dsCombo, "SubCat", "", Me.combosubcat, , , True)
            Dim gr As UltraGridRow = myWinUtils.FindRow(Me.combosubcat, "SubCatName", "Labels", False)
            If Not gr Is Nothing Then
                Me.combosubcat.Value = myUtils.cValTN(gr.Cells("SubCatId").Value)
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
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

    Private Sub SetItemGrid(ByVal subcatid As Integer)
        If Me.FormPrepared = True Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@SubCatId", myUtils.cValTN(subcatid), GetType(Integer), False))
            Dim oRet As New clsProcOutput
            oRet = Me.GenerateParamsOutput("items", Params)
            If oRet.Success Then
                Me.UpdateViewData(myView, oRet)
                myView.mainGrid.MainConf("FORMATXML") = myAttribBase.ParamFormatXML(Me.Controller, myView.mainGrid.myDS.Tables("attrib"))
                Dim str1 As String = myAttribBase.ParamWidthString(Me.Controller, myView.mainGrid.myDS.Tables("attrib"), "subcatid", subcatid)
                myView.mainGrid.QuickConf("", True, "1-4" & str1, True)

            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub combosubcat_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combosubcat.ValueChanged
        If Me.FormPrepared Then SetItemGrid(Me.combosubcat.Value)
    End Sub
End Class
