Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports SharedModule



Public Class Form2

    Private ProcessedPassengers As New HashSet(Of String)
    Private TotalFare As Decimal = 0

    Dim current_dict = bookingDictionary
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
        MakeTransparent(btnSearch)

        btnBooking.Parent = pbxCashierTicket
        btnTicket.Parent = pbxCashierTicket
        btnSupport.Parent = pbxCashierTicket
        btnExit.Parent = pbxCashierTicket
        btnCalculate.Parent = pbxCashierTicket
        btnResetTicket.Parent = pbxCashierTicket
        btnNextTicket.Parent = pbxCashierTicket
        btnSearch.Parent = pbxCashierTicket
        btnProcessTicket.Parent = pbxCashierTicket ' transparency of the buttons

        hoverButton(btnBooking)
        hoverButton(btnTicket)
        hoverButton(btnSupport)
        hoverButton(btnExit)
        hoverButton(btnCalculate)
        hoverButton(btnResetTicket)
        hoverButton(btnSearch)
        hoverButton(btnProcessTicket) ' hover effect of the buttons

        btnNextTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnNextTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)
        btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnCalculate.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255) ' hover effect of the button next ticket and calculate
        btnProcessTicket.Enabled = False

        ' Set the background color of the form to transparent   

        Me.DoubleBuffered = True ' double buffered so the form wont tweak or lag

        cbxPassengerTicket.AutoCompleteMode = AutoCompleteMode.None
        cbxPassengerTicket.DropDownStyle = ComboBoxStyle.DropDown

        'Load bookers
        Dim bookers = LoadBookers()

        For Each booker In bookers
            cbxPassengerTicket.Items.Add(booker)
        Next

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

    End Sub
    Private Sub Assign_Customer()
        Dim current_booker As Customers = current_dict(cbxPassengerTicket.Text)
        'assign all the fields to a variable for easy access
        Dim customerID = current_booker.CustomerID
        Dim fullName = current_booker.FullName
        Dim age = current_booker.Age
        Dim dateOfBirth = current_booker.DateOfBirth
        Dim gender = current_booker.Gender
        Dim seatNumber = current_booker.SeatNumber
        Dim baggageAllowance = current_booker.BaggageAllowance
        Dim address = current_booker.Address
        Dim pwdStatus = current_booker.PWDStatus
        Dim departure = current_booker.Departure
        Dim destination = current_booker.Destination
        Dim tripType = current_booker.TripType
        Dim bookingDate = current_booker.BookingDate
        Dim departureTime = current_booker.DepartureTime
        Dim arrivalTime = current_booker.ArrivalTime
        Dim flightID = current_booker.FlightID
        Dim booked_under = current_booker.BookedUnder

        Dim plane_type = GetPlaneTypeByDestinationAndTime(destination, departureTime, bookingDate)
        'generate seatmap and confirm the seatclass
        Dim seat_map = GenerateSeats(plane_type).seatmap
        Dim class_type = seat_map(seatNumber)


        lblClass.Text = class_type
        lblDepartDateTicket.Text = departure
        lblDepartTimeTicket.Text = departureTime
        lblArrivalDateTicket.Text = bookingDate.AddDays(1).ToShortDateString() ' example, if arrival is next day
        lblArrivalTimeTicket.Text = arrivalTime
        lblBookingDateTicket.Text = bookingDate.ToShortDateString()
        lblBookedUnderTicket.Text = booked_under
        lblFullNameTicket.Text = fullName
        lblSeatNumTicket.Text = seatNumber
        lblDateOfBirthTicket.Text = dateOfBirth.ToShortDateString()
        lblDestinationTicket.Text = destination
        lblGenderTicket.Text = gender
        lblBaggageAllowanceTicket.Text = baggageAllowance
        lblAdressTicket.Text = address
        lblPWDTicket.Text = If(pwdStatus, "Yes", "No")

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Not String.IsNullOrWhiteSpace(cbxPassengerTicket.Text) Then
            Try
                Dim searchText As String = cbxPassengerTicket.Text.Trim().ToLower()
                cbxPassengerTicket.Items.Clear()

                Dim found As Boolean = False

                For Each key In bookingDictionary.Keys
                    If searchText = "" OrElse key.ToLower().Contains(searchText) Then
                        cbxPassengerTicket.Items.Add(key)
                        found = True
                    End If
                Next

                ' If no results were found, show a message box
                If Not found Then
                    MessageBox.Show("No matching passenger found in the dictionary.")
                Else
                    ' Show dropdown if there are results
                    If cbxPassengerTicket.Items.Count > 0 Then
                        cbxPassengerTicket.DroppedDown = True
                    End If

                    ' Call Assign_Customer() if a match is found
                    Assign_Customer()

                    ' Label everything





                End If

            Catch ex As Exception
                MessageBox.Show("Search error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a valid passenger")
        End If

    End Sub

    Private Sub cbxPassengerTicket_TextChanged(sender As Object, e As EventArgs) Handles cbxPassengerTicket.TextChanged
        Dim text As String = cbxPassengerTicket.Text
        Dim selectionStart As Integer = cbxPassengerTicket.SelectionStart

        ' Filter matches
        Dim matches = bookingDictionary.Keys.Where(Function(k) k.ToLower().Contains(text.ToLower())).ToList()

        ' Only update if there are matches
        If matches.Count > 0 Then
            ' Temporarily prevent event re-firing
            RemoveHandler cbxPassengerTicket.TextChanged, AddressOf cbxPassengerTicket_TextChanged

            cbxPassengerTicket.BeginUpdate()
            cbxPassengerTicket.Items.Clear()
            cbxPassengerTicket.Items.AddRange(matches.ToArray())
            cbxPassengerTicket.DroppedDown = True
            cbxPassengerTicket.SelectedIndex = -1
            cbxPassengerTicket.Text = text
            cbxPassengerTicket.SelectionStart = selectionStart
            cbxPassengerTicket.SelectionLength = 0
            cbxPassengerTicket.EndUpdate()

            AddHandler cbxPassengerTicket.TextChanged, AddressOf cbxPassengerTicket_TextChanged
        Else
            cbxPassengerTicket.DroppedDown = False
        End If
    End Sub
End Class