Imports System.IO

Module Module1
    Public Sub ShowImage(planes As String)
        Dim filepath = Path.Combine(Application.StartupPath, "Seatmaps", planes & ".png")
        Form3.ptbImages.Size = New Size(1, 1)
        Form3.ptbImages.Location = New Point(0, 0)
        If Form3.ptbImages.Image IsNot Nothing Then
            Form3.ptbImages.Image.Dispose()
        End If

        Dim img = Image.FromFile(filepath)
        Form3.ptbImages.Image = img

        Form3.ptbImages.SizeMode = PictureBoxSizeMode.Zoom

        Dim panelWidth = Form3.pnlPlane.ClientSize.Width
        Dim aspectRatio = img.Height / img.Width
        Dim newWidth = panelWidth
        Dim newHeight = CInt(newWidth * aspectRatio)

        Form3.ptbImages.Size = New Size(newWidth, newHeight)

    End Sub

    Public Sub MakeTransparent(button As Button)
        button.BackColor = Color.Transparent
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.FlatAppearance.MouseOverBackColor = Color.Transparent
        button.FlatAppearance.MouseDownBackColor = Color.Transparent
        button.BackColor = Color.Transparent
    End Sub

    Public Sub DisappearAllLabel()
        Form3.lblAirbus320.Visible = False

    End Sub

    Public Sub AppearLabel(label As Label)
        label.Visible = True
    End Sub

End Module
