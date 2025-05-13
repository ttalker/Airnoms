Imports System.Runtime.CompilerServices
Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports SharedModule



Public Class Form2

    Private ProcessedPassengers As New HashSet(Of String)
    Private TotalFare As Decimal = 0

    Dim current_dict = bookingDictionary
    Public BaggagePrices As New Dictionary(Of String, Integer) From {
    {"10 kg", 1000},
    {"20 kg", 1800},
    {"40 kg", 3000}
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
        MakeTransparent(btnCalculate)
        btnBooking.Parent = pbxCashierTicket
        btnTicket.Parent = pbxCashierTicket
        btnSupport.Parent = pbxCashierTicket
        btnExit.Parent = pbxCashierTicket
        btnCalculate.Parent = pbxCashierTicket
        btnResetTicket.Parent = pbxCashierTicket
        btnNextTicket.Parent = pbxCashierTicket
        btnSearch.Parent = pbxCashierTicket
        btnProcessTicket.Parent = pbxCashierTicket ' transparency of the buttons
        btnCalculate.Parent = pbxCashierTicket

        hoverButton(btnBooking)
        hoverButton(btnTicket)
        hoverButton(btnSupport)
        hoverButton(btnExit)
        hoverButton(btnCalculate)
        hoverButton(btnResetTicket)
        hoverButton(btnSearch)
        hoverButton(btnProcessTicket)
        hoverButton(btnNextTicket)
        ' hover effect of the buttons

        btnNextTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnNextTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)
        btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnCalculate.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255) ' hover effect of the button next ticket and calculate
        btnProcessTicket.Enabled = False
        btnCalculate.Enabled = False

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

    Private Sub CalculateTicket()

        Dim current_booker As Customers = current_dict(cbxPassengerTicket.Text)
        Dim baseFare As Double
        Dim destination = current_booker.Destination
        Dim seatNumber = current_booker.SeatNumber
        Dim departureTime = current_booker.DepartureTime
        Dim pwdStatus = current_booker.PWDStatus
        Dim departure = current_booker.Departure
        Dim bookingDate = current_booker.BookingDate
        Dim baggage = current_booker.BaggageAllowance
        Dim plane_type = GetPlaneTypeByDestinationAndTime(destination, departureTime, bookingDate)
        'generate seatmap and confirm the seatclass
        Dim seat_map = GenerateSeats(plane_type).seatmap
        Dim class_type = seat_map(seatNumber)
        ' Get base fare depending on seat class
        If class_type.ToLower() = "business" Then
            baseFare = GetBusinessFare(departure, destination)
        ElseIf class_type.ToLower() = "economy" Then
            baseFare = GetEconomyFare(departure, destination)
        ElseIf class_type.ToLower() = "first" Then
            baseFare = GetFirstClassFare(departure, destination)
        ElseIf class_type.ToLower() = "premium economy" Then
            baseFare = GetEconomyFare(departure, destination) * 1.3 '30% increase based on economy seats
        End If

        'add fare based on baggage

        Dim baggage_price = BaggagePrices(baggage)
        baseFare += baggage_price

        ' Compute discount
        Dim discount As Double = 0
        If current_booker.PWDStatus OrElse current_booker.Age >= 60 Then
            discount = baseFare * 0.2 ' 20% discount
        End If

        'minus the discount
        baseFare -= discount

        ' Compute VAT (12%)
        Dim tax As Double = (baseFare - discount) * 0.12

        ' Compute total
        Dim totalAmount As Double = baseFare + tax

        ' Create TransactionInfo object
        CurrentTransaction = New TransactionInfo With {
            .FlightID = current_booker.FlightID,
            .BookerName = current_booker.FullName,
            .BookerID = current_booker.CustomerID,
            .SeatClass = class_type,
            .SeatNumber = seatNumber,
            .BasePrice = baseFare,
            .Discount = discount,
            .Tax = tax,
            .TotalAmount = totalAmount
        }

        Dim culturePH As New Globalization.CultureInfo("fil-PH")

        lblTicketAmt.Text = baseFare.ToString("C2", culturePH)
        lblTaxTicket.Text = tax.ToString("C2", culturePH)
        lblTotalTicket.Text = totalAmount.ToString("C2", culturePH)

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim payment As Double
        Dim total As Double
        Dim change As Double

        ' Remove currency symbols and commas for parsing
        Dim totalText = lblTotalTicket.Text.Replace("₱", "").Replace(",", "").Trim()
        Dim paymentText = tbxTicketPayment.Text.Replace("₱", "").Replace(",", "").Trim()

        If Double.TryParse(paymentText, payment) AndAlso Double.TryParse(totalText, total) Then
            If payment >= total Then
                change = payment - total
                btnProcessTicket.Enabled = True
                btnCalculate.Enabled = False
                lblChangeTicket.Text = change
                MessageBox.Show("Payment accepted. Change: ₱" & change.ToString("F2"))
            Else
                btnProcessTicket.Enabled = False
                MessageBox.Show("Insufficient payment. Please enter at least ₱" & total.ToString("F2"))
            End If
        Else
            MessageBox.Show("Invalid input. Please enter numeric values for payment and total.")
        End If

    End Sub
    Private Sub Assign_Customer()
        Dim selectedKey As String = cbxPassengerTicket.Text.Trim()

        If current_dict.ContainsKey(selectedKey) Then
            Dim current_booker As Customers = current_dict(selectedKey)

            ' Assign all the fields to a variable for easy access
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
            Dim seat_map = GenerateSeats(plane_type).seatmap
            Dim class_type = seat_map(seatNumber)

            lblClass.Text = class_type
            lblDepartDateTicket.Text = departure
            lblDepartTimeTicket.Text = departureTime
            lblArrivalDateTicket.Text = bookingDate.AddDays(1).ToShortDateString()
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
        Else
            MessageBox.Show("Selected passenger not found in dictionary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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
                    CalculateTicket()
                    btnCalculate.Enabled = True
                End If

            Catch ex As Exception
                MessageBox.Show("Search error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a valid passenger")
            btnCalculate.Enabled = False
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

    Private Sub btnProcessTicket_Click(sender As Object, e As EventArgs) Handles btnProcessTicket.Click

        Try

            openCon()

            ' Upload transaction to database
            Dim query As String = "INSERT INTO transaction_table " &
                              "(flight_id, fullname, customer_id, seat_class, seat_number, base_price, discount, tax, total_amount) " &
                              "VALUES (@flight_id, @fullname, @customer_id, @seat_class, @seat_number, @base_price, @discount, @tax, @total_amount)"
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@flight_id", CurrentTransaction.FlightID)
                cmd.Parameters.AddWithValue("@fullname", CurrentTransaction.BookerName)
                cmd.Parameters.AddWithValue("@customer_id", CurrentTransaction.BookerID)
                cmd.Parameters.AddWithValue("@seat_class", CurrentTransaction.SeatClass)
                cmd.Parameters.AddWithValue("@seat_number", CurrentTransaction.SeatNumber)
                cmd.Parameters.AddWithValue("@base_price", CurrentTransaction.BasePrice)
                cmd.Parameters.AddWithValue("@discount", CurrentTransaction.Discount)
                cmd.Parameters.AddWithValue("@tax", CurrentTransaction.Tax)
                cmd.Parameters.AddWithValue("@total_amount", CurrentTransaction.TotalAmount)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Transaction successfully recorded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error processing transaction: " & ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
            btnProcessTicket.Enabled = False
            btnCalculate.Enabled = False
        End Try

        cbxPassengerTicket.Items.Remove(cbxPassengerTicket.Text)
        ClearTicketLabels()
    End Sub

    Private Sub cbxPassengerTicket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPassengerTicket.SelectedIndexChanged
        If bookingDictionary.ContainsKey(cbxPassengerTicket.Text) Then
            Assign_Customer()
            CalculateTicket()
            btnCalculate.Enabled = True
        End If
    End Sub

    Public Sub ClearTicketLabels()
        lblClass.Text = ""
        lblDepartDateTicket.Text = ""
        lblDepartTimeTicket.Text = ""
        lblArrivalDateTicket.Text = ""
        lblArrivalTimeTicket.Text = ""
        lblBookingDateTicket.Text = ""
        lblBookedUnderTicket.Text = ""
        lblFullNameTicket.Text = ""
        lblSeatNumTicket.Text = ""
        lblDateOfBirthTicket.Text = ""
        lblDestinationTicket.Text = ""
        lblGenderTicket.Text = ""
        lblBaggageAllowanceTicket.Text = ""
        lblAdressTicket.Text = ""
        lblPWDTicket.Text = ""
        lblTicketAmt.Text = ""
        lblTaxTicket.Text = ""
        lblTotalTicket.Text = ""
        cbxPassengerTicket.Text = ""
        tbxTicketPayment.Text = ""
        lblChangeTicket.Text = ""
    End Sub

    Private Sub btnResetTicket_Click(sender As Object, e As EventArgs) Handles btnResetTicket.Click
        ClearTicketLabels()
        btnCalculate.Enabled = False
        btnProcessTicket.Enabled = False
    End Sub

    Private Sub btnNextTicket_Click(sender As Object, e As EventArgs) Handles btnNextTicket.Click

        If cbxPassengerTicket.Items.Count = 0 Then Exit Sub

        ' If nothing is selected, select the first item
        If cbxPassengerTicket.SelectedIndex = -1 Then
            cbxPassengerTicket.SelectedIndex = 0
        Else
            ' Move to the next item if available
            If cbxPassengerTicket.SelectedIndex < cbxPassengerTicket.Items.Count - 1 Then
                cbxPassengerTicket.SelectedIndex += 1
            Else
                ' Optional: loop back to first item or disable next
                MessageBox.Show("No more items to select.")
            End If
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitToUserForm(Me)
    End Sub
End Class