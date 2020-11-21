Imports Infragistics.Win.UltraWinTabControl
Imports risersoft.app.mxform.eto

Public Class frmPIDSchemePanel
    Inherits frmMax
    Friend PanelCode, PanelName As String, PanelType As Integer, FieldIns As Boolean, fp As frmPIDScheme

    Friend Sub SetPanel(r1 As DataRow)
        Me.PanelCode = r1("PanelCode")
        Me.PanelName = r1("PanelName")
        Me.PanelType = r1("PanelType")
        Me.FieldIns = myUtils.cBoolTN(r1("FieldIns"))
    End Sub

    Public Sub initForm()
        Me.UltraTabControl1.Style = UltraTabControlStyle.Wizard
        myView.SetGrid(Me.UltraGrid1)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("PidCTL"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If frmMode = EnumfrmMode.acEditM Then
            strXML = "<PARAMS PanelCode=""" & myUtils.cStrTN(PanelCode) & """ PanelType=""" & myUtils.cValTN(PanelType) & """/>"
            Dim objModel As frmPIDSchemePanelModel = Me.InitData("frmPIDSchemePanelModel", oview, prepMode, prepIdx, strXML)
            If Me.BindModel(objModel, oview) Then
                fp = CType(oview.fParent, frmPIDScheme)
                FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Private Sub reFreshViews(Key As String, PidCtlId As Integer)
        For Each oView As clsWinView In New clsWinView() {myView}
            Dim oRet As New clsProcOutput
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@PidUnitId", frmIDX, GetType(Integer), False))
            Params.Add(New clsSQLParam("@PanelType", myUtils.cValTN(PanelType), GetType(Integer), False))
            Params.Add(New clsSQLParam("@PanelCode", "'" & myUtils.cStrTN(PanelCode) & "'", GetType(String), False))
            Params.Add(New clsSQLParam("@PidCtlId", myUtils.cValTN(PidCtlId), GetType(Integer), False))
            oRet = Me.GenerateParamsOutput(Key.Trim.ToLower, Params)
            If oRet.Success Then
                Me.UpdateViewData(oView, oRet)
            Else
                MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        Next
    End Sub

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

    Private Sub btnAddDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDoc.Click
        Dim f As New frmPIDCtl, oView As clsWinView
        oView = Me.oSelView
        If Not oView Is Nothing Then
            If f.PrepForm(oView, EnumfrmMode.acAddM, "", "<PARAMS LOCATION=""" & PanelCode & """ PIDUNITID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                Me.reFreshViews("refresh", 0)
            End If
        End If
    End Sub

    Private Sub btn_EditDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EditDoc.Click
        Dim oView As clsWinView, f As frmPIDCtl
        oView = Me.oSelView
        If Not oView Is Nothing Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If Not oView.ContextRow Is Nothing Then
                f = New frmPIDCtl
                If f.PrepForm(oView, EnumfrmMode.acEditM, oView.ContextRow.CellValue("pidctlid")) Then
                    f.ShowDialog()
                    Me.reFreshViews("refresh", 0)
                End If
            End If
        End If
    End Sub

    Private Sub btnDelDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelDoc.Click
        Dim oView As clsWinView
        oView = Me.oSelView
        If Not oView Is Nothing Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If Not oView.ContextRow Is Nothing Then
                If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                    Me.reFreshViews("deleterefresh", myUtils.cValTN(oView.ContextRow.CellValue("pidctlid")))
                End If
            End If
        End If
    End Sub

    Private Sub btnCopyWireNos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyWireNos.Click
        Dim str1 As String = ""
        If myUtils.IsInList(PanelType, 1, 2) Then str1 = fp.myCtl.WireNos(Me.frmIDX, PanelCode)
        If str1.Trim.Length > 0 Then My.Computer.Clipboard.SetText(str1)
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(sender As System.Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        Me.Panelbtn.Visible = (Not myUtils.IsInList(e.Tab.Key, "matlist"))
    End Sub

    Private Function oSelView() As clsWinView
        Dim oView As clsWinView = Nothing
        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "det"
                oView = myView
        End Select
        Return oView
    End Function

    Private Sub btnAssignBus_Click(sender As System.Object, e As System.EventArgs) Handles btnAssignBus.Click
        Dim f As New frmGrid, Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(frmIDX), GetType(Integer), False))
        Dim Model As clsViewModel = Me.GenerateParamsModel("pidctlbus", Params)
        f.myView.PrepEdit(Model)
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            'i know the panel and i know the bus, call up PIDSchemeBus
            Dim f2 As New frmPIDBusScheme
            f2.rBus = myUtils.DataRowFromGridRow(f.myView.ContextRow)
            If f2.PrepForm(myView, EnumfrmMode.acEditM, frmIDX) Then
                f2.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        Dim oView As clsWinView, f As frmPIDCtl
        oView = Me.oSelView
        If Not oView Is Nothing Then
            oView.ContextRow = oView.mainGrid.ActiveRow
            If Not oView.ContextRow Is Nothing Then
                f = New frmPIDCtl
                If f.PrepForm(oView, EnumfrmMode.acCopyM, oView.ContextRow.CellValue("pidctlid")) Then
                    f.ShowDialog()
                    Me.reFreshViews("refresh", 0)
                End If
            End If
        End If
    End Sub

    Private Sub btnCopyMB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyMB.Click
        Dim PidUnitId As Integer, gRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        gRow = fp.pView.mainGrid.myGrid.ActiveRow
        If (Not gRow Is Nothing) AndAlso (gRow.Band.Columns.Exists("PidUnitId")) Then
            PidUnitId = gRow.Cells("PidUnitId").Value
            If frmIDX = PidUnitId Then
                MsgBox("Please select a different work order", MsgBoxStyle.OkOnly, myWinApp.Vars("appname"))
            Else
                Dim f As New frmGrid, Params As New List(Of clsSQLParam)
                Params.Add(New clsSQLParam("@PidUnitID", PidUnitId, GetType(Integer), False))
                Dim Model As clsViewModel = Me.GenerateParamsModel("pidctlpanel", Params)
                f.myView.PrepEdit(Model)
                f.Text = "Please select a Panel to Copy From"
                If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                    Using f2 As New frmPIDCtlCopy

                        f2.PanelCode = myUtils.cStrTN(f.myView.ContextRow.CellValue("panelcode"))
                        f2.UltraTabControl1.Tabs(0).Text = myUtils.cStrTN(f.myView.ContextRow.CellValue("panelname"))
                        If f2.PrepForm(myView, EnumfrmMode.acEditM, PidUnitId) Then
                            If f2.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                                Params.Clear()
                                Params.Add(New clsSQLParam("@RefPIDUnitID", myUtils.cValTN(PidUnitId), GetType(Integer), False))
                                Params.Add(New clsSQLParam("@PidUnitId", myUtils.cValTN(frmIDX), GetType(Integer), False))
                                Params.Add(New clsSQLParam("@PanelCode", "'" & myUtils.cStrTN(Me.PanelCode) & "'", GetType(String), False))

                                Dim ds As New DataSet
                                myUtils.AddTable(ds, f2.myView.mainGrid.myDS, "CopyCtl", 0)
                                myUtils.AddTable(ds, myView.mainGrid.myDS, "PIDCtl", 0)
                                Dim oRet As clsProcOutput = Me.GenerateDataParamsOutput("copymb", ds, Params)
                                If oRet.Success = True Then
                                    Me.reFreshViews("refresh", 0)
                                End If
                            End If
                        End If
                    End Using

                End If

            End If
        End If
    End Sub
End Class
