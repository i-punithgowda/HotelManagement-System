Imports System.Data.SqlClient
Public Class removeUser
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
    Dim count As Integer

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "select count(username) as count from dbo.login where type='User' "
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    count = reader("count")
                End While
                If count = 1 Then
                    MsgBox("Cant delete as there is only one admin left!!!", MsgBoxStyle.Critical, "Error")
                    txtusername.Text = ""
                Else
                    del_admin()
                    txtusername.Text = ""
                End If
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub del_admin()
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "delete from dbo.login where username='" + txtusername.Text + "'and type='User'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                MsgBox("Deleted succesfully")
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Useform.Show()
    End Sub

    Private Sub removeAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        First.Show()
    End Sub


End Class