Imports System.IO
Public Class Form3

    Dim planes As String
    Public Sub DisappearAllLabel()
        lblAirbus320.Visible = False
        lblAirbus321.Visible = False
        lblAirbus330300.Visible = False

    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnAirbus320)
        MakeTransparent(btnAirbus321)
        MakeTransparent(btnAirbus330300)
    End Sub

    Private Sub btnAirbus320_Click(sender As Object, e As EventArgs) Handles btnAirbus320.Click
        planes = "Airbus 320"
        DisappearAllLabel()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearLabel(lblAirbus320)


    End Sub

    Private Sub btnAirbus321_Click(sender As Object, e As EventArgs) Handles btnAirbus321.Click
        planes = "Airbus A321"
        DisappearAllLabel()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearLabel(lblAirbus321)
    End Sub

    Private Sub btnAirbus330300_Click(sender As Object, e As EventArgs) Handles btnAirbus330300.Click
        planes = "Airbus A330-300"
        DisappearAllLabel()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearLabel(lblAirbus330300)
    End Sub
    Private Sub ptbImages_Click(sender As Object, e As EventArgs) Handles ptbImages.Click

    End Sub


End Class