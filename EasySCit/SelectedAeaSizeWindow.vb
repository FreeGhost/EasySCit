Imports System.Drawing.Drawing2D

Public Class SelectedAeaSizeWindow
    Dim PIC As Bitmap = New Bitmap(100, 100)
    Dim GFX As Graphics = Graphics.FromImage(PIC)

    Private Sub MoveTimer_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles MoveTimer.Tick
        BringToFront()
        Left = MousePosition.X + 10 : Top = MousePosition.Y + 10
        GFX.CopyFromScreen(New Point(Location.X - 20, Location.Y - 20), New Point(0, 0), PIC.Size)
        ZoomImagePIC.Image = PIC
        Dim OriginalPIC As Image
        OriginalPIC = Me.ZoomImagePIC.Image
        Dim ZoomImage As New Bitmap(OriginalPIC, (Convert.ToInt32(OriginalPIC.Width * 400) / 80), (Convert.ToInt32(OriginalPIC.Height * 400 / 80)))
        Dim Coberted As Graphics = Graphics.FromImage(ZoomImage)
        Coberted.InterpolationMode = InterpolationMode.HighQualityBicubic
        ZoomImagePIC.Image = Nothing
        ZoomImagePIC.Image = ZoomImage
        Size = New Size(106, 135)
    End Sub

    Private Sub AreaSizeLabel_TextChanged(sender As Object, e As EventArgs) Handles AreaSizeLabel.TextChanged
        AreaSizeLabel.Left = Width / 2 - AreaSizeLabel.Width / 2
    End Sub

    Private Sub SelectedAeaSizeWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class