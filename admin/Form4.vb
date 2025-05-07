
﻿'Imports cashierform
'Imports userForm.Module1
Imports SharedModule
Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnAddAdmin)
        MakeTransparent(btnAddFlight)
        MakeTransparent(btnCLearAdmin)
        MakeTransparent(btnBackAdmin)

        hoverButton(btnAddAdmin)
        hoverButton(btnAddFlight)
        hoverButton(btnBackAdmin)
        hoverButton(btnCLearAdmin)


    End Sub

    Private Sub btnBackAdmin_Click(sender As Object, e As EventArgs) Handles btnBackAdmin.Click
        Form1.Enabled = True
        Me.Hide()

    End Sub

    Private Sub btnCLearAdmin_Click(sender As Object, e As EventArgs) Handles btnCLearAdmin.Click
        tbxDepartureAdmin.Clear()
        tbxDestinationAdmin.Clear()
        tbxDepartureTimeAdmin.Clear()
        cbxPilotAdmin.Text = ""
        cbxPlaneAdmin.Text = ""
    End Sub

﻿Public Class Cancel_Delay_Form

End Class