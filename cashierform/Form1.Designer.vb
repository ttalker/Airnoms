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
        pbxCashierBooking.BackgroundImage = My.Resources.Resources.BOOKING_ROUND_TRIP
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
        ComboBox1.Location = New Point(1308, 297)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(83, 23)
        ComboBox1.TabIndex = 42
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(1429, 297)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(15, 14)
        CheckBox2.TabIndex = 43
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"AC1"})
        ComboBox2.Location = New Point(1205, 297)
        ComboBox2.Margin = New Padding(3, 2, 3, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(64, 23)
        ComboBox2.TabIndex = 44
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(839, 293)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(95, 23)
        TextBox1.TabIndex = 45
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(940, 293)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(53, 23)
        TextBox2.TabIndex = 46
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1547, 911)
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
End Class
