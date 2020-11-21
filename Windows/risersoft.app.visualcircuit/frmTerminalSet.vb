Imports System.Drawing
Imports Infragistics.Win.UltraWinGrid
Imports System.Windows.Forms
Imports risersoft.app.mxform.eto
Imports risersoft.shared.Extensions
Public Class frmTerminalSet
    Dim myFuncsVC As clsFuncsVC
    Dim zoomFactor As Decimal() = {0.25, 0.33, 0.5, 0.66, 0.8, 1, 1.25, 1.5, 2.0, 2.5, 3.0}
    Dim surFace As DesignSurfaceExt, wireBag As New clsConf, TermBag As New clsConf
    Dim WithEvents rootComponent As Form

    Public Sub InitForm()
        myView.SetGrid(Me.UltraGrid1)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        myFuncsVC = New clsFuncsVC(Me.Controller)
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        Me.cmb_SetTypeCode.Items.Clear()
        Me.cmb_SetTypeCode.ValueList = myWinSQL2.VListFromDic(myFuncsVC.dicSetType).ComboList

        Me.PictureBox1.BackColor = Color.LightYellow
        Me.PanelPic.BackColor = Me.PictureBox1.BackColor
        Me.PictureBox1.Location = New Point(25, 25)

        surFace = New DesignSurfaceExt()
        surFace.UseSnapLines()
        rootComponent = DirectCast(surFace.CreateRootComponent(GetType(Form), New Size(400, 400)), Form)
        rootComponent.BackColor = Me.PanelPic.BackColor
        rootComponent.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        rootComponent.Text = "Root Component hosted by the DesignSurface N.1"
        rootComponent.Dock = DockStyle.Fill
        '- step.3

        Dim view As Control = surFace.GetView()
        '- change some properties
        view.Text = "Test Form "
        view.Dock = DockStyle.Fill
        view.Parent = Me.PanelPic

        Me.PictureBox1.BringToFront()
        Me.PictureBox1.Parent = rootComponent

        rootComponent.AutoScroll = True
        rootComponent.AutoScrollMinSize = New Size(200, 300)
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(NewModel.GridViews("CTerm"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmTerminalSetModel = Me.InitData("frmTerminalSetModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If frmMode = EnumfrmMode.acEditM Then
                Me.ctlzoom.Value = Array.IndexOf(zoomFactor, myUtils.cValTN(myRow("imagesf")))
                If Not myUtils.NullNot(myRow("setpic")) Then WinFormUtils.FillPB(Me.PictureBox1, myRow("setpic"))
                setZoom()
            Else
                Me.ctlzoom.Value = Me.ctlzoom.Maximum / 2
            End If

            For Each gRow As UltraGridRow In myView.mainGrid.myGrid.Rows
                Me.AddRow(gRow)
            Next
            FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Dim tb1, tb2 As TextBox, r As DataRow
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If hasNewImg Then WinFormUtils.FillDSFromPB(myRow.Row, "setpic", Me.PictureBox1)
            myRow("imagesf") = zoomFactor(Me.ctlzoom.Value)
            For Each r In myView.mainGrid.myDS.Tables(0).Select
                tb1 = TermBag(r("Termid"))
                r("terminallocx") = tb1.Location.X - Me.PictureBox1.Location.X
                r("terminallocy") = tb1.Location.Y - Me.PictureBox1.Location.Y
                r("terminalwidth") = tb1.Width

                tb2 = wireBag(r("Termid"))
                r("wirelocx") = tb2.Location.X - Me.PictureBox1.Location.X
                r("wirelocy") = tb2.Location.Y - Me.PictureBox1.Location.Y
                r("wirewidth") = tb2.Width
            Next
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me.PictureBox1.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog1.FileName)
            hasNewImg = True
            setZoom()
        End If
    End Sub

    Private Sub setZoom()
        Dim newZoom As Double = zoomFactor(Me.ctlzoom.Value)
        Me.PictureBox1.Width = Me.PictureBox1.Image.Width * newZoom
        Me.PictureBox1.Height = Me.PictureBox1.Image.Height * newZoom
    End Sub

    Private Sub ctlzoom_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctlzoom.Scroll
        setZoom()
    End Sub

    Private Sub PanelPic_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles rootComponent.Paint
        Dim g As Graphics = e.Graphics
        g.DrawRectangle(Pens.Black, sender.ClientRectangle)
        g.FillRectangle(Brushes.LightYellow, 0, 0, sender.Width, sender.Height)
        myFuncsVC.DrawRuler(sender, e.Graphics)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim gRow As UltraGridRow, r As DataRow
        gRow = myView.mainGrid.ButtonAction("add")
        r = myWinUtils.DataRowFromGridRow(gRow)
        gRow.Cells("Terminalname").Value = Math.Max(myTables.MaxNum(r.Table, "terminalname"), r.Table.Rows.Count) + 1
        Me.AddRow(gRow)
    End Sub

    Private Sub AddRow(ByVal gRow As UltraGridRow)
        Dim tb1, tb2 As TextBox, r As DataRow
        r = myWinUtils.DataRowFromGridRow(gRow)

        tb1 = DirectCast(surFace.CreateControl(GetType(TextBox), New Size(50, 16), New Point(Me.PanelPic.Width / 2, Me.PanelPic.Height / 2)), TextBox)
        tb2 = DirectCast(surFace.CreateControl(GetType(TextBox), New Size(50, 16), New Point(tb1.Location.X + tb1.Width, tb1.Location.Y + tb1.Height)), TextBox)

        If myUtils.cValTN(r("Terminallocx")) > 0 Then
            tb1.Location = New Point(r("terminallocx") + Me.PictureBox1.Location.X, r("Terminallocy") + Me.PictureBox1.Location.Y)
            If myUtils.cValTN(r("Terminalwidth")) > 0 Then tb1.Size = New Size(r("Terminalwidth"), tb1.Size.Height)
        End If

        If myUtils.cValTN(r("wirelocx")) > 0 Then
            tb2.Location = New Point(r("wirelocx") + Me.PictureBox1.Location.X, r("wirelocy") + Me.PictureBox1.Location.Y)
            If myUtils.cValTN(r("wirewidth")) > 0 Then tb2.Size = New Size(r("wirewidth"), tb2.Size.Height)
        End If

        TermBag.Add(gRow.Cells("termid").Value, tb1)
        wireBag.Add(gRow.Cells("termid").Value, tb2)

        For Each tb As TextBox In New TextBox() {tb1, tb2}
            tb.BackColor = Me.PanelPic.BackColor
            tb.BorderStyle = BorderStyle.None
            tb.BringToFront()
            tb.Tag = gRow
        Next
        Me.UpdateRow(gRow)
    End Sub

    Private Sub UpdateRow(ByVal gRow As UltraGridRow)
        Dim tb1, tb2 As TextBox, r As DataRow

        tb1 = TermBag(gRow.Cells("Termid").Value)
        tb2 = wireBag(gRow.Cells("Termid").Value)
        If (Not tb1 Is Nothing) Then tb1.Text = "TN-" & gRow.Cells("terminalname").Value
        If (Not tb2 Is Nothing) Then tb2.Text = "WN-" & gRow.Cells("terminalname").Value
        r = myWinUtils.DataRowFromGridRow(gRow)
        For Each tb As TextBox In New TextBox() {tb1, tb2}
            If Not tb Is Nothing Then
                Select Case myUtils.cValTN(r("textalign"))
                    Case 1
                        tb.TextAlign = HorizontalAlignment.Left
                    Case 2
                        tb.TextAlign = HorizontalAlignment.Right
                    Case Else
                        tb.TextAlign = HorizontalAlignment.Center
                End Select
            End If
        Next
    End Sub

    Private Sub UltraGrid1_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGrid1.AfterCellUpdate
        If Me.FormPrepared Then Me.UpdateRow(e.Cell.Row)
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim tb1, tb2 As TextBox
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If MsgBox("Do you want to delete the row ?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                tb1 = TermBag(myView.ContextRow.CellValue("Termid"))
                If Not tb1 Is Nothing Then rootComponent.Controls.Remove(tb1)
                tb2 = wireBag(myView.ContextRow.CellValue("Termid"))
                If Not tb2 Is Nothing Then rootComponent.Controls.Remove(tb2)
                myView.ContextRow.Delete(False)

            End If
        End If
    End Sub

    Private Sub btnNoGuide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoGuide.Click
        surFace.UseNoGuides()
        Me.btnNoGuide.Enabled = False
    End Sub

    Private Sub btnSaveImage_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveImage.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "*.jpg|*.jpg"
        sfd.FilterIndex = 1
        If sfd.ShowDialog = DialogResult.OK Then
            Me.PictureBox1.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub
End Class
