<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckAvailabilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckAvailabilityToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip2)
        Me.Panel1.Controls.Add(Me.Guna2Panel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 597)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.GuestToolStripMenuItem, Me.CheckAvailabilityToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(721, 36)
        Me.MenuStrip2.TabIndex = 52
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.RemoveUserToolStripMenuItem})
        Me.UserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(65, 32)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(212, 32)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'RemoveUserToolStripMenuItem
        '
        Me.RemoveUserToolStripMenuItem.Name = "RemoveUserToolStripMenuItem"
        Me.RemoveUserToolStripMenuItem.Size = New System.Drawing.Size(212, 32)
        Me.RemoveUserToolStripMenuItem.Text = "Remove User"
        '
        'GuestToolStripMenuItem
        '
        Me.GuestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuestDetailsToolStripMenuItem})
        Me.GuestToolStripMenuItem.Name = "GuestToolStripMenuItem"
        Me.GuestToolStripMenuItem.Size = New System.Drawing.Size(76, 32)
        Me.GuestToolStripMenuItem.Text = "Guest"
        '
        'GuestDetailsToolStripMenuItem
        '
        Me.GuestDetailsToolStripMenuItem.Name = "GuestDetailsToolStripMenuItem"
        Me.GuestDetailsToolStripMenuItem.Size = New System.Drawing.Size(210, 32)
        Me.GuestDetailsToolStripMenuItem.Text = "Guest details"
        '
        'CheckAvailabilityToolStripMenuItem
        '
        Me.CheckAvailabilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckAvailabilityToolStripMenuItem1})
        Me.CheckAvailabilityToolStripMenuItem.Name = "CheckAvailabilityToolStripMenuItem"
        Me.CheckAvailabilityToolStripMenuItem.Size = New System.Drawing.Size(177, 32)
        Me.CheckAvailabilityToolStripMenuItem.Text = "Room availability"
        '
        'CheckAvailabilityToolStripMenuItem1
        '
        Me.CheckAvailabilityToolStripMenuItem1.Name = "CheckAvailabilityToolStripMenuItem1"
        Me.CheckAvailabilityToolStripMenuItem1.Size = New System.Drawing.Size(249, 32)
        Me.CheckAvailabilityToolStripMenuItem1.Text = "Check availability"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(89, 32)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 39)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(718, 555)
        Me.Guna2Panel1.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(383, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 51)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Hello, Admin"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(721, 558)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 51
        Me.Guna2PictureBox1.TabStop = False
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(722, 593)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "adminForm"
        Me.Text = "adminForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuestDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckAvailabilityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckAvailabilityToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
