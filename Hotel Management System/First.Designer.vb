<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class First
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(First))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.adminlogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.userLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.userLogin)
        Me.Panel1.Controls.Add(Me.adminlogin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 561)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Matura MT Script Capitals", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(281, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(429, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hotel Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(984, 468)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.IconPictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 34)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(847, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "+919901780987"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Coral
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PhoneAlt
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Coral
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(809, 3)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'adminlogin
        '
        Me.adminlogin.CheckedState.Parent = Me.adminlogin
        Me.adminlogin.CustomImages.Parent = Me.adminlogin
        Me.adminlogin.FillColor = System.Drawing.Color.Lime
        Me.adminlogin.FillColor2 = System.Drawing.Color.Aqua
        Me.adminlogin.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.adminlogin.ForeColor = System.Drawing.Color.Black
        Me.adminlogin.HoverState.Parent = Me.adminlogin
        Me.adminlogin.Location = New System.Drawing.Point(280, 482)
        Me.adminlogin.Name = "adminlogin"
        Me.adminlogin.ShadowDecoration.Parent = Me.adminlogin
        Me.adminlogin.Size = New System.Drawing.Size(180, 45)
        Me.adminlogin.TabIndex = 4
        Me.adminlogin.Text = "Admin login"
        '
        'userLogin
        '
        Me.userLogin.CheckedState.Parent = Me.userLogin
        Me.userLogin.CustomImages.Parent = Me.userLogin
        Me.userLogin.FillColor = System.Drawing.Color.Lime
        Me.userLogin.FillColor2 = System.Drawing.Color.Aqua
        Me.userLogin.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.userLogin.ForeColor = System.Drawing.Color.Black
        Me.userLogin.HoverState.Parent = Me.userLogin
        Me.userLogin.Location = New System.Drawing.Point(490, 482)
        Me.userLogin.Name = "userLogin"
        Me.userLogin.ShadowDecoration.Parent = Me.userLogin
        Me.userLogin.Size = New System.Drawing.Size(180, 45)
        Me.userLogin.TabIndex = 5
        Me.userLogin.Text = "User login"
        '
        'First
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "First"
        Me.Text = "First"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents adminlogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents userLogin As Guna.UI2.WinForms.Guna2GradientButton
End Class
