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
        btnSupport = New Button()
        pnlRightInfo.SuspendLayout()
        gbxPaymentTicket.SuspendLayout()
        gbxSummaryTickets.SuspendLayout()
        pnlleftInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(301, 27)
        btnTicket.Margin = New Padding(4, 3, 4, 3)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(243, 73)
        btnTicket.TabIndex = 5
        btnTicket.Text = "TICKET"
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(34, 27)
        btnBooking.Margin = New Padding(4, 3, 4, 3)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(243, 73)
        btnBooking.TabIndex = 4
        btnBooking.Text = "BOOKING"
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' lblMainBooking
        ' 
        lblMainBooking.BackColor = SystemColors.ActiveCaption
        lblMainBooking.Location = New Point(34, 122)
        lblMainBooking.Margin = New Padding(4, 0, 4, 0)
        lblMainBooking.Name = "lblMainBooking"
        lblMainBooking.Size = New Size(1863, 990)
        lblMainBooking.TabIndex = 3
        ' 
        ' pnlRightInfo
        ' 
        pnlRightInfo.BackColor = Color.Snow
        pnlRightInfo.Controls.Add(gbxPaymentTicket)
        pnlRightInfo.Controls.Add(btnCalculate)
        pnlRightInfo.Controls.Add(gbxSummaryTickets)
        pnlRightInfo.Location = New Point(1054, 153)
        pnlRightInfo.Margin = New Padding(4, 3, 4, 3)
        pnlRightInfo.Name = "pnlRightInfo"
        pnlRightInfo.Size = New Size(810, 803)
        pnlRightInfo.TabIndex = 7
        ' 
        ' gbxPaymentTicket
        ' 
        gbxPaymentTicket.Controls.Add(tbxTicketPayment)
        gbxPaymentTicket.Controls.Add(Label1)
        gbxPaymentTicket.Controls.Add(Label2)
        gbxPaymentTicket.Controls.Add(lblPaymentAmountTicket)
        gbxPaymentTicket.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxPaymentTicket.Location = New Point(56, 333)
        gbxPaymentTicket.Margin = New Padding(4, 3, 4, 3)
        gbxPaymentTicket.Name = "gbxPaymentTicket"
        gbxPaymentTicket.Padding = New Padding(4, 3, 4, 3)
        gbxPaymentTicket.Size = New Size(699, 372)
        gbxPaymentTicket.TabIndex = 38
        gbxPaymentTicket.TabStop = False
        gbxPaymentTicket.Text = "Payment"
        ' 
        ' tbxTicketPayment
        ' 
        tbxTicketPayment.Anchor = AnchorStyles.None
        tbxTicketPayment.Location = New Point(291, 123)
        tbxTicketPayment.Margin = New Padding(4, 3, 4, 3)
        tbxTicketPayment.MaximumSize = New Size(308, 30)
        tbxTicketPayment.Name = "tbxTicketPayment"
        tbxTicketPayment.Size = New Size(308, 60)
        tbxTicketPayment.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(130, 230)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(481, 50)
        Label1.TabIndex = 6
        Label1.Text = "Change:"
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ControlDarkDark
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(121, 197)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(500, 3)
        Label2.TabIndex = 5
        ' 
        ' lblPaymentAmountTicket
        ' 
        lblPaymentAmountTicket.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPaymentAmountTicket.Location = New Point(60, 120)
        lblPaymentAmountTicket.Margin = New Padding(4, 0, 4, 0)
        lblPaymentAmountTicket.Name = "lblPaymentAmountTicket"
        lblPaymentAmountTicket.Size = New Size(231, 42)
        lblPaymentAmountTicket.TabIndex = 3
        lblPaymentAmountTicket.Text = "Ticket Payment:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Silver
        btnCalculate.Location = New Point(554, 717)
        btnCalculate.Margin = New Padding(4, 3, 4, 3)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(201, 73)
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
        gbxSummaryTickets.Location = New Point(31, 13)
        gbxSummaryTickets.Margin = New Padding(4, 3, 4, 3)
        gbxSummaryTickets.Name = "gbxSummaryTickets"
        gbxSummaryTickets.Padding = New Padding(4, 3, 4, 3)
        gbxSummaryTickets.Size = New Size(754, 313)
        gbxSummaryTickets.TabIndex = 37
        gbxSummaryTickets.TabStop = False
        gbxSummaryTickets.Text = "Summary"
        ' 
        ' lblTotalTicket
        ' 
        lblTotalTicket.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalTicket.Location = New Point(114, 247)
        lblTotalTicket.Margin = New Padding(4, 0, 4, 0)
        lblTotalTicket.Name = "lblTotalTicket"
        lblTotalTicket.Size = New Size(481, 32)
        lblTotalTicket.TabIndex = 6
        lblTotalTicket.Text = "Total:"
        ' 
        ' lblBrokenLineTicket
        ' 
        lblBrokenLineTicket.BackColor = SystemColors.ControlDarkDark
        lblBrokenLineTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBrokenLineTicket.Location = New Point(117, 220)
        lblBrokenLineTicket.Margin = New Padding(4, 0, 4, 0)
        lblBrokenLineTicket.Name = "lblBrokenLineTicket"
        lblBrokenLineTicket.Size = New Size(500, 3)
        lblBrokenLineTicket.TabIndex = 5
        ' 
        ' lblTaxTicket
        ' 
        lblTaxTicket.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTaxTicket.Location = New Point(114, 157)
        lblTaxTicket.Margin = New Padding(4, 0, 4, 0)
        lblTaxTicket.Name = "lblTaxTicket"
        lblTaxTicket.Size = New Size(481, 32)
        lblTaxTicket.TabIndex = 4
        lblTaxTicket.Text = "Tax:"
        ' 
        ' lblTicketAmountTicket
        ' 
        lblTicketAmountTicket.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTicketAmountTicket.Location = New Point(114, 95)
        lblTicketAmountTicket.Margin = New Padding(4, 0, 4, 0)
        lblTicketAmountTicket.Name = "lblTicketAmountTicket"
        lblTicketAmountTicket.Size = New Size(481, 32)
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
        pnlleftInfo.Location = New Point(74, 153)
        pnlleftInfo.Margin = New Padding(4, 3, 4, 3)
        pnlleftInfo.Name = "pnlleftInfo"
        pnlleftInfo.Size = New Size(930, 803)
        pnlleftInfo.TabIndex = 6
        ' 
        ' lblAddressTicket
        ' 
        lblAddressTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddressTicket.Location = New Point(64, 648)
        lblAddressTicket.Margin = New Padding(4, 0, 4, 0)
        lblAddressTicket.Name = "lblAddressTicket"
        lblAddressTicket.Size = New Size(491, 32)
        lblAddressTicket.TabIndex = 35
        lblAddressTicket.Text = "Address:"
        lblAddressTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSeatNumberTicket
        ' 
        lblSeatNumberTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeatNumberTicket.Location = New Point(606, 682)
        lblSeatNumberTicket.Margin = New Padding(4, 0, 4, 0)
        lblSeatNumberTicket.Name = "lblSeatNumberTicket"
        lblSeatNumberTicket.Size = New Size(174, 32)
        lblSeatNumberTicket.TabIndex = 34
        lblSeatNumberTicket.Text = "Seat #:"
        ' 
        ' lblArrivalTimeTicket
        ' 
        lblArrivalTimeTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalTimeTicket.Location = New Point(549, 393)
        lblArrivalTimeTicket.Margin = New Padding(4, 0, 4, 0)
        lblArrivalTimeTicket.Name = "lblArrivalTimeTicket"
        lblArrivalTimeTicket.Size = New Size(324, 32)
        lblArrivalTimeTicket.TabIndex = 31
        lblArrivalTimeTicket.Text = "Arrival Time:"
        lblArrivalTimeTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblArrivalDateTicket
        ' 
        lblArrivalDateTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalDateTicket.Location = New Point(549, 333)
        lblArrivalDateTicket.Margin = New Padding(4, 0, 4, 0)
        lblArrivalDateTicket.Name = "lblArrivalDateTicket"
        lblArrivalDateTicket.Size = New Size(324, 32)
        lblArrivalDateTicket.TabIndex = 30
        lblArrivalDateTicket.Text = "Arrival Date:"
        lblArrivalDateTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDepartureTimeTicket
        ' 
        lblDepartureTimeTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureTimeTicket.Location = New Point(64, 393)
        lblDepartureTimeTicket.Margin = New Padding(4, 0, 4, 0)
        lblDepartureTimeTicket.Name = "lblDepartureTimeTicket"
        lblDepartureTimeTicket.Size = New Size(451, 32)
        lblDepartureTimeTicket.TabIndex = 29
        lblDepartureTimeTicket.Text = "Depart Time:"
        lblDepartureTimeTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbxClassTicket
        ' 
        cbxClassTicket.FormattingEnabled = True
        cbxClassTicket.Location = New Point(226, 267)
        cbxClassTicket.Margin = New Padding(4, 3, 4, 3)
        cbxClassTicket.Name = "cbxClassTicket"
        cbxClassTicket.Size = New Size(288, 33)
        cbxClassTicket.TabIndex = 28
        ' 
        ' lblClassTicket
        ' 
        lblClassTicket.AutoSize = True
        lblClassTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblClassTicket.Location = New Point(64, 265)
        lblClassTicket.Margin = New Padding(4, 0, 4, 0)
        lblClassTicket.Name = "lblClassTicket"
        lblClassTicket.Size = New Size(67, 30)
        lblClassTicket.TabIndex = 27
        lblClassTicket.Text = "Class:"
        ' 
        ' lblGenderTicket
        ' 
        lblGenderTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGenderTicket.Location = New Point(606, 515)
        lblGenderTicket.Margin = New Padding(4, 0, 4, 0)
        lblGenderTicket.Name = "lblGenderTicket"
        lblGenderTicket.Size = New Size(253, 32)
        lblGenderTicket.TabIndex = 25
        lblGenderTicket.Text = "Gender:"
        lblGenderTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPassengersTicket
        ' 
        lblPassengersTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassengersTicket.Location = New Point(606, 600)
        lblPassengersTicket.Margin = New Padding(4, 0, 4, 0)
        lblPassengersTicket.Name = "lblPassengersTicket"
        lblPassengersTicket.Size = New Size(284, 32)
        lblPassengersTicket.TabIndex = 19
        lblPassengersTicket.Text = "No. of Passengers:"
        lblPassengersTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDestinationTicket
        ' 
        lblDestinationTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestinationTicket.Location = New Point(64, 717)
        lblDestinationTicket.Margin = New Padding(4, 0, 4, 0)
        lblDestinationTicket.Name = "lblDestinationTicket"
        lblDestinationTicket.Size = New Size(493, 32)
        lblDestinationTicket.TabIndex = 15
        lblDestinationTicket.Text = "Destination:"
        lblDestinationTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblFullnameTicket
        ' 
        lblFullnameTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullnameTicket.Location = New Point(63, 583)
        lblFullnameTicket.Margin = New Padding(4, 0, 4, 0)
        lblFullnameTicket.Name = "lblFullnameTicket"
        lblFullnameTicket.Size = New Size(493, 32)
        lblFullnameTicket.TabIndex = 13
        lblFullnameTicket.Text = "Fullname:"
        lblFullnameTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBookingDateTicket
        ' 
        lblBookingDateTicket.BackColor = Color.Gainsboro
        lblBookingDateTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookingDateTicket.Location = New Point(64, 515)
        lblBookingDateTicket.Margin = New Padding(4, 0, 4, 0)
        lblBookingDateTicket.Name = "lblBookingDateTicket"
        lblBookingDateTicket.Size = New Size(493, 32)
        lblBookingDateTicket.TabIndex = 11
        lblBookingDateTicket.Text = "Booking Date:"
        lblBookingDateTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDepartureDateTicket
        ' 
        lblDepartureDateTicket.BackColor = Color.Snow
        lblDepartureDateTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureDateTicket.Location = New Point(64, 333)
        lblDepartureDateTicket.Margin = New Padding(4, 0, 4, 0)
        lblDepartureDateTicket.Name = "lblDepartureDateTicket"
        lblDepartureDateTicket.Size = New Size(451, 32)
        lblDepartureDateTicket.TabIndex = 6
        lblDepartureDateTicket.Text = "Depart Date:"
        lblDepartureDateTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbxFlightTicket
        ' 
        cbxFlightTicket.FormattingEnabled = True
        cbxFlightTicket.Location = New Point(226, 192)
        cbxFlightTicket.Margin = New Padding(4, 3, 4, 3)
        cbxFlightTicket.Name = "cbxFlightTicket"
        cbxFlightTicket.Size = New Size(288, 33)
        cbxFlightTicket.TabIndex = 5
        ' 
        ' lblFlightTicket
        ' 
        lblFlightTicket.AutoSize = True
        lblFlightTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFlightTicket.Location = New Point(64, 190)
        lblFlightTicket.Margin = New Padding(4, 0, 4, 0)
        lblFlightTicket.Name = "lblFlightTicket"
        lblFlightTicket.Size = New Size(75, 30)
        lblFlightTicket.TabIndex = 4
        lblFlightTicket.Text = "Flight:"
        ' 
        ' cbxPassengerTicket
        ' 
        cbxPassengerTicket.FormattingEnabled = True
        cbxPassengerTicket.Location = New Point(226, 123)
        cbxPassengerTicket.Margin = New Padding(4, 3, 4, 3)
        cbxPassengerTicket.Name = "cbxPassengerTicket"
        cbxPassengerTicket.Size = New Size(288, 33)
        cbxPassengerTicket.TabIndex = 3
        ' 
        ' lblSelectPassengerTicket
        ' 
        lblSelectPassengerTicket.AutoSize = True
        lblSelectPassengerTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectPassengerTicket.Location = New Point(64, 123)
        lblSelectPassengerTicket.Margin = New Padding(4, 0, 4, 0)
        lblSelectPassengerTicket.Name = "lblSelectPassengerTicket"
        lblSelectPassengerTicket.Size = New Size(118, 30)
        lblSelectPassengerTicket.TabIndex = 2
        lblSelectPassengerTicket.Text = "Passenger:"
        ' 
        ' gbxBookingDetailsTicket
        ' 
        gbxBookingDetailsTicket.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbxBookingDetailsTicket.Location = New Point(29, 15)
        gbxBookingDetailsTicket.Margin = New Padding(4, 3, 4, 3)
        gbxBookingDetailsTicket.Name = "gbxBookingDetailsTicket"
        gbxBookingDetailsTicket.Padding = New Padding(4, 3, 4, 3)
        gbxBookingDetailsTicket.Size = New Size(874, 430)
        gbxBookingDetailsTicket.TabIndex = 36
        gbxBookingDetailsTicket.TabStop = False
        gbxBookingDetailsTicket.Text = "Booking Details"
        ' 
        ' gxbCustomerDataTickets
        ' 
        gxbCustomerDataTickets.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gxbCustomerDataTickets.Location = New Point(29, 453)
        gxbCustomerDataTickets.Margin = New Padding(4, 3, 4, 3)
        gxbCustomerDataTickets.Name = "gxbCustomerDataTickets"
        gxbCustomerDataTickets.Padding = New Padding(4, 3, 4, 3)
        gxbCustomerDataTickets.Size = New Size(874, 327)
        gxbCustomerDataTickets.TabIndex = 37
        gxbCustomerDataTickets.TabStop = False
        gxbCustomerDataTickets.Text = "Customer Data"
        ' 
        ' btnResetTicket
        ' 
        btnResetTicket.Location = New Point(1621, 993)
        btnResetTicket.Margin = New Padding(4, 3, 4, 3)
        btnResetTicket.Name = "btnResetTicket"
        btnResetTicket.Size = New Size(243, 73)
        btnResetTicket.TabIndex = 9
        btnResetTicket.Text = "RESET"
        btnResetTicket.UseVisualStyleBackColor = True
        ' 
        ' btnProcessTicket
        ' 
        btnProcessTicket.Location = New Point(1354, 993)
        btnProcessTicket.Margin = New Padding(4, 3, 4, 3)
        btnProcessTicket.Name = "btnProcessTicket"
        btnProcessTicket.Size = New Size(243, 73)
        btnProcessTicket.TabIndex = 8
        btnProcessTicket.Text = "PROCESS TICKET"
        btnProcessTicket.UseVisualStyleBackColor = True
        ' 
        ' btnSupport
        ' 
        btnSupport.Location = New Point(563, 27)
        btnSupport.Margin = New Padding(4, 3, 4, 3)
        btnSupport.Name = "btnSupport"
        btnSupport.Size = New Size(243, 73)
        btnSupport.TabIndex = 10
        btnSupport.Text = "SUPPORT"
        btnSupport.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1931, 1137)
        Controls.Add(btnSupport)
        Controls.Add(btnResetTicket)
        Controls.Add(btnProcessTicket)
        Controls.Add(pnlRightInfo)
        Controls.Add(pnlleftInfo)
        Controls.Add(btnTicket)
        Controls.Add(btnBooking)
        Controls.Add(lblMainBooking)
        Margin = New Padding(4, 3, 4, 3)
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
    Friend WithEvents btnSupport As Button
End Class
