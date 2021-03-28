Imports System.Data.SqlClient
Public Class AddRoom
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "select * from dbo.room where room_no='" + txtRoomno.Text + "'"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                Dim count As Integer = 0
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    count = count + 1
                End While
                If count = 1 Then
                    MsgBox("Room number " + txtRoomno.Text + " already exists!!!")

                Else
                    adder()
                End If
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()

        End Try

    End Sub

    Private Sub adder()


        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")

                connection.Open()
                Dim query As String = "Insert into dbo.room (room_no,room_type,total_cost,available) values ('" + txtRoomno.Text + "','" + cmbType.Text + "','" + txtTotal.Text + "','Yes')"
                Dim command As New SqlCommand
                Dim reader As SqlDataReader
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                MsgBox("Room added")
                txtRoomno.Text = ""
                txtTarrif.Text = ""
                txtTotal.Text = ""
                txtCostperDay.Text = ""
            End Using
            connection.Close()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        txtRoomno.Text = ""
        txtTarrif.Text = ""
        txtTotal.Text = ""
        txtCostperDay.Text = ""
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.Text = "Single A/C" Then
            txtCostperDay.Text = "800"
            txtTarrif.Text = "12%"
            txtTotal.Text = txtCostperDay.Text + (txtCostperDay.Text * 0.12)
        ElseIf cmbType.Text = "Single Non A/C" Then
            txtCostperDay.Text = "600"
            txtTarrif.Text = "12%"
            txtTotal.Text = txtCostperDay.Text + (txtCostperDay.Text * 0.12)
        ElseIf cmbType.Text = "Duplex " Then
            txtCostperDay.Text = "3000"
            txtTarrif.Text = "18%"
            txtTotal.Text = txtCostperDay.Text + (txtCostperDay.Text * 0.18)
        ElseIf cmbType.Text = "Double A/C" Then
            txtCostperDay.Text = "1200"
            txtTarrif.Text = "12%"
            txtTotal.Text = txtCostperDay.Text + (txtCostperDay.Text * 0.12)
        ElseIf cmbType.Text = "Double Non A/C" Then
            txtCostperDay.Text = "1000"
            txtTarrif.Text = "12%"
            txtTotal.Text = txtCostperDay.Text + (txtCostperDay.Text * 0.12)
        ElseIf cmbType.Text = "Master Suite" Then
            txtCostperDay.Text = "5000"
            txtTarrif.Text = "18%"
            txtTotal.Text = txtCostperDay.Text + (txtCostperDay.Text * 0.18)
        End If
    End Sub

    Private Sub AddRoom_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Useform.Show()
    End Sub
End Class