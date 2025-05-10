Imports MySql.Data.MySqlClient
Imports SharedModule
Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnBack)
        MakeTransparent(btnSearch)

        hoverButton(btnBack)
        hoverButton(btnSearch)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Form1.Enabled = True
        Me.Hide()
    End Sub
End Class