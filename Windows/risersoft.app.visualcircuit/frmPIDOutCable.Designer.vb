Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPIDOutCable
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGrid5 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.UltraGrid4 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_Mode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.btnIC = New Infragistics.Win.Misc.UltraButton()
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLeft.SuspendLayout()
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cmb_Mode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraGrid5
        '
        Me.UltraGrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid5.Location = New System.Drawing.Point(227, 0)
        Me.UltraGrid5.Name = "UltraGrid5"
        Me.UltraGrid5.Size = New System.Drawing.Size(555, 523)
        Me.UltraGrid5.TabIndex = 12
        Me.UltraGrid5.Text = "UltraGrid5"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(217, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 523)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'PanelLeft
        '
        Me.PanelLeft.Controls.Add(Me.UltraGrid4)
        Me.PanelLeft.Controls.Add(Me.Panel2)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(217, 523)
        Me.PanelLeft.TabIndex = 13
        '
        'UltraGrid4
        '
        Me.UltraGrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid4.Name = "UltraGrid4"
        Me.UltraGrid4.Size = New System.Drawing.Size(217, 478)
        Me.UltraGrid4.TabIndex = 11
        Me.UltraGrid4.Text = "UltraGrid4"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmb_Mode)
        Me.Panel2.Controls.Add(Me.btnIC)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 478)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(217, 45)
        Me.Panel2.TabIndex = 0
        '
        'cmb_Mode
        '
        Me.cmb_Mode.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmb_Mode.Location = New System.Drawing.Point(97, 0)
        Me.cmb_Mode.Name = "cmb_Mode"
        Me.cmb_Mode.Size = New System.Drawing.Size(120, 21)
        Me.cmb_Mode.TabIndex = 317
        Me.cmb_Mode.Text = "UltraComboEditor1"
        '
        'btnIC
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnIC.Appearance = Appearance3
        Me.btnIC.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnIC.Location = New System.Drawing.Point(0, 0)
        Me.btnIC.Name = "btnIC"
        Me.btnIC.Size = New System.Drawing.Size(97, 45)
        Me.btnIC.TabIndex = 310
        Me.btnIC.Text = "Print Inter Connection"
        '
        'frmPIDOutCable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Control Items"
        Me.ClientSize = New System.Drawing.Size(782, 523)
        Me.Controls.Add(Me.UltraGrid5)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.PanelLeft)
        Me.Name = "frmPIDOutCable"
        Me.Text = "Control Items"
        CType(Me.UltraGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLeft.ResumeLayout(False)
        CType(Me.UltraGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cmb_Mode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGrid5 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents PanelLeft As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid4 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnIC As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_Mode As Infragistics.Win.UltraWinEditors.UltraComboEditor

#End Region
End Class

