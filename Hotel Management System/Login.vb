Imports System.Data.SqlClient
Public Class Login
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If lblLogin.Text = "User login" Then
            userlogin()
        Else
            adminlogin()
        End If
    End Sub

    Private Sub userlogin()
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            Dim count As Integer = 0
            query = "select * from dbo.login where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "' and type='User'  "
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MsgBox("Login Succesful")
                Me.Hide()
                Useform.Show()
            Else
                MsgBox("Wrong username or password")
                txtusername.Text = ""
                txtpassword.Text = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub adminlogin()
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            Dim count As Integer = 0
            query = "select * from dbo.login where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "' and type='Admin'  "
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MsgBox("Login Succesful")
                Me.Hide()
                adminForm.Show()
            Else
                MsgBox("Wrong username or password")
                txtusername.Text = ""
                txtpassword.Text = ""
            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        First.Show()
    End Sub
End Class
