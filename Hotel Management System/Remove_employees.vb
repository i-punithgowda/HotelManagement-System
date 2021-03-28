Imports System.Data.SqlClient
Public Class Remove_employees
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connection.ConnectionString = "server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True"
        Try
            connection.Open()
            Dim query As String = "select * from dbo.employee where e_id='" + txteid.Text + "'"
            Dim command As New SqlCommand
            Dim reader As SqlDataReader
            Dim count As Integer = 0
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            While reader.Read
                count = count + 1
            End While
            connection.Close()
            If count = 1 Then
                updater()
            Else
                MsgBox("Employee id entered is wrong")

            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub


    Private Sub updater()
        Try
            connection.Open()
            Dim query As String = "delete from dbo.employee where e_id='" + txteid.Text + "'"
            Dim command As New SqlCommand
            Dim reader As SqlDataReader
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            MsgBox("Employee details has been deleted")
            txteid.Text = ""
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Remove_employees_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Useform.Show()
    End Sub
End Class