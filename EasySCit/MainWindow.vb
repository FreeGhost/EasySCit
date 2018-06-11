Imports System.IO
Imports System.Threading

Public Class MainWindow
    Public ScreenShotsName As String = "Date", EasySCitlockDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\EasySCit", ScreenShotsNum, FileName As String
    Dim ASU As String = "True"
    Dim FirstRun As Boolean
    Dim Value As String = Application.ExecutablePath
    Dim KeyName As String = "Software\Microsoft\Windows\CurrentVersion\Run"
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Dim MutexOBJ As Mutex, MutexKey As String = "EnCt2f8cf1b7359f2c8bb1aa7fa38b215816a74a43e09f8cf1b7359f2c8bb1aa7fa38JqfYwrD+ZAFEEQpAF1rJEM3bkQ==IwEmS"

    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        MutexOBJ = New Mutex(False, MutexKey)
        If MutexOBJ.WaitOne(0, False) = False Then
            MutexOBJ.Close()
            MutexOBJ = Nothing
            EasySCitNotifyIcon.Visible = False
            MsgBox("Could not launch EasySCit" & vbCrLf & "Only one instance of EasySCit can be run at a time.", MsgBoxStyle.Critical, "EasySCit - ERROR")
            Close()
        End If
        If My.Settings.ScreenShotsName = "Date" Then
            CB1.Image = My.Resources.CheckBox_Checked
            CB2.Image = My.Resources.CheckBox_UnChecked
            DNTextBox.Enabled = False
            ScreenShotsName = "Date"
        Else
            CB1.Image = My.Resources.CheckBox_UnChecked
            CB2.Image = My.Resources.CheckBox_Checked
            DNTextBox.Enabled = True
            ScreenShotsName = "DefaultName"
            DNTextBox.Text = My.Settings.DefaultName
        End If
        If My.Settings.LTS = "" Then
            LTSTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\EasySCit"
            EasySCitlockDirectory = LTSTextBox.Text
        Else
            LTSTextBox.Text = My.Settings.LTS
            EasySCitlockDirectory = My.Settings.LTS
        End If
        Directory.CreateDirectory(EasySCitlockDirectory)
        If My.Settings.StartMyESSWhenCS = "Yes" Then
            CB3.Image = My.Resources.CheckBox_Checked
            ASU = "True"
            My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).SetValue(Application.ProductName, Value)
        Else
            CB3.Image = My.Resources.CheckBox_UnChecked
            ASU = "False"
        End If
    End Sub

    Private Sub HideTimer_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles HideTimer.Tick
        HideTimer.Stop()
        Hide()
        Opacity = 1
    End Sub

    Private Sub ListeningTimer_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ListeningTimer.Tick
        If GetAsyncKeyState(17) And GetAsyncKeyState(44) Then
            SelectAnArea()
        ElseIf GetAsyncKeyState(44) Then
            TheWholeScreen()
        ElseIf GetAsyncKeyState(Keys.Escape) Then
            SelectAreaWindow.Close()
            SelectedAeaSizeWindow.Close()
        End If
    End Sub

    Private Sub CB1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CB1.Click
        CB1.Image = My.Resources.CheckBox_Checked
        CB2.Image = My.Resources.CheckBox_UnChecked
        DNTextBox.Enabled = False
        ScreenShotsName = "Date"
        My.Settings.ScreenShotsName = "Date"
    End Sub

    Private Sub CB2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CB2.Click
        CB1.Image = My.Resources.CheckBox_UnChecked
        CB2.Image = My.Resources.CheckBox_Checked
        DNTextBox.Enabled = True
        ScreenShotsName = "DefaultName"
        My.Settings.ScreenShotsName = "DefaultName"
    End Sub

    Private Sub BrowsBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles BrowsBUT.Click
        Try
            Dim BrowseLocationDialog As New FolderBrowserDialog
            If (BrowseLocationDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                Dim FileName As String = BrowseLocationDialog.SelectedPath
                LTSTextBox.Text = FileName
                My.Settings.LTS = LTSTextBox.Text
                EasySCitlockDirectory = LTSTextBox.Text
                Directory.CreateDirectory(EasySCitlockDirectory)
            End If
        Catch
            MsgBox("Unknown Error!" & vbCrLf & "Sorry there was an error, please report to me the error code : 'ECSI1'", "Unknown Error!")
        End Try
    End Sub

    Private Sub CB3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CB3.Click
        If ASU = "True" Then
            My.Settings.StartMyESSWhenCS = "No"
            My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).DeleteValue(Application.ProductName, True)
            CB3.Image = My.Resources.CheckBox_UnChecked
            ASU = "False"
        ElseIf ASU = "False" Then
            My.Settings.StartMyESSWhenCS = "Yes"
            My.Computer.Registry.CurrentUser.OpenSubKey(KeyName, True).SetValue(Application.ProductName, Value)
            CB3.Image = My.Resources.CheckBox_Checked
            ASU = "True"
        End If
    End Sub

    Private Sub SevingExtensionComboBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles SevingExtensionComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub HideLabel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SaveBUT.Click
        My.Settings.DefaultName = DNTextBox.Text
        EasySCitNotifyIcon.Visible = True
        Hide()
    End Sub

    Private Sub TakeTheWholeScreenPrtScToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TakeTheWholeScreenPrtScToolStripMenuItem.Click
        TheWholeScreen()
    End Sub

    Private Sub SelectAnAreaCtrlPrtScToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAnAreaCtrlPrtScToolStripMenuItem.Click
        SelectAnArea()
    End Sub

    Function TheWholeScreen()
        Dim Bounds As Rectangle
        Dim Screenshot As Bitmap
        Dim Graph As Graphics
        If Screen.AllScreens.Count() > 1 Then
            If Screen.AllScreens(0).Bounds.Height > Screen.AllScreens(1).Bounds.Height Then
                Bounds.Size = New Size(Screen.AllScreens(0).Bounds.Width + Screen.AllScreens(1).Bounds.Width, Screen.AllScreens(0).Bounds.Height)
            Else
                Bounds.Size = New Size(Screen.AllScreens(0).Bounds.Width + Screen.AllScreens(1).Bounds.Width, Screen.AllScreens(1).Bounds.Height)
            End If
        Else
            Bounds.Size = New Size(Screen.AllScreens(0).Bounds.Width, Screen.AllScreens(0).Bounds.Height)
        End If
        Screenshot = New Bitmap(Bounds.Width, Bounds.Height, Imaging.PixelFormat.Format32bppArgb)
        Graph = Graphics.FromImage(Screenshot)
        Graph.CopyFromScreen(Bounds.X, Bounds.Y, 0, 0, Bounds.Size, CopyPixelOperation.SourceCopy)
        If ScreenShotsName = "Date" Then
            FileName = Now.Year & "-" & Now.Month & "-" & Now.Day & "_" & Now.Hour & "-" & Now.Minute & "-" & Now.Second
        ElseIf ScreenShotsName = "DefaultName" Then
            FileName = DNTextBox.Text & "_" & My.Settings.TakenSSNum
        End If
        If SevingExtensionComboBox.Text = "JPG" Then
            ScreenShotsNum = "\" & FileName & ".JPG"
            Try
                Screenshot.Save(LTSTextBox.Text & ScreenShotsNum, Imaging.ImageFormat.Jpeg)
                My.Settings.TakenSSNum += 1
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf SevingExtensionComboBox.Text = "PNG" Then
            ScreenShotsNum = "\" & FileName & ".PNG"
            Try
                Screenshot.Save(LTSTextBox.Text & ScreenShotsNum, Imaging.ImageFormat.Png)
                My.Settings.TakenSSNum += 1
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Return 0
    End Function

    Private Sub GetToolKifyBUT_Click(sender As Object, e As EventArgs) Handles GetToolKifyBUT.Click
        Process.Start("https://mousa.alfhaily.me/Apps/Free/ToolKify")
    End Sub

    Sub SelectAnArea()
        SelectAreaWindow.Show()
        SelectedAeaSizeWindow.Show()
        Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutWindow.Show()
    End Sub

    Private Sub MyESSNotifyIcon_MouseDoubleClick_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles SettingsToolStripMenuItem.Click, EasySCitNotifyIcon.MouseDoubleClick
        EasySCitNotifyIcon.Visible = False
        Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
End Class