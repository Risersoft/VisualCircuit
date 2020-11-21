<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTerminalSet
    Inherits frmMax

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        InitForm()
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelPic = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.btnSaveImage = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNoGuide = New Infragistics.Win.Misc.UltraButton()
        Me.chk_NoWhiteSpace = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.ctlzoom = New System.Windows.Forms.TrackBar()
        Me.txt_Descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_SetTypeCode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_NumTerm = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtlUpLoad4 = New risersoft.[shared].win.ctlUpLoad()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelPic.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.chk_NoWhiteSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctlzoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SetTypeCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 604)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(711, 48)
        Me.Panel4.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance18.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance18
        Me.btnSave.Location = New System.Drawing.Point(423, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance19.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance19
        Me.btnCancel.Location = New System.Drawing.Point(519, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance20.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance20
        Me.btnOK.Location = New System.Drawing.Point(615, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelPic)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 321)
        Me.Panel1.TabIndex = 5
        '
        'PanelPic
        '
        Me.PanelPic.AutoScroll = True
        Me.PanelPic.Controls.Add(Me.PictureBox1)
        Me.PanelPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPic.Location = New System.Drawing.Point(429, 0)
        Me.PanelPic.Name = "PanelPic"
        Me.PanelPic.Size = New System.Drawing.Size(282, 288)
        Me.PanelPic.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(210, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.UltraButton1)
        Me.Panel3.Controls.Add(Me.btnSaveImage)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(429, 288)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(282, 33)
        Me.Panel3.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(6, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Terminal Set Image"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraButton1
        '
        Me.UltraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraButton1.Location = New System.Drawing.Point(129, 4)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(64, 23)
        Me.UltraButton1.TabIndex = 15
        Me.UltraButton1.Text = "Browse"
        '
        'btnSaveImage
        '
        Me.btnSaveImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveImage.Location = New System.Drawing.Point(206, 4)
        Me.btnSaveImage.Name = "btnSaveImage"
        Me.btnSaveImage.Size = New System.Drawing.Size(64, 23)
        Me.btnSaveImage.TabIndex = 14
        Me.btnSaveImage.Text = "Save"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnNoGuide)
        Me.Panel2.Controls.Add(Me.chk_NoWhiteSpace)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Controls.Add(Me.ctlzoom)
        Me.Panel2.Controls.Add(Me.txt_Descrip)
        Me.Panel2.Controls.Add(Me.cmb_SetTypeCode)
        Me.Panel2.Controls.Add(Me.UltraLabel5)
        Me.Panel2.Controls.Add(Me.txt_NumTerm)
        Me.Panel2.Controls.Add(Me.UltraLabel7)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 321)
        Me.Panel2.TabIndex = 0
        '
        'btnNoGuide
        '
        Me.btnNoGuide.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNoGuide.Location = New System.Drawing.Point(304, 156)
        Me.btnNoGuide.Name = "btnNoGuide"
        Me.btnNoGuide.Size = New System.Drawing.Size(74, 37)
        Me.btnNoGuide.TabIndex = 128
        Me.btnNoGuide.Text = "Do not use snap lines"
        '
        'chk_NoWhiteSpace
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.SizeInPoints = 8.0!
        Me.chk_NoWhiteSpace.Appearance = Appearance2
        Me.chk_NoWhiteSpace.Location = New System.Drawing.Point(105, 156)
        Me.chk_NoWhiteSpace.Name = "chk_NoWhiteSpace"
        Me.chk_NoWhiteSpace.Size = New System.Drawing.Size(210, 24)
        Me.chk_NoWhiteSpace.TabIndex = 127
        Me.chk_NoWhiteSpace.Text = "Do not provide white space"
        '
        'UltraLabel1
        '
        Appearance25.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance25
        Me.UltraLabel1.Location = New System.Drawing.Point(17, 115)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 30)
        Me.UltraLabel1.TabIndex = 126
        Me.UltraLabel1.Text = "Image Scale Factor"
        '
        'ctlzoom
        '
        Me.ctlzoom.Location = New System.Drawing.Point(103, 115)
        Me.ctlzoom.Name = "ctlzoom"
        Me.ctlzoom.Size = New System.Drawing.Size(320, 45)
        Me.ctlzoom.TabIndex = 125
        '
        'txt_Descrip
        '
        Appearance29.FontData.BoldAsString = "False"
        Appearance29.FontData.ItalicAsString = "False"
        Appearance29.FontData.Name = "Arial"
        Appearance29.FontData.SizeInPoints = 8.25!
        Appearance29.FontData.StrikeoutAsString = "False"
        Appearance29.FontData.UnderlineAsString = "False"
        Me.txt_Descrip.Appearance = Appearance29
        Me.txt_Descrip.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Descrip.Location = New System.Drawing.Point(105, 34)
        Me.txt_Descrip.Name = "txt_Descrip"
        Me.txt_Descrip.Size = New System.Drawing.Size(318, 21)
        Me.txt_Descrip.TabIndex = 119
        '
        'cmb_SetTypeCode
        '
        Me.cmb_SetTypeCode.Location = New System.Drawing.Point(105, 88)
        Me.cmb_SetTypeCode.Name = "cmb_SetTypeCode"
        Me.cmb_SetTypeCode.Size = New System.Drawing.Size(136, 21)
        Me.cmb_SetTypeCode.TabIndex = 124
        Me.cmb_SetTypeCode.Text = "UltraComboEditor1"
        '
        'UltraLabel5
        '
        Appearance23.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance23
        Me.UltraLabel5.Location = New System.Drawing.Point(3, 64)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(94, 18)
        Me.UltraLabel5.TabIndex = 123
        Me.UltraLabel5.Text = "No. of Terminals"
        '
        'txt_NumTerm
        '
        Appearance24.FontData.BoldAsString = "False"
        Appearance24.FontData.ItalicAsString = "False"
        Appearance24.FontData.Name = "Arial"
        Appearance24.FontData.SizeInPoints = 8.25!
        Appearance24.FontData.StrikeoutAsString = "False"
        Appearance24.FontData.UnderlineAsString = "False"
        Me.txt_NumTerm.Appearance = Appearance24
        Me.txt_NumTerm.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_NumTerm.Location = New System.Drawing.Point(105, 61)
        Me.txt_NumTerm.Name = "txt_NumTerm"
        Me.txt_NumTerm.Size = New System.Drawing.Size(60, 21)
        Me.txt_NumTerm.TabIndex = 122
        '
        'UltraLabel7
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance1
        Me.UltraLabel7.Location = New System.Drawing.Point(1, 88)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel7.TabIndex = 121
        Me.UltraLabel7.Text = "Set Type"
        '
        'UltraLabel2
        '
        Appearance28.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance28
        Me.UltraLabel2.Location = New System.Drawing.Point(17, 34)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(80, 24)
        Me.UltraLabel2.TabIndex = 120
        Me.UltraLabel2.Text = "Description"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 321)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(711, 8)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.btnAdd)
        Me.Panel9.Controls.Add(Me.btnEdit)
        Me.Panel9.Controls.Add(Me.btnDel)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 530)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(711, 34)
        Me.Panel9.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Block for insertion into AutoCAD schematic"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'CtlUpLoad4
        '
        Me.CtlUpLoad4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CtlUpLoad4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad4.Location = New System.Drawing.Point(0, 564)
        Me.CtlUpLoad4.Name = "CtlUpLoad4"
        Me.CtlUpLoad4.Size = New System.Drawing.Size(711, 40)
        Me.CtlUpLoad4.TabIndex = 14
        Me.CtlUpLoad4.Tag = "4"
        Me.CtlUpLoad4.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(479, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(559, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(64, 23)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(639, 3)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 23)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Delete"
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 329)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(711, 201)
        Me.UltraGrid1.TabIndex = 24
        Me.UltraGrid1.Text = "Terminals"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPG Files|*.jpg|GIF Files|*.gif|BMP Files|*.bmp"
        '
        'frmTerminalSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Control Terminal Set"
        Me.ClientSize = New System.Drawing.Size(711, 652)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CtlUpLoad4)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmTerminalSet"
        Me.Text = "Control Terminal Set"
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelPic.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.chk_NoWhiteSpace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctlzoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SetTypeCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSaveImage As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_Descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_SetTypeCode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_NumTerm As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CtlUpLoad4 As ctlUpLoad
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ctlzoom As System.Windows.Forms.TrackBar
    Friend WithEvents PanelPic As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chk_NoWhiteSpace As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnNoGuide As Infragistics.Win.Misc.UltraButton
End Class
