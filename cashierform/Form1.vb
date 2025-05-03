'Imports userForm.Module1
'Imports admin.Module1
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports SharedModule
Imports System.Windows.Forms



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

    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click
        support_form.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'ExitApplication(Me)
    End Sub

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
        cbxGender.Text = "Male"
        cbxDeparture.Text = "Tarlac"
        cbxDestination.Text = "Seoul, Korea"
        cbxSeatNumber.Text = "1A"
        cbxDepartureTime.Text = "May 1, 2025"
        cbxArrivalTime.Text = "May 1, 2025"
        dtpArrivalDate.Text = "May 1, 2025"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all the inputs 
        tbxFullname.Clear()
        tbxAddress.Clear()
        cbxGender.Text = ""
        dtpBookingDate.Text = ""
        dtpBirthdate.Text = ""
        cbxArrivalTime.Text = ""
        cbxDepartureTime.Text = ""
        cbxDeparture.Text = ""
        cbxDestination.Text = ""
        cbxSeatNumber.Text = ""
        tbxAge.Text = ""

        'Clear the inputs in passenger
        For i As Integer = 1 To 6
            'finds the controls no matter their parent
            Dim tbxName = Me.Controls.Find("tbxPassname" & i, True).FirstOrDefault()
            Dim tbxAge = Me.Controls.Find("tbxpassAge" & i, True).FirstOrDefault()
            Dim dtpBday = Me.Controls.Find("dtppassbday" & i, True).FirstOrDefault()
            Dim cbxGen = Me.Controls.Find("cbxpassgen" & i, True).FirstOrDefault()
            Dim cbxSeat = Me.Controls.Find("cbxpassseat" & i, True).FirstOrDefault()
            Dim cbxBag = Me.Controls.Find("cbxpassbag" & i, True).FirstOrDefault()

            'clears the input
            If TypeOf tbxName Is System.Windows.Forms.TextBox Then DirectCast(tbxName, System.Windows.Forms.TextBox).Clear()
            If TypeOf tbxAge Is System.Windows.Forms.TextBox Then DirectCast(tbxAge, System.Windows.Forms.TextBox).Clear()
            If TypeOf dtpBday Is System.Windows.Forms.DateTimePicker Then DirectCast(dtpBday, System.Windows.Forms.DateTimePicker).Value = DateTime.Now
            If TypeOf cbxGen Is System.Windows.Forms.ComboBox Then DirectCast(cbxGen, System.Windows.Forms.ComboBox).SelectedIndex = -1
            If TypeOf cbxSeat Is System.Windows.Forms.ComboBox Then DirectCast(cbxSeat, System.Windows.Forms.ComboBox).SelectedIndex = -1
            If TypeOf cbxBag Is System.Windows.Forms.ComboBox Then DirectCast(cbxBag, System.Windows.Forms.ComboBox).SelectedIndex = -1
        Next

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxCashierBooking.Click
        DoubleBuffered = True
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click

        Provide_tbxError(tbxFullname, ErrorProvider1)
        Provide_tbxError(tbxAddress, ErrorProvider1)
        Provide_cbxError(cbxGender, ErrorProvider1)
        Provide_cbxError(cbxArrivalTime, ErrorProvider1)
        Provide_cbxError(cbxArrivalTime, ErrorProvider1)
        Provide_cbxError(cbxArrivalTime, ErrorProvider1)
        Provide_cbxError(cbxArrivalTime, ErrorProvider1)
        Provide_cbxError(cbxArrivalTime, ErrorProvider1)
        Provide_cbxError(cbxArrivalTime, ErrorProvider1)
        Provide_cbxError(cbxArrivalTime, ErrorProvider1)
        Provide_cbxError(cbxArrivalTime, ErrorProvider1)
        Provide_tbxError(tbxAge, ErrorProvider1)
        Provide_cbxError(cbxBaggage, ErrorProvider1)
        Provide_cbxError(cbxDeparture, ErrorProvider1)
        Provide_cbxError(cbxDestination, ErrorProvider1)
        Provide_cbxError(cbxSeatNumber, ErrorProvider1)
        Provide_cbxError(cbxDepartureTime, ErrorProvider1)


    End Sub

End Class
