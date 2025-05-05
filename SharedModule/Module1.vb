Imports System.IO

Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe
'Imports System.Data.SqlClient

Public Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public conn As New MySqlConnection
    Public cmd2 As New MySqlCommand

    'admin sql
    Public Sub openCon()
        con.ConnectionString = "server=100.89.19.71; username=root; password=; database=comprog_db"
        con.Open()
    End Sub
    Public Sub openConTesting()
        conn.ConnectionString = "server=100.89.19.71; username=root; password=; database=testing_db"
        conn.Open()
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

    Public Sub Provide_tbxError(tbx As TextBox, errors As ErrorProvider)
        If String.IsNullOrEmpty(tbx.Text) Then
            errors.SetError(tbx, "This field is required.")
        Else
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


Public Class PassengerInfo
    Public Property FullName As String
    Public Property Age As Integer
    Public Property DateOfBirth As Date
    Public Property Gender As String
    Public Property SeatNumber As String
    Public Property BaggageAllowance As String
    Public Property IsPWD As Boolean

    Public Sub New()
        ' Default constructor /  parameterless constructor
    End Sub
    Public Sub New(Fullname As String, Age As Integer, DateOfBirth As Date, Gender As String, SeatNumber As String, BaggageAllowance As String, isPWD As Boolean)
        Me.FullName = Fullname
        Me.Age = Age
        Me.DateOfBirth = DateOfBirth
        Me.Gender = Gender
        Me.SeatNumber = SeatNumber
        Me.BaggageAllowance = BaggageAllowance
        Me.IsPWD = isPWD
    End Sub
End Class

Public Class BookingInfo
    Public Property TripType As String
    Public Property Departure As String
    Public Property Destination As String
    Public Property DepartDate As Date
    Public Property DepartTime As String
    Public Property ArrivalDate As Date
    Public Property ArrivalTime As String
    Public Property BookingDate As Date

    ' Main Booker
    Public Property BookerFullName As String
    Public Property BookerAge As Integer
    Public Property BookerBirthDate As Date
    Public Property BookerGender As String
    Public Property BookerAddress As String
    Public Property BookerIsPWD As Boolean
    Public Property BookerSeatNumber As String
    Public Property BookerBaggageAllowance As String
    Public Property CoPassengers As List(Of PassengerInfo)
    Public Property countPassenger As Integer = 1

    Public Sub New()
        Me.CoPassengers = New List(Of PassengerInfo)()
    End Sub
    Public Sub New(tripType As String, departure As String, destination As String,
                   departDate As Date, departTime As String, arrivalDate As Date,
                   arrivalTime As String, bookingDate As Date,
                   bookerFullName As String, bookerAge As Integer,
                   bookerBirthDate As Date, bookerGender As String,
                   bookerAddress As String, bookerIsPWD As Boolean,
                   bookerSeatNumber As String, bookerBaggageAllowance As String,
                   countPassenger As Integer,
                   Optional coPassengers As List(Of PassengerInfo) = Nothing
                   )

        Me.TripType = tripType
        Me.Departure = departure
        Me.Destination = destination
        Me.DepartDate = departDate
        Me.DepartTime = departTime
        Me.ArrivalDate = arrivalDate
        Me.ArrivalTime = arrivalTime
        Me.BookingDate = bookingDate

        Me.BookerFullName = bookerFullName
        Me.BookerAge = bookerAge
        Me.BookerBirthDate = bookerBirthDate
        Me.BookerGender = bookerGender
        Me.BookerAddress = bookerAddress
        Me.BookerIsPWD = bookerIsPWD
        Me.BookerSeatNumber = bookerSeatNumber
        Me.BookerBaggageAllowance = bookerBaggageAllowance

        Me.CoPassengers = If(coPassengers, New List(Of PassengerInfo)())
        Me.countPassenger = countPassenger
    End Sub
End Class

