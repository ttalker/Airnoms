Imports System.IO

Module Module1
    Public Sub ShowImage(planes As String, ptbImages As PictureBox, pnlPlane As Panel)
        Dim filepath = Path.Combine(Application.StartupPath, "Seatmaps", planes & ".png")
        ptbImages.Size = New Size(1, 1)
        ptbImages.Location = New Point(0, 0)
        If ptbImages.Image IsNot Nothing Then
            ptbImages.Image.Dispose()
        End If

        Dim img = Image.FromFile(filepath)
        ptbImages.Image = img

        ptbImages.SizeMode = PictureBoxSizeMode.Zoom

        Dim panelWidth = pnlPlane.ClientSize.Width
        Dim aspectRatio = img.Height / img.Width
        Dim newWidth = panelWidth
        Dim newHeight = CInt(newWidth * aspectRatio)

        ptbImages.Size = New Size(newWidth, newHeight)

    End Sub


End Module
