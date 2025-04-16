Public Class Form1
    Public Property ticketIdentifier As String ' for ticket identifier'

    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Form2.Hide()
        Me.Show()
    End Sub

    Private Sub rbnOneWayTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rbnOneWayTrip.CheckedChanged
        ticketIdentifier = "One Way Trip" 'identifies for one way trip'
        lblArrivalDate.Visible = False
        dtpArrivalDate.Visible = False
        lblArrivalTime.Visible = False
        cbxArrivalTime.Visible = False
    End Sub

    Private Sub rbnRoundTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rbnRoundTrip.CheckedChanged
        ticketIdentifier = "Round Trip" 'identifies for round trip'
        lblArrivalDate.Visible = True
        dtpArrivalDate.Visible = True
        lblArrivalTime.Visible = True
        cbxArrivalTime.Visible = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblArrivalDate.Visible = False
        dtpArrivalDate.Visible = False
        lblArrivalTime.Visible = False
        cbxArrivalTime.Visible = False
    End Sub

    Private Sub BTNFILL_Click(sender As Object, e As EventArgs) Handles BTNFILL.Click
        tbxFullname.Text = "Kelvin Dave M. Rivera"
        tbxAddress.Text = "Tarlac"
        tbxCity.Text = "Tarlac City"
        tbxContactNumber.Text = "0999999999"
        tbxEmail.Text = "examplemail@gmail.com"
        tbxPostalCode.Text = "2003"
        tbxGender.Text = "Male"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class
