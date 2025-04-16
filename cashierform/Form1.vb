Public Class Form1



    Private Sub rbnOneWayTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rbnOneWayTrip.CheckedChanged
        lblArrivalDate.Visible = False
        dtpArrival.Visible = False
    End Sub

    Private Sub rbnRoundTrip_CheckedChanged(sender As Object, e As EventArgs) Handles rbnRoundTrip.CheckedChanged
        lblArrivalDate.Visible = True
        dtpArrival.Visible = True
    End Sub


End Class
