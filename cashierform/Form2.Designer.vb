<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnTicket = New Button()
        btnBooking = New Button()
        lblMainBooking = New Label()
        pnlRightInfo = New Panel()
        gbxPaymentTicket = New GroupBox()
        tbxTicketPayment = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblPaymentAmountTicket = New Label()
        btnCalculate = New Button()
        gbxSummaryTickets = New GroupBox()
        lblTotalTicket = New Label()
        lblBrokenLineTicket = New Label()
        lblTaxTicket = New Label()
        lblTicketAmountTicket = New Label()
        pnlleftInfo = New Panel()
        lblAddressTicket = New Label()
        lblSeatNumberTicket = New Label()
        lblArrivalTimeTicket = New Label()
        lblArrivalDateTicket = New Label()
        lblDepartureTimeTicket = New Label()
        cbxClassTicket = New ComboBox()
        lblClassTicket = New Label()
        lblGenderTicket = New Label()
        lblPassengersTicket = New Label()
        lblDestinationTicket = New Label()
        lblFullnameTicket = New Label()
        lblBookingDateTicket = New Label()
        lblDepartureDateTicket = New Label()
        cbxFlightTicket = New ComboBox()
        lblFlightTicket = New Label()
        cbxPassengerTicket = New ComboBox()
        lblSelectPassengerTicket = New Label()
        gbxBookingDetailsTicket = New GroupBox()
        gxbCustomerDataTickets = New GroupBox()
        btnResetTicket = New Button()
        btnProcessTicket = New Button()
        Button1 = New Button()
        pnlRightInfo.SuspendLayout()
        gbxPaymentTicket.SuspendLayout()
        gbxSummaryTickets.SuspendLayout()
        pnlleftInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(211, 16)
        btnTicket.Margin = New Padding(3, 2, 3, 2)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(170, 44)
        btnTicket.TabIndex = 5
        btnTicket.Text = "TICKET"
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(24, 16)
        btnBooking.Margin = New Padding(3, 2, 3, 2)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(170, 44)
        btnBooking.TabIndex = 4
        btnBooking.Text = "BOOKING"
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' lblMainBooking
        ' 
        lblMainBooking.BackColor = SystemColors.ActiveCaption
        lblMainBooking.Location = New Point(24, 73)
        lblMainBooking.Name = "lblMainBooking"
        lblMainBooking.Size = New Size(1304, 594)
        lblMainBooking.TabIndex = 3
        ' 
        ' pnlRightInfo
        ' 
        pnlRightInfo.BackColor = Color.Snow
        pnlRightInfo.Controls.Add(gbxPaymentTicket)
        pnlRightInfo.Controls.Add(btnCalculate)
        pnlRightInfo.Controls.Add(gbxSummaryTickets)
        pnlRightInfo.Location = New Point(738, 92)
        pnlRightInfo.Margin = New Padding(3, 2, 3, 2)
        pnlRightInfo.Name = "pnlRightInfo"
        pnlRightInfo.Size = New Size(567, 482)
        pnlRightInfo.TabIndex = 7
        ' 
        ' gbxPaymentTicket
        ' 
        gbxPaymentTicket.Controls.Add(tbxTicketPayment)
        gbxPaymentTicket.Controls.Add(Label1)
        gbxPaymentTicket.Controls.Add(Label2)
        gbxPaymentTicket.Controls.Add(lblPaymentAmountTicket)
        gbxPaymentTicket.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxPaymentTicket.Location = New Point(39, 200)
        gbxPaymentTicket.Margin = New Padding(3, 2, 3, 2)
        gbxPaymentTicket.Name = "gbxPaymentTicket"
        gbxPaymentTicket.Padding = New Padding(3, 2, 3, 2)
        gbxPaymentTicket.Size = New Size(489, 223)
        gbxPaymentTicket.TabIndex = 38
        gbxPaymentTicket.TabStop = False
        gbxPaymentTicket.Text = "Payment"
        ' 
        ' tbxTicketPayment
        ' 
        tbxTicketPayment.Anchor = AnchorStyles.None
        tbxTicketPayment.Location = New Point(204, 74)
        tbxTicketPayment.Margin = New Padding(3, 2, 3, 2)
        tbxTicketPayment.MaximumSize = New Size(217, 30)
        tbxTicketPayment.Name = "tbxTicketPayment"
        tbxTicketPayment.Size = New Size(217, 43)
        tbxTicketPayment.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(91, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(337, 30)
        Label1.TabIndex = 6
        Label1.Text = "Change:"
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ControlDarkDark
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(85, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(350, 2)
        Label2.TabIndex = 5
        ' 
        ' lblPaymentAmountTicket
        ' 
        lblPaymentAmountTicket.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPaymentAmountTicket.Location = New Point(42, 72)
        lblPaymentAmountTicket.Name = "lblPaymentAmountTicket"
        lblPaymentAmountTicket.Size = New Size(162, 25)
        lblPaymentAmountTicket.TabIndex = 3
        lblPaymentAmountTicket.Text = "Ticket Payment:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Silver
        btnCalculate.Location = New Point(388, 430)
        btnCalculate.Margin = New Padding(3, 2, 3, 2)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(141, 44)
        btnCalculate.TabIndex = 38
        btnCalculate.Text = "CALCULATE"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' gbxSummaryTickets
        ' 
        gbxSummaryTickets.Controls.Add(lblTotalTicket)
        gbxSummaryTickets.Controls.Add(lblBrokenLineTicket)
        gbxSummaryTickets.Controls.Add(lblTaxTicket)
        gbxSummaryTickets.Controls.Add(lblTicketAmountTicket)
        gbxSummaryTickets.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxSummaryTickets.Location = New Point(22, 8)
        gbxSummaryTickets.Margin = New Padding(3, 2, 3, 2)
        gbxSummaryTickets.Name = "gbxSummaryTickets"
        gbxSummaryTickets.Padding = New Padding(3, 2, 3, 2)
        gbxSummaryTickets.Size = New Size(528, 188)
        gbxSummaryTickets.TabIndex = 37
        gbxSummaryTickets.TabStop = False
        gbxSummaryTickets.Text = "Summary"
        ' 
        ' lblTotalTicket
        ' 
        lblTotalTicket.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalTicket.Location = New Point(80, 148)
        lblTotalTicket.Name = "lblTotalTicket"
        lblTotalTicket.Size = New Size(337, 19)
        lblTotalTicket.TabIndex = 6
        lblTotalTicket.Text = "Total:"
        ' 
        ' lblBrokenLineTicket
        ' 
        lblBrokenLineTicket.BackColor = SystemColors.ControlDarkDark
        lblBrokenLineTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBrokenLineTicket.Location = New Point(82, 132)
        lblBrokenLineTicket.Name = "lblBrokenLineTicket"
        lblBrokenLineTicket.Size = New Size(350, 2)
        lblBrokenLineTicket.TabIndex = 5
        ' 
        ' lblTaxTicket
        ' 
        lblTaxTicket.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTaxTicket.Location = New Point(80, 94)
        lblTaxTicket.Name = "lblTaxTicket"
        lblTaxTicket.Size = New Size(337, 19)
        lblTaxTicket.TabIndex = 4
        lblTaxTicket.Text = "Tax:"
        ' 
        ' lblTicketAmountTicket
        ' 
        lblTicketAmountTicket.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTicketAmountTicket.Location = New Point(80, 57)
        lblTicketAmountTicket.Name = "lblTicketAmountTicket"
        lblTicketAmountTicket.Size = New Size(337, 19)
        lblTicketAmountTicket.TabIndex = 3
        lblTicketAmountTicket.Text = "Ticket Amount:"
        ' 
        ' pnlleftInfo
        ' 
        pnlleftInfo.BackColor = Color.Snow
        pnlleftInfo.Controls.Add(lblAddressTicket)
        pnlleftInfo.Controls.Add(lblSeatNumberTicket)
        pnlleftInfo.Controls.Add(lblArrivalTimeTicket)
        pnlleftInfo.Controls.Add(lblArrivalDateTicket)
        pnlleftInfo.Controls.Add(lblDepartureTimeTicket)
        pnlleftInfo.Controls.Add(cbxClassTicket)
        pnlleftInfo.Controls.Add(lblClassTicket)
        pnlleftInfo.Controls.Add(lblGenderTicket)
        pnlleftInfo.Controls.Add(lblPassengersTicket)
        pnlleftInfo.Controls.Add(lblDestinationTicket)
        pnlleftInfo.Controls.Add(lblFullnameTicket)
        pnlleftInfo.Controls.Add(lblBookingDateTicket)
        pnlleftInfo.Controls.Add(lblDepartureDateTicket)
        pnlleftInfo.Controls.Add(cbxFlightTicket)
        pnlleftInfo.Controls.Add(lblFlightTicket)
        pnlleftInfo.Controls.Add(cbxPassengerTicket)
        pnlleftInfo.Controls.Add(lblSelectPassengerTicket)
        pnlleftInfo.Controls.Add(gbxBookingDetailsTicket)
        pnlleftInfo.Controls.Add(gxbCustomerDataTickets)
        pnlleftInfo.Location = New Point(52, 92)
        pnlleftInfo.Margin = New Padding(3, 2, 3, 2)
        pnlleftInfo.Name = "pnlleftInfo"
        pnlleftInfo.Size = New Size(651, 482)
        pnlleftInfo.TabIndex = 6
        ' 
        ' lblAddressTicket
        ' 
        lblAddressTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddressTicket.Location = New Point(45, 389)
        lblAddressTicket.Name = "lblAddressTicket"
        lblAddressTicket.Size = New Size(344, 19)
        lblAddressTicket.TabIndex = 35
        lblAddressTicket.Text = "Address:"
        lblAddressTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSeatNumberTicket
        ' 
        lblSeatNumberTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeatNumberTicket.Location = New Point(424, 409)
        lblSeatNumberTicket.Name = "lblSeatNumberTicket"
        lblSeatNumberTicket.Size = New Size(122, 19)
        lblSeatNumberTicket.TabIndex = 34
        lblSeatNumberTicket.Text = "Seat #:"
        ' 
        ' lblArrivalTimeTicket
        ' 
        lblArrivalTimeTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalTimeTicket.Location = New Point(384, 236)
        lblArrivalTimeTicket.Name = "lblArrivalTimeTicket"
        lblArrivalTimeTicket.Size = New Size(227, 19)
        lblArrivalTimeTicket.TabIndex = 31
        lblArrivalTimeTicket.Text = "Arrival Time:"
        lblArrivalTimeTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblArrivalDateTicket
        ' 
        lblArrivalDateTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalDateTicket.Location = New Point(384, 200)
        lblArrivalDateTicket.Name = "lblArrivalDateTicket"
        lblArrivalDateTicket.Size = New Size(227, 19)
        lblArrivalDateTicket.TabIndex = 30
        lblArrivalDateTicket.Text = "Arrival Date:"
        lblArrivalDateTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDepartureTimeTicket
        ' 
        lblDepartureTimeTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureTimeTicket.Location = New Point(45, 236)
        lblDepartureTimeTicket.Name = "lblDepartureTimeTicket"
        lblDepartureTimeTicket.Size = New Size(316, 19)
        lblDepartureTimeTicket.TabIndex = 29
        lblDepartureTimeTicket.Text = "Depart Time:"
        lblDepartureTimeTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbxClassTicket
        ' 
        cbxClassTicket.FormattingEnabled = True
        cbxClassTicket.Location = New Point(158, 160)
        cbxClassTicket.Margin = New Padding(3, 2, 3, 2)
        cbxClassTicket.Name = "cbxClassTicket"
        cbxClassTicket.Size = New Size(203, 23)
        cbxClassTicket.TabIndex = 28
        ' 
        ' lblClassTicket
        ' 
        lblClassTicket.AutoSize = True
        lblClassTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblClassTicket.Location = New Point(45, 159)
        lblClassTicket.Name = "lblClassTicket"
        lblClassTicket.Size = New Size(46, 20)
        lblClassTicket.TabIndex = 27
        lblClassTicket.Text = "Class:"
        ' 
        ' lblGenderTicket
        ' 
        lblGenderTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGenderTicket.Location = New Point(424, 309)
        lblGenderTicket.Name = "lblGenderTicket"
        lblGenderTicket.Size = New Size(177, 19)
        lblGenderTicket.TabIndex = 25
        lblGenderTicket.Text = "Gender:"
        lblGenderTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPassengersTicket
        ' 
        lblPassengersTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassengersTicket.Location = New Point(424, 360)
        lblPassengersTicket.Name = "lblPassengersTicket"
        lblPassengersTicket.Size = New Size(199, 19)
        lblPassengersTicket.TabIndex = 19
        lblPassengersTicket.Text = "No. of Passengers:"
        lblPassengersTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDestinationTicket
        ' 
        lblDestinationTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestinationTicket.Location = New Point(45, 430)
        lblDestinationTicket.Name = "lblDestinationTicket"
        lblDestinationTicket.Size = New Size(345, 19)
        lblDestinationTicket.TabIndex = 15
        lblDestinationTicket.Text = "Destination:"
        lblDestinationTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblFullnameTicket
        ' 
        lblFullnameTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullnameTicket.Location = New Point(44, 350)
        lblFullnameTicket.Name = "lblFullnameTicket"
        lblFullnameTicket.Size = New Size(345, 19)
        lblFullnameTicket.TabIndex = 13
        lblFullnameTicket.Text = "Fullname:"
        lblFullnameTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBookingDateTicket
        ' 
        lblBookingDateTicket.BackColor = Color.Gainsboro
        lblBookingDateTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookingDateTicket.Location = New Point(45, 309)
        lblBookingDateTicket.Name = "lblBookingDateTicket"
        lblBookingDateTicket.Size = New Size(345, 19)
        lblBookingDateTicket.TabIndex = 11
        lblBookingDateTicket.Text = "Booking Date:"
        lblBookingDateTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDepartureDateTicket
        ' 
        lblDepartureDateTicket.BackColor = Color.Snow
        lblDepartureDateTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureDateTicket.Location = New Point(45, 200)
        lblDepartureDateTicket.Name = "lblDepartureDateTicket"
        lblDepartureDateTicket.Size = New Size(316, 19)
        lblDepartureDateTicket.TabIndex = 6
        lblDepartureDateTicket.Text = "Depart Date:"
        lblDepartureDateTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbxFlightTicket
        ' 
        cbxFlightTicket.FormattingEnabled = True
        cbxFlightTicket.Location = New Point(158, 115)
        cbxFlightTicket.Margin = New Padding(3, 2, 3, 2)
        cbxFlightTicket.Name = "cbxFlightTicket"
        cbxFlightTicket.Size = New Size(203, 23)
        cbxFlightTicket.TabIndex = 5
        ' 
        ' lblFlightTicket
        ' 
        lblFlightTicket.AutoSize = True
        lblFlightTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFlightTicket.Location = New Point(45, 114)
        lblFlightTicket.Name = "lblFlightTicket"
        lblFlightTicket.Size = New Size(52, 20)
        lblFlightTicket.TabIndex = 4
        lblFlightTicket.Text = "Flight:"
        ' 
        ' cbxPassengerTicket
        ' 
        cbxPassengerTicket.FormattingEnabled = True
        cbxPassengerTicket.Location = New Point(158, 74)
        cbxPassengerTicket.Margin = New Padding(3, 2, 3, 2)
        cbxPassengerTicket.Name = "cbxPassengerTicket"
        cbxPassengerTicket.Size = New Size(203, 23)
        cbxPassengerTicket.TabIndex = 3
        ' 
        ' lblSelectPassengerTicket
        ' 
        lblSelectPassengerTicket.AutoSize = True
        lblSelectPassengerTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectPassengerTicket.Location = New Point(45, 74)
        lblSelectPassengerTicket.Name = "lblSelectPassengerTicket"
        lblSelectPassengerTicket.Size = New Size(83, 20)
        lblSelectPassengerTicket.TabIndex = 2
        lblSelectPassengerTicket.Text = "Passenger:"
        ' 
        ' gbxBookingDetailsTicket
        ' 
        gbxBookingDetailsTicket.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxBookingDetailsTicket.Location = New Point(20, 9)
        gbxBookingDetailsTicket.Margin = New Padding(3, 2, 3, 2)
        gbxBookingDetailsTicket.Name = "gbxBookingDetailsTicket"
        gbxBookingDetailsTicket.Padding = New Padding(3, 2, 3, 2)
        gbxBookingDetailsTicket.Size = New Size(612, 258)
        gbxBookingDetailsTicket.TabIndex = 36
        gbxBookingDetailsTicket.TabStop = False
        gbxBookingDetailsTicket.Text = "Booking Details"
        ' 
        ' gxbCustomerDataTickets
        ' 
        gxbCustomerDataTickets.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gxbCustomerDataTickets.Location = New Point(20, 272)
        gxbCustomerDataTickets.Margin = New Padding(3, 2, 3, 2)
        gxbCustomerDataTickets.Name = "gxbCustomerDataTickets"
        gxbCustomerDataTickets.Padding = New Padding(3, 2, 3, 2)
        gxbCustomerDataTickets.Size = New Size(612, 196)
        gxbCustomerDataTickets.TabIndex = 37
        gxbCustomerDataTickets.TabStop = False
        gxbCustomerDataTickets.Text = "Customer Data"
        ' 
        ' btnResetTicket
        ' 
        btnResetTicket.Location = New Point(1135, 596)
        btnResetTicket.Margin = New Padding(3, 2, 3, 2)
        btnResetTicket.Name = "btnResetTicket"
        btnResetTicket.Size = New Size(170, 44)
        btnResetTicket.TabIndex = 9
        btnResetTicket.Text = "RESET"
        btnResetTicket.UseVisualStyleBackColor = True
        ' 
        ' btnProcessTicket
        ' 
        btnProcessTicket.Location = New Point(948, 596)
        btnProcessTicket.Margin = New Padding(3, 2, 3, 2)
        btnProcessTicket.Name = "btnProcessTicket"
        btnProcessTicket.Size = New Size(170, 44)
        btnProcessTicket.TabIndex = 8
        btnProcessTicket.Text = "PROCESS TICKET"
        btnProcessTicket.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(394, 16)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 44)
        Button1.TabIndex = 10
        Button1.Text = "TICKET"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1352, 682)
        Controls.Add(Button1)
        Controls.Add(btnResetTicket)
        Controls.Add(btnProcessTicket)
        Controls.Add(pnlRightInfo)
        Controls.Add(pnlleftInfo)
        Controls.Add(btnTicket)
        Controls.Add(btnBooking)
        Controls.Add(lblMainBooking)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        Text = "Form2"
        pnlRightInfo.ResumeLayout(False)
        gbxPaymentTicket.ResumeLayout(False)
        gbxPaymentTicket.PerformLayout()
        gbxSummaryTickets.ResumeLayout(False)
        pnlleftInfo.ResumeLayout(False)
        pnlleftInfo.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnTicket As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents lblMainBooking As Label
    Friend WithEvents pnlRightInfo As Panel
    Friend WithEvents pnlleftInfo As Panel
    Friend WithEvents lblGenderTicket As Label
    Friend WithEvents lblPassengersTicket As Label
    Friend WithEvents lblDestinationTicket As Label
    Friend WithEvents lblFullnameTicket As Label
    Friend WithEvents lblBookingDateTicket As Label
    Friend WithEvents lblArrivalDate As Label
    Friend WithEvents lblDepartureDateTicket As Label
    Friend WithEvents cbxFlightTicket As ComboBox
    Friend WithEvents lblFlightTicket As Label
    Friend WithEvents cbxPassengerTicket As ComboBox
    Friend WithEvents lblSelectPassengerTicket As Label
    Friend WithEvents btnResetTicket As Button
    Friend WithEvents btnProcessTicket As Button
    Friend WithEvents cbxClassTicket As ComboBox
    Friend WithEvents lblClassTicket As Label
    Friend WithEvents lblDepartureTimeTicket As Label
    Friend WithEvents lblArrivalTimeTicket As Label
    Friend WithEvents lblArrivalDateTicket As Label
    Friend WithEvents lblSeatNumberTicket As Label
    Friend WithEvents lblAddressTicket As Label
    Friend WithEvents gxbCustomerDataTickets As GroupBox
    Friend WithEvents gbxBookingDetailsTicket As GroupBox
    Friend WithEvents gbxSummaryTickets As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTaxTicket As Label
    Friend WithEvents lblTicketAmountTicket As Label
    Friend WithEvents lblTotalTicket As Label
    Friend WithEvents lblBrokenLineTicket As Label
    Friend WithEvents gbxPaymentTicket As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPaymentAmountTicket As Label
    Friend WithEvents tbxTicketPayment As TextBox
    Friend WithEvents Button1 As Button
End Class
