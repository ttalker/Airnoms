'Imports System.Reflection
Imports cashierform
Imports SharedModule
Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnHomeUser)
        MakeTransparent(btnBookingUser)
        MakeTransparent(btnSupportUser)
        MakeTransparent(btnExitUser)
        btnHomeUser.Parent = pbxHome
        btnBookingUser.Parent = pbxHome
        btnSupportUser.Parent = pbxHome
        btnExitUser.Parent = pbxHome
        hoverButton(btnHomeUser)
        hoverButton(btnBookingUser)
        hoverButton(btnSupportUser)
        hoverButton(btnExitUser)

    End Sub

    Private Sub btnHomeUser_Click(sender As Object, e As EventArgs) Handles btnHomeUser.Click
        Me.Show()
        Form4.Hide()
    End Sub

    Private Sub btnBookingUser_Click(sender As Object, e As EventArgs) Handles btnBookingUser.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnSupportUser_Click(sender As Object, e As EventArgs) Handles btnSupportUser.Click
        Dim supportForm As New cashierform.Form3
        supportForm.Show()
    End Sub




End Class
