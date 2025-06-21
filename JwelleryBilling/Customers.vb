Imports System.Data.SqlClient
Public Class Customers
    Dim key = 0
    Private Sub clear()
        customername.Text = ""
        customerphone.Text = ""
        customeradd.Text = ""
        key = 0
    End Sub

    Private Sub Addcust()
        Try
            con.Open()
            Dim query = "select * from customer_table"
            Dim cmd As New SqlCommand(query, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim cmdbldr As New SqlCommandBuilder(da)
            Dim ds As New DataSet
            da.Fill(ds)
            CustomerGV.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Addcust()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim adm As New Admin
        adm.Show()
        Me.Hide()
    End Sub

    Private Sub closes_Click(sender As Object, e As EventArgs) Handles closes.Click
        Application.Exit()
    End Sub

    Private Sub Product_Table_Click(sender As Object, e As EventArgs)
        Dim product As New Products
        product.Show()
        Me.Hide()
    End Sub

    Private Sub store_Click(sender As Object, e As EventArgs) Handles store.Click
        If customername.Text = "" Or customerphone.Text = "" Or customeradd.Text = "" Then
            MsgBox("Fill All Details..")
        Else
            Try
                con.Open()
                Dim query = "insert into customer_table values('" & customername.Text & "', '" & customerphone.Text & "', '" & customeradd.Text & "')"
                Dim cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Details Saved Successfully..")
                con.Close()
                clear()
                Addcust()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CustomerGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CustomerGV.CellMouseClick
        Dim row As DataGridViewRow = CustomerGV.Rows(e.RowIndex)
        customername.Text = row.Cells(1).Value.ToString
        customerphone.Text = row.Cells(2).Value.ToString
        customeradd.Text = row.Cells(3).Value.ToString
        If customername.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If customername.Text = "" Or customerphone.Text = "" Or customeradd.Text = "" Then
            MsgBox("Select a Customer To Update...")
        Else
            Try
                con.Open()
                Dim query = "update customer_table set customer_name='" & customername.Text & "', customer_phone='" & customerphone.Text & "', customer_address='" & customeradd.Text & "' where customer_id='" & key & "'"
                Dim cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Details Updated Successfully...")
                con.Close()
                clear()
                Addcust()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If key = 0 Then
            MsgBox("Select a Customer To Delete...")
        Else
            Try
                con.Open()
                Dim query = "delete from customer_table where customer_id='" & key & "'"
                Dim cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Information Deleted Successfully")
                con.Close()
                clear()
                Addcust()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        clear()
    End Sub

End Class