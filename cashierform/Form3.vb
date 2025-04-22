Imports System.IO
Public Class Form3

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ptbImages.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlanes.SelectedIndexChanged
        Dim planes As String = cmbPlanes.Text()
        Dim filepath As String = Path.Combine(Application.StartupPath, "Seatmaps/", planes & ".png")

        ptbImages.Image = Image.FromFile(filepath)


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class