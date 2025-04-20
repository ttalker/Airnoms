<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblMainBooking = New Label()
        btnBooking = New Button()
        btnTicket = New Button()
        btnClear = New Button()
        btnBook = New Button()
        pnlleftInfo = New Panel()
        BTNFILL = New Button()
        lblSeatNumber = New Label()
        cbxSeatNumber = New ComboBox()
        cbxArrivalTime = New ComboBox()
        lblArrivalTime = New Label()
        cbxDepartureTime = New ComboBox()
        lblDepartureTime = New Label()
        tbxGender = New TextBox()
        Label2 = New Label()
        tbxEmail = New TextBox()
        lblEmail = New Label()
        tbxContactNumber = New TextBox()
        lblContactNumber = New Label()
        tbxPostalCode = New TextBox()
        lblPostalCode = New Label()
        tbxCity = New TextBox()
        lblCity = New Label()
        tbxAddress = New TextBox()
        lblAddress = New Label()
        tbxFullname = New TextBox()
        lblFullname = New Label()
        dtpBookingDate = New DateTimePicker()
        lblBookingDate = New Label()
        dtpArrivalDate = New DateTimePicker()
        lblArrivalDate = New Label()
        dtpDeparture = New DateTimePicker()
        lblDepartureDate = New Label()
        cbxDestination = New ComboBox()
        lblDestination = New Label()
        cbxDeparture = New ComboBox()
        lblDeparture = New Label()
        rbnRoundTrip = New RadioButton()
        rbnOneWayTrip = New RadioButton()
        gbxBookingDetails = New GroupBox()
        gbxCustomerData = New GroupBox()
        lblNumber = New Label()
        lblFullnamePassenger = New Label()
        lblSeatNumberPassengers = New Label()
        lblGenderPassenger = New Label()
        lblNumberOnePassenger = New Label()
        lblNumberTwoPassenger = New Label()
        lblNumberThreePassenger = New Label()
        Label5 = New Label()
        lblNumberFourPassenger = New Label()
        Label6 = New Label()
        lblNumberFivePassenger = New Label()
        Label7 = New Label()
        lblNumberSixPassenger = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox12 = New TextBox()
        TextBox11 = New TextBox()
        TextBox15 = New TextBox()
        TextBox14 = New TextBox()
        TextBox18 = New TextBox()
        TextBox17 = New TextBox()
        pnlRightInfo = New Panel()
        ComboBox7 = New ComboBox()
        ComboBox6 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        gbxPassengers = New GroupBox()
        btnSupport = New Button()
        pnlleftInfo.SuspendLayout()
        pnlRightInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblMainBooking
        ' 
        lblMainBooking.BackColor = SystemColors.ActiveCaption
        lblMainBooking.Location = New Point(30, 92)
        lblMainBooking.Name = "lblMainBooking"
        lblMainBooking.Size = New Size(1490, 792)
        lblMainBooking.TabIndex = 0
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(30, 17)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(194, 58)
        btnBooking.TabIndex = 1
        btnBooking.Text = "BOOKING"
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(244, 16)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(194, 58)
        btnTicket.TabIndex = 2
        btnTicket.Text = "TICKET"
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1083, 792)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(194, 58)
        btnClear.TabIndex = 5
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBook
        ' 
        btnBook.Location = New Point(1297, 792)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(194, 58)
        btnBook.TabIndex = 7
        btnBook.Text = "BOOK"
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' pnlleftInfo
        ' 
        pnlleftInfo.BackColor = Color.Snow
        pnlleftInfo.Controls.Add(BTNFILL)
        pnlleftInfo.Controls.Add(lblSeatNumber)
        pnlleftInfo.Controls.Add(cbxSeatNumber)
        pnlleftInfo.Controls.Add(cbxArrivalTime)
        pnlleftInfo.Controls.Add(lblArrivalTime)
        pnlleftInfo.Controls.Add(cbxDepartureTime)
        pnlleftInfo.Controls.Add(lblDepartureTime)
        pnlleftInfo.Controls.Add(tbxGender)
        pnlleftInfo.Controls.Add(Label2)
        pnlleftInfo.Controls.Add(tbxEmail)
        pnlleftInfo.Controls.Add(lblEmail)
        pnlleftInfo.Controls.Add(tbxContactNumber)
        pnlleftInfo.Controls.Add(lblContactNumber)
        pnlleftInfo.Controls.Add(tbxPostalCode)
        pnlleftInfo.Controls.Add(lblPostalCode)
        pnlleftInfo.Controls.Add(tbxCity)
        pnlleftInfo.Controls.Add(lblCity)
        pnlleftInfo.Controls.Add(tbxAddress)
        pnlleftInfo.Controls.Add(lblAddress)
        pnlleftInfo.Controls.Add(tbxFullname)
        pnlleftInfo.Controls.Add(lblFullname)
        pnlleftInfo.Controls.Add(dtpBookingDate)
        pnlleftInfo.Controls.Add(lblBookingDate)
        pnlleftInfo.Controls.Add(dtpArrivalDate)
        pnlleftInfo.Controls.Add(lblArrivalDate)
        pnlleftInfo.Controls.Add(dtpDeparture)
        pnlleftInfo.Controls.Add(lblDepartureDate)
        pnlleftInfo.Controls.Add(cbxDestination)
        pnlleftInfo.Controls.Add(lblDestination)
        pnlleftInfo.Controls.Add(cbxDeparture)
        pnlleftInfo.Controls.Add(lblDeparture)
        pnlleftInfo.Controls.Add(rbnRoundTrip)
        pnlleftInfo.Controls.Add(rbnOneWayTrip)
        pnlleftInfo.Controls.Add(gbxBookingDetails)
        pnlleftInfo.Controls.Add(gbxCustomerData)
        pnlleftInfo.Location = New Point(60, 122)
        pnlleftInfo.Name = "pnlleftInfo"
        pnlleftInfo.Size = New Size(744, 739)
        pnlleftInfo.TabIndex = 3
        ' 
        ' BTNFILL
        ' 
        BTNFILL.Location = New Point(594, 673)
        BTNFILL.Margin = New Padding(2)
        BTNFILL.Name = "BTNFILL"
        BTNFILL.Size = New Size(90, 27)
        BTNFILL.TabIndex = 33
        BTNFILL.Text = "FILL UP"
        BTNFILL.UseVisualStyleBackColor = True
        ' 
        ' lblSeatNumber
        ' 
        lblSeatNumber.AutoSize = True
        lblSeatNumber.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeatNumber.Location = New Point(463, 165)
        lblSeatNumber.Name = "lblSeatNumber"
        lblSeatNumber.Size = New Size(64, 25)
        lblSeatNumber.TabIndex = 32
        lblSeatNumber.Text = "Seat #"
        ' 
        ' cbxSeatNumber
        ' 
        cbxSeatNumber.FormattingEnabled = True
        cbxSeatNumber.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumber.Location = New Point(542, 166)
        cbxSeatNumber.Name = "cbxSeatNumber"
        cbxSeatNumber.Size = New Size(123, 28)
        cbxSeatNumber.TabIndex = 31
        ' 
        ' cbxArrivalTime
        ' 
        cbxArrivalTime.FormattingEnabled = True
        cbxArrivalTime.Location = New Point(460, 293)
        cbxArrivalTime.Name = "cbxArrivalTime"
        cbxArrivalTime.Size = New Size(209, 28)
        cbxArrivalTime.TabIndex = 30
        ' 
        ' lblArrivalTime
        ' 
        lblArrivalTime.AutoSize = True
        lblArrivalTime.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalTime.Location = New Point(334, 294)
        lblArrivalTime.Name = "lblArrivalTime"
        lblArrivalTime.Size = New Size(116, 25)
        lblArrivalTime.TabIndex = 29
        lblArrivalTime.Text = "Arrival Time:"
        lblArrivalTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbxDepartureTime
        ' 
        cbxDepartureTime.FormattingEnabled = True
        cbxDepartureTime.Location = New Point(460, 245)
        cbxDepartureTime.Name = "cbxDepartureTime"
        cbxDepartureTime.Size = New Size(209, 28)
        cbxDepartureTime.TabIndex = 28
        ' 
        ' lblDepartureTime
        ' 
        lblDepartureTime.AutoSize = True
        lblDepartureTime.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureTime.Location = New Point(334, 245)
        lblDepartureTime.Name = "lblDepartureTime"
        lblDepartureTime.Size = New Size(120, 25)
        lblDepartureTime.TabIndex = 27
        lblDepartureTime.Text = "Depart Time:"
        lblDepartureTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbxGender
        ' 
        tbxGender.Location = New Point(559, 518)
        tbxGender.Name = "tbxGender"
        tbxGender.Size = New Size(126, 27)
        tbxGender.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(424, 517)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 25)
        Label2.TabIndex = 25
        Label2.Text = "Gender:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbxEmail
        ' 
        tbxEmail.Location = New Point(172, 672)
        tbxEmail.Name = "tbxEmail"
        tbxEmail.Size = New Size(231, 27)
        tbxEmail.TabIndex = 24
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(50, 674)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(60, 25)
        lblEmail.TabIndex = 23
        lblEmail.Text = "Email:"
        lblEmail.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbxContactNumber
        ' 
        tbxContactNumber.Location = New Point(172, 623)
        tbxContactNumber.Name = "tbxContactNumber"
        tbxContactNumber.Size = New Size(231, 27)
        tbxContactNumber.TabIndex = 22
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContactNumber.Location = New Point(50, 625)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(96, 25)
        lblContactNumber.TabIndex = 21
        lblContactNumber.Text = "Contact #:"
        lblContactNumber.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbxPostalCode
        ' 
        tbxPostalCode.Location = New Point(559, 570)
        tbxPostalCode.Name = "tbxPostalCode"
        tbxPostalCode.Size = New Size(126, 27)
        tbxPostalCode.TabIndex = 20
        ' 
        ' lblPostalCode
        ' 
        lblPostalCode.AutoSize = True
        lblPostalCode.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPostalCode.Location = New Point(424, 569)
        lblPostalCode.Name = "lblPostalCode"
        lblPostalCode.Size = New Size(114, 25)
        lblPostalCode.TabIndex = 19
        lblPostalCode.Text = "Postal Code:"
        lblPostalCode.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbxCity
        ' 
        tbxCity.Location = New Point(172, 570)
        tbxCity.Name = "tbxCity"
        tbxCity.Size = New Size(231, 27)
        tbxCity.TabIndex = 18
        ' 
        ' lblCity
        ' 
        lblCity.AutoSize = True
        lblCity.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCity.Location = New Point(50, 569)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(48, 25)
        lblCity.TabIndex = 17
        lblCity.Text = "City:"
        lblCity.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbxAddress
        ' 
        tbxAddress.Location = New Point(172, 515)
        tbxAddress.Name = "tbxAddress"
        tbxAddress.Size = New Size(231, 27)
        tbxAddress.TabIndex = 16
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.Location = New Point(50, 517)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(83, 25)
        lblAddress.TabIndex = 15
        lblAddress.Text = "Address:"
        lblAddress.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbxFullname
        ' 
        tbxFullname.Location = New Point(172, 463)
        tbxFullname.Name = "tbxFullname"
        tbxFullname.Size = New Size(231, 27)
        tbxFullname.TabIndex = 14
        ' 
        ' lblFullname
        ' 
        lblFullname.AutoSize = True
        lblFullname.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullname.Location = New Point(50, 467)
        lblFullname.Name = "lblFullname"
        lblFullname.Size = New Size(92, 25)
        lblFullname.TabIndex = 13
        lblFullname.Text = "Fullname:"
        lblFullname.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtpBookingDate
        ' 
        dtpBookingDate.Location = New Point(181, 415)
        dtpBookingDate.Name = "dtpBookingDate"
        dtpBookingDate.Size = New Size(125, 27)
        dtpBookingDate.TabIndex = 12
        ' 
        ' lblBookingDate
        ' 
        lblBookingDate.AutoSize = True
        lblBookingDate.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookingDate.Location = New Point(50, 415)
        lblBookingDate.Name = "lblBookingDate"
        lblBookingDate.Size = New Size(129, 25)
        lblBookingDate.TabIndex = 11
        lblBookingDate.Text = "Booking Date:"
        lblBookingDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtpArrivalDate
        ' 
        dtpArrivalDate.Location = New Point(176, 296)
        dtpArrivalDate.Name = "dtpArrivalDate"
        dtpArrivalDate.Size = New Size(125, 27)
        dtpArrivalDate.TabIndex = 9
        ' 
        ' lblArrivalDate
        ' 
        lblArrivalDate.AutoSize = True
        lblArrivalDate.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalDate.Location = New Point(51, 294)
        lblArrivalDate.Name = "lblArrivalDate"
        lblArrivalDate.Size = New Size(114, 25)
        lblArrivalDate.TabIndex = 8
        lblArrivalDate.Text = "Arrival Date:"
        lblArrivalDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtpDeparture
        ' 
        dtpDeparture.Location = New Point(176, 247)
        dtpDeparture.Name = "dtpDeparture"
        dtpDeparture.Size = New Size(125, 27)
        dtpDeparture.TabIndex = 7
        ' 
        ' lblDepartureDate
        ' 
        lblDepartureDate.AutoSize = True
        lblDepartureDate.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureDate.Location = New Point(50, 245)
        lblDepartureDate.Name = "lblDepartureDate"
        lblDepartureDate.Size = New Size(118, 25)
        lblDepartureDate.TabIndex = 6
        lblDepartureDate.Text = "Depart Date:"
        lblDepartureDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbxDestination
        ' 
        cbxDestination.FormattingEnabled = True
        cbxDestination.Location = New Point(177, 192)
        cbxDestination.Name = "cbxDestination"
        cbxDestination.Size = New Size(226, 28)
        cbxDestination.TabIndex = 5
        ' 
        ' lblDestination
        ' 
        lblDestination.AutoSize = True
        lblDestination.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestination.Location = New Point(50, 190)
        lblDestination.Name = "lblDestination"
        lblDestination.Size = New Size(113, 25)
        lblDestination.TabIndex = 4
        lblDestination.Text = "Destination:"
        ' 
        ' cbxDeparture
        ' 
        cbxDeparture.FormattingEnabled = True
        cbxDeparture.Location = New Point(172, 134)
        cbxDeparture.Name = "cbxDeparture"
        cbxDeparture.Size = New Size(231, 28)
        cbxDeparture.TabIndex = 3
        ' 
        ' lblDeparture
        ' 
        lblDeparture.AutoSize = True
        lblDeparture.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeparture.Location = New Point(51, 132)
        lblDeparture.Name = "lblDeparture"
        lblDeparture.Size = New Size(102, 25)
        lblDeparture.TabIndex = 2
        lblDeparture.Text = "Departure:"
        ' 
        ' rbnRoundTrip
        ' 
        rbnRoundTrip.AutoSize = True
        rbnRoundTrip.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnRoundTrip.Location = New Point(268, 74)
        rbnRoundTrip.Name = "rbnRoundTrip"
        rbnRoundTrip.Size = New Size(125, 29)
        rbnRoundTrip.TabIndex = 1
        rbnRoundTrip.TabStop = True
        rbnRoundTrip.Text = "Round Trip"
        rbnRoundTrip.UseVisualStyleBackColor = True
        ' 
        ' rbnOneWayTrip
        ' 
        rbnOneWayTrip.AutoSize = True
        rbnOneWayTrip.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnOneWayTrip.Location = New Point(96, 74)
        rbnOneWayTrip.Name = "rbnOneWayTrip"
        rbnOneWayTrip.Size = New Size(144, 29)
        rbnOneWayTrip.TabIndex = 0
        rbnOneWayTrip.TabStop = True
        rbnOneWayTrip.Text = "One-way Trip"
        rbnOneWayTrip.UseVisualStyleBackColor = True
        ' 
        ' gbxBookingDetails
        ' 
        gbxBookingDetails.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxBookingDetails.Location = New Point(18, 10)
        gbxBookingDetails.Name = "gbxBookingDetails"
        gbxBookingDetails.Size = New Size(704, 339)
        gbxBookingDetails.TabIndex = 34
        gbxBookingDetails.TabStop = False
        gbxBookingDetails.Text = "Booking Details"
        ' 
        ' gbxCustomerData
        ' 
        gbxCustomerData.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxCustomerData.Location = New Point(22, 355)
        gbxCustomerData.Name = "gbxCustomerData"
        gbxCustomerData.Size = New Size(700, 363)
        gbxCustomerData.TabIndex = 35
        gbxCustomerData.TabStop = False
        gbxCustomerData.Text = "Customer Data"
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumber.Location = New Point(35, 93)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(41, 25)
        lblNumber.TabIndex = 3
        lblNumber.Text = "No."
        ' 
        ' lblFullnamePassenger
        ' 
        lblFullnamePassenger.AutoSize = True
        lblFullnamePassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullnamePassenger.Location = New Point(134, 93)
        lblFullnamePassenger.Name = "lblFullnamePassenger"
        lblFullnamePassenger.Size = New Size(88, 25)
        lblFullnamePassenger.TabIndex = 4
        lblFullnamePassenger.Text = "Fullname"
        ' 
        ' lblSeatNumberPassengers
        ' 
        lblSeatNumberPassengers.AutoSize = True
        lblSeatNumberPassengers.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeatNumberPassengers.Location = New Point(506, 93)
        lblSeatNumberPassengers.Name = "lblSeatNumberPassengers"
        lblSeatNumberPassengers.Size = New Size(64, 25)
        lblSeatNumberPassengers.TabIndex = 5
        lblSeatNumberPassengers.Text = "Seat #"
        ' 
        ' lblGenderPassenger
        ' 
        lblGenderPassenger.AutoSize = True
        lblGenderPassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGenderPassenger.Location = New Point(371, 93)
        lblGenderPassenger.Name = "lblGenderPassenger"
        lblGenderPassenger.Size = New Size(74, 25)
        lblGenderPassenger.TabIndex = 6
        lblGenderPassenger.Text = "Gender"
        ' 
        ' lblNumberOnePassenger
        ' 
        lblNumberOnePassenger.AutoSize = True
        lblNumberOnePassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberOnePassenger.Location = New Point(41, 155)
        lblNumberOnePassenger.Name = "lblNumberOnePassenger"
        lblNumberOnePassenger.Size = New Size(19, 25)
        lblNumberOnePassenger.TabIndex = 7
        lblNumberOnePassenger.Text = "1"
        ' 
        ' lblNumberTwoPassenger
        ' 
        lblNumberTwoPassenger.AutoSize = True
        lblNumberTwoPassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberTwoPassenger.Location = New Point(41, 230)
        lblNumberTwoPassenger.Name = "lblNumberTwoPassenger"
        lblNumberTwoPassenger.Size = New Size(22, 25)
        lblNumberTwoPassenger.TabIndex = 8
        lblNumberTwoPassenger.Text = "2"
        ' 
        ' lblNumberThreePassenger
        ' 
        lblNumberThreePassenger.AutoSize = True
        lblNumberThreePassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberThreePassenger.Location = New Point(41, 312)
        lblNumberThreePassenger.Name = "lblNumberThreePassenger"
        lblNumberThreePassenger.Size = New Size(22, 25)
        lblNumberThreePassenger.TabIndex = 9
        lblNumberThreePassenger.Text = "3"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(41, 384)
        Label5.Name = "Label5"
        Label5.Size = New Size(19, 25)
        Label5.TabIndex = 10
        Label5.Text = "1"
        ' 
        ' lblNumberFourPassenger
        ' 
        lblNumberFourPassenger.AutoSize = True
        lblNumberFourPassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberFourPassenger.Location = New Point(41, 387)
        lblNumberFourPassenger.Name = "lblNumberFourPassenger"
        lblNumberFourPassenger.Size = New Size(22, 25)
        lblNumberFourPassenger.TabIndex = 10
        lblNumberFourPassenger.Text = "4"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(41, 467)
        Label6.Name = "Label6"
        Label6.Size = New Size(19, 25)
        Label6.TabIndex = 11
        Label6.Text = "1"
        ' 
        ' lblNumberFivePassenger
        ' 
        lblNumberFivePassenger.AutoSize = True
        lblNumberFivePassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberFivePassenger.Location = New Point(41, 470)
        lblNumberFivePassenger.Name = "lblNumberFivePassenger"
        lblNumberFivePassenger.Size = New Size(22, 25)
        lblNumberFivePassenger.TabIndex = 11
        lblNumberFivePassenger.Text = "5"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(41, 559)
        Label7.Name = "Label7"
        Label7.Size = New Size(19, 25)
        Label7.TabIndex = 12
        Label7.Text = "1"
        ' 
        ' lblNumberSixPassenger
        ' 
        lblNumberSixPassenger.AutoSize = True
        lblNumberSixPassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberSixPassenger.Location = New Point(41, 562)
        lblNumberSixPassenger.Name = "lblNumberSixPassenger"
        lblNumberSixPassenger.Size = New Size(22, 25)
        lblNumberSixPassenger.TabIndex = 12
        lblNumberSixPassenger.Text = "6"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(98, 153)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(240, 27)
        TextBox1.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(363, 153)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(91, 27)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(98, 229)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(240, 27)
        TextBox6.TabIndex = 18
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(363, 229)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(91, 27)
        TextBox5.TabIndex = 19
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(98, 312)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(240, 27)
        TextBox9.TabIndex = 21
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(363, 312)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(91, 27)
        TextBox8.TabIndex = 22
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(98, 388)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(240, 27)
        TextBox12.TabIndex = 24
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(363, 388)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(91, 27)
        TextBox11.TabIndex = 25
        ' 
        ' TextBox15
        ' 
        TextBox15.Location = New Point(98, 469)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(240, 27)
        TextBox15.TabIndex = 27
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(363, 469)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(91, 27)
        TextBox14.TabIndex = 28
        ' 
        ' TextBox18
        ' 
        TextBox18.Location = New Point(98, 561)
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New Size(240, 27)
        TextBox18.TabIndex = 30
        ' 
        ' TextBox17
        ' 
        TextBox17.Location = New Point(363, 561)
        TextBox17.Name = "TextBox17"
        TextBox17.Size = New Size(91, 27)
        TextBox17.TabIndex = 31
        ' 
        ' pnlRightInfo
        ' 
        pnlRightInfo.BackColor = Color.Snow
        pnlRightInfo.Controls.Add(ComboBox7)
        pnlRightInfo.Controls.Add(ComboBox6)
        pnlRightInfo.Controls.Add(ComboBox5)
        pnlRightInfo.Controls.Add(ComboBox4)
        pnlRightInfo.Controls.Add(ComboBox3)
        pnlRightInfo.Controls.Add(ComboBox2)
        pnlRightInfo.Controls.Add(TextBox17)
        pnlRightInfo.Controls.Add(TextBox18)
        pnlRightInfo.Controls.Add(TextBox14)
        pnlRightInfo.Controls.Add(TextBox15)
        pnlRightInfo.Controls.Add(TextBox11)
        pnlRightInfo.Controls.Add(TextBox12)
        pnlRightInfo.Controls.Add(TextBox8)
        pnlRightInfo.Controls.Add(TextBox9)
        pnlRightInfo.Controls.Add(TextBox5)
        pnlRightInfo.Controls.Add(TextBox6)
        pnlRightInfo.Controls.Add(TextBox2)
        pnlRightInfo.Controls.Add(TextBox1)
        pnlRightInfo.Controls.Add(lblNumberSixPassenger)
        pnlRightInfo.Controls.Add(Label7)
        pnlRightInfo.Controls.Add(lblNumberFivePassenger)
        pnlRightInfo.Controls.Add(Label6)
        pnlRightInfo.Controls.Add(lblNumberFourPassenger)
        pnlRightInfo.Controls.Add(Label5)
        pnlRightInfo.Controls.Add(lblNumberThreePassenger)
        pnlRightInfo.Controls.Add(lblNumberTwoPassenger)
        pnlRightInfo.Controls.Add(lblNumberOnePassenger)
        pnlRightInfo.Controls.Add(lblGenderPassenger)
        pnlRightInfo.Controls.Add(lblSeatNumberPassengers)
        pnlRightInfo.Controls.Add(lblFullnamePassenger)
        pnlRightInfo.Controls.Add(lblNumber)
        pnlRightInfo.Controls.Add(gbxPassengers)
        pnlRightInfo.Location = New Point(843, 122)
        pnlRightInfo.Name = "pnlRightInfo"
        pnlRightInfo.Size = New Size(648, 642)
        pnlRightInfo.TabIndex = 4
        ' 
        ' ComboBox7
        ' 
        ComboBox7.FormattingEnabled = True
        ComboBox7.Items.AddRange(New Object() {"AC1"})
        ComboBox7.Location = New Point(481, 560)
        ComboBox7.Name = "ComboBox7"
        ComboBox7.Size = New Size(123, 28)
        ComboBox7.TabIndex = 37
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"AC1"})
        ComboBox6.Location = New Point(481, 471)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(123, 28)
        ComboBox6.TabIndex = 36
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"AC1"})
        ComboBox5.Location = New Point(481, 388)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(123, 28)
        ComboBox5.TabIndex = 35
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"AC1"})
        ComboBox4.Location = New Point(481, 313)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(123, 28)
        ComboBox4.TabIndex = 34
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"AC1"})
        ComboBox3.Location = New Point(481, 230)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(123, 28)
        ComboBox3.TabIndex = 33
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"AC1"})
        ComboBox2.Location = New Point(481, 152)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(123, 28)
        ComboBox2.TabIndex = 32
        ' 
        ' gbxPassengers
        ' 
        gbxPassengers.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxPassengers.Location = New Point(22, 13)
        gbxPassengers.Name = "gbxPassengers"
        gbxPassengers.Size = New Size(606, 610)
        gbxPassengers.TabIndex = 8
        gbxPassengers.TabStop = False
        gbxPassengers.Text = "Passengers"
        ' 
        ' btnSupport
        ' 
        btnSupport.Location = New Point(458, 17)
        btnSupport.Margin = New Padding(2)
        btnSupport.Name = "btnSupport"
        btnSupport.Size = New Size(180, 57)
        btnSupport.TabIndex = 11
        btnSupport.Text = "SUPPORT"
        btnSupport.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1545, 910)
        Controls.Add(btnSupport)
        Controls.Add(btnBook)
        Controls.Add(btnClear)
        Controls.Add(pnlRightInfo)
        Controls.Add(pnlleftInfo)
        Controls.Add(btnTicket)
        Controls.Add(btnBooking)
        Controls.Add(lblMainBooking)
        Margin = New Padding(2)
        Name = "Form1"
        Text = " CASHIER"
        pnlleftInfo.ResumeLayout(False)
        pnlleftInfo.PerformLayout()
        pnlRightInfo.ResumeLayout(False)
        pnlRightInfo.PerformLayout()
        ResumeLayout(False)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents lblMainBooking As Label
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnTicket As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents pnlleftInfo As Panel
    Friend WithEvents rbnRoundTrip As RadioButton
    Friend WithEvents rbnOneWayTrip As RadioButton
    Friend WithEvents cbxDestination As ComboBox
    Friend WithEvents lblDestination As Label
    Friend WithEvents cbxDeparture As ComboBox
    Friend WithEvents lblDeparture As Label
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents lblDepartureDate As Label
    Friend WithEvents dtpArrivalDate As DateTimePicker
    Friend WithEvents lblArrivalDate As Label
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents lblBookingDate As Label
    Friend WithEvents lblCustomerData As Label
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents tbxFullname As TextBox
    Friend WithEvents lblFullname As Label
    Friend WithEvents tbxCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents tbxContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents tbxPostalCode As TextBox
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents tbxGender As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxDepartureTime As ComboBox
    Friend WithEvents lblDepartureTime As Label
    Friend WithEvents cbxArrivalTime As ComboBox
    Friend WithEvents lblArrivalTime As Label
    Friend WithEvents cbxSeatNumber As ComboBox
    Friend WithEvents lblSeatNumber As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblFullnamePassenger As Label
    Friend WithEvents lblSeatNumberPassengers As Label
    Friend WithEvents lblGenderPassenger As Label
    Friend WithEvents lblNumberOnePassenger As Label
    Friend WithEvents lblNumberTwoPassenger As Label
    Friend WithEvents lblNumberThreePassenger As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNumberFourPassenger As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNumberFivePassenger As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNumberSixPassenger As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents pnlRightInfo As Panel
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents BTNFILL As Button
    Friend WithEvents gbxBookingDetails As GroupBox
    Friend WithEvents gbxPassengers As GroupBox
    Friend WithEvents gbxCustomerData As GroupBox
    Friend WithEvents btnSupport As Button
End Class
