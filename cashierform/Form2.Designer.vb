<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnTicket = New Button()
        btnBooking = New Button()
        lblMainBooking = New Label()
        pnlRightInfo = New Panel()
        btnCalculateTicket = New Button()
        lblPassengers = New Label()
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
        lblCustomerData = New Label()
        lblDepartureDateTicket = New Label()
        cbxFlightTicket = New ComboBox()
        lblFlightTicket = New Label()
        cbxPassengerTicket = New ComboBox()
        lblSelectPassengerTicket = New Label()
        lblBookingDetailsForm2 = New Label()
        btnResetTicket = New Button()
        btnProcessTicket = New Button()
        pnlRightInfo.SuspendLayout()
        pnlleftInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(301, 26)
        btnTicket.Margin = New Padding(4)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(242, 72)
        btnTicket.TabIndex = 5
        btnTicket.Text = "TICKET"
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(34, 28)
        btnBooking.Margin = New Padding(4)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(242, 72)
        btnBooking.TabIndex = 4
        btnBooking.Text = "BOOKING"
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' lblMainBooking
        ' 
        lblMainBooking.BackColor = SystemColors.ActiveCaption
        lblMainBooking.Location = New Point(34, 121)
        lblMainBooking.Margin = New Padding(4, 0, 4, 0)
        lblMainBooking.Name = "lblMainBooking"
        lblMainBooking.Size = New Size(1862, 990)
        lblMainBooking.TabIndex = 3
        ' 
        ' pnlRightInfo
        ' 
        pnlRightInfo.BackColor = Color.Snow
        pnlRightInfo.Controls.Add(btnCalculateTicket)
        pnlRightInfo.Controls.Add(lblPassengers)
        pnlRightInfo.Location = New Point(1054, 152)
        pnlRightInfo.Margin = New Padding(4)
        pnlRightInfo.Name = "pnlRightInfo"
        pnlRightInfo.Size = New Size(810, 802)
        pnlRightInfo.TabIndex = 7
        ' 
        ' btnCalculateTicket
        ' 
        btnCalculateTicket.BackColor = Color.Silver
        btnCalculateTicket.Location = New Point(544, 698)
        btnCalculateTicket.Margin = New Padding(4)
        btnCalculateTicket.Name = "btnCalculateTicket"
        btnCalculateTicket.Size = New Size(201, 72)
        btnCalculateTicket.TabIndex = 11
        btnCalculateTicket.Text = "CALCULATE"
        btnCalculateTicket.UseVisualStyleBackColor = False
        ' 
        ' lblPassengers
        ' 
        lblPassengers.AutoSize = True
        lblPassengers.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassengers.Location = New Point(52, 39)
        lblPassengers.Margin = New Padding(4, 0, 4, 0)
        lblPassengers.Name = "lblPassengers"
        lblPassengers.Size = New Size(169, 45)
        lblPassengers.TabIndex = 1
        lblPassengers.Text = "Summary"
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
        pnlleftInfo.Controls.Add(lblCustomerData)
        pnlleftInfo.Controls.Add(lblDepartureDateTicket)
        pnlleftInfo.Controls.Add(cbxFlightTicket)
        pnlleftInfo.Controls.Add(lblFlightTicket)
        pnlleftInfo.Controls.Add(cbxPassengerTicket)
        pnlleftInfo.Controls.Add(lblSelectPassengerTicket)
        pnlleftInfo.Controls.Add(lblBookingDetailsForm2)
        pnlleftInfo.Location = New Point(75, 152)
        pnlleftInfo.Margin = New Padding(4)
        pnlleftInfo.Name = "pnlleftInfo"
        pnlleftInfo.Size = New Size(930, 802)
        pnlleftInfo.TabIndex = 6
        ' 
        ' lblAddressTicket
        ' 
        lblAddressTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddressTicket.Location = New Point(64, 649)
        lblAddressTicket.Margin = New Padding(4, 0, 4, 0)
        lblAddressTicket.Name = "lblAddressTicket"
        lblAddressTicket.Size = New Size(491, 31)
        lblAddressTicket.TabIndex = 35
        lblAddressTicket.Text = "Address:"
        lblAddressTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSeatNumberTicket
        ' 
        lblSeatNumberTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeatNumberTicket.Location = New Point(606, 681)
        lblSeatNumberTicket.Margin = New Padding(4, 0, 4, 0)
        lblSeatNumberTicket.Name = "lblSeatNumberTicket"
        lblSeatNumberTicket.Size = New Size(174, 31)
        lblSeatNumberTicket.TabIndex = 34
        lblSeatNumberTicket.Text = "Seat #:"
        ' 
        ' lblArrivalTimeTicket
        ' 
        lblArrivalTimeTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalTimeTicket.Location = New Point(549, 392)
        lblArrivalTimeTicket.Margin = New Padding(4, 0, 4, 0)
        lblArrivalTimeTicket.Name = "lblArrivalTimeTicket"
        lblArrivalTimeTicket.Size = New Size(324, 31)
        lblArrivalTimeTicket.TabIndex = 31
        lblArrivalTimeTicket.Text = "Arrival Time:"
        lblArrivalTimeTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblArrivalDateTicket
        ' 
        lblArrivalDateTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalDateTicket.Location = New Point(549, 332)
        lblArrivalDateTicket.Margin = New Padding(4, 0, 4, 0)
        lblArrivalDateTicket.Name = "lblArrivalDateTicket"
        lblArrivalDateTicket.Size = New Size(324, 31)
        lblArrivalDateTicket.TabIndex = 30
        lblArrivalDateTicket.Text = "Arrival Date:"
        lblArrivalDateTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDepartureTimeTicket
        ' 
        lblDepartureTimeTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureTimeTicket.Location = New Point(64, 392)
        lblDepartureTimeTicket.Margin = New Padding(4, 0, 4, 0)
        lblDepartureTimeTicket.Name = "lblDepartureTimeTicket"
        lblDepartureTimeTicket.Size = New Size(451, 31)
        lblDepartureTimeTicket.TabIndex = 29
        lblDepartureTimeTicket.Text = "Depart Time:"
        lblDepartureTimeTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbxClassTicket
        ' 
        cbxClassTicket.FormattingEnabled = True
        cbxClassTicket.Location = New Point(226, 266)
        cbxClassTicket.Margin = New Padding(4)
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
        lblGenderTicket.Size = New Size(252, 31)
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
        lblPassengersTicket.Size = New Size(284, 31)
        lblPassengersTicket.TabIndex = 19
        lblPassengersTicket.Text = "No. of Passengers:"
        lblPassengersTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDestinationTicket
        ' 
        lblDestinationTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestinationTicket.Location = New Point(64, 716)
        lblDestinationTicket.Margin = New Padding(4, 0, 4, 0)
        lblDestinationTicket.Name = "lblDestinationTicket"
        lblDestinationTicket.Size = New Size(492, 31)
        lblDestinationTicket.TabIndex = 15
        lblDestinationTicket.Text = "Destination:"
        lblDestinationTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblFullnameTicket
        ' 
        lblFullnameTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullnameTicket.Location = New Point(62, 582)
        lblFullnameTicket.Margin = New Padding(4, 0, 4, 0)
        lblFullnameTicket.Name = "lblFullnameTicket"
        lblFullnameTicket.Size = New Size(492, 31)
        lblFullnameTicket.TabIndex = 13
        lblFullnameTicket.Text = "Fullname:"
        lblFullnameTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBookingDateTicket
        ' 
        lblBookingDateTicket.BackColor = Color.Gainsboro
        lblBookingDateTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookingDateTicket.Location = New Point(62, 515)
        lblBookingDateTicket.Margin = New Padding(4, 0, 4, 0)
        lblBookingDateTicket.Name = "lblBookingDateTicket"
        lblBookingDateTicket.Size = New Size(492, 31)
        lblBookingDateTicket.TabIndex = 11
        lblBookingDateTicket.Text = "Booking Date:"
        lblBookingDateTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCustomerData
        ' 
        lblCustomerData.AutoSize = True
        lblCustomerData.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerData.Location = New Point(48, 444)
        lblCustomerData.Margin = New Padding(4, 0, 4, 0)
        lblCustomerData.Name = "lblCustomerData"
        lblCustomerData.Size = New Size(252, 45)
        lblCustomerData.TabIndex = 10
        lblCustomerData.Text = "Customer Data"
        ' 
        ' lblDepartureDateTicket
        ' 
        lblDepartureDateTicket.BackColor = Color.Snow
        lblDepartureDateTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartureDateTicket.Location = New Point(64, 332)
        lblDepartureDateTicket.Margin = New Padding(4, 0, 4, 0)
        lblDepartureDateTicket.Name = "lblDepartureDateTicket"
        lblDepartureDateTicket.Size = New Size(451, 31)
        lblDepartureDateTicket.TabIndex = 6
        lblDepartureDateTicket.Text = "Depart Date:"
        lblDepartureDateTicket.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbxFlightTicket
        ' 
        cbxFlightTicket.FormattingEnabled = True
        cbxFlightTicket.Location = New Point(226, 191)
        cbxFlightTicket.Margin = New Padding(4)
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
        cbxPassengerTicket.Location = New Point(226, 122)
        cbxPassengerTicket.Margin = New Padding(4)
        cbxPassengerTicket.Name = "cbxPassengerTicket"
        cbxPassengerTicket.Size = New Size(288, 33)
        cbxPassengerTicket.TabIndex = 3
        ' 
        ' lblSelectPassengerTicket
        ' 
        lblSelectPassengerTicket.AutoSize = True
        lblSelectPassengerTicket.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSelectPassengerTicket.Location = New Point(64, 122)
        lblSelectPassengerTicket.Margin = New Padding(4, 0, 4, 0)
        lblSelectPassengerTicket.Name = "lblSelectPassengerTicket"
        lblSelectPassengerTicket.Size = New Size(118, 30)
        lblSelectPassengerTicket.TabIndex = 2
        lblSelectPassengerTicket.Text = "Passenger:"
        ' 
        ' lblBookingDetailsForm2
        ' 
        lblBookingDetailsForm2.AutoSize = True
        lblBookingDetailsForm2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookingDetailsForm2.Location = New Point(48, 39)
        lblBookingDetailsForm2.Margin = New Padding(4, 0, 4, 0)
        lblBookingDetailsForm2.Name = "lblBookingDetailsForm2"
        lblBookingDetailsForm2.Size = New Size(263, 45)
        lblBookingDetailsForm2.TabIndex = 0
        lblBookingDetailsForm2.Text = "Booking Details"
        ' 
        ' btnResetTicket
        ' 
        btnResetTicket.Location = New Point(1621, 994)
        btnResetTicket.Margin = New Padding(4)
        btnResetTicket.Name = "btnResetTicket"
        btnResetTicket.Size = New Size(242, 72)
        btnResetTicket.TabIndex = 9
        btnResetTicket.Text = "RESET"
        btnResetTicket.UseVisualStyleBackColor = True
        ' 
        ' btnProcessTicket
        ' 
        btnProcessTicket.Location = New Point(1354, 994)
        btnProcessTicket.Margin = New Padding(4)
        btnProcessTicket.Name = "btnProcessTicket"
        btnProcessTicket.Size = New Size(242, 72)
        btnProcessTicket.TabIndex = 8
        btnProcessTicket.Text = "PROCESS TICKET"
        btnProcessTicket.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1931, 1138)
        Controls.Add(btnResetTicket)
        Controls.Add(btnProcessTicket)
        Controls.Add(pnlRightInfo)
        Controls.Add(pnlleftInfo)
        Controls.Add(btnTicket)
        Controls.Add(btnBooking)
        Controls.Add(lblMainBooking)
        Margin = New Padding(4)
        Name = "Form2"
        Text = "Form2"
        pnlRightInfo.ResumeLayout(False)
        pnlRightInfo.PerformLayout()
        pnlleftInfo.ResumeLayout(False)
        pnlleftInfo.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnTicket As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents lblMainBooking As Label
    Friend WithEvents pnlRightInfo As Panel
    Friend WithEvents lblPassengers As Label
    Friend WithEvents pnlleftInfo As Panel
    Friend WithEvents lblGenderTicket As Label
    Friend WithEvents lblPassengersTicket As Label
    Friend WithEvents lblDestinationTicket As Label
    Friend WithEvents lblFullnameTicket As Label
    Friend WithEvents lblBookingDateTicket As Label
    Friend WithEvents lblCustomerData As Label
    Friend WithEvents lblArrivalDate As Label
    Friend WithEvents lblDepartureDateTicket As Label
    Friend WithEvents cbxFlightTicket As ComboBox
    Friend WithEvents lblFlightTicket As Label
    Friend WithEvents cbxPassengerTicket As ComboBox
    Friend WithEvents lblSelectPassengerTicket As Label
    Friend WithEvents lblBookingDetailsForm2 As Label
    Friend WithEvents btnResetTicket As Button
    Friend WithEvents btnProcessTicket As Button
    Friend WithEvents cbxClassTicket As ComboBox
    Friend WithEvents lblClassTicket As Label
    Friend WithEvents lblDepartureTimeTicket As Label
    Friend WithEvents lblArrivalTimeTicket As Label
    Friend WithEvents lblArrivalDateTicket As Label
    Friend WithEvents lblSeatNumberTicket As Label
    Friend WithEvents lblAddressTicket As Label
    Friend WithEvents btnCalculateTicket As Button
End Class
