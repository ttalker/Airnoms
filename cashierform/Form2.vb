Public Class Form2

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        Show()
        Form1.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblArrivalDateTicket.Visible = False
        lblArrivalTimeTicket.Visible = False
        Me.Size = New Size(1563, 957)
    End Sub

    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click
        Form1.support_form.Show()
    End Sub
End Class