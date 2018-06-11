Public Class AboutWindow

    Private Sub TermsAndConditionsBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TermsAndConditionsBUT.Click
        Process.Start("https://mousa.alfhaily.me/Apps/LICENSE")
    End Sub

    Private Sub YouTubeBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles YouTubeBUT.Click
        Process.Start("https://www.youtube.com/channel/UCWeRjXP-I7OmAwKKF8xHCFQ")
    End Sub

    Private Sub TwitterBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TwitterBUT.Click
        Process.Start("https://twitter.com/FreeGh0o0st")
    End Sub

    Private Sub WebsiteBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles WebsiteBUT.Click
        Process.Start("https://mousa.alfhaily.me")
    End Sub

    Private Sub CloseBUT_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CloseBUT.Click
        Close()
    End Sub
End Class