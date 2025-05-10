
Imports MySql.Data.MySqlClient
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

        LoadAllDestinations(cbxDestination)

        Dim result = GenerateSeats(AircraftType.Boeing737_800)
        Dim seatmap = result.seatmap
        Dim capacity = result.capacity

        ' Output to console/debug window
        For Each seat As KeyValuePair(Of String, String) In seatmap
            Debug.WriteLine($"Seat: {seat.Key}, Class: {seat.Value}")
        Next

        ' Show total capacity
        MessageBox.Show("Total seats: " & capacity.ToString(), "Seatmap Test")
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
        cbxDepartureTime.Text = "2:00 PM"
        cbxArrivalTime.Text = "2:00 PM"
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
        'Clear previous passengers when booking again
        allPassengers.Clear()

        ' Clear previous error states
        ErrorProvider1.Clear()

        ' Flag to track validation status
        Dim hasError As Boolean = False

        ' === 1. Validate Main Booker Fields ===
        If String.IsNullOrWhiteSpace(tbxFullname.Text) Then
            Provide_tbxError(tbxFullname, ErrorProvider1)
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(tbxAge.Text) Then
            Provide_tbxError(tbxAge, ErrorProvider1)
            hasError = True
        ElseIf Not Integer.TryParse(tbxAge.Text, Nothing) Then
            MessageBox.Show("Main Booker Age must be a number.")
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(tbxAddress.Text) Then
            Provide_tbxError(tbxAddress, ErrorProvider1)
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(cbxGender.Text) Then
            Provide_cbxError(cbxGender, ErrorProvider1)
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(cbxBaggage.Text) Then
            Provide_cbxError(cbxBaggage, ErrorProvider1)
            hasError = True
        End If
        If Not Date.TryParse(dtpBirthdate.Text, Nothing) Then
            MessageBox.Show("Invalid birthdate format.")
            hasError = True
        End If
        If Not Date.TryParse(dtpBookingDate.Text, Nothing) Then
            MessageBox.Show("Invalid booking date format.")
            hasError = True
        End If

        ' === 2. Validate Flight Details ===
        If String.IsNullOrWhiteSpace(cbxDeparture.Text) Then
            Provide_cbxError(cbxDeparture, ErrorProvider1)
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(cbxDestination.Text) Then
            Provide_cbxError(cbxDestination, ErrorProvider1)
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(cbxSeatNumber.Text) Then
            Provide_cbxError(cbxSeatNumber, ErrorProvider1)
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(cbxDepartureTime.Text) Then
            Provide_cbxError(cbxDepartureTime, ErrorProvider1)
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(cbxArrivalTime.Text) Then
            Provide_cbxError(cbxArrivalTime, ErrorProvider1)
            hasError = True
        End If
        If Not Date.TryParse(dtpDepartDate.Text, Nothing) Then
            MessageBox.Show("Invalid departure date format.")
            hasError = True
        End If
        If Not Date.TryParse(dtpArrivalDate.Text, Nothing) Then
            MessageBox.Show("Invalid arrival date format.")
            hasError = True
        End If


        'Check for errors and exit the process if there is errors 
        If hasError Then
            MessageBox.Show("Please correct the errors before continuing.")
            Exit Sub
        End If

        ' === 3. Create Main Booker ===
        Dim mainBooker As New PassengerInfo(
            tbxFullname.Text,
            Convert.ToInt32(tbxAge.Text),
            Convert.ToDateTime(dtpBirthdate.Text),
            cbxGender.Text,
            cbxSeatNumber.Text,
            cbxBaggage.Text,
            chkPWD.Checked
        )

        ' === 4. Validate Co-Passengers ===
        Dim coPassengers As New List(Of PassengerInfo)
        Dim passengerCount As Integer = 1 ' Starts with 1 for the main booker

        For i = 1 To 5
            Dim nameBox = CType(Me.Controls($"tbxPassname{i}"), TextBox)
            Dim ageBox = CType(Me.Controls($"tbxpassAge{i}"), TextBox)
            Dim genderBox = CType(Me.Controls($"cbxpassgen{i}"), ComboBox)
            Dim dobPicker = CType(Me.Controls($"dtppassbday{i}"), DateTimePicker)
            Dim seatBox = CType(Me.Controls($"cbxpassseat{i}"), ComboBox)
            Dim bagBox = CType(Me.Controls($"cbxpassbag{i}"), ComboBox)
            Dim pwdBox = CType(Me.Controls($"chkpasspwd{i}"), CheckBox)

            Dim anyFilled = Not String.IsNullOrWhiteSpace(nameBox.Text) OrElse
                            Not String.IsNullOrWhiteSpace(ageBox.Text) OrElse
                            Not String.IsNullOrWhiteSpace(genderBox.Text) OrElse
                            Not String.IsNullOrWhiteSpace(seatBox.Text) OrElse
                            Not String.IsNullOrWhiteSpace(bagBox.Text)

            If anyFilled Then
                If String.IsNullOrWhiteSpace(nameBox.Text) Then
                    Provide_tbxError(nameBox, ErrorProvider1)
                    hasError = True
                End If

                If String.IsNullOrWhiteSpace(ageBox.Text) Then
                    Provide_tbxError(ageBox, ErrorProvider1)
                    hasError = True
                ElseIf Not Integer.TryParse(ageBox.Text, Nothing) Then
                    MessageBox.Show($"Passenger #{i + 1} age must be a number.")
                    hasError = True
                End If
                If String.IsNullOrWhiteSpace(genderBox.Text) Then
                    Provide_cbxError(genderBox, ErrorProvider1)
                    hasError = True
                End If
                If String.IsNullOrWhiteSpace(seatBox.Text) Then
                    Provide_cbxError(seatBox, ErrorProvider1)
                    hasError = True
                End If
                If String.IsNullOrWhiteSpace(bagBox.Text) Then
                    Provide_cbxError(bagBox, ErrorProvider1)
                    hasError = True
                End If
                If Not Date.TryParse(dobPicker.Text, Nothing) Then
                    MessageBox.Show($"Invalid birthdate for Passenger #{i + 1}.")
                    hasError = True
                End If

                'check for errors on copassengers
                If hasError Then
                    Exit Sub
                End If

                coPassengers.Add(New PassengerInfo(
                    nameBox.Text,
                    Convert.ToInt32(ageBox.Text),
                    Convert.ToDateTime(dobPicker.Text),
                    genderBox.Text,
                    seatBox.Text,
                    bagBox.Text,
                    pwdBox.Checked
                ))

                passengerCount += 1
                Debug.WriteLine($"Added co-passenger #{i}. Total passengers: {passengerCount}")
            End If
        Next

        ' Parse combined departure date and time / combined
        Dim fullDepartureString As String = dtpDepartDate.Value.ToShortDateString() & " " & cbxDepartureTime.Text
        Dim parsedDepartureDate As DateTime
        If Not DateTime.TryParse(fullDepartureString, parsedDepartureDate) Then
            MessageBox.Show("Invalid departure date or time format.")
            Exit Sub
        End If

        ' Parse combined arrival date and time
        Dim fullArrivalString As String = dtpArrivalDate.Value.ToShortDateString() & " " & cbxArrivalTime.Text
        Dim parsedArrivalDate As DateTime
        If Not DateTime.TryParse(fullArrivalString, parsedArrivalDate) Then
            MessageBox.Show("Invalid arrival date or time format.")
            Exit Sub
        End If

        ' === 5. Store into BookingInfo ===
        Dim booking As New BookingInfo(
                tripType:=ticketIdentifier, ' Use your trip identifier here
                departure:=cbxDeparture.Text,
                destination:=cbxDestination.Text,
                departDate:=parsedDepartureDate,
                arrivalDate:=parsedArrivalDate,
                bookingDate:=Convert.ToDateTime(dtpBookingDate.Text),
                bookerFullName:=mainBooker.FullName,
                bookerAge:=mainBooker.Age,
                bookerBirthDate:=mainBooker.DateOfBirth,
                bookerGender:=mainBooker.Gender,
                bookerAddress:=tbxAddress.Text,
                bookerIsPWD:=mainBooker.IsPWD,
                bookerSeatNumber:=mainBooker.SeatNumber,
                bookerBaggageAllowance:=mainBooker.BaggageAllowance,
                countPassenger:=passengerCount,
                coPassengers:=coPassengers
            )

        ' === 6. Success Message ===
        MessageBox.Show("Booking validated and stored successfully!")

        isBooked = True

        '=== 7. Store the info to a global list ===
        CurrentBooking = booking
        AllBookings.Add(booking)

        '=== 7. Store the info to a global list ===
        CurrentBooking = booking


        '=== 8. put all bookers in allpassengers and put them into the database ===

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

        ' Add the information to the database
        Try
            openCon() ' opens con

            For Each passenger As PassengerInfo In allPassengers
                Using cmd As New MySqlCommand("
            INSERT INTO customer_table 
            (fullname, address, age, date_of_birth, gender, destination, departure, baggage_allowance, seat_number, pwd_status, 
             booked_under, number_of_passengers, trip_type, departure_time, arrival_time) 
            VALUES 
            (@fullname, @address, @age, @dob, @gender, @destination, @departure, @baggage, @seat, @pwd, 
             @bookedUnder, @numPassengers, @tripType, @departTime, @arriveTime)", con) ' <<< use con here

                    cmd.Parameters.AddWithValue("@fullname", passenger.FullName)
                    cmd.Parameters.AddWithValue("@address", tbxAddress.Text)
                    cmd.Parameters.AddWithValue("@age", passenger.Age)
                    cmd.Parameters.AddWithValue("@dob", passenger.DateOfBirth)
                    cmd.Parameters.AddWithValue("@gender", passenger.Gender)
                    cmd.Parameters.AddWithValue("@destination", cbxDestination.Text)
                    cmd.Parameters.AddWithValue("@departure", cbxDeparture.Text)
                    cmd.Parameters.AddWithValue("@baggage", passenger.BaggageAllowance)
                    cmd.Parameters.AddWithValue("@seat", passenger.SeatNumber)
                    cmd.Parameters.AddWithValue("@pwd", If(passenger.IsPWD, "Yes", "No"))
                    cmd.Parameters.AddWithValue("@bookedUnder", CurrentBooking.BookerFullName)
                    cmd.Parameters.AddWithValue("@numPassengers", passengerCount)
                    cmd.Parameters.AddWithValue("@tripType", ticketIdentifier)
                    cmd.Parameters.AddWithValue("@departTime", parsedDepartureDate)
                    cmd.Parameters.AddWithValue("@arriveTime", parsedArrivalDate)

                    cmd.ExecuteNonQuery()
                End Using
            Next

            MessageBox.Show("All passengers successfully inserted into the database.")

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' Display total
        MessageBox.Show($"Total passengers: {allPassengers.Count}")
        MessageBox.Show("Main Booker: " & CurrentBooking.BookerFullName)




        btnClear.PerformClick()


    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitToUserForm(Me)

    Private Sub cbxDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDestination.SelectedIndexChanged
        cbxDepartureTime.Text = ""

        If Not String.IsNullOrWhiteSpace(cbxDestination.Text) Then
            LoadDepartureTimesForDestination(cbxDestination.Text, cbxDepartureTime)
        End If
    End Sub

    Private Sub dtpDepartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDepartDate.ValueChanged
        If FlightsExistForDate(dtpDepartDate.Value) = False Then
            MessageBox.Show("No flights are scheduled for the selected departure date.")
        End If

    End Sub
End Class

