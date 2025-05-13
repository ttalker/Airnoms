Imports MySql.Data.MySqlClient
Imports SharedModule

Public Class Form6

    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Try
            ' Basic validation
            If cbxDepartureAddFlight.SelectedItem Is Nothing OrElse
               cbxDestinationAddFlight.SelectedItem Is Nothing OrElse
               String.IsNullOrWhiteSpace(cbxPilotAddFlight.Text) OrElse
               cbxPlaneTypeAddFlight.SelectedItem Is Nothing OrElse
               String.IsNullOrWhiteSpace(tbxDepartTimeAddFlight.Text) Then

                MessageBox.Show("Please fill in all fields with valid data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim departure = cbxDepartureAddFlight.SelectedItem.ToString()
            Dim destination = cbxDestinationAddFlight.SelectedItem.ToString()
            Dim pilot = cbxPilotAddFlight.Text.Trim()
            Dim departureDate = dtpDepartureDateAddFlight.Value.Date
            Dim planeType = cbxPlaneTypeAddFlight.SelectedItem.ToString()
            Dim departureTime As DateTime

            ' Validate departure time format
            Dim departureTimeString = tbxDepartTimeAddFlight.Text.Trim()
            If Not DateTime.TryParseExact(departureTimeString, "HH:mm:ss", Nothing, Globalization.DateTimeStyles.None, departureTime) Then
                MessageBox.Show("Invalid departure time. Please use 24-hour format (HH:mm:ss).", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Combine date and time and check if it's in the past
            Dim fullDepartureDateTime As DateTime = departureDate.AddHours(departureTime.Hour).AddMinutes(departureTime.Minute).AddSeconds(departureTime.Second)
            If fullDepartureDateTime < DateTime.Now Then
                MessageBox.Show("Cannot schedule a flight in the past. Please select a future date and time.", "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Calculate arrival time
            Dim rnd As New Random()
            Dim arrivalTime = departureTime.AddHours(rnd.Next(3, 11))

            ' Plane capacity lookup
            Dim planeCapacities As New Dictionary(Of String, Integer) From {
                {"Boeing737_800", 523}, {"Boeing747_8", 308}, {"Boeing777_300ER", 388},
                {"Boeing787_9", 300}, {"Boeing737_MAX_8", 178}, {"AirbusA320", 186},
                {"AirbusA321", 236}, {"AirbusA330_300", 314}, {"AirbusA330_800", 523}, {"AirbusA350_900", 195}
            }

            If Not planeCapacities.ContainsKey(planeType) Then
                MessageBox.Show("Unknown plane type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim capacity = planeCapacities(planeType)


            ' Generate new flight ID
            Dim nextFlightNum = GetNextFlightNumber()
            Dim flightID = $"FL{nextFlightNum:D3}"

            openCon()
            Using checkCmd As New MySqlCommand("SELECT COUNT(*) FROM flight_table WHERE pilot = @Pilot AND departure_date = @Date", con)
                checkCmd.Parameters.AddWithValue("@Pilot", pilot)
                checkCmd.Parameters.AddWithValue("@Date", departureDate)

                Dim count = Convert.ToInt32(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("This pilot is already assigned to another flight on the selected date.", "Pilot Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using

            '  Insert flight
            Using cmd As New MySqlCommand("
                    INSERT INTO flight_table 
                    (flight_id, plane_type, pilot, departure, destination, departure_date, 
                     departure_time, arrival_time, capacity, status)
                    VALUES 
                    (@FlightID, @PlaneType, @Pilot, @Departure, @Destination, @DepartureDate, 
                     @DepartureTime, @ArrivalTime, @Capacity, @Status)", con)

                cmd.Parameters.AddWithValue("@FlightID", flightID)
                cmd.Parameters.AddWithValue("@PlaneType", planeType)
                cmd.Parameters.AddWithValue("@Pilot", pilot)
                cmd.Parameters.AddWithValue("@Departure", departure)
                cmd.Parameters.AddWithValue("@Destination", destination)
                cmd.Parameters.AddWithValue("@DepartureDate", departureDate)
                cmd.Parameters.AddWithValue("@DepartureTime", departureTime.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@ArrivalTime", arrivalTime.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@Capacity", capacity)
                cmd.Parameters.AddWithValue("@Status", "Waiting")

                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Flight added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error adding flight: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxDepartureAddFlight.Items.Clear()
        cbxDepartureAddFlight.Items.Add("Manila")
        cbxDepartureAddFlight.SelectedIndex = 0
        cbxDepartureAddFlight.Enabled = False ' Optional: prevent changing it
        LoadForm6Data()
    End Sub

    Private Sub LoadForm6Data()
        cbxDepartureAddFlight.Items.Clear()
        cbxDestinationAddFlight.Items.Clear()
        cbxPilotAddFlight.Items.Clear()
        cbxPlaneTypeAddFlight.Items.Clear()

        ' Only "Manila" for departure
        cbxDepartureAddFlight.Items.Add("Manila")
        cbxDepartureAddFlight.SelectedIndex = 0

        ' Destinations
        Dim destinations = {"Seoul", "Beijing", "Tokyo", "Los Angeles", "Taipei", "Sydney", "Vancouver", "London", "Singapore", "Kuala Lumpur"}
        cbxDestinationAddFlight.Items.AddRange(destinations)

        ' Plane Types
        Dim planeTypes = {"AirbusA350_900", "AirbusA330_800", "AirbusA330_300", "AirbusA321", "AirbusA320",
                          "Boeing737_800", "Boeing747_8", "Boeing777_300ER", "Boeing787_9", "Boeing737_MAX_8"}
        cbxPlaneTypeAddFlight.Items.AddRange(planeTypes)

        ' Load Available Pilots
        LoadAvailablePilots()
    End Sub
    Private ReadOnly allPilots As New List(Of String) From {
    "Capt. Reyes", "Capt. Santos", "Capt. Lee", "Capt. Tanaka", "Capt. Smith",
    "Capt. Gualberto", "Capt. Maglalang", "Capt. Barba", "Capt. Pilar", "Capt. Jayat"
}

    Private Sub LoadAvailablePilots()
        cbxPilotAddFlight.Items.Clear()

        Dim assignedPilots As New HashSet(Of String)()

        Try
            openCon()
            Dim cmd As New MySqlCommand("SELECT DISTINCT pilot FROM flight_table WHERE departure_date = @SelectedDate", con)
            cmd.Parameters.AddWithValue("@SelectedDate", dtpDepartureDateAddFlight.Value.Date)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                assignedPilots.Add(reader("pilot").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading assigned pilots: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        Dim availablePilots = allPilots.Where(Function(p) Not assignedPilots.Contains(p)).ToArray()

        cbxPilotAddFlight.DropDownStyle = ComboBoxStyle.DropDown
        cbxPilotAddFlight.Items.AddRange(availablePilots.Distinct().ToArray())
    End Sub


    Private Sub btnAddPilot_Click(sender As Object, e As EventArgs) Handles btnAddPilot.Click
        Dim newPilot As String = InputBox("Enter the new pilot's name (e.g., 'Capt. Cruz'):", "Add Pilot").Trim()

        If String.IsNullOrWhiteSpace(newPilot) Then
            MessageBox.Show("Pilot name cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Avoid duplicates by checking both dropdown and allPilots list
        If cbxPilotAddFlight.Items.Contains(newPilot) OrElse allPilots.Contains(newPilot) Then
            MessageBox.Show("Pilot already exists in the list.", "Duplicate Pilot", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        allPilots.Add(newPilot)
        cbxPilotAddFlight.Items.Add(newPilot)
        cbxPilotAddFlight.SelectedItem = newPilot
        MessageBox.Show("Pilot added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
