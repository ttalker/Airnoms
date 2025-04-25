Public Class Form1
    Public Property ticketIdentifier As String ' for ticket identifier'
    Public Shared Property support_form As New Form3()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnBooking)
        MakeTransparent(btnTicket)
        MakeTransparent(btnSupport)
        MakeTransparent(btnExit)
        MakeTransparent(btnClear)
        MakeTransparent(btnBook)
        btnBooking.Parent = pbxCashierBooking
        btnTicket.Parent = pbxCashierBooking
        btnSupport.Parent = pbxCashierBooking
        btnExit.Parent = pbxCashierBooking
        btnClear.Parent = pbxCashierBooking
        btnBook.Parent = pbxCashierBooking ' transparency of the buttons
        hoverButton(btnBooking)
        hoverButton(btnTicket)
        hoverButton(btnSupport)
        hoverButton(btnExit)
        hoverButton(btnClear)
        hoverButton(btnBook) ' hover effect of the buttons

        Me.DoubleBuffered = True ' double buffered so the form wont tweak or lag

        dtpArrivalDate.Visible = False ' arrival date & time is hidden
        cbxArrivalTime.Visible = False

    End Sub

    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Form2.Hide()
        Me.Show()
    End Sub

    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click
        support_form.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

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


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxCashierBooking.Click
        Me.DoubleBuffered = True
    End Sub


End Class
