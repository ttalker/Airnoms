<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnExit = New Button()
        btnTransactions = New Button()
        btnFlights = New Button()
        pbxAdmin = New PictureBox()
        btnBookings = New Button()
        dgvTransactionHistory = New DataGridView()
        CType(pbxAdmin, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTransactionHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(778, 32)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(146, 70)
        btnExit.TabIndex = 9
        btnExit.Text = " "
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnTransactions
        ' 
        btnTransactions.Location = New Point(283, 33)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(250, 70)
        btnTransactions.TabIndex = 7
        btnTransactions.Text = " "
        btnTransactions.UseVisualStyleBackColor = True
        ' 
        ' btnFlights
        ' 
        btnFlights.Location = New Point(53, 33)
        btnFlights.Name = "btnFlights"
        btnFlights.Size = New Size(185, 70)
        btnFlights.TabIndex = 6
        btnFlights.Text = " "
        btnFlights.UseVisualStyleBackColor = True
        ' 
        ' pbxAdmin
        ' 
        pbxAdmin.BackgroundImage = My.Resources.Resources.Admin__transaction_history_
        pbxAdmin.Location = New Point(-3, -2)
        pbxAdmin.Name = "pbxAdmin"
        pbxAdmin.Size = New Size(1552, 884)
        pbxAdmin.TabIndex = 5
        pbxAdmin.TabStop = False
        ' 
        ' btnBookings
        ' 
        btnBookings.Location = New Point(579, 34)
        btnBookings.Name = "btnBookings"
        btnBookings.Size = New Size(183, 70)
        btnBookings.TabIndex = 10
        btnBookings.Text = " "
        btnBookings.UseVisualStyleBackColor = True
        ' 
        ' dgvTransactionHistory
        ' 
        dgvTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactionHistory.Location = New Point(124, 238)
        dgvTransactionHistory.Name = "dgvTransactionHistory"
        dgvTransactionHistory.Size = New Size(1293, 579)
        dgvTransactionHistory.TabIndex = 11
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1547, 881)
        Controls.Add(dgvTransactionHistory)
        Controls.Add(btnBookings)
        Controls.Add(btnExit)
        Controls.Add(btnTransactions)
        Controls.Add(btnFlights)
        Controls.Add(pbxAdmin)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TRANSACTIONS"
        CType(pbxAdmin, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTransactionHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnFlights As Button
    Friend WithEvents pbxAdmin As PictureBox
    Friend WithEvents btnBookings As Button
    Friend WithEvents dgvTransactionHistory As DataGridView
End Class
