Imports System.DirectoryServices.ActiveDirectory
Imports cashierform
Imports SharedModule


Public Class Form4
    Dim bookinginfo As New BookingInfo()
    Dim passengerInfo As New PassengerInfo()
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

        If String.IsNullOrWhiteSpace(tbxFullnameUser.Text) Then
            MessageBox.Show("Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bookerAge As Integer ' Validate the age input
        If Not Integer.TryParse(tbxAgeUser.Text, bookerAge) Then
            MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(cbxGenderUser.Text) Then
            MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(tbxAddressUser.Text) Then
            MessageBox.Show("Please enter an address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(cbxSeatNumberUser.Text) Then
            MessageBox.Show("Please select a seat number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(cbxBgAllowanceUser.Text) Then
            MessageBox.Show("Please select a baggage allowance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dtpDepartDateUser.Value.Date < DateTime.Now.Date Then
            MessageBox.Show("Departure date must be today or later.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Create co-passengers list
        Dim countPassenger As Integer = 1 '1 cause the booker is one of the passengers
        Dim copassengers As New List(Of PassengerInfo)()
        For i As Integer = 1 To 6
            Dim nameCtrl = Me.Controls.Find("tbxFullnamePassenger" & i, True).FirstOrDefault()
            Dim ageCtrl = Me.Controls.Find("tbxAgePassenger" & i, True).FirstOrDefault()
            Dim birthCtrl = Me.Controls.Find("dtpBirtDatePassenger" & i, True).FirstOrDefault()
            Dim genderCtrl = Me.Controls.Find("cbxGenderPassenger" & i, True).FirstOrDefault()
            Dim seatCtrl = Me.Controls.Find("cbxSeatNumberPassenger" & i, True).FirstOrDefault()
            Dim baggageCtrl = Me.Controls.Find("cbxBagAllowancePassenger" & i, True).FirstOrDefault()
            Dim pwdCtrl = Me.Controls.Find("chbPWDPassenger" & i, True).FirstOrDefault()

            If TypeOf nameCtrl Is TextBox AndAlso Not String.IsNullOrWhiteSpace(DirectCast(nameCtrl, TextBox).Text) Then
                Dim passengerAge As Integer
                If Not Integer.TryParse(DirectCast(ageCtrl, TextBox).Text, passengerAge) Then
                    MessageBox.Show("Please enter a valid age for passenger " & i, "Validation Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim passenger As New PassengerInfo With {
                .FullName = DirectCast(nameCtrl, TextBox).Text,
                .Age = passengerAge,
                .DateOfBirth = DirectCast(birthCtrl, DateTimePicker).Value,
                .Gender = DirectCast(genderCtrl, ComboBox).Text,
                .SeatNumber = DirectCast(seatCtrl, ComboBox).Text,
                .BaggageAllowance = DirectCast(baggageCtrl, ComboBox).Text,
                .IsPWD = DirectCast(pwdCtrl, CheckBox).Checked
            }

                copassengers.Add(passenger)
            End If
        Next


        bookinginfo = New BookingInfo(
        tripType:=tripIndicator,
        departure:=cbxDepartureUser.Text,
        destination:=cbxDestinationUser.Text,
        departDate:=dtpDepartDateUser.Value,
        departTime:=cbxDepartTimeUser.Text,
        arrivalDate:=dtpArrivalDateUser.Value,
        arrivalTime:=cbxArrivalTimeUser.Text,
        bookingDate:=DateTime.Now,
        bookerFullName:=tbxFullnameUser.Text,
        bookerAge:=bookerAge,
        bookerBirthDate:=dtpDateBirthUser.Value,
        bookerGender:=cbxGenderUser.Text,
        bookerAddress:=tbxAddressUser.Text,
        bookerIsPWD:=chbPWDUser.Checked,
        bookerSeatNumber:=cbxSeatNumberUser.Text,
        bookerBaggageAllowance:=cbxBgAllowanceUser.Text,
        coPassengers:=copassengers)


        MessageBox.Show("Booking completed successfully for " & bookinginfo.BookerFullName &
                   " with " & bookinginfo.CoPassengers.Count & " co-passengers.",
                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
