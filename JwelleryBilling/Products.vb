Imports System.Data.SqlClient
Public Class Products
    Dim key = 0
    Private Sub Clear()
        itemname.Text = ""
        itemcategory.SelectedIndex = 0
        itemtype.SelectedIndex = 0
        catsrch.SelectedIndex = 0
        typesrch.SelectedIndex = 0
        itemprice.Text = ""
        itemqty.Text = ""
        key = 0
    End Sub
    Private Sub AddItem()
        con.Open()
        Dim query = "select * from item_Table"
        Dim cmd As New SqlCommand(query, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim cmdbld As New SqlCommandBuilder(da)
        Dim ds As New DataSet
        da.Fill(ds)
        ProductGV.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub CategoryFilter()
        If catsrch.SelectedIndex = 0 Then
            AddItem()
        Else
            If typesrch.SelectedIndex = 0 Then
                con.Open()
                Dim query = "select * from item_Table where Item_Category='" & catsrch.SelectedItem.ToString() & "'"
                Dim cmd As New SqlCommand(query, con)
                Dim da As New SqlDataAdapter(cmd)
                Dim cmdbldr As New SqlCommandBuilder(da)
                Dim ds As DataSet
                ds = New DataSet
                da.Fill(ds)
                ProductGV.DataSource = ds.Tables(0)
                con.Close()
            Else
                con.Open()
                Dim query = "select * from item_Table where Item_Category='" & catsrch.SelectedItem.ToString() & "' and Item_Type='" & typesrch.SelectedIndex.ToString() & "'"
                Dim cmd As New SqlCommand(query, con)
                Dim da As New SqlDataAdapter(cmd)
                Dim cmdbldr As New SqlCommandBuilder(da)
                Dim ds As DataSet
                ds = New DataSet
                da.Fill(ds)
                ProductGV.DataSource = ds.Tables(0)
                con.Close()
            End If
        End If
    End Sub
    Private Sub TypeFilter()
        If typesrch.SelectedIndex = 0 Then
            AddItem()
        Else
            If catsrch.SelectedIndex = 0 Then
                con.Open()
                Dim query = "select * from item_Table where Item_Type='" & typesrch.SelectedItem.ToString() & "'"
                Dim cmd As New SqlCommand(query, con)
                Dim da As New SqlDataAdapter(cmd)
                Dim cmdbldr As New SqlCommandBuilder(da)
                Dim ds As New DataSet
                da.Fill(ds)
                ProductGV.DataSource = ds.Tables(0)
                con.Close()
            Else
                con.Open()
                Dim query = "select * from item_Table where Item_Type='" & typesrch.SelectedItem.ToString() & "' and Item_Category='" & catsrch.SelectedItem.ToString() & "'"
                Dim cmd As New SqlCommand(query, con)
                Dim da As New SqlDataAdapter(cmd)
                Dim cmdbldr As New SqlCommandBuilder(da)
                Dim ds As New DataSet
                da.Fill(ds)
                ProductGV.DataSource = ds.Tables(0)
                con.Close()
            End If
        End If
    End Sub
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddItem()
        itemcategory.SelectedIndex = 0
        itemtype.SelectedIndex = 0
        catsrch.SelectedIndex = 0
        typesrch.SelectedIndex = 0
    End Sub

    Private Function item_exist(item_name As String)
        Dim count As Integer = 0
        con.Open()
        Dim query = "select count(*) from Item_Table where Item_Name='" & item_name & "'"
        Dim cmd As New SqlCommand(query, con)
        count = Convert.ToInt32(cmd.ExecuteScalar())
        con.Close()
        Return count
    End Function

    Private Sub store_Click(sender As Object, e As EventArgs) Handles store.Click
        Dim count As Integer = item_exist(itemname.Text)
        If count = 0 Then
            If itemname.Text = "" Or itemcategory.SelectedIndex = -1 Or itemtype.SelectedIndex = -1 Or itemprice.Text = "" Or itemqty.Text = "" Then
                MsgBox("Fill All Details...")
            Else
                Try
                    con.Open()
                    Dim query = "insert into item_Table values('" & itemname.Text & "','" & itemcategory.SelectedItem.ToString() & "','" & itemtype.SelectedItem.ToString() & "','" & itemprice.Text & "','" & itemqty.Text & "')"
                    Dim cmd As New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Item Saved Successfully")
                    con.Close()
                    AddItem()
                    Clear()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            con.Open()
            Dim query = "select Item_Quantity from item_Table where Item_Name='" & itemname.Text & "'"
            Dim cmd As New SqlCommand(query, con)
            Dim quantity As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            quantity = quantity + Val(itemqty.Text)
            MsgBox("Quantity Updated" & quantity)

            Dim query1 = "update item_Table set Item_Quantity='" & quantity & "' where Item_name='" & itemname.Text & "'"
            Dim cmd1 As New SqlCommand(query1, con)
            cmd1.ExecuteNonQuery()
            MsgBox("Quantity Update")
            con.Close()
            AddItem()
        End If
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim adm = New Admin
        adm.Show()
        Me.Hide()
    End Sub

    Private Sub closes_Click(sender As Object, e As EventArgs) Handles closes.Click
        Application.Exit()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If itemname.Text = "" Or itemcategory.SelectedIndex = -1 Or itemtype.SelectedIndex = -1 Or itemprice.Text = "" Or itemqty.Text = "" Or key = 0 Then
            MsgBox("Select a product to Update")
        Else
            Try
                con.Open()
                Dim query = "update item_Table set Item_Name='" & itemname.Text & "', Item_Category='" & itemcategory.SelectedItem.ToString & "', Item_Type='" & itemtype.SelectedItem.ToString & "', Item_Price='" & itemprice.Text & "', Item_Quantity='" & itemqty.Text & "' where Item_Id='" & key & "'"
                Dim cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Product Information Updated Successfully")
                con.Close()
                Clear()
                AddItem()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        Clear()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If key = 0 Then
            MsgBox("Select a product to delete")
        Else
            Try
                con.Open()
                Dim query = "delete from item_Table where Item_Id = '" & key & "'"
                Dim cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Product Deleted Successfully")
                con.Close()
                Clear()
                AddItem()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ProductGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim row As DataGridViewRow = ProductGV.Rows(e.RowIndex)
        Dim itemcat As String = row.Cells(2).Value.ToString().Trim().ToLower
        Dim itmtype As String = row.Cells(3).Value.ToString().Trim().ToLower
        itemname.Text = row.Cells(1).Value.ToString
        itemprice.Text = row.Cells(4).Value.ToString
        itemqty.Text = row.Cells(5).Value.ToString
        For Each item As Object In itemcategory.Items
            If item.ToString().ToLower.StartsWith(itemcat) Then
                itemcategory.SelectedItem = item
            End If
        Next
        For Each item As Object In itemtype.Items
            If item.ToString().ToLower.StartsWith(itmtype) Then
                itemtype.SelectedItem = item
            End If
        Next
        If itemname.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub catsrch_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles catsrch.SelectedIndexChanged
        CategoryFilter()
    End Sub

    Private Sub typesrch_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles typesrch.SelectedIndexChanged
        TypeFilter()
    End Sub

    Private Sub ProductGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductGV.CellContentClick
        Dim row As DataGridViewRow = ProductGV.Rows(e.RowIndex)
        Dim itemcat As String = row.Cells(2).Value.ToString().Trim().ToLower
        Dim itmtype As String = row.Cells(3).Value.ToString().Trim().ToLower
        itemname.Text = row.Cells(1).Value.ToString
        itemprice.Text = row.Cells(4).Value.ToString
        itemqty.Text = row.Cells(5).Value.ToString
        For Each item As Object In itemcategory.Items
            If item.ToString().ToLower.StartsWith(itemcat) Then
                itemcategory.SelectedItem = item
            End If
        Next
        For Each item As Object In itemtype.Items
            If item.ToString().ToLower.StartsWith(itmtype) Then
                itemtype.SelectedItem = item
            End If
        Next
        If itemname.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class