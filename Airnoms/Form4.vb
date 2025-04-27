Imports cashierform

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.MakeTransparent(btnHomeUser)
        Module1.MakeTransparent(btnBookingUser)
        Module1.MakeTransparent(btnSupportUser)
        Module1.MakeTransparent(btnExit)
        Module1.MakeTransparent(btnResetUser)
        Module1.MakeTransparent(btnBookUser)
        btnHomeUser.Parent = pbxUserBooking
        btnBookingUser.Parent = pbxUserBooking
        btnSupportUser.Parent = pbxUserBooking
        btnExit.Parent = pbxUserBooking
        btnResetUser.Parent = pbxUserBooking
        btnBookUser.Parent = pbxUserBooking
        Module1.hoverButton(btnHomeUser)
        Module1.hoverButton(btnBookingUser)
        Module1.hoverButton(btnSupportUser)
        Module1.hoverButton(btnExit)
        Module1.hoverButton(btnResetUser)
        Module1.hoverButton(btnBookUser)
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