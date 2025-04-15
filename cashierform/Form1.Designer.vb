<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formCashierBooking
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
        lblMainBooking = New Label()
        btnBooking = New Button()
        btnTicket = New Button()
        pnlleftInfo = New Panel()
        pnlRightInfo = New Panel()
        btnClear = New Button()
        btnBook = New Button()
        SuspendLayout()
        ' 
        ' lblMainBooking
        ' 
        lblMainBooking.BackColor = SystemColors.ActiveCaption
        lblMainBooking.Location = New Point(30, 92)
        lblMainBooking.Name = "lblMainBooking"
        lblMainBooking.Size = New Size(1490, 792)
        lblMainBooking.TabIndex = 0
        ' 
        ' btnBooking
        ' 
        btnBooking.Location = New Point(30, 17)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(194, 58)
        btnBooking.TabIndex = 1
        btnBooking.Text = "BOOKING"
        btnBooking.UseVisualStyleBackColor = True
        ' 
        ' btnTicket
        ' 
        btnTicket.Location = New Point(244, 16)
        btnTicket.Name = "btnTicket"
        btnTicket.Size = New Size(194, 58)
        btnTicket.TabIndex = 2
        btnTicket.Text = "TICKET"
        btnTicket.UseVisualStyleBackColor = True
        ' 
        ' pnlleftInfo
        ' 
        pnlleftInfo.Location = New Point(60, 144)
        pnlleftInfo.Name = "pnlleftInfo"
        pnlleftInfo.Size = New Size(744, 699)
        pnlleftInfo.TabIndex = 3
        ' 
        ' pnlRightInfo
        ' 
        pnlRightInfo.Location = New Point(843, 144)
        pnlRightInfo.Name = "pnlRightInfo"
        pnlRightInfo.Size = New Size(648, 620)
        pnlRightInfo.TabIndex = 4
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1083, 785)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(194, 58)
        btnClear.TabIndex = 5
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBook
        ' 
        btnBook.Location = New Point(1297, 785)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(194, 58)
        btnBook.TabIndex = 7
        btnBook.Text = "BOOK"
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' formCashierBooking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1545, 910)
        Controls.Add(btnBook)
        Controls.Add(btnClear)
        Controls.Add(pnlRightInfo)
        Controls.Add(pnlleftInfo)
        Controls.Add(btnTicket)
        Controls.Add(btnBooking)
        Controls.Add(lblMainBooking)
        Margin = New Padding(2)
        Name = "formCashierBooking"
        Text = " "
        ResumeLayout(False)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents lblMainBooking As Label
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnTicket As Button
    Friend WithEvents pnlleftInfo As Panel
    Friend WithEvents pnlRightInfo As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBook As Button
End Class
