Imports System.IO
Public Class Form3
    Dim planes As String
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnAirbus320, pnlButtons)
    End Sub
End Class