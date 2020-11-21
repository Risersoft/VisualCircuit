Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPIDPanel
    Inherits frmMax
    Dim dv1, dv2, dv3 As DataView, showreduction As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Me.initForm()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmb_pValueA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraGrid1CtlPanel As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1CtlPanel = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panelbtn = New System.Windows.Forms.Panel()
        Me.btnDelPanel = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPanel = New Infragistics.Win.Misc.UltraButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_pValueA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Remarks = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_filenum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Customer = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnRenamePanel = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1CtlPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelbtn.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.cmb_pValueA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_filenum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1CtlPanel)
        Me.UltraTabPageControl1.Controls.Add(Me.Panelbtn)
        Me.UltraTabPageControl1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(871, 245)
        '
        'UltraGrid1CtlPanel
        '
        Me.UltraGrid1CtlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1CtlPanel.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid1CtlPanel.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1CtlPanel.Name = "UltraGrid1CtlPanel"
        Me.UltraGrid1CtlPanel.Size = New System.Drawing.Size(871, 205)
        Me.UltraGrid1CtlPanel.TabIndex = 0
        Me.UltraGrid1CtlPanel.Text = "Delivery Schedule"
        '
        'Panelbtn
        '
        Me.Panelbtn.Controls.Add(Me.btnRenamePanel)
        Me.Panelbtn.Controls.Add(Me.btnDelPanel)
        Me.Panelbtn.Controls.Add(Me.btnAddPanel)
        Me.Panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelbtn.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panelbtn.Location = New System.Drawing.Point(0, 205)
        Me.Panelbtn.Name = "Panelbtn"
        Me.Panelbtn.Size = New System.Drawing.Size(871, 40)
        Me.Panelbtn.TabIndex = 7
        '
        'btnDelPanel
        '
        Me.btnDelPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelPanel.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelPanel.Location = New System.Drawing.Point(714, 6)
        Me.btnDelPanel.Name = "btnDelPanel"
        Me.btnDelPanel.Size = New System.Drawing.Size(70, 24)
        Me.btnDelPanel.TabIndex = 2
        Me.btnDelPanel.Text = "&Delete"
        '
        'btnAddPanel
        '
        Me.btnAddPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPanel.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddPanel.Location = New System.Drawing.Point(790, 6)
        Me.btnAddPanel.Name = "btnAddPanel"
        Me.btnAddPanel.Size = New System.Drawing.Size(72, 24)
        Me.btnAddPanel.TabIndex = 0
        Me.btnAddPanel.Text = "&Add New"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 408)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(875, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(587, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(683, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Location = New System.Drawing.Point(779, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(24, 8)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 16)
        Me.Label23.TabIndex = 297
        Me.Label23.Text = "Length"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_pValueA
        '
        Me.cmb_pValueA.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cmb_pValueA.Location = New System.Drawing.Point(72, 8)
        Me.cmb_pValueA.Name = "cmb_pValueA"
        Me.cmb_pValueA.Size = New System.Drawing.Size(88, 21)
        Me.cmb_pValueA.TabIndex = 296
        Me.cmb_pValueA.Text = "UltraComboEditor1"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(24, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 292
        Me.Label11.Text = "Length"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTextEditor1
        '
        Appearance4.TextHAlignAsString = "Center"
        Me.UltraTextEditor1.Appearance = Appearance4
        Me.UltraTextEditor1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTextEditor1.Location = New System.Drawing.Point(72, 104)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(64, 21)
        Me.UltraTextEditor1.TabIndex = 291
        Me.UltraTextEditor1.Text = "UltraTextEditor8"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(871, 245)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 137)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(875, 271)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Panels"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Controls.Add(Me.txt_Remarks)
        Me.Panel2.Controls.Add(Me.txt_filenum)
        Me.Panel2.Controls.Add(Me.UltraLabel42)
        Me.Panel2.Controls.Add(Me.txt_Descrip)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_Customer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(875, 137)
        Me.Panel2.TabIndex = 222
        '
        'UltraLabel1
        '
        Appearance5.TextHAlignAsString = "Center"
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel1.Location = New System.Drawing.Point(68, 87)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel1.TabIndex = 302
        Me.UltraLabel1.Text = "Remarks"
        '
        'txt_Remarks
        '
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.ItalicAsString = "False"
        Appearance6.FontData.Name = "Arial"
        Appearance6.FontData.SizeInPoints = 10.0!
        Appearance6.FontData.StrikeoutAsString = "False"
        Appearance6.FontData.UnderlineAsString = "False"
        Me.txt_Remarks.Appearance = Appearance6
        Me.txt_Remarks.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Remarks.Location = New System.Drawing.Point(140, 87)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.ReadOnly = True
        Me.txt_Remarks.Size = New System.Drawing.Size(272, 24)
        Me.txt_Remarks.TabIndex = 301
        '
        'txt_filenum
        '
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.FontData.ItalicAsString = "False"
        Appearance7.FontData.Name = "Arial"
        Appearance7.FontData.SizeInPoints = 10.0!
        Appearance7.FontData.StrikeoutAsString = "False"
        Appearance7.FontData.UnderlineAsString = "False"
        Me.txt_filenum.Appearance = Appearance7
        Me.txt_filenum.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_filenum.Location = New System.Drawing.Point(420, 55)
        Me.txt_filenum.Name = "txt_filenum"
        Me.txt_filenum.ReadOnly = True
        Me.txt_filenum.Size = New System.Drawing.Size(208, 24)
        Me.txt_filenum.TabIndex = 300
        '
        'UltraLabel42
        '
        Appearance8.TextHAlignAsString = "Center"
        Me.UltraLabel42.Appearance = Appearance8
        Me.UltraLabel42.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel42.Location = New System.Drawing.Point(39, 55)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(97, 16)
        Me.UltraLabel42.TabIndex = 299
        Me.UltraLabel42.Text = "Description"
        '
        'txt_Descrip
        '
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.FontData.ItalicAsString = "False"
        Appearance9.FontData.Name = "Arial"
        Appearance9.FontData.SizeInPoints = 10.0!
        Appearance9.FontData.StrikeoutAsString = "False"
        Appearance9.FontData.UnderlineAsString = "False"
        Me.txt_Descrip.Appearance = Appearance9
        Me.txt_Descrip.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Descrip.Location = New System.Drawing.Point(140, 55)
        Me.txt_Descrip.Name = "txt_Descrip"
        Me.txt_Descrip.ReadOnly = True
        Me.txt_Descrip.Size = New System.Drawing.Size(272, 24)
        Me.txt_Descrip.TabIndex = 298
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(68, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 297
        Me.Label6.Text = "Customer"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Customer
        '
        Me.txt_Customer.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Customer.Location = New System.Drawing.Point(140, 23)
        Me.txt_Customer.Name = "txt_Customer"
        Me.txt_Customer.ReadOnly = True
        Me.txt_Customer.Size = New System.Drawing.Size(584, 21)
        Me.txt_Customer.TabIndex = 296
        Me.txt_Customer.Text = "UltraTextEditor1"
        '
        'btnRenamePanel
        '
        Me.btnRenamePanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRenamePanel.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnRenamePanel.Location = New System.Drawing.Point(638, 6)
        Me.btnRenamePanel.Name = "btnRenamePanel"
        Me.btnRenamePanel.Size = New System.Drawing.Size(70, 24)
        Me.btnRenamePanel.TabIndex = 3
        Me.btnRenamePanel.Text = "&Rename"
        '
        'frmPIDPanel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Work order Panels and Field Areas"
        Me.ClientSize = New System.Drawing.Size(875, 456)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPIDPanel"
        Me.Text = "Work order Panels and Field Areas"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1CtlPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelbtn.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.cmb_pValueA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_filenum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panelbtn As System.Windows.Forms.Panel
    Friend WithEvents btnDelPanel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPanel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remarks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_filenum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Customer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnRenamePanel As Infragistics.Win.Misc.UltraButton

#End Region
End Class

