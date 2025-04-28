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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        btnExit = New Button()
        btnBookings = New Button()
        btnFlights = New Button()
        pbxAdmin = New PictureBox()
        btnTransactions = New Button()
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
        pbxAdmin.BackgroundImage = CType(resources.GetObject("pbxAdmin.BackgroundImage"), Image)
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
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 881)
        Controls.Add(btnTransactions)
        Controls.Add(btnExit)
        Controls.Add(btnBookings)
        Controls.Add(btnFlights)
        Controls.Add(pbxAdmin)
        Name = "Form3"
        Text = "BOOKINGS"
        CType(pbxAdmin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnFlights As Button
    Friend WithEvents pbxAdmin As PictureBox
    Friend WithEvents btnTransactions As Button
End Class
