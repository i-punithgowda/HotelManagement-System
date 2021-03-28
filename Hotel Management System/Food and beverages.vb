Imports System.Data.SqlClient

Public Class Food_and_beverages
    Dim connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
    Dim price As Integer
    Dim oldTotal As Integer
    Dim itemtotal As Integer
    Dim newTotal As String
    Private Sub Food_and_beverages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        room_loader()
    End Sub

    Private Sub room_loader()
        cmbRoomno.Items.Clear()
        cmbRoomno.Text = "Select room number"
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String = "select * from dbo.room where available='No'"
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

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.SelectedIndex = 0 Then
            cmbItems.Items.Clear()
            cmbItems.Items.Add("Chole Bhature")
            cmbItems.Items.Add("Peas Panneer")
            cmbItems.Items.Add("Dal Tadka")
            cmbItems.Items.Add("Basil Fried Rice")
            cmbItems.Items.Add("Panneer Butter Masala")

        ElseIf cmbType.SelectedIndex = 1 Then
            cmbItems.Items.Clear()
            cmbItems.Items.Add("Masala Dosa")
            cmbItems.Items.Add("Rice Sambhar")
            cmbItems.Items.Add("Tomato Rice")
            cmbItems.Items.Add("Vegetable Kurma")
            cmbItems.Items.Add("Puliogre")

        ElseIf cmbType.SelectedIndex = 2 Then
            cmbItems.Items.Clear()
            cmbItems.Items.Add("Chow Mein")
            cmbItems.Items.Add("Fried Shrimp with Cashew Nuts")
            cmbItems.Items.Add("Kung Pao Chicken")
            cmbItems.Items.Add("Ma Po Tofu")
            cmbItems.Items.Add("Yangchow Fried Rice")

        ElseIf cmbType.SelectedIndex = 3 Then
            cmbItems.Items.Clear()
            cmbItems.Items.Add("Lobster rolls")
            cmbItems.Items.Add("Hot dogs")
            cmbItems.Items.Add("sandwich")
            cmbItems.Items.Add("Cheeseburgers")
            cmbItems.Items.Add("Pizza")

        ElseIf cmbType.SelectedIndex = 4 Then
            cmbItems.Items.Clear()
            cmbItems.Items.Add("Mountain dew")
            cmbItems.Items.Add("Maaza")
            cmbItems.Items.Add("Mirinda")
            cmbItems.Items.Add("Red bull")
            cmbItems.Items.Add("Kingfisher")
        End If

    End Sub

    Private Sub cmbItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItems.SelectedIndexChanged
        If cmbItems.Text = "Chole Bhature" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\1.JPG")
            price = 150
            datagridview_Add()
        ElseIf cmbItems.Text = "Peas Panneer" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\2.JPG")
            price = 100
            datagridview_Add()
        ElseIf cmbItems.Text = "Dal Tadka" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\3.JPG")
            price = 120
            datagridview_Add()
        ElseIf cmbItems.Text = "Basil Fried Rice" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\4.JPG")
            price = 125
            datagridview_Add()
        ElseIf cmbItems.Text = "Panneer Butter Masala" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\5.JPG")
            price = 200
            datagridview_Add()
        ElseIf cmbItems.Text = "Masala Dosa" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\6.JPG")
            price = 70
            datagridview_Add()
        ElseIf cmbItems.Text = "Rice Sambhar" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\7.JPG")
            price = 50
            datagridview_Add()
        ElseIf cmbItems.Text = "Tomato Rice" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\8.JPG")
            price = 50
            datagridview_Add()
        ElseIf cmbItems.Text = "Vegetable Kurma" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\9.JPG")
            price = 100
            datagridview_Add()
        ElseIf cmbItems.Text = "Puliogre" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\10.JPG")
            price = 50
            datagridview_Add()
        ElseIf cmbItems.Text = "Chow Mein" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\11.JPG")
            price = 200
            datagridview_Add()
        ElseIf cmbItems.Text = "Fried Shrimp with Cashew Nuts" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\12.JPEG")
            price = 150
            datagridview_Add()
        ElseIf cmbItems.Text = "Kung Pao Chicken" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\13.JPG")
            price = 120
            datagridview_Add()
        ElseIf cmbItems.Text = "Ma Po Tofu" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\14.JPG")
            price = 150
            datagridview_Add()
        ElseIf cmbItems.Text = "Yangchow Fried Rice" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\15.JPG")
            price = 200
            datagridview_Add()
        ElseIf cmbItems.Text = "Lobster rolls" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\16.JPEG")
            price = 100
            datagridview_Add()
        ElseIf cmbItems.Text = "Hot dogs" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\17.JPG")
            price = 70
            datagridview_Add()
        ElseIf cmbItems.Text = "sandwich" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\18.JPG")
            price = 80
            datagridview_Add()
        ElseIf cmbItems.Text = "Cheeseburgers" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\19.JPG")
            price = 100
            datagridview_Add()
        ElseIf cmbItems.Text = "Pizza" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\20.JPG")
            price = 150
            datagridview_Add()
        ElseIf cmbItems.Text = "Mountain dew" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\21.JPG")
            price = 35
            datagridview_Add()
        ElseIf cmbItems.Text = "Maaza" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\22.JPG")
            price = 30
            datagridview_Add()
        ElseIf cmbItems.Text = "Mirinda" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\23.JPG")
            price = 35
            datagridview_Add()
        ElseIf cmbItems.Text = "Red bull" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\24.JPG")
            price = 70
            datagridview_Add()
        ElseIf cmbItems.Text = "Kingfisher" Then
            picFood.Image = Image.FromFile("C:\Users\ADMIN\Documents\Hotel Management System\Hotel Management System\Food_images\25.JPG")
            price = 100
            datagridview_Add()
        End If
    End Sub


    Private Sub datagridview_Add()

        dgvItems.Rows.Add(cmbItems.Text, price, 1)
        Dim sum As Integer = 0
        For i As Integer = 0 To dgvItems.Rows.Count() - 1 Step +1
            sum = sum + dgvItems.Rows(i).Cells(1).Value
        Next
        txttotal.Text = sum.ToString
        Dim total As Integer = txttotal.Text
        Dim servicecharge As Integer = txtService.Text
        itemtotal = total + servicecharge
        txtFinalttl.Text = itemtotal
        newTotal = (itemtotal + oldTotal)

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        dgvItems.Rows.Clear()
        txttotal.Text = ""
        txtFinalttl.Text = ""
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
        Useform.Show()

    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String
                Dim reader As SqlDataReader
                Dim command As SqlCommand
                query = "update dbo.bookings set Amount='" + newTotal + "' where room_no='" + cmbRoomno.Text + "' "
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                MsgBox("Order Confirmed")
                connection.Close()
                txtFinalttl.Text = ""
                txttotal.Text = ""
                picFood.Image = Nothing
                cmbItems.Text = "Select Item"
                cmbRoomno.Text = "Select Room number"
                cmbType.Text = "Select type"
                dgvItems.Rows.Clear()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbRoomno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoomno.SelectedIndexChanged
        Try
            Using connection As New SqlConnection("server=DESKTOP-VN49ARL;Database=Hotel; Integrated Security=True")
                connection.Open()
                Dim query As String
                Dim reader As SqlDataReader
                Dim command As SqlCommand
                query = "Select Amount from dbo.bookings where room_no='" + cmbRoomno.Text + "' and status='Active'"
                command = New SqlCommand(query, connection)
                reader = command.ExecuteReader
                While reader.Read
                    oldTotal = reader("Amount")
                End While
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Food_and_beverages_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Useform.Show()
    End Sub
End Class