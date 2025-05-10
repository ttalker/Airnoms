'Imports cashierform
'Imports userForm.Module1
Imports MySql.Data.MySqlClient
Imports SharedModule
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnFlights)
        MakeTransparent(btnTransactions)
        MakeTransparent(btnBookings)
        MakeTransparent(btnExit)
        MakeTransparent(btnCancelFlight)
        MakeTransparent(btnAddFlight)
        MakeTransparent(btnViewFlightAdmin)
        btnFlights.Parent = pbxAdmin
        btnTransactions.Parent = pbxAdmin
        btnBookings.Parent = pbxAdmin
        btnExit.Parent = pbxAdmin
        btnCancelFlight.Parent = pbxAdmin
        btnAddFlight.Parent = pbxAdmin
        btnViewFlightAdmin.Parent = pbxAdmin

        ' transparency of the buttons
        hoverButton(btnViewFlightAdmin)
        hoverButton(btnFlights)
        hoverButton(btnTransactions)
        hoverButton(btnBookings)
        hoverButton(btnExit)
        hoverButton(btnCancelFlight)
        hoverButton(btnAddFlight)
        ' transparency of the background

        Me.DoubleBuffered = True
        btnCancelFlight.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnCancelFlight.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)



        GenerateAndSaveFlightsIfNotExist(Date.Today)
        AddStatusTimerToForm1_Load()
        UpdateFlightStatuses()
        LoadFlightsByDate(Date.Today)
    End Sub
    Public Sub LoadFlightsByDate(flightDate As Date)
        Dim dt As New DataTable()
        Try
            openCon()
            Dim query As String = "SELECT flight_id as 'Flight No.', 
                                     departure as 'From', 
                                     destination as 'To', 
                                     departure_date as 'Date',
                                     departure_time as 'Departure', 
                                     arrival_time as 'Arrival Time', 
                                     capacity as 'Capacity',
                                     status as 'Status'
                              FROM flight_table 
                              WHERE departure_date = @DepartureDate
                              ORDER BY departure_time"

            Dim adapter As New MySqlDataAdapter(query, con)
            adapter.SelectCommand.Parameters.AddWithValue("@DepartureDate", flightDate)
            adapter.Fill(dt)
            con.Close()

            dgvFlights.DataSource = Nothing
            dgvFlights.DataSource = dt
            dgvFlights.Refresh()

            FormatFlightDataGridView()
        Catch ex As Exception
            MessageBox.Show($"Error loading flights: {ex.Message}")
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub FormatFlightDataGridView()

        dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFlights.RowHeadersVisible = False
        dgvFlights.AllowUserToAddRows = False
        dgvFlights.AllowUserToDeleteRows = False
        dgvFlights.ReadOnly = True
        dgvFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Add color coding based on flight status
        For Each row As DataGridViewRow In dgvFlights.Rows
            Dim status As String = row.Cells("Status").Value.ToString()

            Select Case status
                Case "Waiting"
                    row.DefaultCellStyle.BackColor = Color.LightYellow
                Case "On Flight"
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                Case "Arrived"
                    row.DefaultCellStyle.BackColor = Color.LightGreen
            End Select
        Next
    End Sub

    ' Timer to update flight statuses automatically
    Private WithEvents statusUpdateTimer As New Timer()

    Private Sub InitializeStatusTimer()
        ' Update flight statuses every 5 minutes
        statusUpdateTimer.Interval = 5 * 60 * 1000 ' 5 minutes in milliseconds
        statusUpdateTimer.Start()
        AddHandler statusUpdateTimer.Tick, AddressOf StatusTimer_Tick
    End Sub

    Private Sub StatusTimer_Tick(sender As Object, e As EventArgs)
        ' Update flight statuses and refresh the grid
        UpdateFlightStatuses()
        RefreshFlightData()
    End Sub

    ' Call this in Form1_Load as well
    Private Sub AddStatusTimerToForm1_Load()
        ' Add this line to your Form1_Load method
        InitializeStatusTimer()
    End Sub

    ' Add this to your RefreshFlightData method
    Public Sub RefreshFlightData()
        ' Update flight statuses first
        UpdateFlightStatuses()
        ' Then load flights
        LoadFlightsByDate(Date.Today)
    End Sub

    Private Sub btnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Me.Show()
        Form2.Hide()
        Form3.Hide()
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Me.Hide()
        Form2.Show()
        Form3.Hide()
    End Sub

    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        Me.Hide()
        Form2.Hide()
        Form3.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'ExitApplication(Me)
    End Sub

    'Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
    '    Form5.Show()
    'End Sub
End Class
