Imports MySql.Data.MySqlClient
Imports SharedModule

Public Class Form4
    Dim bookinginfo As New BookingInfo()
    Public Property tripIndicator As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnHomeUser)
        MakeTransparent(btnBookingUser)
        MakeTransparent(btnSupportUser)
        MakeTransparent(btnExit)
        MakeTransparent(btnResetUser)
        MakeTransparent(btnBookUser)
        btnHomeUser.Parent = pbxUserBooking
        btnBookingUser.Parent = pbxUserBooking
        btnSupportUser.Parent = pbxUserBooking
        btnExit.Parent = pbxUserBooking
        btnResetUser.Parent = pbxUserBooking
        btnBookUser.Parent = pbxUserBooking ' tool transparency
        hoverButton(btnHomeUser)
        hoverButton(btnBookingUser)
        hoverButton(btnSupportUser)
        hoverButton(btnExit)
        hoverButton(btnResetUser)
        hoverButton(btnBookUser) ' hover effect
        btnResetUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnResetUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)
        Me.DoubleBuffered = True
        lblCover.Visible = True ' cover for one way trip
        lblCover.BringToFront()

        ' Set default trip type
        tripIndicator = "One Way Trip"

        ' Load all destinations
        LoadAllDestinations(cbxDestinationUser)
    End Sub

    Private Sub rbnOneWayTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rbnOneWayTrip.CheckedChanged
        tripIndicator = "One Way Trip"
        lblCover.Visible = True
        lblCover.BringToFront()
    End Sub

    Private Sub rbnRoundTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rbnRoundTrip.CheckedChanged
        tripIndicator = "Round Trip"
        lblCover.Visible = False
        lblCover.SendToBack()
    End Sub

    Private Sub btnHomeUser_Click(sender As Object, e As EventArgs) Handles btnHomeUser.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub btnBookingUser_Click(sender As Object, e As EventArgs) Handles btnBookingUser.Click
        Show()
        Form3.Hide()
    End Sub

    Private Sub btnSupportUser_Click(sender As Object, e As EventArgs) Handles btnSupportUser.Click
        Dim supportForm As New cashierform.Form3
        supportForm.Show()
    End Sub

    Private Sub btnBookUser_Click(sender As Object, e As EventArgs) Handles btnBookUser.Click

        'Dim bookinginfo As BookingInfo = New BookingInfo()

        If Not ValidateForm() Then
            Return
        End If
        Dim countPassenger As Integer = 1 '1 cause the booker is one of the passengers
        Dim copassengers As New List(Of PassengerInfo)()

        For i As Integer = 1 To 6
            Try
                Dim nameCtrl = TryCast(Me.Controls.Find("tbxFullnamePassenger" & i, True).FirstOrDefault(), TextBox)
                If nameCtrl IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(nameCtrl.Text) Then
                    Dim ageCtrl = TryCast(Me.Controls.Find("tbxAgePassenger" & i, True).FirstOrDefault(), TextBox)
                    Dim birthCtrl = TryCast(Me.Controls.Find("dtpBirtDatePassenger" & i, True).FirstOrDefault(), DateTimePicker)
                    Dim genderCtrl = TryCast(Me.Controls.Find("cbxGenderPassenger" & i, True).FirstOrDefault(), ComboBox)
                    Dim seatCtrl = TryCast(Me.Controls.Find("cbxSeatNumberPassenger" & i, True).FirstOrDefault(), ComboBox)
                    Dim baggageCtrl = TryCast(Me.Controls.Find("cbxBagAllowancePassenger" & i, True).FirstOrDefault(), ComboBox)
                    Dim pwdCtrl = TryCast(Me.Controls.Find("chbPWDPassenger" & i, True).FirstOrDefault(), CheckBox)

                    Dim passengerAge As Integer = 0
                    If ageCtrl IsNot Nothing AndAlso Integer.TryParse(ageCtrl.Text, passengerAge) = False Then
                        MessageBox.Show($"Invalid age for co-passenger {i}. Please enter a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    Dim isPWD As Boolean = False
                    If pwdCtrl IsNot Nothing Then
                        isPWD = pwdCtrl.Checked
                    End If

                    copassengers.Add(New PassengerInfo With {
                        .FullName = nameCtrl.Text,
                        .Age = passengerAge,
                        .DateOfBirth = If(birthCtrl IsNot Nothing, birthCtrl.Value, DateTime.Now),
                        .Gender = If(genderCtrl IsNot Nothing, genderCtrl.Text, ""),
                        .SeatNumber = If(seatCtrl IsNot Nothing, seatCtrl.Text, ""),
                        .BaggageAllowance = If(baggageCtrl IsNot Nothing, baggageCtrl.Text, ""),
                        .IsPWD = isPWD
                    })
                    countPassenger += 1
                End If
            Catch ex As Exception
                MessageBox.Show($"Error processing passenger {i}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        Next

        bookinginfo = New BookingInfo(
            tripType:=tripIndicator,
            departure:=cbxDepartureUser.Text,
            destination:=cbxDestinationUser.Text,
            departDate:=DateTime.Parse(dtpDepartDateUser.Value.ToShortDateString() & " " & cbxDepartTimeUser.Text),
            arrivalDate:=DateTime.Parse(dtpArrivalDateUser.Value.ToShortDateString() & " " & cbxArrivalTimeUser.Text),
            bookingDate:=DateTime.Now,
            bookerFullName:=tbxFullnameUser.Text,
            bookerAge:=Integer.Parse(tbxAgeUser.Text),
            bookerBirthDate:=dtpDateBirthUser.Value,
            bookerGender:=cbxGenderUser.Text,
            bookerAddress:=tbxAddressUser.Text,
            bookerIsPWD:=chbPWDUser.Checked,
            bookerSeatNumber:=cbxSeatNumberUser.Text,
            bookerBaggageAllowance:=cbxBgAllowanceUser.Text,
            coPassengers:=copassengers,
            countPassenger:=countPassenger
)

        MessageBox.Show("Booking completed successfully for " & bookinginfo.BookerFullName & "." & vbNewLine &
               "Co-passengers: " & bookinginfo.CoPassengers.Count & vbNewLine & "Total passengers: " & countPassenger,
               "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Save booking to database
        SaveBookingToDatabase(bookinginfo)

    End Sub

    Private Function ValidateForm() As Boolean
        Dim isValid As Boolean = True
        ErrorProvider1.Clear() ' Clear any previous error indicators

        ' Validate booker information
        If String.IsNullOrWhiteSpace(tbxFullnameUser.Text) Then
            ErrorProvider1.SetError(tbxFullnameUser, "Full name is required.")
            isValid = False
        End If

        ' Validate the age input
        Dim bookerAge As Integer
        If Not Integer.TryParse(tbxAgeUser.Text, bookerAge) Then
            ErrorProvider1.SetError(tbxAgeUser, "Age must be a number.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(cbxGenderUser.Text) Then
            ErrorProvider1.SetError(cbxGenderUser, "Gender is required.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(tbxAddressUser.Text) Then
            ErrorProvider1.SetError(tbxAddressUser, "Address is required.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(cbxSeatNumberUser.Text) Then
            ErrorProvider1.SetError(cbxSeatNumberUser, "Seat number is required.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(cbxBgAllowanceUser.Text) Then
            ErrorProvider1.SetError(cbxBgAllowanceUser, "Baggage allowance is required.")
            isValid = False
        End If

        If dtpDepartDateUser.Value.Date < DateTime.Now.Date Then
            ErrorProvider1.SetError(dtpDepartDateUser, "Departure date must be today or later.")
            isValid = False
        End If

        ' Validate departure and destination
        If String.IsNullOrWhiteSpace(cbxDepartureUser.Text) Then
            ErrorProvider1.SetError(cbxDepartureUser, "Departure location is required.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(cbxDestinationUser.Text) Then
            ErrorProvider1.SetError(cbxDestinationUser, "Destination is required.")
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(cbxDepartTimeUser.Text) Then
            ErrorProvider1.SetError(cbxDepartTimeUser, "Departure time is required.")
            isValid = False
        End If

        ' For round trip, validate arrival info
        If tripIndicator = "Round Trip" Then
            If String.IsNullOrWhiteSpace(cbxArrivalTimeUser.Text) Then
                ErrorProvider1.SetError(cbxArrivalTimeUser, "Arrival time is required.")
                isValid = False
            End If

            If dtpArrivalDateUser.Value.Date < dtpDepartDateUser.Value.Date Then
                ErrorProvider1.SetError(dtpArrivalDateUser, "Arrival date must be on or after departure date.")
                isValid = False
            End If
        End If

        If dtpDepartDateUser.Value.Date < DateTime.Now.Date Then
            ErrorProvider1.SetError(dtpDepartDateUser, "Departure date must be today or later.")
            isValid = False
        End If

        If dtpDepartDateUser.Value.Date = DateTime.Now.Date Then
            ErrorProvider1.SetError(dtpDepartDateUser, "Booking for the same day is not allowed.")
            MessageBox.Show("You cannot book a trip for today. Please select a future date.", "Invalid Booking Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub SaveBookingToDatabase(booking As BookingInfo) ' save function for database
        Try
            openCon()
            Using cmd As New MySqlCommand("ALTER TABLE customer_table MODIFY customer_id INT AUTO_INCREMENT;", con)
                cmd.ExecuteNonQuery()
            End Using
            ' Insert the main booker
            Dim insertQuery As String = "
    INSERT INTO customer_table (booking_date, fullname, address, age, date_of_birth, gender, destination, departure, baggage_allowance,
    seat_number, pwd_status, booked_under, number_of_passengers, trip_type, departure_time, arrival_time)
    VALUES (@BookingDate, @FullName, @Address, @Age, @DOB, @Gender, @Destination, @Departure, @Baggage, @Seat, @PWD, @BookedUnder, @NumPassengers, @TripType, @DepartureTime, @ArrivalTime)"

            Using cmd As New MySqlCommand(insertQuery, con)
                cmd.Parameters.AddWithValue("@BookingDate", booking.BookingDate)
                cmd.Parameters.AddWithValue("@FullName", booking.BookerFullName)
                cmd.Parameters.AddWithValue("@Address", booking.BookerAddress)
                cmd.Parameters.AddWithValue("@Age", booking.BookerAge)
                cmd.Parameters.AddWithValue("@DOB", booking.BookerBirthDate)
                cmd.Parameters.AddWithValue("@Gender", booking.BookerGender)
                cmd.Parameters.AddWithValue("@Destination", booking.Destination)
                cmd.Parameters.AddWithValue("@Departure", booking.Departure)
                cmd.Parameters.AddWithValue("@Baggage", booking.BookerBaggageAllowance)
                cmd.Parameters.AddWithValue("@Seat", booking.BookerSeatNumber)
                cmd.Parameters.AddWithValue("@PWD", If(booking.BookerIsPWD, "Yes", "No"))
                cmd.Parameters.AddWithValue("@BookedUnder", booking.BookerFullName)
                cmd.Parameters.AddWithValue("@NumPassengers", booking.countPassenger)
                cmd.Parameters.AddWithValue("@TripType", booking.TripType)

                Dim departureDateTime As DateTime = booking.DepartDate
                cmd.Parameters.AddWithValue("@DepartureTime", departureDateTime.ToString("HH:mm:ss"))

                Dim arrivalDateTime As DateTime = booking.ArrivalDate
                cmd.Parameters.AddWithValue("@ArrivalTime", arrivalDateTime.ToString("HH:mm:ss"))

                cmd.ExecuteNonQuery()
            End Using

            ' Insert all co-passengers
            For Each p As PassengerInfo In booking.CoPassengers
                Using passengerCmd As New MySqlCommand(insertQuery, con)
                    passengerCmd.Parameters.AddWithValue("@BookingDate", booking.BookingDate)
                    passengerCmd.Parameters.AddWithValue("@FullName", p.FullName)
                    passengerCmd.Parameters.AddWithValue("@Address", booking.BookerAddress) ' Use booker's address for co-passengers
                    passengerCmd.Parameters.AddWithValue("@Age", p.Age)
                    passengerCmd.Parameters.AddWithValue("@DOB", p.DateOfBirth)
                    passengerCmd.Parameters.AddWithValue("@Gender", p.Gender)
                    passengerCmd.Parameters.AddWithValue("@Destination", booking.Destination)
                    passengerCmd.Parameters.AddWithValue("@Departure", booking.Departure)
                    passengerCmd.Parameters.AddWithValue("@Baggage", p.BaggageAllowance)
                    passengerCmd.Parameters.AddWithValue("@Seat", p.SeatNumber)
                    passengerCmd.Parameters.AddWithValue("@PWD", If(p.IsPWD, "Yes", "No"))
                    passengerCmd.Parameters.AddWithValue("@BookedUnder", booking.BookerFullName)
                    passengerCmd.Parameters.AddWithValue("@NumPassengers", booking.countPassenger)
                    passengerCmd.Parameters.AddWithValue("@TripType", booking.TripType)

                    Dim departureDateTime As DateTime = booking.DepartDate
                    passengerCmd.Parameters.AddWithValue("@DepartureTime", departureDateTime.ToString("HH:mm:ss"))

                    Dim arrivalDateTime As DateTime = booking.ArrivalDate
                    passengerCmd.Parameters.AddWithValue("@ArrivalTime", arrivalDateTime.ToString("HH:mm:ss"))

                    passengerCmd.ExecuteNonQuery()
                End Using
            Next

            MessageBox.Show("Booking and passengers saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Make sure to close the conection
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Private Sub btnResetUser_Click(sender As Object, e As EventArgs) Handles btnResetUser.Click ' just resets everything

        tbxFullnameUser.Clear()
        tbxAgeUser.Clear()
        tbxAddressUser.Clear()
        cbxGenderUser.SelectedIndex = -1
        cbxSeatNumberUser.SelectedIndex = -1
        cbxBgAllowanceUser.SelectedIndex = -1
        chbPWDUser.Checked = False

        cbxDepartureUser.SelectedIndex = -1
        cbxDestinationUser.SelectedIndex = -1
        cbxDepartTimeUser.SelectedIndex = -1
        cbxArrivalTimeUser.SelectedIndex = -1

        dtpDateBirthUser.Value = Date.Now
        dtpDepartDateUser.Value = DateTime.Now
        dtpArrivalDateUser.Value = DateTime.Now
        dtpBookingDateUser.Value = DateTime.Now

        rbnOneWayTrip.Checked = True

        For i As Integer = 1 To 6
            Dim nameCtrl = TryCast(Me.Controls.Find("tbxFullnamePassenger" & i, True).FirstOrDefault(), TextBox)
            If nameCtrl IsNot Nothing Then nameCtrl.Clear()

            Dim ageCtrl = TryCast(Me.Controls.Find("tbxAgePassenger" & i, True).FirstOrDefault(), TextBox)
            If ageCtrl IsNot Nothing Then ageCtrl.Clear()

            Dim birthCtrl = TryCast(Me.Controls.Find("dtpBirtDatePassenger" & i, True).FirstOrDefault(), DateTimePicker)
            If birthCtrl IsNot Nothing Then birthCtrl.Value = Date.Now

            Dim genderCtrl = TryCast(Me.Controls.Find("cbxGenderPassenger" & i, True).FirstOrDefault(), ComboBox)
            If genderCtrl IsNot Nothing Then genderCtrl.SelectedIndex = -1

            Dim seatCtrl = TryCast(Me.Controls.Find("cbxSeatNumberPassenger" & i, True).FirstOrDefault(), ComboBox)
            If seatCtrl IsNot Nothing Then seatCtrl.SelectedIndex = -1

            Dim baggageCtrl = TryCast(Me.Controls.Find("cbxBagAllowancePassenger" & i, True).FirstOrDefault(), ComboBox)
            If baggageCtrl IsNot Nothing Then baggageCtrl.SelectedIndex = -1

            Dim pwdCtrl = TryCast(Me.Controls.Find("chbPWDPassenger" & i, True).FirstOrDefault(), CheckBox)
            If pwdCtrl IsNot Nothing Then pwdCtrl.Checked = False
        Next

        MessageBox.Show("Form has been reset.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cbxDestinationUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDestinationUser.SelectedIndexChanged
        If cbxDestinationUser.SelectedItem IsNot Nothing Then
            ' Fixed: Pass the departure time combo box instead of the destination combo box
            LoadDepartureTimesForDestination(cbxDestinationUser.SelectedItem.ToString(), cbxDepartTimeUser)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitToUserForm(Me)
    End Sub
    Public Sub ExitToUserForm(currentForm As Form) ' function for exit 
        Dim result As DialogResult = MessageBox.Show("Do you want to log out?", "Exit",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            currentForm.Hide()
            Form1.Show()
        End If
    End Sub

End Class