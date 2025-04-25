Public Class Form1
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub

End Class
