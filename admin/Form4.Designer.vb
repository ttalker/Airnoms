<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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

        btnAddFlight = New Button()
        btnCLearAdmin = New Button()
        btnBackAdmin = New Button()
        btnAddAdmin = New Button()
        tbxDepartureAdmin = New TextBox()
        tbxDestinationAdmin = New TextBox()
        tbxDepartureTimeAdmin = New TextBox()
        cbxPilotAdmin = New ComboBox()
        cbxPlaneAdmin = New ComboBox()
        SuspendLayout()
        ' 
        ' btnAddFlight
        ' 
        btnAddFlight.Location = New Point(426, 408)
        btnAddFlight.Name = "btnAddFlight"
        btnAddFlight.Size = New Size(164, 62)
        btnAddFlight.TabIndex = 7
        btnAddFlight.Text = " "
        btnAddFlight.UseVisualStyleBackColor = True
        ' 
        ' btnCLearAdmin
        ' 
        btnCLearAdmin.Location = New Point(298, 408)
        btnCLearAdmin.Name = "btnCLearAdmin"
        btnCLearAdmin.Size = New Size(122, 62)
        btnCLearAdmin.TabIndex = 7
        btnCLearAdmin.Text = " "
        btnCLearAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnBackAdmin
        ' 
        btnBackAdmin.Location = New Point(42, 408)
        btnBackAdmin.Name = "btnBackAdmin"
        btnBackAdmin.Size = New Size(142, 62)
        btnBackAdmin.TabIndex = 7
        btnBackAdmin.Text = " "
        btnBackAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnAddAdmin
        ' 
        btnAddAdmin.Location = New Point(426, 268)
        btnAddAdmin.Name = "btnAddAdmin"
        btnAddAdmin.Size = New Size(74, 38)
        btnAddAdmin.TabIndex = 7
        btnAddAdmin.Text = " "
        btnAddAdmin.UseVisualStyleBackColor = True
        ' 
        ' tbxDepartureAdmin
        ' 
        tbxDepartureAdmin.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxDepartureAdmin.Location = New Point(234, 117)
        tbxDepartureAdmin.Name = "tbxDepartureAdmin"
        tbxDepartureAdmin.Size = New Size(186, 29)
        tbxDepartureAdmin.TabIndex = 8
        ' 
        ' tbxDestinationAdmin
        ' 
        tbxDestinationAdmin.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxDestinationAdmin.Location = New Point(234, 166)
        tbxDestinationAdmin.Name = "tbxDestinationAdmin"
        tbxDestinationAdmin.Size = New Size(186, 29)
        tbxDestinationAdmin.TabIndex = 8
        ' 
        ' tbxDepartureTimeAdmin
        ' 
        tbxDepartureTimeAdmin.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxDepartureTimeAdmin.Location = New Point(234, 217)
        tbxDepartureTimeAdmin.Name = "tbxDepartureTimeAdmin"
        tbxDepartureTimeAdmin.Size = New Size(186, 29)
        tbxDepartureTimeAdmin.TabIndex = 8
        ' 
        ' cbxPilotAdmin
        ' 
        cbxPilotAdmin.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxPilotAdmin.FormattingEnabled = True
        cbxPilotAdmin.Items.AddRange(New Object() {"try", "test", "me"})
        cbxPilotAdmin.Location = New Point(234, 272)
        cbxPilotAdmin.Name = "cbxPilotAdmin"
        cbxPilotAdmin.Size = New Size(186, 29)
        cbxPilotAdmin.TabIndex = 9
        ' 
        ' cbxPlaneAdmin
        ' 
        cbxPlaneAdmin.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxPlaneAdmin.FormattingEnabled = True
        cbxPlaneAdmin.Location = New Point(234, 318)
        cbxPlaneAdmin.Name = "cbxPlaneAdmin"
        cbxPlaneAdmin.Size = New Size(186, 29)
        cbxPlaneAdmin.TabIndex = 9
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Admin__add_flight___1_
        ClientSize = New Size(620, 492)
        Controls.Add(cbxPlaneAdmin)
        Controls.Add(cbxPilotAdmin)
        Controls.Add(tbxDepartureTimeAdmin)
        Controls.Add(tbxDestinationAdmin)
        Controls.Add(tbxDepartureAdmin)
        Controls.Add(btnAddAdmin)
        Controls.Add(btnBackAdmin)
        Controls.Add(btnCLearAdmin)
        Controls.Add(btnAddFlight)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cancel_Delay_Form))
        btnDelay = New Button()
        btnCancel = New Button()
        lblFlightID = New Label()
        txtReason = New TextBox()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' btnDelay
        ' 
        btnDelay.BackColor = Color.Transparent
        btnDelay.Location = New Point(298, 289)
        btnDelay.Name = "btnDelay"
        btnDelay.Size = New Size(127, 39)
        btnDelay.TabIndex = 0
        btnDelay.Text = "DELAY"
        btnDelay.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.Location = New Point(437, 287)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(128, 40)
        btnCancel.TabIndex = 1
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblFlightID
        ' 
        lblFlightID.AutoSize = True
        lblFlightID.BackColor = Color.Transparent
        lblFlightID.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFlightID.Location = New Point(215, 150)
        lblFlightID.Name = "lblFlightID"
        lblFlightID.Size = New Size(67, 25)
        lblFlightID.TabIndex = 2
        lblFlightID.Text = "Label1"
        ' 
        ' txtReason
        ' 
        txtReason.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtReason.Location = New Point(215, 193)
        txtReason.Name = "txtReason"
        txtReason.Size = New Size(210, 27)
        txtReason.TabIndex = 3
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(465, 371)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(121, 42)
        btnReturn.TabIndex = 4
        btnReturn.Text = "RETURN"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' Cancel_Delay_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(612, 450)
        Controls.Add(btnReturn)
        Controls.Add(txtReason)
        Controls.Add(lblFlightID)
        Controls.Add(btnCancel)
        Controls.Add(btnDelay)
        Name = "Cancel_Delay_Form"
        Text = "Cancel_Delay_Form"

        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddFlight As Button
    Friend WithEvents btnCLearAdmin As Button
    Friend WithEvents btnBackAdmin As Button
    Friend WithEvents btnAddAdmin As Button
    Friend WithEvents tbxDepartureAdmin As TextBox
    Friend WithEvents tbxDestinationAdmin As TextBox
    Friend WithEvents tbxDepartureTimeAdmin As TextBox
    Friend WithEvents cbxPilotAdmin As ComboBox
    Friend WithEvents cbxPlaneAdmin As ComboBox
    Friend WithEvents btnDelay As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblFlightID As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents btnReturn As Button

End Class
