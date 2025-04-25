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
        tbxCity = New TextBox()
        tbxPostalCode = New TextBox()
        tbxContactNumber = New TextBox()
        tbxEmail = New TextBox()
        tbxGender = New TextBox()
        cbxDepartureTime = New ComboBox()
        cbxArrivalTime = New ComboBox()
        BTNFILL = New Button()
        cbxFlight = New ComboBox()
        cbxSeatNumber = New ComboBox()
        btnSupport = New Button()
        pbxCashierBooking = New PictureBox()
        btnExit = New Button()
        CType(pbxCashierBooking, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(86, 28)
        btnBooking.Margin = New Padding(3, 2, 3, 2)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(177, 67)
        btnBooking.TabIndex = 1
        btnBooking.Text = " "
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(291, 27)
        btnTicket.Margin = New Padding(3, 2, 3, 2)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(178, 64)
        btnTicket.TabIndex = 2
        btnTicket.Text = " "
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1088, 795)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(181, 78)
        btnClear.TabIndex = 5
        btnClear.Text = " "
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBook
        ' 
        btnBook.Location = New Point(1285, 795)
        btnBook.Margin = New Padding(3, 2, 3, 2)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(178, 78)
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
        dtpBookingDate.Location = New Point(275, 606)
        dtpBookingDate.Margin = New Padding(3, 2, 3, 2)
        dtpBookingDate.Name = "dtpBookingDate"
        dtpBookingDate.Size = New Size(110, 23)
        dtpBookingDate.TabIndex = 12
        ' 
        ' tbxFullname
        ' 
        tbxFullname.Location = New Point(275, 650)
        tbxFullname.Margin = New Padding(3, 2, 3, 2)
        tbxFullname.Name = "tbxFullname"
        tbxFullname.Size = New Size(203, 23)
        tbxFullname.TabIndex = 14
        ' 
        ' tbxAddress
        ' 
        tbxAddress.Location = New Point(275, 687)
        tbxAddress.Margin = New Padding(3, 2, 3, 2)
        tbxAddress.Name = "tbxAddress"
        tbxAddress.Size = New Size(203, 23)
        tbxAddress.TabIndex = 16
        ' 
        ' tbxCity
        ' 
        tbxCity.Location = New Point(275, 729)
        tbxCity.Margin = New Padding(3, 2, 3, 2)
        tbxCity.Name = "tbxCity"
        tbxCity.Size = New Size(194, 23)
        tbxCity.TabIndex = 18
        ' 
        ' tbxPostalCode
        ' 
        tbxPostalCode.Location = New Point(602, 731)
        tbxPostalCode.Margin = New Padding(3, 2, 3, 2)
        tbxPostalCode.Name = "tbxPostalCode"
        tbxPostalCode.Size = New Size(111, 23)
        tbxPostalCode.TabIndex = 20
        ' 
        ' tbxContactNumber
        ' 
        tbxContactNumber.Location = New Point(275, 768)
        tbxContactNumber.Margin = New Padding(3, 2, 3, 2)
        tbxContactNumber.Name = "tbxContactNumber"
        tbxContactNumber.Size = New Size(203, 23)
        tbxContactNumber.TabIndex = 22
        ' 
        ' tbxEmail
        ' 
        tbxEmail.Location = New Point(275, 805)
        tbxEmail.Margin = New Padding(3, 2, 3, 2)
        tbxEmail.Name = "tbxEmail"
        tbxEmail.Size = New Size(203, 23)
        tbxEmail.TabIndex = 24
        ' 
        ' tbxGender
        ' 
        tbxGender.Location = New Point(602, 691)
        tbxGender.Margin = New Padding(3, 2, 3, 2)
        tbxGender.Name = "tbxGender"
        tbxGender.Size = New Size(111, 23)
        tbxGender.TabIndex = 26
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
        btnSupport.Location = New Point(487, 26)
        btnSupport.Margin = New Padding(2)
        btnSupport.Name = "btnSupport"
        btnSupport.Size = New Size(180, 63)
        btnSupport.TabIndex = 11
        btnSupport.Text = " "
        btnSupport.UseVisualStyleBackColor = True
        ' 
        ' pbxCashierBooking
        ' 
        pbxCashierBooking.BackgroundImage = My.Resources.Resources.MAIN_REFERENCE__REAL____Round_Trip__2___1_
        pbxCashierBooking.Location = New Point(-1, -2)
        pbxCashierBooking.Name = "pbxCashierBooking"
        pbxCashierBooking.Size = New Size(1549, 915)
        pbxCashierBooking.TabIndex = 34
        pbxCashierBooking.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(710, 27)
        btnExit.Margin = New Padding(2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(143, 61)
        btnExit.TabIndex = 35
        btnExit.Text = " "
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1547, 911)
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
        Controls.Add(tbxGender)
        Controls.Add(cbxDestination)
        Controls.Add(dtpDeparture)
        Controls.Add(tbxEmail)
        Controls.Add(dtpArrivalDate)
        Controls.Add(dtpBookingDate)
        Controls.Add(tbxContactNumber)
        Controls.Add(tbxFullname)
        Controls.Add(tbxAddress)
        Controls.Add(tbxPostalCode)
        Controls.Add(tbxCity)
        Controls.Add(pbxCashierBooking)
        Margin = New Padding(2)
        MaximumSize = New Size(1563, 969)
        Name = "Form1"
        Text = " CASHIER"
        CType(pbxCashierBooking, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbxCity As TextBox
    Friend WithEvents tbxPostalCode As TextBox
    Friend WithEvents tbxContactNumber As TextBox
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents tbxGender As TextBox
    Friend WithEvents cbxDepartureTime As ComboBox
    Friend WithEvents cbxArrivalTime As ComboBox
    Friend WithEvents BTNFILL As Button
    Friend WithEvents cbxFlight As ComboBox
    Friend WithEvents cbxSeatNumber As ComboBox
    Friend WithEvents btnSupport As Button
    Friend WithEvents pbxCashierBooking As PictureBox
    Friend WithEvents btnExit As Button
End Class
