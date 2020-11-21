<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmCtl
    Inherits frmMax
    Friend WithEvents btnRenum As Infragistics.Win.Misc.UltraButton

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitForm()
        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnAddMG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditMG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelMG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents chk_IsTB As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_Loc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnMoveDown As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMoveUp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlItemVMS1 As ctlItemVMS2
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents combo_ItemUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents combo_ItemName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents combo_ItemId As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmb_ctlmake As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_CatNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblMake As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_MtgCPID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_MtgMBID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chk_MinLevel As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Legend As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ctlItem As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Price As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_purpose As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnAddTS As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditTS As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelTS As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnCopy As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.combo_ItemUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.combo_ItemName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.combo_ItemId = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_ctlmake = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_CatNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblMake = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_GAMakesItem = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_GARating = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_GANameItem = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_ctlcatid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_LugHoleDia = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_lugtype = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_DontPrintInMatList = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsTB = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_MinLevel = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_MtgCPID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_MtgMBID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Price = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_purpose = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRenum = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveDown = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveUp = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopy = New Infragistics.Win.Misc.UltraButton()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton2 = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnAddTS = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditTS = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelTS = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAddMG = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditMG = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelMG = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_isOld = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_Loc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Legend = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ctlItem = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.CtlItemVMS1 = New risersoft.app.config.ctlItemVMS2()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.combo_ItemUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_ItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_ItemId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.txt_descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ctlmake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CatNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txt_GAMakesItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GARating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GANameItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ctlcatid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LugHoleDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_lugtype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_DontPrintInMatList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_MinLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MtgCPID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MtgMBID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chk_isOld, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Loc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Legend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ctlItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.CtlItemVMS1)
        Me.UltraTabPageControl6.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(0, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(684, 380)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.combo_ItemUnit)
        Me.Panel2.Controls.Add(Me.combo_ItemName)
        Me.Panel2.Controls.Add(Me.combo_ItemId)
        Me.Panel2.Controls.Add(Me.UltraLabel13)
        Me.Panel2.Controls.Add(Me.UltraLabel14)
        Me.Panel2.Controls.Add(Me.UltraLabel15)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 56)
        Me.Panel2.TabIndex = 20
        '
        'combo_ItemUnit
        '
        Me.combo_ItemUnit.DisplayMember = "unitName"
        Me.combo_ItemUnit.Location = New System.Drawing.Point(480, 8)
        Me.combo_ItemUnit.Name = "combo_ItemUnit"
        Me.combo_ItemUnit.ReadOnly = True
        Me.combo_ItemUnit.Size = New System.Drawing.Size(120, 22)
        Me.combo_ItemUnit.TabIndex = 123
        Me.combo_ItemUnit.TabStop = False
        Me.combo_ItemUnit.ValueMember = "itemId"
        '
        'combo_ItemName
        '
        Me.combo_ItemName.DisplayMember = "itemName"
        Me.combo_ItemName.Location = New System.Drawing.Point(144, 32)
        Me.combo_ItemName.Name = "combo_ItemName"
        Me.combo_ItemName.Size = New System.Drawing.Size(456, 22)
        Me.combo_ItemName.TabIndex = 119
        Me.combo_ItemName.ValueMember = "itemId"
        '
        'combo_ItemId
        '
        Me.combo_ItemId.DisplayMember = "itemCode"
        Me.combo_ItemId.Location = New System.Drawing.Point(144, 8)
        Me.combo_ItemId.Name = "combo_ItemId"
        Me.combo_ItemId.Size = New System.Drawing.Size(224, 22)
        Me.combo_ItemId.TabIndex = 118
        Me.combo_ItemId.ValueMember = "itemId"
        '
        'UltraLabel13
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel13.Appearance = Appearance1
        Me.UltraLabel13.Location = New System.Drawing.Point(440, 8)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel13.TabIndex = 122
        Me.UltraLabel13.Text = "Unit"
        '
        'UltraLabel14
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel14.Appearance = Appearance2
        Me.UltraLabel14.Location = New System.Drawing.Point(80, 32)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel14.TabIndex = 121
        Me.UltraLabel14.Text = "Item Name"
        '
        'UltraLabel15
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel15.Appearance = Appearance3
        Me.UltraLabel15.Location = New System.Drawing.Point(80, 8)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel15.TabIndex = 120
        Me.UltraLabel15.Text = "Item Code"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl7.Controls.Add(Me.txt_descrip)
        Me.UltraTabPageControl7.Controls.Add(Me.cmb_ctlmake)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraLabel9)
        Me.UltraTabPageControl7.Controls.Add(Me.txt_CatNum)
        Me.UltraTabPageControl7.Controls.Add(Me.lblMake)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(684, 380)
        '
        'UltraLabel6
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance4
        Me.UltraLabel6.Location = New System.Drawing.Point(38, 125)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(80, 40)
        Me.UltraLabel6.TabIndex = 123
        Me.UltraLabel6.Text = "Description / Specification"
        '
        'txt_descrip
        '
        Me.txt_descrip.AcceptsReturn = True
        Appearance5.FontData.BoldAsString = "False"
        Appearance5.FontData.ItalicAsString = "False"
        Appearance5.FontData.Name = "Arial"
        Appearance5.FontData.SizeInPoints = 8.25!
        Appearance5.FontData.StrikeoutAsString = "False"
        Appearance5.FontData.UnderlineAsString = "False"
        Me.txt_descrip.Appearance = Appearance5
        Me.txt_descrip.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_descrip.Location = New System.Drawing.Point(126, 125)
        Me.txt_descrip.Multiline = True
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(496, 80)
        Me.txt_descrip.TabIndex = 122
        '
        'cmb_ctlmake
        '
        Me.cmb_ctlmake.Location = New System.Drawing.Point(126, 47)
        Me.cmb_ctlmake.Name = "cmb_ctlmake"
        Me.cmb_ctlmake.Size = New System.Drawing.Size(224, 21)
        Me.cmb_ctlmake.TabIndex = 121
        Me.cmb_ctlmake.Text = "UltraComboEditor1"
        '
        'UltraLabel9
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance6
        Me.UltraLabel9.Location = New System.Drawing.Point(70, 86)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel9.TabIndex = 120
        Me.UltraLabel9.Text = "Cat No."
        '
        'txt_CatNum
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.ItalicAsString = "False"
        Appearance7.FontData.Name = "Arial"
        Appearance7.FontData.SizeInPoints = 8.25!
        Appearance7.FontData.StrikeoutAsString = "False"
        Appearance7.FontData.UnderlineAsString = "False"
        Me.txt_CatNum.Appearance = Appearance7
        Me.txt_CatNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CatNum.Location = New System.Drawing.Point(126, 86)
        Me.txt_CatNum.Name = "txt_CatNum"
        Me.txt_CatNum.Size = New System.Drawing.Size(200, 21)
        Me.txt_CatNum.TabIndex = 119
        '
        'lblMake
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.lblMake.Appearance = Appearance8
        Me.lblMake.Location = New System.Drawing.Point(70, 47)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(48, 24)
        Me.lblMake.TabIndex = 118
        Me.lblMake.Text = "Make"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraTabControl2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(684, 402)
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(684, 402)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl2.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl6
        UltraTab1.Text = "Itemcode"
        UltraTab2.TabPage = Me.UltraTabPageControl7
        UltraTab2.Text = "Non Item code"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(684, 380)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel17)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_GAMakesItem)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel11)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_GARating)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel7)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_GANameItem)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ctlcatid)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel16)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_LugHoleDia)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_lugtype)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel12)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_DontPrintInMatList)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_IsTB)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_MinLevel)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_MtgCPID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_MtgMBID)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel10)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Price)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel4)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Remark)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_purpose)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(684, 402)
        '
        'UltraLabel17
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel17.Appearance = Appearance9
        Me.UltraLabel17.Location = New System.Drawing.Point(19, 297)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(103, 17)
        Me.UltraLabel17.TabIndex = 184
        Me.UltraLabel17.Text = "GA Makes"
        '
        'txt_GAMakesItem
        '
        Appearance10.FontData.BoldAsString = "False"
        Appearance10.FontData.ItalicAsString = "False"
        Appearance10.FontData.Name = "Arial"
        Appearance10.FontData.SizeInPoints = 8.25!
        Appearance10.FontData.StrikeoutAsString = "False"
        Appearance10.FontData.UnderlineAsString = "False"
        Me.txt_GAMakesItem.Appearance = Appearance10
        Me.txt_GAMakesItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_GAMakesItem.Location = New System.Drawing.Point(128, 293)
        Me.txt_GAMakesItem.Name = "txt_GAMakesItem"
        Me.txt_GAMakesItem.Size = New System.Drawing.Size(296, 21)
        Me.txt_GAMakesItem.TabIndex = 183
        '
        'UltraLabel11
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance11
        Me.UltraLabel11.Location = New System.Drawing.Point(19, 260)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(103, 17)
        Me.UltraLabel11.TabIndex = 182
        Me.UltraLabel11.Text = "GA Rating"
        '
        'txt_GARating
        '
        Appearance12.FontData.BoldAsString = "False"
        Appearance12.FontData.ItalicAsString = "False"
        Appearance12.FontData.Name = "Arial"
        Appearance12.FontData.SizeInPoints = 8.25!
        Appearance12.FontData.StrikeoutAsString = "False"
        Appearance12.FontData.UnderlineAsString = "False"
        Me.txt_GARating.Appearance = Appearance12
        Me.txt_GARating.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_GARating.Location = New System.Drawing.Point(128, 256)
        Me.txt_GARating.Name = "txt_GARating"
        Me.txt_GARating.Size = New System.Drawing.Size(296, 21)
        Me.txt_GARating.TabIndex = 181
        '
        'UltraLabel7
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance13
        Me.UltraLabel7.Location = New System.Drawing.Point(11, 222)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(110, 17)
        Me.UltraLabel7.TabIndex = 180
        Me.UltraLabel7.Text = "GA Name"
        '
        'txt_GANameItem
        '
        Appearance14.FontData.BoldAsString = "False"
        Appearance14.FontData.ItalicAsString = "False"
        Appearance14.FontData.Name = "Arial"
        Appearance14.FontData.SizeInPoints = 8.25!
        Appearance14.FontData.StrikeoutAsString = "False"
        Appearance14.FontData.UnderlineAsString = "False"
        Me.txt_GANameItem.Appearance = Appearance14
        Me.txt_GANameItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_GANameItem.Location = New System.Drawing.Point(127, 218)
        Me.txt_GANameItem.Name = "txt_GANameItem"
        Me.txt_GANameItem.Size = New System.Drawing.Size(296, 21)
        Me.txt_GANameItem.TabIndex = 179
        '
        'cmb_ctlcatid
        '
        Me.cmb_ctlcatid.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cmb_ctlcatid.Location = New System.Drawing.Point(128, 32)
        Me.cmb_ctlcatid.Name = "cmb_ctlcatid"
        Me.cmb_ctlcatid.Size = New System.Drawing.Size(224, 22)
        Me.cmb_ctlcatid.TabIndex = 178
        '
        'UltraLabel16
        '
        Appearance15.TextHAlignAsString = "Right"
        Me.UltraLabel16.Appearance = Appearance15
        Me.UltraLabel16.Location = New System.Drawing.Point(375, 358)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel16.TabIndex = 176
        Me.UltraLabel16.Text = "Hole Dia"
        '
        'txt_LugHoleDia
        '
        Appearance16.FontData.BoldAsString = "False"
        Appearance16.FontData.ItalicAsString = "False"
        Appearance16.FontData.Name = "Arial"
        Appearance16.FontData.SizeInPoints = 8.25!
        Appearance16.FontData.StrikeoutAsString = "False"
        Appearance16.FontData.UnderlineAsString = "False"
        Me.txt_LugHoleDia.Appearance = Appearance16
        Me.txt_LugHoleDia.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_LugHoleDia.Location = New System.Drawing.Point(429, 358)
        Me.txt_LugHoleDia.Name = "txt_LugHoleDia"
        Me.txt_LugHoleDia.Size = New System.Drawing.Size(136, 21)
        Me.txt_LugHoleDia.TabIndex = 175
        '
        'cmb_lugtype
        '
        Me.cmb_lugtype.Location = New System.Drawing.Point(128, 358)
        Me.cmb_lugtype.Name = "cmb_lugtype"
        Me.cmb_lugtype.Size = New System.Drawing.Size(241, 21)
        Me.cmb_lugtype.TabIndex = 174
        '
        'UltraLabel12
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.UltraLabel12.Appearance = Appearance17
        Me.UltraLabel12.Location = New System.Drawing.Point(48, 358)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel12.TabIndex = 173
        Me.UltraLabel12.Text = "Lug Type"
        '
        'chk_DontPrintInMatList
        '
        Me.chk_DontPrintInMatList.Location = New System.Drawing.Point(361, 74)
        Me.chk_DontPrintInMatList.Name = "chk_DontPrintInMatList"
        Me.chk_DontPrintInMatList.Size = New System.Drawing.Size(314, 24)
        Me.chk_DontPrintInMatList.TabIndex = 172
        Me.chk_DontPrintInMatList.Text = "Do not print this item in Material List. (For WD purpose only)"
        '
        'chk_IsTB
        '
        Me.chk_IsTB.Location = New System.Drawing.Point(361, 27)
        Me.chk_IsTB.Name = "chk_IsTB"
        Me.chk_IsTB.Size = New System.Drawing.Size(314, 24)
        Me.chk_IsTB.TabIndex = 170
        Me.chk_IsTB.Text = "Treat this item like Terminal Block when allocating terminals"
        '
        'chk_MinLevel
        '
        Appearance18.FontData.BoldAsString = "False"
        Appearance18.FontData.SizeInPoints = 8.0!
        Me.chk_MinLevel.Appearance = Appearance18
        Me.chk_MinLevel.Location = New System.Drawing.Point(270, 118)
        Me.chk_MinLevel.Name = "chk_MinLevel"
        Me.chk_MinLevel.Size = New System.Drawing.Size(153, 24)
        Me.chk_MinLevel.TabIndex = 119
        Me.chk_MinLevel.Text = "Maintain Minimum Level"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(322, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Mounting Indoor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_MtgCPID
        '
        Me.cmb_MtgCPID.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cmb_MtgCPID.Location = New System.Drawing.Point(429, 330)
        Me.cmb_MtgCPID.Name = "cmb_MtgCPID"
        Me.cmb_MtgCPID.Size = New System.Drawing.Size(224, 22)
        Me.cmb_MtgCPID.TabIndex = 168
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(16, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Mounting Outdoor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_MtgMBID
        '
        Me.cmb_MtgMBID.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cmb_MtgMBID.Location = New System.Drawing.Point(127, 330)
        Me.cmb_MtgMBID.Name = "cmb_MtgMBID"
        Me.cmb_MtgMBID.Size = New System.Drawing.Size(189, 22)
        Me.cmb_MtgMBID.TabIndex = 166
        '
        'UltraLabel10
        '
        Appearance19.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance19
        Me.UltraLabel10.Location = New System.Drawing.Point(74, 122)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(48, 17)
        Me.UltraLabel10.TabIndex = 123
        Me.UltraLabel10.Text = "Price"
        '
        'txt_Price
        '
        Appearance20.FontData.BoldAsString = "False"
        Appearance20.FontData.ItalicAsString = "False"
        Appearance20.FontData.Name = "Arial"
        Appearance20.FontData.SizeInPoints = 8.25!
        Appearance20.FontData.StrikeoutAsString = "False"
        Appearance20.FontData.UnderlineAsString = "False"
        Me.txt_Price.Appearance = Appearance20
        Me.txt_Price.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Price.Location = New System.Drawing.Point(128, 118)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(136, 21)
        Me.txt_Price.TabIndex = 122
        '
        'UltraLabel4
        '
        Appearance21.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance21
        Me.UltraLabel4.Location = New System.Drawing.Point(41, 161)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 40)
        Me.UltraLabel4.TabIndex = 121
        Me.UltraLabel4.Text = "Remark"
        '
        'txt_Remark
        '
        Appearance22.FontData.BoldAsString = "False"
        Appearance22.FontData.ItalicAsString = "False"
        Appearance22.FontData.Name = "Arial"
        Appearance22.FontData.SizeInPoints = 8.25!
        Appearance22.FontData.StrikeoutAsString = "False"
        Appearance22.FontData.UnderlineAsString = "False"
        Me.txt_Remark.Appearance = Appearance22
        Me.txt_Remark.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Remark.Location = New System.Drawing.Point(127, 161)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(524, 40)
        Me.txt_Remark.TabIndex = 120
        '
        'UltraLabel3
        '
        Appearance23.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance23
        Me.UltraLabel3.Location = New System.Drawing.Point(33, 32)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(88, 24)
        Me.UltraLabel3.TabIndex = 113
        Me.UltraLabel3.Text = "Item Category"
        '
        'UltraLabel1
        '
        Appearance24.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance24
        Me.UltraLabel1.Location = New System.Drawing.Point(57, 79)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 17)
        Me.UltraLabel1.TabIndex = 110
        Me.UltraLabel1.Text = "Purpose"
        '
        'txt_purpose
        '
        Appearance25.FontData.BoldAsString = "False"
        Appearance25.FontData.ItalicAsString = "False"
        Appearance25.FontData.Name = "Arial"
        Appearance25.FontData.SizeInPoints = 8.25!
        Appearance25.FontData.StrikeoutAsString = "False"
        Appearance25.FontData.UnderlineAsString = "False"
        Me.txt_purpose.Appearance = Appearance25
        Me.txt_purpose.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_purpose.Location = New System.Drawing.Point(127, 75)
        Me.txt_purpose.Name = "txt_purpose"
        Me.txt_purpose.Size = New System.Drawing.Size(225, 21)
        Me.txt_purpose.TabIndex = 108
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl4.Controls.Add(Me.PictureBox1)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(684, 402)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnRenum)
        Me.Panel3.Controls.Add(Me.btnMoveDown)
        Me.Panel3.Controls.Add(Me.btnMoveUp)
        Me.Panel3.Controls.Add(Me.btnCopy)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.UltraButton2)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Controls.Add(Me.btnDel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(338, 329)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 73)
        Me.Panel3.TabIndex = 21
        '
        'btnRenum
        '
        Me.btnRenum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRenum.Location = New System.Drawing.Point(193, 32)
        Me.btnRenum.Name = "btnRenum"
        Me.btnRenum.Size = New System.Drawing.Size(87, 23)
        Me.btnRenum.TabIndex = 17
        Me.btnRenum.Text = "Renumber"
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveDown.Location = New System.Drawing.Point(6, 32)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(87, 23)
        Me.btnMoveDown.TabIndex = 16
        Me.btnMoveDown.Text = "Move Down"
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveUp.Location = New System.Drawing.Point(113, 32)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(64, 23)
        Me.btnMoveUp.TabIndex = 15
        Me.btnMoveUp.Text = "Move Up"
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.Location = New System.Drawing.Point(6, 3)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(87, 23)
        Me.btnCopy.TabIndex = 14
        Me.btnCopy.Text = "Copy From ..."
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(113, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        '
        'UltraButton2
        '
        Me.UltraButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraButton2.Location = New System.Drawing.Point(-414, 33)
        Me.UltraButton2.Name = "UltraButton2"
        Me.UltraButton2.Size = New System.Drawing.Size(70, 24)
        Me.UltraButton2.TabIndex = 9
        Me.UltraButton2.Text = "Copy"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(193, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(64, 23)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(273, 3)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 23)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Delete"
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(338, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(346, 402)
        Me.UltraGrid1.TabIndex = 22
        Me.UltraGrid1.Text = "Terminal Sets"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 402)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Panel9)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(684, 402)
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnAddTS)
        Me.Panel9.Controls.Add(Me.btnEditTS)
        Me.Panel9.Controls.Add(Me.btnDelTS)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 357)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(684, 45)
        Me.Panel9.TabIndex = 19
        '
        'btnAddTS
        '
        Me.btnAddTS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTS.Location = New System.Drawing.Point(451, 9)
        Me.btnAddTS.Name = "btnAddTS"
        Me.btnAddTS.Size = New System.Drawing.Size(64, 23)
        Me.btnAddTS.TabIndex = 13
        Me.btnAddTS.Text = "Add"
        '
        'btnEditTS
        '
        Me.btnEditTS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditTS.Location = New System.Drawing.Point(531, 9)
        Me.btnEditTS.Name = "btnEditTS"
        Me.btnEditTS.Size = New System.Drawing.Size(64, 23)
        Me.btnEditTS.TabIndex = 4
        Me.btnEditTS.Text = "Edit"
        '
        'btnDelTS
        '
        Me.btnDelTS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelTS.Location = New System.Drawing.Point(611, 9)
        Me.btnDelTS.Name = "btnDelTS"
        Me.btnDelTS.Size = New System.Drawing.Size(64, 23)
        Me.btnDelTS.TabIndex = 3
        Me.btnDelTS.Text = "Delete"
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(684, 402)
        Me.UltraGrid2.TabIndex = 20
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(684, 402)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnAddMG)
        Me.Panel5.Controls.Add(Me.btnEditMG)
        Me.Panel5.Controls.Add(Me.btnDelMG)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 357)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(684, 45)
        Me.Panel5.TabIndex = 23
        '
        'btnAddMG
        '
        Me.btnAddMG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddMG.Location = New System.Drawing.Point(451, 9)
        Me.btnAddMG.Name = "btnAddMG"
        Me.btnAddMG.Size = New System.Drawing.Size(64, 23)
        Me.btnAddMG.TabIndex = 13
        Me.btnAddMG.Text = "Add"
        '
        'btnEditMG
        '
        Me.btnEditMG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditMG.Location = New System.Drawing.Point(531, 9)
        Me.btnEditMG.Name = "btnEditMG"
        Me.btnEditMG.Size = New System.Drawing.Size(64, 23)
        Me.btnEditMG.TabIndex = 4
        Me.btnEditMG.Text = "Edit"
        '
        'btnDelMG
        '
        Me.btnDelMG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelMG.Location = New System.Drawing.Point(611, 9)
        Me.btnDelMG.Name = "btnDelMG"
        Me.btnDelMG.Size = New System.Drawing.Size(64, 23)
        Me.btnDelMG.TabIndex = 3
        Me.btnDelMG.Text = "Delete"
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(684, 402)
        Me.UltraGrid3.TabIndex = 24
        Me.UltraGrid3.Text = "Mounting Codes"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 518)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(688, 48)
        Me.Panel4.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance26.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance26
        Me.btnSave.Location = New System.Drawing.Point(400, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance27.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance27
        Me.btnCancel.Location = New System.Drawing.Point(496, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance28.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance28
        Me.btnOK.Location = New System.Drawing.Point(592, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chk_isOld)
        Me.Panel1.Controls.Add(Me.cmb_Loc)
        Me.Panel1.Controls.Add(Me.UltraLabel5)
        Me.Panel1.Controls.Add(Me.UltraLabel8)
        Me.Panel1.Controls.Add(Me.txt_Legend)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.txt_ctlItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 90)
        Me.Panel1.TabIndex = 108
        '
        'chk_isOld
        '
        Me.chk_isOld.Location = New System.Drawing.Point(308, 54)
        Me.chk_isOld.Name = "chk_isOld"
        Me.chk_isOld.Size = New System.Drawing.Size(344, 24)
        Me.chk_isOld.TabIndex = 171
        Me.chk_isOld.Text = "Item is Old (No Longer to be used in future WO)"
        '
        'cmb_Loc
        '
        Me.cmb_Loc.Location = New System.Drawing.Point(128, 32)
        Me.cmb_Loc.Name = "cmb_Loc"
        Me.cmb_Loc.Size = New System.Drawing.Size(224, 21)
        Me.cmb_Loc.TabIndex = 145
        Me.cmb_Loc.Text = "UltraComboEditor1"
        '
        'UltraLabel5
        '
        Appearance29.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance29
        Me.UltraLabel5.Location = New System.Drawing.Point(74, 32)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel5.TabIndex = 117
        Me.UltraLabel5.Text = "Location"
        '
        'UltraLabel8
        '
        Appearance30.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance30
        Me.UltraLabel8.Location = New System.Drawing.Point(74, 59)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel8.TabIndex = 114
        Me.UltraLabel8.Text = "Legend"
        '
        'txt_Legend
        '
        Appearance31.FontData.BoldAsString = "False"
        Appearance31.FontData.ItalicAsString = "False"
        Appearance31.FontData.Name = "Arial"
        Appearance31.FontData.SizeInPoints = 8.25!
        Appearance31.FontData.StrikeoutAsString = "False"
        Appearance31.FontData.UnderlineAsString = "False"
        Me.txt_Legend.Appearance = Appearance31
        Me.txt_Legend.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Legend.Location = New System.Drawing.Point(128, 59)
        Me.txt_Legend.Name = "txt_Legend"
        Me.txt_Legend.Size = New System.Drawing.Size(168, 21)
        Me.txt_Legend.TabIndex = 113
        '
        'UltraLabel2
        '
        Appearance32.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance32
        Me.UltraLabel2.Location = New System.Drawing.Point(42, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(80, 24)
        Me.UltraLabel2.TabIndex = 112
        Me.UltraLabel2.Text = "Item"
        '
        'txt_ctlItem
        '
        Appearance33.FontData.BoldAsString = "False"
        Appearance33.FontData.ItalicAsString = "False"
        Appearance33.FontData.Name = "Arial"
        Appearance33.FontData.SizeInPoints = 8.25!
        Appearance33.FontData.StrikeoutAsString = "False"
        Appearance33.FontData.UnderlineAsString = "False"
        Me.txt_ctlItem.Appearance = Appearance33
        Me.txt_ctlItem.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_ctlItem.Location = New System.Drawing.Point(128, 8)
        Me.txt_ctlItem.Name = "txt_ctlItem"
        Me.txt_ctlItem.Size = New System.Drawing.Size(488, 21)
        Me.txt_ctlItem.TabIndex = 111
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 90)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(688, 428)
        Me.UltraTabControl1.TabIndex = 109
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Specification"
        UltraTab4.TabPage = Me.UltraTabPageControl1
        UltraTab4.Text = "Details"
        UltraTab5.TabPage = Me.UltraTabPageControl4
        UltraTab5.Text = "Component Terminal Sets"
        UltraTab6.TabPage = Me.UltraTabPageControl3
        UltraTab6.Text = "Terminal Sets Master"
        UltraTab7.TabPage = Me.UltraTabPageControl5
        UltraTab7.Text = "Mounting Guide"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(684, 402)
        '
        'CtlItemVMS1
        '
        Me.CtlItemVMS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlItemVMS1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlItemVMS1.ItemVMSID = 0
        Me.CtlItemVMS1.Location = New System.Drawing.Point(0, 56)
        Me.CtlItemVMS1.Mode = risersoft.[shared].EnumVMSMode.acItem
        Me.CtlItemVMS1.Name = "CtlItemVMS1"
        Me.CtlItemVMS1.Size = New System.Drawing.Size(684, 324)
        Me.CtlItemVMS1.TabIndex = 21
        '
        'frmCtl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Control Item"
        Me.ClientSize = New System.Drawing.Size(688, 566)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmCtl"
        Me.Text = "Control Item"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.combo_ItemUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_ItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_ItemId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        Me.UltraTabPageControl7.PerformLayout()
        CType(Me.txt_descrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ctlmake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CatNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txt_GAMakesItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GARating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GANameItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ctlcatid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LugHoleDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_lugtype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_DontPrintInMatList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_MinLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MtgCPID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MtgMBID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_purpose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chk_isOld, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Loc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Legend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ctlItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk_DontPrintInMatList As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_lugtype As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_LugHoleDia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_isOld As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_GAMakesItem As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_GARating As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_GANameItem As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_ctlcatid As Infragistics.Win.UltraWinGrid.UltraCombo

#End Region
End Class

