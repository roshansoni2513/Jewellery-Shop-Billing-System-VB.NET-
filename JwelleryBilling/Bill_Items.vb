Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Bill_Items
    Dim tot_amt As Integer = 0
    Private Sub Bill_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            Dim query = "select Bill_Id, Bill_Item, Item_Price, Item_Qty, Taxable_Amount, GST_Amount, Total_Amount from Bill_Details where Bill_Id='" & bill_key & "'"
            Dim cmd As New SqlCommand(query, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim cmdbldr As New SqlCommandBuilder(da)
            Dim ds As New DataSet
            da.Fill(ds)
            Bill_Items_GV.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim i As Integer
        For i = 0 To Bill_Items_GV.Rows.Count() - 1
            tot_amt = tot_amt + Convert.ToInt32(Bill_Items_GV.Rows(i).Cells(6).Value)
        Next
        totallbl.Text = "RS " + tot_amt.ToString()
    End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '   doc.DefaultPageSettings.PaperSize = New PaperSize("MySize", 250, 600)
    '  PPD.WindowState = FormWindowState.Maximized
    'PPD.PrintPreviewControl.Zoom = 2.5
    ' PPD.Document = doc
    'PPD.ShowDialog()
    'Application.Exit()
    'End Sub

    'Private Sub doc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles doc.PrintPage
    'Dim headingname_font As New Font("Century Gothic", 15, FontStyle.Bold)
    'Dim headingadd_font As New Font("Century Gothic", 7, FontStyle.Regular)
    'Dim customer_info_font As New Font("Century Gothic", 7, FontStyle.Regular)
    'Dim basic_font As New Font("Century Gothic", 5, FontStyle.Bold)

    '    Dim left As New StringFormat
    'Dim right As New StringFormat
    'Dim center As New StringFormat

    '       left.Alignment = StringAlignment.Near
    '      right.Alignment = StringAlignment.Far
    '     center.Alignment = StringAlignment.Center

    'Dim box1 As New Rectangle(5, 5, 240, 30)
    'Dim box2 As New Rectangle(5, 35, 240, 15)
    '    Dim box3 As New Rectangle(5, 50, 240, 15)
    '       e.Graphics.DrawRectangle(Pens.Transparent, box1)
    '      e.Graphics.DrawRectangle(Pens.Transparent, box2)
    '     e.Graphics.DrawRectangle(Pens.Transparent, box3)
    '    e.Graphics.DrawString("Jewellery Shop Billing", headingname_font, Brushes.Crimson, box1, center)
    '   e.Graphics.DrawString("Naya Bazar, Ajmer", headingadd_font, Brushes.Crimson, box2, center)
    '  e.Graphics.DrawString("0145 - 2600261, 7014139347", headingadd_font, Brushes.Crimson, box3, center)
    '


    'End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        doc.DefaultPageSettings.PaperSize = New PaperSize("MySize", 250, 600)
        PPD.WindowState = FormWindowState.Maximized
        PPD.PrintPreviewControl.Zoom = 2.5
        PPD.Document = doc
        PPD.ShowDialog()

    End Sub

    Private Sub doc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles doc.PrintPage
        'Setting Fonts
        Dim f8 As New Font("Arial", 8, FontStyle.Regular)
        Dim F8Ab As New Font("Arial", 8, FontStyle.Bold)
        Dim f8b As New Font("Verdana", 8, FontStyle.Regular)
        'Setting Alignments
        Dim left As New StringFormat
        Dim Center As New StringFormat
        Dim Right As New StringFormat

        left.Alignment = StringAlignment.Near
        Center.Alignment = StringAlignment.Center
        Right.Alignment = StringAlignment.Far
        'Drawing Box
        Dim Rect1 As New Rectangle(5, 5, 240, 17)
        Dim Rect2 As New Rectangle(5, 22, 240, 17)
        Dim Rect3 As New Rectangle(5, 39, 240, 17)


        'e.Graphics.DrawRectangle(Pens.Black, Rect1)
        'e.Graphics.DrawRectangle(Pens.Black, Rect2)
        'e.Graphics.DrawRectangle(Pens.Black, Rect3)

        e.Graphics.DrawString("Jewellery Shop", F8Ab, Brushes.Crimson, Rect1, Center)
        e.Graphics.DrawString("Naya Bazar, Ajmer", F8Ab, Brushes.Crimson, Rect2, Center)
        e.Graphics.DrawString("+91-7014139347", F8Ab, Brushes.Crimson, Rect3, Center)

        Dim Rect4 As New Rectangle(5, 73, 60, 17)
        Dim Rect5 As New Rectangle(65, 73, 60, 17)
        Dim Rect6 As New Rectangle(125, 73, 60, 17)
        Dim Rect7 As New Rectangle(185, 73, 60, 17)
        ' e.Graphics.DrawRectangle(Pens.Black, Rect4)
        'e.Graphics.DrawRectangle(Pens.Black, Rect5)
        'e.Graphics.DrawRectangle(Pens.Black, Rect6)
        'e.Graphics.DrawRectangle(Pens.Black, Rect7)

        e.Graphics.DrawString("Item", F8Ab, Brushes.Crimson, Rect4, Center)
        e.Graphics.DrawString("Quant", F8Ab, Brushes.Crimson, Rect5, Center)
        e.Graphics.DrawString("Price", F8Ab, Brushes.Crimson, Rect6, Center)
        e.Graphics.DrawString("Sum", F8Ab, Brushes.Crimson, Rect7, Center)

        Dim y As Integer = 90
        Dim Total As Integer = 0
        Dim gst As Integer = 0
        Dim amount As Integer = 0
        For i = 0 To Bill_Items_GV.Rows.Count - 1
            Dim Rect8 As New Rectangle(5, y, 60, 17)
            Dim Rect9 As New Rectangle(65, y, 60, 17)
            Dim Rect10 As New Rectangle(125, y, 60, 17)
            Dim Rect11 As New Rectangle(185, y, 60, 17)
            'e.Graphics.DrawRectangle(Pens.Black, Rect8)
            'e.Graphics.DrawRectangle(Pens.Black, Rect9)
            'e.Graphics.DrawRectangle(Pens.Black, Rect10)
            'e.Graphics.DrawRectangle(Pens.Black, Rect11)

            e.Graphics.DrawString(Bill_Items_GV.Rows(i).Cells(1).Value, f8, Brushes.Crimson, Rect8, Center)
            e.Graphics.DrawString(Bill_Items_GV.Rows(i).Cells(2).Value, f8, Brushes.Crimson, Rect9, Center)
            e.Graphics.DrawString(Bill_Items_GV.Rows(i).Cells(3).Value, f8, Brushes.Crimson, Rect10, Center)
            e.Graphics.DrawString(Bill_Items_GV.Rows(i).Cells(2).Value * Bill_Items_GV.Rows(i).Cells(3).Value, f8, Brushes.Crimson, Rect11, Center)
            y = y + 17
            Total = Total + Bill_Items_GV.Rows(i).Cells(2).Value * Bill_Items_GV.Rows(i).Cells(3).Value
            gst = gst + Bill_Items_GV.Rows(i).Cells(5).Value()
            amount = amount + Bill_Items_GV.Rows(i).Cells(4).Value()
        Next
        Dim Rect12 As New Rectangle(5, y, 240, 17)
        'e.Graphics.DrawRectangle(Pens.Black, Rect12)
        e.Graphics.DrawString("Total Bill", F8Ab, Brushes.Crimson, Rect12, Center)

        Dim Rect15 As New Rectangle(5, (y + 17), 200, 17)
        'e.Graphics.DrawRectangle(Pens.Black, Rect12)
        e.Graphics.DrawString("Taxable Amount", F8Ab, Brushes.Crimson, Rect15, Center)

        Dim Rect17 As New Rectangle(5, (y + 34), 220, 17)
        'e.Graphics.DrawRectangle(Pens.Black, Rect12)
        e.Graphics.DrawString("GST Amount", F8Ab, Brushes.Crimson, Rect17, Center)

        Dim Rect16 As New Rectangle(185, (y + 17), 60, 17)
        'e.Graphics.DrawRectangle(Pens.Black, Rect12)
        e.Graphics.DrawString(amount, f8b, Brushes.Crimson, Rect16, Center)

        Dim Rect18 As New Rectangle(185, (y + 34), 60, 17)
        'e.Graphics.DrawRectangle(Pens.Black, Rect12)
        e.Graphics.DrawString(gst, f8b, Brushes.Crimson, Rect18, Center)

        Dim Rect13 As New Rectangle(185, y, 60, 17)
        'e.Graphics.DrawRectangle(Pens.Black, Rect13)
        e.Graphics.DrawString(Total, f8b, Brushes.Crimson, Rect13, Center)

        Dim Rect14 As New Rectangle(5, y + 64, 240, 17)
        'e.Graphics.DrawRectangle(Pens.Black, Rect14)
        e.Graphics.DrawString("----Thank You for Shopping With us-----", f8b, Brushes.Crimson, Rect14, Center)

    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim Bill_Detail As New Bill_Details()
        Bill_Detail.Show()
        Me.Hide()
    End Sub
End Class