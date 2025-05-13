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
        tbxSearchInput = New TextBox()
        dgvBookings = New DataGridView()
        pbxAdmin = New PictureBox()
        btnSearch = New Button()
        btnViewInfo = New Button()
        CType(dgvBookings, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBookings.Location = New Point(586, 26)
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
        lblBookingDateAdmin.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblBookingDateAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblBookingDateAdmin.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblBookingDateAdmin.Location = New Point(1168, 273)
        lblBookingDateAdmin.Name = "lblBookingDateAdmin"
        lblBookingDateAdmin.Size = New Size(14, 21)
        lblBookingDateAdmin.TabIndex = 13
        lblBookingDateAdmin.Text = " "
        ' 
        ' lblSeatNumAdmin
        ' 
        lblSeatNumAdmin.AutoSize = True
        lblSeatNumAdmin.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblSeatNumAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblSeatNumAdmin.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblSeatNumAdmin.Location = New Point(1168, 326)
        lblSeatNumAdmin.Name = "lblSeatNumAdmin"
        lblSeatNumAdmin.Size = New Size(14, 21)
        lblSeatNumAdmin.TabIndex = 14
        lblSeatNumAdmin.Text = " "
        ' 
        ' lblBaggageAllowanceAdmin
        ' 
        lblBaggageAllowanceAdmin.AutoSize = True
        lblBaggageAllowanceAdmin.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblBaggageAllowanceAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblBaggageAllowanceAdmin.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblBaggageAllowanceAdmin.Location = New Point(1168, 380)
        lblBaggageAllowanceAdmin.Name = "lblBaggageAllowanceAdmin"
        lblBaggageAllowanceAdmin.Size = New Size(14, 21)
        lblBaggageAllowanceAdmin.TabIndex = 15
        lblBaggageAllowanceAdmin.Text = " "
        ' 
        ' lblFullNameAdmin
        ' 
        lblFullNameAdmin.AutoSize = True
        lblFullNameAdmin.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblFullNameAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblFullNameAdmin.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblFullNameAdmin.Location = New Point(1168, 436)
        lblFullNameAdmin.Name = "lblFullNameAdmin"
        lblFullNameAdmin.Size = New Size(14, 21)
        lblFullNameAdmin.TabIndex = 16
        lblFullNameAdmin.Text = " "
        ' 
        ' lblAgeAdmin
        ' 
        lblAgeAdmin.AutoSize = True
        lblAgeAdmin.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblAgeAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblAgeAdmin.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblAgeAdmin.Location = New Point(1168, 495)
        lblAgeAdmin.Name = "lblAgeAdmin"
        lblAgeAdmin.Size = New Size(14, 21)
        lblAgeAdmin.TabIndex = 17
        lblAgeAdmin.Text = " "
        ' 
        ' lblDateOfBirthAdmin
        ' 
        lblDateOfBirthAdmin.AutoSize = True
        lblDateOfBirthAdmin.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblDateOfBirthAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblDateOfBirthAdmin.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblDateOfBirthAdmin.Location = New Point(1168, 549)
        lblDateOfBirthAdmin.Name = "lblDateOfBirthAdmin"
        lblDateOfBirthAdmin.Size = New Size(14, 21)
        lblDateOfBirthAdmin.TabIndex = 18
        lblDateOfBirthAdmin.Text = " "
        ' 
        ' lblGenderAdmin
        ' 
        lblGenderAdmin.AutoSize = True
        lblGenderAdmin.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblGenderAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblGenderAdmin.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblGenderAdmin.Location = New Point(1168, 604)
        lblGenderAdmin.Name = "lblGenderAdmin"
        lblGenderAdmin.Size = New Size(14, 21)
        lblGenderAdmin.TabIndex = 19
        lblGenderAdmin.Text = " "
        ' 
        ' lblAddressAdmin
        ' 
        lblAddressAdmin.AutoSize = True
        lblAddressAdmin.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblAddressAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblAddressAdmin.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblAddressAdmin.Location = New Point(1168, 663)
        lblAddressAdmin.Name = "lblAddressAdmin"
        lblAddressAdmin.Size = New Size(14, 21)
        lblAddressAdmin.TabIndex = 20
        lblAddressAdmin.Text = " "
        ' 
        ' lblPWDAdmin
        ' 
        lblPWDAdmin.AutoSize = True
        lblPWDAdmin.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblPWDAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblPWDAdmin.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblPWDAdmin.Location = New Point(1168, 722)
        lblPWDAdmin.Name = "lblPWDAdmin"
        lblPWDAdmin.Size = New Size(14, 21)
        lblPWDAdmin.TabIndex = 21
        lblPWDAdmin.Text = " "
        ' 
        ' tbxSearchInput
        ' 
        tbxSearchInput.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbxSearchInput.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        tbxSearchInput.Location = New Point(109, 242)
        tbxSearchInput.Name = "tbxSearchInput"
        tbxSearchInput.Size = New Size(275, 34)
        tbxSearchInput.TabIndex = 22
        ' 
        ' dgvBookings
        ' 
        dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBookings.Location = New Point(110, 301)
        dgvBookings.Name = "dgvBookings"
        dgvBookings.Size = New Size(720, 436)
        dgvBookings.TabIndex = 23
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
        ' btnSearch
        ' 
        btnSearch.Location = New Point(394, 235)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(110, 42)
        btnSearch.TabIndex = 24
        btnSearch.Text = " "
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnViewInfo
        ' 
        btnViewInfo.Location = New Point(696, 754)
        btnViewInfo.Name = "btnViewInfo"
        btnViewInfo.Size = New Size(162, 63)
        btnViewInfo.TabIndex = 25
        btnViewInfo.Text = " "
        btnViewInfo.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 881)
        Controls.Add(btnViewInfo)
        Controls.Add(btnSearch)
        Controls.Add(dgvBookings)
        Controls.Add(tbxSearchInput)
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
        CType(dgvBookings, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxAdmin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnFlights As Button
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
    Friend WithEvents tbxSearchInput As TextBox
    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents pbxAdmin As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnViewInfo As Button
End Class
