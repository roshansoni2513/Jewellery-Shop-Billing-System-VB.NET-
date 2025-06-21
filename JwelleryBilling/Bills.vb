Imports System.Data.SqlClient
Public Class Bills
    Dim key = 0, stock = 0, custkey = 0, i = 0, GridTot = 0, GSTtot = 0, AmountTot = 0
    Dim bill_id As String = "JSB-001"
    Private Sub DisplayCustomer()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Dim query = "select * from customer_table"
        Dim cmd As New SqlCommand(query, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim cmdbldr As New SqlCommandBuilder(da)
        Dim ds As New DataSet
        da.Fill(ds)
        CustomerGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub DisplayProduct()
        con.Open()
        Dim query = "select * from Item_table"
        Dim cmd As New SqlCommand(query, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim cmdbldr As New SqlCommandBuilder(da)
        Dim ds As New DataSet
        da.Fill(ds)
        ProductGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub AddBillToBilling_Table()
        Try
            con.Open()
            Dim query = "insert into Billing_Table values('" & bill_id & "','" & Date.Today & "','" & GridTot & "','" & GSTtot & "','" & customertxt.Text & "','" & emp_name & "')"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddBillToBill_Details()
        
        Try
            con.Open()
            Dim tot_price As Integer = 0
            Dim amount As Integer = 0
            Dim gst_amt As Integer = 0
            Dim prod_price As Integer = 0
            Dim prod_qty As Integer = 0
            Dim query As String
            Dim cmd As SqlCommand
            Dim i As Integer
            For i = 0 To BillGV.Rows.Count - 1
                prod_price = Convert.ToInt32(BillGV.Rows(i).Cells(2).Value)
                prod_qty = Convert.ToInt32(BillGV.Rows(i).Cells(3).Value)
                tot_price = prod_price * prod_qty
                amount = tot_price / 1.18
                gst_amt = tot_price * 0.03
                query = "insert into Bill_Details values('" & bill_id & "','" & Date.Today & "','" & customertxt.Text & "','" & emp_name & "','" & BillGV.Rows(i).Cells(1).Value & "','" & prod_qty & "','" & prod_price & "','" & gst_amt & "','" & amount & "','" & tot_price & "')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.state = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Function item_exists(item_name As String)
        'Dim yes As Boolean = False
        For Each row As DataGridViewRow In BillGV.Rows
            If row.Cells("Column2").Value IsNot Nothing AndAlso row.Cells("Column2").Value.ToString() = item_name Then
                Return row.Index
                Exit For
            End If
        Next
        Return -1
    End Function
    Private Sub bill_id_gen()
        Try
            con.Open()
            Dim query = "select top 1 Bill_Id from Billing_Table order by Bill_Id desc"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            Dim res As Object = cmd.ExecuteScalar()
            If res IsNot Nothing Then
                Dim lastbillid As String = res.ToString()
                Dim num As Integer = Integer.Parse(lastbillid.Substring(4))
                num = num + 1
                bill_id = "JSB-" + num.ToString("D3")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim log As New Login()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub closes_Click(sender As Object, e As EventArgs) Handles closes.Click
        Application.Exit()
    End Sub

    Private Sub Bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCustomer()
        DisplayProduct()
        amountlbl.Text = ""
        gstlbl.Text = ""
        totallbl.Text = ""
    End Sub

    Private Sub UpdateItem()
        Dim NewQty = stock - Convert.ToInt32(productqtytxt.Text)
        Try
            con.Open()
            Dim query = "update Item_Table set Item_Quantity='" & NewQty & "' where Item_Id='" & key & "'"
            Dim cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
            DisplayProduct()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub clear()
        productnametxt.Text = ""
        productpricetxt.Text = ""
        productqtytxt.Text = ""
        key = 0
        custkey = 0
    End Sub

    Private Sub CustomerGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CustomerGV.CellMouseClick
        Dim row As DataGridViewRow = CustomerGV.Rows(e.RowIndex)
        If customertxt.Text = "" Then
            customertxt.Text = row.Cells(1).Value.ToString()
            If customertxt.Text = "" Then
                custkey = 0
            Else
                custkey = Convert.ToInt32(row.Cells(0).Value.ToString())
            End If
        Else
            MsgBox("Customer Already Selected")
        End If

    End Sub

    Private Sub ProductGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProductGV.CellMouseClick
        Dim row As DataGridViewRow = ProductGV.Rows(e.RowIndex)
        productnametxt.Text = row.Cells(1).Value.ToString()
        productpricetxt.Text = row.Cells(4).Value.ToString()
        If productnametxt.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString())
            stock = Convert.ToInt32(row.Cells(5).Value.ToString())
        End If
        productqtytxt.Focus()
    End Sub

    Private Sub addtobillbtn_Click(sender As Object, e As EventArgs) Handles addtobillbtn.Click
        If productqtytxt.Text = "" Then
            MsgBox("Enter Quantity...")
        ElseIf productnametxt.Text = "" Or productpricetxt.Text = "" Then
            MsgBox("Select an Item...")
        ElseIf Convert.ToInt32(productqtytxt.Text) > stock Then
            MsgBox("Not Enough Stock...")
        Else
            Dim rowindex As Integer = item_exists(productnametxt.Text)
            If rowindex <> -1 Then
                BillGV.Rows(rowindex).Cells("Column4").Value() = Convert.ToInt32(BillGV.Rows(rowindex).Cells("Column4").Value()) + Val(productqtytxt.Text)
                Dim total As Integer = 0
                total = Convert.ToInt32(BillGV.Rows(rowindex).Cells("Column3").Value()) * Convert.ToInt32(BillGV.Rows(rowindex).Cells("Column4").Value())
                Dim amount As Integer = total / 1.03
                Dim gst As Integer = amount * 0.03
                BillGV.Rows(rowindex).Cells("Column5").Value() = amount
                BillGV.Rows(rowindex).Cells("column6").Value() = gst
                BillGV.Rows(rowindex).Cells("Column7").Value() = total
                UpdateItem()
                clear()
            Else
                Dim rnum As Integer = BillGV.Rows.Add()
                i = i + 1
                Dim total As Integer = Convert.ToInt32(productqtytxt.Text) * Convert.ToInt32(productpricetxt.Text)
                Dim amount As Integer = total / 1.03
                Dim gst As Integer = amount * 0.03
                BillGV.Rows.Item(rnum).Cells("Column1").Value = i
                BillGV.Rows.Item(rnum).Cells("Column2").Value = productnametxt.Text
                BillGV.Rows.Item(rnum).Cells("Column3").Value = productpricetxt.Text
                BillGV.Rows.Item(rnum).Cells("Column4").Value = productqtytxt.Text
                BillGV.Rows.Item(rnum).Cells("Column5").Value = amount
                BillGV.Rows.Item(rnum).Cells("Column6").Value = gst
                BillGV.Rows.Item(rnum).Cells("Column7").Value = total
                UpdateItem()
                clear()
            End If
            GridTot = 0
            AmountTot = 0
            GSTtot = 0
            For Each row As DataGridViewRow In BillGV.Rows
                GridTot = GridTot + Convert.ToInt32(row.Cells("Column7").Value())
                AmountTot = AmountTot + Convert.ToInt32(row.Cells("Column5").Value())
                GSTtot = GSTtot + Convert.ToInt32(row.Cells("Column6").Value())
            Next
            If GridTot <> 0 Then
                totallbl.Text = Convert.ToString(GridTot) + "\-"
            End If
            If AmountTot <> 0 Then
                amountlbl.Text = Convert.ToString(AmountTot) + "\-"
            End If
            If GSTtot <> 0 Then
                gstlbl.Text = Convert.ToString(GSTtot) + "\-"
            End If
        End If
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
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
        For i = 0 To BillGV.Rows.Count - 1
            Dim Rect8 As New Rectangle(5, y, 60, 17)
            Dim Rect9 As New Rectangle(65, y, 60, 17)
            Dim Rect10 As New Rectangle(125, y, 60, 17)
            Dim Rect11 As New Rectangle(185, y, 60, 17)
            'e.Graphics.DrawRectangle(Pens.Black, Rect8)
            'e.Graphics.DrawRectangle(Pens.Black, Rect9)
            'e.Graphics.DrawRectangle(Pens.Black, Rect10)
            'e.Graphics.DrawRectangle(Pens.Black, Rect11)

            e.Graphics.DrawString(BillGV.Rows(i).Cells(1).Value, f8, Brushes.Crimson, Rect8, Center)
            e.Graphics.DrawString(BillGV.Rows(i).Cells(2).Value, f8, Brushes.Crimson, Rect9, Center)
            e.Graphics.DrawString(BillGV.Rows(i).Cells(3).Value, f8, Brushes.Crimson, Rect10, Center)
            e.Graphics.DrawString(BillGV.Rows(i).Cells(2).Value * BillGV.Rows(i).Cells(3).Value, f8, Brushes.Crimson, Rect11, Center)
            y = y + 17
            Total = Total + BillGV.Rows(i).Cells(2).Value * BillGV.Rows(i).Cells(3).Value
            gst = gst + BillGV.Rows(i).Cells(5).Value()
            amount = amount + BillGV.Rows(i).Cells(4).Value()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bill_id_gen()
        AddBillToBill_Details()
        AddBillToBilling_Table()
        doc.DefaultPageSettings.PaperSize = New Printing.PaperSize("My Size", 250, 600)
        PPD.WindowState = FormWindowState.Maximized
        PPD.PrintPreviewControl.Zoom = 2.5
        PPD.Document = doc
        PPD.Show()
    End Sub

    Private Sub customerbtn_Click(sender As Object, e As EventArgs) Handles customerbtn.Click
        customertxt.Text = ""
    End Sub
End Class