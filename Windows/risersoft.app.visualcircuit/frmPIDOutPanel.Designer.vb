Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPIDOutPanel
    Inherits frmMax

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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid6 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid9 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid8 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid7 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_Mode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnLHPIDU = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnLHPanel = New Infragistics.Win.Misc.UltraButton()
        Me.btnML = New Infragistics.Win.Misc.UltraButton()
        Me.btnWD = New Infragistics.Win.Misc.UltraButton()
        Me.btnTB = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel()
        Me.CtlRTF1 = New risersoft.[shared].win.ctlRTF()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGrid9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGrid8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_Mode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGrid6)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(683, 481)
        '
        'UltraGrid6
        '
        Me.UltraGrid6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid6.Name = "UltraGrid6"
        Me.UltraGrid6.Size = New System.Drawing.Size(683, 481)
        Me.UltraGrid6.TabIndex = 12
        Me.UltraGrid6.Text = "UltraGrid6"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(683, 481)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(683, 481)
        Me.UltraGrid1.TabIndex = 15
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(683, 481)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(683, 481)
        Me.UltraGrid3.TabIndex = 15
        Me.UltraGrid3.Text = "UltraGrid3"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid9)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(683, 481)
        '
        'UltraGrid9
        '
        Me.UltraGrid9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid9.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid9.Name = "UltraGrid9"
        Me.UltraGrid9.Size = New System.Drawing.Size(683, 481)
        Me.UltraGrid9.TabIndex = 18
        Me.UltraGrid9.Text = "UltraGrid9"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGrid8)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(683, 481)
        '
        'UltraGrid8
        '
        Me.UltraGrid8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid8.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid8.Name = "UltraGrid8"
        Me.UltraGrid8.Size = New System.Drawing.Size(683, 481)
        Me.UltraGrid8.TabIndex = 19
        Me.UltraGrid8.Text = "UltraGrid8"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(683, 481)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(683, 481)
        Me.UltraGrid2.TabIndex = 13
        Me.UltraGrid2.Text = "UltraGrid2"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGrid4)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(683, 481)
        '
        'UltraGrid4
        '
        Me.UltraGrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid4.Name = "UltraGrid4"
        Me.UltraGrid4.Size = New System.Drawing.Size(683, 481)
        Me.UltraGrid4.TabIndex = 14
        Me.UltraGrid4.Text = "UltraGrid4"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGrid5)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(683, 481)
        '
        'UltraGrid5
        '
        Me.UltraGrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid5.Name = "UltraGrid5"
        Me.UltraGrid5.Size = New System.Drawing.Size(683, 481)
        Me.UltraGrid5.TabIndex = 14
        Me.UltraGrid5.Text = "UltraGrid5"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraGrid7)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(683, 481)
        '
        'UltraGrid7
        '
        Me.UltraGrid7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid7.Name = "UltraGrid7"
        Me.UltraGrid7.Size = New System.Drawing.Size(683, 481)
        Me.UltraGrid7.TabIndex = 14
        Me.UltraGrid7.Text = "UltraGrid7"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.CtlRTF1)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(1, 1)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(683, 481)
        '
        'UltraTabControl1
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.UltraTabControl1.ActiveTabAppearance = Appearance5
        Appearance4.FontData.SizeInPoints = 10.0!
        Me.UltraTabControl1.Appearance = Appearance4
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl10)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(685, 523)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio
        Me.UltraTabControl1.TabIndex = 4
        Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowAutoSize
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.BottomLeft
        UltraTab7.Key = "tb"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Terminal Blocks"
        UltraTab8.TabPage = Me.UltraTabPageControl1
        UltraTab8.Text = "Wiring Details"
        UltraTab9.TabPage = Me.UltraTabPageControl2
        UltraTab9.Text = "Lug Summary"
        UltraTab10.TabPage = Me.UltraTabPageControl3
        UltraTab10.Text = "Labels"
        UltraTab5.TabPage = Me.UltraTabPageControl9
        UltraTab5.Text = "Hardware"
        UltraTab1.TabPage = Me.UltraTabPageControl4
        UltraTab1.Text = "Material List"
        UltraTab2.TabPage = Me.UltraTabPageControl5
        UltraTab2.Text = "BOM with Rating"
        UltraTab3.TabPage = Me.UltraTabPageControl6
        UltraTab3.Text = "BOM Without Rating"
        UltraTab4.TabPage = Me.UltraTabPageControl8
        UltraTab4.Text = "Legend List"
        UltraTab6.TabPage = Me.UltraTabPageControl10
        UltraTab6.Text = "Notes"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab8, UltraTab9, UltraTab10, UltraTab5, UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab6})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(683, 481)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_Mode)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.btnLHPIDU)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.btnLHPanel)
        Me.Panel1.Controls.Add(Me.btnML)
        Me.Panel1.Controls.Add(Me.btnWD)
        Me.Panel1.Controls.Add(Me.btnTB)
        Me.Panel1.Controls.Add(Me.UltraLabel42)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(685, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(97, 523)
        Me.Panel1.TabIndex = 5
        '
        'cmb_Mode
        '
        Me.cmb_Mode.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmb_Mode.Location = New System.Drawing.Point(0, 333)
        Me.cmb_Mode.Name = "cmb_Mode"
        Me.cmb_Mode.Size = New System.Drawing.Size(97, 21)
        Me.cmb_Mode.TabIndex = 316
        Me.cmb_Mode.Text = "UltraComboEditor1"
        '
        'UltraLabel2
        '
        Appearance7.TextHAlignAsString = "Center"
        Appearance7.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraLabel2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel2.Location = New System.Drawing.Point(0, 306)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(97, 27)
        Me.UltraLabel2.TabIndex = 315
        Me.UltraLabel2.Text = "Print Mode"
        '
        'btnLHPIDU
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnLHPIDU.Appearance = Appearance3
        Me.btnLHPIDU.AutoSize = True
        Me.btnLHPIDU.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLHPIDU.Location = New System.Drawing.Point(0, 256)
        Me.btnLHPIDU.Name = "btnLHPIDU"
        Me.btnLHPIDU.Size = New System.Drawing.Size(97, 50)
        Me.btnLHPIDU.TabIndex = 314
        Me.btnLHPIDU.Text = "Labels, Hardware and Lugs"
        '
        'UltraLabel1
        '
        Appearance11.TextHAlignAsString = "Center"
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance11
        Me.UltraLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel1.Location = New System.Drawing.Point(0, 202)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(97, 54)
        Me.UltraLabel1.TabIndex = 313
        Me.UltraLabel1.Text = "Print Menu Work Order"
        '
        'btnLHPanel
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnLHPanel.Appearance = Appearance2
        Me.btnLHPanel.AutoSize = True
        Me.btnLHPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLHPanel.Location = New System.Drawing.Point(0, 152)
        Me.btnLHPanel.Name = "btnLHPanel"
        Me.btnLHPanel.Size = New System.Drawing.Size(97, 50)
        Me.btnLHPanel.TabIndex = 311
        Me.btnLHPanel.Text = "Labels, Hardware and Lugs"
        '
        'btnML
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btnML.Appearance = Appearance6
        Me.btnML.AutoSize = True
        Me.btnML.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnML.Location = New System.Drawing.Point(0, 128)
        Me.btnML.Name = "btnML"
        Me.btnML.Size = New System.Drawing.Size(97, 24)
        Me.btnML.TabIndex = 310
        Me.btnML.Text = "Material List"
        '
        'btnWD
        '
        Appearance8.FontData.BoldAsString = "True"
        Me.btnWD.Appearance = Appearance8
        Me.btnWD.AutoSize = True
        Me.btnWD.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnWD.Location = New System.Drawing.Point(0, 91)
        Me.btnWD.Name = "btnWD"
        Me.btnWD.Size = New System.Drawing.Size(97, 37)
        Me.btnWD.TabIndex = 309
        Me.btnWD.Text = "Wiring Diagram"
        '
        'btnTB
        '
        Appearance9.FontData.BoldAsString = "True"
        Me.btnTB.Appearance = Appearance9
        Me.btnTB.AutoSize = True
        Me.btnTB.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTB.Location = New System.Drawing.Point(0, 54)
        Me.btnTB.Name = "btnTB"
        Me.btnTB.Size = New System.Drawing.Size(97, 37)
        Me.btnTB.TabIndex = 308
        Me.btnTB.Text = "Terminal Block Diagram"
        '
        'UltraLabel42
        '
        Appearance10.TextHAlignAsString = "Center"
        Me.UltraLabel42.Appearance = Appearance10
        Me.UltraLabel42.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraLabel42.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel42.Location = New System.Drawing.Point(0, 0)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(97, 54)
        Me.UltraLabel42.TabIndex = 307
        Me.UltraLabel42.Text = "Print Menu Panel"
        '
        'CtlRTF1
        '
        Me.CtlRTF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlRTF1.EditEnabled = True
        Me.CtlRTF1.Location = New System.Drawing.Point(0, 0)
        Me.CtlRTF1.Name = "CtlRTF1"
        Me.CtlRTF1.Size = New System.Drawing.Size(683, 481)
        Me.CtlRTF1.TabIndex = 1
        '
        'frmPIDOutPanel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Control Items"
        Me.ClientSize = New System.Drawing.Size(782, 523)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPIDOutPanel"
        Me.Text = "Control Items"
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGrid9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGrid8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.UltraGrid7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_Mode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid6 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid9 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGrid7 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid8 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnTB As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLHPanel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnML As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnWD As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLHPIDU As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_Mode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents CtlRTF1 As risersoft.shared.win.ctlRTF

#End Region
End Class

