<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        btnClearAdmin = New Button()
        btnAddFlightAdmin = New Button()
        btnReturnAdmin = New Button()
        btnAddPilotAdmin = New Button()
        tbxDepartureADmin = New TextBox()
        tbxDestinationADmin = New TextBox()
        tbxDepartureTimeADmin = New TextBox()
        cbxPilotAdmin = New ComboBox()
        cbxPlaneAdmin = New ComboBox()
        SuspendLayout()
        ' 
        ' btnClearAdmin
        ' 
        btnClearAdmin.Location = New Point(299, 409)
        btnClearAdmin.Name = "btnClearAdmin"
        btnClearAdmin.Size = New Size(119, 59)
        btnClearAdmin.TabIndex = 11
        btnClearAdmin.Text = " "
        btnClearAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnAddFlightAdmin
        ' 
        btnAddFlightAdmin.Location = New Point(424, 409)
        btnAddFlightAdmin.Name = "btnAddFlightAdmin"
        btnAddFlightAdmin.Size = New Size(165, 59)
        btnAddFlightAdmin.TabIndex = 11
        btnAddFlightAdmin.Text = " "
        btnAddFlightAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnReturnAdmin
        ' 
        btnReturnAdmin.Location = New Point(42, 409)
        btnReturnAdmin.Name = "btnReturnAdmin"
        btnReturnAdmin.Size = New Size(135, 59)
        btnReturnAdmin.TabIndex = 11
        btnReturnAdmin.Text = " "
        btnReturnAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnAddPilotAdmin
        ' 
        btnAddPilotAdmin.Location = New Point(424, 270)
        btnAddPilotAdmin.Name = "btnAddPilotAdmin"
        btnAddPilotAdmin.Size = New Size(73, 37)
        btnAddPilotAdmin.TabIndex = 11
        btnAddPilotAdmin.Text = " "
        btnAddPilotAdmin.UseVisualStyleBackColor = True
        ' 
        ' tbxDepartureADmin
        ' 
        tbxDepartureADmin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxDepartureADmin.Location = New Point(229, 116)
        tbxDepartureADmin.Name = "tbxDepartureADmin"
        tbxDepartureADmin.Size = New Size(174, 29)
        tbxDepartureADmin.TabIndex = 12
        ' 
        ' tbxDestinationADmin
        ' 
        tbxDestinationADmin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxDestinationADmin.Location = New Point(229, 165)
        tbxDestinationADmin.Name = "tbxDestinationADmin"
        tbxDestinationADmin.Size = New Size(174, 29)
        tbxDestinationADmin.TabIndex = 12
        ' 
        ' tbxDepartureTimeADmin
        ' 
        tbxDepartureTimeADmin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxDepartureTimeADmin.Location = New Point(229, 218)
        tbxDepartureTimeADmin.Name = "tbxDepartureTimeADmin"
        tbxDepartureTimeADmin.Size = New Size(174, 29)
        tbxDepartureTimeADmin.TabIndex = 12
        ' 
        ' cbxPilotAdmin
        ' 
        cbxPilotAdmin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxPilotAdmin.FormattingEnabled = True
        cbxPilotAdmin.Items.AddRange(New Object() {"Aldrin", "Charles", "Kelvin", "Kyran", "Vincent"})
        cbxPilotAdmin.Location = New Point(229, 273)
        cbxPilotAdmin.Name = "cbxPilotAdmin"
        cbxPilotAdmin.Size = New Size(174, 29)
        cbxPilotAdmin.TabIndex = 13
        ' 
        ' cbxPlaneAdmin
        ' 
        cbxPlaneAdmin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbxPlaneAdmin.FormattingEnabled = True
        cbxPlaneAdmin.Location = New Point(229, 321)
        cbxPlaneAdmin.Name = "cbxPlaneAdmin"
        cbxPlaneAdmin.Size = New Size(174, 29)
        cbxPlaneAdmin.TabIndex = 13
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Admin__add_flight___2_
        ClientSize = New Size(626, 500)
        Controls.Add(cbxPlaneAdmin)
        Controls.Add(cbxPilotAdmin)
        Controls.Add(tbxDepartureTimeADmin)
        Controls.Add(tbxDestinationADmin)
        Controls.Add(tbxDepartureADmin)
        Controls.Add(btnAddPilotAdmin)
        Controls.Add(btnReturnAdmin)
        Controls.Add(btnAddFlightAdmin)
        Controls.Add(btnClearAdmin)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClearAdmin As Button
    Friend WithEvents btnAddFlightAdmin As Button
    Friend WithEvents btnReturnAdmin As Button
    Friend WithEvents btnAddPilotAdmin As Button
    Friend WithEvents tbxDepartureADmin As TextBox
    Friend WithEvents tbxDestinationADmin As TextBox
    Friend WithEvents tbxDepartureTimeADmin As TextBox
    Friend WithEvents cbxPilotAdmin As ComboBox
    Friend WithEvents cbxPlaneAdmin As ComboBox
End Class
