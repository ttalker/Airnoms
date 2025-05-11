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


        Me.RefreshFlightData() ' Forces Form1 to reload with updated info
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
                                     plane_type as 'Plane Type',
                                     pilot as 'Pilot',
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
        With dgvFlights.ColumnHeadersDefaultCellStyle
            .BackColor = Color.FromArgb(17, 47, 78) ' Dark blue header
            .ForeColor = Color.White                ' White header text
            .Font = New Font("Segoe UI", 10, FontStyle.Regular)
        End With
        dgvFlights.EnableHeadersVisualStyles = False

        ' Row styling
        With dgvFlights.DefaultCellStyle
            .BackColor = Color.White                ' White row background
            .ForeColor = Color.Black                ' Black text
            .Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .SelectionBackColor = Color.LightBlue
            .SelectionForeColor = Color.Black
        End With
        ' Add color coding based on flight status
        ' Add color coding based on flight status
        For Each row As DataGridViewRow In dgvFlights.Rows
            Dim status As String = row.Cells("Status").Value.ToString()

            Select Case status
                Case "Waiting"
                    row.DefaultCellStyle.BackColor = Color.LightYellow
                    row.DefaultCellStyle.ForeColor = Color.Black
                Case "On Flight"
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue
                    row.DefaultCellStyle.ForeColor = Color.Black
                Case "Arrived"
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                    row.DefaultCellStyle.ForeColor = Color.Black
                Case "Cancelled"
                    row.DefaultCellStyle.BackColor = Color.LightCoral
                    row.DefaultCellStyle.ForeColor = Color.White
                Case "Delayed"
                    row.DefaultCellStyle.BackColor = Color.Gold
                    row.DefaultCellStyle.ForeColor = Color.Black
                Case Else
                    ' Optional: Default styling
                    row.DefaultCellStyle.BackColor = Color.White
                    row.DefaultCellStyle.ForeColor = Color.Black
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

        ' Format DataGridView again to ensure coloring applies
        FormatFlightDataGridView()
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
        ExitToUserForm(Me)
    End Sub
    Private Sub btnViewFlightAdmin_Click(sender As Object, e As EventArgs) Handles btnViewFlightAdmin.Click
        If dgvFlights.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvFlights.SelectedRows(0)

            ' Retrieve flight details from the selected row
            Dim flightID As String = selectedRow.Cells("Flight No.").Value.ToString()
            'Dim destination As String = selectedRow.Cells("destination").Value.ToString()
            'Dim depDate As String = selectedRow.Cells("Departure Date").Value.ToString()
            'Dim depTime As String = selectedRow.Cells("Departure Time").Value.ToString()

            ' Create and show the passenger popup form
            Dim passengerPopup As New Form5()
            passengerPopup.LoadPassengers(flightID)
            passengerPopup.ShowDialog()
        Else
            MessageBox.Show("Please select a flight to view passenger information.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub





    Private Sub btnCancelFlight_Click(sender As Object, e As EventArgs) Handles btnCancelFlight.Click
        If dgvFlights.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvFlights.SelectedRows(0)
            Dim selectedFlightID As String = selectedRow.Cells("Flight No.").Value.ToString()

            Dim popup As New Form4()
            popup.LoadFlightDetails(selectedFlightID)
            popup.ShowDialog()

            If popup.FlightWasCancelled Then
                RefreshFlightData() ' or LoadFlightsByDate(Date.Today) if you prefer
            End If
        Else
            MessageBox.Show("Please select a flight to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        'Form6.Show()
    End Sub

    'Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
    '    Form5.Show()
    'End Sub
End Class
