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
        cbxClassTicket = New ComboBox()
        cbxPassengerTicket = New ComboBox()
        tbxFlightTicket = New TextBox()
        btnProcessTicket = New Button()
        btnSupport = New Button()
        pbxCashierTicket = New PictureBox()
        btnExit = New Button()
        btnNextTicket = New Button()
        btnResetTicket = New Button()
        ErrorProvider1 = New ErrorProvider(components)
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
        ' cbxClassTicket
        ' 
        cbxClassTicket.FormattingEnabled = True
        cbxClassTicket.Location = New Point(260, 335)
        cbxClassTicket.Margin = New Padding(3, 2, 3, 2)
        cbxClassTicket.Name = "cbxClassTicket"
        cbxClassTicket.Size = New Size(203, 23)
        cbxClassTicket.TabIndex = 28
        ' 
        ' cbxPassengerTicket
        ' 
        cbxPassengerTicket.FormattingEnabled = True
        cbxPassengerTicket.Location = New Point(260, 239)
        cbxPassengerTicket.Margin = New Padding(3, 2, 3, 2)
        cbxPassengerTicket.Name = "cbxPassengerTicket"
        cbxPassengerTicket.Size = New Size(203, 23)
        cbxPassengerTicket.TabIndex = 3
        ' 
        ' tbxFlightTicket
        ' 
        tbxFlightTicket.Anchor = AnchorStyles.None
        tbxFlightTicket.Location = New Point(260, 288)
        tbxFlightTicket.Margin = New Padding(3, 2, 3, 2)
        tbxFlightTicket.MaximumSize = New Size(217, 30)
        tbxFlightTicket.Name = "tbxFlightTicket"
        tbxFlightTicket.Size = New Size(203, 23)
        tbxFlightTicket.TabIndex = 17
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
        pbxCashierTicket.BackgroundImage = My.Resources.Resources.TICKET_PAGE__1_
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
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 911)
        Controls.Add(btnResetTicket)
        Controls.Add(btnNextTicket)
        Controls.Add(btnExit)
        Controls.Add(tbxFlightTicket)
        Controls.Add(btnCalculate)
        Controls.Add(tbxTicketPayment)
        Controls.Add(cbxPassengerTicket)
        Controls.Add(btnSupport)
        Controls.Add(cbxClassTicket)
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
    Friend WithEvents cbxClassTicket As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents tbxTicketPayment As TextBox
    Friend WithEvents btnSupport As Button
    Friend WithEvents tbxFlightTicket As TextBox
    Friend WithEvents pbxCashierTicket As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNextTicket As Button
    Friend WithEvents btnResetTicket As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
