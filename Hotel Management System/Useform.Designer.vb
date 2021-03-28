<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Useform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Useform))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckAvailabilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FoodAndBeveragesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesToolStripMenuItem, Me.RoomsToolStripMenuItem, Me.BookingsToolStripMenuItem, Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1224, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.RemoveEmployeeToolStripMenuItem, Me.SearchEmployeeToolStripMenuItem})
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.EmployeesToolStripMenuItem.Text = "Employees"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AddEmployeeToolStripMenuItem.Text = "Add employee"
        '
        'RemoveEmployeeToolStripMenuItem
        '
        Me.RemoveEmployeeToolStripMenuItem.Name = "RemoveEmployeeToolStripMenuItem"
        Me.RemoveEmployeeToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.RemoveEmployeeToolStripMenuItem.Text = "Remove employee"
        '
        'SearchEmployeeToolStripMenuItem
        '
        Me.SearchEmployeeToolStripMenuItem.Name = "SearchEmployeeToolStripMenuItem"
        Me.SearchEmployeeToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.SearchEmployeeToolStripMenuItem.Text = "Search employee"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRoomsToolStripMenuItem, Me.DeleteRoomsToolStripMenuItem, Me.CheckAvailabilityToolStripMenuItem})
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.RoomsToolStripMenuItem.Text = "Rooms"
        '
        'AddRoomsToolStripMenuItem
        '
        Me.AddRoomsToolStripMenuItem.Name = "AddRoomsToolStripMenuItem"
        Me.AddRoomsToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.AddRoomsToolStripMenuItem.Text = "Add rooms"
        '
        'DeleteRoomsToolStripMenuItem
        '
        Me.DeleteRoomsToolStripMenuItem.Name = "DeleteRoomsToolStripMenuItem"
        Me.DeleteRoomsToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.DeleteRoomsToolStripMenuItem.Text = "Delete rooms"
        '
        'CheckAvailabilityToolStripMenuItem
        '
        Me.CheckAvailabilityToolStripMenuItem.Name = "CheckAvailabilityToolStripMenuItem"
        Me.CheckAvailabilityToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.CheckAvailabilityToolStripMenuItem.Text = "Check Availability"
        '
        'BookingsToolStripMenuItem
        '
        Me.BookingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckinToolStripMenuItem, Me.CancelBookingToolStripMenuItem, Me.CheckoutToolStripMenuItem, Me.FoodAndBeveragesToolStripMenuItem})
        Me.BookingsToolStripMenuItem.Name = "BookingsToolStripMenuItem"
        Me.BookingsToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.BookingsToolStripMenuItem.Text = "Bookings"
        '
        'CheckinToolStripMenuItem
        '
        Me.CheckinToolStripMenuItem.Name = "CheckinToolStripMenuItem"
        Me.CheckinToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.CheckinToolStripMenuItem.Text = "Check_in"
        '
        'CancelBookingToolStripMenuItem
        '
        Me.CancelBookingToolStripMenuItem.Name = "CancelBookingToolStripMenuItem"
        Me.CancelBookingToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.CancelBookingToolStripMenuItem.Text = "Cancel Booking"
        '
        'CheckoutToolStripMenuItem
        '
        Me.CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        Me.CheckoutToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.CheckoutToolStripMenuItem.Text = "Checkout"
        '
        'FoodAndBeveragesToolStripMenuItem
        '
        Me.FoodAndBeveragesToolStripMenuItem.Name = "FoodAndBeveragesToolStripMenuItem"
        Me.FoodAndBeveragesToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.FoodAndBeveragesToolStripMenuItem.Text = "Food and Beverages"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.FileToolStripMenuItem.Text = "Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1228, 711)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Matura MT Script Capitals", 29.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(618, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hotel Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Useform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1224, 737)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Useform"
        Me.Text = "adminForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddRoomsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteRoomsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckAvailabilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelBookingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FoodAndBeveragesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
End Class
