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
        btnTicket = New Button()
        btnBooking = New Button()
        lblMainBooking = New Label()
        SuspendLayout()
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(241, 21)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(194, 58)
        btnTicket.TabIndex = 5
        btnTicket.Text = "TICKET"
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(27, 22)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(194, 58)
        btnBooking.TabIndex = 4
        btnBooking.Text = "BOOKING"
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' lblMainBooking
        ' 
        lblMainBooking.BackColor = SystemColors.ActiveCaption
        lblMainBooking.Location = New Point(27, 97)
        lblMainBooking.Name = "lblMainBooking"
        lblMainBooking.Size = New Size(1490, 792)
        lblMainBooking.TabIndex = 3
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1545, 910)
        Controls.Add(btnTicket)
        Controls.Add(btnBooking)
        Controls.Add(lblMainBooking)
        MaximumSize = New Size(1563, 957)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnTicket As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents lblMainBooking As Label
End Class
