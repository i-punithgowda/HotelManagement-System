Imports System.Data.SqlClient
Public Class change_password
    Dim connection As New SqlConnection
    Dim command As New SqlCommand
    Dim oldpass As String
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        connection.ConnectionString = "server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True"
        Try
            connection.Open()
            Dim query As String = "select * from dbo.login where username='" + txtusername.Text + "'"
            Dim reader As SqlDataReader
            Dim count As Integer = 0
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                count = count + 1
                oldpass = reader("password")
            End While
            If count = 1 Then
                connection.Close()
                verifier()
            Else
                MsgBox("Employee id was wrong")
            End If


        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub verifier()
        If txtoldpassword.Text = oldpass Then
            newPass_update()
        Else
            MsgBox("Old password is not matching")
        End If
    End Sub
    Private Sub newPass_update()
        If txtnewpassword.Text = txtconfirm.Text Then
            Try
                connection.ConnectionString = "server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True"
                connection.Open()
                Dim query As String = "update dbo.login set password='" + txtconfirm.Text + "' where username='" + txtusername.Text + "'"
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                connection.Close()
                MsgBox("Password was succesfully updated")
                txtusername.Text = ""
                txtoldpassword.Text = ""
                txtnewpassword.Text = ""
                txtconfirm.Text = ""
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                connection.Dispose()
            End Try
        Else
            MsgBox("Passwords are not matching, try again")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtoldpassword.Text = ""
        txtnewpassword.Text = ""
        txtusername.Text = ""
        txtconfirm.Text = ""

    End Sub

    Private Sub change_password_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Useform.Show()
    End Sub
End Class