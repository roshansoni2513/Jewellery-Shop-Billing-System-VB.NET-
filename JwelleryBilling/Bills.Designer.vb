<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bills
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bills))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.amountlbl = New System.Windows.Forms.Label()
        Me.gstlbl = New System.Windows.Forms.Label()
        Me.totallbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.closes = New System.Windows.Forms.PictureBox()
        Me.logout = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProductGV = New System.Windows.Forms.DataGridView()
        Me.CustomerGV = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BillGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.customerbtn = New System.Windows.Forms.Button()
        Me.customertxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.productpricetxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addtobillbtn = New System.Windows.Forms.Button()
        Me.productnametxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.productqtytxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.PPD = New System.Windows.Forms.PrintPreviewDialog()
        Me.amttot = New System.Windows.Forms.Label()
        Me.GST = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ProductGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.amttot)
        Me.Panel1.Controls.Add(Me.GST)
        Me.Panel1.Controls.Add(Me.total)
        Me.Panel1.Controls.Add(Me.amountlbl)
        Me.Panel1.Controls.Add(Me.gstlbl)
        Me.Panel1.Controls.Add(Me.totallbl)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.closes)
        Me.Panel1.Controls.Add(Me.logout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.BillGV)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 635)
        Me.Panel1.TabIndex = 2
        '
        'amountlbl
        '
        Me.amountlbl.AutoSize = True
        Me.amountlbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountlbl.ForeColor = System.Drawing.Color.Crimson
        Me.amountlbl.Location = New System.Drawing.Point(878, 334)
        Me.amountlbl.Name = "amountlbl"
        Me.amountlbl.Size = New System.Drawing.Size(39, 17)
        Me.amountlbl.TabIndex = 38
        Me.amountlbl.Text = "Total"
        '
        'gstlbl
        '
        Me.gstlbl.AutoSize = True
        Me.gstlbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gstlbl.ForeColor = System.Drawing.Color.Crimson
        Me.gstlbl.Location = New System.Drawing.Point(998, 334)
        Me.gstlbl.Name = "gstlbl"
        Me.gstlbl.Size = New System.Drawing.Size(39, 17)
        Me.gstlbl.TabIndex = 37
        Me.gstlbl.Text = "Total"
        '
        'totallbl
        '
        Me.totallbl.AutoSize = True
        Me.totallbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totallbl.ForeColor = System.Drawing.Color.Crimson
        Me.totallbl.Location = New System.Drawing.Point(1137, 334)
        Me.totallbl.Name = "totallbl"
        Me.totallbl.Size = New System.Drawing.Size(39, 17)
        Me.totallbl.TabIndex = 26
        Me.totallbl.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(110, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 30)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Billing"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(45, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 30)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Shop"
        '
        'closes
        '
        Me.closes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closes.Image = CType(resources.GetObject("closes.Image"), System.Drawing.Image)
        Me.closes.Location = New System.Drawing.Point(1226, 3)
        Me.closes.Name = "closes"
        Me.closes.Size = New System.Drawing.Size(30, 27)
        Me.closes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closes.TabIndex = 34
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
        Me.logout.TabIndex = 33
        Me.logout.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(55, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 30)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Jewellery"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ProductGV)
        Me.Panel3.Controls.Add(Me.CustomerGV)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(33, 366)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1201, 251)
        Me.Panel3.TabIndex = 30
        '
        'ProductGV
        '
        Me.ProductGV.AllowUserToAddRows = False
        Me.ProductGV.AllowUserToDeleteRows = False
        Me.ProductGV.AllowUserToResizeColumns = False
        Me.ProductGV.AllowUserToResizeRows = False
        Me.ProductGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductGV.BackgroundColor = System.Drawing.Color.White
        Me.ProductGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ProductGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductGV.ColumnHeadersHeight = 30
        Me.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.ProductGV.EnableHeadersVisualStyles = False
        Me.ProductGV.Location = New System.Drawing.Point(640, 48)
        Me.ProductGV.Name = "ProductGV"
        Me.ProductGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ProductGV.RowHeadersVisible = False
        Me.ProductGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Crimson
        Me.ProductGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ProductGV.Size = New System.Drawing.Size(543, 200)
        Me.ProductGV.TabIndex = 25
        '
        'CustomerGV
        '
        Me.CustomerGV.AllowUserToAddRows = False
        Me.CustomerGV.AllowUserToDeleteRows = False
        Me.CustomerGV.AllowUserToResizeColumns = False
        Me.CustomerGV.AllowUserToResizeRows = False
        Me.CustomerGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomerGV.BackgroundColor = System.Drawing.Color.White
        Me.CustomerGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CustomerGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.CustomerGV.ColumnHeadersHeight = 30
        Me.CustomerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.CustomerGV.EnableHeadersVisualStyles = False
        Me.CustomerGV.Location = New System.Drawing.Point(17, 48)
        Me.CustomerGV.Name = "CustomerGV"
        Me.CustomerGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.CustomerGV.RowHeadersVisible = False
        Me.CustomerGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Crimson
        Me.CustomerGV.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.CustomerGV.Size = New System.Drawing.Size(573, 200)
        Me.CustomerGV.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(826, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 22)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Products List"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(174, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 22)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Customers List"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(673, 323)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 37)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BillGV
        '
        Me.BillGV.AllowUserToAddRows = False
        Me.BillGV.AllowUserToDeleteRows = False
        Me.BillGV.AllowUserToResizeColumns = False
        Me.BillGV.AllowUserToResizeRows = False
        Me.BillGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BillGV.BackgroundColor = System.Drawing.Color.White
        Me.BillGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BillGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BillGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.BillGV.ColumnHeadersHeight = 30
        Me.BillGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BillGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BillGV.DefaultCellStyle = DataGridViewCellStyle9
        Me.BillGV.EnableHeadersVisualStyles = False
        Me.BillGV.Location = New System.Drawing.Point(673, 37)
        Me.BillGV.Name = "BillGV"
        Me.BillGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.BillGV.RowHeadersVisible = False
        Me.BillGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Crimson
        Me.BillGV.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.BillGV.Size = New System.Drawing.Size(543, 265)
        Me.BillGV.TabIndex = 27
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.FillWeight = 177.665!
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.FillWeight = 87.05584!
        Me.Column2.HeaderText = "Product"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.FillWeight = 87.05584!
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.FillWeight = 87.05584!
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.FillWeight = 87.05584!
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.FillWeight = 87.05584!
        Me.Column6.HeaderText = "GST"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.FillWeight = 87.05584!
        Me.Column7.HeaderText = "Total"
        Me.Column7.Name = "Column7"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.customerbtn)
        Me.Panel2.Controls.Add(Me.customertxt)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.productpricetxt)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.addtobillbtn)
        Me.Panel2.Controls.Add(Me.productnametxt)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.productqtytxt)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(232, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 265)
        Me.Panel2.TabIndex = 25
        '
        'customerbtn
        '
        Me.customerbtn.BackColor = System.Drawing.Color.Crimson
        Me.customerbtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerbtn.ForeColor = System.Drawing.Color.White
        Me.customerbtn.Location = New System.Drawing.Point(15, 213)
        Me.customerbtn.Name = "customerbtn"
        Me.customerbtn.Size = New System.Drawing.Size(167, 37)
        Me.customerbtn.TabIndex = 22
        Me.customerbtn.Text = "Change Customer"
        Me.customerbtn.UseVisualStyleBackColor = False
        '
        'customertxt
        '
        Me.customertxt.Enabled = False
        Me.customertxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customertxt.Location = New System.Drawing.Point(15, 164)
        Me.customertxt.Name = "customertxt"
        Me.customertxt.Size = New System.Drawing.Size(167, 33)
        Me.customertxt.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(21, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Customer Name"
        '
        'productpricetxt
        '
        Me.productpricetxt.Enabled = False
        Me.productpricetxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productpricetxt.Location = New System.Drawing.Point(215, 164)
        Me.productpricetxt.Name = "productpricetxt"
        Me.productpricetxt.Size = New System.Drawing.Size(139, 33)
        Me.productpricetxt.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(249, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Price"
        '
        'addtobillbtn
        '
        Me.addtobillbtn.BackColor = System.Drawing.Color.Crimson
        Me.addtobillbtn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addtobillbtn.ForeColor = System.Drawing.Color.White
        Me.addtobillbtn.Location = New System.Drawing.Point(215, 213)
        Me.addtobillbtn.Name = "addtobillbtn"
        Me.addtobillbtn.Size = New System.Drawing.Size(139, 37)
        Me.addtobillbtn.TabIndex = 21
        Me.addtobillbtn.Text = "Add to Bill"
        Me.addtobillbtn.UseVisualStyleBackColor = False
        '
        'productnametxt
        '
        Me.productnametxt.Enabled = False
        Me.productnametxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productnametxt.Location = New System.Drawing.Point(15, 53)
        Me.productnametxt.Name = "productnametxt"
        Me.productnametxt.Size = New System.Drawing.Size(167, 33)
        Me.productnametxt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(21, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product Name"
        '
        'productqtytxt
        '
        Me.productqtytxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productqtytxt.Location = New System.Drawing.Point(215, 53)
        Me.productqtytxt.Name = "productqtytxt"
        Me.productqtytxt.Size = New System.Drawing.Size(139, 33)
        Me.productqtytxt.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(232, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity"
        '
        'doc
        '
        '
        'PPD
        '
        Me.PPD.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PPD.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PPD.ClientSize = New System.Drawing.Size(400, 300)
        Me.PPD.Document = Me.doc
        Me.PPD.Enabled = True
        Me.PPD.Icon = CType(resources.GetObject("PPD.Icon"), System.Drawing.Icon)
        Me.PPD.Name = "PrintPreviewDialog1"
        Me.PPD.Visible = False
        '
        'amttot
        '
        Me.amttot.AutoSize = True
        Me.amttot.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amttot.ForeColor = System.Drawing.Color.Crimson
        Me.amttot.Location = New System.Drawing.Point(814, 333)
        Me.amttot.Name = "amttot"
        Me.amttot.Size = New System.Drawing.Size(65, 18)
        Me.amttot.TabIndex = 41
        Me.amttot.Text = "Amount"
        '
        'GST
        '
        Me.GST.AutoSize = True
        Me.GST.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GST.ForeColor = System.Drawing.Color.Crimson
        Me.GST.Location = New System.Drawing.Point(966, 333)
        Me.GST.Name = "GST"
        Me.GST.Size = New System.Drawing.Size(35, 18)
        Me.GST.TabIndex = 40
        Me.GST.Text = "GST"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.Color.Crimson
        Me.total.Location = New System.Drawing.Point(1096, 333)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(42, 18)
        Me.total.TabIndex = 39
        Me.total.Text = "Total"
        '
        'Bills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1283, 659)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bills"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bills"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ProductGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents addtobillbtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents productqtytxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents productnametxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BillGV As System.Windows.Forms.DataGridView
    Friend WithEvents customertxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents productpricetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CustomerGV As System.Windows.Forms.DataGridView
    Friend WithEvents ProductGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logout As System.Windows.Forms.PictureBox
    Friend WithEvents closes As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents totallbl As System.Windows.Forms.Label
    Friend WithEvents doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents PPD As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customerbtn As System.Windows.Forms.Button
    Friend WithEvents amountlbl As System.Windows.Forms.Label
    Friend WithEvents gstlbl As System.Windows.Forms.Label
    Friend WithEvents amttot As System.Windows.Forms.Label
    Friend WithEvents GST As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
End Class
