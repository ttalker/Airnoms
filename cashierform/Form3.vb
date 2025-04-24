Imports System.IO
Public Class Form3

    Dim planes As String
    Public Sub DisappearAllLabel()
        lblAirbus320.Visible = False
        lblAirbus321.Visible = False
        lblAirbus330300.Visible = False
        lblAirbus350900.Visible = False
        lblAirbus330800.Visible = False
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        MakeTransparent(btnAirbus320)
        MakeTransparent(btnAirbus321)
        MakeTransparent(btnAirbus330300)
        MakeTransparent(btnAirbus350900)
        MakeTransparent(btnAirbus330800)

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

    Private Sub btnAirbus350900_Click(sender As Object, e As EventArgs) Handles btnAirbus350900.Click
        planes = "Airbus A350-900"
        DisappearAllLabel()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearLabel(lblAirbus350900)
    End Sub

    Private Sub btnAirbus330800_Click(sender As Object, e As EventArgs) Handles btnAirbus330800.Click
        planes = "Airbus A330-800"
        DisappearAllLabel()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearLabel(lblAirbus330800)
    End Sub
End Class