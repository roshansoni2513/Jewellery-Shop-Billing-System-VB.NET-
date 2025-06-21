<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.store = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.Label()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.empname = New System.Windows.Forms.Label()
        Me.empnametxt = New System.Windows.Forms.TextBox()
        Me.logout = New System.Windows.Forms.PictureBox()
        Me.closes = New System.Windows.Forms.PictureBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EmployeeGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Productbar = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.EmployeeGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(548, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 28)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Employee List"
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.Crimson
        Me.reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.Color.White
        Me.reset.Location = New System.Drawing.Point(840, 219)
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
        Me.delete.Location = New System.Drawing.Point(678, 219)
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
        Me.Edit.Location = New System.Drawing.Point(513, 219)
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
        Me.store.Location = New System.Drawing.Point(359, 219)
        Me.store.Name = "store"
        Me.store.Size = New System.Drawing.Size(109, 36)
        Me.store.TabIndex = 31
        Me.store.Text = "Save"
        Me.store.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.Crimson
        Me.password.Location = New System.Drawing.Point(773, 131)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(95, 22)
        Me.password.TabIndex = 27
        Me.password.Text = "Password"
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.Location = New System.Drawing.Point(777, 157)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(172, 33)
        Me.passwordtxt.TabIndex = 26
        Me.passwordtxt.UseSystemPasswordChar = True
        '
        'empname
        '
        Me.empname.AutoSize = True
        Me.empname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empname.ForeColor = System.Drawing.Color.Crimson
        Me.empname.Location = New System.Drawing.Point(355, 131)
        Me.empname.Name = "empname"
        Me.empname.Size = New System.Drawing.Size(161, 22)
        Me.empname.TabIndex = 25
        Me.empname.Text = "Employee Name"
        '
        'empnametxt
        '
        Me.empnametxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empnametxt.Location = New System.Drawing.Point(359, 157)
        Me.empnametxt.Name = "empnametxt"
        Me.empnametxt.Size = New System.Drawing.Size(186, 33)
        Me.empnametxt.TabIndex = 24
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
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 659)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.username)
        Me.Panel1.Controls.Add(Me.usernametxt)
        Me.Panel1.Controls.Add(Me.reset)
        Me.Panel1.Controls.Add(Me.delete)
        Me.Panel1.Controls.Add(Me.Edit)
        Me.Panel1.Controls.Add(Me.store)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.passwordtxt)
        Me.Panel1.Controls.Add(Me.empname)
        Me.Panel1.Controls.Add(Me.empnametxt)
        Me.Panel1.Controls.Add(Me.logout)
        Me.Panel1.Controls.Add(Me.closes)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Crimson
        Me.Panel1.Location = New System.Drawing.Point(18, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 635)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Controls.Add(Me.EmployeeGV)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(15, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1229, 346)
        Me.Panel2.TabIndex = 39
        '
        'EmployeeGV
        '
        Me.EmployeeGV.AllowUserToAddRows = False
        Me.EmployeeGV.AllowUserToDeleteRows = False
        Me.EmployeeGV.AllowUserToResizeColumns = False
        Me.EmployeeGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.EmployeeGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeGV.BackgroundColor = System.Drawing.Color.White
        Me.EmployeeGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmployeeGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.EmployeeGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeGV.ColumnHeadersHeight = 30
        Me.EmployeeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeGV.EnableHeadersVisualStyles = False
        Me.EmployeeGV.Location = New System.Drawing.Point(14, 54)
        Me.EmployeeGV.Name = "EmployeeGV"
        Me.EmployeeGV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EmployeeGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.EmployeeGV.RowHeadersVisible = False
        Me.EmployeeGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson
        Me.EmployeeGV.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.EmployeeGV.Size = New System.Drawing.Size(1201, 276)
        Me.EmployeeGV.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(583, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Employee"
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.Crimson
        Me.username.Location = New System.Drawing.Point(568, 131)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(101, 22)
        Me.username.TabIndex = 37
        Me.username.Text = "Username"
        '
        'usernametxt
        '
        Me.usernametxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(572, 157)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(181, 33)
        Me.usernametxt.TabIndex = 36
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Productbar})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1259, 635)
        Me.ShapeContainer1.TabIndex = 40
        Me.ShapeContainer1.TabStop = False
        '
        'Productbar
        '
        Me.Productbar.BorderColor = System.Drawing.Color.Crimson
        Me.Productbar.BorderWidth = 2
        Me.Productbar.Name = "Productbar"
        Me.Productbar.SelectionColor = System.Drawing.Color.Crimson
        Me.Productbar.X1 = 581
        Me.Productbar.X2 = 715
        Me.Productbar.Y1 = 84
        Me.Productbar.Y2 = 84
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1287, 659)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        CType(Me.logout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.EmployeeGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents store As System.Windows.Forms.Button
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents passwordtxt As System.Windows.Forms.TextBox
    Friend WithEvents empname As System.Windows.Forms.Label
    Friend WithEvents empnametxt As System.Windows.Forms.TextBox
    Friend WithEvents logout As System.Windows.Forms.PictureBox
    Friend WithEvents closes As System.Windows.Forms.PictureBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents usernametxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EmployeeGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Productbar As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
