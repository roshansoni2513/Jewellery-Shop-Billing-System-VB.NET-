Imports System.Data.SqlClient
Public Class Login
    Private Sub closes_Click(sender As Object, e As EventArgs) Handles closes.Click, closes.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Dim bill = New Bills
        bill.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        employeebar.Hide()
        employee_panel.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        employeebar.Show()
        employee_panel.Show()
        admin_panel.Hide()
        adminbar.Hide()
        emp_usernametb.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        employee_panel.Hide()
        employeebar.Hide()
        admin_panel.Show()
        adminbar.Show()
    End Sub

    Private Sub emplogin_Click(sender As Object, e As EventArgs) Handles emplogin.Click
        Dim user As String = emp_usernametb.Text.TrimEnd()
        Dim pass As String = emp_passtb.Text.TrimEnd()
        Try
            con.Open()
            Dim query = "select count(*) from Employee_table where Emp_username='" & user & "' and Emp_pass='" & pass & "'"
            Dim cmd As New SqlCommand(query, con)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                Dim bill As New Bills
                bill.Show()
                Me.Hide()
            Else
                MsgBox("Not a Valid Employee")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub adminlogin_Click(sender As Object, e As EventArgs) Handles adminlogin.Click
        If admin_usertb.Text = "decole" And admin_passtb.Text = "123456" Then
            Dim adm As New Admin()
            adm.Show()
            Me.Hide()
        Else
            MsgBox("Wrong username password")
        End If
    End Sub
End Class