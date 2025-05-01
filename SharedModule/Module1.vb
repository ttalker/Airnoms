Imports System.IO

Imports MySql.Data.MySqlClient
'Imports System.Data.SqlClient
'Imports cashierform
'Imports userform
Public Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public rd As MySqlDataReader = cmd.ExecuteReader()

    'admin sql
    Public Sub openCon()
        con.ConnectionString = "server=100.89.19.71; username=root; password=; database=comprog_db"
        con.Open()
    End Sub

    'cashier
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

    Public Sub AppearLabel(label As Label)
        label.Visible = True
        label.BringToFront()
    End Sub

    Public Sub AppearPicture(pbx As PictureBox)
        pbx.Visible = True
        pbx.BringToFront()
    End Sub

    Public Sub hoverButton(btn As Button)
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 79, 176, 231)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 79, 176, 231)
    End Sub


    'userform
    'Sub LogoutAndRedirect(currentForm As Form, loginFormType As Type)
    '    currentForm.Hide()
    '    Dim loginForm As Form = Activator.CreateInstance(loginFormType)
    '    loginForm.Show()
    'End Sub

    Public Sub Provide_tbxError(tbx As TextBox, errors As ErrorProvider)
        If String.IsNullOrEmpty(tbx.Text) Then
            ' Display an error in the ErrorProvider
            errors.SetError(tbx, "This field is required.")
        Else
            ' Clear the error if the TextBox has text
            errors.SetError(tbx, "")
        End If
    End Sub

    Public Sub Provide_cbxError(cbx As ComboBox, errors As ErrorProvider)
        If cbx.SelectedIndex = -1 Then
            errors.SetError(cbx, "This field is required.")
        Else
            errors.SetError(cbx, "")
        End If
    End Sub

End Module