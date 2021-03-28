Imports System.Data.SqlClient
Public Class Add_new_employee
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            connection.Open()
            Dim query As String
            Dim reader As SqlDataReader
            Dim command As SqlCommand
            query = " insert into dbo.employee (e_id,e_name,designation,phone_no,email_id,aadhar_no,address) values ('" + txteid.Text + "','" + txtename.Text + "','" + cmbdesignation.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtaadharnum.Text + "','" + txtaddress.Text + "') "
            command = New SqlCommand(query, connection)
            reader = command.ExecuteReader
            MsgBox("New employee addded", MsgBoxStyle.Information)
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txteid.Text = ""
        txtaddress.Text = ""
        txtaadharnum.Text = ""
        txtemail.Text = ""
        txtename.Text = ""
        txtphone.Text = ""

    End Sub

    Private Sub Add_new_employee_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Useform.Show()
    End Sub
End Class