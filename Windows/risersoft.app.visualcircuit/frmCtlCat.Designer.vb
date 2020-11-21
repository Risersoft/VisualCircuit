<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmCtlCat
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_CtlCat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_GANameCat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_GAMakesCat = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_CtlCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GANameCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GAMakesCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 274)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(483, 48)
        Me.Panel4.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(195, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(291, 8)
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
        Me.btnOK.Location = New System.Drawing.Point(387, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'UltraLabel2
        '
        Appearance18.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance18
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel2.Location = New System.Drawing.Point(100, 34)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel2.TabIndex = 178
        Me.UltraLabel2.Text = "Name"
        '
        'txt_CtlCat
        '
        Appearance19.FontData.BoldAsString = "False"
        Appearance19.FontData.ItalicAsString = "False"
        Appearance19.FontData.Name = "Arial"
        Appearance19.FontData.SizeInPoints = 8.25!
        Appearance19.FontData.StrikeoutAsString = "False"
        Appearance19.FontData.UnderlineAsString = "False"
        Me.txt_CtlCat.Appearance = Appearance19
        Me.txt_CtlCat.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CtlCat.Location = New System.Drawing.Point(137, 31)
        Me.txt_CtlCat.Name = "txt_CtlCat"
        Me.txt_CtlCat.Size = New System.Drawing.Size(306, 21)
        Me.txt_CtlCat.TabIndex = 177
        '
        'UltraLabel1
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel1.Location = New System.Drawing.Point(23, 80)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(111, 14)
        Me.UltraLabel1.TabIndex = 183
        Me.UltraLabel1.Text = "Name in GA Drawing"
        '
        'txt_GANameCat
        '
        Appearance6.FontData.BoldAsString = "False"
        Appearance6.FontData.ItalicAsString = "False"
        Appearance6.FontData.Name = "Arial"
        Appearance6.FontData.SizeInPoints = 8.25!
        Appearance6.FontData.StrikeoutAsString = "False"
        Appearance6.FontData.UnderlineAsString = "False"
        Me.txt_GANameCat.Appearance = Appearance6
        Me.txt_GANameCat.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_GANameCat.Location = New System.Drawing.Point(137, 77)
        Me.txt_GANameCat.Name = "txt_GANameCat"
        Me.txt_GANameCat.Size = New System.Drawing.Size(306, 21)
        Me.txt_GANameCat.TabIndex = 182
        '
        'UltraLabel3
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance4
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel3.Location = New System.Drawing.Point(20, 125)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(114, 14)
        Me.UltraLabel3.TabIndex = 185
        Me.UltraLabel3.Text = "Makes in GA Drawing"
        '
        'txt_GAMakesCat
        '
        Appearance17.FontData.BoldAsString = "False"
        Appearance17.FontData.ItalicAsString = "False"
        Appearance17.FontData.Name = "Arial"
        Appearance17.FontData.SizeInPoints = 8.25!
        Appearance17.FontData.StrikeoutAsString = "False"
        Appearance17.FontData.UnderlineAsString = "False"
        Me.txt_GAMakesCat.Appearance = Appearance17
        Me.txt_GAMakesCat.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_GAMakesCat.Location = New System.Drawing.Point(137, 122)
        Me.txt_GAMakesCat.Name = "txt_GAMakesCat"
        Me.txt_GAMakesCat.Size = New System.Drawing.Size(306, 21)
        Me.txt_GAMakesCat.TabIndex = 184
        '
        'frmCtlCat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Control Item Category"
        Me.ClientSize = New System.Drawing.Size(483, 322)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.txt_GAMakesCat)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.txt_GANameCat)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.txt_CtlCat)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmCtlCat"
        Me.Text = "Control Item Category"
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_CtlCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GANameCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GAMakesCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_CtlCat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_GANameCat As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_GAMakesCat As Infragistics.Win.UltraWinEditors.UltraTextEditor

#End Region
End Class

