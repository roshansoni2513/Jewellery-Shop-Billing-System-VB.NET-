<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bill_Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bill_Items))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.totallbl = New System.Windows.Forms.Label()
        Me.print = New System.Windows.Forms.Button()
        Me.Bill_Items_GV = New System.Windows.Forms.DataGridView()
        Me.PPD = New System.Windows.Forms.PrintPreviewDialog()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.Bill_Items_GV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.back)
        Me.Panel1.Controls.Add(Me.totallbl)
        Me.Panel1.Controls.Add(Me.print)
        Me.Panel1.Controls.Add(Me.Bill_Items_GV)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 361)
        Me.Panel1.TabIndex = 0
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Crimson
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.back.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.Location = New System.Drawing.Point(203, 312)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(110, 40)
        Me.back.TabIndex = 32
        Me.back.Text = "Close"
        Me.back.UseVisualStyleBackColor = False
        '
        'totallbl
        '
        Me.totallbl.AutoSize = True
        Me.totallbl.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totallbl.ForeColor = System.Drawing.Color.Crimson
        Me.totallbl.Location = New System.Drawing.Point(338, 252)
        Me.totallbl.Name = "totallbl"
        Me.totallbl.Size = New System.Drawing.Size(53, 22)
        Me.totallbl.TabIndex = 31
        Me.totallbl.Text = "Total"
        '
        'print
        '
        Me.print.BackColor = System.Drawing.Color.Crimson
        Me.print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.print.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.print.ForeColor = System.Drawing.Color.White
        Me.print.Location = New System.Drawing.Point(463, 312)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(110, 40)
        Me.print.TabIndex = 30
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = False
        '
        'Bill_Items_GV
        '
        Me.Bill_Items_GV.AllowUserToAddRows = False
        Me.Bill_Items_GV.AllowUserToDeleteRows = False
        Me.Bill_Items_GV.AllowUserToResizeColumns = False
        Me.Bill_Items_GV.AllowUserToResizeRows = False
        Me.Bill_Items_GV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Bill_Items_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Bill_Items_GV.BackgroundColor = System.Drawing.Color.White
        Me.Bill_Items_GV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Bill_Items_GV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Bill_Items_GV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bill_Items_GV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Bill_Items_GV.ColumnHeadersHeight = 30
        Me.Bill_Items_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Bill_Items_GV.DefaultCellStyle = DataGridViewCellStyle2
        Me.Bill_Items_GV.EnableHeadersVisualStyles = False
        Me.Bill_Items_GV.Location = New System.Drawing.Point(17, 13)
        Me.Bill_Items_GV.Name = "Bill_Items_GV"
        Me.Bill_Items_GV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bill_Items_GV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Bill_Items_GV.RowHeadersVisible = False
        Me.Bill_Items_GV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Crimson
        Me.Bill_Items_GV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Bill_Items_GV.Size = New System.Drawing.Size(742, 236)
        Me.Bill_Items_GV.TabIndex = 0
        '
        'PPD
        '
        Me.PPD.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PPD.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PPD.ClientSize = New System.Drawing.Size(400, 300)
        Me.PPD.Enabled = True
        Me.PPD.Icon = CType(resources.GetObject("PPD.Icon"), System.Drawing.Icon)
        Me.PPD.Name = "PPD"
        Me.PPD.Visible = False
        '
        'doc
        '
        '
        'Bill_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(800, 385)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Bill_Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bill_Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Bill_Items_GV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Bill_Items_GV As System.Windows.Forms.DataGridView
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents totallbl As System.Windows.Forms.Label
    Friend WithEvents PPD As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents back As System.Windows.Forms.Button
End Class
