Public Class Admin
    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim log As New Login
        log.Show()
        Me.Hide()
    End Sub

    Private Sub closes_Click(sender As Object, e As EventArgs) Handles closes.Click
        Application.Exit()
    End Sub

    Private Sub Product_Table_Click(sender As Object, e As EventArgs) Handles Product_Table.Click
        Dim product As New Products
        product.Show()
        Me.Hide()
    End Sub

    Private Sub Customer_Table_Click(sender As Object, e As EventArgs) Handles Customer_Table.Click
        Dim customer As New Customers
        customer.Show()
        Me.Hide()
    End Sub

    Private Sub Employee_Table_Click(sender As Object, e As EventArgs) Handles Employee_Table.Click
        Dim emp As New Employee()
        emp.Show()
        Me.Hide()
    End Sub

    Private Sub Bill_Details_Table_Click(sender As Object, e As EventArgs) Handles Bill_Details_Table.Click
        Dim billdetail As New Bill_Details()
        billdetail.Show()
        Me.Hide()
    End Sub

End Class