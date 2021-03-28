Imports System.Data.SqlClient
Public Class Checkout
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
    Dim oldTotal As Integer
    Dim finaldate As Double
    Dim total_amount As String
    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        room_loader()
    End Sub


    Private Sub room_loader()
        cmbRoomno.Items.Clear()
        cmbRoomno.Text = "Select room number"
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                cmbRoom.Items.Clear()
                Dim query As String = "select * from dbo.room where Available='No'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    Dim roomno As String = reader("room_no")
                    cmbRoom.Items.Add(roomno)
                End While

            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub cmbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoom.SelectedIndexChanged
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String
                Dim reader As SqlDataReader
                Dim command As SqlCommand
                query = "Select * from dbo.bookings where room_no='" + cmbRoom.Text + "' and status='Active'"
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    cmbCheckin.Text = reader("date")
                    oldTotal = reader("Amount")
                    dtpCheckout.MinDate = cmbCheckin.Value
                End While
                txtCharge.Text = oldTotal
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        room_charge()
    End Sub

    Private Sub dtpCheckout_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckout.ValueChanged
        Dim dateone = cmbCheckin.Value
        Dim datetwo = dtpCheckout.Value
        Dim diff As TimeSpan = datetwo.Subtract(dateone)
        finaldate = diff.Days

    End Sub


    Private Sub room_charge()
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "select * from dbo.room where room_no='" + cmbRoom.Text + "'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    txtAmt.Text = reader("total_cost")
                End While

            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub BtnttlAmt_Click(sender As Object, e As EventArgs) Handles BtnttlAmt.Click

        Dim amtPerDay As Integer = txtAmt.Text
        Dim roomCharge As Integer = finaldate * amtPerDay
        total_amount = roomCharge + oldTotal
        txtFInalamt.Text = total_amount
    End Sub

    Private Sub Btncheckout_Click(sender As Object, e As EventArgs) Handles Btncheckout.Click
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                cmbRoom.Items.Clear()
                Dim query As String = "update  dbo.bookings set amount='" + total_amount + "', Status='Check Out', checkout_date='" + dtpCheckout.Text + "' where room_no='" + cmbRoom.Text + "' and status='Active'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
            End Using
            Room_availability()
            MsgBox("Checked Out")
            txtAmt.Text = ""
            txtCharge.Text = ""
            txtFInalamt.Text = ""

            room_loader()
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub
    Private Sub Room_availability()
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                cmbRoom.Items.Clear()
                Dim query As String = "update  dbo.room set available='Yes' where room_no='" + cmbRoom.Text + "'"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Useform.Show()
    End Sub

    Private Sub Checkout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Useform.Show()
    End Sub
End Class