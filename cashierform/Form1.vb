'Imports userForm.Module1
'Imports admin.Module1
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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
            End If
        Next

        ' === 5. Store into BookingInfo ===
        Dim booking As New BookingInfo(
            tripType:=ticketIdentifier, ' Use your trip identifier here
            departure:=cbxDeparture.Text,
            destination:=cbxDestination.Text,
            departDate:=Convert.ToDateTime(dtpDepartDate.Text),
            departTime:=cbxDepartureTime.Text,
            arrivalDate:=Convert.ToDateTime(dtpArrivalDate.Text),
            arrivalTime:=cbxArrivalTime.Text,
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

        '=== 7. Store the info to a global list ===
        CurrentBooking = booking
        AllBookings.Add(booking)

    End Sub

End Class

