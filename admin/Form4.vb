Imports SharedModule
Imports MySql.Data.MySqlClient


Public Class Form4
    Private flightID As String
    Public FlightWasCancelled As Boolean = False


    ' Call this when showing the form
    Public Sub LoadFlightDetails(selectedFlightID As String)
        flightID = selectedFlightID
        lblFlight_Id.Text = selectedFlightID ' Show in label
    End Sub

    ' Delay flight by 2–3 hours
    Private Sub btnDelayFlight_Click(sender As Object, e As EventArgs) Handles btnDelayFlight.Click
        Dim delayHours As Integer = (New Random()).Next(2, 4) ' 2 or 3
        DelayFlight(flightID, delayHours) ' Call from module

        MessageBox.Show($"Flight {flightID} delayed by {delayHours} hour(s).", "Delayed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    ' Cancel the flight
    Private Sub btnCancelFlight_Click(sender As Object, e As EventArgs) Handles btnCancelFlight.Click
        CancelFlight(flightID)
        FlightWasCancelled = True
        MessageBox.Show($"Flight {flightID} has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Me.Close()
    End Sub


    ' Close popup
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class
