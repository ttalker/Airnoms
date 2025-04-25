Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(1563, 957)
    End Sub

    Private Sub btnHomeUser_Click(sender As Object, e As EventArgs) Handles btnHomeUser.Click
        Me.Show()
        Form4.Hide()
    End Sub

    Private Sub btnBookingUser_Click(sender As Object, e As EventArgs) Handles btnBookingUser.Click
        Me.Hide()
        Form4.Show()
    End Sub



    'im trying border radius on label'

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    '    Label1.Size = borderRadius.Size
    'End Sub

End Class
