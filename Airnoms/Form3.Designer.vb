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
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBookingUser
        ' 
        btnBookingUser.Location = New Point(283, 42)
        btnBookingUser.Margin = New Padding(2)
        btnBookingUser.Name = "btnBookingUser"
        btnBookingUser.Size = New Size(155, 46)
        btnBookingUser.TabIndex = 5
        btnBookingUser.Text = "BOOKING"
        btnBookingUser.UseVisualStyleBackColor = True
        ' 
        ' btnHomeUser
        ' 
        btnHomeUser.Location = New Point(75, 42)
        btnHomeUser.Margin = New Padding(2)
        btnHomeUser.Name = "btnHomeUser"
        btnHomeUser.Size = New Size(155, 46)
        btnHomeUser.TabIndex = 4
        btnHomeUser.Text = "HOME"
        btnHomeUser.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.MAIN_REFERENCE__1_
        PictureBox1.Location = New Point(-1, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1554, 937)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1547, 930)
        Controls.Add(btnBookingUser)
        Controls.Add(btnHomeUser)
        Controls.Add(PictureBox1)
        Margin = New Padding(2)
        MaximumSize = New Size(1563, 969)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBookingUser As Button
    Friend WithEvents btnHomeUser As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
