Imports System.Data.SqlClient
Public Class Bill_Details
    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim adm As New Admin()
        adm.Show()
        Me.Hide()
    End Sub

    Private Sub AddBills()
        Try
            con.Open()
            Dim query = "select * from Billing_Table"
            Dim cmd As New SqlCommand(query, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim cmdbldr As New SqlCommandBuilder(da)
            Dim ds As New DataSet
            da.Fill(ds)
            AllBillsGV.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LoadCombobox()
        Try
            con.Open()
            Dim query = "select Emp_name from Employee_Table"
            Dim cmd As New SqlCommand(query, con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                employee.Items.Add(reader("Emp_name").ToString().TrimEnd())
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub closes_Click(sender As Object, e As EventArgs) Handles closes.Click
        Application.Exit()
    End Sub

    Private Sub Bill_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddBills()
        LoadCombobox()
    End Sub

    Private Sub AllBillsGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AllBillsGV.CellMouseClick
        Dim row As DataGridViewRow = AllBillsGV.Rows(e.RowIndex)
        bill_key = row.Cells(0).Value.ToString()
        Dim show_details As New Bill_Items()
        show_details.Show()
        Me.Hide()
    End Sub

    Private Sub employee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employee.SelectedIndexChanged
        Try
            con.Open()
            Dim query As String
            If employee.SelectedItem = "None" Then
                query = "select * from Billing_Table"
            Else
                query = "select * from Billing_Table where Emp_name='" & employee.SelectedItem & "'"
            End If
            Dim cmd As New SqlCommand(query, con)
            Dim da As New SqlDataAdapter(cmd)
            Dim cmdbldr As New SqlCommandBuilder(da)
            Dim ds As New DataSet
            da.Fill(ds)
            AllBillsGV.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class