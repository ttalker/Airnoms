Public Class Form1
    Public Property ticketIdentifier As String ' for ticket identifier'
    Public Shared Property support_form As New Form3()

    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Form2.Hide()
        Me.Show()
    End Sub
    'base load'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD
<<<<<<< HEAD
        'lblArrivalDate.Visible = False
=======
>>>>>>> 7ba4d9e0cf15db48332c536ae5a60e9511323aa5
=======
        'lblArrivalDate.Visible = False
>>>>>>> 49da96fcdc7d0ddbf070ef2450c2306a548bd3b1
        dtpArrivalDate.Visible = False
        cbxArrivalTime.Visible = False
        Me.Size = New Size(1563, 957)
        'cbxFlight.Size = New Size(110, 30)
        'cbxSeatNumber.Size = New Size(110, 30)
    End Sub
    Private Sub rbnOneWayTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rbnOneWayTrip.CheckedChanged
        ticketIdentifier = "One Way Trip" 'identifies for one way trip'
        dtpArrivalDate.Visible = False
        cbxArrivalTime.Visible = False
    End Sub

    Private Sub rbnRoundTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rbnRoundTrip.CheckedChanged
        ticketIdentifier = "Round Trip" 'identifies for round trip'
        dtpArrivalDate.Visible = True
        cbxArrivalTime.Visible = True

    End Sub



    Private Sub BTNFILL_Click(sender As Object, e As EventArgs) Handles BTNFILL.Click
        tbxFullname.Text = "Kelvin Dave M. Rivera"
        tbxAddress.Text = "Tarlac"
        tbxCity.Text = "Tarlac City"
        tbxContactNumber.Text = "0999999999"
        tbxEmail.Text = "examplemail@gmail.com"
        tbxPostalCode.Text = "2003"
        tbxGender.Text = "Male"
        cbxDeparture.Text = "Tarlac"
        cbxDestination.Text = "Seoul, Korea"
        cbxSeatNumber.Text = "1A"
        cbxDepartureTime.Text = "May 1, 2025"
        cbxArrivalTime.Text = "May 1, 2025"
        dtpArrivalDate.Text = "May 1, 2025"
        dtpDeparture.Text = "May 1, 2025"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxFullname.Clear()
        tbxAddress.Clear()
        tbxCity.Clear()
        tbxContactNumber.Clear()
        tbxEmail.Clear()
        tbxPostalCode.Clear()
        tbxGender.Clear()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSupport.Click
        support_form.Show()

    End Sub

End Class
