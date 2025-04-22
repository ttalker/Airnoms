Imports System.IO
Public Class Form3

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlanes.SelectedIndexChanged

        Dim planes As String = cmbPlanes.Text()
        Dim filepath As String = Path.Combine(Application.StartupPath, "Seatmaps", planes & ".png")
        ptbImages.Size = New Size(1, 1)
        ptbImages.Location = New Point(0, 0)
        If ptbImages.Image IsNot Nothing Then
            ptbImages.Image.Dispose()
        End If

        Dim img As Image = Image.FromFile(filepath)
        ptbImages.Image = img

        ptbImages.SizeMode = PictureBoxSizeMode.Zoom

        Dim panelWidth = Panel1.ClientSize.Width
        Dim aspectRatio = img.Height / img.Width
        Dim newWidth = panelWidth
        Dim newHeight = CInt(newWidth * aspectRatio)

        ptbImages.Size = New Size(newWidth, newHeight)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class