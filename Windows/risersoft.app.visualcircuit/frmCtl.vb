Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmCtl
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim myViewTS, myViewMG As New clsWinView, myFuncsVC As clsFuncsVC, dsTS As DataSet
    Dim WithEvents oSort As clsWinSort

    Private Sub PanelPic_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        myFuncsVC.DrawRuler(sender, e.Graphics)
    End Sub

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGrid1)
        myViewTS.SetGrid(Me.UltraGrid2)
        myViewMG.SetGrid(Me.UltraGrid3)

        myFuncsVC = New clsFuncsVC(Me.Controller)
        dsTS = myFuncsVC.dsTS
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("Items"))
            myViewTS.PrepEdit(NewModel.GridViews("TS"))
            myViewMG.PrepEdit(NewModel.GridViews("MG"))

            Me.reMtgCode()
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmCtlModel = Me.InitData("frmCtlModel", oview, prepMode, prepIdx, strXML)

        If Me.BindModel(objModel, oView) Then
            Me.cmb_Loc.ValueList = myFuncsVC.LocationList.ComboList
            Me.cmb_ctlmake.ValueList = Me.Model.ValueLists("CtlMake").ComboList
            Me.codesys.SetConf(Me.dsCombo.Tables("Items"), Me.combo_ItemId, Me.combo_ItemName, Me.combo_ItemUnit)
            myWinSQL.AssignCmb(Me.dsCombo, "Cat", "", Me.cmb_ctlcatid)

            If prepMode = EnumfrmMode.acEditM Then
                CtlItemVMS1.ItemVMSID = myUtils.cValTN(myRow("ItemVmsId"))
                combo_ItemId.Value = Me.CtlItemVMS1.myParentID
            End If
            Me.codesys.HandleCombo(Me.combo_ItemId, IIf(frmMode = EnumfrmMode.acAddM, EnumWantEvent.acForceEvent, EnumWantEvent.acNoEvent))

            oSort = New clsWinSort(myView, Me.btnMoveUp, Me.btnMoveDown, Me.btnRenum, "sortindex")
            oSort.reSort()

            If myUtils.cValTN(myRow("ItemVmsId")) > 0 Then
                Me.UltraTabControl2.Tabs(0).Selected = True
            Else
                Me.UltraTabControl2.Tabs(1).Selected = True
            End If

            Dim dt2 As DataTable = myFuncsVC.dtLugType()
            If Not dt2 Is Nothing Then Me.cmb_lugtype.ValueList = myWinSQL2.VListFromTable(dt2).ComboList

            Me.reBuildImg()
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.UltraTabControl2.SelectedTab.Index = 0 Then
                If myUtils.NullNot(combo_ItemId.Value) Then WinFormUtils.AddError(combo_ItemId, "Select Item Code")
                If Me.CtlItemVMS1.ItemVMSID = 0 Then WinFormUtils.AddError(Me.CtlItemVMS1, "Select Item Specification")
            End If

            If Me.CanSave Then
                myRow("itemvmsid") = Me.CtlItemVMS1.ItemVMSID
                WinFormUtils.FillDSFromPB(myRow.Row, "compimagewd", Me.PictureBox1)
                If Me.SaveModel() Then
                    Return True
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        Me.CtlItemVMS1.InitVMS(myUtils.cValTN(combo_ItemId.Value), , EnumWantEvent.acForceEvent)
    End Sub

    Private Sub btnAddTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTS.Click
        Dim f As New frmTerminalSet
        If f.PrepForm(myViewTS, EnumfrmMode.acAddM, "") Then
            f.ShowDialog()
            RefreshGrid(myViewTS, "refreshts", 0)
        End If
    End Sub

    Private Sub btnEditTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTS.Click
        Dim f As frmTerminalSet
        myViewTS.ContextRow = myViewTS.mainGrid.ActiveRow
        If Not myViewTS.ContextRow Is Nothing Then
            f = New frmTerminalSet
            If f.PrepForm(myViewTS, EnumfrmMode.acEditM, myViewTS.ContextRow.CellValue("ctlterminalsetid")) Then
                f.ShowDialog()
                RefreshGrid(myViewTS, "refreshts", 0)
            End If
        End If
    End Sub

    Private Sub btnDelTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelTS.Click
        myViewTS.ContextRow = myViewTS.mainGrid.ActiveRow
        If Not myViewTS.ContextRow Is Nothing Then
            RefreshGrid(myViewTS, "deleterefreshts", myUtils.cValTN(myViewTS.ContextRow.CellValue("ctlterminalsetid")))
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As New frmCtlItemTermSet
        If Me.VSave Then
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS CTLITEMID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                RefreshGrid(myView, "refreshitem", frmIDX)
                Me.reBuildImg()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim f As frmCtlItemTermSet
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            f = New frmCtlItemTermSet
            If f.PrepForm(myView, EnumfrmMode.acEditM, myView.ContextRow.CellValue("ctlitemtermsetid")) Then
                f.ShowDialog()
                RefreshGrid(myView, "refreshitem", frmIDX)
                Me.reBuildImg()
            End If
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@ctlitemtermsetid", myUtils.cValTN(myView.ContextRow.CellValue("ctlitemtermsetid")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@ctlitemid", frmIDX, GetType(Integer), False))
            Dim oRet As clsProcOutput = GenerateParamsOutput("deleterefreshitem", Params)
            If oRet.Success Then
                Me.UpdateViewData(myView, oRet)
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
            Me.reBuildImg()
        End If
    End Sub

    Private Sub reBuildImg()
        If myView.mainGrid.myGrid.Rows.Count > 0 Then
            Me.PictureBox1.Image = myFuncsVC.BuildImage(myView.mainGrid.myDS.Tables(0), dsTS)
        Else
            Me.PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub btnAddMG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMG.Click
        Dim f As New frmCtlMtg
        If f.PrepForm(myViewMG, EnumfrmMode.acAddM, "") Then
            f.ShowDialog()
            RefreshGrid(myViewMG, "refreshmg", 0)
            Me.reMtgCode()
        End If
    End Sub

    Private Sub btnEditmg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditMG.Click
        Dim f As frmCtlMtg
        myViewMG.ContextRow = myViewMG.mainGrid.ActiveRow
        If Not myViewMG.ContextRow Is Nothing Then
            f = New frmCtlMtg
            If f.PrepForm(myViewMG, EnumfrmMode.acEditM, myViewMG.ContextRow.CellValue("ctlmtgid")) Then
                f.ShowDialog()
                RefreshGrid(myViewMG, "refreshmg", 0)
                Me.reMtgCode()
            End If
        End If
    End Sub

    Private Sub btnDelMG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelMG.Click
        myViewMG.ContextRow = myViewMG.mainGrid.ActiveRow
        If Not myViewMG.ContextRow Is Nothing Then
            RefreshGrid(myViewMG, "deleterefreshmg", myUtils.cValTN(myViewMG.ContextRow.CellValue("ctlmtgid")))
            Me.reMtgCode()
        End If
    End Sub

    Private Sub reMtgCode()
        Dim dt As DataTable, val1 As Integer
        Dim oRet As clsProcOutput = GenerateIDOutput("ctlmtgmbcp", 0)
        If oRet.Success Then
            dt = oRet.Data.Tables("CtlMtgMB")
            val1 = myUtils.cValTN(Me.cmb_MtgMBID.Value)
            myWinSQL.AssignCmb(dt.DataSet, dt.TableName, "", Me.cmb_MtgMBID)
            If val1 > 0 Then Me.cmb_MtgMBID.Value = val1

            dt = oRet.Data.Tables("CtlMtgCP")
            val1 = myUtils.cValTN(Me.cmb_MtgCPID.Value)
            myWinSQL.AssignCmb(dt.DataSet, dt.TableName, "", Me.cmb_MtgCPID)
            If val1 > 0 Then Me.cmb_MtgCPID.Value = val1
        End If
    End Sub

    Private Sub oSort_OnMove() Handles oSort.OnMove
        reBuildImg()
    End Sub

    Private Sub RefreshGrid(View As clsWinView, key As String, ID As Integer)
        Dim oRet As New clsProcOutput
        oRet = Me.GenerateIDOutput(key.Trim.ToLower, ID)
        If oRet.Success Then
            Me.UpdateViewData(View, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub
End Class
