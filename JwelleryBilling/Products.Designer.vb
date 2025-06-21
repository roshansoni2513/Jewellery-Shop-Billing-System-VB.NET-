<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.typesrch = New System.Windows.Forms.ComboBox()
        Me.catsrch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProductGV = New System.Windows.Forms.DataGridView()
        Me.logout = New System.Windows.Forms.PictureBox()
        Me.closes = New System.Windows.Forms.PictureBox()
        Me.reset = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.store = New System.Windows.Forms.Button()
        Me.itemtype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.itemqty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemprice = New System.Windows.Forms.TextBox()
        Me.itemcategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.itemname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Productbar = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ProductGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.logout)
        Me.Panel1.Controls.Add(Me.closes)
        Me.Panel1.Controls.Add(Me.reset)
        Me.Panel1.Controls.Add(Me.delete)
        Me.Panel1.Controls.Add(Me.Edit)
        Me.Panel1.Controls.Add(Me.store)
        Me.Panel1.Controls.Add(Me.itemtype)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.itemqty)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.itemprice)
        Me.Panel1.Controls.Add(Me.itemcategory)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.itemname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Crimson
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1260, 635)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Controls.Add(Me.typesrch)
        Me.Panel2.Controls.Add(Me.catsrch)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.ProductGV)
        Me.Panel2.Location = New System.Drawing.Point(15, 239)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1231, 382)
        Me.Panel2.TabIndex = 24
        '
        'typesrch
        '
        Me.typesrch.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typesrch.ForeColor = System.Drawing.Color.Crimson
        Me.typesrch.FormattingEnabled = True
        Me.typesrch.Items.AddRange(New Object() {"Select Type", "Gold", "Silver ", "Diamond"})
        Me.typesrch.Location = New System.Drawing.Point(637, 69)
        Me.typesrch.Name = "typesrch"
        Me.typesrch.Size = New System.Drawing.Size(209, 32)
        Me.typesrch.TabIndex = 19
        Me.typesrch.Text = "Types"
        '
        'catsrch
        '
        Me.catsrch.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.catsrch.ForeColor = System.Drawing.Color.Crimson
        Me.catsrch.FormattingEnabled = True
        Me.catsrch.Items.AddRange(New Object() {"Select Category", "Earings", "Necklace", "Ring", "Bangles", "Bracelet", "Chain"})
        Me.catsrch.Location = New System.Drawing.Point(375, 69)
        Me.catsrch.Name = "catsrch"
        Me.catsrch.Size = New System.Drawing.Size(206, 32)
        Me.catsrch.TabIndex = 18
        Me.catsrch.Text = "Categories"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(556, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Product List"
        '
        'ProductGV
        '
        Me.ProductGV.AllowUserToAddRows = False
        Me.ProductGV.AllowUserToDeleteRows = False
        Me.ProductGV.AllowUserToResizeColumns = False
        Me.ProductGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ProductGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductGV.BackgroundColor = System.Drawing.Color.White
        Me.ProductGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ProductGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductGV.ColumnHeadersHeight = 30
        Me.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductGV.EnableHeadersVisualStyles = False
        Me.ProductGV.Location = New System.Drawing.Point(14, 119)
        Me.ProductGV.Name = "ProductGV"
        Me.ProductGV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProductGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ProductGV.RowHeadersVisible = False
        Me.ProductGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Crimson
        Me.ProductGV.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ProductGV.Size = New System.Drawing.Size(1204, 248)
        Me.ProductGV.TabIndex = 1
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
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.Crimson
        Me.reset.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.Color.White
        Me.reset.Location = New System.Drawing.Point(814, 186)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(109, 37)
        Me.reset.TabIndex = 20
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Crimson
        Me.delete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.Color.White
        Me.delete.Location = New System.Drawing.Point(652, 186)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(109, 37)
        Me.delete.TabIndex = 19
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.Crimson
        Me.Edit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.Color.White
        Me.Edit.Location = New System.Drawing.Point(487, 186)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(109, 37)
        Me.Edit.TabIndex = 18
        Me.Edit.Text = "Update"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'store
        '
        Me.store.BackColor = System.Drawing.Color.Crimson
        Me.store.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.store.ForeColor = System.Drawing.Color.White
        Me.store.Location = New System.Drawing.Point(333, 186)
        Me.store.Name = "store"
        Me.store.Size = New System.Drawing.Size(109, 37)
        Me.store.TabIndex = 17
        Me.store.Text = "Save"
        Me.store.UseVisualStyleBackColor = False
        '
        'itemtype
        '
        Me.itemtype.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemtype.ForeColor = System.Drawing.Color.Crimson
        Me.itemtype.FormattingEnabled = True
        Me.itemtype.Items.AddRange(New Object() {"Select Type", "Gold", "Silver ", "Diamond"})
        Me.itemtype.Location = New System.Drawing.Point(568, 137)
        Me.itemtype.Name = "itemtype"
        Me.itemtype.Size = New System.Drawing.Size(158, 32)
        Me.itemtype.TabIndex = 13
        Me.itemtype.Text = "Types"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(1013, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantity"
        '
        'itemqty
        '
        Me.itemqty.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemqty.Location = New System.Drawing.Point(1019, 136)
        Me.itemqty.Name = "itemqty"
        Me.itemqty.Size = New System.Drawing.Size(139, 33)
        Me.itemqty.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(778, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Price"
        '
        'itemprice
        '
        Me.itemprice.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemprice.Location = New System.Drawing.Point(784, 136)
        Me.itemprice.Name = "itemprice"
        Me.itemprice.Size = New System.Drawing.Size(139, 33)
        Me.itemprice.TabIndex = 9
        '
        'itemcategory
        '
        Me.itemcategory.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemcategory.ForeColor = System.Drawing.Color.Crimson
        Me.itemcategory.FormattingEnabled = True
        Me.itemcategory.Items.AddRange(New Object() {"Select Category", "Earings", "Necklace", "Ring", "Bangles", "Bracelet", "Chain"})
        Me.itemcategory.Location = New System.Drawing.Point(331, 136)
        Me.itemcategory.Name = "itemcategory"
        Me.itemcategory.Size = New System.Drawing.Size(158, 32)
        Me.itemcategory.TabIndex = 8
        Me.itemcategory.Text = "Categories"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(107, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Item"
        '
        'itemname
        '
        Me.itemname.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemname.Location = New System.Drawing.Point(111, 136)
        Me.itemname.Name = "itemname"
        Me.itemname.Size = New System.Drawing.Size(139, 33)
        Me.itemname.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(568, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Products"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Productbar})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1260, 635)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'Productbar
        '
        Me.Productbar.BorderColor = System.Drawing.Color.Crimson
        Me.Productbar.BorderWidth = 2
        Me.Productbar.Name = "Productbar"
        Me.Productbar.SelectionColor = System.Drawing.Color.Crimson
        Me.Productbar.X1 = 569
        Me.Productbar.X2 = 680
        Me.Productbar.Y1 = 94
        Me.Productbar.Y2 = 94
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 659)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1283, 659)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ProductGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents itemname As System.Windows.Forms.TextBox
    Friend WithEvents itemtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents itemqty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents itemprice As System.Windows.Forms.TextBox
    Friend WithEvents itemcategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents store As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents closes As System.Windows.Forms.PictureBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents logout As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents typesrch As System.Windows.Forms.ComboBox
    Friend WithEvents catsrch As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProductGV As System.Windows.Forms.DataGridView
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Productbar As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
