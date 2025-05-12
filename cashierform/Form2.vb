Imports System.Runtime.CompilerServices
Imports SharedModule



Public Class Form2

    Private ProcessedPassengers As New HashSet(Of String)
    Private TotalFare As Decimal = 0


    Public BaggagePrices As New Dictionary(Of String, Integer) From {
    {"10kg", 1000},
    {"20kg", 1800},
    {"40kg", 3000}
}
    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click

        Show()
        Form1.Hide()
    End Sub

    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click

        Form1.support_form.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitToUserForm(Me)
    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnBooking)
        MakeTransparent(btnTicket)
        MakeTransparent(btnSupport)
        MakeTransparent(btnExit)
        MakeTransparent(btnCalculate)
        MakeTransparent(btnResetTicket)
        MakeTransparent(btnNextTicket)
        MakeTransparent(btnProcessTicket)

        btnBooking.Parent = pbxCashierTicket
        btnTicket.Parent = pbxCashierTicket
        btnSupport.Parent = pbxCashierTicket
        btnExit.Parent = pbxCashierTicket
        btnCalculate.Parent = pbxCashierTicket
        btnResetTicket.Parent = pbxCashierTicket
        btnNextTicket.Parent = pbxCashierTicket
        btnProcessTicket.Parent = pbxCashierTicket ' transparency of the buttons

        hoverButton(btnBooking)
        hoverButton(btnTicket)
        hoverButton(btnSupport)
        hoverButton(btnExit)
        hoverButton(btnCalculate)
        hoverButton(btnResetTicket)
        hoverButton(btnProcessTicket) ' hover effect of the buttons

        btnNextTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnNextTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)
        btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnCalculate.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255) ' hover effect of the button next ticket and calculate
        btnProcessTicket.Enabled = False

        ' Set the background color of the form to transparent   

        Me.DoubleBuffered = True ' double buffered so the form wont tweak or lag


        cbxPassengerTicket.Items.Clear()

        ' Add each passenger to the ComboBox
        For Each passenger As PassengerInfo In allPassengers
            cbxPassengerTicket.Items.Add(passenger.FullName) ' Or any other property, such as FullName or SeatNumber
        Next



    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

    End Sub

    Private Sub cbxPassengerTicket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPassengerTicket.SelectedIndexChanged
        Dim selectedIndex As Integer = cbxPassengerTicket.SelectedIndex

        If selectedIndex >= 0 AndAlso selectedIndex < allPassengers.Count Then
            Dim selectedPassenger As PassengerInfo = allPassengers(selectedIndex)

            ' Display in labels
            lblFullNameTicket.Text = selectedPassenger.FullName
            lblDateOfBirthTicket.Text = selectedPassenger.DateOfBirth.ToShortDateString()
            lblGenderTicket.Text = selectedPassenger.Gender
            lblSeatNumTicket.Text = selectedPassenger.SeatNumber
            lblBaggageAllowanceTicket.Text = selectedPassenger.BaggageAllowance
            lblPWDTicket.Text = If(selectedPassenger.IsPWD, "Yes", "No")
            lblAdressTicket.Text = CurrentBooking.BookerAddress.ToString
            lblBookingDateTicket.Text = CurrentBooking.BookingDate.ToShortDateString()
            lblDestinationTicket.Text = CurrentBooking.Destination
            lblDepartDateTicket.Text = CurrentBooking.DepartDate.ToShortDateString()
            lblArrivalDateTicket.Text = CurrentBooking.ArrivalDate.ToShortDateString()
            lblDepartTimeTicket.Text = CurrentBooking.DepartTime
            lblArrivalTimeTicket.Text = CurrentBooking.ArrivalTime
            lblBookedUnderTicket.Text = CurrentBooking.BookerFullName


        End If
    End Sub

    Private Sub cbxClassTicket_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class