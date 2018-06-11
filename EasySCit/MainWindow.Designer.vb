<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.CB3 = New System.Windows.Forms.PictureBox()
        Me.CB2 = New System.Windows.Forms.PictureBox()
        Me.EasySCitNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TakeTheWholeScreenPrtScToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAnAreaCtrlPrtScToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DNTextBox = New System.Windows.Forms.TextBox()
        Me.BrowsBUT = New System.Windows.Forms.Label()
        Me.CB1 = New System.Windows.Forms.PictureBox()
        Me.HideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LTSTextBox = New System.Windows.Forms.TextBox()
        Me.SaveBUT = New System.Windows.Forms.Label()
        Me.SevingExtensionComboBox = New System.Windows.Forms.ComboBox()
        Me.GetToolKifyBUT = New System.Windows.Forms.Label()
        CType(Me.CB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CB2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.CB1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB3
        '
        Me.CB3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB3.Image = Global.EasySCit.My.Resources.Resources.CheckBox_Checked
        Me.CB3.Location = New System.Drawing.Point(390, 74)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(17, 17)
        Me.CB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CB3.TabIndex = 92
        Me.CB3.TabStop = False
        '
        'CB2
        '
        Me.CB2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB2.Image = Global.EasySCit.My.Resources.Resources.CheckBox_UnChecked
        Me.CB2.Location = New System.Drawing.Point(49, 96)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(17, 17)
        Me.CB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CB2.TabIndex = 91
        Me.CB2.TabStop = False
        '
        'EasySCitNotifyIcon
        '
        Me.EasySCitNotifyIcon.ContextMenuStrip = Me.ContextMenuStrip
        Me.EasySCitNotifyIcon.Icon = CType(resources.GetObject("EasySCitNotifyIcon.Icon"), System.Drawing.Icon)
        Me.EasySCitNotifyIcon.Text = "EasySCit"
        Me.EasySCitNotifyIcon.Visible = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TakeTheWholeScreenPrtScToolStripMenuItem, Me.SelectAnAreaCtrlPrtScToolStripMenuItem, Me.ToolStripSeparator1, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(230, 126)
        '
        'TakeTheWholeScreenPrtScToolStripMenuItem
        '
        Me.TakeTheWholeScreenPrtScToolStripMenuItem.Name = "TakeTheWholeScreenPrtScToolStripMenuItem"
        Me.TakeTheWholeScreenPrtScToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.TakeTheWholeScreenPrtScToolStripMenuItem.Text = "Take the whole screen (PrtSc)"
        '
        'SelectAnAreaCtrlPrtScToolStripMenuItem
        '
        Me.SelectAnAreaCtrlPrtScToolStripMenuItem.Name = "SelectAnAreaCtrlPrtScToolStripMenuItem"
        Me.SelectAnAreaCtrlPrtScToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.SelectAnAreaCtrlPrtScToolStripMenuItem.Text = "Select an area (Ctrl + PrtSc)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(226, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(226, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ListeningTimer
        '
        Me.ListeningTimer.Enabled = True
        '
        'DNTextBox
        '
        Me.DNTextBox.BackColor = System.Drawing.Color.White
        Me.DNTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DNTextBox.Location = New System.Drawing.Point(199, 100)
        Me.DNTextBox.Name = "DNTextBox"
        Me.DNTextBox.Size = New System.Drawing.Size(97, 13)
        Me.DNTextBox.TabIndex = 1
        Me.DNTextBox.TabStop = False
        '
        'BrowsBUT
        '
        Me.BrowsBUT.BackColor = System.Drawing.Color.Transparent
        Me.BrowsBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrowsBUT.Location = New System.Drawing.Point(282, 168)
        Me.BrowsBUT.Name = "BrowsBUT"
        Me.BrowsBUT.Size = New System.Drawing.Size(19, 19)
        Me.BrowsBUT.TabIndex = 94
        '
        'CB1
        '
        Me.CB1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB1.Image = Global.EasySCit.My.Resources.Resources.CheckBox_Checked
        Me.CB1.Location = New System.Drawing.Point(49, 74)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(17, 17)
        Me.CB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CB1.TabIndex = 89
        Me.CB1.TabStop = False
        '
        'HideTimer
        '
        Me.HideTimer.Enabled = True
        Me.HideTimer.Interval = 1
        '
        'LTSTextBox
        '
        Me.LTSTextBox.BackColor = System.Drawing.Color.White
        Me.LTSTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LTSTextBox.Location = New System.Drawing.Point(55, 171)
        Me.LTSTextBox.Name = "LTSTextBox"
        Me.LTSTextBox.ReadOnly = True
        Me.LTSTextBox.Size = New System.Drawing.Size(216, 13)
        Me.LTSTextBox.TabIndex = 90
        '
        'SaveBUT
        '
        Me.SaveBUT.BackColor = System.Drawing.Color.Transparent
        Me.SaveBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveBUT.Location = New System.Drawing.Point(622, 6)
        Me.SaveBUT.Name = "SaveBUT"
        Me.SaveBUT.Size = New System.Drawing.Size(19, 19)
        Me.SaveBUT.TabIndex = 95
        '
        'SevingExtensionComboBox
        '
        Me.SevingExtensionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SevingExtensionComboBox.FormattingEnabled = True
        Me.SevingExtensionComboBox.Items.AddRange(New Object() {"JPG", "PNG"})
        Me.SevingExtensionComboBox.Location = New System.Drawing.Point(395, 170)
        Me.SevingExtensionComboBox.Name = "SevingExtensionComboBox"
        Me.SevingExtensionComboBox.Size = New System.Drawing.Size(125, 21)
        Me.SevingExtensionComboBox.TabIndex = 96
        Me.SevingExtensionComboBox.Text = "PNG"
        '
        'GetToolKifyBUT
        '
        Me.GetToolKifyBUT.BackColor = System.Drawing.Color.Transparent
        Me.GetToolKifyBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetToolKifyBUT.Location = New System.Drawing.Point(447, 224)
        Me.GetToolKifyBUT.Name = "GetToolKifyBUT"
        Me.GetToolKifyBUT.Size = New System.Drawing.Size(171, 53)
        Me.GetToolKifyBUT.TabIndex = 97
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.EasySCit.My.Resources.Resources.MainWindowBG
        Me.ClientSize = New System.Drawing.Size(650, 300)
        Me.Controls.Add(Me.GetToolKifyBUT)
        Me.Controls.Add(Me.SevingExtensionComboBox)
        Me.Controls.Add(Me.DNTextBox)
        Me.Controls.Add(Me.SaveBUT)
        Me.Controls.Add(Me.CB3)
        Me.Controls.Add(Me.CB2)
        Me.Controls.Add(Me.BrowsBUT)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.LTSTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainWindow"
        CType(Me.CB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CB2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.CB1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB3 As System.Windows.Forms.PictureBox
    Friend WithEvents CB2 As System.Windows.Forms.PictureBox
    Friend WithEvents EasySCitNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ListeningTimer As System.Windows.Forms.Timer
    Friend WithEvents DNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrowsBUT As System.Windows.Forms.Label
    Friend WithEvents CB1 As System.Windows.Forms.PictureBox
    Friend WithEvents HideTimer As System.Windows.Forms.Timer
    Friend WithEvents LTSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveBUT As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TakeTheWholeScreenPrtScToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAnAreaCtrlPrtScToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SevingExtensionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GetToolKifyBUT As Label
End Class
