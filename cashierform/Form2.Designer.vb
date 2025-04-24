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
        tbxTicketPayment = New TextBox()
        btnCalculate = New Button()
        cbxClassTicket = New ComboBox()
        cbxPassengerTicket = New ComboBox()
        tbxFlightTicket = New TextBox()
        btnResetTicket = New Button()
        btnProcessTicket = New Button()
        btnSupport = New Button()
        PictureBox1 = New PictureBox()
        btnExit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(293, 26)
        btnTicket.Margin = New Padding(3, 2, 3, 2)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(170, 69)
        btnTicket.TabIndex = 5
        btnTicket.Text = " "
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(79, 29)
        btnBooking.Margin = New Padding(3, 2, 3, 2)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(170, 66)
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
        btnCalculate.Location = New Point(1249, 707)
        btnCalculate.Margin = New Padding(3, 2, 3, 2)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(173, 54)
        btnCalculate.TabIndex = 38
        btnCalculate.Text = "CALCULATE"
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
        ' btnResetTicket
        ' 
        btnResetTicket.Location = New Point(870, 796)
        btnResetTicket.Margin = New Padding(3, 2, 3, 2)
        btnResetTicket.Name = "btnResetTicket"
        btnResetTicket.Size = New Size(182, 76)
        btnResetTicket.TabIndex = 9
        btnResetTicket.Text = " "
        btnResetTicket.UseVisualStyleBackColor = True
        ' 
        ' btnProcessTicket
        ' 
        btnProcessTicket.Location = New Point(1271, 800)
        btnProcessTicket.Margin = New Padding(3, 2, 3, 2)
        btnProcessTicket.Name = "btnProcessTicket"
        btnProcessTicket.Size = New Size(182, 68)
        btnProcessTicket.TabIndex = 8
        btnProcessTicket.Text = " "
        btnProcessTicket.UseVisualStyleBackColor = True
        ' 
        ' btnSupport
        ' 
        btnSupport.Location = New Point(497, 29)
        btnSupport.Margin = New Padding(3, 2, 3, 2)
        btnSupport.Name = "btnSupport"
        btnSupport.Size = New Size(170, 66)
        btnSupport.TabIndex = 10
        btnSupport.Text = " "
        btnSupport.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.MAIN_REFERENCE__REAL____TICKET__1_
        PictureBox1.Location = New Point(-3, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1551, 910)
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(696, 26)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(170, 66)
        btnExit.TabIndex = 40
        btnExit.Text = " "
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 911)
        Controls.Add(btnExit)
        Controls.Add(tbxFlightTicket)
        Controls.Add(btnCalculate)
        Controls.Add(tbxTicketPayment)
        Controls.Add(cbxPassengerTicket)
        Controls.Add(btnSupport)
        Controls.Add(cbxClassTicket)
        Controls.Add(btnResetTicket)
        Controls.Add(btnProcessTicket)
        Controls.Add(btnTicket)
        Controls.Add(btnBooking)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTicket As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents lblArrivalDate As Label
    Friend WithEvents cbxPassengerTicket As ComboBox
    Friend WithEvents btnResetTicket As Button
    Friend WithEvents btnProcessTicket As Button
    Friend WithEvents cbxClassTicket As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents tbxTicketPayment As TextBox
    Friend WithEvents btnSupport As Button
    Friend WithEvents tbxFlightTicket As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
End Class
