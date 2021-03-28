Public Class First
    Private Sub userLogin_Click(sender As Object, e As EventArgs) Handles userLogin.Click
        Me.Hide()
        Login.Show()
        Login.lblLogin.Text = "User login"

    End Sub

    Private Sub adminlogin_Click(sender As Object, e As EventArgs) Handles adminlogin.Click
        Me.Hide()
        Login.Show()
        Login.lblLogin.Text = "Admin login"
    End Sub
End Class