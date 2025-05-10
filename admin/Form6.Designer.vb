<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        btnReturnCancelFlight = New Button()
        btnCancleCancelFlight = New Button()
        btnDelayCancelFlight = New Button()
        tbxReasonCancelFlight = New TextBox()
        LblFlightIDCancleFlight = New Label()
        SuspendLayout()
        ' 
        ' btnReturnCancelFlight
        ' 
        btnReturnCancelFlight.Location = New Point(462, 369)
        btnReturnCancelFlight.Name = "btnReturnCancelFlight"
        btnReturnCancelFlight.Size = New Size(130, 52)
        btnReturnCancelFlight.TabIndex = 12
        btnReturnCancelFlight.Text = " "
        btnReturnCancelFlight.UseVisualStyleBackColor = True
        ' 
        ' btnCancleCancelFlight
        ' 
        btnCancleCancelFlight.Location = New Point(435, 288)
        btnCancleCancelFlight.Name = "btnCancleCancelFlight"
        btnCancleCancelFlight.Size = New Size(132, 38)
        btnCancleCancelFlight.TabIndex = 12
        btnCancleCancelFlight.Text = " "
        btnCancleCancelFlight.UseVisualStyleBackColor = True
        ' 
        ' btnDelayCancelFlight
        ' 
        btnDelayCancelFlight.Location = New Point(297, 288)
        btnDelayCancelFlight.Name = "btnDelayCancelFlight"
        btnDelayCancelFlight.Size = New Size(132, 38)
        btnDelayCancelFlight.TabIndex = 12
        btnDelayCancelFlight.Text = " "
        btnDelayCancelFlight.UseVisualStyleBackColor = True
        ' 
        ' tbxReasonCancelFlight
        ' 
        tbxReasonCancelFlight.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxReasonCancelFlight.Location = New Point(216, 191)
        tbxReasonCancelFlight.Name = "tbxReasonCancelFlight"
        tbxReasonCancelFlight.Size = New Size(246, 29)
        tbxReasonCancelFlight.TabIndex = 13
        ' 
        ' LblFlightIDCancleFlight
        ' 
        LblFlightIDCancleFlight.AutoSize = True
        LblFlightIDCancleFlight.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        LblFlightIDCancleFlight.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblFlightIDCancleFlight.Location = New Point(216, 152)
        LblFlightIDCancleFlight.Name = "LblFlightIDCancleFlight"
        LblFlightIDCancleFlight.Size = New Size(56, 21)
        LblFlightIDCancleFlight.TabIndex = 14
        LblFlightIDCancleFlight.Text = "Label1"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.delay_flight_
        ClientSize = New Size(626, 433)
        Controls.Add(LblFlightIDCancleFlight)
        Controls.Add(tbxReasonCancelFlight)
        Controls.Add(btnDelayCancelFlight)
        Controls.Add(btnCancleCancelFlight)
        Controls.Add(btnReturnCancelFlight)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReturnCancelFlight As Button
    Friend WithEvents btnCancleCancelFlight As Button
    Friend WithEvents btnDelayCancelFlight As Button
    Friend WithEvents tbxReasonCancelFlight As TextBox
    Friend WithEvents LblFlightIDCancleFlight As Label
End Class
