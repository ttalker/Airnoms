'Imports cashierform
'Imports userForm.Module1
Imports SharedModule
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnFlights)
        MakeTransparent(btnTransactions)
        MakeTransparent(btnBookings)
        MakeTransparent(btnExit)
        btnFlights.Parent = pbxAdmin
        btnTransactions.Parent = pbxAdmin
        btnBookings.Parent = pbxAdmin
        btnExit.Parent = pbxAdmin


        ' transparency of the buttons
        hoverButton(btnFlights)
        hoverButton(btnTransactions)
        hoverButton(btnBookings)
        hoverButton(btnExit)
        ' transparency of the background

        Me.DoubleBuffered = True
    End Sub

    Private Sub btnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Form1.Show()
        Me.Hide()
        Form2.Hide()
    End Sub
    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Me.Show()
        Form1.Hide()
        Form2.Hide()
    End Sub
    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        Me.Hide()
        Form1.Hide()
        Form2.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'ExitApplication(Me)
    End Sub
End Class