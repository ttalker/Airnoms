Imports System.IO

Imports MySql.Data.MySqlClient
'Imports System.Data.SqlClient
'Imports cashierform
'Imports userform
Public Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    'Public rd As MySqlDataReader = cmd.ExecuteReader()

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

    Public Function IsPWD(check As CheckBox) As String
        If check.Checked Then
            Return "Yes"
        Else
            Return "No"
        End If
    End Function

    Public customer_info_list As New List(Of CustomerInfo)

End Module

Public Class CustomerInfo
    Public Property Fullname As String
    Public Property Age As Integer
    Public Property Birthdate As Date
    Public Property Address As String
    Public Property Gender As String
    Public Property Seat As String
    Public Property Baggage As Integer
    Public Property IsPwd As Boolean

    Public Property Destination As String
    Public Property Departure As String
    Public Property Depart_date As Date
    Public Property Depart_time As String

    Public Property Arrival_date As Date
    Public Property Arrival_time As String

    'constructor (objects should only be instantiated after fulfilling conditions)

    ' Constructor WITHOUT Arrival info
    Public Sub New(fullname As String, age As Integer, birthdate As Date, address As String, gender As String,
                   seat As String, baggage As Integer, isPwd As Boolean, destination As String,
                   departure As String, depart_date As Date, depart_time As String)
        Me.Fullname = fullname
        Me.Age = age
        Me.Birthdate = birthdate
        Me.Address = address
        Me.Gender = gender
        Me.Seat = seat
        Me.Baggage = baggage
        Me.IsPwd = isPwd
        Me.Destination = destination
        Me.Departure = departure
        Me.Depart_date = depart_date
        Me.Depart_time = depart_time
        ' Arrival_date and Arrival_time remain default (e.g., 1/1/0001 and "")

    End Sub

    ' Constructor WITH Arrival info
    Public Sub New(fullname As String, age As Integer, birthdate As Date, address As String, gender As String,
                   seat As String, baggage As Integer, isPwd As Boolean, destination As String,
                   departure As String, depart_date As Date, depart_time As String, arrival_date As Date, arrival_time As String)
        Me.Fullname = fullname
        Me.Age = age
        Me.Birthdate = birthdate
        Me.Address = address
        Me.Gender = gender
        Me.Seat = seat
        Me.Baggage = baggage
        Me.IsPwd = isPwd
        Me.Destination = destination
        Me.Departure = departure
        Me.Depart_date = depart_date
        Me.Depart_time = depart_time
        Me.Arrival_date = arrival_date
        Me.Arrival_time = arrival_time
    End Sub

End Class