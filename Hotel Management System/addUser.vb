Imports System.Data.SqlClient
Public Class addUser
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click

        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "insert into dbo.login (username,password,type) values ('" + txtusername.Text + "','" + txtpassword.Text + "','User')"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                MsgBox("Added succesfully")
                txtusername.Text = ""
                txtpassword.Text = ""
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        adminForm.Show()
    End Sub



    Private Sub addAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        adminForm.Show()
    End Sub


End Class