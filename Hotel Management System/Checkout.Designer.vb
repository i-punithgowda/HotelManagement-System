<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Checkout))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnttlAmt = New System.Windows.Forms.Button()
        Me.txtCharge = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCheckin = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btncheckout = New System.Windows.Forms.Button()
        Me.txtFInalamt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpCheckout = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbRoom = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbRoomno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dateCheckIn)
        Me.Panel1.Controls.Add(Me.cmbRoomno)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 701)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.BtnttlAmt)
        Me.Panel2.Controls.Add(Me.txtCharge)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.cmbCheckin)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Btncheckout)
        Me.Panel2.Controls.Add(Me.txtFInalamt)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtAmt)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.dtpCheckout)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmbRoom)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 701)
        Me.Panel2.TabIndex = 43
        '
        'BtnttlAmt
        '
        Me.BtnttlAmt.BackColor = System.Drawing.Color.Black
        Me.BtnttlAmt.Font = New System.Drawing.Font("Gill Sans MT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnttlAmt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnttlAmt.Location = New System.Drawing.Point(552, 502)
        Me.BtnttlAmt.Name = "BtnttlAmt"
        Me.BtnttlAmt.Size = New System.Drawing.Size(280, 54)
        Me.BtnttlAmt.TabIndex = 52
        Me.BtnttlAmt.Text = "Calculate Total Amount"
        Me.BtnttlAmt.UseVisualStyleBackColor = False
        '
        'txtCharge
        '
        Me.txtCharge.Enabled = False
        Me.txtCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharge.Location = New System.Drawing.Point(673, 384)
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.Size = New System.Drawing.Size(212, 36)
        Me.txtCharge.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(439, 384)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(191, 29)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Charge till date"
        '
        'cmbCheckin
        '
        Me.cmbCheckin.CustomFormat = "dd/MM/yyyy"
        Me.cmbCheckin.Enabled = False
        Me.cmbCheckin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbCheckin.Location = New System.Drawing.Point(671, 237)
        Me.cmbCheckin.Name = "cmbCheckin"
        Me.cmbCheckin.Size = New System.Drawing.Size(213, 36)
        Me.cmbCheckin.TabIndex = 49
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Gill Sans MT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(673, 631)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 58)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btncheckout
        '
        Me.Btncheckout.BackColor = System.Drawing.Color.Black
        Me.Btncheckout.Font = New System.Drawing.Font("Gill Sans MT", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncheckout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Btncheckout.Location = New System.Drawing.Point(476, 631)
        Me.Btncheckout.Name = "Btncheckout"
        Me.Btncheckout.Size = New System.Drawing.Size(139, 58)
        Me.Btncheckout.TabIndex = 47
        Me.Btncheckout.Text = "Checkout"
        Me.Btncheckout.UseVisualStyleBackColor = False
        '
        'txtFInalamt
        '
        Me.txtFInalamt.Enabled = False
        Me.txtFInalamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFInalamt.Location = New System.Drawing.Point(673, 569)
        Me.txtFInalamt.Name = "txtFInalamt"
        Me.txtFInalamt.Size = New System.Drawing.Size(212, 36)
        Me.txtFInalamt.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(441, 573)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 29)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Total Amount"
        '
        'txtAmt
        '
        Me.txtAmt.Enabled = False
        Me.txtAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(673, 443)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(212, 36)
        Me.txtAmt.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(439, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 29)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Check-Out-date"
        '
        'dtpCheckout
        '
        Me.dtpCheckout.CustomFormat = "dd/MM/yyyy"
        Me.dtpCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckout.Location = New System.Drawing.Point(672, 304)
        Me.dtpCheckout.Name = "dtpCheckout"
        Me.dtpCheckout.Size = New System.Drawing.Size(213, 36)
        Me.dtpCheckout.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(441, 450)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 29)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Amount per day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(439, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 29)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Check-In-date"
        '
        'cmbRoom
        '
        Me.cmbRoom.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoom.FormattingEnabled = True
        Me.cmbRoom.Items.AddRange(New Object() {""})
        Me.cmbRoom.Location = New System.Drawing.Point(672, 154)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Size = New System.Drawing.Size(213, 36)
        Me.cmbRoom.TabIndex = 38
        Me.cmbRoom.Text = "Select Room number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(438, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 29)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Room number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(586, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 51)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Checkout"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(382, 701)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(672, 304)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(213, 36)
        Me.DateTimePicker1.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(456, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 29)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Check-In-date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(456, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 29)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Check-In-date"
        '
        'dateCheckIn
        '
        Me.dateCheckIn.CustomFormat = "dd/MM/yyyy"
        Me.dateCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateCheckIn.Location = New System.Drawing.Point(672, 230)
        Me.dateCheckIn.Name = "dateCheckIn"
        Me.dateCheckIn.Size = New System.Drawing.Size(213, 36)
        Me.dateCheckIn.TabIndex = 39
        '
        'cmbRoomno
        '
        Me.cmbRoomno.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoomno.FormattingEnabled = True
        Me.cmbRoomno.Items.AddRange(New Object() {""})
        Me.cmbRoomno.Location = New System.Drawing.Point(672, 147)
        Me.cmbRoomno.Name = "cmbRoomno"
        Me.cmbRoomno.Size = New System.Drawing.Size(213, 36)
        Me.cmbRoomno.TabIndex = 38
        Me.cmbRoomno.Text = "Select Room number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(456, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 29)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Room number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(586, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 51)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Checkout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 493)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 701)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Checkout"
        Me.Text = "Checkout"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dateCheckIn As DateTimePicker
    Friend WithEvents cmbRoomno As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpCheckout As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbRoom As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents txtFInalamt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Btncheckout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbCheckin As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCharge As TextBox
    Friend WithEvents BtnttlAmt As Button
End Class
