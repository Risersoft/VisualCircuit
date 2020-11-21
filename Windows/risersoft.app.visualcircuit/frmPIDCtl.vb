Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmPIDCtl
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Public myViewLabItem As New clsWinView
    Dim dsTS As DataSet, myCtlItemID As Integer, oSort As clsWinSort, rCtl As DataRow, myViewLabText As New clsWinView
    Friend fp As frmPIDSchemePanel, myFuncsVC As New clsFuncsVC(Me.Controller)

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGrid1)
        oSort = New clsWinSort(myView, Nothing, Nothing, Nothing, "SortIndexCtl")
        myViewLabItem.SetGrid(Me.UltraGrid2)
        myViewLabText.SetGrid(Me.UltraGrid3)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("CtlTerm"))
            myViewLabItem.PrepEdit(NewModel.GridViews("LabItem"))
            myViewLabText.PrepEdit(NewModel.GridViews("LabText"), Me.btnAddLabelText, Me.btnDelLabelText)

            dsTS = Me.Model.DatasetCollection("dsTS")
            Me.codesys.SetConf(Me.dsCombo.Tables("Items"), Me.cmb_CtlItemID, Me.combo_ctlcat, Me.combo_ItemCode, Me.combo_Make, Me.combo_Spec, Me.combo_SuppSpec)
            myWinSQL.AssignCmb(Me.dsCombo, "Mtg", "", Me.combo_MtgID)
            Me.cmb_Location.ValueList = myFuncsVC.LocationList.ComboList

            Me.cmb_GAUse.ValueList = Me.Model.ValueLists("GaUse").ComboList
            myCtlItemID = myUtils.cValTN(myRow("ctlItemId"))
            Me.LoadCtlItemID(myCtlItemID)

            Me.CtlXMLVList1.myView.mainGrid.MainConf("showrownumber") = True
            Me.CtlXMLVList1.myView.mainGrid.MainConf("FORMATXML") = "<COL KEY=""STNUM"" CAPTION=""Starting No.""/><COL KEY=""ENDNUM"" CAPTION=""Ending No.""/>"
            Me.CtlXMLVList1.InitVList(myUtils.cStrTN(myRow("terminalnumxml")) & "<VALUE STNUM='1' ENDNUM='1'/>", "TERMINALNUM", "", EmptyGridEnum.acLast, "1-1", True)

            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmPIDCtlModel = Me.InitData("frmPIDCtlModel", oview, prepMode, prepIdx, strXML)
        fp = CType(oview.fParent, frmPIDSchemePanel)
        If Me.BindModel(objModel, oview) Then
            MyViewSortPosXML(myView.CreateSortPos, 0)
            WinFormUtils.FillPB(Me.PictureBox1, myRow("Compimagewd"))

            hasNewImg = False
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Sub PanelPic_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        myFuncsVC.DrawRuler(sender, e.Graphics)
    End Sub

    Private Sub reMakeBusList()
        Dim oRet As clsProcOutput = Me.GenerateIDOutput("pidctlterm", myUtils.cValTN(frmIDX))
        If oRet.Success Then
            Me.UpdateViewData(myView, oRet)
        Else
            MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Sub MyViewSortPosXML(SortPos As List(Of clsGridSortPos), pidctltermid As Integer)
        myView.mainGrid.myGrid.DisplayLayout.Bands(0).Columns("settypecode").ValueList = Me.Model.ValueLists("dicSetType").ComboList
        If Not SortPos Is Nothing Then myView.History.DoSortPos(SortPos)
        Dim gRow = myView.mainGrid.FindRow("pidctltermid=" & pidctltermid, myView.mainGrid.myDS)
        If Not gRow Is Nothing Then gRow.SelectAndActivate()
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            Me.txt_Legend.Text = Me.txt_Legend.Text.Trim
            If fp.PanelType = 4 AndAlso fp.FieldIns Then
                'Customer Field Area - dont check for same legend (ref ECS)
            ElseIf (Not rCtl Is Nothing) AndAlso ((Not myUtils.cBoolTN(rCtl("haswd"))) OrElse (myUtils.cBoolTN(rCtl("istb")))) Then
                'Non wiring diagram/TB item. Allow. (BH etc)
            Else
                Dim rr() As DataRow = fp.myView.mainGrid.myDS.Tables(0).Select("legend='" & Me.txt_Legend.Text & "'")
                If rr.Length > 0 AndAlso myUtils.cValTN(myRow("pidctlid")) > 0 AndAlso (rr(0)("pidctlid") <> myRow("pidctlid")) Then WinFormUtils.AddError(Me.txt_Legend, "Duplicate Legend")
            End If
            If Me.CanSave Then
                cm.EndCurrentEdit()
                If hasNewImg Then WinFormUtils.FillDSFromPB(myRow.Row, "compimagewd", Me.PictureBox1)
                myRow("Terminalnumxml") = Me.CtlXMLVList1.ValueListXML
                If Me.SaveModel() Then
                    Return True
                End If
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim rr() As DataRow
        Dim pidctltermid As Integer = myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("pidctltermid").Value)
        Dim strXML As String = "<PARAMS PidCtlBusId=""" & myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("PidCtlBusId").Value) & """ PidCtlTermId2=""" & myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("PidCtlTermId2").Value) & """/>"
        If (pidctltermid > 0) Then
            Using f As New frmPIDBusCtl
                If f.PrepForm(myView, EnumfrmMode.acEditM, myUtils.cValTN(myRow("pidunitid")), strXML) Then
                    If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                        Dim strXML2 = myView.CreateSortPos

                        rr = myView.mainGrid.myDS.Tables(0).Select("pidctltermid = " & pidctltermid)
                        rr(0)("pidctlbusid") = f.ContextRow.CellValue("pidctlbusid")
                        rr(0)("wirenum") = f.ContextRow.CellValue("wirenum")
                        If f.TerminalRow Is Nothing Then
                            rr(0)("pidctltermid2") = DBNull.Value
                        Else
                            rr(0)("pidctltermid2") = f.TerminalRow.CellValue("pidctltermid")
                        End If
                        reBuildImg(False)
                        Me.VSave()
                        Me.reMakeBusList()
                        MyViewSortPosXML(strXML2, pidctltermid)
                    End If
                End If
            End Using
        Else
            MsgBox("First save then proceed.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Friend Sub reBuildImg(Optional ByVal buildsort As Boolean = True)
        Dim r1, rr1(), rr2() As DataRow, ctlv1 As New ctlXMLVList
        If Me.FormPrepared Then
            If (Not Me.UltraTabControl2.Tabs("def").Visible) AndAlso myView.mainGrid.myGrid.Rows.Count > 0 Then
                If buildsort Then
                    Dim cnt As Integer = 0
                    For Each r1 In dsTS.Tables(2).Select("ctlitemid=" & myRow("ctlitemid"), "sortindex,ctlitemtermsetid")
                        cnt = cnt + 1
                        r1("sortindex") = cnt
                    Next
                    For Each r1 In myView.mainGrid.myDS.Tables(0).Select()
                        rr1 = dsTS.Tables(2).Select("ctlitemtermsetid=" & r1("ctlitemtermsetid"))
                        If rr1.Length > 0 Then
                            ctlv1.InitVList(myUtils.cStrTN(rr1(0)("terminalnumxml")) & "<VALUE TERMINALNAME='1'/>", "TERMINALNAME", "", EmptyGridEnum.acLast, "1", False)
                            rr2 = ctlv1.myView.mainGrid.myDS.Tables(0).Select("terminalname='" & r1("terminalname") & "'")
                            If rr2.Length > 0 Then
                                cnt = myUtils.cValTN(rr2(0)("sortindex"))
                                If cnt >= 100 Then cnt = cnt - 100
                                r1("sortindexctl") = myUtils.cValTN(rr1(0)("sortindex")) + cnt / 100
                            Else
                                r1("sortindexctl") = myUtils.cValTN(rr1(0)("sortindex"))
                            End If
                            r1("sortindex") = r1("sortindexctl")
                        End If
                    Next
                    oSort.reSort()
                End If
                If Me.PictureBox1.Image IsNot Nothing Then Me.PictureBox1.Image.Dispose()
                Me.PictureBox1.Image = myFuncsVC.BuildImage(myView.mainGrid.myDS.Tables(0), dsTS)
                hasNewImg = True
            End If
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Using f As New frmPIDCtlSelect
            f.fPC = Me
            If myUtils.cValTN(myRow("ctlitemid")) > 0 Then
                If f.PrepForm(myView, EnumfrmMode.acEditM, myRow("ctlitemid")) Then
                    If f.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Me.LoadCtlItemID(f.myView.ContextRow.CellValue("ctlitemid"))
                    End If
                End If
            Else
                If f.PrepForm(myView, EnumfrmMode.acAddM, "") Then
                    If f.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Me.LoadCtlItemID(f.myView.ContextRow.CellValue("ctlitemid"))
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub LoadCtlItemID(ByVal ctlitemid As Integer)
        Dim nr, r2, rr() As DataRow, gRow, gr2 As UltraGridRow, ctlv1 As New ctlXMLVList, str1 As String

        Me.cmb_CtlItemID.Value = ctlitemid
        Me.codesys.HandleCombo(Me.cmb_CtlItemID, IIf(frmMode = EnumfrmMode.acAddM, EnumWantEvent.acForceEvent, EnumWantEvent.acNoEvent))

        gRow = Me.cmb_CtlItemID.SelectedRow
        rCtl = myWinUtils.DataRowFromGridRow(gRow)
        If Not gRow Is Nothing Then
            Select Case fp.PanelType
                Case 1
                    Me.combo_MtgID.Value = gRow.Cells("mtgmbid").Value
                Case 2
                    Me.combo_MtgID.Value = gRow.Cells("mtgcpid").Value
            End Select
            gr2 = Me.combo_MtgID.SelectedRow
            r2 = myWinUtils.DataRowFromGridRow(gr2)
            If r2 Is Nothing Then str1 = "" Else str1 = myZip.ExpandString(r2("contentrtfzip"))
            Me.CtlRTF1.RTFText = str1
            Me.CtlRTF1.EditEnabled = False
        End If
        If (Not rCtl Is Nothing) AndAlso myUtils.cBoolTN(rCtl("istb")) Then
            Me.UltraTabControl2.Tabs("def").Visible = True
        Else
            Me.UltraTabControl2.Tabs("def").Visible = False
        End If
        If Not rCtl Is Nothing Then
            If myUtils.cBoolTN(rCtl("haswd")) Then
                Me.txt_Qty.Text = 1
                Me.txt_Qty.ReadOnly = True
            Else
                Me.txt_Qty.ReadOnly = False
            End If
            If myUtils.cBoolTN(rCtl("isold")) Then
                Me.LabelOK.Text = "Item is Old"
                Me.LabelOK.Appearance.ForeColor = Drawing.Color.Red
            Else
                Me.LabelOK.Text = "Item is Current"
                Me.LabelOK.Appearance.ForeColor = Drawing.Color.Green
            End If
        End If
        If myCtlItemID <> ctlitemid OrElse myView.mainGrid.myGrid.Rows.Count = 0 Then
            myCtlItemID = ctlitemid
            'TODO: match terminalsetid and maintain wire relationships
            myUtils.DeleteRows(myView.mainGrid.myDS.Tables(0).Select)
            If Me.UltraTabControl2.Tabs("def").Visible Then
                remakeTB()
            Else
                For Each r1 As DataRow In dsTS.Tables(2).Select("ctlitemid=" & ctlitemid, "sortindex")
                    ctlv1.InitVList(myUtils.cStrTN(r1("terminalnumxml")) & "<VALUE TERMINALNAME='1'/>", "TERMINALNAME", "", EmptyGridEnum.acLast, "1", False)
                    For Each r2 In ctlv1.myView.mainGrid.myDS.Tables(0).Select("", "sortindex")
                        nr = myUtils.CopyOneRow(r1, myView.mainGrid.myDS.Tables(0))
                        nr("terminalname") = r2("terminalname")
                        nr("sortindex") = myUtils.cValTN(r1("sortindex")) + myUtils.cValTN(0.1 * r2("sortindex"))
                        rr = dsTS.Tables(0).Select("ctlterminalsetid=" & r1("ctlterminalsetid"))
                        If rr.Length > 0 Then nr("settypecode") = rr(0)("settypecode")
                    Next
                Next
            End If
        End If
        Me.reBuildImg()
    End Sub

    Private Sub frmPIDCtlItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.frmMode = EnumfrmMode.acAddM Then Me.btnSelect_Click(Nothing, Nothing)
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim rr() As DataRow
        Dim pidctltermid As Integer = myUtils.cValTN(myView.mainGrid.myGrid.ActiveRow.Cells("pidctltermid").Value)
        If (pidctltermid > 0) Then
            Dim strXML = myView.CreateSortPos
            rr = myView.mainGrid.myDS.Tables(0).Select("pidctltermid = " & pidctltermid)
            rr(0)("pidctlbusid") = DBNull.Value
            rr(0)("wirenum") = DBNull.Value
            reBuildImg()
            Me.VSave()
            MyViewSortPosXML(strXML, pidctltermid)
        End If
    End Sub

    Private Sub remakeTB()
        Dim r1, nr, rr() As DataRow
        myUtils.ChangeAll(myView.mainGrid.myDS.Tables(0).Select, "incl=null")
        For Each r1 In Me.CtlXMLVList1.myView.mainGrid.myDS.Tables(0).Select("")
            For i As Integer = CInt(myUtils.cValTN(r1("stnum"))) To CInt(myUtils.cValTN(r1("endnum")))
                rr = myView.mainGrid.myDS.Tables(0).Select("terminalname='" & i & "'")
                If rr.Length > 0 Then
                    nr = rr(0)
                Else
                    nr = myUtils.CopyOneRow(r1, myView.mainGrid.myDS.Tables(0))
                    nr("terminalname") = i
                End If
                nr("sortindexctl") = i
                nr("incl") = True
            Next
        Next
        If myView.mainGrid.myDS.Tables(0).Select("isnull(incl,0)=0").Length > 0 Then
            If MsgBox("There are terminals that need to be deleted. Proceed ?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                myUtils.DeleteRows(myView.mainGrid.myDS.Tables(0).Select("isnull(incl,0)=0"))
            End If
        End If
        oSort.reSort()
    End Sub

    Private Sub btnMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMake.Click
        remakeTB()
    End Sub

    Private Sub btnAddLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLabel.Click
        Dim f As frmPIDCtlItem
        If Me.VSave Then
            f = New frmPIDCtlItem
            If f.PrepForm(myViewLabItem, EnumfrmMode.acAddM, "", "<PARAMS PIDCTLID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                If f.DoRefresh Then
                    Dim oRet As New clsProcOutput
                    Dim Params As New List(Of clsSQLParam)
                    Params.Add(New clsSQLParam("@pidctlid", frmIDX, GetType(Integer), False))
                    oRet = Me.GenerateParamsOutput("refresh", Params)
                    If oRet.Success Then
                        Me.UpdateViewData(myViewLabItem, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnDelLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelLabel.Click
        myViewLabItem.ContextRow = myViewLabItem.mainGrid.ActiveRow
        If Not myViewLabItem.ContextRow Is Nothing Then
            If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Dim oRet As New clsProcOutput
                Dim Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@pidctlid", frmIDX, GetType(Integer), False))
                Params.Add(New clsSQLParam("@pidctlitemid", myUtils.cValTN(myViewLabItem.ContextRow.CellValue("pidctlitemid")), GetType(Integer), False))
                oRet = Me.GenerateParamsOutput("deleterefresh", Params)
                If oRet.Success Then
                    Me.UpdateViewData(myViewLabItem, oRet)
                Else
                    MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                End If
            End If
        End If
    End Sub

    Private Sub btnReSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReBuild.Click
        Me.reBuildImg(True)
    End Sub

    Private Sub btnMoveDown_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveDown.Click
        Dim r1 As DataRow
        myView.ContextRow = myView.mainGrid.ActiveRow
        If (Not myView.ContextRow Is Nothing) Then
            r1 = myUtils.DataRowFromGridRow(myView.ContextRow)
            Me.moveupdown(r1, False)
        End If
    End Sub

    Private Sub btnMoveUp_Click(sender As System.Object, e As System.EventArgs) Handles btnMoveUp.Click
        Dim r1 As DataRow
        myView.ContextRow = myView.mainGrid.ActiveRow
        If (Not myView.ContextRow Is Nothing) Then
            r1 = myUtils.DataRowFromGridRow(myView.ContextRow)
            Me.moveupdown(r1, True)
        End If
    End Sub

    Private Sub moveupdown(r1 As DataRow, moveup As Boolean)
        Dim rr1(), rr2(), rShift, rBlank As DataRow
        Dim strXML = myView.CreateSortPos
        If moveup Then
            rr1 = r1.Table.Select("sortindexctl<" & r1("sortindexctl") & " and pidctlbusid is null", "sortindexctl")
        Else
            rr1 = r1.Table.Select("sortindexctl>" & r1("sortindexctl") & " and pidctlbusid is null", "sortindexctl")
        End If
        If rr1.Length > 0 Then
            Dim PIDCtlTermID As Integer = myUtils.cValTN(rr1(0)("pidctltermid"))
            If moveup Then
                rr2 = r1.Table.Select("sortindexctl<=" & r1("sortindexctl") & " and sortindexctl >= " & rr1(0)("sortindexctl"), "sortindexctl")
            Else
                rr2 = r1.Table.Select("sortindexctl>=" & r1("sortindexctl") & " and sortindexctl <= " & rr1(0)("sortindexctl"), "sortindexctl desc")
            End If
            For i As Integer = 0 To rr2.Length - 1
                rBlank = rr2(i)
                If i < rr2.Length - 1 Then rShift = rr2(i + 1) Else rShift = Nothing
                For Each str1 As String In New String() {"pidctlbusid", "wirenum", "pidctltermid2"}
                    If rShift Is Nothing Then
                        rBlank(str1) = DBNull.Value
                    Else
                        rBlank(str1) = rShift(str1)
                    End If
                Next
            Next
            reBuildImg(False)
            Me.VSave()
            Me.reMakeBusList()
            MyViewSortPosXML(strXML, PIDCtlTermID)
        End If
    End Sub
End Class
