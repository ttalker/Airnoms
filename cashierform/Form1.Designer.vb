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
        dtpDeparture = New DateTimePicker()
        dtpArrivalDate = New DateTimePicker()
        dtpBookingDate = New DateTimePicker()
        tbxFullname = New TextBox()
        tbxAddress = New TextBox()
        cbxDepartureTime = New ComboBox()
        cbxArrivalTime = New ComboBox()
        BTNFILL = New Button()
        cbxFlight = New ComboBox()
        cbxSeatNumber = New ComboBox()
        btnSupport = New Button()
        pbxCashierBooking = New PictureBox()
        btnExit = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        tbxAge = New TextBox()
        dtpBirthdate = New DateTimePicker()
        cbxGender = New ComboBox()
        chkPWD = New CheckBox()
        cbxBaggage = New ComboBox()
        ComboBox1 = New ComboBox()
        CheckBox2 = New CheckBox()
        ComboBox2 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        ComboBox5 = New ComboBox()
        CheckBox1 = New CheckBox()
        ComboBox6 = New ComboBox()
        ComboBox7 = New ComboBox()
        DateTimePicker3 = New DateTimePicker()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        ComboBox8 = New ComboBox()
        CheckBox3 = New CheckBox()
        ComboBox9 = New ComboBox()
        ComboBox10 = New ComboBox()
        DateTimePicker4 = New DateTimePicker()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        ComboBox11 = New ComboBox()
        CheckBox4 = New CheckBox()
        ComboBox12 = New ComboBox()
        ComboBox13 = New ComboBox()
        DateTimePicker5 = New DateTimePicker()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        ComboBox14 = New ComboBox()
        CheckBox5 = New CheckBox()
        ComboBox15 = New ComboBox()
        ComboBox16 = New ComboBox()
        DateTimePicker6 = New DateTimePicker()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        ComboBox17 = New ComboBox()
        CheckBox6 = New CheckBox()
        ComboBox18 = New ComboBox()
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
        rbnOneWayTrip.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnOneWayTrip.Location = New Point(202, 240)
        rbnOneWayTrip.Margin = New Padding(3, 2, 3, 2)
        rbnOneWayTrip.Name = "rbnOneWayTrip"
        rbnOneWayTrip.Size = New Size(31, 24)
        rbnOneWayTrip.TabIndex = 0
        rbnOneWayTrip.TabStop = True
        rbnOneWayTrip.Text = " "
        rbnOneWayTrip.UseVisualStyleBackColor = True
        ' 
        ' rbnRoundTrip
        ' 
        rbnRoundTrip.AutoSize = True
        rbnRoundTrip.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbnRoundTrip.Location = New Point(400, 240)
        rbnRoundTrip.Margin = New Padding(3, 2, 3, 2)
        rbnRoundTrip.Name = "rbnRoundTrip"
        rbnRoundTrip.Size = New Size(31, 24)
        rbnRoundTrip.TabIndex = 1
        rbnRoundTrip.TabStop = True
        rbnRoundTrip.Text = " "
        rbnRoundTrip.UseVisualStyleBackColor = True
        ' 
        ' cbxDeparture
        ' 
        cbxDeparture.FormattingEnabled = True
        cbxDeparture.Location = New Point(275, 293)
        cbxDeparture.Margin = New Padding(3, 2, 3, 2)
        cbxDeparture.Name = "cbxDeparture"
        cbxDeparture.Size = New Size(203, 23)
        cbxDeparture.TabIndex = 3
        ' 
        ' cbxDestination
        ' 
        cbxDestination.FormattingEnabled = True
        cbxDestination.Location = New Point(275, 346)
        cbxDestination.Margin = New Padding(3, 2, 3, 2)
        cbxDestination.Name = "cbxDestination"
        cbxDestination.Size = New Size(203, 23)
        cbxDestination.TabIndex = 5
        ' 
        ' dtpDeparture
        ' 
        dtpDeparture.Location = New Point(275, 394)
        dtpDeparture.Margin = New Padding(3, 2, 3, 2)
        dtpDeparture.Name = "dtpDeparture"
        dtpDeparture.Size = New Size(110, 23)
        dtpDeparture.TabIndex = 7
        ' 
        ' dtpArrivalDate
        ' 
        dtpArrivalDate.Location = New Point(275, 441)
        dtpArrivalDate.Margin = New Padding(3, 2, 3, 2)
        dtpArrivalDate.Name = "dtpArrivalDate"
        dtpArrivalDate.Size = New Size(110, 23)
        dtpArrivalDate.TabIndex = 9
        ' 
        ' dtpBookingDate
        ' 
        dtpBookingDate.Location = New Point(626, 647)
        dtpBookingDate.Margin = New Padding(3, 2, 3, 2)
        dtpBookingDate.Name = "dtpBookingDate"
        dtpBookingDate.Size = New Size(110, 23)
        dtpBookingDate.TabIndex = 12
        ' 
        ' tbxFullname
        ' 
        tbxFullname.Location = New Point(275, 610)
        tbxFullname.Margin = New Padding(3, 2, 3, 2)
        tbxFullname.Name = "tbxFullname"
        tbxFullname.Size = New Size(203, 23)
        tbxFullname.TabIndex = 14
        ' 
        ' tbxAddress
        ' 
        tbxAddress.Location = New Point(275, 763)
        tbxAddress.Margin = New Padding(3, 2, 3, 2)
        tbxAddress.Name = "tbxAddress"
        tbxAddress.Size = New Size(203, 23)
        tbxAddress.TabIndex = 16
        ' 
        ' cbxDepartureTime
        ' 
        cbxDepartureTime.FormattingEnabled = True
        cbxDepartureTime.Location = New Point(602, 391)
        cbxDepartureTime.Margin = New Padding(3, 2, 3, 2)
        cbxDepartureTime.Name = "cbxDepartureTime"
        cbxDepartureTime.Size = New Size(173, 23)
        cbxDepartureTime.TabIndex = 28
        ' 
        ' cbxArrivalTime
        ' 
        cbxArrivalTime.FormattingEnabled = True
        cbxArrivalTime.Location = New Point(602, 441)
        cbxArrivalTime.Margin = New Padding(3, 2, 3, 2)
        cbxArrivalTime.Name = "cbxArrivalTime"
        cbxArrivalTime.Size = New Size(173, 23)
        cbxArrivalTime.TabIndex = 30
        ' 
        ' BTNFILL
        ' 
        BTNFILL.Location = New Point(696, 824)
        BTNFILL.Margin = New Padding(2)
        BTNFILL.Name = "BTNFILL"
        BTNFILL.Size = New Size(79, 20)
        BTNFILL.TabIndex = 33
        BTNFILL.Text = "FILL UP"
        BTNFILL.UseVisualStyleBackColor = True
        ' 
        ' cbxFlight
        ' 
        cbxFlight.FormattingEnabled = True
        cbxFlight.Items.AddRange(New Object() {"AC1"})
        cbxFlight.Location = New Point(602, 293)
        cbxFlight.Margin = New Padding(3, 2, 3, 2)
        cbxFlight.Name = "cbxFlight"
        cbxFlight.Size = New Size(108, 23)
        cbxFlight.TabIndex = 33
        ' 
        ' cbxSeatNumber
        ' 
        cbxSeatNumber.FormattingEnabled = True
        cbxSeatNumber.Items.AddRange(New Object() {"AC1"})
        cbxSeatNumber.Location = New Point(602, 340)
        cbxSeatNumber.Margin = New Padding(3, 2, 3, 2)
        cbxSeatNumber.Name = "cbxSeatNumber"
        cbxSeatNumber.Size = New Size(108, 23)
        cbxSeatNumber.TabIndex = 31
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
        pbxCashierBooking.BackgroundImage = My.Resources.Resources.BOOKING_ROUND_TRIP1
        pbxCashierBooking.Location = New Point(-1, -2)
        pbxCashierBooking.Name = "pbxCashierBooking"
        pbxCashierBooking.Size = New Size(1549, 915)
        pbxCashierBooking.TabIndex = 34
        pbxCashierBooking.TabStop = False
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
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' tbxAge
        ' 
        tbxAge.Location = New Point(275, 660)
        tbxAge.Margin = New Padding(3, 2, 3, 2)
        tbxAge.Name = "tbxAge"
        tbxAge.Size = New Size(203, 23)
        tbxAge.TabIndex = 37
        ' 
        ' dtpBirthdate
        ' 
        dtpBirthdate.Location = New Point(275, 712)
        dtpBirthdate.Margin = New Padding(3, 2, 3, 2)
        dtpBirthdate.Name = "dtpBirthdate"
        dtpBirthdate.Size = New Size(203, 23)
        dtpBirthdate.TabIndex = 38
        ' 
        ' cbxGender
        ' 
        cbxGender.FormattingEnabled = True
        cbxGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cbxGender.Location = New Point(275, 809)
        cbxGender.Margin = New Padding(3, 2, 3, 2)
        cbxGender.Name = "cbxGender"
        cbxGender.Size = New Size(108, 23)
        cbxGender.TabIndex = 39
        ' 
        ' chkPWD
        ' 
        chkPWD.AutoSize = True
        chkPWD.Location = New Point(568, 782)
        chkPWD.Name = "chkPWD"
        chkPWD.Size = New Size(15, 14)
        chkPWD.TabIndex = 40
        chkPWD.UseVisualStyleBackColor = True
        ' 
        ' cbxBaggage
        ' 
        cbxBaggage.FormattingEnabled = True
        cbxBaggage.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        cbxBaggage.Location = New Point(677, 712)
        cbxBaggage.Margin = New Padding(3, 2, 3, 2)
        cbxBaggage.Name = "cbxBaggage"
        cbxBaggage.Size = New Size(59, 23)
        cbxBaggage.TabIndex = 41
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        ComboBox1.Location = New Point(1338, 301)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(83, 23)
        ComboBox1.TabIndex = 42
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(1443, 305)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(15, 14)
        CheckBox2.TabIndex = 43
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"AC1"})
        ComboBox2.Location = New Point(1257, 301)
        ComboBox2.Margin = New Padding(3, 2, 3, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(64, 23)
        ComboBox2.TabIndex = 44
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(842, 301)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(164, 23)
        TextBox1.TabIndex = 45
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(1012, 301)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(53, 23)
        TextBox2.TabIndex = 46
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(1071, 301)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(87, 23)
        DateTimePicker1.TabIndex = 47
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Male", "Female", "Others"})
        ComboBox3.Location = New Point(1164, 301)
        ComboBox3.Margin = New Padding(3, 2, 3, 2)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(82, 23)
        ComboBox3.TabIndex = 48
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Male", "Female", "Others"})
        ComboBox4.Location = New Point(1164, 373)
        ComboBox4.Margin = New Padding(3, 2, 3, 2)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(82, 23)
        ComboBox4.TabIndex = 55
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(1071, 373)
        DateTimePicker2.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(87, 23)
        DateTimePicker2.TabIndex = 54
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(1012, 373)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(53, 23)
        TextBox3.TabIndex = 53
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(842, 373)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(164, 23)
        TextBox4.TabIndex = 52
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"AC1"})
        ComboBox5.Location = New Point(1257, 373)
        ComboBox5.Margin = New Padding(3, 2, 3, 2)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(64, 23)
        ComboBox5.TabIndex = 51
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(1443, 377)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(15, 14)
        CheckBox1.TabIndex = 50
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        ComboBox6.Location = New Point(1338, 373)
        ComboBox6.Margin = New Padding(3, 2, 3, 2)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(83, 23)
        ComboBox6.TabIndex = 49
        ' 
        ' ComboBox7
        ' 
        ComboBox7.FormattingEnabled = True
        ComboBox7.Items.AddRange(New Object() {"Male", "Female", "Others"})
        ComboBox7.Location = New Point(1164, 450)
        ComboBox7.Margin = New Padding(3, 2, 3, 2)
        ComboBox7.Name = "ComboBox7"
        ComboBox7.Size = New Size(82, 23)
        ComboBox7.TabIndex = 62
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Location = New Point(1071, 450)
        DateTimePicker3.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(87, 23)
        DateTimePicker3.TabIndex = 61
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(1012, 450)
        TextBox5.Margin = New Padding(3, 2, 3, 2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(53, 23)
        TextBox5.TabIndex = 60
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(842, 450)
        TextBox6.Margin = New Padding(3, 2, 3, 2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(164, 23)
        TextBox6.TabIndex = 59
        ' 
        ' ComboBox8
        ' 
        ComboBox8.FormattingEnabled = True
        ComboBox8.Items.AddRange(New Object() {"AC1"})
        ComboBox8.Location = New Point(1257, 450)
        ComboBox8.Margin = New Padding(3, 2, 3, 2)
        ComboBox8.Name = "ComboBox8"
        ComboBox8.Size = New Size(64, 23)
        ComboBox8.TabIndex = 58
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(1443, 454)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(15, 14)
        CheckBox3.TabIndex = 57
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox9
        ' 
        ComboBox9.FormattingEnabled = True
        ComboBox9.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        ComboBox9.Location = New Point(1338, 450)
        ComboBox9.Margin = New Padding(3, 2, 3, 2)
        ComboBox9.Name = "ComboBox9"
        ComboBox9.Size = New Size(83, 23)
        ComboBox9.TabIndex = 56
        ' 
        ' ComboBox10
        ' 
        ComboBox10.FormattingEnabled = True
        ComboBox10.Items.AddRange(New Object() {"Male", "Female", "Others"})
        ComboBox10.Location = New Point(1164, 526)
        ComboBox10.Margin = New Padding(3, 2, 3, 2)
        ComboBox10.Name = "ComboBox10"
        ComboBox10.Size = New Size(82, 23)
        ComboBox10.TabIndex = 69
        ' 
        ' DateTimePicker4
        ' 
        DateTimePicker4.Location = New Point(1071, 526)
        DateTimePicker4.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker4.Name = "DateTimePicker4"
        DateTimePicker4.Size = New Size(87, 23)
        DateTimePicker4.TabIndex = 68
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(1012, 526)
        TextBox7.Margin = New Padding(3, 2, 3, 2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(53, 23)
        TextBox7.TabIndex = 67
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(842, 526)
        TextBox8.Margin = New Padding(3, 2, 3, 2)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(164, 23)
        TextBox8.TabIndex = 66
        ' 
        ' ComboBox11
        ' 
        ComboBox11.FormattingEnabled = True
        ComboBox11.Items.AddRange(New Object() {"AC1"})
        ComboBox11.Location = New Point(1257, 526)
        ComboBox11.Margin = New Padding(3, 2, 3, 2)
        ComboBox11.Name = "ComboBox11"
        ComboBox11.Size = New Size(64, 23)
        ComboBox11.TabIndex = 65
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(1443, 530)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(15, 14)
        CheckBox4.TabIndex = 64
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' ComboBox12
        ' 
        ComboBox12.FormattingEnabled = True
        ComboBox12.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        ComboBox12.Location = New Point(1338, 526)
        ComboBox12.Margin = New Padding(3, 2, 3, 2)
        ComboBox12.Name = "ComboBox12"
        ComboBox12.Size = New Size(83, 23)
        ComboBox12.TabIndex = 63
        ' 
        ' ComboBox13
        ' 
        ComboBox13.FormattingEnabled = True
        ComboBox13.Items.AddRange(New Object() {"Male", "Female", "Others"})
        ComboBox13.Location = New Point(1164, 603)
        ComboBox13.Margin = New Padding(3, 2, 3, 2)
        ComboBox13.Name = "ComboBox13"
        ComboBox13.Size = New Size(82, 23)
        ComboBox13.TabIndex = 76
        ' 
        ' DateTimePicker5
        ' 
        DateTimePicker5.Location = New Point(1071, 603)
        DateTimePicker5.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker5.Name = "DateTimePicker5"
        DateTimePicker5.Size = New Size(87, 23)
        DateTimePicker5.TabIndex = 75
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(1012, 603)
        TextBox9.Margin = New Padding(3, 2, 3, 2)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(53, 23)
        TextBox9.TabIndex = 74
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(842, 603)
        TextBox10.Margin = New Padding(3, 2, 3, 2)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(164, 23)
        TextBox10.TabIndex = 73
        ' 
        ' ComboBox14
        ' 
        ComboBox14.FormattingEnabled = True
        ComboBox14.Items.AddRange(New Object() {"AC1"})
        ComboBox14.Location = New Point(1257, 603)
        ComboBox14.Margin = New Padding(3, 2, 3, 2)
        ComboBox14.Name = "ComboBox14"
        ComboBox14.Size = New Size(64, 23)
        ComboBox14.TabIndex = 72
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(1443, 607)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(15, 14)
        CheckBox5.TabIndex = 71
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' ComboBox15
        ' 
        ComboBox15.FormattingEnabled = True
        ComboBox15.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        ComboBox15.Location = New Point(1338, 603)
        ComboBox15.Margin = New Padding(3, 2, 3, 2)
        ComboBox15.Name = "ComboBox15"
        ComboBox15.Size = New Size(83, 23)
        ComboBox15.TabIndex = 70
        ' 
        ' ComboBox16
        ' 
        ComboBox16.FormattingEnabled = True
        ComboBox16.Items.AddRange(New Object() {"Male", "Female", "Others"})
        ComboBox16.Location = New Point(1164, 677)
        ComboBox16.Margin = New Padding(3, 2, 3, 2)
        ComboBox16.Name = "ComboBox16"
        ComboBox16.Size = New Size(82, 23)
        ComboBox16.TabIndex = 83
        ' 
        ' DateTimePicker6
        ' 
        DateTimePicker6.Location = New Point(1071, 677)
        DateTimePicker6.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker6.Name = "DateTimePicker6"
        DateTimePicker6.Size = New Size(87, 23)
        DateTimePicker6.TabIndex = 82
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(1012, 677)
        TextBox11.Margin = New Padding(3, 2, 3, 2)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(53, 23)
        TextBox11.TabIndex = 81
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(842, 677)
        TextBox12.Margin = New Padding(3, 2, 3, 2)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(164, 23)
        TextBox12.TabIndex = 80
        ' 
        ' ComboBox17
        ' 
        ComboBox17.FormattingEnabled = True
        ComboBox17.Items.AddRange(New Object() {"AC1"})
        ComboBox17.Location = New Point(1257, 677)
        ComboBox17.Margin = New Padding(3, 2, 3, 2)
        ComboBox17.Name = "ComboBox17"
        ComboBox17.Size = New Size(64, 23)
        ComboBox17.TabIndex = 79
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(1443, 681)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(15, 14)
        CheckBox6.TabIndex = 78
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' ComboBox18
        ' 
        ComboBox18.FormattingEnabled = True
        ComboBox18.Items.AddRange(New Object() {"10kg", "20kg", "40kg"})
        ComboBox18.Location = New Point(1338, 677)
        ComboBox18.Margin = New Padding(3, 2, 3, 2)
        ComboBox18.Name = "ComboBox18"
        ComboBox18.Size = New Size(83, 23)
        ComboBox18.TabIndex = 77
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1547, 911)
        Controls.Add(ComboBox16)
        Controls.Add(DateTimePicker6)
        Controls.Add(TextBox11)
        Controls.Add(TextBox12)
        Controls.Add(ComboBox17)
        Controls.Add(CheckBox6)
        Controls.Add(ComboBox18)
        Controls.Add(ComboBox13)
        Controls.Add(DateTimePicker5)
        Controls.Add(TextBox9)
        Controls.Add(TextBox10)
        Controls.Add(ComboBox14)
        Controls.Add(CheckBox5)
        Controls.Add(ComboBox15)
        Controls.Add(ComboBox10)
        Controls.Add(DateTimePicker4)
        Controls.Add(TextBox7)
        Controls.Add(TextBox8)
        Controls.Add(ComboBox11)
        Controls.Add(CheckBox4)
        Controls.Add(ComboBox12)
        Controls.Add(ComboBox7)
        Controls.Add(DateTimePicker3)
        Controls.Add(TextBox5)
        Controls.Add(TextBox6)
        Controls.Add(ComboBox8)
        Controls.Add(CheckBox3)
        Controls.Add(ComboBox9)
        Controls.Add(ComboBox4)
        Controls.Add(DateTimePicker2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox4)
        Controls.Add(ComboBox5)
        Controls.Add(CheckBox1)
        Controls.Add(ComboBox6)
        Controls.Add(ComboBox3)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(CheckBox2)
        Controls.Add(ComboBox1)
        Controls.Add(cbxBaggage)
        Controls.Add(chkPWD)
        Controls.Add(cbxGender)
        Controls.Add(dtpBirthdate)
        Controls.Add(tbxAge)
        Controls.Add(btnExit)
        Controls.Add(cbxSeatNumber)
        Controls.Add(btnSupport)
        Controls.Add(btnTicket)
        Controls.Add(cbxFlight)
        Controls.Add(btnBooking)
        Controls.Add(BTNFILL)
        Controls.Add(btnBook)
        Controls.Add(cbxArrivalTime)
        Controls.Add(btnClear)
        Controls.Add(rbnOneWayTrip)
        Controls.Add(cbxDepartureTime)
        Controls.Add(rbnRoundTrip)
        Controls.Add(cbxDeparture)
        Controls.Add(cbxDestination)
        Controls.Add(dtpDeparture)
        Controls.Add(dtpArrivalDate)
        Controls.Add(dtpBookingDate)
        Controls.Add(tbxFullname)
        Controls.Add(tbxAddress)
        Controls.Add(pbxCashierBooking)
        Margin = New Padding(2)
        MaximumSize = New Size(1563, 969)
        Name = "Form1"
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
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents dtpArrivalDate As DateTimePicker
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents tbxFullname As TextBox
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents cbxDepartureTime As ComboBox
    Friend WithEvents cbxArrivalTime As ComboBox
    Friend WithEvents BTNFILL As Button
    Friend WithEvents cbxFlight As ComboBox
    Friend WithEvents cbxSeatNumber As ComboBox
    Friend WithEvents btnSupport As Button
    Friend WithEvents pbxCashierBooking As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cbxGender As ComboBox
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents tbxAge As TextBox
    Friend WithEvents cbxBaggage As ComboBox
    Friend WithEvents chkPWD As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox16 As ComboBox
    Friend WithEvents DateTimePicker6 As DateTimePicker
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents ComboBox17 As ComboBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents ComboBox18 As ComboBox
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents ComboBox14 As ComboBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents ComboBox15 As ComboBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox6 As ComboBox
End Class
