Imports cashierform
Imports SharedModule
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnHomeUser)
        MakeTransparent(btnBookingUser)
        MakeTransparent(btnSupportUser)
        MakeTransparent(btnExit)
        MakeTransparent(btnResetUser)
        MakeTransparent(btnBookUser)
        btnHomeUser.Parent = pbxUserBooking
        btnBookingUser.Parent = pbxUserBooking
        btnSupportUser.Parent = pbxUserBooking
        btnExit.Parent = pbxUserBooking
        btnResetUser.Parent = pbxUserBooking
        btnBookUser.Parent = pbxUserBooking
        hoverButton(btnHomeUser)
        hoverButton(btnBookingUser)
        hoverButton(btnSupportUser)
        hoverButton(btnExit)
        hoverButton(btnResetUser)
        hoverButton(btnBookUser)
        btnResetUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnResetUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)
        Me.DoubleBuffered = True
    End Sub

    Private Sub btnHomeUser_Click(sender As Object, e As EventArgs) Handles btnHomeUser.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub btnBookingUser_Click(sender As Object, e As EventArgs) Handles btnBookingUser.Click
        Show
        Form3.Hide
    End Sub

    Private Sub btnSupportUser_Click(sender As Object, e As EventArgs) Handles btnSupportUser.Click
        Dim supportForm As New cashierform.Form3
        supportForm.Show()
    End Sub
End Class