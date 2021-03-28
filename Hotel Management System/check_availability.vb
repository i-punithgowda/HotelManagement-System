Imports System.Data.SqlClient
Public Class check_availability
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        cmbRoomno.Items.Clear()
        cmbRoomno.Text = "Select room number"
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "select * from dbo.room where room_type='" + cmbType.Text + "'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                Dim count As Integer = 0
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim roomno As String = reader("room_no")
                    cmbRoomno.Items.Add(roomno)
                End While



            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try

    End Sub

    Private Sub cmbRoomno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoomno.SelectedIndexChanged
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "select * from dbo.room where room_no='" + cmbRoomno.Text + "'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                Dim count As Integer = 0
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim available As String = reader("available")
                    lblavail.Text = available
                End While



            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub check_availability_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Login.lblLogin.Text = "User login" Then
            Useform.Show()
        Else
            adminForm.Show()
        End If
    End Sub
End Class