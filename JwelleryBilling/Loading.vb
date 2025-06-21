Public Class Loading
    Dim i As Integer = 0
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub loader(value As Integer)
        Dim maxwidth As Integer = Panel1.Width
        Dim newwidth As Integer = (value * maxwidth) / 100
        Panel2.Width = newwidth
        Panel2.BackColor = Color.Crimson
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        Label2.Text = i & " %"
        If i <= 100 Then
            loader(i)
        Else
            Timer1.Enabled = False
            Dim log As New Login()
            log.Show()
            Me.Hide()
        End If
    End Sub
End Class
