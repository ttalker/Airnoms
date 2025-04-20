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
        btnTicket = New Button()
        btnBooking = New Button()
        btnBook = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(241, 21)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(194, 58)
        btnTicket.TabIndex = 14
        btnTicket.Text = "TICKET"
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(27, 22)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(194, 58)
        btnBooking.TabIndex = 13
        btnBooking.Text = "BOOKING"
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' btnBook
        ' 
        btnBook.Location = New Point(1294, 797)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(194, 58)
        btnBook.TabIndex = 18
        btnBook.Text = "BOOK"
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1080, 797)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(194, 58)
        btnClear.TabIndex = 17
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1545, 910)
        Controls.Add(btnTicket)
        Controls.Add(btnBooking)
        Controls.Add(btnBook)
        Controls.Add(btnClear)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnTicket As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents btnClear As Button
End Class
