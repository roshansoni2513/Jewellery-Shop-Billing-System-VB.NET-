<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.logout = New System.Windows.Forms.PictureBox()
        Me.closes = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.reset = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.store = New System.Windows.Forms.Button()
        Me.customeradd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.customerphone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.customername = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Productbar = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CustomerGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CustomerGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 659)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'logout
        '
        Me.logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logout.Image = CType(resources.GetObject("logout.Image"), System.Drawing.Image)
        Me.logout.Location = New System.Drawing.Point(3, 3)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(30, 27)
        Me.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logout.TabIndex = 22
        Me.logout.TabStop = False
        '
        'closes
        '
        Me.closes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closes.Image = CType(resources.GetObject("closes.Image"), System.Drawing.Image)
        Me.closes.Location = New System.Drawing.Point(1226, 3)
        Me.closes.Name = "closes"
        Me.closes.Size = New System.Drawing.Size(30, 27)
        Me.closes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closes.TabIndex = 21
        Me.closes.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(550, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Customers"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.reset)
        Me.Panel1.Controls.Add(Me.delete)
        Me.Panel1.Controls.Add(Me.Edit)
        Me.Panel1.Controls.Add(Me.store)
        Me.Panel1.Controls.Add(Me.customeradd)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.customerphone)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.customername)
        Me.Panel1.Controls.Add(Me.logout)
        Me.Panel1.Controls.Add(Me.closes)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Crimson
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 635)
        Me.Panel1.TabIndex = 2
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.Crimson
        Me.reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.Color.White
        Me.reset.Location = New System.Drawing.Point(819, 211)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(109, 36)
        Me.reset.TabIndex = 34
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Crimson
        Me.delete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.Color.White
        Me.delete.Location = New System.Drawing.Point(657, 211)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(109, 36)
        Me.delete.TabIndex = 33
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.Crimson
        Me.Edit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.Color.White
        Me.Edit.Location = New System.Drawing.Point(492, 211)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(109, 36)
        Me.Edit.TabIndex = 32
        Me.Edit.Text = "Update"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'store
        '
        Me.store.BackColor = System.Drawing.Color.Crimson
        Me.store.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.store.ForeColor = System.Drawing.Color.White
        Me.store.Location = New System.Drawing.Point(338, 211)
        Me.store.Name = "store"
        Me.store.Size = New System.Drawing.Size(109, 36)
        Me.store.TabIndex = 31
        Me.store.Text = "Save"
        Me.store.UseVisualStyleBackColor = False
        '
        'customeradd
        '
        Me.customeradd.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customeradd.Location = New System.Drawing.Point(699, 149)
        Me.customeradd.Name = "customeradd"
        Me.customeradd.Size = New System.Drawing.Size(251, 33)
        Me.customeradd.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(695, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 22)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(505, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 22)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Phone"
        '
        'customerphone
        '
        Me.customerphone.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerphone.Location = New System.Drawing.Point(511, 150)
        Me.customerphone.Name = "customerphone"
        Me.customerphone.Size = New System.Drawing.Size(139, 33)
        Me.customerphone.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(309, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Name"
        '
        'customername
        '
        Me.customername.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customername.Location = New System.Drawing.Point(315, 150)
        Me.customername.Name = "customername"
        Me.customername.Size = New System.Drawing.Size(139, 33)
        Me.customername.TabIndex = 24
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Productbar})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1259, 635)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'Productbar
        '
        Me.Productbar.BorderColor = System.Drawing.Color.Crimson
        Me.Productbar.BorderWidth = 2
        Me.Productbar.Name = "Productbar"
        Me.Productbar.SelectionColor = System.Drawing.Color.Crimson
        Me.Productbar.X1 = 557
        Me.Productbar.X2 = 680
        Me.Productbar.Y1 = 63
        Me.Productbar.Y2 = 63
        '
        'CustomerGV
        '
        Me.CustomerGV.AllowUserToAddRows = False
        Me.CustomerGV.AllowUserToDeleteRows = False
        Me.CustomerGV.AllowUserToResizeColumns = False
        Me.CustomerGV.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Crimson
        Me.CustomerGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.CustomerGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomerGV.BackgroundColor = System.Drawing.Color.White
        Me.CustomerGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CustomerGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.CustomerGV.ColumnHeadersHeight = 30
        Me.CustomerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerGV.DefaultCellStyle = DataGridViewCellStyle8
        Me.CustomerGV.EnableHeadersVisualStyles = False
        Me.CustomerGV.Location = New System.Drawing.Point(12, 46)
        Me.CustomerGV.Name = "CustomerGV"
        Me.CustomerGV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CustomerGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.CustomerGV.RowHeadersVisible = False
        Me.CustomerGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Crimson
        Me.CustomerGV.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.CustomerGV.Size = New System.Drawing.Size(1207, 289)
        Me.CustomerGV.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(540, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Customers List"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CustomerGV)
        Me.Panel2.Location = New System.Drawing.Point(14, 274)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1231, 348)
        Me.Panel2.TabIndex = 36
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1283, 659)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        CType(Me.logout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CustomerGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents logout As System.Windows.Forms.PictureBox
    Friend WithEvents closes As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Productbar As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents customeradd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents customerphone As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents customername As System.Windows.Forms.TextBox
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents store As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerGV As System.Windows.Forms.DataGridView
End Class
