<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectAreaWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectAreaWindow))
        Me.PETCLabel = New System.Windows.Forms.Label()
        Me.SQRCodePIC = New System.Windows.Forms.PictureBox()
        Me.SelectTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SQRCodePIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PETCLabel
        '
        Me.PETCLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PETCLabel.AutoSize = True
        Me.PETCLabel.Location = New System.Drawing.Point(47, 81)
        Me.PETCLabel.Name = "PETCLabel"
        Me.PETCLabel.Size = New System.Drawing.Size(111, 13)
        Me.PETCLabel.TabIndex = 4
        Me.PETCLabel.Text = "Press ""Esc"" to cancel"
        '
        'SQRCodePIC
        '
        Me.SQRCodePIC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SQRCodePIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SQRCodePIC.Location = New System.Drawing.Point(12, 12)
        Me.SQRCodePIC.Name = "SQRCodePIC"
        Me.SQRCodePIC.Size = New System.Drawing.Size(43, 44)
        Me.SQRCodePIC.TabIndex = 3
        Me.SQRCodePIC.TabStop = False
        Me.SQRCodePIC.Visible = False
        '
        'SelectTimer
        '
        Me.SelectTimer.Interval = 1
        '
        'SelectAreaWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(200, 175)
        Me.Controls.Add(Me.PETCLabel)
        Me.Controls.Add(Me.SQRCodePIC)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectAreaWindow"
        Me.Opacity = 0.7R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MyESS"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        CType(Me.SQRCodePIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PETCLabel As System.Windows.Forms.Label
    Friend WithEvents SQRCodePIC As System.Windows.Forms.PictureBox
    Friend WithEvents SelectTimer As System.Windows.Forms.Timer
End Class
