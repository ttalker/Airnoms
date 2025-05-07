'Imports cashierform
'Imports userForm.Module1
Imports SharedModule
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnFlights)
        MakeTransparent(btnTransactions)
        MakeTransparent(btnBookings)
        MakeTransparent(btnExit)
        MakeTransparent(btnCancelFlight)
        MakeTransparent(btnAddFlight)
        MakeTransparent(btnViewFlightAdmin)
        btnFlights.Parent = pbxAdmin
        btnTransactions.Parent = pbxAdmin
        btnBookings.Parent = pbxAdmin
        btnExit.Parent = pbxAdmin
        btnCancelFlight.Parent = pbxAdmin
        btnAddFlight.Parent = pbxAdmin
        btnViewFlightAdmin.Parent = pbxAdmin

        ' transparency of the buttons
        hoverButton(btnViewFlightAdmin)
        hoverButton(btnFlights)
        hoverButton(btnTransactions)
        hoverButton(btnBookings)
        hoverButton(btnExit)
        hoverButton(btnCancelFlight)
        hoverButton(btnAddFlight)
        ' transparency of the background

        Me.DoubleBuffered = True
        btnCancelFlight.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnCancelFlight.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)





    End Sub

    Private Sub btnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Me.Show()
        Form2.Hide()
        Form3.Hide()
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Me.Hide()
        Form2.Show()
        Form3.Hide()
    End Sub

    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        Me.Hide()
        Form2.Hide()
        Form3.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'ExitApplication(Me)
    End Sub

    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Form4.Show()
        Me.Enabled = False
    End Sub
End Class

