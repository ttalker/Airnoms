Imports System.IO
Public Class Form3

    Dim planes As String

    Public Sub DisappearAllPicture()
        pbxAB321.Visible = False
        pbxAB320.Visible = False
        pbxA330300.Visible = False
        pbx350.Visible = False
        pbxAB330800.Visible = False
        pbxBoeing737800.Visible = False
        pbx737MAX.Visible = False

        pbx300er.Visible = False
        pbx7879.Visible = False
        pbx7478.Visible = False
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DoubleBuffered = True
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        MakeTransparent(btnAirbus320)
        MakeTransparent(btnAirbus321)
        MakeTransparent(btnAirbus330300)
        MakeTransparent(btnAirbus350900)
        MakeTransparent(btnAirbus330800)
        MakeTransparent(btnBoeing737800)
        MakeTransparent(btnBoeing737MAX)
        MakeTransparent(btnBoeing77300er)
        MakeTransparent(btnBoeing7879)
        MakeTransparent(btnBoeing7478)
    End Sub

    Private Sub btnAirbus320_Click(sender As Object, e As EventArgs) Handles btnAirbus320.Click
        planes = "Airbus 320"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbxAB320)

    End Sub

    Private Sub btnAirbus321_Click(sender As Object, e As EventArgs) Handles btnAirbus321.Click
        planes = "Airbus A321"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbxAB321)
    End Sub


    Private Sub btnAirbus330300_Click(sender As Object, e As EventArgs) Handles btnAirbus330300.Click
        planes = "Airbus A330-300"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbxA330300)
    End Sub

    Private Sub btnAirbus350900_Click(sender As Object, e As EventArgs) Handles btnAirbus350900.Click
        planes = "Airbus A350-900"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbx350)
    End Sub

    Private Sub btnAirbus330800_Click(sender As Object, e As EventArgs) Handles btnAirbus330800.Click
        planes = "Airbus A330-800"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbxAB330800)
    End Sub

    Private Sub btnBoeing737800_Click(sender As Object, e As EventArgs) Handles btnBoeing737800.Click
        planes = "Boeing 737-800"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbxBoeing737800)
    End Sub

    Private Sub btnBoeing737MAX_Click(sender As Object, e As EventArgs) Handles btnBoeing737MAX.Click
        planes = "Boeing 737 MAX 8"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbx737MAX)
    End Sub

    Private Sub btnBoeing77300er_Click(sender As Object, e As EventArgs) Handles btnBoeing77300er.Click
        planes = "Boeing 777-300ER"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbx300er)
    End Sub

    Private Sub btnBoeing7879_Click(sender As Object, e As EventArgs) Handles btnBoeing7879.Click
        planes = "Boeing 787-9"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbx7879)
    End Sub

    Private Sub btnBoeing7478_Click(sender As Object, e As EventArgs) Handles btnBoeing7478.Click
        planes = "Boeing 747-8"
        DisappearAllPicture()
        ShowImage(planes, ptbImages, pnlPlane)
        AppearPicture(pbx7478)
    End Sub


End Class