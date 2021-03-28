Imports System.Data.SqlClient
Public Class GuestForm
    Dim connection As New SqlConnection
    Dim dbdataset As New DataTable
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        connection.ConnectionString = "server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True"
        Try
            connection.Open()
            Dim query As String = "select * from dbo.bookings where name='" + txtName.Text + "'"
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
                datagridview_load()
            Else
                MsgBox("Guest not found")
                dbdataset.Clear()
            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub datagridview_load()
        connection.ConnectionString = "server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True"

        dbdataset.Clear()
        Dim SDA As New SqlDataAdapter
        Dim bSource As New BindingSource


        Try
            connection.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select room_type as 'Room type',room_no as 'Room number',name as 'Name',date as 'Checkin',amount as 'Amount',checkout_date as 'Checkout' from dbo.bookings where name='" + txtName.Text + "'"
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
    End Sub

    Private Sub BtnGuest_Click(sender As Object, e As EventArgs) Handles BtnGuest.Click
        connection.ConnectionString = "server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True"

        dbdataset.Clear()
        Dim SDA As New SqlDataAdapter
        Dim bSource As New BindingSource


        Try
            connection.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select room_type as 'Room type',room_no as 'Room number',name as 'Name',date as 'Checkin',amount as 'Amount',checkout_date as 'Checkout' from dbo.bookings "
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
    End Sub

    Private Sub GuestForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        adminForm.Show()
    End Sub


End Class