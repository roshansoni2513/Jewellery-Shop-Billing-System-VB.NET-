Imports System.Data.SqlClient
Public Class Employee
    Dim key = 0
    Private Sub clear()
        empnametxt.Text = ""
        usernametxt.Text = ""
        passwordtxt.Text = ""
        key = 0
    End Sub
    Private Sub Addemp()
        con.Open()
        Dim query = "select * from Employee_table"
        Dim cmd As New SqlCommand(query, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim cmdbldr As New SqlCommandBuilder(da)
        Dim ds As New DataSet
        da.Fill(ds)
        EmployeeGV.DataSource = ds.Tables(0)
        EmployeeGV.Columns(0).Width = 200
        con.Close()
    End Sub
    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim adm As New Admin()
        adm.Show()
        Me.Hide()
    End Sub

    Private Sub closes_Click(sender As Object, e As EventArgs) Handles closes.Click
        Application.Exit()
    End Sub

    Private Function employee_exist(name As String)
        Dim count As Integer = 0
        con.Open()
        Dim query = "select count(*) from Employee_table where Emp_name='" & name & "'"
        Dim cmd As New SqlCommand(query, con)
        count = Convert.ToInt32(cmd.ExecuteScalar())
        con.Close()
        Return count
    End Function

    Private Sub store_Click(sender As Object, e As EventArgs) Handles store.Click
        Dim name = Char.ToUpper(empnametxt.Text(0)) & empnametxt.Text.ToString.Substring(1)
        Dim count As Integer = employee_exist(name)
        If count = 0 Then
            If empnametxt.Text = "" Or usernametxt.Text = "" Or passwordtxt.Text = "" Then
                MsgBox("Fill All The Details....")
            Else
                Try
                    con.Open()
                    Dim query = "insert into Employee_table values('" & name & "','" & usernametxt.Text & "','" & passwordtxt.Text & "')"
                    Dim cmd As New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Employee Details Saved Successfully.....")
                    con.Close()
                    clear()
                    Addemp()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Employee Already Exists.... ")
            clear()
            Addemp()
        End If
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Addemp()
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        clear()
    End Sub

    Private Sub EmployeeGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Dim row As DataGridViewRow = EmployeeGV.Rows(e.RowIndex)
        empnametxt.Text = row.Cells(1).Value.ToString()
        usernametxt.Text = row.Cells(2).Value.ToString()
        passwordtxt.Text = row.Cells(3).Value.ToString()
        If empnametxt.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString())
        End If
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If empnametxt.Text = "" Or usernametxt.Text = "" Or passwordtxt.Text = "" Then
            MsgBox("Select A Employee To Be Updated....")
        Else
            Try
                Dim name = Char.ToUpper(empnametxt.Text(0)) & empnametxt.Text.ToString.Substring(1)
                con.Open()
                Dim query = "update Employee_table set Emp_name='" & name & "',Emp_username='" & usernametxt.Text & "',Emp_pass='" & passwordtxt.Text & "' where Emp_id='" & key & "'"
                Dim cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Updated Successfully....")
                con.close()
                clear()
                Addemp()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If key = 0 Then
            MsgBox("Please Select an Employee To Be Deleted")
        Else
            Try
                con.Open()
                Dim query = "delete from Employee_table where Emp_id='" & key & "'"
                Dim cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Deleted Successfully...")
                con.Close()
                clear()
                Addemp()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub EmployeeGV_CellMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeGV.Rows(e.RowIndex)
        empnametxt.Text = row.Cells(1).Value.ToString().TrimEnd
        usernametxt.Text = row.Cells(2).Value.ToString().TrimEnd
        passwordtxt.Text = row.Cells(3).Value.ToString().TrimEnd
        If empnametxt.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

End Class