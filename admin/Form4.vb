Imports MySql.Data.MySqlClient
Imports SharedModule
Public Class Form4
    Private Sub btnAddPilotAdmin_Click(sender As Object, e As EventArgs) Handles btnAddPilotAdmin.Click
        Dim pilot As String
        pilot = cbxPilotAdmin.Text

        cbxPilotAdmin.Items.Add(pilot)
    End Sub

    Private Sub btnClearAdmin_Click(sender As Object, e As EventArgs) Handles btnClearAdmin.Click
        tbxDepartureADmin.Clear()
        tbxDestinationADmin.Clear()
        tbxDepartureTimeADmin.Clear()
        cbxPilotAdmin.Text = ""
        cbxPlaneAdmin.Text = ""
    End Sub

    Private Sub btnReturnAdmin_Click(sender As Object, e As EventArgs) Handles btnReturnAdmin.Click

        Form1.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnAddFlightAdmin)
        MakeTransparent(btnAddPilotAdmin)
        MakeTransparent(btnClearAdmin)
        MakeTransparent(btnReturnAdmin)

        hoverButton(btnAddFlightAdmin)
        hoverButton(btnAddPilotAdmin)
        hoverButton(btnClearAdmin)
        hoverButton(btnReturnAdmin)
    End Sub
End Class