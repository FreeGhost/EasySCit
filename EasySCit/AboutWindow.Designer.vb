<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutWindow))
        Me.TermsAndConditionsBUT = New System.Windows.Forms.Label()
        Me.WebsiteBUT = New System.Windows.Forms.Label()
        Me.TwitterBUT = New System.Windows.Forms.Label()
        Me.YouTubeBUT = New System.Windows.Forms.Label()
        Me.CloseBUT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TermsAndConditionsBUT
        '
        Me.TermsAndConditionsBUT.BackColor = System.Drawing.Color.Transparent
        Me.TermsAndConditionsBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TermsAndConditionsBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TermsAndConditionsBUT.Location = New System.Drawing.Point(269, 188)
        Me.TermsAndConditionsBUT.Name = "TermsAndConditionsBUT"
        Me.TermsAndConditionsBUT.Size = New System.Drawing.Size(115, 11)
        Me.TermsAndConditionsBUT.TabIndex = 14
        '
        'WebsiteBUT
        '
        Me.WebsiteBUT.BackColor = System.Drawing.Color.Transparent
        Me.WebsiteBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WebsiteBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WebsiteBUT.Location = New System.Drawing.Point(370, 221)
        Me.WebsiteBUT.Name = "WebsiteBUT"
        Me.WebsiteBUT.Size = New System.Drawing.Size(61, 60)
        Me.WebsiteBUT.TabIndex = 13
        '
        'TwitterBUT
        '
        Me.TwitterBUT.BackColor = System.Drawing.Color.Transparent
        Me.TwitterBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TwitterBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TwitterBUT.Location = New System.Drawing.Point(295, 221)
        Me.TwitterBUT.Name = "TwitterBUT"
        Me.TwitterBUT.Size = New System.Drawing.Size(61, 60)
        Me.TwitterBUT.TabIndex = 12
        '
        'YouTubeBUT
        '
        Me.YouTubeBUT.BackColor = System.Drawing.Color.Transparent
        Me.YouTubeBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YouTubeBUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.YouTubeBUT.Location = New System.Drawing.Point(219, 221)
        Me.YouTubeBUT.Name = "YouTubeBUT"
        Me.YouTubeBUT.Size = New System.Drawing.Size(61, 60)
        Me.YouTubeBUT.TabIndex = 11
        '
        'CloseBUT
        '
        Me.CloseBUT.BackColor = System.Drawing.Color.Transparent
        Me.CloseBUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseBUT.Location = New System.Drawing.Point(623, 6)
        Me.CloseBUT.Name = "CloseBUT"
        Me.CloseBUT.Size = New System.Drawing.Size(19, 19)
        Me.CloseBUT.TabIndex = 96
        '
        'AboutWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.EasySCit.My.Resources.Resources.AboutWindowBG
        Me.ClientSize = New System.Drawing.Size(650, 300)
        Me.Controls.Add(Me.CloseBUT)
        Me.Controls.Add(Me.TermsAndConditionsBUT)
        Me.Controls.Add(Me.WebsiteBUT)
        Me.Controls.Add(Me.TwitterBUT)
        Me.Controls.Add(Me.YouTubeBUT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyESS"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TermsAndConditionsBUT As System.Windows.Forms.Label
    Friend WithEvents WebsiteBUT As System.Windows.Forms.Label
    Friend WithEvents TwitterBUT As System.Windows.Forms.Label
    Friend WithEvents YouTubeBUT As System.Windows.Forms.Label
    Friend WithEvents CloseBUT As System.Windows.Forms.Label
End Class
