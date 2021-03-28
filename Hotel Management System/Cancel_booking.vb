Imports System.Data.SqlClient
Public Class Cancel_booking
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
    Dim dbdataset As New DataTable

    Private Sub datagridview_load()

        Dim SDA As New SqlDataAdapter
        Dim bSource As New BindingSource
        Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")

            Try
                connection.Open()
                dbdataset.Clear()
                Dim Query As String
                Query = "select room_no,name,date,phone from dbo.bookings  where room_no='" + txtRoomno.Text + "' and status='Active'"
                Dim command As New SqlCommand
                command = New SqlCommand(Query, connection)
                SDA.SelectCommand = command
                SDA.Fill(dbdataset)
                bSource.DataSource = dbdataset
                DataGridView1.DataSource = bSource
                SDA.Update(dbdataset)
                connection.Close()

            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        datagridview_load()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Availability_updater()
        status_updater()
    End Sub

    Private Sub status_updater()
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "update dbo.bookings set status='Cancelled' where room_no='" + txtRoomno.Text + "'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                MsgBox("Cancelled succesfully")
                dbdataset.Clear()
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub Availability_updater()
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "update dbo.room set available='Yes' where room_no='" + txtRoomno.Text + "'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub Cancel_booking_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Useform.Show()
    End Sub
End Class