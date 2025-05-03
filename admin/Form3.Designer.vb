<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        btnExit = New Button()
        btnBookings = New Button()
        btnFlights = New Button()
        pbxAdmin = New PictureBox()
        btnTransactions = New Button()
        lblBookingDateAdmin = New Label()
        lblSeatNumAdmin = New Label()
        lblBaggageAllowanceAdmin = New Label()
        lblFullNameAdmin = New Label()
        lblAgeAdmin = New Label()
        lblDateOfBirthAdmin = New Label()
        lblGenderAdmin = New Label()
        lblAddressAdmin = New Label()
        lblPWDAdmin = New Label()
        TextBox1 = New TextBox()
        CType(pbxAdmin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(786, 26)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(146, 70)
        btnExit.TabIndex = 9
        btnExit.Text = " "
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnBookings
        ' 
        btnBookings.Location = New Point(588, 26)
        btnBookings.Name = "btnBookings"
        btnBookings.Size = New Size(183, 70)
        btnBookings.TabIndex = 8
        btnBookings.Text = " "
        btnBookings.UseVisualStyleBackColor = True
        ' 
        ' btnFlights
        ' 
        btnFlights.Location = New Point(43, 26)
        btnFlights.Name = "btnFlights"
        btnFlights.Size = New Size(185, 70)
        btnFlights.TabIndex = 6
        btnFlights.Text = " "
        btnFlights.UseVisualStyleBackColor = True
        ' 
        ' pbxAdmin
        ' 
        pbxAdmin.BackgroundImage = My.Resources.Resources.Admin_Panel_bookings___2_
        pbxAdmin.Location = New Point(-3, -2)
        pbxAdmin.Name = "pbxAdmin"
        pbxAdmin.Size = New Size(1552, 884)
        pbxAdmin.TabIndex = 5
        pbxAdmin.TabStop = False
        ' 
        ' btnTransactions
        ' 
        btnTransactions.Location = New Point(280, 27)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(250, 70)
        btnTransactions.TabIndex = 10
        btnTransactions.Text = " "
        btnTransactions.UseVisualStyleBackColor = True
        ' 
        ' lblBookingDateAdmin
        ' 
        lblBookingDateAdmin.AutoSize = True
        lblBookingDateAdmin.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBookingDateAdmin.Location = New Point(1168, 267)
        lblBookingDateAdmin.Name = "lblBookingDateAdmin"
        lblBookingDateAdmin.Size = New Size(61, 25)
        lblBookingDateAdmin.TabIndex = 13
        lblBookingDateAdmin.Text = "Label2"
        ' 
        ' lblSeatNumAdmin
        ' 
        lblSeatNumAdmin.AutoSize = True
        lblSeatNumAdmin.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSeatNumAdmin.Location = New Point(1168, 320)
        lblSeatNumAdmin.Name = "lblSeatNumAdmin"
        lblSeatNumAdmin.Size = New Size(61, 25)
        lblSeatNumAdmin.TabIndex = 14
        lblSeatNumAdmin.Text = "Label2"
        ' 
        ' lblBaggageAllowanceAdmin
        ' 
        lblBaggageAllowanceAdmin.AutoSize = True
        lblBaggageAllowanceAdmin.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBaggageAllowanceAdmin.Location = New Point(1168, 374)
        lblBaggageAllowanceAdmin.Name = "lblBaggageAllowanceAdmin"
        lblBaggageAllowanceAdmin.Size = New Size(61, 25)
        lblBaggageAllowanceAdmin.TabIndex = 15
        lblBaggageAllowanceAdmin.Text = "Label2"
        ' 
        ' lblFullNameAdmin
        ' 
        lblFullNameAdmin.AutoSize = True
        lblFullNameAdmin.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullNameAdmin.Location = New Point(1168, 430)
        lblFullNameAdmin.Name = "lblFullNameAdmin"
        lblFullNameAdmin.Size = New Size(61, 25)
        lblFullNameAdmin.TabIndex = 16
        lblFullNameAdmin.Text = "Label2"
        ' 
        ' lblAgeAdmin
        ' 
        lblAgeAdmin.AutoSize = True
        lblAgeAdmin.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAgeAdmin.Location = New Point(1168, 489)
        lblAgeAdmin.Name = "lblAgeAdmin"
        lblAgeAdmin.Size = New Size(61, 25)
        lblAgeAdmin.TabIndex = 17
        lblAgeAdmin.Text = "Label2"
        ' 
        ' lblDateOfBirthAdmin
        ' 
        lblDateOfBirthAdmin.AutoSize = True
        lblDateOfBirthAdmin.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDateOfBirthAdmin.Location = New Point(1168, 543)
        lblDateOfBirthAdmin.Name = "lblDateOfBirthAdmin"
        lblDateOfBirthAdmin.Size = New Size(61, 25)
        lblDateOfBirthAdmin.TabIndex = 18
        lblDateOfBirthAdmin.Text = "Label2"
        ' 
        ' lblGenderAdmin
        ' 
        lblGenderAdmin.AutoSize = True
        lblGenderAdmin.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGenderAdmin.Location = New Point(1168, 598)
        lblGenderAdmin.Name = "lblGenderAdmin"
        lblGenderAdmin.Size = New Size(61, 25)
        lblGenderAdmin.TabIndex = 19
        lblGenderAdmin.Text = "Label2"
        ' 
        ' lblAddressAdmin
        ' 
        lblAddressAdmin.AutoSize = True
        lblAddressAdmin.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddressAdmin.Location = New Point(1168, 657)
        lblAddressAdmin.Name = "lblAddressAdmin"
        lblAddressAdmin.Size = New Size(61, 25)
        lblAddressAdmin.TabIndex = 20
        lblAddressAdmin.Text = "Label2"
        ' 
        ' lblPWDAdmin
        ' 
        lblPWDAdmin.AutoSize = True
        lblPWDAdmin.Font = New Font("Josefin Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPWDAdmin.Location = New Point(1168, 716)
        lblPWDAdmin.Name = "lblPWDAdmin"
        lblPWDAdmin.Size = New Size(61, 25)
        lblPWDAdmin.TabIndex = 21
        lblPWDAdmin.Text = "Label2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Josefin Sans", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(94, 239)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(289, 36)
        TextBox1.TabIndex = 22
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 881)
        Controls.Add(TextBox1)
        Controls.Add(lblPWDAdmin)
        Controls.Add(lblAddressAdmin)
        Controls.Add(lblGenderAdmin)
        Controls.Add(lblDateOfBirthAdmin)
        Controls.Add(lblAgeAdmin)
        Controls.Add(lblFullNameAdmin)
        Controls.Add(lblBaggageAllowanceAdmin)
        Controls.Add(lblSeatNumAdmin)
        Controls.Add(lblBookingDateAdmin)
        Controls.Add(btnTransactions)
        Controls.Add(btnExit)
        Controls.Add(btnBookings)
        Controls.Add(btnFlights)
        Controls.Add(pbxAdmin)
        Name = "Form3"
        Text = "BOOKINGS"
        CType(pbxAdmin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnFlights As Button
    Friend WithEvents pbxAdmin As PictureBox
    Friend WithEvents btnTransactions As Button
    Friend WithEvents lblBookingDateAdmin As Label
    Friend WithEvents lblSeatNumAdmin As Label
    Friend WithEvents lblBaggageAllowanceAdmin As Label
    Friend WithEvents lblFullNameAdmin As Label
    Friend WithEvents lblAgeAdmin As Label
    Friend WithEvents lblDateOfBirthAdmin As Label
    Friend WithEvents lblGenderAdmin As Label
    Friend WithEvents lblAddressAdmin As Label
    Friend WithEvents lblPWDAdmin As Label
    Friend WithEvents TextBox1 As TextBox
End Class
