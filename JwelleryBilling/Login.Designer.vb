<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.employee_panel = New System.Windows.Forms.Panel()
        Me.emplogin = New System.Windows.Forms.Button()
        Me.emp_passtb = New System.Windows.Forms.TextBox()
        Me.emp_usernametb = New System.Windows.Forms.TextBox()
        Me.emp_password = New System.Windows.Forms.Label()
        Me.emp_username = New System.Windows.Forms.Label()
        Me.admin_panel = New System.Windows.Forms.Panel()
        Me.adminlogin = New System.Windows.Forms.Button()
        Me.admin_passtb = New System.Windows.Forms.TextBox()
        Me.admin_usertb = New System.Windows.Forms.TextBox()
        Me.admin_pass = New System.Windows.Forms.Label()
        Me.admin_username = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.closes = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.employeebar = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.adminbar = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.employee_panel.SuspendLayout()
        Me.admin_panel.SuspendLayout()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.employee_panel)
        Me.Panel1.Controls.Add(Me.admin_panel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.closes)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 423)
        Me.Panel1.TabIndex = 0
        '
        'employee_panel
        '
        Me.employee_panel.Controls.Add(Me.emplogin)
        Me.employee_panel.Controls.Add(Me.emp_passtb)
        Me.employee_panel.Controls.Add(Me.emp_usernametb)
        Me.employee_panel.Controls.Add(Me.emp_password)
        Me.employee_panel.Controls.Add(Me.emp_username)
        Me.employee_panel.Location = New System.Drawing.Point(56, 242)
        Me.employee_panel.Name = "employee_panel"
        Me.employee_panel.Size = New System.Drawing.Size(426, 162)
        Me.employee_panel.TabIndex = 14
        '
        'emplogin
        '
        Me.emplogin.BackColor = System.Drawing.Color.White
        Me.emplogin.FlatAppearance.BorderSize = 5
        Me.emplogin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emplogin.ForeColor = System.Drawing.Color.Crimson
        Me.emplogin.Location = New System.Drawing.Point(139, 116)
        Me.emplogin.Name = "emplogin"
        Me.emplogin.Size = New System.Drawing.Size(168, 40)
        Me.emplogin.TabIndex = 12
        Me.emplogin.Text = "Login"
        Me.emplogin.UseVisualStyleBackColor = False
        '
        'emp_passtb
        '
        Me.emp_passtb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_passtb.Location = New System.Drawing.Point(192, 64)
        Me.emp_passtb.Name = "emp_passtb"
        Me.emp_passtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.emp_passtb.Size = New System.Drawing.Size(196, 27)
        Me.emp_passtb.TabIndex = 11
        '
        'emp_usernametb
        '
        Me.emp_usernametb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_usernametb.Location = New System.Drawing.Point(192, 6)
        Me.emp_usernametb.Name = "emp_usernametb"
        Me.emp_usernametb.Size = New System.Drawing.Size(196, 27)
        Me.emp_usernametb.TabIndex = 10
        '
        'emp_password
        '
        Me.emp_password.AutoSize = True
        Me.emp_password.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_password.ForeColor = System.Drawing.Color.Crimson
        Me.emp_password.Location = New System.Drawing.Point(39, 69)
        Me.emp_password.Name = "emp_password"
        Me.emp_password.Size = New System.Drawing.Size(95, 22)
        Me.emp_password.TabIndex = 9
        Me.emp_password.Text = "Password"
        '
        'emp_username
        '
        Me.emp_username.AutoSize = True
        Me.emp_username.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_username.ForeColor = System.Drawing.Color.Crimson
        Me.emp_username.Location = New System.Drawing.Point(39, 11)
        Me.emp_username.Name = "emp_username"
        Me.emp_username.Size = New System.Drawing.Size(101, 22)
        Me.emp_username.TabIndex = 8
        Me.emp_username.Text = "Username"
        '
        'admin_panel
        '
        Me.admin_panel.Controls.Add(Me.adminlogin)
        Me.admin_panel.Controls.Add(Me.admin_passtb)
        Me.admin_panel.Controls.Add(Me.admin_usertb)
        Me.admin_panel.Controls.Add(Me.admin_pass)
        Me.admin_panel.Controls.Add(Me.admin_username)
        Me.admin_panel.Location = New System.Drawing.Point(56, 242)
        Me.admin_panel.Name = "admin_panel"
        Me.admin_panel.Size = New System.Drawing.Size(426, 162)
        Me.admin_panel.TabIndex = 13
        '
        'adminlogin
        '
        Me.adminlogin.BackColor = System.Drawing.Color.White
        Me.adminlogin.FlatAppearance.BorderSize = 5
        Me.adminlogin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminlogin.ForeColor = System.Drawing.Color.Crimson
        Me.adminlogin.Location = New System.Drawing.Point(139, 116)
        Me.adminlogin.Name = "adminlogin"
        Me.adminlogin.Size = New System.Drawing.Size(168, 40)
        Me.adminlogin.TabIndex = 12
        Me.adminlogin.Text = "Login"
        Me.adminlogin.UseVisualStyleBackColor = False
        '
        'admin_passtb
        '
        Me.admin_passtb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_passtb.Location = New System.Drawing.Point(192, 64)
        Me.admin_passtb.Name = "admin_passtb"
        Me.admin_passtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.admin_passtb.Size = New System.Drawing.Size(196, 27)
        Me.admin_passtb.TabIndex = 11
        '
        'admin_usertb
        '
        Me.admin_usertb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_usertb.Location = New System.Drawing.Point(192, 6)
        Me.admin_usertb.Name = "admin_usertb"
        Me.admin_usertb.Size = New System.Drawing.Size(196, 27)
        Me.admin_usertb.TabIndex = 10
        '
        'admin_pass
        '
        Me.admin_pass.AutoSize = True
        Me.admin_pass.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_pass.ForeColor = System.Drawing.Color.Crimson
        Me.admin_pass.Location = New System.Drawing.Point(39, 69)
        Me.admin_pass.Name = "admin_pass"
        Me.admin_pass.Size = New System.Drawing.Size(95, 22)
        Me.admin_pass.TabIndex = 9
        Me.admin_pass.Text = "Password"
        '
        'admin_username
        '
        Me.admin_username.AutoSize = True
        Me.admin_username.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_username.ForeColor = System.Drawing.Color.Crimson
        Me.admin_username.Location = New System.Drawing.Point(39, 11)
        Me.admin_username.Name = "admin_username"
        Me.admin_username.Size = New System.Drawing.Size(101, 22)
        Me.admin_username.TabIndex = 8
        Me.admin_username.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(306, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(129, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Admin"
        '
        'closes
        '
        Me.closes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closes.Image = CType(resources.GetObject("closes.Image"), System.Drawing.Image)
        Me.closes.Location = New System.Drawing.Point(509, 3)
        Me.closes.Name = "closes"
        Me.closes.Size = New System.Drawing.Size(30, 27)
        Me.closes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closes.TabIndex = 9
        Me.closes.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JwelleryBilling.My.Resources.Resources.index
        Me.PictureBox1.Location = New System.Drawing.Point(173, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(121, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jewellery Shop Software"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.employeebar, Me.adminbar})
        Me.ShapeContainer1.Size = New System.Drawing.Size(542, 423)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'employeebar
        '
        Me.employeebar.BorderColor = System.Drawing.Color.Crimson
        Me.employeebar.BorderWidth = 2
        Me.employeebar.Name = "employeebar"
        Me.employeebar.SelectionColor = System.Drawing.Color.Crimson
        Me.employeebar.X1 = 302
        Me.employeebar.X2 = 411
        Me.employeebar.Y1 = 226
        Me.employeebar.Y2 = 226
        '
        'adminbar
        '
        Me.adminbar.BorderColor = System.Drawing.Color.Crimson
        Me.adminbar.BorderWidth = 2
        Me.adminbar.Name = "adminbar"
        Me.adminbar.SelectionColor = System.Drawing.Color.Crimson
        Me.adminbar.X1 = 124
        Me.adminbar.X2 = 203
        Me.adminbar.Y1 = 226
        Me.adminbar.Y2 = 226
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(566, 447)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.employee_panel.ResumeLayout(False)
        Me.employee_panel.PerformLayout()
        Me.admin_panel.ResumeLayout(False)
        Me.admin_panel.PerformLayout()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents closes As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents employeebar As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents adminbar As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents employee_panel As System.Windows.Forms.Panel
    Friend WithEvents emplogin As System.Windows.Forms.Button
    Friend WithEvents emp_passtb As System.Windows.Forms.TextBox
    Friend WithEvents emp_usernametb As System.Windows.Forms.TextBox
    Friend WithEvents emp_password As System.Windows.Forms.Label
    Friend WithEvents emp_username As System.Windows.Forms.Label
    Friend WithEvents admin_panel As System.Windows.Forms.Panel
    Friend WithEvents adminlogin As System.Windows.Forms.Button
    Friend WithEvents admin_passtb As System.Windows.Forms.TextBox
    Friend WithEvents admin_usertb As System.Windows.Forms.TextBox
    Friend WithEvents admin_pass As System.Windows.Forms.Label
    Friend WithEvents admin_username As System.Windows.Forms.Label
End Class
