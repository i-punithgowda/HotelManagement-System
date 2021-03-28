<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Food_and_beverages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Food_and_beverages))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFinalttl = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtService = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.picFood = New System.Windows.Forms.PictureBox()
        Me.cmbItems = New System.Windows.Forms.ComboBox()
        Me.Items = New System.Windows.Forms.Label()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbRoomno = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1583, 729)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.txtFinalttl)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtService)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.BtnClear)
        Me.Panel2.Controls.Add(Me.picFood)
        Me.Panel2.Controls.Add(Me.cmbItems)
        Me.Panel2.Controls.Add(Me.Items)
        Me.Panel2.Controls.Add(Me.dgvItems)
        Me.Panel2.Controls.Add(Me.cancelBtn)
        Me.Panel2.Controls.Add(Me.BtnOrder)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.cmbType)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cmbRoomno)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1583, 729)
        Me.Panel2.TabIndex = 41
        '
        'txtFinalttl
        '
        Me.txtFinalttl.Enabled = False
        Me.txtFinalttl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalttl.Location = New System.Drawing.Point(699, 561)
        Me.txtFinalttl.Name = "txtFinalttl"
        Me.txtFinalttl.Size = New System.Drawing.Size(212, 36)
        Me.txtFinalttl.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(467, 568)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 29)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Total Amount"
        '
        'txtService
        '
        Me.txtService.Enabled = False
        Me.txtService.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtService.Location = New System.Drawing.Point(699, 485)
        Me.txtService.Name = "txtService"
        Me.txtService.Size = New System.Drawing.Size(212, 36)
        Me.txtService.TabIndex = 65
        Me.txtService.Text = "30"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(467, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 29)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Service Charge"
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Lime
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(1199, 646)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(176, 51)
        Me.BtnClear.TabIndex = 63
        Me.BtnClear.Text = "Clear items"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'picFood
        '
        Me.picFood.Location = New System.Drawing.Point(1076, 27)
        Me.picFood.Name = "picFood"
        Me.picFood.Size = New System.Drawing.Size(363, 328)
        Me.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFood.TabIndex = 62
        Me.picFood.TabStop = False
        '
        'cmbItems
        '
        Me.cmbItems.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItems.FormattingEnabled = True
        Me.cmbItems.Items.AddRange(New Object() {""})
        Me.cmbItems.Location = New System.Drawing.Point(699, 319)
        Me.cmbItems.Name = "cmbItems"
        Me.cmbItems.Size = New System.Drawing.Size(213, 36)
        Me.cmbItems.TabIndex = 61
        Me.cmbItems.Text = "Select Item"
        '
        'Items
        '
        Me.Items.AutoSize = True
        Me.Items.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Items.Location = New System.Drawing.Point(467, 326)
        Me.Items.Name = "Items"
        Me.Items.Size = New System.Drawing.Size(83, 29)
        Me.Items.TabIndex = 60
        Me.Items.Text = " Items"
        '
        'dgvItems
        '
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2})
        Me.dgvItems.Location = New System.Drawing.Point(982, 389)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.RowTemplate.Height = 24
        Me.dgvItems.Size = New System.Drawing.Size(538, 234)
        Me.dgvItems.TabIndex = 59
        '
        'Column1
        '
        Me.Column1.HeaderText = "Items"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Lime
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.Location = New System.Drawing.Point(725, 646)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(176, 51)
        Me.cancelBtn.TabIndex = 58
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'BtnOrder
        '
        Me.BtnOrder.BackColor = System.Drawing.Color.Lime
        Me.BtnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrder.Location = New System.Drawing.Point(482, 646)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(176, 51)
        Me.BtnOrder.TabIndex = 57
        Me.BtnOrder.Text = "Confirm order"
        Me.BtnOrder.UseVisualStyleBackColor = False
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(699, 405)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(212, 36)
        Me.txttotal.TabIndex = 56
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(467, 405)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 29)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Item total "
        '
        'cmbType
        '
        Me.cmbType.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"North Indian", "South Indian", "Chineese", "American", "Beverages"})
        Me.cmbType.Location = New System.Drawing.Point(699, 250)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(213, 36)
        Me.cmbType.TabIndex = 42
        Me.cmbType.Text = "Select type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(467, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 29)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Food / Beverages"
        '
        'cmbRoomno
        '
        Me.cmbRoomno.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoomno.FormattingEnabled = True
        Me.cmbRoomno.Items.AddRange(New Object() {""})
        Me.cmbRoomno.Location = New System.Drawing.Point(699, 182)
        Me.cmbRoomno.Name = "cmbRoomno"
        Me.cmbRoomno.Size = New System.Drawing.Size(213, 36)
        Me.cmbRoomno.TabIndex = 40
        Me.cmbRoomno.Text = "Select Room number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(467, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 29)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Room number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(525, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 102)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Food and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Beverages"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(435, 726)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {""})
        Me.ComboBox1.Location = New System.Drawing.Point(688, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 36)
        Me.ComboBox1.TabIndex = 40
        Me.ComboBox1.Text = "Select Room number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(467, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 29)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Room number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(525, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 102)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Food and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Beverages"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(416, 670)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Food_and_beverages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1583, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Food_and_beverages"
        Me.Text = "Food_and_beverages"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbRoomno As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnOrder As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents cmbItems As ComboBox
    Friend WithEvents Items As Label
    Friend WithEvents picFood As PictureBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents txtService As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFinalttl As TextBox
    Friend WithEvents Label6 As Label
End Class
