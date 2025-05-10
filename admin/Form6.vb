Imports MySql.Data.MySqlClient
Imports SharedModule
Public Class Form6
    Private Sub btnAddFlightAdmin_Click(sender As Object, e As EventArgs) Handles btnReturnCancelFlight.Click
        Form1.Enabled = True
        Me.Hide()

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnCancleCancelFlight)
        MakeTransparent(btnDelayCancelFlight)
        MakeTransparent(btnReturnCancelFlight)

        hoverButton(btnCancleCancelFlight)
        hoverButton(btnDelayCancelFlight)
        hoverButton(btnReturnCancelFlight)
    End Sub
End Class