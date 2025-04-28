Imports SharedModule
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnSignIn)
        MakeTransparent(btnCreateAccount)
        btnSignIn.Parent = pbxSignIn
        btnCreateAccount.Parent = pbxSignIn
        hoverButton(btnSignIn)
        hoverButton(btnCreateAccount)
        btnSignIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnSignIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255) ' effects for button
        Me.DoubleBuffered = True
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Me.Hide()
        Form3.Show()
    End Sub


End Class
