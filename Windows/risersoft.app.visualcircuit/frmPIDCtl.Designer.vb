Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPIDCtl
    Inherits risersoft.shared.win.frmMax
   
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
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CtlXMLVList1 As risersoft.shared.win.ctlXMLVList
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnMake As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmb_Location As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblMake As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_DescripSuffix As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_descripPrefix As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents combo_ctlcat As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents combo_SuppSpec As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents combo_Spec As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents combo_Make As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents combo_ItemCode As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents combo_MtgID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_CtlItemID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnSelect As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_Legend As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkMax As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Price As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_ctlCat As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_purpose As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnAddTS As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditTS As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelTS As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlXMLVList1 = New risersoft.[shared].win.ctlXMLVList()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnMake = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMoveUp = New Infragistics.Win.Misc.UltraButton()
        Me.btnMoveDown = New Infragistics.Win.Misc.UltraButton()
        Me.btnReBuild = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_LegendCable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_GAUse = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.LabelOK = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_IsParTB = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_Location = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblMake = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_DescripSuffix = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_descripPrefix = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.combo_ctlcat = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.combo_SuppSpec = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.combo_Spec = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.combo_Make = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.combo_ItemCode = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.CtlRTF1 = New risersoft.[shared].win.ctlRTF()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.combo_MtgID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDelLabel = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddLabel = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnDelLabelText = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddLabelText = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Price = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_ctlCat = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_purpose = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnAddTS = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditTS = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelTS = New Infragistics.Win.Misc.UltraButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkMax = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnSelect = New Infragistics.Win.Misc.UltraButton()
        Me.cmb_CtlItemID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Legend = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.txt_LegendCable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_GAUse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsParTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DescripSuffix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descripPrefix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_ctlcat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_SuppSpec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_Spec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_Make, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_ItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.combo_MtgID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ctlCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chkMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CtlItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Legend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.CtlXMLVList1)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(383, 329)
        '
        'CtlXMLVList1
        '
        Me.CtlXMLVList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlXMLVList1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlXMLVList1.Location = New System.Drawing.Point(0, 0)
        Me.CtlXMLVList1.Name = "CtlXMLVList1"
        Me.CtlXMLVList1.Size = New System.Drawing.Size(383, 298)
        Me.CtlXMLVList1.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnMake)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 298)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(383, 31)
        Me.Panel6.TabIndex = 24
        '
        'btnMake
        '
        Me.btnMake.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMake.Location = New System.Drawing.Point(303, 3)
        Me.btnMake.Name = "btnMake"
        Me.btnMake.Size = New System.Drawing.Size(64, 23)
        Me.btnMake.TabIndex = 5
        Me.btnMake.Text = "Make"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl6.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(383, 329)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(383, 290)
        Me.UltraGrid1.TabIndex = 25
        Me.UltraGrid1.Text = "Terminals"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnMoveUp)
        Me.Panel3.Controls.Add(Me.btnMoveDown)
        Me.Panel3.Controls.Add(Me.btnReBuild)
        Me.Panel3.Controls.Add(Me.btnDel)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 290)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(383, 39)
        Me.Panel3.TabIndex = 23
        '
        'btnMoveUp
        '
        Me.btnMoveUp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMoveUp.Location = New System.Drawing.Point(33, 0)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(79, 39)
        Me.btnMoveUp.TabIndex = 8
        Me.btnMoveUp.Text = "Move Up"
        '
        'btnMoveDown
        '
        Me.btnMoveDown.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMoveDown.Location = New System.Drawing.Point(112, 0)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(79, 39)
        Me.btnMoveDown.TabIndex = 7
        Me.btnMoveDown.Text = "Move Down"
        '
        'btnReBuild
        '
        Me.btnReBuild.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnReBuild.Location = New System.Drawing.Point(191, 0)
        Me.btnReBuild.Name = "btnReBuild"
        Me.btnReBuild.Size = New System.Drawing.Size(64, 39)
        Me.btnReBuild.TabIndex = 6
        Me.btnReBuild.Text = "Re-Build"
        '
        'btnDel
        '
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDel.Location = New System.Drawing.Point(255, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 39)
        Me.btnDel.TabIndex = 5
        Me.btnDel.Text = "Remove"
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEdit.Location = New System.Drawing.Point(319, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(64, 39)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Edit"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_LegendCable)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel19)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel18)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_GAUse)
        Me.UltraTabPageControl2.Controls.Add(Me.LabelOK)
        Me.UltraTabPageControl2.Controls.Add(Me.chk_IsParTB)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_Location)
        Me.UltraTabPageControl2.Controls.Add(Me.lblMake)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel9)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_Qty)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel12)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_DescripSuffix)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel16)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_descripPrefix)
        Me.UltraTabPageControl2.Controls.Add(Me.combo_ctlcat)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel8)
        Me.UltraTabPageControl2.Controls.Add(Me.combo_SuppSpec)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl2.Controls.Add(Me.combo_Spec)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl2.Controls.Add(Me.combo_Make)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl2.Controls.Add(Me.combo_ItemCode)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel15)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(725, 355)
        '
        'txt_LegendCable
        '
        Appearance8.FontData.BoldAsString = "False"
        Appearance8.FontData.ItalicAsString = "False"
        Appearance8.FontData.Name = "Arial"
        Appearance8.FontData.SizeInPoints = 8.25!
        Appearance8.FontData.StrikeoutAsString = "False"
        Appearance8.FontData.UnderlineAsString = "False"
        Me.txt_LegendCable.Appearance = Appearance8
        Me.txt_LegendCable.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_LegendCable.Location = New System.Drawing.Point(127, 286)
        Me.txt_LegendCable.Name = "txt_LegendCable"
        Me.txt_LegendCable.Size = New System.Drawing.Size(168, 21)
        Me.txt_LegendCable.TabIndex = 227
        '
        'UltraLabel19
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel19.Appearance = Appearance7
        Me.UltraLabel19.Location = New System.Drawing.Point(18, 290)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(101, 17)
        Me.UltraLabel19.TabIndex = 228
        Me.UltraLabel19.Text = "Legend Cable"
        '
        'UltraLabel18
        '
        Appearance19.TextHAlignAsString = "Right"
        Me.UltraLabel18.Appearance = Appearance19
        Me.UltraLabel18.Location = New System.Drawing.Point(-23, 319)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(144, 16)
        Me.UltraLabel18.TabIndex = 226
        Me.UltraLabel18.Text = "GA use"
        '
        'cmb_GAUse
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.FontData.SizeInPoints = 10.0!
        Me.cmb_GAUse.Appearance = Appearance2
        Me.cmb_GAUse.Location = New System.Drawing.Point(127, 313)
        Me.cmb_GAUse.Name = "cmb_GAUse"
        Me.cmb_GAUse.Size = New System.Drawing.Size(364, 24)
        Me.cmb_GAUse.TabIndex = 225
        '
        'LabelOK
        '
        Appearance30.ForeColor = System.Drawing.Color.Green
        Appearance30.TextHAlignAsString = "Left"
        Me.LabelOK.Appearance = Appearance30
        Me.LabelOK.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOK.Location = New System.Drawing.Point(402, 98)
        Me.LabelOK.Name = "LabelOK"
        Me.LabelOK.Size = New System.Drawing.Size(222, 22)
        Me.LabelOK.TabIndex = 147
        Me.LabelOK.Text = "Item is Current"
        '
        'chk_IsParTB
        '
        Me.chk_IsParTB.Location = New System.Drawing.Point(402, 9)
        Me.chk_IsParTB.Name = "chk_IsParTB"
        Me.chk_IsParTB.Size = New System.Drawing.Size(289, 24)
        Me.chk_IsParTB.TabIndex = 146
        Me.chk_IsParTB.Text = "Device is used for parallelling between similar panels"
        '
        'cmb_Location
        '
        Me.cmb_Location.Location = New System.Drawing.Point(127, 205)
        Me.cmb_Location.Name = "cmb_Location"
        Me.cmb_Location.ReadOnly = True
        Me.cmb_Location.Size = New System.Drawing.Size(224, 21)
        Me.cmb_Location.TabIndex = 144
        Me.cmb_Location.Text = "UltraComboEditor1"
        '
        'lblMake
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.lblMake.Appearance = Appearance11
        Me.lblMake.Location = New System.Drawing.Point(71, 205)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(48, 24)
        Me.lblMake.TabIndex = 143
        Me.lblMake.Text = "Location"
        '
        'UltraLabel9
        '
        Appearance38.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance38
        Me.UltraLabel9.Location = New System.Drawing.Point(73, 236)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 17)
        Me.UltraLabel9.TabIndex = 142
        Me.UltraLabel9.Text = "Qty"
        '
        'txt_Qty
        '
        Appearance39.FontData.BoldAsString = "False"
        Appearance39.FontData.ItalicAsString = "False"
        Appearance39.FontData.Name = "Arial"
        Appearance39.FontData.SizeInPoints = 8.25!
        Appearance39.FontData.StrikeoutAsString = "False"
        Appearance39.FontData.UnderlineAsString = "False"
        Me.txt_Qty.Appearance = Appearance39
        Me.txt_Qty.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Qty.Location = New System.Drawing.Point(127, 232)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Size = New System.Drawing.Size(168, 21)
        Me.txt_Qty.TabIndex = 141
        '
        'UltraLabel12
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel12.Appearance = Appearance5
        Me.UltraLabel12.Location = New System.Drawing.Point(377, 262)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(41, 18)
        Me.UltraLabel12.TabIndex = 140
        Me.UltraLabel12.Text = "Suffix"
        '
        'txt_DescripSuffix
        '
        Appearance6.FontData.BoldAsString = "False"
        Appearance6.FontData.ItalicAsString = "False"
        Appearance6.FontData.Name = "Arial"
        Appearance6.FontData.SizeInPoints = 8.25!
        Appearance6.FontData.StrikeoutAsString = "False"
        Appearance6.FontData.UnderlineAsString = "False"
        Me.txt_DescripSuffix.Appearance = Appearance6
        Me.txt_DescripSuffix.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DescripSuffix.Location = New System.Drawing.Point(424, 259)
        Me.txt_DescripSuffix.Multiline = True
        Me.txt_DescripSuffix.Name = "txt_DescripSuffix"
        Me.txt_DescripSuffix.Size = New System.Drawing.Size(267, 21)
        Me.txt_DescripSuffix.TabIndex = 139
        '
        'UltraLabel16
        '
        Appearance15.TextHAlignAsString = "Right"
        Me.UltraLabel16.Appearance = Appearance15
        Me.UltraLabel16.Location = New System.Drawing.Point(-18, 262)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(137, 18)
        Me.UltraLabel16.TabIndex = 136
        Me.UltraLabel16.Text = "Description Prefix"
        '
        'txt_descripPrefix
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.ItalicAsString = "False"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.FontData.StrikeoutAsString = "False"
        Appearance4.FontData.UnderlineAsString = "False"
        Me.txt_descripPrefix.Appearance = Appearance4
        Me.txt_descripPrefix.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_descripPrefix.Location = New System.Drawing.Point(127, 259)
        Me.txt_descripPrefix.Multiline = True
        Me.txt_descripPrefix.Name = "txt_descripPrefix"
        Me.txt_descripPrefix.Size = New System.Drawing.Size(244, 21)
        Me.txt_descripPrefix.TabIndex = 135
        '
        'combo_ctlcat
        '
        Me.combo_ctlcat.DisplayMember = "CtlCat"
        Me.combo_ctlcat.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.combo_ctlcat.Location = New System.Drawing.Point(127, 13)
        Me.combo_ctlcat.Name = "combo_ctlcat"
        Me.combo_ctlcat.ReadOnly = True
        Me.combo_ctlcat.Size = New System.Drawing.Size(224, 22)
        Me.combo_ctlcat.TabIndex = 134
        Me.combo_ctlcat.ValueMember = "CtlItemID"
        '
        'UltraLabel8
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance12
        Me.UltraLabel8.Location = New System.Drawing.Point(33, 14)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(88, 24)
        Me.UltraLabel8.TabIndex = 133
        Me.UltraLabel8.Text = "Item Category"
        '
        'combo_SuppSpec
        '
        Me.combo_SuppSpec.DisplayMember = "SuppSpec"
        Me.combo_SuppSpec.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.combo_SuppSpec.Location = New System.Drawing.Point(127, 154)
        Me.combo_SuppSpec.Name = "combo_SuppSpec"
        Me.combo_SuppSpec.ReadOnly = True
        Me.combo_SuppSpec.Size = New System.Drawing.Size(224, 22)
        Me.combo_SuppSpec.TabIndex = 132
        Me.combo_SuppSpec.ValueMember = "CtlItemID"
        '
        'UltraLabel6
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance17
        Me.UltraLabel6.Location = New System.Drawing.Point(11, 154)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(110, 22)
        Me.UltraLabel6.TabIndex = 131
        Me.UltraLabel6.Text = "Supplier Spec"
        '
        'combo_Spec
        '
        Me.combo_Spec.DisplayMember = "Spec"
        Me.combo_Spec.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.combo_Spec.Location = New System.Drawing.Point(127, 126)
        Me.combo_Spec.Name = "combo_Spec"
        Me.combo_Spec.ReadOnly = True
        Me.combo_Spec.Size = New System.Drawing.Size(224, 22)
        Me.combo_Spec.TabIndex = 130
        Me.combo_Spec.ValueMember = "CtlItemID"
        '
        'UltraLabel5
        '
        Appearance32.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance32
        Me.UltraLabel5.Location = New System.Drawing.Point(63, 126)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(58, 22)
        Me.UltraLabel5.TabIndex = 129
        Me.UltraLabel5.Text = "Spec"
        '
        'combo_Make
        '
        Me.combo_Make.DisplayMember = "Make"
        Me.combo_Make.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.combo_Make.Location = New System.Drawing.Point(127, 98)
        Me.combo_Make.Name = "combo_Make"
        Me.combo_Make.ReadOnly = True
        Me.combo_Make.Size = New System.Drawing.Size(224, 22)
        Me.combo_Make.TabIndex = 128
        Me.combo_Make.ValueMember = "CtlItemID"
        '
        'UltraLabel2
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.Location = New System.Drawing.Point(63, 98)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(58, 22)
        Me.UltraLabel2.TabIndex = 127
        Me.UltraLabel2.Text = "Make"
        '
        'combo_ItemCode
        '
        Me.combo_ItemCode.DisplayMember = "itemCode"
        Me.combo_ItemCode.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.combo_ItemCode.Location = New System.Drawing.Point(127, 41)
        Me.combo_ItemCode.Name = "combo_ItemCode"
        Me.combo_ItemCode.ReadOnly = True
        Me.combo_ItemCode.Size = New System.Drawing.Size(224, 22)
        Me.combo_ItemCode.TabIndex = 122
        Me.combo_ItemCode.ValueMember = "CtlItemID"
        '
        'UltraLabel15
        '
        Appearance33.TextHAlignAsString = "Right"
        Me.UltraLabel15.Appearance = Appearance33
        Me.UltraLabel15.Location = New System.Drawing.Point(63, 41)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(58, 23)
        Me.UltraLabel15.TabIndex = 124
        Me.UltraLabel15.Text = "Item Code"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraTabControl2)
        Me.UltraTabPageControl4.Controls.Add(Me.PictureBox1)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(725, 355)
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(338, 0)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(387, 355)
        Me.UltraTabControl2.TabIndex = 1
        UltraTab3.Key = "def"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Definition"
        UltraTab6.Key = "alloc"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Allocation"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab6})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(383, 329)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 355)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.CtlRTF1)
        Me.UltraTabPageControl5.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(725, 355)
        '
        'CtlRTF1
        '
        Me.CtlRTF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlRTF1.EditEnabled = True
        Me.CtlRTF1.Location = New System.Drawing.Point(0, 71)
        Me.CtlRTF1.Name = "CtlRTF1"
        Me.CtlRTF1.Size = New System.Drawing.Size(725, 284)
        Me.CtlRTF1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.combo_MtgID)
        Me.Panel2.Controls.Add(Me.UltraLabel17)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(725, 71)
        Me.Panel2.TabIndex = 1
        '
        'combo_MtgID
        '
        Me.combo_MtgID.DisplayMember = "MtgMBID"
        Me.combo_MtgID.Location = New System.Drawing.Point(127, 24)
        Me.combo_MtgID.Name = "combo_MtgID"
        Me.combo_MtgID.ReadOnly = True
        Me.combo_MtgID.Size = New System.Drawing.Size(224, 22)
        Me.combo_MtgID.TabIndex = 130
        Me.combo_MtgID.ValueMember = "CtlItemID"
        '
        'UltraLabel17
        '
        Appearance16.TextHAlignAsString = "Right"
        Me.UltraLabel17.Appearance = Appearance16
        Me.UltraLabel17.Location = New System.Drawing.Point(11, 24)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(110, 22)
        Me.UltraLabel17.TabIndex = 129
        Me.UltraLabel17.Text = "Mounting"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(725, 355)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDelLabel)
        Me.Panel5.Controls.Add(Me.btnAddLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 324)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(725, 31)
        Me.Panel5.TabIndex = 23
        '
        'btnDelLabel
        '
        Me.btnDelLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelLabel.Location = New System.Drawing.Point(597, 0)
        Me.btnDelLabel.Name = "btnDelLabel"
        Me.btnDelLabel.Size = New System.Drawing.Size(64, 31)
        Me.btnDelLabel.TabIndex = 7
        Me.btnDelLabel.Text = "Delete"
        '
        'btnAddLabel
        '
        Me.btnAddLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddLabel.Location = New System.Drawing.Point(661, 0)
        Me.btnAddLabel.Name = "btnAddLabel"
        Me.btnAddLabel.Size = New System.Drawing.Size(64, 31)
        Me.btnAddLabel.TabIndex = 6
        Me.btnAddLabel.Text = "Add"
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(725, 355)
        Me.UltraGrid2.TabIndex = 24
        Me.UltraGrid2.Text = "Terminals"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(725, 355)
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnDelLabelText)
        Me.Panel7.Controls.Add(Me.btnAddLabelText)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 324)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(725, 31)
        Me.Panel7.TabIndex = 25
        '
        'btnDelLabelText
        '
        Me.btnDelLabelText.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelLabelText.Location = New System.Drawing.Point(597, 0)
        Me.btnDelLabelText.Name = "btnDelLabelText"
        Me.btnDelLabelText.Size = New System.Drawing.Size(64, 31)
        Me.btnDelLabelText.TabIndex = 7
        Me.btnDelLabelText.Text = "Delete"
        '
        'btnAddLabelText
        '
        Me.btnAddLabelText.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddLabelText.Location = New System.Drawing.Point(661, 0)
        Me.btnAddLabelText.Name = "btnAddLabelText"
        Me.btnAddLabelText.Size = New System.Drawing.Size(64, 31)
        Me.btnAddLabelText.TabIndex = 6
        Me.btnAddLabelText.Text = "Add"
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(725, 355)
        Me.UltraGrid3.TabIndex = 26
        Me.UltraGrid3.Text = "Terminals"
        '
        'UltraLabel11
        '
        Appearance21.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance21
        Me.UltraLabel11.Location = New System.Drawing.Point(399, 278)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel11.TabIndex = 120
        Me.UltraLabel11.Text = "Mtg Code CP"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(16, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Mounting CP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(16, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Mounting MB"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraLabel10
        '
        Appearance34.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance34
        Me.UltraLabel10.Location = New System.Drawing.Point(74, 133)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel10.TabIndex = 123
        Me.UltraLabel10.Text = "Price"
        '
        'UltraLabel7
        '
        Appearance25.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance25
        Me.UltraLabel7.Location = New System.Drawing.Point(377, 233)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel7.TabIndex = 115
        Me.UltraLabel7.Text = "Mtg Code MB"
        '
        'txt_Price
        '
        Appearance35.FontData.BoldAsString = "False"
        Appearance35.FontData.ItalicAsString = "False"
        Appearance35.FontData.Name = "Arial"
        Appearance35.FontData.SizeInPoints = 8.25!
        Appearance35.FontData.StrikeoutAsString = "False"
        Appearance35.FontData.UnderlineAsString = "False"
        Me.txt_Price.Appearance = Appearance35
        Me.txt_Price.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Price.Location = New System.Drawing.Point(128, 133)
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(136, 21)
        Me.txt_Price.TabIndex = 122
        '
        'UltraLabel4
        '
        Appearance36.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance36
        Me.UltraLabel4.Location = New System.Drawing.Point(41, 176)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(80, 40)
        Me.UltraLabel4.TabIndex = 121
        Me.UltraLabel4.Text = "Remark"
        '
        'txt_Remark
        '
        Appearance37.FontData.BoldAsString = "False"
        Appearance37.FontData.ItalicAsString = "False"
        Appearance37.FontData.Name = "Arial"
        Appearance37.FontData.SizeInPoints = 8.25!
        Appearance37.FontData.StrikeoutAsString = "False"
        Appearance37.FontData.UnderlineAsString = "False"
        Me.txt_Remark.Appearance = Appearance37
        Me.txt_Remark.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Remark.Location = New System.Drawing.Point(127, 176)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(496, 40)
        Me.txt_Remark.TabIndex = 120
        '
        'cmb_ctlCat
        '
        Me.cmb_ctlCat.Location = New System.Drawing.Point(127, 47)
        Me.cmb_ctlCat.Name = "cmb_ctlCat"
        Me.cmb_ctlCat.Size = New System.Drawing.Size(224, 21)
        Me.cmb_ctlCat.TabIndex = 118
        Me.cmb_ctlCat.Text = "UltraComboEditor1"
        '
        'UltraLabel3
        '
        Appearance31.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance31
        Me.UltraLabel3.Location = New System.Drawing.Point(33, 47)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(88, 24)
        Me.UltraLabel3.TabIndex = 113
        Me.UltraLabel3.Text = "Item Category"
        '
        'UltraLabel1
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance13
        Me.UltraLabel1.Location = New System.Drawing.Point(57, 90)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 24)
        Me.UltraLabel1.TabIndex = 110
        Me.UltraLabel1.Text = "Purpose"
        '
        'txt_purpose
        '
        Appearance14.FontData.BoldAsString = "False"
        Appearance14.FontData.ItalicAsString = "False"
        Appearance14.FontData.Name = "Arial"
        Appearance14.FontData.SizeInPoints = 8.25!
        Appearance14.FontData.StrikeoutAsString = "False"
        Appearance14.FontData.UnderlineAsString = "False"
        Me.txt_purpose.Appearance = Appearance14
        Me.txt_purpose.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_purpose.Location = New System.Drawing.Point(127, 90)
        Me.txt_purpose.Name = "txt_purpose"
        Me.txt_purpose.Size = New System.Drawing.Size(296, 21)
        Me.txt_purpose.TabIndex = 108
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnAddTS)
        Me.Panel9.Controls.Add(Me.btnEditTS)
        Me.Panel9.Controls.Add(Me.btnDelTS)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 310)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(725, 45)
        Me.Panel9.TabIndex = 19
        '
        'btnAddTS
        '
        Me.btnAddTS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTS.Location = New System.Drawing.Point(492, 9)
        Me.btnAddTS.Name = "btnAddTS"
        Me.btnAddTS.Size = New System.Drawing.Size(64, 23)
        Me.btnAddTS.TabIndex = 13
        Me.btnAddTS.Text = "Add"
        '
        'btnEditTS
        '
        Me.btnEditTS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditTS.Location = New System.Drawing.Point(572, 9)
        Me.btnEditTS.Name = "btnEditTS"
        Me.btnEditTS.Size = New System.Drawing.Size(64, 23)
        Me.btnEditTS.TabIndex = 4
        Me.btnEditTS.Text = "Edit"
        '
        'btnDelTS
        '
        Me.btnDelTS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelTS.Location = New System.Drawing.Point(652, 9)
        Me.btnDelTS.Name = "btnDelTS"
        Me.btnDelTS.Size = New System.Drawing.Size(64, 23)
        Me.btnDelTS.TabIndex = 3
        Me.btnDelTS.Text = "Delete"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 471)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(729, 48)
        Me.Panel4.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance18.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance18
        Me.btnSave.Location = New System.Drawing.Point(441, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance22.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance22
        Me.btnCancel.Location = New System.Drawing.Point(537, 8)
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
        Me.btnOK.Location = New System.Drawing.Point(633, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkMax)
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.cmb_CtlItemID)
        Me.Panel1.Controls.Add(Me.UltraLabel14)
        Me.Panel1.Controls.Add(Me.txt_Legend)
        Me.Panel1.Controls.Add(Me.UltraLabel13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 90)
        Me.Panel1.TabIndex = 108
        '
        'chkMax
        '
        Me.chkMax.Location = New System.Drawing.Point(394, 47)
        Me.chkMax.Name = "chkMax"
        Me.chkMax.Size = New System.Drawing.Size(145, 24)
        Me.chkMax.TabIndex = 145
        Me.chkMax.Text = "Open Items Maximized"
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnSelect.Location = New System.Drawing.Point(257, 47)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(72, 24)
        Me.btnSelect.TabIndex = 135
        Me.btnSelect.Text = "Select"
        '
        'cmb_CtlItemID
        '
        Me.cmb_CtlItemID.DisplayMember = "Item"
        Me.cmb_CtlItemID.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cmb_CtlItemID.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmb_CtlItemID.Location = New System.Drawing.Point(83, 13)
        Me.cmb_CtlItemID.Name = "cmb_CtlItemID"
        Me.cmb_CtlItemID.ReadOnly = True
        Me.cmb_CtlItemID.Size = New System.Drawing.Size(634, 22)
        Me.cmb_CtlItemID.TabIndex = 126
        Me.cmb_CtlItemID.ValueMember = "CtlItemID"
        '
        'UltraLabel14
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel14.Appearance = Appearance3
        Me.UltraLabel14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel14.Location = New System.Drawing.Point(19, 13)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(58, 22)
        Me.UltraLabel14.TabIndex = 127
        Me.UltraLabel14.Text = "Item"
        '
        'txt_Legend
        '
        Appearance9.FontData.BoldAsString = "False"
        Appearance9.FontData.ItalicAsString = "False"
        Appearance9.FontData.Name = "Arial"
        Appearance9.FontData.SizeInPoints = 8.25!
        Appearance9.FontData.StrikeoutAsString = "False"
        Appearance9.FontData.UnderlineAsString = "False"
        Me.txt_Legend.Appearance = Appearance9
        Me.txt_Legend.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Legend.Location = New System.Drawing.Point(83, 47)
        Me.txt_Legend.Name = "txt_Legend"
        Me.txt_Legend.Size = New System.Drawing.Size(168, 21)
        Me.txt_Legend.TabIndex = 137
        '
        'UltraLabel13
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel13.Appearance = Appearance10
        Me.UltraLabel13.Location = New System.Drawing.Point(35, 47)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel13.TabIndex = 138
        Me.UltraLabel13.Text = "Legend"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 90)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(729, 381)
        Me.UltraTabControl1.TabIndex = 110
        UltraTab1.TabPage = Me.UltraTabPageControl2
        UltraTab1.Text = "Specification"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Terminals"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Mounting"
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "Label Items"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Label Texts"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab4, UltraTab5, UltraTab2, UltraTab7})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(725, 355)
        '
        'frmPIDCtl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Control Item in Scheme"
        Me.ClientSize = New System.Drawing.Size(729, 519)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPIDCtl"
        Me.Text = "Control Item in Scheme"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.txt_LegendCable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_GAUse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsParTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DescripSuffix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descripPrefix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_ctlcat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_SuppSpec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_Spec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_Make, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_ItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.combo_MtgID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ctlCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_purpose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chkMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CtlItemID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Legend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk_IsParTB As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnDelLabel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddLabel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnReBuild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents LabelOK As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents CtlRTF1 As risersoft.shared.win.ctlRTF
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_GAUse As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnMoveUp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnMoveDown As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_LegendCable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnDelLabelText As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddLabelText As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid

#End Region
End Class

