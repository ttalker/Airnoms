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
        components = New ComponentModel.Container()
        btnTicket = New Button()
        btnBooking = New Button()
        tbxTicketPayment = New TextBox()
        btnCalculate = New Button()
        cbxPassengerTicket = New ComboBox()
        btnProcessTicket = New Button()
        btnSupport = New Button()
        pbxCashierTicket = New PictureBox()
        btnExit = New Button()
        btnNextTicket = New Button()
        btnResetTicket = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        lblDepartDateTicket = New Label()
        lblArrivalDateTicket = New Label()
        lblDepartTimeTicket = New Label()
        lblArrivalTimeTicket = New Label()
        lblGenderTicket = New Label()
        lblDateOfBirthTicket = New Label()
        lblFullNameTicket = New Label()
        lblBookingDateTicket = New Label()
        lblBaggageAllowanceTicket = New Label()
        lblDestinationTicket = New Label()
        lblSeatNumTicket = New Label()
        lblBookedUnderTicket = New Label()
        lblAdressTicket = New Label()
        lblPWDTicket = New Label()
        lblChangeTicket = New Label()
        lblTotalTicket = New Label()
        lblTaxTicket = New Label()
        lblTicketAmt = New Label()
        lblClass = New Label()
        CType(pbxCashierTicket, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(295, 29)
        btnTicket.Margin = New Padding(3, 2, 3, 2)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(178, 64)
        btnTicket.TabIndex = 5
        btnTicket.Text = " "
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(86, 27)
        btnBooking.Margin = New Padding(3, 2, 3, 2)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(177, 67)
        btnBooking.TabIndex = 4
        btnBooking.Text = " "
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' tbxTicketPayment
        ' 
        tbxTicketPayment.Anchor = AnchorStyles.None
        tbxTicketPayment.Location = New Point(1106, 588)
        tbxTicketPayment.Margin = New Padding(3, 2, 3, 2)
        tbxTicketPayment.MaximumSize = New Size(217, 30)
        tbxTicketPayment.Name = "tbxTicketPayment"
        tbxTicketPayment.Size = New Size(217, 23)
        tbxTicketPayment.TabIndex = 16
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Silver
        btnCalculate.Location = New Point(1248, 707)
        btnCalculate.Margin = New Padding(3, 2, 3, 2)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(185, 54)
        btnCalculate.TabIndex = 38
        btnCalculate.Text = " "
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' cbxPassengerTicket
        ' 
        cbxPassengerTicket.FormattingEnabled = True
        cbxPassengerTicket.Location = New Point(272, 270)
        cbxPassengerTicket.Margin = New Padding(3, 2, 3, 2)
        cbxPassengerTicket.Name = "cbxPassengerTicket"
        cbxPassengerTicket.Size = New Size(177, 23)
        cbxPassengerTicket.TabIndex = 3
        ' 
        ' btnProcessTicket
        ' 
        btnProcessTicket.Location = New Point(1275, 799)
        btnProcessTicket.Margin = New Padding(3, 2, 3, 2)
        btnProcessTicket.Name = "btnProcessTicket"
        btnProcessTicket.Size = New Size(182, 68)
        btnProcessTicket.TabIndex = 8
        btnProcessTicket.Text = " "
        btnProcessTicket.UseVisualStyleBackColor = True
        ' 
        ' btnSupport
        ' 
        btnSupport.Location = New Point(492, 29)
        btnSupport.Margin = New Padding(3, 2, 3, 2)
        btnSupport.Name = "btnSupport"
        btnSupport.Size = New Size(180, 63)
        btnSupport.TabIndex = 10
        btnSupport.Text = " "
        btnSupport.UseVisualStyleBackColor = True
        ' 
        ' pbxCashierTicket
        ' 
        pbxCashierTicket.BackgroundImage = My.Resources.Resources.TICKET_PAGE2
        pbxCashierTicket.Location = New Point(2, -1)
        pbxCashierTicket.Name = "pbxCashierTicket"
        pbxCashierTicket.Size = New Size(1551, 910)
        pbxCashierTicket.TabIndex = 39
        pbxCashierTicket.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(707, 30)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(143, 61)
        btnExit.TabIndex = 40
        btnExit.Text = " "
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnNextTicket
        ' 
        btnNextTicket.Location = New Point(1077, 800)
        btnNextTicket.Margin = New Padding(3, 2, 3, 2)
        btnNextTicket.Name = "btnNextTicket"
        btnNextTicket.Size = New Size(182, 68)
        btnNextTicket.TabIndex = 41
        btnNextTicket.Text = " "
        btnNextTicket.UseVisualStyleBackColor = True
        ' 
        ' btnResetTicket
        ' 
        btnResetTicket.Location = New Point(873, 800)
        btnResetTicket.Margin = New Padding(3, 2, 3, 2)
        btnResetTicket.Name = "btnResetTicket"
        btnResetTicket.Size = New Size(182, 68)
        btnResetTicket.TabIndex = 42
        btnResetTicket.Text = " "
        btnResetTicket.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' lblDepartDateTicket
        ' 
        lblDepartDateTicket.AutoSize = True
        lblDepartDateTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblDepartDateTicket.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDepartDateTicket.Location = New Point(272, 365)
        lblDepartDateTicket.Name = "lblDepartDateTicket"
        lblDepartDateTicket.Size = New Size(57, 25)
        lblDepartDateTicket.TabIndex = 43
        lblDepartDateTicket.Text = "Label1"
        ' 
        ' lblArrivalDateTicket
        ' 
        lblArrivalDateTicket.AutoSize = True
        lblArrivalDateTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblArrivalDateTicket.Font = New Font("Josefin Sans", 12F)
        lblArrivalDateTicket.Location = New Point(272, 419)
        lblArrivalDateTicket.Name = "lblArrivalDateTicket"
        lblArrivalDateTicket.Size = New Size(61, 25)
        lblArrivalDateTicket.TabIndex = 44
        lblArrivalDateTicket.Text = "Label2"
        ' 
        ' lblDepartTimeTicket
        ' 
        lblDepartTimeTicket.AutoSize = True
        lblDepartTimeTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblDepartTimeTicket.Font = New Font("Josefin Sans", 12F)
        lblDepartTimeTicket.Location = New Point(597, 364)
        lblDepartTimeTicket.Name = "lblDepartTimeTicket"
        lblDepartTimeTicket.Size = New Size(60, 25)
        lblDepartTimeTicket.TabIndex = 45
        lblDepartTimeTicket.Text = "Label3"
        ' 
        ' lblArrivalTimeTicket
        ' 
        lblArrivalTimeTicket.AutoSize = True
        lblArrivalTimeTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblArrivalTimeTicket.Font = New Font("Josefin Sans", 12F)
        lblArrivalTimeTicket.Location = New Point(597, 417)
        lblArrivalTimeTicket.Name = "lblArrivalTimeTicket"
        lblArrivalTimeTicket.Size = New Size(61, 25)
        lblArrivalTimeTicket.TabIndex = 46
        lblArrivalTimeTicket.Text = "Label4"
        ' 
        ' lblGenderTicket
        ' 
        lblGenderTicket.AutoSize = True
        lblGenderTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblGenderTicket.Font = New Font("Josefin Sans", 12F)
        lblGenderTicket.Location = New Point(269, 757)
        lblGenderTicket.Name = "lblGenderTicket"
        lblGenderTicket.Size = New Size(60, 25)
        lblGenderTicket.TabIndex = 50
        lblGenderTicket.Text = "Label5"
        ' 
        ' lblDateOfBirthTicket
        ' 
        lblDateOfBirthTicket.AutoSize = True
        lblDateOfBirthTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblDateOfBirthTicket.Font = New Font("Josefin Sans", 12F)
        lblDateOfBirthTicket.Location = New Point(269, 703)
        lblDateOfBirthTicket.Name = "lblDateOfBirthTicket"
        lblDateOfBirthTicket.Size = New Size(61, 25)
        lblDateOfBirthTicket.TabIndex = 49
        lblDateOfBirthTicket.Text = "Label6"
        ' 
        ' lblFullNameTicket
        ' 
        lblFullNameTicket.AutoSize = True
        lblFullNameTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblFullNameTicket.Font = New Font("Josefin Sans", 12F)
        lblFullNameTicket.Location = New Point(269, 655)
        lblFullNameTicket.Name = "lblFullNameTicket"
        lblFullNameTicket.Size = New Size(60, 25)
        lblFullNameTicket.TabIndex = 48
        lblFullNameTicket.Text = "Label7"
        ' 
        ' lblBookingDateTicket
        ' 
        lblBookingDateTicket.AutoSize = True
        lblBookingDateTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblBookingDateTicket.Font = New Font("Josefin Sans", 12F)
        lblBookingDateTicket.Location = New Point(269, 605)
        lblBookingDateTicket.Name = "lblBookingDateTicket"
        lblBookingDateTicket.Size = New Size(60, 25)
        lblBookingDateTicket.TabIndex = 47
        lblBookingDateTicket.Text = "Label8"
        ' 
        ' lblBaggageAllowanceTicket
        ' 
        lblBaggageAllowanceTicket.AutoSize = True
        lblBaggageAllowanceTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblBaggageAllowanceTicket.Font = New Font("Josefin Sans", 12F)
        lblBaggageAllowanceTicket.Location = New Point(608, 752)
        lblBaggageAllowanceTicket.Name = "lblBaggageAllowanceTicket"
        lblBaggageAllowanceTicket.Size = New Size(61, 25)
        lblBaggageAllowanceTicket.TabIndex = 54
        lblBaggageAllowanceTicket.Text = "Label9"
        ' 
        ' lblDestinationTicket
        ' 
        lblDestinationTicket.AutoSize = True
        lblDestinationTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblDestinationTicket.Font = New Font("Josefin Sans", 12F)
        lblDestinationTicket.Location = New Point(608, 697)
        lblDestinationTicket.Name = "lblDestinationTicket"
        lblDestinationTicket.Size = New Size(67, 25)
        lblDestinationTicket.TabIndex = 53
        lblDestinationTicket.Text = "Label10"
        ' 
        ' lblSeatNumTicket
        ' 
        lblSeatNumTicket.AutoSize = True
        lblSeatNumTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblSeatNumTicket.Font = New Font("Josefin Sans", 12F)
        lblSeatNumTicket.Location = New Point(608, 650)
        lblSeatNumTicket.Name = "lblSeatNumTicket"
        lblSeatNumTicket.Size = New Size(62, 25)
        lblSeatNumTicket.TabIndex = 52
        lblSeatNumTicket.Text = "Label11"
        ' 
        ' lblBookedUnderTicket
        ' 
        lblBookedUnderTicket.AutoSize = True
        lblBookedUnderTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblBookedUnderTicket.Font = New Font("Josefin Sans", 12F)
        lblBookedUnderTicket.Location = New Point(608, 607)
        lblBookedUnderTicket.Name = "lblBookedUnderTicket"
        lblBookedUnderTicket.Size = New Size(66, 25)
        lblBookedUnderTicket.TabIndex = 51
        lblBookedUnderTicket.Text = "Label12"
        ' 
        ' lblAdressTicket
        ' 
        lblAdressTicket.AutoSize = True
        lblAdressTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblAdressTicket.Font = New Font("Josefin Sans", 12F)
        lblAdressTicket.Location = New Point(272, 810)
        lblAdressTicket.Name = "lblAdressTicket"
        lblAdressTicket.Size = New Size(65, 25)
        lblAdressTicket.TabIndex = 55
        lblAdressTicket.Text = "Label13"
        ' 
        ' lblPWDTicket
        ' 
        lblPWDTicket.AutoSize = True
        lblPWDTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblPWDTicket.Font = New Font("Josefin Sans", 12F)
        lblPWDTicket.Location = New Point(610, 807)
        lblPWDTicket.Name = "lblPWDTicket"
        lblPWDTicket.Size = New Size(66, 25)
        lblPWDTicket.TabIndex = 56
        lblPWDTicket.Text = "Label14"
        ' 
        ' lblChangeTicket
        ' 
        lblChangeTicket.AutoSize = True
        lblChangeTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblChangeTicket.Font = New Font("Josefin Sans", 12F)
        lblChangeTicket.Location = New Point(1121, 666)
        lblChangeTicket.Name = "lblChangeTicket"
        lblChangeTicket.Size = New Size(65, 25)
        lblChangeTicket.TabIndex = 59
        lblChangeTicket.Text = "Label15"
        ' 
        ' lblTotalTicket
        ' 
        lblTotalTicket.AutoSize = True
        lblTotalTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblTotalTicket.Font = New Font("Josefin Sans", 12F)
        lblTotalTicket.Location = New Point(1121, 393)
        lblTotalTicket.Name = "lblTotalTicket"
        lblTotalTicket.Size = New Size(66, 25)
        lblTotalTicket.TabIndex = 58
        lblTotalTicket.Text = "Label16"
        ' 
        ' lblTaxTicket
        ' 
        lblTaxTicket.AutoSize = True
        lblTaxTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblTaxTicket.Font = New Font("Josefin Sans", 12F)
        lblTaxTicket.Location = New Point(1121, 324)
        lblTaxTicket.Name = "lblTaxTicket"
        lblTaxTicket.Size = New Size(65, 25)
        lblTaxTicket.TabIndex = 57
        lblTaxTicket.Text = "Label17"
        ' 
        ' lblTicketAmt
        ' 
        lblTicketAmt.AutoSize = True
        lblTicketAmt.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblTicketAmt.Font = New Font("Josefin Sans", 12F)
        lblTicketAmt.Location = New Point(1121, 279)
        lblTicketAmt.Name = "lblTicketAmt"
        lblTicketAmt.Size = New Size(65, 25)
        lblTicketAmt.TabIndex = 60
        lblTicketAmt.Text = "Label15"
        ' 
        ' lblClass
        ' 
        lblClass.AutoSize = True
        lblClass.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblClass.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClass.Location = New Point(269, 313)
        lblClass.Name = "lblClass"
        lblClass.Size = New Size(57, 25)
        lblClass.TabIndex = 61
        lblClass.Text = "Label1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 911)
        Controls.Add(lblClass)
        Controls.Add(lblTicketAmt)
        Controls.Add(lblChangeTicket)
        Controls.Add(lblTotalTicket)
        Controls.Add(lblTaxTicket)
        Controls.Add(lblPWDTicket)
        Controls.Add(lblAdressTicket)
        Controls.Add(lblBaggageAllowanceTicket)
        Controls.Add(lblDestinationTicket)
        Controls.Add(lblSeatNumTicket)
        Controls.Add(lblBookedUnderTicket)
        Controls.Add(lblGenderTicket)
        Controls.Add(lblDateOfBirthTicket)
        Controls.Add(lblFullNameTicket)
        Controls.Add(lblBookingDateTicket)
        Controls.Add(lblArrivalTimeTicket)
        Controls.Add(lblDepartTimeTicket)
        Controls.Add(lblArrivalDateTicket)
        Controls.Add(lblDepartDateTicket)
        Controls.Add(btnResetTicket)
        Controls.Add(btnNextTicket)
        Controls.Add(btnExit)
        Controls.Add(btnCalculate)
        Controls.Add(tbxTicketPayment)
        Controls.Add(cbxPassengerTicket)
        Controls.Add(btnSupport)
        Controls.Add(btnProcessTicket)
        Controls.Add(btnTicket)
        Controls.Add(btnBooking)
        Controls.Add(pbxCashierTicket)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        Text = "TICKET PROCESSING"
        CType(pbxCashierTicket, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTicket As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents lblArrivalDate As Label
    Friend WithEvents cbxPassengerTicket As ComboBox
    Friend WithEvents btnProcessTicket As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents tbxTicketPayment As TextBox
    Friend WithEvents btnSupport As Button
    Friend WithEvents pbxCashierTicket As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNextTicket As Button
    Friend WithEvents btnResetTicket As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblGenderTicket As Label
    Friend WithEvents lblDateOfBirthTicket As Label
    Friend WithEvents lblFullNameTicket As Label
    Friend WithEvents lblBookingDateTicket As Label
    Friend WithEvents lblArrivalTimeTicket As Label
    Friend WithEvents lblDepartTimeTicket As Label
    Friend WithEvents lblArrivalDateTicket As Label
    Friend WithEvents lblDepartDateTicket As Label
    Friend WithEvents lblChangeTicket As Label
    Friend WithEvents lblTotalTicket As Label
    Friend WithEvents lblTaxTicket As Label
    Friend WithEvents lblPWDTicket As Label
    Friend WithEvents lblAdressTicket As Label
    Friend WithEvents lblBaggageAllowanceTicket As Label
    Friend WithEvents lblDestinationTicket As Label
    Friend WithEvents lblSeatNumTicket As Label
    Friend WithEvents lblBookedUnderTicket As Label
    Friend WithEvents lblTicketAmt As Label
    Friend WithEvents lblClass As Label
End Class
