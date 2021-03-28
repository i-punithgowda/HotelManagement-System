Imports System.Data.SqlClient
Public Class bookings
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")


    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        cmbRoomno.Items.Clear()
        cmbRoomno.Text = "Select room number"
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "select * from dbo.room where room_type='" + cmbType.Text + "' and available='Yes'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
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
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    txtAmount.Text = reader("total_cost")
                End While

            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub



    Private Sub BtnCOnfirm_Click(sender As Object, e As EventArgs) Handles BtnCOnfirm.Click
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "insert into dbo.bookings (room_type,room_no,name,date,phone,purpose,status,amount) values ('" + cmbType.Text + "','" + cmbRoomno.Text + "','" + txtName.Text + "','" + dateCheckIn.Text + "','" + txtPhone.Text + "','" + txtPurpose.Text + "','Active','0')"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                updater()
                txtAmount.Text = ""
                txtName.Text = ""
                txtPhone.Text = ""
                txtPurpose.Text = ""
                cmbRoomno.Text = ""
                cmbType.Text = ""
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub updater()
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "update dbo.room set available='No' where room_no='" + cmbRoomno.Text + "'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                MsgBox("Room booked succesfully")
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Useform.Show()
    End Sub

    Private Sub bookings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Useform.Show()
    End Sub
End Class