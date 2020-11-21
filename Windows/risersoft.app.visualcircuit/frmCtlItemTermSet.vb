Imports System.Drawing
Imports Infragistics.Win.UltraWinEditors
Imports System.Windows.Forms
Imports risersoft.app.mxform.eto

Public Class frmCtlItemTermSet
    Private TheFont As New Font("Times New Roman", 14, FontStyle.Bold)
    Dim myFuncsVC As New clsFuncsVC(Me.Controller), dsTS As DataSet

    Public Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "TS", "", Me.cmb_CtlTerminalSetID)
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

            dsTS = Me.Model.DatasetCollection("dsTS")

            AddHandler CtlXMLVList1.myView.mainGrid.myGrid.AfterCellUpdate, AddressOf UltraGrid1_AfterCellUpdate
            AddHandler CtlXMLVList1.myView.mainGrid.myGrid.AfterRowsDeleted, AddressOf UltraGrid1_AfterCellUpdate
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmCtlItemTermSetModel = Me.InitData("frmCtlItemTermSetModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            Me.CtlXMLVList1.myView.mainGrid.MainConf("showrownumber") = True
            Me.CtlXMLVList1.InitVList(myUtils.cStrTN(myRow("terminalnumxml")) & "<VALUE TERMINALNAME='1'/>", "TERMINALNAME", "", EmptyGridEnum.acLast, "1", False)
            Me.BuildImage()
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Dim r As DataRow, str1 As String = ""
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            myRow("terminalnumxml") = Me.CtlXMLVList1.ValueListXML
            For Each r In Me.CtlXMLVList1.myView.mainGrid.myDS.Tables(0).Select
                str1 = str1 & IIf(str1 = "", "", ",") & r("terminalname")
            Next
            myRow("Terminalnums") = str1
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub BuildImage()
        Dim r As DataRow = myWinUtils.DataRowFromGridRow(Me.cmb_CtlTerminalSetID.SelectedRow)
        If r Is Nothing Then
            Me.PictureBox1.Image = Nothing
        Else
            Me.PictureBox1.Image = myFuncsVC.BuildImage(r, dsTS.Tables(1), Me.CtlXMLVList1.myView.mainGrid.myDS.Tables(0))
        End If
    End Sub

    Private Sub UltraGrid1_AfterCellUpdate(ByVal sender As Object, ByVal e As Object)
        If Me.FormPrepared Then
            Me.CtlXMLVList1.myView.mainGrid.myGrid.UpdateData()
            Me.BuildImage()
        End If
    End Sub

    Private Sub cmb_CtlTerminalSetID_RowSelected(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles cmb_CtlTerminalSetID.RowSelected
        If Me.FormPrepared Then Me.BuildImage()
    End Sub
End Class
