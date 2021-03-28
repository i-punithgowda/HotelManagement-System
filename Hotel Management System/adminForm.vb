Public Class adminForm
    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        Me.Hide()
        addUser.Show()
    End Sub

    Private Sub RemoveUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveUserToolStripMenuItem.Click
        Me.Hide()
        removeUser.Show()
    End Sub

    Private Sub GuestDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestDetailsToolStripMenuItem.Click
        Me.Hide()
        GuestForm.Show()
    End Sub

    Private Sub CheckAvailabilityToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CheckAvailabilityToolStripMenuItem1.Click
        Me.Hide()
        check_availability.Show()
    End Sub

    Private Sub adminForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        First.Show()
        Login.txtpassword.Text = ""
        Login.txtusername.Text = ""
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        First.Show()
        Login.txtpassword.Text = ""
        Login.txtusername.Text = ""
    End Sub


End Class