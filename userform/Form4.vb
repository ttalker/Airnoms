
Imports cashierform
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

        MessageBox.Show("Booking completed successfully for " & BookingInfo.BookerFullName & "." & vbNewLine &
               "Co-passengers: " & BookingInfo.CoPassengers.Count & vbNewLine & "Total passengers: " & countPassenger,
               "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Save booking to database
        SaveBookingToDatabase(BookingInfo)
    End Sub

    Private Function ValidateForm() As Boolean
        ' Validate booker information
        If String.IsNullOrWhiteSpace(tbxFullnameUser.Text) Then
            MessageBox.Show("Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim bookerAge As Integer ' Validate the age input
        If Not Integer.TryParse(tbxAgeUser.Text, bookerAge) Then
            MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cbxGenderUser.Text) Then
            MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(tbxAddressUser.Text) Then
            MessageBox.Show("Please enter an address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cbxSeatNumberUser.Text) Then
            MessageBox.Show("Please select a seat number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cbxBgAllowanceUser.Text) Then
            MessageBox.Show("Please select a baggage allowance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If dtpDepartDateUser.Value.Date < DateTime.Now.Date Then
            MessageBox.Show("Departure date must be today or later.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validate departure and destination
        If String.IsNullOrWhiteSpace(cbxDepartureUser.Text) Then
            MessageBox.Show("Please select a departure location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cbxDestinationUser.Text) Then
            MessageBox.Show("Please select a destination.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cbxDepartTimeUser.Text) Then
            MessageBox.Show("Please select a departure time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' For round trip, validate arrival info
        If tripIndicator = "Round Trip" Then
            If String.IsNullOrWhiteSpace(cbxArrivalTimeUser.Text) Then
                MessageBox.Show("Please select an arrival time for round trip.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If dtpArrivalDateUser.Value.Date < dtpDepartDateUser.Value.Date Then
                MessageBox.Show("Arrival date must be on or after departure date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub SaveBookingToDatabase(booking As BookingInfo) ' save function for database
        Try
            openConTesting()
            Using cmd2 As New MySqlCommand("ALTER TABLE testing_table_customer MODIFY customer_id INT AUTO_INCREMENT;", conn)
                cmd2.ExecuteNonQuery()
            End Using
            ' Insert the main booker
            Dim insertQuery As String = "
    INSERT INTO testing_table_customer (fullname, address, age, date_of_birth, gender, destination, departure, baggage_allowance,
    seat_number, pwd_status, booked_under, number_of_passengers, trip_type, departure_time, arrival_time)
    VALUES (@FullName, @Address, @Age, @DOB, @Gender, @Destination, @Departure, @Baggage, @Seat, @PWD, @BookedUnder, @NumPassengers, @TripType, @DepartureTime, @ArrivalTime)"

            Using cmd As New MySqlCommand(insertQuery, conn)
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
                Using passengerCmd As New MySqlCommand(insertQuery, conn)
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
            ' Make sure to close the connection
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
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
End Class