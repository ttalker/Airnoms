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
        cbxArrivalTimeUser = New ComboBox()
        cbxDepartTimeUser = New ComboBox()
        Label19 = New Label()
        cbxSeatNumberUser = New ComboBox()
        Label18 = New Label()
        cbxFlightUser = New ComboBox()
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
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBookingUser
        ' 
        btnBookingUser.Location = New Point(193, 17)
        btnBookingUser.Margin = New Padding(2, 2, 2, 2)
        btnBookingUser.Name = "btnBookingUser"
        btnBookingUser.Size = New Size(155, 46)
        btnBookingUser.TabIndex = 5
        btnBookingUser.Text = "BOOKING"
        btnBookingUser.UseVisualStyleBackColor = True
        ' 
        ' btnHomeUser
        ' 
        btnHomeUser.Location = New Point(22, 18)
        btnHomeUser.Margin = New Padding(2, 2, 2, 2)
        btnHomeUser.Name = "btnHomeUser"
        btnHomeUser.Size = New Size(155, 46)
        btnHomeUser.TabIndex = 4
        btnHomeUser.Text = "HOME"
        btnHomeUser.UseVisualStyleBackColor = True
        ' 
        ' lblMainUser
        ' 
        lblMainUser.BackColor = SystemColors.ActiveCaption
        lblMainUser.Location = New Point(22, 78)
        lblMainUser.Margin = New Padding(2, 0, 2, 0)
        lblMainUser.Name = "lblMainUser"
        lblMainUser.Size = New Size(1192, 667)
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
        Panel1.Location = New Point(52, 96)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(651, 290)
        Panel1.TabIndex = 6
        ' 
        ' lblArrivalDateUser
        ' 
        lblArrivalDateUser.AutoSize = True
        lblArrivalDateUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalDateUser.Location = New Point(390, 239)
        lblArrivalDateUser.Margin = New Padding(2, 0, 2, 0)
        lblArrivalDateUser.Name = "lblArrivalDateUser"
        lblArrivalDateUser.Size = New Size(93, 20)
        lblArrivalDateUser.TabIndex = 15
        lblArrivalDateUser.Text = "Arrival date:"
        ' 
        ' lblDepartDateUser
        ' 
        lblDepartDateUser.AutoSize = True
        lblDepartDateUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartDateUser.Location = New Point(390, 202)
        lblDepartDateUser.Margin = New Padding(2, 0, 2, 0)
        lblDepartDateUser.Name = "lblDepartDateUser"
        lblDepartDateUser.Size = New Size(94, 20)
        lblDepartDateUser.TabIndex = 14
        lblDepartDateUser.Text = "Depart date:"
        ' 
        ' cbxDestinationUser
        ' 
        cbxDestinationUser.FormattingEnabled = True
        cbxDestinationUser.Location = New Point(403, 166)
        cbxDestinationUser.Margin = New Padding(2, 2, 2, 2)
        cbxDestinationUser.Name = "cbxDestinationUser"
        cbxDestinationUser.Size = New Size(182, 23)
        cbxDestinationUser.TabIndex = 13
        ' 
        ' lblDestinationUser
        ' 
        lblDestinationUser.AutoSize = True
        lblDestinationUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestinationUser.Location = New Point(389, 133)
        lblDestinationUser.Margin = New Padding(2, 0, 2, 0)
        lblDestinationUser.Name = "lblDestinationUser"
        lblDestinationUser.Size = New Size(91, 20)
        lblDestinationUser.TabIndex = 12
        lblDestinationUser.Text = "Destination:"
        ' 
        ' cbxDepartureUser
        ' 
        cbxDepartureUser.FormattingEnabled = True
        cbxDepartureUser.Location = New Point(403, 101)
        cbxDepartureUser.Margin = New Padding(2, 2, 2, 2)
        cbxDepartureUser.Name = "cbxDepartureUser"
        cbxDepartureUser.Size = New Size(186, 23)
        cbxDepartureUser.TabIndex = 11
        ' 
        ' lblDepartureUser
        ' 
        lblDepartureUser.AutoSize = True
        lblDepartureUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureUser.Location = New Point(389, 68)
        lblDepartureUser.Margin = New Padding(2, 0, 2, 0)
        lblDepartureUser.Name = "lblDepartureUser"
        lblDepartureUser.Size = New Size(83, 20)
        lblDepartureUser.TabIndex = 10
        lblDepartureUser.Text = "Departure:"
        ' 
        ' dtpArrivalDateUser
        ' 
        dtpArrivalDateUser.Location = New Point(499, 239)
        dtpArrivalDateUser.Margin = New Padding(2, 2, 2, 2)
        dtpArrivalDateUser.Name = "dtpArrivalDateUser"
        dtpArrivalDateUser.Size = New Size(111, 23)
        dtpArrivalDateUser.TabIndex = 9
        ' 
        ' dtpDepartDateUser
        ' 
        dtpDepartDateUser.Location = New Point(499, 202)
        dtpDepartDateUser.Margin = New Padding(2, 2, 2, 2)
        dtpDepartDateUser.Name = "dtpDepartDateUser"
        dtpDepartDateUser.Size = New Size(111, 23)
        dtpDepartDateUser.TabIndex = 8
        ' 
        ' rbnRoundTrip
        ' 
        rbnRoundTrip.AutoSize = True
        rbnRoundTrip.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnRoundTrip.Location = New Point(528, 33)
        rbnRoundTrip.Margin = New Padding(2, 2, 2, 2)
        rbnRoundTrip.Name = "rbnRoundTrip"
        rbnRoundTrip.Size = New Size(96, 23)
        rbnRoundTrip.TabIndex = 3
        rbnRoundTrip.TabStop = True
        rbnRoundTrip.Text = "Round Trip"
        rbnRoundTrip.UseVisualStyleBackColor = True
        ' 
        ' rbnOneWayTrip
        ' 
        rbnOneWayTrip.AutoSize = True
        rbnOneWayTrip.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnOneWayTrip.Location = New Point(403, 32)
        rbnOneWayTrip.Margin = New Padding(2, 2, 2, 2)
        rbnOneWayTrip.Name = "rbnOneWayTrip"
        rbnOneWayTrip.Size = New Size(112, 23)
        rbnOneWayTrip.TabIndex = 2
        rbnOneWayTrip.TabStop = True
        rbnOneWayTrip.Text = "One-way Trip"
        rbnOneWayTrip.UseVisualStyleBackColor = True
        ' 
        ' lblPicture
        ' 
        lblPicture.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPicture.Image = My.Resources.Resources.Group_5__1_
        lblPicture.Location = New Point(-11, 48)
        lblPicture.Margin = New Padding(2, 0, 2, 0)
        lblPicture.Name = "lblPicture"
        lblPicture.Size = New Size(397, 227)
        lblPicture.TabIndex = 1
        ' 
        ' lblIniterary
        ' 
        lblIniterary.AutoSize = True
        lblIniterary.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIniterary.Location = New Point(20, 7)
        lblIniterary.Margin = New Padding(2, 0, 2, 0)
        lblIniterary.Name = "lblIniterary"
        lblIniterary.Size = New Size(113, 32)
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
        Panel2.Location = New Point(52, 403)
        Panel2.Margin = New Padding(2, 2, 2, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(651, 324)
        Panel2.TabIndex = 7
        ' 
        ' lblPassengerUser
        ' 
        lblPassengerUser.AutoSize = True
        lblPassengerUser.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassengerUser.Location = New Point(20, 14)
        lblPassengerUser.Margin = New Padding(2, 0, 2, 0)
        lblPassengerUser.Name = "lblPassengerUser"
        lblPassengerUser.Size = New Size(140, 32)
        lblPassengerUser.TabIndex = 16
        lblPassengerUser.Text = "Passengers"
        ' 
        ' cbxSeatNumberFourUser
        ' 
        cbxSeatNumberFourUser.FormattingEnabled = True
        cbxSeatNumberFourUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberFourUser.Location = New Point(511, 224)
        cbxSeatNumberFourUser.Margin = New Padding(2, 2, 2, 2)
        cbxSeatNumberFourUser.Name = "cbxSeatNumberFourUser"
        cbxSeatNumberFourUser.Size = New Size(99, 23)
        cbxSeatNumberFourUser.TabIndex = 55
        ' 
        ' cbxSeatNumberFiveUser
        ' 
        cbxSeatNumberFiveUser.FormattingEnabled = True
        cbxSeatNumberFiveUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberFiveUser.Location = New Point(511, 266)
        cbxSeatNumberFiveUser.Margin = New Padding(2, 2, 2, 2)
        cbxSeatNumberFiveUser.Name = "cbxSeatNumberFiveUser"
        cbxSeatNumberFiveUser.Size = New Size(99, 23)
        cbxSeatNumberFiveUser.TabIndex = 55
        ' 
        ' cbxSeatNumberThreeUser
        ' 
        cbxSeatNumberThreeUser.FormattingEnabled = True
        cbxSeatNumberThreeUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberThreeUser.Location = New Point(511, 178)
        cbxSeatNumberThreeUser.Margin = New Padding(2, 2, 2, 2)
        cbxSeatNumberThreeUser.Name = "cbxSeatNumberThreeUser"
        cbxSeatNumberThreeUser.Size = New Size(99, 23)
        cbxSeatNumberThreeUser.TabIndex = 54
        ' 
        ' cbxSeatNumberTwoUser
        ' 
        cbxSeatNumberTwoUser.FormattingEnabled = True
        cbxSeatNumberTwoUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberTwoUser.Location = New Point(511, 141)
        cbxSeatNumberTwoUser.Margin = New Padding(2, 2, 2, 2)
        cbxSeatNumberTwoUser.Name = "cbxSeatNumberTwoUser"
        cbxSeatNumberTwoUser.Size = New Size(99, 23)
        cbxSeatNumberTwoUser.TabIndex = 53
        ' 
        ' cbxSeatNumberOneUser
        ' 
        cbxSeatNumberOneUser.FormattingEnabled = True
        cbxSeatNumberOneUser.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumberOneUser.Location = New Point(511, 101)
        cbxSeatNumberOneUser.Margin = New Padding(2, 2, 2, 2)
        cbxSeatNumberOneUser.Name = "cbxSeatNumberOneUser"
        cbxSeatNumberOneUser.Size = New Size(99, 23)
        cbxSeatNumberOneUser.TabIndex = 52
        ' 
        ' tbxGenderFourUser
        ' 
        tbxGenderFourUser.Location = New Point(354, 224)
        tbxGenderFourUser.Margin = New Padding(2, 2, 2, 2)
        tbxGenderFourUser.Name = "tbxGenderFourUser"
        tbxGenderFourUser.Size = New Size(124, 23)
        tbxGenderFourUser.TabIndex = 51
        ' 
        ' tbxGenderFiveUser
        ' 
        tbxGenderFiveUser.Location = New Point(354, 268)
        tbxGenderFiveUser.Margin = New Padding(2, 2, 2, 2)
        tbxGenderFiveUser.Name = "tbxGenderFiveUser"
        tbxGenderFiveUser.Size = New Size(124, 23)
        tbxGenderFiveUser.TabIndex = 51
        ' 
        ' tbxFullnamePassengerFourUser
        ' 
        tbxFullnamePassengerFourUser.Location = New Point(78, 225)
        tbxFullnamePassengerFourUser.Margin = New Padding(2, 2, 2, 2)
        tbxFullnamePassengerFourUser.Name = "tbxFullnamePassengerFourUser"
        tbxFullnamePassengerFourUser.Size = New Size(240, 23)
        tbxFullnamePassengerFourUser.TabIndex = 50
        ' 
        ' tbxFullnamePassengerFiveUser
        ' 
        tbxFullnamePassengerFiveUser.Location = New Point(78, 269)
        tbxFullnamePassengerFiveUser.Margin = New Padding(2, 2, 2, 2)
        tbxFullnamePassengerFiveUser.Name = "tbxFullnamePassengerFiveUser"
        tbxFullnamePassengerFiveUser.Size = New Size(240, 23)
        tbxFullnamePassengerFiveUser.TabIndex = 50
        ' 
        ' tbxGenderThreeUser
        ' 
        tbxGenderThreeUser.Location = New Point(354, 180)
        tbxGenderThreeUser.Margin = New Padding(2, 2, 2, 2)
        tbxGenderThreeUser.Name = "tbxGenderThreeUser"
        tbxGenderThreeUser.Size = New Size(124, 23)
        tbxGenderThreeUser.TabIndex = 49
        ' 
        ' tbxFullnamePassengerThreeUser
        ' 
        tbxFullnamePassengerThreeUser.Location = New Point(78, 181)
        tbxFullnamePassengerThreeUser.Margin = New Padding(2, 2, 2, 2)
        tbxFullnamePassengerThreeUser.Name = "tbxFullnamePassengerThreeUser"
        tbxFullnamePassengerThreeUser.Size = New Size(240, 23)
        tbxFullnamePassengerThreeUser.TabIndex = 48
        ' 
        ' tbxGenderTwoUser
        ' 
        tbxGenderTwoUser.Location = New Point(354, 141)
        tbxGenderTwoUser.Margin = New Padding(2, 2, 2, 2)
        tbxGenderTwoUser.Name = "tbxGenderTwoUser"
        tbxGenderTwoUser.Size = New Size(124, 23)
        tbxGenderTwoUser.TabIndex = 47
        ' 
        ' tbxFullnamePassengerTwoUser
        ' 
        tbxFullnamePassengerTwoUser.Location = New Point(78, 142)
        tbxFullnamePassengerTwoUser.Margin = New Padding(2, 2, 2, 2)
        tbxFullnamePassengerTwoUser.Name = "tbxFullnamePassengerTwoUser"
        tbxFullnamePassengerTwoUser.Size = New Size(240, 23)
        tbxFullnamePassengerTwoUser.TabIndex = 46
        ' 
        ' tbxGenderOneUser
        ' 
        tbxGenderOneUser.Location = New Point(354, 101)
        tbxGenderOneUser.Margin = New Padding(2, 2, 2, 2)
        tbxGenderOneUser.Name = "tbxGenderOneUser"
        tbxGenderOneUser.Size = New Size(124, 23)
        tbxGenderOneUser.TabIndex = 45
        ' 
        ' tbxFullnamePassengerOneUser
        ' 
        tbxFullnamePassengerOneUser.Location = New Point(78, 102)
        tbxFullnamePassengerOneUser.Margin = New Padding(2, 2, 2, 2)
        tbxFullnamePassengerOneUser.Name = "tbxFullnamePassengerOneUser"
        tbxFullnamePassengerOneUser.Size = New Size(240, 23)
        tbxFullnamePassengerOneUser.TabIndex = 44
        ' 
        ' lblNumberFourPassengerUser
        ' 
        lblNumberFourPassengerUser.AutoSize = True
        lblNumberFourPassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberFourPassengerUser.Location = New Point(33, 224)
        lblNumberFourPassengerUser.Margin = New Padding(2, 0, 2, 0)
        lblNumberFourPassengerUser.Name = "lblNumberFourPassengerUser"
        lblNumberFourPassengerUser.Size = New Size(18, 20)
        lblNumberFourPassengerUser.TabIndex = 43
        lblNumberFourPassengerUser.Text = "4"
        ' 
        ' lblNumberFivePassenger
        ' 
        lblNumberFivePassenger.AutoSize = True
        lblNumberFivePassenger.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberFivePassenger.Location = New Point(33, 268)
        lblNumberFivePassenger.Margin = New Padding(2, 0, 2, 0)
        lblNumberFivePassenger.Name = "lblNumberFivePassenger"
        lblNumberFivePassenger.Size = New Size(17, 20)
        lblNumberFivePassenger.TabIndex = 43
        lblNumberFivePassenger.Text = "5"
        ' 
        ' lblNumberThreePassengerUser
        ' 
        lblNumberThreePassengerUser.AutoSize = True
        lblNumberThreePassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberThreePassengerUser.Location = New Point(33, 181)
        lblNumberThreePassengerUser.Margin = New Padding(2, 0, 2, 0)
        lblNumberThreePassengerUser.Name = "lblNumberThreePassengerUser"
        lblNumberThreePassengerUser.Size = New Size(17, 20)
        lblNumberThreePassengerUser.TabIndex = 42
        lblNumberThreePassengerUser.Text = "3"
        ' 
        ' lblNumberTwoPassengerUser
        ' 
        lblNumberTwoPassengerUser.AutoSize = True
        lblNumberTwoPassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberTwoPassengerUser.Location = New Point(33, 142)
        lblNumberTwoPassengerUser.Margin = New Padding(2, 0, 2, 0)
        lblNumberTwoPassengerUser.Name = "lblNumberTwoPassengerUser"
        lblNumberTwoPassengerUser.Size = New Size(17, 20)
        lblNumberTwoPassengerUser.TabIndex = 41
        lblNumberTwoPassengerUser.Text = "2"
        ' 
        ' lblNumberOnePassengerUser
        ' 
        lblNumberOnePassengerUser.AutoSize = True
        lblNumberOnePassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberOnePassengerUser.Location = New Point(33, 103)
        lblNumberOnePassengerUser.Margin = New Padding(2, 0, 2, 0)
        lblNumberOnePassengerUser.Name = "lblNumberOnePassengerUser"
        lblNumberOnePassengerUser.Size = New Size(15, 20)
        lblNumberOnePassengerUser.TabIndex = 40
        lblNumberOnePassengerUser.Text = "1"
        ' 
        ' lblGenderPassengerUser
        ' 
        lblGenderPassengerUser.AutoSize = True
        lblGenderPassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGenderPassengerUser.Location = New Point(387, 58)
        lblGenderPassengerUser.Margin = New Padding(2, 0, 2, 0)
        lblGenderPassengerUser.Name = "lblGenderPassengerUser"
        lblGenderPassengerUser.Size = New Size(59, 20)
        lblGenderPassengerUser.TabIndex = 39
        lblGenderPassengerUser.Text = "Gender"
        ' 
        ' lblSeatNumberPassengersUser
        ' 
        lblSeatNumberPassengersUser.AutoSize = True
        lblSeatNumberPassengersUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeatNumberPassengersUser.Location = New Point(537, 58)
        lblSeatNumberPassengersUser.Margin = New Padding(2, 0, 2, 0)
        lblSeatNumberPassengersUser.Name = "lblSeatNumberPassengersUser"
        lblSeatNumberPassengersUser.Size = New Size(51, 20)
        lblSeatNumberPassengersUser.TabIndex = 38
        lblSeatNumberPassengersUser.Text = "Seat #"
        ' 
        ' lblFullnamePassengerUser
        ' 
        lblFullnamePassengerUser.AutoSize = True
        lblFullnamePassengerUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullnamePassengerUser.Location = New Point(153, 58)
        lblFullnamePassengerUser.Margin = New Padding(2, 0, 2, 0)
        lblFullnamePassengerUser.Name = "lblFullnamePassengerUser"
        lblFullnamePassengerUser.Size = New Size(72, 20)
        lblFullnamePassengerUser.TabIndex = 37
        lblFullnamePassengerUser.Text = "Fullname"
        ' 
        ' lblNumberUser
        ' 
        lblNumberUser.AutoSize = True
        lblNumberUser.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberUser.Location = New Point(28, 58)
        lblNumberUser.Margin = New Padding(2, 0, 2, 0)
        lblNumberUser.Name = "lblNumberUser"
        lblNumberUser.Size = New Size(34, 20)
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
        Panel3.Location = New Point(732, 96)
        Panel3.Margin = New Padding(2, 2, 2, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(454, 631)
        Panel3.TabIndex = 7
        ' 
        ' cbxArrivalTimeUser
        ' 
        cbxArrivalTimeUser.FormattingEnabled = True
        cbxArrivalTimeUser.Location = New Point(131, 184)
        cbxArrivalTimeUser.Margin = New Padding(2, 2, 2, 2)
        cbxArrivalTimeUser.Name = "cbxArrivalTimeUser"
        cbxArrivalTimeUser.Size = New Size(146, 23)
        cbxArrivalTimeUser.TabIndex = 81
        ' 
        ' cbxDepartTimeUser
        ' 
        cbxDepartTimeUser.FormattingEnabled = True
        cbxDepartTimeUser.Location = New Point(131, 149)
        cbxDepartTimeUser.Margin = New Padding(2, 2, 2, 2)
        cbxDepartTimeUser.Name = "cbxDepartTimeUser"
        cbxDepartTimeUser.Size = New Size(146, 23)
        cbxDepartTimeUser.TabIndex = 80
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(226, 111)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(51, 20)
        Label19.TabIndex = 79
        Label19.Text = "Seat #"
        ' 
        ' cbxSeatNumberUser
        ' 
        cbxSeatNumberUser.FormattingEnabled = True
        cbxSeatNumberUser.Location = New Point(281, 111)
        cbxSeatNumberUser.Margin = New Padding(2, 2, 2, 2)
        cbxSeatNumberUser.Name = "cbxSeatNumberUser"
        cbxSeatNumberUser.Size = New Size(112, 23)
        cbxSeatNumberUser.TabIndex = 78
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(30, 110)
        Label18.Margin = New Padding(2, 0, 2, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(52, 20)
        Label18.TabIndex = 77
        Label18.Text = "Flight:"
        ' 
        ' cbxFlightUser
        ' 
        cbxFlightUser.FormattingEnabled = True
        cbxFlightUser.Location = New Point(90, 111)
        cbxFlightUser.Margin = New Padding(2, 2, 2, 2)
        cbxFlightUser.Name = "cbxFlightUser"
        cbxFlightUser.Size = New Size(112, 23)
        cbxFlightUser.TabIndex = 16
        ' 
        ' btnBookUser
        ' 
        btnBookUser.Location = New Point(280, 562)
        btnBookUser.Margin = New Padding(2, 2, 2, 2)
        btnBookUser.Name = "btnBookUser"
        btnBookUser.Size = New Size(155, 46)
        btnBookUser.TabIndex = 9
        btnBookUser.Text = "BOOK"
        btnBookUser.UseVisualStyleBackColor = True
        ' 
        ' tbxEmailUser
        ' 
        tbxEmailUser.Location = New Point(131, 502)
        tbxEmailUser.Margin = New Padding(2, 2, 2, 2)
        tbxEmailUser.Name = "tbxEmailUser"
        tbxEmailUser.Size = New Size(218, 23)
        tbxEmailUser.TabIndex = 76
        ' 
        ' btnResetUser
        ' 
        btnResetUser.Location = New Point(109, 563)
        btnResetUser.Margin = New Padding(2, 2, 2, 2)
        btnResetUser.Name = "btnResetUser"
        btnResetUser.Size = New Size(155, 46)
        btnResetUser.TabIndex = 8
        btnResetUser.Text = "RESET"
        btnResetUser.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(74, 504)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(50, 20)
        Label15.TabIndex = 75
        Label15.Text = "Email:"
        ' 
        ' tbxContactUser
        ' 
        tbxContactUser.Location = New Point(131, 465)
        tbxContactUser.Margin = New Padding(2, 2, 2, 2)
        tbxContactUser.Name = "tbxContactUser"
        tbxContactUser.Size = New Size(218, 23)
        tbxContactUser.TabIndex = 74
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(46, 466)
        Label16.Margin = New Padding(2, 0, 2, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(78, 20)
        Label16.TabIndex = 73
        Label16.Text = "Contact #:"
        ' 
        ' tbxCountryUser
        ' 
        tbxCountryUser.Location = New Point(131, 425)
        tbxCountryUser.Margin = New Padding(2, 2, 2, 2)
        tbxCountryUser.Name = "tbxCountryUser"
        tbxCountryUser.Size = New Size(218, 23)
        tbxCountryUser.TabIndex = 72
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(54, 425)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(69, 20)
        Label17.TabIndex = 71
        Label17.Text = "Country:"
        ' 
        ' tbxPostalCodeUser
        ' 
        tbxPostalCodeUser.Location = New Point(326, 382)
        tbxPostalCodeUser.Margin = New Padding(2, 2, 2, 2)
        tbxPostalCodeUser.Name = "tbxPostalCodeUser"
        tbxPostalCodeUser.Size = New Size(97, 23)
        tbxPostalCodeUser.TabIndex = 70
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(233, 382)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(92, 20)
        Label14.TabIndex = 69
        Label14.Text = "Postal Code:"
        ' 
        ' tbxCityUser
        ' 
        tbxCityUser.Location = New Point(95, 383)
        tbxCityUser.Margin = New Padding(2, 2, 2, 2)
        tbxCityUser.Name = "tbxCityUser"
        tbxCityUser.Size = New Size(126, 23)
        tbxCityUser.TabIndex = 68
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(46, 382)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(39, 20)
        Label13.TabIndex = 67
        Label13.Text = "City:"
        ' 
        ' tbxGenderUser
        ' 
        tbxGenderUser.Location = New Point(131, 299)
        tbxGenderUser.Margin = New Padding(2, 2, 2, 2)
        tbxGenderUser.Name = "tbxGenderUser"
        tbxGenderUser.Size = New Size(146, 23)
        tbxGenderUser.TabIndex = 66
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(60, 300)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 20)
        Label11.TabIndex = 65
        Label11.Text = "Gender:"
        ' 
        ' tbxAddressUser
        ' 
        tbxAddressUser.Location = New Point(131, 342)
        tbxAddressUser.Margin = New Padding(2, 2, 2, 2)
        tbxAddressUser.Name = "tbxAddressUser"
        tbxAddressUser.Size = New Size(218, 23)
        tbxAddressUser.TabIndex = 64
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(57, 342)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(67, 20)
        Label12.TabIndex = 63
        Label12.Text = "Address:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(23, 262)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 20)
        Label10.TabIndex = 62
        Label10.Text = "Date-of-Birth:"
        ' 
        ' dtpBdayUser
        ' 
        dtpBdayUser.Location = New Point(134, 262)
        dtpBdayUser.Margin = New Padding(2, 2, 2, 2)
        dtpBdayUser.Name = "dtpBdayUser"
        dtpBdayUser.Size = New Size(143, 23)
        dtpBdayUser.TabIndex = 61
        ' 
        ' tbxFullnameUser
        ' 
        tbxFullnameUser.Location = New Point(131, 223)
        tbxFullnameUser.Margin = New Padding(2, 2, 2, 2)
        tbxFullnameUser.Name = "tbxFullnameUser"
        tbxFullnameUser.Size = New Size(218, 23)
        tbxFullnameUser.TabIndex = 60
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(50, 223)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 20)
        Label9.TabIndex = 59
        Label9.Text = "Fullname:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(34, 183)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 20)
        Label8.TabIndex = 57
        Label8.Text = "Arrival time:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(29, 148)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 20)
        Label7.TabIndex = 18
        Label7.Text = "Depart time:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(29, 68)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 17
        Label6.Text = "Booking date:"
        ' 
        ' dtpBookingDateUser
        ' 
        dtpBookingDateUser.Location = New Point(132, 68)
        dtpBookingDateUser.Margin = New Padding(2, 2, 2, 2)
        dtpBookingDateUser.Name = "dtpBookingDateUser"
        dtpBookingDateUser.Size = New Size(146, 23)
        dtpBookingDateUser.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(27, 25)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(184, 32)
        Label4.TabIndex = 16
        Label4.Text = "Customer Data"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1236, 762)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnBookingUser)
        Controls.Add(btnHomeUser)
        Controls.Add(lblMainUser)
        Margin = New Padding(2, 2, 2, 2)
        MaximumSize = New Size(1254, 808)
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
