Imports System.Drawing
Imports Infragistics.Win.UltraWinEditors
Imports System.IO
Imports risersoft.app.mxform.eto

Public Class frmCtlMtg
    Public Sub InitForm()
        myView.SetGrid(Me.UltraGrid1)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("MtgItem"))
            myView.mainGrid.PrepEntSelect("<SYS ID=""ITEMID""/>", Me.btnDel, Me.btnSel)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmCtlMtgModel = Me.InitData("frmCtlMtgModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If Not myUtils.NullNot(myRow("contentrtfzip")) Then Me.CtlRTF1.RTFText = myZip.ExpandString(myRow("contentrtfzip"))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        myRow("contentrtfzip") = myZip.CompressString(Me.CtlRTF1.RTFText)
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function
End Class
