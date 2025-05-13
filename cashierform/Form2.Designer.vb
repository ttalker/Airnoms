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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
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
        btnSearch = New Button()
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
        btnCalculate.Location = New Point(1256, 696)
        btnCalculate.Margin = New Padding(3, 2, 3, 2)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(185, 69)
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
        pbxCashierTicket.BackgroundImage = CType(resources.GetObject("pbxCashierTicket.BackgroundImage"), Image)
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
        lblDepartDateTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartDateTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblDepartDateTicket.Location = New Point(272, 368)
        lblDepartDateTicket.Name = "lblDepartDateTicket"
        lblDepartDateTicket.Size = New Size(14, 21)
        lblDepartDateTicket.TabIndex = 43
        lblDepartDateTicket.Text = " "
        ' 
        ' lblArrivalDateTicket
        ' 
        lblArrivalDateTicket.AutoSize = True
        lblArrivalDateTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblArrivalDateTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalDateTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblArrivalDateTicket.Location = New Point(272, 419)
        lblArrivalDateTicket.Name = "lblArrivalDateTicket"
        lblArrivalDateTicket.Size = New Size(14, 21)
        lblArrivalDateTicket.TabIndex = 44
        lblArrivalDateTicket.Text = " "
        ' 
        ' lblDepartTimeTicket
        ' 
        lblDepartTimeTicket.AutoSize = True
        lblDepartTimeTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblDepartTimeTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartTimeTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblDepartTimeTicket.Location = New Point(597, 366)
        lblDepartTimeTicket.Name = "lblDepartTimeTicket"
        lblDepartTimeTicket.Size = New Size(14, 21)
        lblDepartTimeTicket.TabIndex = 45
        lblDepartTimeTicket.Text = " "
        ' 
        ' lblArrivalTimeTicket
        ' 
        lblArrivalTimeTicket.AutoSize = True
        lblArrivalTimeTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblArrivalTimeTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblArrivalTimeTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblArrivalTimeTicket.Location = New Point(597, 422)
        lblArrivalTimeTicket.Name = "lblArrivalTimeTicket"
        lblArrivalTimeTicket.Size = New Size(14, 21)
        lblArrivalTimeTicket.TabIndex = 46
        lblArrivalTimeTicket.Text = " "
        ' 
        ' lblGenderTicket
        ' 
        lblGenderTicket.AutoSize = True
        lblGenderTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblGenderTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGenderTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblGenderTicket.Location = New Point(269, 760)
        lblGenderTicket.Name = "lblGenderTicket"
        lblGenderTicket.Size = New Size(14, 21)
        lblGenderTicket.TabIndex = 50
        lblGenderTicket.Text = " "
        ' 
        ' lblDateOfBirthTicket
        ' 
        lblDateOfBirthTicket.AutoSize = True
        lblDateOfBirthTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblDateOfBirthTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDateOfBirthTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblDateOfBirthTicket.Location = New Point(269, 708)
        lblDateOfBirthTicket.Name = "lblDateOfBirthTicket"
        lblDateOfBirthTicket.Size = New Size(14, 21)
        lblDateOfBirthTicket.TabIndex = 49
        lblDateOfBirthTicket.Text = " "
        ' 
        ' lblFullNameTicket
        ' 
        lblFullNameTicket.AutoSize = True
        lblFullNameTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblFullNameTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullNameTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblFullNameTicket.Location = New Point(269, 659)
        lblFullNameTicket.Name = "lblFullNameTicket"
        lblFullNameTicket.Size = New Size(14, 21)
        lblFullNameTicket.TabIndex = 48
        lblFullNameTicket.Text = " "
        ' 
        ' lblBookingDateTicket
        ' 
        lblBookingDateTicket.AutoSize = True
        lblBookingDateTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblBookingDateTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookingDateTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblBookingDateTicket.Location = New Point(269, 605)
        lblBookingDateTicket.Name = "lblBookingDateTicket"
        lblBookingDateTicket.Size = New Size(14, 21)
        lblBookingDateTicket.TabIndex = 47
        lblBookingDateTicket.Text = " "
        ' 
        ' lblBaggageAllowanceTicket
        ' 
        lblBaggageAllowanceTicket.AutoSize = True
        lblBaggageAllowanceTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblBaggageAllowanceTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBaggageAllowanceTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblBaggageAllowanceTicket.Location = New Point(605, 759)
        lblBaggageAllowanceTicket.Name = "lblBaggageAllowanceTicket"
        lblBaggageAllowanceTicket.Size = New Size(14, 21)
        lblBaggageAllowanceTicket.TabIndex = 54
        lblBaggageAllowanceTicket.Text = " "
        ' 
        ' lblDestinationTicket
        ' 
        lblDestinationTicket.AutoSize = True
        lblDestinationTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblDestinationTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDestinationTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblDestinationTicket.Location = New Point(605, 706)
        lblDestinationTicket.Name = "lblDestinationTicket"
        lblDestinationTicket.Size = New Size(14, 21)
        lblDestinationTicket.TabIndex = 53
        lblDestinationTicket.Text = " "
        ' 
        ' lblSeatNumTicket
        ' 
        lblSeatNumTicket.AutoSize = True
        lblSeatNumTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblSeatNumTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeatNumTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblSeatNumTicket.Location = New Point(605, 658)
        lblSeatNumTicket.Name = "lblSeatNumTicket"
        lblSeatNumTicket.Size = New Size(14, 21)
        lblSeatNumTicket.TabIndex = 52
        lblSeatNumTicket.Text = " "
        ' 
        ' lblBookedUnderTicket
        ' 
        lblBookedUnderTicket.AutoSize = True
        lblBookedUnderTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblBookedUnderTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBookedUnderTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblBookedUnderTicket.Location = New Point(605, 608)
        lblBookedUnderTicket.Name = "lblBookedUnderTicket"
        lblBookedUnderTicket.Size = New Size(14, 21)
        lblBookedUnderTicket.TabIndex = 51
        lblBookedUnderTicket.Text = " "
        ' 
        ' lblAdressTicket
        ' 
        lblAdressTicket.AutoSize = True
        lblAdressTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblAdressTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAdressTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblAdressTicket.Location = New Point(272, 815)
        lblAdressTicket.Name = "lblAdressTicket"
        lblAdressTicket.Size = New Size(14, 21)
        lblAdressTicket.TabIndex = 55
        lblAdressTicket.Text = " "
        ' 
        ' lblPWDTicket
        ' 
        lblPWDTicket.AutoSize = True
        lblPWDTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblPWDTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPWDTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblPWDTicket.Location = New Point(607, 812)
        lblPWDTicket.Name = "lblPWDTicket"
        lblPWDTicket.Size = New Size(14, 21)
        lblPWDTicket.TabIndex = 56
        lblPWDTicket.Text = " "
        ' 
        ' lblChangeTicket
        ' 
        lblChangeTicket.AutoSize = True
        lblChangeTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblChangeTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChangeTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblChangeTicket.Location = New Point(1121, 668)
        lblChangeTicket.Name = "lblChangeTicket"
        lblChangeTicket.Size = New Size(14, 21)
        lblChangeTicket.TabIndex = 59
        lblChangeTicket.Text = " "
        ' 
        ' lblTotalTicket
        ' 
        lblTotalTicket.AutoSize = True
        lblTotalTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblTotalTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblTotalTicket.Location = New Point(1121, 397)
        lblTotalTicket.Name = "lblTotalTicket"
        lblTotalTicket.Size = New Size(14, 21)
        lblTotalTicket.TabIndex = 58
        lblTotalTicket.Text = " "
        ' 
        ' lblTaxTicket
        ' 
        lblTaxTicket.AutoSize = True
        lblTaxTicket.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblTaxTicket.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTaxTicket.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblTaxTicket.Location = New Point(1121, 329)
        lblTaxTicket.Name = "lblTaxTicket"
        lblTaxTicket.Size = New Size(14, 21)
        lblTaxTicket.TabIndex = 57
        lblTaxTicket.Text = " "
        ' 
        ' lblTicketAmt
        ' 
        lblTicketAmt.AutoSize = True
        lblTicketAmt.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblTicketAmt.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTicketAmt.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblTicketAmt.Location = New Point(1121, 280)
        lblTicketAmt.Name = "lblTicketAmt"
        lblTicketAmt.Size = New Size(14, 21)
        lblTicketAmt.TabIndex = 60
        lblTicketAmt.Text = " "
        ' 
        ' lblClass
        ' 
        lblClass.AutoSize = True
        lblClass.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblClass.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblClass.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblClass.Location = New Point(270, 317)
        lblClass.Name = "lblClass"
        lblClass.Size = New Size(14, 21)
        lblClass.TabIndex = 61
        lblClass.Text = " "
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(463, 267)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(86, 34)
        btnSearch.TabIndex = 62
        btnSearch.Text = " "
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 911)
        Controls.Add(btnSearch)
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
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents btnSearch As Button
End Class
