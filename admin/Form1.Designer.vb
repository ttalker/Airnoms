<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        pbxAdmin = New PictureBox()
        btnFlights = New Button()
        btnTransactions = New Button()
        btnExit = New Button()
        btnCancelFlight = New Button()
        btnAddFlight = New Button()
        btnBookings = New Button()
        btnViewFlightAdmin = New Button()
        dgvFlights = New DataGridView()
        CType(pbxAdmin, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvFlights, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbxAdmin
        ' 
        pbxAdmin.BackgroundImage = My.Resources.Resources.Admin_Panel_TEST_2
        pbxAdmin.Location = New Point(-4, -1)
        pbxAdmin.Name = "pbxAdmin"
        pbxAdmin.Size = New Size(1552, 916)
        pbxAdmin.TabIndex = 0
        pbxAdmin.TabStop = False
        ' 
        ' btnFlights
        ' 
        btnFlights.Location = New Point(43, 28)
        btnFlights.Name = "btnFlights"
        btnFlights.Size = New Size(185, 70)
        btnFlights.TabIndex = 1
        btnFlights.Text = " "
        btnFlights.UseVisualStyleBackColor = True
        ' 
        ' btnTransactions
        ' 
        btnTransactions.Location = New Point(307, 27)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(213, 70)
        btnTransactions.TabIndex = 2
        btnTransactions.Text = " "
        btnTransactions.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(782, 27)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(146, 70)
        btnExit.TabIndex = 4
        btnExit.Text = " "
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnCancelFlight
        ' 
        btnCancelFlight.Location = New Point(1109, 794)
        btnCancelFlight.Name = "btnCancelFlight"
        btnCancelFlight.Size = New Size(164, 66)
        btnCancelFlight.TabIndex = 5
        btnCancelFlight.Text = " "
        btnCancelFlight.UseVisualStyleBackColor = True
        ' 
        ' btnAddFlight
        ' 
        btnAddFlight.Location = New Point(1289, 795)
        btnAddFlight.Name = "btnAddFlight"
        btnAddFlight.Size = New Size(164, 66)
        btnAddFlight.TabIndex = 6
        btnAddFlight.Text = " "
        btnAddFlight.UseVisualStyleBackColor = True
        ' 
        ' btnBookings
        ' 
        btnBookings.Location = New Point(580, 27)
        btnBookings.Name = "btnBookings"
        btnBookings.Size = New Size(183, 70)
        btnBookings.TabIndex = 9
        btnBookings.Text = " "
        btnBookings.UseVisualStyleBackColor = True
        ' 
        ' btnViewFlightAdmin
        ' 
        btnViewFlightAdmin.Location = New Point(939, 794)
        btnViewFlightAdmin.Name = "btnViewFlightAdmin"
        btnViewFlightAdmin.Size = New Size(164, 66)
        btnViewFlightAdmin.TabIndex = 10
        btnViewFlightAdmin.Text = " "
        btnViewFlightAdmin.UseVisualStyleBackColor = True
        ' 
        ' dgvFlights
        ' 
        dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFlights.Location = New Point(143, 264)
        dgvFlights.Name = "dgvFlights"
        dgvFlights.Size = New Size(1245, 500)
        dgvFlights.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 911)
        Controls.Add(dgvFlights)
        Controls.Add(btnViewFlightAdmin)
        Controls.Add(btnBookings)
        Controls.Add(btnAddFlight)
        Controls.Add(btnCancelFlight)
        Controls.Add(btnExit)
        Controls.Add(btnTransactions)
        Controls.Add(btnFlights)
        Controls.Add(pbxAdmin)
        Name = "Form1"
        Text = "FLIGHTS"
        CType(pbxAdmin, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvFlights, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbxAdmin As PictureBox
    Friend WithEvents btnFlights As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancelFlight As Button
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnViewFlightAdmin As Button
    Friend WithEvents dgvFlights As DataGridView

End Class
