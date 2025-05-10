Imports System.Runtime.CompilerServices
Imports SharedModule



Public Class Form2
    Dim allPassengers As New List(Of PassengerInfo)
    Private ProcessedPassengers As New HashSet(Of String)
    Private TotalFare As Decimal = 0


    Public BaggagePrices As New Dictionary(Of String, Integer) From {
    {"10kg", 1000},
    {"20kg", 1800},
    {"40kg", 3000}
}
    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click

        If isBooked Then
            MessageBox.Show("Please process the current bookings first!")
        Else
            Me.Hide()
            Form1.Show()
        End If

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

        ' Set the background color of the form to transparent   

        Me.DoubleBuffered = True ' double buffered so the form wont tweak or lag



        ' Add main booker
        allPassengers.Add(New PassengerInfo(
                CurrentBooking.BookerFullName,
                CurrentBooking.BookerAge,
                CurrentBooking.BookerBirthDate,
                CurrentBooking.BookerGender,
                CurrentBooking.BookerSeatNumber,
                CurrentBooking.BookerBaggageAllowance,
                CurrentBooking.BookerIsPWD
                ))

        ' Add co-passengers
        allPassengers.AddRange(CurrentBooking.CoPassengers)

        ' Optional: Display total
        MessageBox.Show($"Total passengers: {allPassengers.Count}")

        MessageBox.Show("Main Booker: " & CurrentBooking.BookerFullName)

        cbxPassengerTicket.Items.Clear()

        ' Add each passenger to the ComboBox
        For Each passenger As PassengerInfo In allPassengers
            cbxPassengerTicket.Items.Add(passenger.FullName) ' Or any other property, such as FullName or SeatNumber
        Next


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim departure = CurrentBooking.Departure
        Dim destination = CurrentBooking.Destination

        For Each passenger As PassengerInfo In allPassengers
            ' Skip if already processed
            If ProcessedPassengers.Contains(passenger.FullName) Then
                MessageBox.Show($"{passenger.FullName} has already been processed.")
                Continue For
            End If

            Dim baseFare As Decimal

            'Try
            '    Select Case passenger.FareClass.ToLower()
            '        Case "economy"
            '            baseFare = GetEconomyFare(departure, destination)
            '        Case "business"
            '            baseFare = GetBusinessFare(departure, destination)
            '        Case "first"
            '            baseFare = GetFirstClassFare(departure, destination)
            '        Case Else
            '            MessageBox.Show($"{passenger.FullName} has an invalid fare class.")
            '            Continue For
            '    End Select
            'Catch ex As Exception
            '    MessageBox.Show($"Error processing fare for {passenger.FullName}: {ex.Message}")
            '    Continue For
            'End Try

            ' Get baggage price
            Dim baggagePrice As Integer
            If Not BaggagePrices.TryGetValue(passenger.BaggageAllowance, baggagePrice) Then
                MessageBox.Show($"{passenger.FullName} has an invalid baggage option.")
                Continue For
            End If

            ' Apply 20% discount if PWD or senior
            Dim discount As Decimal = 0
            If passenger.IsPWD OrElse passenger.Age >= 60 Then
                discount = baseFare * 0.2D
            End If

            Dim finalFare As Decimal = (baseFare - discount) + baggagePrice
            TotalFare += finalFare
            ProcessedPassengers.Add(passenger.FullName)

            ' Optional: display per-passenger fare
            MessageBox.Show($"{passenger.FullName} fare: {finalFare:C}")
        Next

        MessageBox.Show($"Total Fare for all processed passengers: {TotalFare:C}")
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


End Class