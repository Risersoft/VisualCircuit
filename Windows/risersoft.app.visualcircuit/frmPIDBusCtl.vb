Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto

Public Class frmPIDBusCtl
    Public TerminalRow As clsRow, ContextRow As clsRow
    Dim myViewBT1, myViewBT2, myViewDev As New clsWinView
    Dim ds As DataSet, fp As frmPIDCtl

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGrid1)
        myViewBT1.SetGrid(Me.UltraGrid2)
        myViewBT2.SetGrid(Me.UltraGrid4)
        myViewDev.SetGrid(Me.UltraGrid3)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            Me.FormPrepared = False

            myView.PrepEdit(NewModel.GridViews("CtlBus"), Me.btnAddDoc, Me.btnDelDoc)
            myView.mainGrid.myGrid.DisplayLayout.Bands(0).Override.FilterUIType = FilterUIType.HeaderIcons
            myView.mainGrid.myGrid.DisplayLayout.Bands(0).Override.FilterEvaluationTrigger = FilterEvaluationTrigger.OnCellValueChange
            myView.mainGrid.myGrid.DisplayLayout.Bands(0).Override.FilterRowPrompt = "Filter"

            myViewBT1.PrepEdit(NewModel.GridViews("BT1"))
            myViewBT2.PrepEdit(NewModel.GridViews("BT2"))
            myViewDev.PrepEdit(NewModel.GridViews("Dev"))

            Me.FormPrepared = True

        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim gRow As UltraGridRow
        Me.FormPrepared = False
        If frmMode = EnumfrmMode.acEditM Then
            Dim objModel As frmPIDBusCtlModel = Me.InitData("frmPIDBusCtlModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then
                fp = pView.fParentWin
                Me.vBag = myWinData.VarBag(strXML)
                If (Me.vBag.Contains("PidCtlBusId")) AndAlso myUtils.cValTN(Me.vBag("PidCtlBusId")) > 0 Then
                    gRow = myWinUtils.FindRow(myView.mainGrid.myGrid, "PidCtlBusId", Me.vBag("PidCtlBusId"))
                    Me.SetBT1Filter(gRow)
                Else
                    Me.SetBT1Filter(Nothing)
                End If
                Me.SetBT2Filter(Nothing)
                PrepForm = True

                If fp.myFuncsVC.WBSortpos IsNot Nothing Then myView.History.DoSortPos(fp.myFuncsVC.WBSortpos)
                If Not gRow Is Nothing Then myWinUtils.SelectRow(myView.mainGrid.myGrid, gRow)

                'for pidctltermid2 in case of multitfmb
                If (Me.vBag.Contains("PidCtlTermId2")) AndAlso myUtils.cValTN(Me.vBag("PidCtlTermId2")) > 0 Then
                    gRow = myWinUtils.FindRow(myViewBT1.mainGrid.myGrid, "PidCtlTermId", Me.vBag("PidCtlTermId2"))
                Else
                    gRow = Nothing
                End If
                If Not gRow Is Nothing Then myWinUtils.SelectRow(myViewBT1.mainGrid.myGrid, gRow)
                Me.FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Dim oView As clsWinView
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            TerminalRow = Nothing
            If Me.UltraTabControl1.SelectedTab.Index = 0 Then
                If myView.mainGrid.myGrid.ActiveRow Is Nothing Then WinFormUtils.AddError(Me.UltraGrid1, "Select Bus")
                If Me.LabelMultiTFMB.Visible AndAlso myViewBT1.mainGrid.myGrid.ActiveRow Is Nothing Then WinFormUtils.AddError(Me.UltraGrid2, "Select Terminal")
            ElseIf Me.UltraTabControl1.SelectedTab.Index = 1 Then
                If myViewBT2.mainGrid.myGrid.ActiveRow Is Nothing Then WinFormUtils.AddError(Me.UltraGrid4, "Select Bus")
            End If
            If Me.LabelMultiTFMB.Visible Then
                If Me.UltraTabControl1.SelectedTab.Index = 0 Then
                    TerminalRow = clsDummyRow.FromDataRow(Nothing, myWinUtils.DataRowFromGridRow(myViewBT1.mainGrid.myGrid.ActiveRow))
                    oView = myViewBT1
                Else
                    TerminalRow = clsDummyRow.FromDataRow(Nothing, myWinUtils.DataRowFromGridRow(myViewBT2.mainGrid.myGrid.ActiveRow))
                    oView = myViewBT2
                End If
                If Not myUtils.cBoolTN(TerminalRow.CellValue("istb")) Then WinFormUtils.AddError(oView.mainGrid.myGrid, "Select a terminal block")
            End If

            If Me.CanSave Then
                If Me.UltraTabControl1.SelectedTab.Index = 0 Then
                    ContextRow = clsDummyRow.FromDataRow(Nothing, myUtils.DataRowFromGridRow(myView.mainGrid.ActiveRow))
                Else
                    ContextRow = clsDummyRow.FromDataRow(Nothing, myUtils.DataRowFromGridRow(myViewBT2.mainGrid.ActiveRow))
                End If
                If Me.SaveModel() Then
                    If myUtils.NullNot(ContextRow.CellValue("pidctlbusid")) Then
                        Dim rr() = myView.mainGrid.myDS.Tables(0).Select("wirenum='" & myUtils.cStrTN(ContextRow.CellValue("wirenum")) & "'")
                        If rr.Length > 0 Then ContextRow = clsDummyRow.FromDataRow(rr(0))
                    End If
                    fp.myFuncsVC.WBSortpos = myView.CreateSortPos
                    Return True
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub UltraGrid1_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid1.AfterRowActivate
        If (Me.FormPrepared = True) AndAlso (Not Me.UltraTabControl1.SelectedTab Is Nothing) AndAlso (Me.UltraTabControl1.SelectedTab.Index = 0) Then
            Me.SetBT1Filter(Me.UltraGrid1.ActiveRow)
        End If
    End Sub

    Private Sub SetBT1Filter(ByVal gRow As UltraGridRow)
        If Not myViewBT1 Is Nothing Then
            If gRow Is Nothing Then
                myViewBT1.mainGrid.myDv.RowFilter = "0=1"
                Me.SetBusType(0)
            Else
                myViewBT1.mainGrid.myDv.RowFilter = "PidCtlBusId=" & myUtils.cValTN(gRow.Cells("PidCtlBusId").Value)
                Me.SetBusType(myUtils.cValTN(gRow.Cells("PidCtlBusId").Value))
            End If
        End If
    End Sub

    Private Sub SetBT2Filter(ByVal gRow As UltraGridRow)
        If gRow Is Nothing Then
            myViewBT2.mainGrid.myDv.RowFilter = "0=1"
        Else
            myViewBT2.mainGrid.myDv.RowFilter = "(PidCtlBusId is not null) and pidctlid=" & myUtils.cValTN(gRow.Cells("pidctlid").Value)
        End If
    End Sub

    Private Sub UltraGrid3_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid3.AfterRowActivate
        If Me.FormPrepared = True Then Me.SetBT2Filter(Me.UltraGrid3.ActiveRow)
    End Sub

    Private Sub UltraGrid4_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UltraGrid4.AfterRowActivate
        If (Me.FormPrepared = True) AndAlso (Not Me.UltraTabControl1.SelectedTab Is Nothing) AndAlso (Me.UltraTabControl1.SelectedTab.Index = 1) Then
            If Me.UltraGrid4.ActiveRow Is Nothing Then
                Me.SetBusType(0)
            Else
                Me.SetBusType(myUtils.cValTN(Me.UltraGrid4.ActiveRow.Cells("PidCtlBusId").Value))
            End If
        End If
    End Sub

    Private Sub SetBusType(ByVal PidCtlBusId As Integer)
        Me.LabelMultiTFMB.Visible = False
        Dim multibus As Boolean = fp.fp.fp.myCtl.SetBusType(myView.mainGrid.myDS.Tables(0), myViewBT1.mainGrid.myDS.Tables(0), PidCtlBusId)
        If multibus AndAlso (myUtils.cBoolTN(fp.cmb_CtlItemID.SelectedRow.Cells("istb").Value) OrElse fp.fp.PanelType = 4) Then Me.LabelMultiTFMB.Visible = True
    End Sub
End Class
