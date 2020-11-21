Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPIDSchemePanel
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
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmb_pValueA As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_pValueA = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panelbtn = New System.Windows.Forms.Panel()
        Me.btnCopyWireNos = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopy = New Infragistics.Win.Misc.UltraButton()
        Me.btnAssignBus = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopyMB = New Infragistics.Win.Misc.UltraButton()
        Me.btn_EditDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_pValueA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelbtn.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(770, 394)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(770, 394)
        Me.UltraGrid1.TabIndex = 8
        Me.UltraGrid1.Text = "UltraGrid1"
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
        Appearance9.TextHAlignAsString = "Center"
        Me.UltraTextEditor1.Appearance = Appearance9
        Me.UltraTextEditor1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraTextEditor1.Location = New System.Drawing.Point(72, 104)
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(64, 21)
        Me.UltraTextEditor1.TabIndex = 291
        Me.UltraTextEditor1.Text = "UltraTextEditor8"
        '
        'Panelbtn
        '
        Me.Panelbtn.Controls.Add(Me.btnCopyWireNos)
        Me.Panelbtn.Controls.Add(Me.btnCopy)
        Me.Panelbtn.Controls.Add(Me.btnAssignBus)
        Me.Panelbtn.Controls.Add(Me.btnCopyMB)
        Me.Panelbtn.Controls.Add(Me.btn_EditDoc)
        Me.Panelbtn.Controls.Add(Me.btnDelDoc)
        Me.Panelbtn.Controls.Add(Me.btnAddDoc)
        Me.Panelbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panelbtn.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panelbtn.Location = New System.Drawing.Point(0, 416)
        Me.Panelbtn.Name = "Panelbtn"
        Me.Panelbtn.Size = New System.Drawing.Size(770, 40)
        Me.Panelbtn.TabIndex = 7
        '
        'btnCopyWireNos
        '
        Me.btnCopyWireNos.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCopyWireNos.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnCopyWireNos.Location = New System.Drawing.Point(328, 0)
        Me.btnCopyWireNos.Name = "btnCopyWireNos"
        Me.btnCopyWireNos.Size = New System.Drawing.Size(156, 40)
        Me.btnCopyWireNos.TabIndex = 4
        Me.btnCopyWireNos.Text = "Copy Wire Nos to clipboard"
        '
        'btnCopy
        '
        Me.btnCopy.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCopy.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnCopy.Location = New System.Drawing.Point(484, 0)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(72, 40)
        Me.btnCopy.TabIndex = 9
        Me.btnCopy.Text = "&Copy"
        '
        'btnAssignBus
        '
        Me.btnAssignBus.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAssignBus.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAssignBus.Location = New System.Drawing.Point(70, 0)
        Me.btnAssignBus.Name = "btnAssignBus"
        Me.btnAssignBus.Size = New System.Drawing.Size(70, 40)
        Me.btnAssignBus.TabIndex = 8
        Me.btnAssignBus.Text = "Assign Bus"
        '
        'btnCopyMB
        '
        Me.btnCopyMB.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCopyMB.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnCopyMB.Location = New System.Drawing.Point(0, 0)
        Me.btnCopyMB.Name = "btnCopyMB"
        Me.btnCopyMB.Size = New System.Drawing.Size(70, 40)
        Me.btnCopyMB.TabIndex = 7
        Me.btnCopyMB.Text = "Copy From"
        '
        'btn_EditDoc
        '
        Me.btn_EditDoc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_EditDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btn_EditDoc.Location = New System.Drawing.Point(556, 0)
        Me.btn_EditDoc.Name = "btn_EditDoc"
        Me.btn_EditDoc.Size = New System.Drawing.Size(72, 40)
        Me.btn_EditDoc.TabIndex = 3
        Me.btn_EditDoc.Text = "&Edit"
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelDoc.Location = New System.Drawing.Point(628, 0)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 40)
        Me.btnDelDoc.TabIndex = 2
        Me.btnDelDoc.Text = "&Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddDoc.Location = New System.Drawing.Point(698, 0)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 40)
        Me.btnAddDoc.TabIndex = 0
        Me.btnAddDoc.Text = "&Add New"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(770, 416)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.StateButtons
        Me.UltraTabControl1.TabIndex = 8
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.BottomLeft
        UltraTab1.Key = "det"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Detail View"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(770, 394)
        '
        'frmPIDSchemePanel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Scheme Panel"
        Me.ClientSize = New System.Drawing.Size(770, 456)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panelbtn)
        Me.Name = "frmPIDSchemePanel"
        Me.Text = "Scheme Panel"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_pValueA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelbtn.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panelbtn As System.Windows.Forms.Panel
    Friend WithEvents btnCopyWireNos As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_EditDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnCopyMB As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAssignBus As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCopy As Infragistics.Win.Misc.UltraButton

#End Region
End Class

