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
        Me.btnBookings = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnFlights = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBookings
        '
        Me.btnBookings.Location = New System.Drawing.Point(586, 27)
        Me.btnBookings.Name = "btnBookings"
        Me.btnBookings.Size = New System.Drawing.Size(184, 69)
        Me.btnBookings.TabIndex = 4
        Me.btnBookings.Text = " "
        Me.btnBookings.UseVisualStyleBackColor = True
        '
        'btnTransaction
        '
        Me.btnTransaction.Location = New System.Drawing.Point(274, 28)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(244, 69)
        Me.btnTransaction.TabIndex = 5
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'btnFlights
        '
        Me.btnFlights.Location = New System.Drawing.Point(50, 27)
        Me.btnFlights.Name = "btnFlights"
        Me.btnFlights.Size = New System.Drawing.Size(186, 69)
        Me.btnFlights.TabIndex = 6
        Me.btnFlights.Text = " "
        Me.btnFlights.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.admin.My.Resources.Resources.Admin_Panel_bookings_1
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1549, 915)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(789, 28)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(166, 69)
        Me.btnExit.TabIndex = 9
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 911)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFlights)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.btnBookings)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.Text = "BOOKINGS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnFlights As Button
    Friend WithEvents btnExit As Button
End Class
