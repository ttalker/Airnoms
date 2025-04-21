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
        btnBookingUser = New Button()
        btnHomeUser = New Button()
        lblMainUser = New Label()
        SuspendLayout()
        ' 
        ' btnBookingUser
        ' 
        btnBookingUser.Location = New Point(241, 21)
        btnBookingUser.Name = "btnBookingUser"
        btnBookingUser.Size = New Size(194, 58)
        btnBookingUser.TabIndex = 5
        btnBookingUser.Text = "BOOKING"
        btnBookingUser.UseVisualStyleBackColor = True
        ' 
        ' btnHomeUser
        ' 
        btnHomeUser.Location = New Point(27, 22)
        btnHomeUser.Name = "btnHomeUser"
        btnHomeUser.Size = New Size(194, 58)
        btnHomeUser.TabIndex = 4
        btnHomeUser.Text = "HOME"
        btnHomeUser.UseVisualStyleBackColor = True
        ' 
        ' lblMainUser
        ' 
        lblMainUser.Image = My.Resources.Resources.Main
        lblMainUser.Location = New Point(29, 101)
        lblMainUser.Name = "lblMainUser"
        lblMainUser.Size = New Size(1488, 781)
        lblMainUser.TabIndex = 6
        lblMainUser.Text = " "
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1545, 910)
        Controls.Add(lblMainUser)
        Controls.Add(btnBookingUser)
        Controls.Add(btnHomeUser)
        MaximumSize = New Size(1563, 957)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBookingUser As Button
    Friend WithEvents btnHomeUser As Button
    Friend WithEvents lblMainUser As Label
End Class
