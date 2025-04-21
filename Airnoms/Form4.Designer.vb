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
        btnBookingUser = New Button()
        btnHomeUser = New Button()
        lblMainUser = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
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
        lblMainUser.BackColor = SystemColors.ActiveCaption
        lblMainUser.Location = New Point(27, 97)
        lblMainUser.Name = "lblMainUser"
        lblMainUser.Size = New Size(1490, 834)
        lblMainUser.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(50, 120)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(870, 363)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(50, 504)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(870, 405)
        Panel2.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(940, 120)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(556, 789)
        Panel3.TabIndex = 7
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1545, 953)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnBookingUser)
        Controls.Add(btnHomeUser)
        Controls.Add(lblMainUser)
        MaximumSize = New Size(1563, 1000)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBookingUser As Button
    Friend WithEvents btnHomeUser As Button
    Friend WithEvents lblMainUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
