Imports System.Data.SqlClient
Public Class search_employees
    Dim connection As New SqlConnection
    Dim dbdataset As New DataTable
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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
                datagridview_load()
            Else
                MsgBox("Employee id entered is wrong")
                dbdataset.Clear()
            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub datagridview_load()

    End Sub

    Private Sub search_employees_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Login.lblLogin.Text = "User login" Then
            Useform.Show()
        Else
            adminForm.Show()
        End If
    End Sub

    Private Sub Btnview_Click(sender As Object, e As EventArgs) Handles Btnview.Click
        connection.ConnectionString = "server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True"

        dbdataset.Clear()
        Dim SDA As New SqlDataAdapter
        Dim bSource As New BindingSource


        Try
            connection.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select e_id as 'Employee id' ,e_name as 'Employee name',designation,phone_no,email_id,aadhar_no,address from dbo.employee "
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
End Class