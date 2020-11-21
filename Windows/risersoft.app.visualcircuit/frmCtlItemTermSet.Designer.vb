<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtlItemTermSet
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CtlXMLVList1 = New risersoft.[shared].win.ctlXMLVList()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_DevSepCable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_CtlTerminalSetID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_TerminalSetName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_DevSepCable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CtlTerminalSetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TerminalSetName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 380)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(701, 48)
        Me.Panel4.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance18.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance18
        Me.btnSave.Location = New System.Drawing.Point(413, 8)
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
        Me.btnCancel.Location = New System.Drawing.Point(509, 8)
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
        Me.btnOK.Location = New System.Drawing.Point(605, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPG Files|*.jpg|GIF Files|*.gif|BMP Files|*.bmp"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CtlXMLVList1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 380)
        Me.Panel1.TabIndex = 25
        '
        'CtlXMLVList1
        '
        Me.CtlXMLVList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlXMLVList1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlXMLVList1.Location = New System.Drawing.Point(0, 121)
        Me.CtlXMLVList1.Name = "CtlXMLVList1"
        Me.CtlXMLVList1.Size = New System.Drawing.Size(401, 259)
        Me.CtlXMLVList1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Controls.Add(Me.txt_TerminalSetName)
        Me.Panel2.Controls.Add(Me.UltraLabel8)
        Me.Panel2.Controls.Add(Me.txt_DevSepCable)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmb_CtlTerminalSetID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(401, 121)
        Me.Panel2.TabIndex = 0
        '
        'UltraLabel8
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance1
        Me.UltraLabel8.Location = New System.Drawing.Point(12, 75)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(248, 34)
        Me.UltraLabel8.TabIndex = 167
        Me.UltraLabel8.Text = "Separate cable number for interconnection originating from this device Terminal S" & _
    "et"
        '
        'txt_DevSepCable
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.ItalicAsString = "False"
        Appearance2.FontData.Name = "Arial"
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.FontData.StrikeoutAsString = "False"
        Appearance2.FontData.UnderlineAsString = "False"
        Me.txt_DevSepCable.Appearance = Appearance2
        Me.txt_DevSepCable.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_DevSepCable.Location = New System.Drawing.Point(266, 75)
        Me.txt_DevSepCable.Name = "txt_DevSepCable"
        Me.txt_DevSepCable.Size = New System.Drawing.Size(72, 21)
        Me.txt_DevSepCable.TabIndex = 166
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Terminal Set"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CtlTerminalSetID
        '
        Me.cmb_CtlTerminalSetID.Location = New System.Drawing.Point(114, 12)
        Me.cmb_CtlTerminalSetID.Name = "cmb_CtlTerminalSetID"
        Me.cmb_CtlTerminalSetID.Size = New System.Drawing.Size(224, 22)
        Me.cmb_CtlTerminalSetID.TabIndex = 164
        Me.cmb_CtlTerminalSetID.Text = "UltraCombo4"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(401, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 380)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'UltraLabel1
        '
        Appearance30.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance30
        Me.UltraLabel1.Location = New System.Drawing.Point(3, 44)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(105, 17)
        Me.UltraLabel1.TabIndex = 169
        Me.UltraLabel1.Text = "Terminal Set Name"
        '
        'txt_TerminalSetName
        '
        Appearance31.FontData.BoldAsString = "False"
        Appearance31.FontData.ItalicAsString = "False"
        Appearance31.FontData.Name = "Arial"
        Appearance31.FontData.SizeInPoints = 8.25!
        Appearance31.FontData.StrikeoutAsString = "False"
        Appearance31.FontData.UnderlineAsString = "False"
        Me.txt_TerminalSetName.Appearance = Appearance31
        Me.txt_TerminalSetName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_TerminalSetName.Location = New System.Drawing.Point(114, 40)
        Me.txt_TerminalSetName.Name = "txt_TerminalSetName"
        Me.txt_TerminalSetName.Size = New System.Drawing.Size(168, 21)
        Me.txt_TerminalSetName.TabIndex = 168
        '
        'frmCtlItemTermSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "Control Item Terminal Set"
        Me.ClientSize = New System.Drawing.Size(701, 428)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmCtlItemTermSet"
        Me.Text = "Control Item Terminal Set"
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_DevSepCable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CtlTerminalSetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TerminalSetName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_CtlTerminalSetID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CtlXMLVList1 As ctlXMLVList
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_DevSepCable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_TerminalSetName As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
