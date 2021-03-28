Public Class Useform
    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Me.Hide()
        Add_new_employee.Show()
    End Sub

    Private Sub RemoveEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveEmployeeToolStripMenuItem.Click
        Me.Hide()
        Remove_employees.Show()
    End Sub

    Private Sub SearchEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchEmployeeToolStripMenuItem.Click
        Me.Hide()
        search_employees.Show()
    End Sub

    Private Sub AddRoomsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRoomsToolStripMenuItem.Click
        Me.Hide()
        AddRoom.Show()
    End Sub

    Private Sub CheckAvailabilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckAvailabilityToolStripMenuItem.Click
        Me.Hide()
        check_availability.Show()
    End Sub

    Private Sub CheckinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckinToolStripMenuItem.Click
        Me.Hide()
        bookings.Show()
    End Sub

    Private Sub CancelBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelBookingToolStripMenuItem.Click
        Me.Hide()
        Cancel_booking.Show()
    End Sub

    Private Sub CheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckoutToolStripMenuItem.Click
        Me.Hide()
        Checkout.Show()
    End Sub

    Private Sub FoodAndBeveragesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FoodAndBeveragesToolStripMenuItem.Click
        Me.Hide()
        Food_and_beverages.Show()
    End Sub


    Private Sub adminForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()
        Login.txtpassword.Text = ""
        Login.txtusername.Text = ""
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Me.Hide()
        First.Show()
        Login.txtpassword.Text = ""
        Login.txtusername.Text = ""
    End Sub

    Private Sub DeleteRoomsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRoomsToolStripMenuItem.Click
        Me.Hide()
        removeRoom.Show()
    End Sub


End Class