Imports cashierform

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.MakeTransparent(btnSignIn)
        Module1.MakeTransparent(btnSignUp)
        btnSignIn.Parent = pbxSignUp
        btnSignUp.Parent = pbxSignUp
        Module1.hoverButton(btnSignIn)
        Module1.hoverButton(btnSignUp)
        btnSignUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnSignUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255) ' effects for button
        Me.DoubleBuffered = True



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class