<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.closes = New System.Windows.Forms.PictureBox()
        Me.logout = New System.Windows.Forms.PictureBox()
        Me.Admin_Panel = New System.Windows.Forms.Label()
        Me.Bill_Details_Table = New System.Windows.Forms.Button()
        Me.Employee_Table = New System.Windows.Forms.Button()
        Me.Customer_Table = New System.Windows.Forms.Button()
        Me.Product_Table = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.closes)
        Me.Panel1.Controls.Add(Me.logout)
        Me.Panel1.Controls.Add(Me.Admin_Panel)
        Me.Panel1.Controls.Add(Me.Bill_Details_Table)
        Me.Panel1.Controls.Add(Me.Employee_Table)
        Me.Panel1.Controls.Add(Me.Customer_Table)
        Me.Panel1.Controls.Add(Me.Product_Table)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 352)
        Me.Panel1.TabIndex = 0
        '
        'closes
        '
        Me.closes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closes.Image = CType(resources.GetObject("closes.Image"), System.Drawing.Image)
        Me.closes.Location = New System.Drawing.Point(293, 3)
        Me.closes.Name = "closes"
        Me.closes.Size = New System.Drawing.Size(30, 27)
        Me.closes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closes.TabIndex = 24
        Me.closes.TabStop = False
        '
        'logout
        '
        Me.logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logout.Image = CType(resources.GetObject("logout.Image"), System.Drawing.Image)
        Me.logout.Location = New System.Drawing.Point(3, 3)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(30, 27)
        Me.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logout.TabIndex = 23
        Me.logout.TabStop = False
        '
        'Admin_Panel
        '
        Me.Admin_Panel.AutoSize = True
        Me.Admin_Panel.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_Panel.ForeColor = System.Drawing.Color.Crimson
        Me.Admin_Panel.Location = New System.Drawing.Point(71, 26)
        Me.Admin_Panel.Name = "Admin_Panel"
        Me.Admin_Panel.Size = New System.Drawing.Size(185, 60)
        Me.Admin_Panel.TabIndex = 22
        Me.Admin_Panel.Text = "Hello! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Roshan & Hitesh"
        Me.Admin_Panel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bill_Details_Table
        '
        Me.Bill_Details_Table.BackColor = System.Drawing.Color.Crimson
        Me.Bill_Details_Table.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bill_Details_Table.ForeColor = System.Drawing.Color.White
        Me.Bill_Details_Table.Location = New System.Drawing.Point(50, 295)
        Me.Bill_Details_Table.Name = "Bill_Details_Table"
        Me.Bill_Details_Table.Size = New System.Drawing.Size(226, 37)
        Me.Bill_Details_Table.TabIndex = 21
        Me.Bill_Details_Table.Text = "Manage Bills"
        Me.Bill_Details_Table.UseVisualStyleBackColor = False
        '
        'Employee_Table
        '
        Me.Employee_Table.BackColor = System.Drawing.Color.Crimson
        Me.Employee_Table.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_Table.ForeColor = System.Drawing.Color.White
        Me.Employee_Table.Location = New System.Drawing.Point(50, 240)
        Me.Employee_Table.Name = "Employee_Table"
        Me.Employee_Table.Size = New System.Drawing.Size(226, 37)
        Me.Employee_Table.TabIndex = 20
        Me.Employee_Table.Text = "Manage Employees"
        Me.Employee_Table.UseVisualStyleBackColor = False
        '
        'Customer_Table
        '
        Me.Customer_Table.BackColor = System.Drawing.Color.Crimson
        Me.Customer_Table.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_Table.ForeColor = System.Drawing.Color.White
        Me.Customer_Table.Location = New System.Drawing.Point(50, 185)
        Me.Customer_Table.Name = "Customer_Table"
        Me.Customer_Table.Size = New System.Drawing.Size(226, 37)
        Me.Customer_Table.TabIndex = 19
        Me.Customer_Table.Text = "Manage Customers"
        Me.Customer_Table.UseVisualStyleBackColor = False
        '
        'Product_Table
        '
        Me.Product_Table.BackColor = System.Drawing.Color.Crimson
        Me.Product_Table.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Table.ForeColor = System.Drawing.Color.White
        Me.Product_Table.Location = New System.Drawing.Point(50, 130)
        Me.Product_Table.Name = "Product_Table"
        Me.Product_Table.Size = New System.Drawing.Size(226, 37)
        Me.Product_Table.TabIndex = 18
        Me.Product_Table.Text = "Manage Products"
        Me.Product_Table.UseVisualStyleBackColor = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(350, 376)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Bill_Details_Table As System.Windows.Forms.Button
    Friend WithEvents Employee_Table As System.Windows.Forms.Button
    Friend WithEvents Customer_Table As System.Windows.Forms.Button
    Friend WithEvents Product_Table As System.Windows.Forms.Button
    Friend WithEvents Admin_Panel As System.Windows.Forms.Label
    Friend WithEvents logout As System.Windows.Forms.PictureBox
    Friend WithEvents closes As System.Windows.Forms.PictureBox
End Class
