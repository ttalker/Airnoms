<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnBookingUser = New Button()
        btnHomeUser = New Button()
        lblMainUser = New Label()
        Panel1 = New Panel()
        lblArrivalDateUser = New Label()
        lblDepartDateUser = New Label()
        cbxDestinationUser = New ComboBox()
        lblDestinationUser = New Label()
        cbxDepartureUser = New ComboBox()
        lblDepartureUser = New Label()
        dtpArrivalDateUser = New DateTimePicker()
        dtpDepartDateUser = New DateTimePicker()
        rbnRoundTrip = New RadioButton()
        rbnOneWayTrip = New RadioButton()
        lblPicture = New Label()
        lblIniterary = New Label()
        Panel2 = New Panel()
        lblPassengerUser = New Label()
        cbxSeatNumberFourUser = New ComboBox()
        cbxSeatNumberFiveUser = New ComboBox()
        cbxSeatNumberThreeUser = New ComboBox()
        cbxSeatNumberTwoUser = New ComboBox()
        cbxSeatNumberOneUser = New ComboBox()
        tbxGenderFourUser = New TextBox()
        tbxGenderFiveUser = New TextBox()
        tbxFullnamePassengerFourUser = New TextBox()
        tbxFullnamePassengerFiveUser = New TextBox()
        tbxGenderThreeUser = New TextBox()
        tbxFullnamePassengerThreeUser = New TextBox()
        tbxGenderTwoUser = New TextBox()
        tbxFullnamePassengerTwoUser = New TextBox()
        tbxGenderOneUser = New TextBox()
        tbxFullnamePassengerOneUser = New TextBox()
        lblNumberFourPassengerUser = New Label()
        lblNumberFivePassenger = New Label()
        lblNumberThreePassengerUser = New Label()
        lblNumberTwoPassengerUser = New Label()
        lblNumberOnePassengerUser = New Label()
        lblGenderPassengerUser = New Label()
        lblSeatNumberPassengersUser = New Label()
        lblFullnamePassengerUser = New Label()
        lblNumberUser = New Label()
        Panel3 = New Panel()
        btnBookUser = New Button()
        tbxEmailUser = New TextBox()
        btnResetUser = New Button()
        Label15 = New Label()
        tbxContactUser = New TextBox()
        Label16 = New Label()
        tbxCountryUser = New TextBox()
        Label17 = New Label()
        tbxPostalCodeUser = New TextBox()
        Label14 = New Label()
        tbxCityUser = New TextBox()
        Label13 = New Label()
        tbxGenderUser = New TextBox()
        Label11 = New Label()
        tbxAddressUser = New TextBox()
        Label12 = New Label()
        Label10 = New Label()
        dtpBdayUser = New DateTimePicker()
        tbxFullnameUser = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        dtpBookingDateUser = New DateTimePicker()
        Label4 = New Label()
        cbxFlightUser = New ComboBox()
        Label18 = New Label()
        Label19 = New Label()
        cbxSeatNumberUser = New ComboBox()
        cbxDepartTimeUser = New ComboBox()
        cbxArrivalTimeUser = New ComboBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBookingUser
        ' 
        btnBookingUser.Location = New Point(241, 21)
        btnBookingUser.Name = "btnBookingUser"
        btnBookingUser.Size = New Size(194, 58)
        btnBookingUser.TabIndex = 5
        btnBookingUser.Text = "BOOKING"
        btnBookingUser.UseVisualStyleBackColor = True
        ' 
        ' btnHomeUser
        ' 
        btnHomeUser.Location = New Point(27, 22)
        btnHomeUser.Name = "btnHomeUser"
        btnHomeUser.Size = New Size(194, 58)
        btnHomeUser.TabIndex = 4
        btnHomeUser.Text = "HOME"
        btnHomeUser.UseVisualStyleBackColor = True
        ' 
        ' lblMainUser
        ' 
        lblMainUser.BackColor = SystemColors.ActiveCaption
        lblMainUser.Location = New Point(27, 97)
        lblMainUser.Name = "lblMainUser"
        lblMainUser.Size = New Size(1490, 834)
        lblMainUser.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblArrivalDateUser)
        Panel1.Controls.Add(lblDepartDateUser)
        Panel1.Controls.Add(cbxDestinationUser)
        Panel1.Controls.Add(lblDestinationUser)
        Panel1.Controls.Add(cbxDepartureUser)
        Panel1.Controls.Add(lblDepartureUser)
        Panel1.Controls.Add(dtpArrivalDateUser)
        Panel1.Controls.Add(dtpDepartDateUser)
        Panel1.Controls.Add(rbnRoundTrip)
        Panel1.Controls.Add(rbnOneWayTrip)
        Panel1.Controls.Add(lblPicture)
        Panel1.Controls.Add(lblIniterary)
        Panel1.Location = New Point(65, 120)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(814, 363)
        Panel1.TabIndex = 6
        ' 
        ' lblArrivalDateUser
        ' 
        lblArrivalDateUser.AutoSize = True
        lblArrivalDateUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalDateUser.Location = New Point(488, 299)
        lblArrivalDateUser.Name = "lblArrivalDateUser"
        lblArrivalDateUser.Size = New Size(112, 25)
        lblArrivalDateUser.TabIndex = 15
        lblArrivalDateUser.Text = "Arrival date:"
        ' 
        ' lblDepartDateUser
        ' 
        lblDepartDateUser.AutoSize = True
        lblDepartDateUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartDateUser.Location = New Point(488, 252)
        lblDepartDateUser.Name = "lblDepartDateUser"
        lblDepartDateUser.Size = New Size(116, 25)
        lblDepartDateUser.TabIndex = 14
        lblDepartDateUser.Text = "Depart date:"
        ' 
        ' cbxDestinationUser
        ' 
        cbxDestinationUser.FormattingEnabled = True
        cbxDestinationUser.Location = New Point(504, 207)
        cbxDestinationUser.Name = "cbxDestinationUser"
        cbxDestinationUser.Size = New Size(226, 28)
        cbxDestinationUser.TabIndex = 13
        ' 
        ' lblDestinationUser
        ' 
        lblDestinationUser.AutoSize = True
        lblDestinationUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestinationUser.Location = New Point(486, 166)
        lblDestinationUser.Name = "lblDestinationUser"
        lblDestinationUser.Size = New Size(113, 25)
        lblDestinationUser.TabIndex = 12
        lblDestinationUser.Text = "Destination:"
        ' 
        ' cbxDepartureUser
        ' 
        cbxDepartureUser.FormattingEnabled = True
        cbxDepartureUser.Location = New Point(504, 126)
        cbxDepartureUser.Name = "cbxDepartureUser"
        cbxDepartureUser.Size = New Size(231, 28)
        cbxDepartureUser.TabIndex = 11
        ' 
        ' lblDepartureUser
        ' 
        lblDepartureUser.AutoSize = True
        lblDepartureUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureUser.Location = New Point(486, 85)
        lblDepartureUser.Name = "lblDepartureUser"
        lblDepartureUser.Size = New Size(102, 25)
        lblDepartureUser.TabIndex = 10
        lblDepartureUser.Text = "Departure:"
        ' 
        ' dtpArrivalDateUser
        ' 
        dtpArrivalDateUser.Location = New Point(624, 299)
        dtpArrivalDateUser.Name = "dtpArrivalDateUser"
        dtpArrivalDateUser.Size = New Size(138, 27)
        dtpArrivalDateUser.TabIndex = 9
        ' 
        ' dtpDepartDateUser
        ' 
        dtpDepartDateUser.Location = New Point(624, 252)
        dtpDepartDateUser.Name = "dtpDepartDateUser"
        dtpDepartDateUser.Size = New Size(138, 27)
        dtpDepartDateUser.TabIndex = 8
        ' 
        ' rbnRoundTrip
        ' 
        rbnRoundTrip.AutoSize = True
        rbnRoundTrip.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnRoundTrip.Location = New Point(660, 41)
        rbnRoundTrip.Name = "rbnRoundTrip"
        rbnRoundTrip.Size = New Size(115, 27)
        rbnRoundTrip.TabIndex = 3
        rbnRoundTrip.TabStop = True
        rbnRoundTrip.Text = "Round Trip"
        rbnRoundTrip.UseVisualStyleBackColor = True
        ' 
        ' rbnOneWayTrip
        ' 
        rbnOneWayTrip.AutoSize = True
        rbnOneWayTrip.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnOneWayTrip.Location = New Point(504, 40)
        rbnOneWayTrip.Name = "rbnOneWayTrip"
        rbnOneWayTrip.Size = New Size(134, 27)
        rbnOneWayTrip.TabIndex = 2
        rbnOneWayTrip.TabStop = True
        rbnOneWayTrip.Text = "One-way Trip"
        rbnOneWayTrip.UseVisualStyleBackColor = True
        ' 
        ' lblPicture
        ' 
        lblPicture.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPicture.Image = My.Resources.Resources.Group_5__1_
        lblPicture.Location = New Point(-14, 60)
        lblPicture.Name = "lblPicture"
        lblPicture.Size = New Size(496, 284)
        lblPicture.TabIndex = 1
        ' 
        ' lblIniterary
        ' 
        lblIniterary.AutoSize = True
        lblIniterary.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIniterary.Location = New Point(25, 9)
        lblIniterary.Name = "lblIniterary"
        lblIniterary.Size = New Size(140, 41)
        lblIniterary.TabIndex = 0
        lblIniterary.Text = "Itinerary"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblPassengerUser)
        Panel2.Controls.Add(cbxSeatNumberFourUser)
        Panel2.Controls.Add(cbxSeatNumberFiveUser)
        Panel2.Controls.Add(cbxSeatNumberThreeUser)
        Panel2.Controls.Add(cbxSeatNumberTwoUser)
        Panel2.Controls.Add(cbxSeatNumberOneUser)
        Panel2.Controls.Add(tbxGenderFourUser)
        Panel2.Controls.Add(tbxGenderFiveUser)
        Panel2.Controls.Add(tbxFullnamePassengerFourUser)
        Panel2.Controls.Add(tbxFullnamePassengerFiveUser)
        Panel2.Controls.Add(tbxGenderThreeUser)
        Panel2.Controls.Add(tbxFullnamePassengerThreeUser)
        Panel2.Controls.Add(tbxGenderTwoUser)
        Panel2.Controls.Add(tbxFullnamePassengerTwoUser)
        Panel2.Controls.Add(tbxGenderOneUser)
        Panel2.Controls.Add(tbxFullnamePassengerOneUser)
        Panel2.Controls.Add(lblNumberFourPassengerUser)
        Panel2.Controls.Add(lblNumberFivePassenger)
        Panel2.Controls.Add(lblNumberThreePassengerUser)
        Panel2.Controls.Add(lblNumberTwoPassengerUser)
        Panel2.Controls.Add(lblNumberOnePassengerUser)
        Panel2.Controls.Add(lblGenderPassengerUser)
        Panel2.Controls.Add(lblSeatNumberPassengersUser)
        Panel2.Controls.Add(lblFullnamePassengerUser)
        Panel2.Controls.Add(lblNumberUser)
        Panel2.Location = New Point(65, 504)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(814, 405)
        Panel2.TabIndex = 7
        ' 
        ' lblPassengerUser
        ' 
        lblPassengerUser.AutoSize = True
        lblPassengerUser.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassengerUser.Location = New Point(25, 18)
        lblPassengerUser.Name = "lblPassengerUser"
        lblPassengerUser.Size = New Size(171, 41)
        lblPassengerUser.TabIndex = 16
        lblPassengerUser.Text = "Passengers"
        ' 
        ' cbxSeatNumberFourUser
        ' 
        cbxSeatNumberFourUser.FormattingEnabled = True
        cbxSeatNumberFourUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberFourUser.Location = New Point(639, 280)
        cbxSeatNumberFourUser.Name = "cbxSeatNumberFourUser"
        cbxSeatNumberFourUser.Size = New Size(123, 28)
        cbxSeatNumberFourUser.TabIndex = 55
        ' 
        ' cbxSeatNumberFiveUser
        ' 
        cbxSeatNumberFiveUser.FormattingEnabled = True
        cbxSeatNumberFiveUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberFiveUser.Location = New Point(639, 332)
        cbxSeatNumberFiveUser.Name = "cbxSeatNumberFiveUser"
        cbxSeatNumberFiveUser.Size = New Size(123, 28)
        cbxSeatNumberFiveUser.TabIndex = 55
        ' 
        ' cbxSeatNumberThreeUser
        ' 
        cbxSeatNumberThreeUser.FormattingEnabled = True
        cbxSeatNumberThreeUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberThreeUser.Location = New Point(639, 223)
        cbxSeatNumberThreeUser.Name = "cbxSeatNumberThreeUser"
        cbxSeatNumberThreeUser.Size = New Size(123, 28)
        cbxSeatNumberThreeUser.TabIndex = 54
        ' 
        ' cbxSeatNumberTwoUser
        ' 
        cbxSeatNumberTwoUser.FormattingEnabled = True
        cbxSeatNumberTwoUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberTwoUser.Location = New Point(639, 176)
        cbxSeatNumberTwoUser.Name = "cbxSeatNumberTwoUser"
        cbxSeatNumberTwoUser.Size = New Size(123, 28)
        cbxSeatNumberTwoUser.TabIndex = 53
        ' 
        ' cbxSeatNumberOneUser
        ' 
        cbxSeatNumberOneUser.FormattingEnabled = True
        cbxSeatNumberOneUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberOneUser.Location = New Point(639, 126)
        cbxSeatNumberOneUser.Name = "cbxSeatNumberOneUser"
        cbxSeatNumberOneUser.Size = New Size(123, 28)
        cbxSeatNumberOneUser.TabIndex = 52
        ' 
        ' tbxGenderFourUser
        ' 
        tbxGenderFourUser.Location = New Point(443, 280)
        tbxGenderFourUser.Name = "tbxGenderFourUser"
        tbxGenderFourUser.Size = New Size(154, 27)
        tbxGenderFourUser.TabIndex = 51
        ' 
        ' tbxGenderFiveUser
        ' 
        tbxGenderFiveUser.Location = New Point(443, 335)
        tbxGenderFiveUser.Name = "tbxGenderFiveUser"
        tbxGenderFiveUser.Size = New Size(154, 27)
        tbxGenderFiveUser.TabIndex = 51
        ' 
        ' tbxFullnamePassengerFourUser
        ' 
        tbxFullnamePassengerFourUser.Location = New Point(98, 281)
        tbxFullnamePassengerFourUser.Name = "tbxFullnamePassengerFourUser"
        tbxFullnamePassengerFourUser.Size = New Size(299, 27)
        tbxFullnamePassengerFourUser.TabIndex = 50
        ' 
        ' tbxFullnamePassengerFiveUser
        ' 
        tbxFullnamePassengerFiveUser.Location = New Point(98, 336)
        tbxFullnamePassengerFiveUser.Name = "tbxFullnamePassengerFiveUser"
        tbxFullnamePassengerFiveUser.Size = New Size(299, 27)
        tbxFullnamePassengerFiveUser.TabIndex = 50
        ' 
        ' tbxGenderThreeUser
        ' 
        tbxGenderThreeUser.Location = New Point(443, 225)
        tbxGenderThreeUser.Name = "tbxGenderThreeUser"
        tbxGenderThreeUser.Size = New Size(154, 27)
        tbxGenderThreeUser.TabIndex = 49
        ' 
        ' tbxFullnamePassengerThreeUser
        ' 
        tbxFullnamePassengerThreeUser.Location = New Point(98, 226)
        tbxFullnamePassengerThreeUser.Name = "tbxFullnamePassengerThreeUser"
        tbxFullnamePassengerThreeUser.Size = New Size(299, 27)
        tbxFullnamePassengerThreeUser.TabIndex = 48
        ' 
        ' tbxGenderTwoUser
        ' 
        tbxGenderTwoUser.Location = New Point(443, 176)
        tbxGenderTwoUser.Name = "tbxGenderTwoUser"
        tbxGenderTwoUser.Size = New Size(154, 27)
        tbxGenderTwoUser.TabIndex = 47
        ' 
        ' tbxFullnamePassengerTwoUser
        ' 
        tbxFullnamePassengerTwoUser.Location = New Point(98, 177)
        tbxFullnamePassengerTwoUser.Name = "tbxFullnamePassengerTwoUser"
        tbxFullnamePassengerTwoUser.Size = New Size(299, 27)
        tbxFullnamePassengerTwoUser.TabIndex = 46
        ' 
        ' tbxGenderOneUser
        ' 
        tbxGenderOneUser.Location = New Point(443, 126)
        tbxGenderOneUser.Name = "tbxGenderOneUser"
        tbxGenderOneUser.Size = New Size(154, 27)
        tbxGenderOneUser.TabIndex = 45
        ' 
        ' tbxFullnamePassengerOneUser
        ' 
        tbxFullnamePassengerOneUser.Location = New Point(98, 127)
        tbxFullnamePassengerOneUser.Name = "tbxFullnamePassengerOneUser"
        tbxFullnamePassengerOneUser.Size = New Size(299, 27)
        tbxFullnamePassengerOneUser.TabIndex = 44
        ' 
        ' lblNumberFourPassengerUser
        ' 
        lblNumberFourPassengerUser.AutoSize = True
        lblNumberFourPassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberFourPassengerUser.Location = New Point(41, 280)
        lblNumberFourPassengerUser.Name = "lblNumberFourPassengerUser"
        lblNumberFourPassengerUser.Size = New Size(22, 25)
        lblNumberFourPassengerUser.TabIndex = 43
        lblNumberFourPassengerUser.Text = "4"
        ' 
        ' lblNumberFivePassenger
        ' 
        lblNumberFivePassenger.AutoSize = True
        lblNumberFivePassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberFivePassenger.Location = New Point(41, 335)
        lblNumberFivePassenger.Name = "lblNumberFivePassenger"
        lblNumberFivePassenger.Size = New Size(22, 25)
        lblNumberFivePassenger.TabIndex = 43
        lblNumberFivePassenger.Text = "5"
        ' 
        ' lblNumberThreePassengerUser
        ' 
        lblNumberThreePassengerUser.AutoSize = True
        lblNumberThreePassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberThreePassengerUser.Location = New Point(41, 226)
        lblNumberThreePassengerUser.Name = "lblNumberThreePassengerUser"
        lblNumberThreePassengerUser.Size = New Size(22, 25)
        lblNumberThreePassengerUser.TabIndex = 42
        lblNumberThreePassengerUser.Text = "3"
        ' 
        ' lblNumberTwoPassengerUser
        ' 
        lblNumberTwoPassengerUser.AutoSize = True
        lblNumberTwoPassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberTwoPassengerUser.Location = New Point(41, 178)
        lblNumberTwoPassengerUser.Name = "lblNumberTwoPassengerUser"
        lblNumberTwoPassengerUser.Size = New Size(22, 25)
        lblNumberTwoPassengerUser.TabIndex = 41
        lblNumberTwoPassengerUser.Text = "2"
        ' 
        ' lblNumberOnePassengerUser
        ' 
        lblNumberOnePassengerUser.AutoSize = True
        lblNumberOnePassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberOnePassengerUser.Location = New Point(41, 129)
        lblNumberOnePassengerUser.Name = "lblNumberOnePassengerUser"
        lblNumberOnePassengerUser.Size = New Size(19, 25)
        lblNumberOnePassengerUser.TabIndex = 40
        lblNumberOnePassengerUser.Text = "1"
        ' 
        ' lblGenderPassengerUser
        ' 
        lblGenderPassengerUser.AutoSize = True
        lblGenderPassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGenderPassengerUser.Location = New Point(484, 72)
        lblGenderPassengerUser.Name = "lblGenderPassengerUser"
        lblGenderPassengerUser.Size = New Size(74, 25)
        lblGenderPassengerUser.TabIndex = 39
        lblGenderPassengerUser.Text = "Gender"
        ' 
        ' lblSeatNumberPassengersUser
        ' 
        lblSeatNumberPassengersUser.AutoSize = True
        lblSeatNumberPassengersUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeatNumberPassengersUser.Location = New Point(671, 72)
        lblSeatNumberPassengersUser.Name = "lblSeatNumberPassengersUser"
        lblSeatNumberPassengersUser.Size = New Size(64, 25)
        lblSeatNumberPassengersUser.TabIndex = 38
        lblSeatNumberPassengersUser.Text = "Seat #"
        ' 
        ' lblFullnamePassengerUser
        ' 
        lblFullnamePassengerUser.AutoSize = True
        lblFullnamePassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullnamePassengerUser.Location = New Point(191, 72)
        lblFullnamePassengerUser.Name = "lblFullnamePassengerUser"
        lblFullnamePassengerUser.Size = New Size(88, 25)
        lblFullnamePassengerUser.TabIndex = 37
        lblFullnamePassengerUser.Text = "Fullname"
        ' 
        ' lblNumberUser
        ' 
        lblNumberUser.AutoSize = True
        lblNumberUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberUser.Location = New Point(35, 72)
        lblNumberUser.Name = "lblNumberUser"
        lblNumberUser.Size = New Size(41, 25)
        lblNumberUser.TabIndex = 36
        lblNumberUser.Text = "No."
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(cbxArrivalTimeUser)
        Panel3.Controls.Add(cbxDepartTimeUser)
        Panel3.Controls.Add(Label19)
        Panel3.Controls.Add(cbxSeatNumberUser)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(cbxFlightUser)
        Panel3.Controls.Add(btnBookUser)
        Panel3.Controls.Add(tbxEmailUser)
        Panel3.Controls.Add(btnResetUser)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(tbxContactUser)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(tbxCountryUser)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(tbxPostalCodeUser)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(tbxCityUser)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(tbxGenderUser)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(tbxAddressUser)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(dtpBdayUser)
        Panel3.Controls.Add(tbxFullnameUser)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(dtpBookingDateUser)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(915, 120)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(568, 789)
        Panel3.TabIndex = 7
        ' 
        ' btnBookUser
        ' 
        btnBookUser.Location = New Point(350, 703)
        btnBookUser.Name = "btnBookUser"
        btnBookUser.Size = New Size(194, 58)
        btnBookUser.TabIndex = 9
        btnBookUser.Text = "BOOK"
        btnBookUser.UseVisualStyleBackColor = True
        ' 
        ' tbxEmailUser
        ' 
        tbxEmailUser.Location = New Point(164, 628)
        tbxEmailUser.Name = "tbxEmailUser"
        tbxEmailUser.Size = New Size(272, 27)
        tbxEmailUser.TabIndex = 76
        ' 
        ' btnResetUser
        ' 
        btnResetUser.Location = New Point(136, 704)
        btnResetUser.Name = "btnResetUser"
        btnResetUser.Size = New Size(194, 58)
        btnResetUser.TabIndex = 8
        btnResetUser.Text = "RESET"
        btnResetUser.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(92, 630)
        Label15.Name = "Label15"
        Label15.Size = New Size(60, 25)
        Label15.TabIndex = 75
        Label15.Text = "Email:"
        ' 
        ' tbxContactUser
        ' 
        tbxContactUser.Location = New Point(164, 581)
        tbxContactUser.Name = "tbxContactUser"
        tbxContactUser.Size = New Size(272, 27)
        tbxContactUser.TabIndex = 74
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(58, 583)
        Label16.Name = "Label16"
        Label16.Size = New Size(96, 25)
        Label16.TabIndex = 73
        Label16.Text = "Contact #:"
        ' 
        ' tbxCountryUser
        ' 
        tbxCountryUser.Location = New Point(164, 531)
        tbxCountryUser.Name = "tbxCountryUser"
        tbxCountryUser.Size = New Size(272, 27)
        tbxCountryUser.TabIndex = 72
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(68, 531)
        Label17.Name = "Label17"
        Label17.Size = New Size(84, 25)
        Label17.TabIndex = 71
        Label17.Text = "Country:"
        ' 
        ' tbxPostalCodeUser
        ' 
        tbxPostalCodeUser.Location = New Point(407, 477)
        tbxPostalCodeUser.Name = "tbxPostalCodeUser"
        tbxPostalCodeUser.Size = New Size(120, 27)
        tbxPostalCodeUser.TabIndex = 70
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(291, 478)
        Label14.Name = "Label14"
        Label14.Size = New Size(114, 25)
        Label14.TabIndex = 69
        Label14.Text = "Postal Code:"
        ' 
        ' tbxCityUser
        ' 
        tbxCityUser.Location = New Point(119, 479)
        tbxCityUser.Name = "tbxCityUser"
        tbxCityUser.Size = New Size(156, 27)
        tbxCityUser.TabIndex = 68
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(58, 478)
        Label13.Name = "Label13"
        Label13.Size = New Size(48, 25)
        Label13.TabIndex = 67
        Label13.Text = "City:"
        ' 
        ' tbxGenderUser
        ' 
        tbxGenderUser.Location = New Point(164, 374)
        tbxGenderUser.Name = "tbxGenderUser"
        tbxGenderUser.Size = New Size(182, 27)
        tbxGenderUser.TabIndex = 66
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(75, 375)
        Label11.Name = "Label11"
        Label11.Size = New Size(79, 25)
        Label11.TabIndex = 65
        Label11.Text = "Gender:"
        ' 
        ' tbxAddressUser
        ' 
        tbxAddressUser.Location = New Point(164, 428)
        tbxAddressUser.Name = "tbxAddressUser"
        tbxAddressUser.Size = New Size(272, 27)
        tbxAddressUser.TabIndex = 64
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(71, 427)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 25)
        Label12.TabIndex = 63
        Label12.Text = "Address:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(29, 327)
        Label10.Name = "Label10"
        Label10.Size = New Size(126, 25)
        Label10.TabIndex = 62
        Label10.Text = "Date-of-Birth:"
        ' 
        ' dtpBdayUser
        ' 
        dtpBdayUser.Location = New Point(168, 328)
        dtpBdayUser.Name = "dtpBdayUser"
        dtpBdayUser.Size = New Size(178, 27)
        dtpBdayUser.TabIndex = 61
        ' 
        ' tbxFullnameUser
        ' 
        tbxFullnameUser.Location = New Point(164, 279)
        tbxFullnameUser.Name = "tbxFullnameUser"
        tbxFullnameUser.Size = New Size(272, 27)
        tbxFullnameUser.TabIndex = 60
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(62, 279)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 25)
        Label9.TabIndex = 59
        Label9.Text = "Fullname:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(42, 229)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 25)
        Label8.TabIndex = 57
        Label8.Text = "Arrival time:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(36, 185)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 25)
        Label7.TabIndex = 18
        Label7.Text = "Depart time:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(36, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 25)
        Label6.TabIndex = 17
        Label6.Text = "Booking date:"
        ' 
        ' dtpBookingDateUser
        ' 
        dtpBookingDateUser.Location = New Point(165, 85)
        dtpBookingDateUser.Name = "dtpBookingDateUser"
        dtpBookingDateUser.Size = New Size(181, 27)
        dtpBookingDateUser.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(34, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(227, 41)
        Label4.TabIndex = 16
        Label4.Text = "Customer Data"
        ' 
        ' cbxFlightUser
        ' 
        cbxFlightUser.FormattingEnabled = True
        cbxFlightUser.Location = New Point(112, 139)
        cbxFlightUser.Name = "cbxFlightUser"
        cbxFlightUser.Size = New Size(139, 28)
        cbxFlightUser.TabIndex = 16
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(38, 138)
        Label18.Name = "Label18"
        Label18.Size = New Size(63, 25)
        Label18.TabIndex = 77
        Label18.Text = "Flight:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(282, 139)
        Label19.Name = "Label19"
        Label19.Size = New Size(64, 25)
        Label19.TabIndex = 79
        Label19.Text = "Seat #"
        ' 
        ' cbxSeatNumberUser
        ' 
        cbxSeatNumberUser.FormattingEnabled = True
        cbxSeatNumberUser.Location = New Point(351, 139)
        cbxSeatNumberUser.Name = "cbxSeatNumberUser"
        cbxSeatNumberUser.Size = New Size(139, 28)
        cbxSeatNumberUser.TabIndex = 78
        ' 
        ' cbxDepartTimeUser
        ' 
        cbxDepartTimeUser.FormattingEnabled = True
        cbxDepartTimeUser.Location = New Point(164, 186)
        cbxDepartTimeUser.Name = "cbxDepartTimeUser"
        cbxDepartTimeUser.Size = New Size(182, 28)
        cbxDepartTimeUser.TabIndex = 80
        ' 
        ' cbxArrivalTimeUser
        ' 
        cbxArrivalTimeUser.FormattingEnabled = True
        cbxArrivalTimeUser.Location = New Point(164, 230)
        cbxArrivalTimeUser.Name = "cbxArrivalTimeUser"
        cbxArrivalTimeUser.Size = New Size(182, 28)
        cbxArrivalTimeUser.TabIndex = 81
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1545, 953)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnBookingUser)
        Controls.Add(btnHomeUser)
        Controls.Add(lblMainUser)
        MaximumSize = New Size(1563, 1000)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBookingUser As Button
    Friend WithEvents btnHomeUser As Button
    Friend WithEvents lblMainUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblIniterary As Label
    Friend WithEvents lblPicture As Label
    Friend WithEvents rbnRoundTrip As RadioButton
    Friend WithEvents rbnOneWayTrip As RadioButton
    Friend WithEvents dtpArrivalDateUser As DateTimePicker
    Friend WithEvents dtpDepartDateUser As DateTimePicker
    Friend WithEvents lblArrivalDateUser As Label
    Friend WithEvents lblDepartDateUser As Label
    Friend WithEvents cbxDestinationUser As ComboBox
    Friend WithEvents lblDestinationUser As Label
    Friend WithEvents cbxDepartureUser As ComboBox
    Friend WithEvents lblDepartureUser As Label
    Friend WithEvents cbxSeatNumberFourUser As ComboBox
    Friend WithEvents cbxSeatNumberFiveUser As ComboBox
    Friend WithEvents cbxSeatNumberThreeUser As ComboBox
    Friend WithEvents cbxSeatNumberTwoUser As ComboBox
    Friend WithEvents cbxSeatNumberOneUser As ComboBox
    Friend WithEvents tbxGenderFourUser As TextBox
    Friend WithEvents tbxGenderFiveUser As TextBox
    Friend WithEvents tbxFullnamePassengerFourUser As TextBox
    Friend WithEvents tbxFullnamePassengerFiveUser As TextBox
    Friend WithEvents tbxGenderThreeUser As TextBox
    Friend WithEvents tbxFullnamePassengerThreeUser As TextBox
    Friend WithEvents tbxGenderTwoUser As TextBox
    Friend WithEvents tbxFullnamePassengerTwoUser As TextBox
    Friend WithEvents tbxGenderOneUser As TextBox
    Friend WithEvents tbxFullnamePassengerOneUser As TextBox
    Friend WithEvents lblNumberFourPassengerUser As Label
    Friend WithEvents lblNumberFivePassenger As Label
    Friend WithEvents lblNumberThreePassengerUser As Label
    Friend WithEvents lblNumberTwoPassengerUser As Label
    Friend WithEvents lblNumberOnePassengerUser As Label
    Friend WithEvents lblGenderPassengerUser As Label
    Friend WithEvents lblSeatNumberPassengersUser As Label
    Friend WithEvents lblFullnamePassengerUser As Label
    Friend WithEvents lblNumberUser As Label
    Friend WithEvents lblPassengerUser As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpBookingDateUser As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxPostalCodeUser As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbxCityUser As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbxGenderUser As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbxAddressUser As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpBdayUser As DateTimePicker
    Friend WithEvents tbxFullnameUser As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBookUser As Button
    Friend WithEvents tbxEmailUser As TextBox
    Friend WithEvents btnResetUser As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents tbxContactUser As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tbxCountryUser As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cbxFlightUser As ComboBox
    Friend WithEvents cbxArrivalTimeUser As ComboBox
    Friend WithEvents cbxDepartTimeUser As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cbxSeatNumberUser As ComboBox
    Friend WithEvents Label18 As Label
End Class
