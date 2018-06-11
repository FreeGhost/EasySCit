Public Class SelectAreaWindow
    Dim PIC As Bitmap
    Dim GFX As Graphics

    Private Sub FromScreenWindow_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        PETCLabel.Hide()
        SQRCodePIC.Left = MousePosition.X
        SQRCodePIC.Top = MousePosition.Y
        SelectTimer.Start()
    End Sub

    Private Sub SelectTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectTimer.Tick
        SelectTimer.Stop()
        SQRCodePIC.Show()
        SQRCodePIC.Width = MousePosition.X - SQRCodePIC.Left
        SQRCodePIC.Height = MousePosition.Y - SQRCodePIC.Top
        SelectedAeaSizeWindow.AreaSizeLabel.Text = SQRCodePIC.Width & " x " & SQRCodePIC.Height
        SelectTimer.Start()
    End Sub

    Private Sub FromScreenWindow_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        SelectTimer.Stop()
        PETCLabel.Show()
        If Not SQRCodePIC.Width = 0 And Not SQRCodePIC.Height = 0 Then
            PIC = New Bitmap(SQRCodePIC.Width, SQRCodePIC.Height)
            GFX = Graphics.FromImage(PIC)
            GFX.CopyFromScreen(New Point(SQRCodePIC.Left, SQRCodePIC.Top), New Point(0, 0), SQRCodePIC.Size)
            If MainWindow.ScreenShotsName = "Date" Then
                MainWindow.FileName = Now.Year & "-" & Now.Month & "-" & Now.Day & "_" & Now.Hour & "-" & Now.Minute & "-" & Now.Second
            ElseIf MainWindow.ScreenShotsName = "DefaultName" Then
                MainWindow.FileName = MainWindow.DNTextBox.Text & "_" & My.Settings.TakenSSNum
            End If
            If MainWindow.SevingExtensionComboBox.Text = "JPG" Then
                MainWindow.ScreenShotsNum = "\" & MainWindow.FileName & ".JPG"
                Try
                    PIC.Save(MainWindow.EasySCitlockDirectory & MainWindow.ScreenShotsNum, Imaging.ImageFormat.Jpeg)
                    My.Settings.TakenSSNum += 1
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            ElseIf MainWindow.SevingExtensionComboBox.Text = "PNG" Then
                MainWindow.ScreenShotsNum = "\" & MainWindow.FileName & ".PNG"
                Try
                    PIC.Save(MainWindow.EasySCitlockDirectory & MainWindow.ScreenShotsNum, Imaging.ImageFormat.Png)
                    My.Settings.TakenSSNum += 1
                Catch ex As Exception
                    MsgBox(ex.ToString())
                End Try
            End If
            Close()
            SelectedAeaSizeWindow.Close()
        End If
    End Sub

    Private Sub SelectAreaWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Screen.AllScreens().Count > 1 Then
            If Screen.AllScreens(0).Bounds.Height > Screen.AllScreens(1).Bounds.Height Then
                Size = New Size(Screen.AllScreens(0).Bounds.Width + Screen.AllScreens(1).Bounds.Width, Screen.AllScreens(0).Bounds.Height)
            Else
                Size = New Size(Screen.AllScreens(0).Bounds.Width + Screen.AllScreens(1).Bounds.Width, Screen.AllScreens(1).Bounds.Height)
            End If
        Else
            Size = New Size(Screen.AllScreens(0).Bounds.Width, Screen.AllScreens(0).Bounds.Height)
        End If
    End Sub
End Class