Imports SharedModule

'Imports userForm.Module1

Public Class Cancel_Delay_Form
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBackAdmin_Click(sender As Object, e As EventArgs)
        Form1.Enabled = True
        Hide()

    End Sub



End Class



    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        Dim pilot As String
        pilot = cbxPilotAdmin.Text
        cbxPilotAdmin.Items.Add(pilot)
    End Sub

