Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPIDScheme
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnBuild = New Infragistics.Win.Misc.UltraButton()
        Me.btnResCalcMultiBus = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditMultiBus = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.btnCopyBus = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelAll = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Remarks = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_filenum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel42 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Customer = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_filenum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTabControl2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(778, 336)
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(778, 336)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.UltraTabControl2.TabIndex = 0
        Me.UltraTabControl2.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(776, 315)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraTabControl3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(778, 336)
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl3.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(778, 336)
        Me.UltraTabControl3.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Excel
        Me.UltraTabControl3.TabIndex = 1
        Me.UltraTabControl3.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(776, 315)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnBuild)
        Me.Panel4.Controls.Add(Me.btnResCalcMultiBus)
        Me.Panel4.Controls.Add(Me.btnEditMultiBus)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Controls.Add(Me.btnCopyBus)
        Me.Panel4.Controls.Add(Me.btnDelAll)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 475)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(782, 48)
        Me.Panel4.TabIndex = 3
        '
        'btnBuild
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnBuild.Appearance = Appearance1
        Me.btnBuild.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBuild.Location = New System.Drawing.Point(190, 0)
        Me.btnBuild.Name = "btnBuild"
        Me.btnBuild.Size = New System.Drawing.Size(88, 48)
        Me.btnBuild.TabIndex = 11
        Me.btnBuild.Text = "Build Scheme Reports"
        '
        'btnResCalcMultiBus
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnResCalcMultiBus.Appearance = Appearance2
        Me.btnResCalcMultiBus.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnResCalcMultiBus.Location = New System.Drawing.Point(102, 0)
        Me.btnResCalcMultiBus.Name = "btnResCalcMultiBus"
        Me.btnResCalcMultiBus.Size = New System.Drawing.Size(88, 48)
        Me.btnResCalcMultiBus.TabIndex = 9
        Me.btnResCalcMultiBus.Text = "ReCalculate Multi Bus"
        '
        'btnEditMultiBus
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnEditMultiBus.Appearance = Appearance3
        Me.btnEditMultiBus.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditMultiBus.Location = New System.Drawing.Point(430, 0)
        Me.btnEditMultiBus.Name = "btnEditMultiBus"
        Me.btnEditMultiBus.Size = New System.Drawing.Size(88, 48)
        Me.btnEditMultiBus.TabIndex = 8
        Me.btnEditMultiBus.Text = "Edit Multi Bus"
        '
        'btnSave
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance4
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(518, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 48)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance5
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(606, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 48)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance6
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(694, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 48)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'btnCopyBus
        '
        Me.btnCopyBus.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCopyBus.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnCopyBus.Location = New System.Drawing.Point(49, 0)
        Me.btnCopyBus.Name = "btnCopyBus"
        Me.btnCopyBus.Size = New System.Drawing.Size(53, 48)
        Me.btnCopyBus.TabIndex = 12
        Me.btnCopyBus.Text = "Copy Bus"
        '
        'btnDelAll
        '
        Me.btnDelAll.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelAll.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelAll.Location = New System.Drawing.Point(0, 0)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(49, 48)
        Me.btnDelAll.TabIndex = 7
        Me.btnDelAll.Text = "Delete All"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.txt_Remarks)
        Me.Panel1.Controls.Add(Me.txt_filenum)
        Me.Panel1.Controls.Add(Me.UltraLabel42)
        Me.Panel1.Controls.Add(Me.txt_Descrip)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_Customer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 113)
        Me.Panel1.TabIndex = 0
        '
        'UltraLabel1
        '
        Appearance7.TextHAlignAsString = "Center"
        Me.UltraLabel1.Appearance = Appearance7
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel1.Location = New System.Drawing.Point(78, 76)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel1.TabIndex = 309
        Me.UltraLabel1.Text = "Remarks"
        '
        'txt_Remarks
        '
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.FontData.ItalicAsString = "False"
        Appearance8.FontData.Name = "Arial"
        Appearance8.FontData.SizeInPoints = 10.0!
        Appearance8.FontData.StrikeoutAsString = "False"
        Appearance8.FontData.UnderlineAsString = "False"
        Me.txt_Remarks.Appearance = Appearance8
        Me.txt_Remarks.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Remarks.Location = New System.Drawing.Point(150, 76)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.ReadOnly = True
        Me.txt_Remarks.Size = New System.Drawing.Size(272, 24)
        Me.txt_Remarks.TabIndex = 308
        '
        'txt_filenum
        '
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.FontData.ItalicAsString = "False"
        Appearance9.FontData.Name = "Arial"
        Appearance9.FontData.SizeInPoints = 10.0!
        Appearance9.FontData.StrikeoutAsString = "False"
        Appearance9.FontData.UnderlineAsString = "False"
        Me.txt_filenum.Appearance = Appearance9
        Me.txt_filenum.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_filenum.Location = New System.Drawing.Point(430, 44)
        Me.txt_filenum.Name = "txt_filenum"
        Me.txt_filenum.ReadOnly = True
        Me.txt_filenum.Size = New System.Drawing.Size(208, 24)
        Me.txt_filenum.TabIndex = 307
        '
        'UltraLabel42
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel42.Appearance = Appearance10
        Me.UltraLabel42.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UltraLabel42.Location = New System.Drawing.Point(49, 44)
        Me.UltraLabel42.Name = "UltraLabel42"
        Me.UltraLabel42.Size = New System.Drawing.Size(97, 16)
        Me.UltraLabel42.TabIndex = 306
        Me.UltraLabel42.Text = "Description"
        '
        'txt_Descrip
        '
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.FontData.ItalicAsString = "False"
        Appearance11.FontData.Name = "Arial"
        Appearance11.FontData.SizeInPoints = 10.0!
        Appearance11.FontData.StrikeoutAsString = "False"
        Appearance11.FontData.UnderlineAsString = "False"
        Me.txt_Descrip.Appearance = Appearance11
        Me.txt_Descrip.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Descrip.Location = New System.Drawing.Point(150, 44)
        Me.txt_Descrip.Name = "txt_Descrip"
        Me.txt_Descrip.ReadOnly = True
        Me.txt_Descrip.Size = New System.Drawing.Size(272, 24)
        Me.txt_Descrip.TabIndex = 305
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(78, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 304
        Me.Label6.Text = "Customer"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Customer
        '
        Me.txt_Customer.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Customer.Location = New System.Drawing.Point(150, 12)
        Me.txt_Customer.Name = "txt_Customer"
        Me.txt_Customer.ReadOnly = True
        Me.txt_Customer.Size = New System.Drawing.Size(584, 21)
        Me.txt_Customer.TabIndex = 303
        Me.txt_Customer.Text = "UltraTextEditor1"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 113)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(782, 362)
        Me.UltraTabControl1.TabIndex = 4
        UltraTab9.TabPage = Me.UltraTabPageControl1
        UltraTab9.Text = "Input"
        UltraTab10.TabPage = Me.UltraTabPageControl2
        UltraTab10.Text = "Reports"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab10})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(778, 336)
        '
        'frmPIDScheme
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Control Items"
        Me.ClientSize = New System.Drawing.Size(782, 523)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmPIDScheme"
        Me.Text = "Control Items"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_filenum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelAll As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remarks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_filenum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel42 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Customer As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents btnEditMultiBus As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnResCalcMultiBus As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnBuild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCopyBus As Infragistics.Win.Misc.UltraButton

#End Region
End Class

