<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectedAeaSizeWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectedAeaSizeWindow))
        Me.AreaSizeLabel = New System.Windows.Forms.Label()
        Me.ZoomImagePIC = New System.Windows.Forms.PictureBox()
        Me.MoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ZoomImagePIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AreaSizeLabel
        '
        Me.AreaSizeLabel.AutoSize = True
        Me.AreaSizeLabel.BackColor = System.Drawing.Color.Transparent
        Me.AreaSizeLabel.ForeColor = System.Drawing.Color.White
        Me.AreaSizeLabel.Location = New System.Drawing.Point(21, 113)
        Me.AreaSizeLabel.Name = "AreaSizeLabel"
        Me.AreaSizeLabel.Size = New System.Drawing.Size(64, 13)
        Me.AreaSizeLabel.TabIndex = 0
        Me.AreaSizeLabel.Text = "<Area Size>"
        '
        'ZoomImagePIC
        '
        Me.ZoomImagePIC.BackColor = System.Drawing.Color.Coral
        Me.ZoomImagePIC.Location = New System.Drawing.Point(3, 3)
        Me.ZoomImagePIC.Name = "ZoomImagePIC"
        Me.ZoomImagePIC.Size = New System.Drawing.Size(100, 100)
        Me.ZoomImagePIC.TabIndex = 1
        Me.ZoomImagePIC.TabStop = False
        '
        'MoveTimer
        '
        Me.MoveTimer.Enabled = True
        Me.MoveTimer.Interval = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(51, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(5, 5)
        Me.Label1.TabIndex = 2
        '
        'SelectedAeaSizeWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Coral
        Me.BackgroundImage = Global.EasySCit.My.Resources.Resources.SelectedAreaSizeWindowBG
        Me.ClientSize = New System.Drawing.Size(106, 135)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ZoomImagePIC)
        Me.Controls.Add(Me.AreaSizeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectedAeaSizeWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyESS"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Coral
        CType(Me.ZoomImagePIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AreaSizeLabel As Label
    Friend WithEvents ZoomImagePIC As PictureBox
    Friend WithEvents MoveTimer As Timer
    Friend WithEvents Label1 As Label
End Class
