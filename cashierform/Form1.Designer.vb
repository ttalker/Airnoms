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
        components = New ComponentModel.Container()
        btnBooking = New Button()
        btnTicket = New Button()
        btnClear = New Button()
        btnBook = New Button()
        rbnOneWayTrip = New RadioButton()
        rbnRoundTrip = New RadioButton()
        cbxDeparture = New ComboBox()
        cbxDestination = New ComboBox()
        dtpDepartDate = New DateTimePicker()
        dtpArrivalDate = New DateTimePicker()
        dtpBookingDate = New DateTimePicker()
        tbxFullname = New TextBox()
        tbxAddress = New TextBox()
        cbxDepartureTime = New ComboBox()
        cbxArrivalTime = New ComboBox()
        cbxSeatNumber = New ComboBox()
        btnSupport = New Button()
        pbxCashierBooking = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        tbxAge = New TextBox()
        dtpBirthdate = New DateTimePicker()
        cbxGender = New ComboBox()
        chkPWD = New CheckBox()
        cbxBaggage = New ComboBox()
        cbxpassbag1 = New ComboBox()
        chkpasspwd1 = New CheckBox()
        cbxpassseat1 = New ComboBox()
        tbxPassname1 = New TextBox()
        tbxpassAge1 = New TextBox()
        dtppassbday1 = New DateTimePicker()
        cbxpassgen1 = New ComboBox()
        cbxpassgen2 = New ComboBox()
        dtppassbday2 = New DateTimePicker()
        tbxpassAge2 = New TextBox()
        tbxPassname2 = New TextBox()
        cbxpassseat2 = New ComboBox()
        chkpasspwd2 = New CheckBox()
        cbxpassbag2 = New ComboBox()
        cbxpassgen3 = New ComboBox()
        dtppassbday3 = New DateTimePicker()
        tbxpassAge3 = New TextBox()
        tbxPassname3 = New TextBox()
        cbxpassseat3 = New ComboBox()
        chkpasspwd3 = New CheckBox()
        cbxpassbag3 = New ComboBox()
        cbxpassgen4 = New ComboBox()
        dtppassbday4 = New DateTimePicker()
        tbxpassAge4 = New TextBox()
        tbxPassname4 = New TextBox()
        cbxpassseat4 = New ComboBox()
        chkpasspwd4 = New CheckBox()
        cbxpassbag4 = New ComboBox()
        cbxpassgen5 = New ComboBox()
        dtppassbday5 = New DateTimePicker()
        tbxpassAge5 = New TextBox()
        tbxPassname5 = New TextBox()
        cbxpassseat5 = New ComboBox()
        chkpasspwd5 = New CheckBox()
        cbxpassbag5 = New ComboBox()
        cbxpassgen6 = New ComboBox()
        dtppassbday6 = New DateTimePicker()
        tbxpassAge6 = New TextBox()
        tbxPassname6 = New TextBox()
        cbxpassseat6 = New ComboBox()
        chkpasspwd6 = New CheckBox()
        cbxpassbag6 = New ComboBox()
        btnExit = New Button()
        lblCoverCashier = New Label()
        CType(pbxCashierBooking, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(82, 27)
        btnBooking.Margin = New Padding(3, 2, 3, 2)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(182, 67)
        btnBooking.TabIndex = 1
        btnBooking.Text = " "
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(291, 29)
        btnTicket.Margin = New Padding(3, 2, 3, 2)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(178, 64)
        btnTicket.TabIndex = 2
        btnTicket.Text = " "
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1088, 799)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(181, 65)
        btnClear.TabIndex = 5
        btnClear.Text = " "
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBook
        ' 
        btnBook.Location = New Point(1281, 799)
        btnBook.Margin = New Padding(3, 2, 3, 2)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(188, 68)
        btnBook.TabIndex = 7
        btnBook.Text = " "
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' rbnOneWayTrip
        ' 
        rbnOneWayTrip.AutoSize = True
        rbnOneWayTrip.BackColor = Color.Transparent
        rbnOneWayTrip.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnOneWayTrip.Location = New Point(202, 240)
        rbnOneWayTrip.Margin = New Padding(3, 2, 3, 2)
        rbnOneWayTrip.Name = "rbnOneWayTrip"
        rbnOneWayTrip.Size = New Size(14, 13)
        rbnOneWayTrip.TabIndex = 0
        rbnOneWayTrip.TabStop = True
        rbnOneWayTrip.UseVisualStyleBackColor = False
        ' 
        ' rbnRoundTrip
        ' 
        rbnRoundTrip.AutoSize = True
        rbnRoundTrip.BackColor = Color.Transparent
        rbnRoundTrip.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnRoundTrip.Location = New Point(400, 240)
        rbnRoundTrip.Margin = New Padding(3, 2, 3, 2)
        rbnRoundTrip.Name = "rbnRoundTrip"
        rbnRoundTrip.Size = New Size(14, 13)
        rbnRoundTrip.TabIndex = 1
        rbnRoundTrip.TabStop = True
        rbnRoundTrip.UseVisualStyleBackColor = False
        ' 
        ' cbxDeparture
        ' 
        cbxDeparture.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxDeparture.FormattingEnabled = True
        cbxDeparture.Items.AddRange(New Object() {"Manila"})
        cbxDeparture.Location = New Point(279, 293)
        cbxDeparture.Margin = New Padding(3, 2, 3, 2)
        cbxDeparture.Name = "cbxDeparture"
        cbxDeparture.Size = New Size(203, 28)
        cbxDeparture.TabIndex = 3
        ' 
        ' cbxDestination
        ' 
        cbxDestination.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxDestination.FormattingEnabled = True
        cbxDestination.Location = New Point(279, 339)
        cbxDestination.Margin = New Padding(3, 2, 3, 2)
        cbxDestination.Name = "cbxDestination"
        cbxDestination.Size = New Size(203, 28)
        cbxDestination.TabIndex = 5
        ' 
        ' dtpDepartDate
        ' 
        dtpDepartDate.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpDepartDate.Location = New Point(279, 393)
        dtpDepartDate.Margin = New Padding(3, 2, 3, 2)
        dtpDepartDate.Name = "dtpDepartDate"
        dtpDepartDate.Size = New Size(110, 27)
        dtpDepartDate.TabIndex = 7
        ' 
        ' dtpArrivalDate
        ' 
        dtpArrivalDate.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpArrivalDate.Location = New Point(279, 435)
        dtpArrivalDate.Margin = New Padding(3, 2, 3, 2)
        dtpArrivalDate.Name = "dtpArrivalDate"
        dtpArrivalDate.Size = New Size(110, 27)
        dtpArrivalDate.TabIndex = 9
        ' 
        ' dtpBookingDate
        ' 
        dtpBookingDate.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpBookingDate.Location = New Point(646, 632)
        dtpBookingDate.Margin = New Padding(3, 2, 3, 2)
        dtpBookingDate.Name = "dtpBookingDate"
        dtpBookingDate.Size = New Size(110, 27)
        dtpBookingDate.TabIndex = 12
        ' 
        ' tbxFullname
        ' 
        tbxFullname.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxFullname.Location = New Point(275, 610)
        tbxFullname.Margin = New Padding(3, 2, 3, 2)
        tbxFullname.Name = "tbxFullname"
        tbxFullname.Size = New Size(203, 27)
        tbxFullname.TabIndex = 14
        ' 
        ' tbxAddress
        ' 
        tbxAddress.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxAddress.Location = New Point(275, 763)
        tbxAddress.Margin = New Padding(3, 2, 3, 2)
        tbxAddress.Name = "tbxAddress"
        tbxAddress.Size = New Size(203, 27)
        tbxAddress.TabIndex = 16
        ' 
        ' cbxDepartureTime
        ' 
        cbxDepartureTime.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxDepartureTime.FormattingEnabled = True
        cbxDepartureTime.Location = New Point(602, 390)
        cbxDepartureTime.Margin = New Padding(3, 2, 3, 2)
        cbxDepartureTime.Name = "cbxDepartureTime"
        cbxDepartureTime.Size = New Size(134, 28)
        cbxDepartureTime.TabIndex = 28
        ' 
        ' cbxArrivalTime
        ' 
        cbxArrivalTime.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxArrivalTime.FormattingEnabled = True
        cbxArrivalTime.Location = New Point(602, 436)
        cbxArrivalTime.Margin = New Padding(3, 2, 3, 2)
        cbxArrivalTime.Name = "cbxArrivalTime"
        cbxArrivalTime.Size = New Size(134, 28)
        cbxArrivalTime.TabIndex = 30
        ' 
        ' cbxSeatNumber
        ' 
        cbxSeatNumber.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxSeatNumber.FormattingEnabled = True
        cbxSeatNumber.Location = New Point(602, 345)
        cbxSeatNumber.Margin = New Padding(3, 2, 3, 2)
        cbxSeatNumber.Name = "cbxSeatNumber"
        cbxSeatNumber.Size = New Size(108, 28)
        cbxSeatNumber.TabIndex = 33
        ' 
        ' btnSupport
        ' 
        btnSupport.Location = New Point(494, 30)
        btnSupport.Margin = New Padding(2)
        btnSupport.Name = "btnSupport"
        btnSupport.Size = New Size(180, 63)
        btnSupport.TabIndex = 11
        btnSupport.Text = " "
        btnSupport.UseVisualStyleBackColor = True
        ' 
        ' pbxCashierBooking
        ' 
        pbxCashierBooking.BackgroundImage = My.Resources.Resources.BOOKING_ROUND_TRIP__4_
        pbxCashierBooking.Location = New Point(-2, -2)
        pbxCashierBooking.Name = "pbxCashierBooking"
        pbxCashierBooking.Size = New Size(1549, 916)
        pbxCashierBooking.TabIndex = 34
        pbxCashierBooking.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' tbxAge
        ' 
        tbxAge.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxAge.Location = New Point(275, 660)
        tbxAge.Margin = New Padding(3, 2, 3, 2)
        tbxAge.Name = "tbxAge"
        tbxAge.Size = New Size(203, 27)
        tbxAge.TabIndex = 37
        ' 
        ' dtpBirthdate
        ' 
        dtpBirthdate.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpBirthdate.Location = New Point(275, 712)
        dtpBirthdate.Margin = New Padding(3, 2, 3, 2)
        dtpBirthdate.Name = "dtpBirthdate"
        dtpBirthdate.Size = New Size(156, 27)
        dtpBirthdate.TabIndex = 38
        ' 
        ' cbxGender
        ' 
        cbxGender.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxGender.FormattingEnabled = True
        cbxGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cbxGender.Location = New Point(275, 809)
        cbxGender.Margin = New Padding(3, 2, 3, 2)
        cbxGender.Name = "cbxGender"
        cbxGender.Size = New Size(108, 28)
        cbxGender.TabIndex = 39
        ' 
        ' chkPWD
        ' 
        chkPWD.AutoSize = True
        chkPWD.Location = New Point(646, 786)
        chkPWD.Name = "chkPWD"
        chkPWD.Size = New Size(15, 14)
        chkPWD.TabIndex = 40
        chkPWD.UseVisualStyleBackColor = True
        ' 
        ' cbxBaggage
        ' 
        cbxBaggage.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxBaggage.FormattingEnabled = True
        cbxBaggage.Items.AddRange(New Object() {"10 kg", "20 kg", "40 kg"})
        cbxBaggage.Location = New Point(646, 711)
        cbxBaggage.Margin = New Padding(3, 2, 3, 2)
        cbxBaggage.Name = "cbxBaggage"
        cbxBaggage.Size = New Size(110, 28)
        cbxBaggage.TabIndex = 41
        ' 
        ' cbxpassbag1
        ' 
        cbxpassbag1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxpassbag1.FormattingEnabled = True
        cbxpassbag1.Items.AddRange(New Object() {"10 kg", "20 kg", "40 kg"})
        cbxpassbag1.Location = New Point(1338, 301)
        cbxpassbag1.Margin = New Padding(3, 2, 3, 2)
        cbxpassbag1.Name = "cbxpassbag1"
        cbxpassbag1.Size = New Size(83, 28)
        cbxpassbag1.TabIndex = 42
        ' 
        ' chkpasspwd1
        ' 
        chkpasspwd1.AutoSize = True
        chkpasspwd1.Location = New Point(1443, 305)
        chkpasspwd1.Name = "chkpasspwd1"
        chkpasspwd1.Size = New Size(15, 14)
        chkpasspwd1.TabIndex = 43
        chkpasspwd1.UseVisualStyleBackColor = True
        ' 
        ' cbxpassseat1
        ' 
        cbxpassseat1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxpassseat1.FormattingEnabled = True
        cbxpassseat1.Location = New Point(1257, 301)
        cbxpassseat1.Margin = New Padding(3, 2, 3, 2)
        cbxpassseat1.Name = "cbxpassseat1"
        cbxpassseat1.Size = New Size(64, 28)
        cbxpassseat1.TabIndex = 44
        ' 
        ' tbxPassname1
        ' 
        tbxPassname1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxPassname1.Location = New Point(842, 301)
        tbxPassname1.Margin = New Padding(3, 2, 3, 2)
        tbxPassname1.Name = "tbxPassname1"
        tbxPassname1.Size = New Size(164, 27)
        tbxPassname1.TabIndex = 45
        ' 
        ' tbxpassAge1
        ' 
        tbxpassAge1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxpassAge1.Location = New Point(1012, 301)
        tbxpassAge1.Margin = New Padding(3, 2, 3, 2)
        tbxpassAge1.Name = "tbxpassAge1"
        tbxpassAge1.Size = New Size(53, 27)
        tbxpassAge1.TabIndex = 46
        ' 
        ' dtppassbday1
        ' 
        dtppassbday1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtppassbday1.Location = New Point(1071, 301)
        dtppassbday1.Margin = New Padding(3, 2, 3, 2)
        dtppassbday1.Name = "dtppassbday1"
        dtppassbday1.Size = New Size(87, 27)
        dtppassbday1.TabIndex = 47
        ' 
        ' cbxpassgen1
        ' 
        cbxpassgen1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxpassgen1.FormattingEnabled = True
        cbxpassgen1.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cbxpassgen1.Location = New Point(1164, 301)
        cbxpassgen1.Margin = New Padding(3, 2, 3, 2)
        cbxpassgen1.Name = "cbxpassgen1"
        cbxpassgen1.Size = New Size(82, 28)
        cbxpassgen1.TabIndex = 48
        ' 
        ' cbxpassgen2
        ' 
        cbxpassgen2.Font = New Font("Segoe UI", 11.25F)
        cbxpassgen2.FormattingEnabled = True
        cbxpassgen2.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cbxpassgen2.Location = New Point(1164, 373)
        cbxpassgen2.Margin = New Padding(3, 2, 3, 2)
        cbxpassgen2.Name = "cbxpassgen2"
        cbxpassgen2.Size = New Size(82, 28)
        cbxpassgen2.TabIndex = 55
        ' 
        ' dtppassbday2
        ' 
        dtppassbday2.Font = New Font("Segoe UI", 11.25F)
        dtppassbday2.Location = New Point(1071, 373)
        dtppassbday2.Margin = New Padding(3, 2, 3, 2)
        dtppassbday2.Name = "dtppassbday2"
        dtppassbday2.Size = New Size(87, 27)
        dtppassbday2.TabIndex = 54
        ' 
        ' tbxpassAge2
        ' 
        tbxpassAge2.Font = New Font("Segoe UI", 11.25F)
        tbxpassAge2.Location = New Point(1012, 373)
        tbxpassAge2.Margin = New Padding(3, 2, 3, 2)
        tbxpassAge2.Name = "tbxpassAge2"
        tbxpassAge2.Size = New Size(53, 27)
        tbxpassAge2.TabIndex = 53
        ' 
        ' tbxPassname2
        ' 
        tbxPassname2.Font = New Font("Segoe UI", 11.25F)
        tbxPassname2.Location = New Point(842, 373)
        tbxPassname2.Margin = New Padding(3, 2, 3, 2)
        tbxPassname2.Name = "tbxPassname2"
        tbxPassname2.Size = New Size(164, 27)
        tbxPassname2.TabIndex = 52
        ' 
        ' cbxpassseat2
        ' 
        cbxpassseat2.Font = New Font("Segoe UI", 11.25F)
        cbxpassseat2.FormattingEnabled = True
        cbxpassseat2.Location = New Point(1257, 373)
        cbxpassseat2.Margin = New Padding(3, 2, 3, 2)
        cbxpassseat2.Name = "cbxpassseat2"
        cbxpassseat2.Size = New Size(64, 28)
        cbxpassseat2.TabIndex = 51
        ' 
        ' chkpasspwd2
        ' 
        chkpasspwd2.AutoSize = True
        chkpasspwd2.Location = New Point(1443, 377)
        chkpasspwd2.Name = "chkpasspwd2"
        chkpasspwd2.Size = New Size(15, 14)
        chkpasspwd2.TabIndex = 50
        chkpasspwd2.UseVisualStyleBackColor = True
        ' 
        ' cbxpassbag2
        ' 
        cbxpassbag2.Font = New Font("Segoe UI", 11.25F)
        cbxpassbag2.FormattingEnabled = True
        cbxpassbag2.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        cbxpassbag2.Location = New Point(1338, 373)
        cbxpassbag2.Margin = New Padding(3, 2, 3, 2)
        cbxpassbag2.Name = "cbxpassbag2"
        cbxpassbag2.Size = New Size(83, 28)
        cbxpassbag2.TabIndex = 49
        ' 
        ' cbxpassgen3
        ' 
        cbxpassgen3.Font = New Font("Segoe UI", 11.25F)
        cbxpassgen3.FormattingEnabled = True
        cbxpassgen3.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cbxpassgen3.Location = New Point(1164, 450)
        cbxpassgen3.Margin = New Padding(3, 2, 3, 2)
        cbxpassgen3.Name = "cbxpassgen3"
        cbxpassgen3.Size = New Size(82, 28)
        cbxpassgen3.TabIndex = 62
        ' 
        ' dtppassbday3
        ' 
        dtppassbday3.Font = New Font("Segoe UI", 11.25F)
        dtppassbday3.Location = New Point(1071, 450)
        dtppassbday3.Margin = New Padding(3, 2, 3, 2)
        dtppassbday3.Name = "dtppassbday3"
        dtppassbday3.Size = New Size(87, 27)
        dtppassbday3.TabIndex = 61
        ' 
        ' tbxpassAge3
        ' 
        tbxpassAge3.Font = New Font("Segoe UI", 11.25F)
        tbxpassAge3.Location = New Point(1012, 450)
        tbxpassAge3.Margin = New Padding(3, 2, 3, 2)
        tbxpassAge3.Name = "tbxpassAge3"
        tbxpassAge3.Size = New Size(53, 27)
        tbxpassAge3.TabIndex = 60
        ' 
        ' tbxPassname3
        ' 
        tbxPassname3.Font = New Font("Segoe UI", 11.25F)
        tbxPassname3.Location = New Point(842, 450)
        tbxPassname3.Margin = New Padding(3, 2, 3, 2)
        tbxPassname3.Name = "tbxPassname3"
        tbxPassname3.Size = New Size(164, 27)
        tbxPassname3.TabIndex = 59
        ' 
        ' cbxpassseat3
        ' 
        cbxpassseat3.Font = New Font("Segoe UI", 11.25F)
        cbxpassseat3.FormattingEnabled = True
        cbxpassseat3.Location = New Point(1257, 450)
        cbxpassseat3.Margin = New Padding(3, 2, 3, 2)
        cbxpassseat3.Name = "cbxpassseat3"
        cbxpassseat3.Size = New Size(64, 28)
        cbxpassseat3.TabIndex = 58
        ' 
        ' chkpasspwd3
        ' 
        chkpasspwd3.AutoSize = True
        chkpasspwd3.Location = New Point(1443, 454)
        chkpasspwd3.Name = "chkpasspwd3"
        chkpasspwd3.Size = New Size(15, 14)
        chkpasspwd3.TabIndex = 57
        chkpasspwd3.UseVisualStyleBackColor = True
        ' 
        ' cbxpassbag3
        ' 
        cbxpassbag3.Font = New Font("Segoe UI", 11.25F)
        cbxpassbag3.FormattingEnabled = True
        cbxpassbag3.Items.AddRange(New Object() {"10 kg", "20 kg", "40 kg"})
        cbxpassbag3.Location = New Point(1338, 450)
        cbxpassbag3.Margin = New Padding(3, 2, 3, 2)
        cbxpassbag3.Name = "cbxpassbag3"
        cbxpassbag3.Size = New Size(83, 28)
        cbxpassbag3.TabIndex = 56
        ' 
        ' cbxpassgen4
        ' 
        cbxpassgen4.Font = New Font("Segoe UI", 11.25F)
        cbxpassgen4.FormattingEnabled = True
        cbxpassgen4.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cbxpassgen4.Location = New Point(1164, 526)
        cbxpassgen4.Margin = New Padding(3, 2, 3, 2)
        cbxpassgen4.Name = "cbxpassgen4"
        cbxpassgen4.Size = New Size(82, 28)
        cbxpassgen4.TabIndex = 69
        ' 
        ' dtppassbday4
        ' 
        dtppassbday4.Font = New Font("Segoe UI", 11.25F)
        dtppassbday4.Location = New Point(1071, 526)
        dtppassbday4.Margin = New Padding(3, 2, 3, 2)
        dtppassbday4.Name = "dtppassbday4"
        dtppassbday4.Size = New Size(87, 27)
        dtppassbday4.TabIndex = 68
        ' 
        ' tbxpassAge4
        ' 
        tbxpassAge4.Font = New Font("Segoe UI", 11.25F)
        tbxpassAge4.Location = New Point(1012, 526)
        tbxpassAge4.Margin = New Padding(3, 2, 3, 2)
        tbxpassAge4.Name = "tbxpassAge4"
        tbxpassAge4.Size = New Size(53, 27)
        tbxpassAge4.TabIndex = 67
        ' 
        ' tbxPassname4
        ' 
        tbxPassname4.Font = New Font("Segoe UI", 11.25F)
        tbxPassname4.Location = New Point(842, 526)
        tbxPassname4.Margin = New Padding(3, 2, 3, 2)
        tbxPassname4.Name = "tbxPassname4"
        tbxPassname4.Size = New Size(164, 27)
        tbxPassname4.TabIndex = 66
        ' 
        ' cbxpassseat4
        ' 
        cbxpassseat4.Font = New Font("Segoe UI", 11.25F)
        cbxpassseat4.FormattingEnabled = True
        cbxpassseat4.Location = New Point(1257, 526)
        cbxpassseat4.Margin = New Padding(3, 2, 3, 2)
        cbxpassseat4.Name = "cbxpassseat4"
        cbxpassseat4.Size = New Size(64, 28)
        cbxpassseat4.TabIndex = 65
        ' 
        ' chkpasspwd4
        ' 
        chkpasspwd4.AutoSize = True
        chkpasspwd4.Location = New Point(1443, 530)
        chkpasspwd4.Name = "chkpasspwd4"
        chkpasspwd4.Size = New Size(15, 14)
        chkpasspwd4.TabIndex = 64
        chkpasspwd4.UseVisualStyleBackColor = True
        ' 
        ' cbxpassbag4
        ' 
        cbxpassbag4.Font = New Font("Segoe UI", 11.25F)
        cbxpassbag4.FormattingEnabled = True
        cbxpassbag4.Items.AddRange(New Object() {"10 kg", "20 kg", "40 kg"})
        cbxpassbag4.Location = New Point(1338, 526)
        cbxpassbag4.Margin = New Padding(3, 2, 3, 2)
        cbxpassbag4.Name = "cbxpassbag4"
        cbxpassbag4.Size = New Size(83, 28)
        cbxpassbag4.TabIndex = 63
        ' 
        ' cbxpassgen5
        ' 
        cbxpassgen5.Font = New Font("Segoe UI", 11.25F)
        cbxpassgen5.FormattingEnabled = True
        cbxpassgen5.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cbxpassgen5.Location = New Point(1164, 603)
        cbxpassgen5.Margin = New Padding(3, 2, 3, 2)
        cbxpassgen5.Name = "cbxpassgen5"
        cbxpassgen5.Size = New Size(82, 28)
        cbxpassgen5.TabIndex = 76
        ' 
        ' dtppassbday5
        ' 
        dtppassbday5.Font = New Font("Segoe UI", 11.25F)
        dtppassbday5.Location = New Point(1071, 603)
        dtppassbday5.Margin = New Padding(3, 2, 3, 2)
        dtppassbday5.Name = "dtppassbday5"
        dtppassbday5.Size = New Size(87, 27)
        dtppassbday5.TabIndex = 75
        ' 
        ' tbxpassAge5
        ' 
        tbxpassAge5.Font = New Font("Segoe UI", 11.25F)
        tbxpassAge5.Location = New Point(1012, 603)
        tbxpassAge5.Margin = New Padding(3, 2, 3, 2)
        tbxpassAge5.Name = "tbxpassAge5"
        tbxpassAge5.Size = New Size(53, 27)
        tbxpassAge5.TabIndex = 74
        ' 
        ' tbxPassname5
        ' 
        tbxPassname5.Font = New Font("Segoe UI", 11.25F)
        tbxPassname5.Location = New Point(842, 603)
        tbxPassname5.Margin = New Padding(3, 2, 3, 2)
        tbxPassname5.Name = "tbxPassname5"
        tbxPassname5.Size = New Size(164, 27)
        tbxPassname5.TabIndex = 73
        ' 
        ' cbxpassseat5
        ' 
        cbxpassseat5.Font = New Font("Segoe UI", 11.25F)
        cbxpassseat5.FormattingEnabled = True
        cbxpassseat5.Location = New Point(1257, 603)
        cbxpassseat5.Margin = New Padding(3, 2, 3, 2)
        cbxpassseat5.Name = "cbxpassseat5"
        cbxpassseat5.Size = New Size(64, 28)
        cbxpassseat5.TabIndex = 72
        ' 
        ' chkpasspwd5
        ' 
        chkpasspwd5.AutoSize = True
        chkpasspwd5.Location = New Point(1443, 607)
        chkpasspwd5.Name = "chkpasspwd5"
        chkpasspwd5.Size = New Size(15, 14)
        chkpasspwd5.TabIndex = 71
        chkpasspwd5.UseVisualStyleBackColor = True
        ' 
        ' cbxpassbag5
        ' 
        cbxpassbag5.Font = New Font("Segoe UI", 11.25F)
        cbxpassbag5.FormattingEnabled = True
        cbxpassbag5.Items.AddRange(New Object() {"10 kg", "20 kg", "40 kg"})
        cbxpassbag5.Location = New Point(1338, 603)
        cbxpassbag5.Margin = New Padding(3, 2, 3, 2)
        cbxpassbag5.Name = "cbxpassbag5"
        cbxpassbag5.Size = New Size(83, 28)
        cbxpassbag5.TabIndex = 70
        ' 
        ' cbxpassgen6
        ' 
        cbxpassgen6.Font = New Font("Segoe UI", 11.25F)
        cbxpassgen6.FormattingEnabled = True
        cbxpassgen6.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cbxpassgen6.Location = New Point(1164, 677)
        cbxpassgen6.Margin = New Padding(3, 2, 3, 2)
        cbxpassgen6.Name = "cbxpassgen6"
        cbxpassgen6.Size = New Size(82, 28)
        cbxpassgen6.TabIndex = 83
        ' 
        ' dtppassbday6
        ' 
        dtppassbday6.Font = New Font("Segoe UI", 11.25F)
        dtppassbday6.Location = New Point(1071, 677)
        dtppassbday6.Margin = New Padding(3, 2, 3, 2)
        dtppassbday6.Name = "dtppassbday6"
        dtppassbday6.Size = New Size(87, 27)
        dtppassbday6.TabIndex = 82
        ' 
        ' tbxpassAge6
        ' 
        tbxpassAge6.Font = New Font("Segoe UI", 11.25F)
        tbxpassAge6.Location = New Point(1012, 677)
        tbxpassAge6.Margin = New Padding(3, 2, 3, 2)
        tbxpassAge6.Name = "tbxpassAge6"
        tbxpassAge6.Size = New Size(53, 27)
        tbxpassAge6.TabIndex = 81
        ' 
        ' tbxPassname6
        ' 
        tbxPassname6.Font = New Font("Segoe UI", 11.25F)
        tbxPassname6.Location = New Point(842, 677)
        tbxPassname6.Margin = New Padding(3, 2, 3, 2)
        tbxPassname6.Name = "tbxPassname6"
        tbxPassname6.Size = New Size(164, 27)
        tbxPassname6.TabIndex = 80
        ' 
        ' cbxpassseat6
        ' 
        cbxpassseat6.Font = New Font("Segoe UI", 11.25F)
        cbxpassseat6.FormattingEnabled = True
        cbxpassseat6.Location = New Point(1257, 677)
        cbxpassseat6.Margin = New Padding(3, 2, 3, 2)
        cbxpassseat6.Name = "cbxpassseat6"
        cbxpassseat6.Size = New Size(64, 28)
        cbxpassseat6.TabIndex = 79
        ' 
        ' chkpasspwd6
        ' 
        chkpasspwd6.AutoSize = True
        chkpasspwd6.Location = New Point(1443, 681)
        chkpasspwd6.Name = "chkpasspwd6"
        chkpasspwd6.Size = New Size(15, 14)
        chkpasspwd6.TabIndex = 78
        chkpasspwd6.UseVisualStyleBackColor = True
        ' 
        ' cbxpassbag6
        ' 
        cbxpassbag6.Font = New Font("Segoe UI", 11.25F)
        cbxpassbag6.FormattingEnabled = True
        cbxpassbag6.Items.AddRange(New Object() {"10 kg", "20 kg", "40 kg"})
        cbxpassbag6.Location = New Point(1338, 677)
        cbxpassbag6.Margin = New Padding(3, 2, 3, 2)
        cbxpassbag6.Name = "cbxpassbag6"
        cbxpassbag6.Size = New Size(83, 28)
        cbxpassbag6.TabIndex = 77
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(703, 31)
        btnExit.Margin = New Padding(2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(143, 61)
        btnExit.TabIndex = 35
        btnExit.Text = " "
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblCoverCashier
        ' 
        lblCoverCashier.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblCoverCashier.Location = New Point(141, 427)
        lblCoverCashier.Name = "lblCoverCashier"
        lblCoverCashier.Size = New Size(615, 58)
        lblCoverCashier.TabIndex = 124
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1547, 916)
        Controls.Add(lblCoverCashier)
        Controls.Add(cbxpassgen6)
        Controls.Add(dtppassbday6)
        Controls.Add(tbxpassAge6)
        Controls.Add(tbxPassname6)
        Controls.Add(cbxpassseat6)
        Controls.Add(chkpasspwd6)
        Controls.Add(cbxpassbag6)
        Controls.Add(cbxpassgen5)
        Controls.Add(dtppassbday5)
        Controls.Add(tbxpassAge5)
        Controls.Add(tbxPassname5)
        Controls.Add(cbxpassseat5)
        Controls.Add(chkpasspwd5)
        Controls.Add(cbxpassbag5)
        Controls.Add(cbxpassgen4)
        Controls.Add(dtppassbday4)
        Controls.Add(tbxpassAge4)
        Controls.Add(tbxPassname4)
        Controls.Add(cbxpassseat4)
        Controls.Add(chkpasspwd4)
        Controls.Add(cbxpassbag4)
        Controls.Add(cbxpassgen3)
        Controls.Add(dtppassbday3)
        Controls.Add(tbxpassAge3)
        Controls.Add(tbxPassname3)
        Controls.Add(cbxpassseat3)
        Controls.Add(chkpasspwd3)
        Controls.Add(cbxpassbag3)
        Controls.Add(cbxpassgen2)
        Controls.Add(dtppassbday2)
        Controls.Add(tbxpassAge2)
        Controls.Add(tbxPassname2)
        Controls.Add(cbxpassseat2)
        Controls.Add(chkpasspwd2)
        Controls.Add(cbxpassbag2)
        Controls.Add(cbxpassgen1)
        Controls.Add(dtppassbday1)
        Controls.Add(tbxpassAge1)
        Controls.Add(tbxPassname1)
        Controls.Add(cbxpassseat1)
        Controls.Add(chkpasspwd1)
        Controls.Add(cbxpassbag1)
        Controls.Add(cbxBaggage)
        Controls.Add(chkPWD)
        Controls.Add(cbxGender)
        Controls.Add(dtpBirthdate)
        Controls.Add(tbxAge)
        Controls.Add(btnExit)
        Controls.Add(btnSupport)
        Controls.Add(btnTicket)
        Controls.Add(cbxSeatNumber)
        Controls.Add(btnBooking)
        Controls.Add(btnBook)
        Controls.Add(cbxArrivalTime)
        Controls.Add(btnClear)
        Controls.Add(rbnOneWayTrip)
        Controls.Add(cbxDepartureTime)
        Controls.Add(rbnRoundTrip)
        Controls.Add(cbxDeparture)
        Controls.Add(cbxDestination)
        Controls.Add(dtpDepartDate)
        Controls.Add(dtpArrivalDate)
        Controls.Add(dtpBookingDate)
        Controls.Add(tbxFullname)
        Controls.Add(tbxAddress)
        Controls.Add(pbxCashierBooking)
        Margin = New Padding(2)
        MaximumSize = New Size(1563, 969)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " CASHIER"
        CType(pbxCashierBooking, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnTicket As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents lblCustomerData As Label
    Friend WithEvents rbnOneWayTrip As RadioButton
    Friend WithEvents rbnRoundTrip As RadioButton
    Friend WithEvents cbxDeparture As ComboBox
    Friend WithEvents cbxDestination As ComboBox
    Friend WithEvents dtpDepartDate As DateTimePicker
    Friend WithEvents dtpArrivalDate As DateTimePicker
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents tbxFullname As TextBox
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents cbxDepartureTime As ComboBox
    Friend WithEvents cbxArrivalTime As ComboBox
    Friend WithEvents cbxSeatNumber As ComboBox
    Friend WithEvents btnSupport As Button
    Friend WithEvents pbxCashierBooking As PictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cbxGender As ComboBox
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents tbxAge As TextBox
    Friend WithEvents cbxBaggage As ComboBox
    Friend WithEvents chkPWD As CheckBox
    Friend WithEvents chkpasspwd1 As CheckBox
    Friend WithEvents cbxpassbag1 As ComboBox
    Friend WithEvents cbxpassseat1 As ComboBox
    Friend WithEvents tbxPassname1 As TextBox
    Friend WithEvents tbxpassAge1 As TextBox
    Friend WithEvents cbxpassgen1 As ComboBox
    Friend WithEvents dtppassbday1 As DateTimePicker
    Friend WithEvents cbxpassgen6 As ComboBox
    Friend WithEvents dtppassbday6 As DateTimePicker
    Friend WithEvents tbxpassAge6 As TextBox
    Friend WithEvents tbxPassname6 As TextBox
    Friend WithEvents cbxpassseat6 As ComboBox
    Friend WithEvents chkpasspwd6 As CheckBox
    Friend WithEvents cbxpassbag6 As ComboBox
    Friend WithEvents cbxpassgen5 As ComboBox
    Friend WithEvents dtppassbday5 As DateTimePicker
    Friend WithEvents tbxpassAge5 As TextBox
    Friend WithEvents tbxPassname5 As TextBox
    Friend WithEvents cbxpassseat5 As ComboBox
    Friend WithEvents chkpasspwd5 As CheckBox
    Friend WithEvents cbxpassbag5 As ComboBox
    Friend WithEvents cbxpassgen4 As ComboBox
    Friend WithEvents dtppassbday4 As DateTimePicker
    Friend WithEvents tbxpassAge4 As TextBox
    Friend WithEvents tbxPassname4 As TextBox
    Friend WithEvents cbxpassseat4 As ComboBox
    Friend WithEvents chkpasspwd4 As CheckBox
    Friend WithEvents cbxpassbag4 As ComboBox
    Friend WithEvents cbxpassgen3 As ComboBox
    Friend WithEvents dtppassbday3 As DateTimePicker
    Friend WithEvents tbxpassAge3 As TextBox
    Friend WithEvents tbxPassname3 As TextBox
    Friend WithEvents cbxpassseat3 As ComboBox
    Friend WithEvents chkpasspwd3 As CheckBox
    Friend WithEvents cbxpassbag3 As ComboBox
    Friend WithEvents cbxpassgen2 As ComboBox
    Friend WithEvents dtppassbday2 As DateTimePicker
    Friend WithEvents tbxpassAge2 As TextBox
    Friend WithEvents tbxPassname2 As TextBox
    Friend WithEvents cbxpassseat2 As ComboBox
    Friend WithEvents chkpasspwd2 As CheckBox
    Friend WithEvents cbxpassbag2 As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCoverCashier As Label
End Class
