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
        pbxHome = New PictureBox()
        btnSupportUser = New Button()
        btnExitUser = New Button()
        CType(pbxHome, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBookingUser
        ' 
        btnBookingUser.Location = New Point(264, 27)
        btnBookingUser.Margin = New Padding(2)
        btnBookingUser.Name = "btnBookingUser"
        btnBookingUser.Size = New Size(182, 68)
        btnBookingUser.TabIndex = 5
        btnBookingUser.Text = " "
        btnBookingUser.UseVisualStyleBackColor = True
        ' 
        ' btnHomeUser
        ' 
        btnHomeUser.Location = New Point(58, 27)
        btnHomeUser.Margin = New Padding(2)
        btnHomeUser.Name = "btnHomeUser"
        btnHomeUser.Size = New Size(180, 68)
        btnHomeUser.TabIndex = 4
        btnHomeUser.Text = " "
        btnHomeUser.UseVisualStyleBackColor = True
        ' 
        ' pbxHome
        ' 
        pbxHome.BackgroundImage = My.Resources.Resources.MAIN_REFERENCE__2_1
        pbxHome.Location = New Point(-1, -2)
        pbxHome.Name = "pbxHome"
        pbxHome.Size = New Size(1554, 920)
        pbxHome.TabIndex = 6
        pbxHome.TabStop = False
        ' 
        ' btnSupportUser
        ' 
        btnSupportUser.Location = New Point(480, 27)
        btnSupportUser.Margin = New Padding(2)
        btnSupportUser.Name = "btnSupportUser"
        btnSupportUser.Size = New Size(182, 68)
        btnSupportUser.TabIndex = 7
        btnSupportUser.Text = " "
        btnSupportUser.UseVisualStyleBackColor = True
        ' 
        ' btnExitUser
        ' 
        btnExitUser.Location = New Point(676, 27)
        btnExitUser.Margin = New Padding(2)
        btnExitUser.Name = "btnExitUser"
        btnExitUser.Size = New Size(143, 68)
        btnExitUser.TabIndex = 8
        btnExitUser.Text = " "
        btnExitUser.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(253))
        ClientSize = New Size(1547, 930)
        Controls.Add(btnExitUser)
        Controls.Add(btnSupportUser)
        Controls.Add(btnBookingUser)
        Controls.Add(btnHomeUser)
        Controls.Add(pbxHome)
        Margin = New Padding(2)
        MaximumSize = New Size(1563, 969)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HOME"
        CType(pbxHome, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBookingUser As Button
    Friend WithEvents btnHomeUser As Button
    Friend WithEvents pbxHome As PictureBox

    Friend WithEvents btnSupportUser As Button
    Friend WithEvents btnExitUser As Button

End Class
