
Imports System.IO
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports userForm

Public Module Module1
    ' Connection objects
    Public con As MySqlConnection
    Public cmd As MySqlCommand
    Public conn As MySqlConnection
    Public cmd2 As MySqlCommand


    Public Property isBooked As Boolean
    Public Property allPassengers As New List(Of PassengerInfo)

    Private ReadOnly Property AdminConnectionString As String
        Get
            Return "server=100.89.19.71; username=root; password=; database=comprog_db"
        End Get
    End Property

    Private ReadOnly Property TestingConnectionString As String
        Get
            Return "server=100.89.19.71; username=root; password=; database=testing_db"
        End Get
    End Property

    ' Open admin database connection with proper error handling
    Public Sub openCon()
        Try
            ' Initialize connection if needed
            If con Is Nothing Then
                con = New MySqlConnection()
            End If

            ' Close if already open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.ConnectionString = AdminConnectionString
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Connection Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Open testing database connection with proper error handling
    Public Sub openConTesting()
        Try
            ' Initialize connection if needed
            If conn Is Nothing Then
                conn = New MySqlConnection()
            End If

            ' Close if already open
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            conn.ConnectionString = TestingConnectionString
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Testing database connection error: " & ex.Message, "Connection Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Safe method to show image with error handling
    Public Sub ShowImage(planes As String, ptbImages As PictureBox, pnlPlane As Panel)
        Try
            Dim filepath = Path.Combine(Application.StartupPath, "Seatmaps", planes & ".png")

            ' Check if file exists before loading
            If Not File.Exists(filepath) Then
                MessageBox.Show($"Image file not found: {filepath}", "File Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ptbImages.Size = New Size(1, 1)
            ptbImages.Location = New Point(0, 0)

            ' Properly dispose of previous image
            If ptbImages.Image IsNot Nothing Then
                ptbImages.Image.Dispose()
            End If

            ' Load image with error handling
            Using fs As New FileStream(filepath, FileMode.Open, FileAccess.Read)
                Dim img = Image.FromStream(fs)
                ptbImages.Image = img.Clone()
            End Using

            ptbImages.SizeMode = PictureBoxSizeMode.Zoom

            ' Calculate proper image dimensions
            Dim panelWidth = pnlPlane.ClientSize.Width
            Dim aspectRatio = CDbl(ptbImages.Image.Height) / CDbl(ptbImages.Image.Width)
            Dim newWidth = panelWidth
            Dim newHeight = CInt(newWidth * aspectRatio)

            ptbImages.Size = New Size(newWidth, newHeight)
        Catch ex As Exception
            MessageBox.Show($"Error loading image: {ex.Message}", "Image Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub MakeTransparent(button As Button)
        button.BackColor = Color.Transparent
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.FlatAppearance.MouseOverBackColor = Color.Transparent
        button.FlatAppearance.MouseDownBackColor = Color.Transparent
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


    Public CurrentBooking As BookingInfo

    Public AllRoutes As New List(Of RouteInfo) From {
        New RouteInfo("Manila", "Seoul", 2600, 12240D, 30600D, 48960D),
        New RouteInfo("Manila", "Beijing", 2800, 11660D, 29150D, 46640D),
        New RouteInfo("Manila", "Tokyo", 3000, 14300D, 35750D, 57200D),
        New RouteInfo("Manila", "Los Angeles", 11800, 37180D, 92950D, 148720D),
        New RouteInfo("Manila", "Taipei", 1200, 7400D, 18500D, 29600D),
        New RouteInfo("Manila", "Sydney", 6200, 19140D, 47850D, 76560D),
        New RouteInfo("Manila", "Vancouver", 10400, 30960D, 77400D, 123840D),
        New RouteInfo("Manila", "London", 10800, 37240D, 93100D, 148960D),
        New RouteInfo("Manila", "Singapore", 2400, 8820D, 22050D, 35280D),
        New RouteInfo("Manila", "Kuala Lumpur", 2500, 9000D, 22500D, 36000D)
    }

    ' Get fare functions with better error handling
    Public Function GetEconomyFare(departure As String, destination As String) As Decimal
        Try
            Dim route = AllRoutes.FirstOrDefault(Function(r) r.FromLocation = departure AndAlso r.ToLocation = destination)
            If route IsNot Nothing Then
                Return route.EconomyFare
            Else
                Throw New Exception($"Route not found: {departure} to {destination}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error retrieving Economy fare: {ex.Message}", "Fare Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0D
        End Try
    End Function

    Public Function GetBusinessFare(departure As String, destination As String) As Decimal
        Try
            Dim route = AllRoutes.FirstOrDefault(Function(r) r.FromLocation = departure AndAlso r.ToLocation = destination)
            If route IsNot Nothing Then
                Return route.BusinessFare
            Else
                Throw New Exception($"Route not found: {departure} to {destination}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error retrieving Business fare: {ex.Message}", "Fare Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0D
        End Try
    End Function

    Public Function GetFirstClassFare(departure As String, destination As String) As Decimal
        Try
            Dim route = AllRoutes.FirstOrDefault(Function(r) r.FromLocation = departure AndAlso r.ToLocation = destination)
            If route IsNot Nothing Then
                Return route.FirstFare
            Else
                Throw New Exception($"Route not found: {departure} to {destination}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error retrieving First Class fare: {ex.Message}", "Fare Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0D
        End Try
    End Function

    ' Flight generation function with improved error handling
    Public Function GenerateDailyFlights(startFlightNumber As Integer, flightDate As Date) As List(Of Flight)
        Dim flights As New List(Of Flight)()
        Try
            Dim destinations As String() = {"Seoul", "Beijing", "Tokyo", "Los Angeles", "Taipei", "Sydney", "Vancouver", "London", "Singapore", "Kuala Lumpur"}
            Dim planeTypes As String() = {"AirbusA350_900", "AirbusA330_800", "AirbusA330_300", "AirbusA321", "AirbusA320", "Boeing737_800", "Boeing747_8", "Boeing777_300ER", "Boeing787_9", "Boeing737_MAX_8"}
            Dim pilots As String() = {"Capt. Reyes", "Capt. Santos", "Capt. Lee", "Capt. Tanaka", "Capt. Smith", "Capt. Gualberto", "Capt, Maglalang", "Capt. Barba", "Capt. Pilar", "Capt. Jayat"}

            Dim planeCapacities As New Dictionary(Of String, Integer) From { ' total capacity
            {"Boeing737_800", 523},
            {"Boeing747_8", 308},
            {"Boeing777_300ER", 388},
            {"Boeing787_9", 300},
            {"Boeing737_MAX_8", 178},
            {"AirbusA320", 186},
            {"AirbusA321", 236},
            {"AirbusA330_300", 314},
            {"AirbusA330_800", 523},
            {"AirbusA350_900", 195}
        }

            Dim rnd As New Random()

            For i As Integer = 0 To destinations.Length - 1
                Dim flightNumber As Integer = startFlightNumber + i + 1
                Dim flightID As String = $"FL{flightNumber.ToString("D3")}"
                Dim departureTime As DateTime = flightDate.AddHours(6 + i) ' flights from 6AM onwards
                Dim durationHours As Integer = rnd.Next(3, 15)
                Dim arrivalTime As DateTime = departureTime.AddHours(durationHours)
                Dim status As String = "Waiting"

                Dim planeType As String = planeTypes(rnd.Next(planeTypes.Length))
                Dim pilot As String = pilots(rnd.Next(pilots.Length))
                Dim capacity As Integer = planeCapacities(planeType)

                flights.Add(New Flight(
                flightID,
                planeType,
                pilot,
                "Manila",
                destinations(i),
                departureTime.Date,
                departureTime.ToString("HH:mm"),
                arrivalTime.ToString("HH:mm"),
                capacity,
                status
            ))
            Next
        Catch ex As Exception
            MessageBox.Show($"Error generating flights: {ex.Message}", "Flight Generation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return flights
    End Function


    Public Function FlightsExistForDate(flightDate As Date) As Boolean
        Try
            openCon()
            cmd = New MySqlCommand("SELECT COUNT(*) FROM flight_table WHERE departure_date = @FlightDate", con)
            cmd.Parameters.AddWithValue("@FlightDate", flightDate)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show($"Error checking flights: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Function


    Public Function GetMaxFlightNumber() As Integer
        Dim maxNumber As Integer = 0
        Try
            openCon()
            cmd = New MySqlCommand("SELECT MAX(CAST(SUBSTRING(flight_id, 3) AS UNSIGNED)) FROM flight_table", con)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                maxNumber = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error retrieving max flight number: {ex.Message}", "Database Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        Return maxNumber
    End Function

    Public Sub GenerateAndSaveFlightsIfNotExist(flightDate As Date)
        Try
            If Not FlightsExistForDate(flightDate) Then
                Dim maxFlightNumber As Integer = GetMaxFlightNumber()
                Dim flights = GenerateDailyFlights(maxFlightNumber, flightDate)

                If flights.Count = 0 Then
                    MessageBox.Show("No flights were generated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                openCon()
                For Each flight In flights
                    cmd = New MySqlCommand("INSERT INTO flight_table (flight_id, plane_type, pilot, departure, destination, departure_date, " &
                 "departure_time, arrival_time, capacity, status) VALUES (@FlightID, @PlaneType, @Pilot @Departure, " &
                 "@Destination, @DepartureDate, @DepartureTime, @ArrivalTime, @Capacity, @Status)", con)

                    cmd.Parameters.AddWithValue("@FlightID", flight.FlightID)
                    cmd.Parameters.AddWithValue("@PlaneType", flight.PlaneType)
                    cmd.Parameters.AddWithValue("@Pilot", flight.Pilot)
                    cmd.Parameters.AddWithValue("@Departure", flight.Departure)
                    cmd.Parameters.AddWithValue("@Destination", flight.Destination)
                    cmd.Parameters.AddWithValue("@DepartureDate", flight.DepartureDate)
                    cmd.Parameters.AddWithValue("@DepartureTime", flight.DepartureTime)
                    cmd.Parameters.AddWithValue("@ArrivalTime", flight.ArrivalTime)
                    cmd.Parameters.AddWithValue("@Capacity", flight.Capacity)
                    cmd.Parameters.AddWithValue("@Status", flight.Status)

                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show($"Error inserting flight {flight.FlightID}: {ex.Message}")
                    End Try
                Next
            End If
        Catch ex As Exception
            MessageBox.Show($"Error generating flights: {ex.Message}", "Flight Generation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub UpdateFlightStatuses()
        Try
            Dim now As DateTime = DateTime.Now
            Dim today As Date = Date.Today

            openCon()

            Dim query As String = "SELECT flight_id, departure_date, departure_time, arrival_time " &
                                "FROM flight_table WHERE departure_date = @Today"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Today", today)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim flightsToUpdate As New List(Of Tuple(Of String, String))

            While reader.Read()
                Try
                    Dim flightId As String = reader("flight_id").ToString()
                    Dim depDate As Date = CDate(reader("departure_date"))
                    Dim depTime As String = reader("departure_time").ToString()
                    Dim arrTime As String = reader("arrival_time").ToString()

                    ' Validate time format before parsing
                    If Not depTime.Contains(":") Or Not arrTime.Contains(":") Then
                        Continue While
                    End If

                    ' Construct DateTime for departure
                    Dim depHour As Integer = Integer.Parse(depTime.Split(":"c)(0))
                    Dim depMin As Integer = Integer.Parse(depTime.Split(":"c)(1))
                    Dim departureDateTime As New DateTime(depDate.Year, depDate.Month, depDate.Day, depHour, depMin, 0)

                    ' Construct DateTime for arrival, assuming it could be the next day
                    Dim arrHour As Integer = Integer.Parse(arrTime.Split(":"c)(0))
                    Dim arrMin As Integer = Integer.Parse(arrTime.Split(":"c)(1))
                    Dim arrivalDateTime As New DateTime(depDate.Year, depDate.Month, depDate.Day, arrHour, arrMin, 0)
                    If arrivalDateTime < departureDateTime Then
                        arrivalDateTime = arrivalDateTime.AddDays(1) ' arrived after midnight
                    End If

                    Dim status As String = "Waiting"
                    If now > arrivalDateTime Then
                        status = "Arrived"
                    ElseIf now >= departureDateTime AndAlso now <= arrivalDateTime Then
                        status = "On Flight"
                    End If

                    flightsToUpdate.Add(New Tuple(Of String, String)(flightId, status))
                Catch ex As Exception
                    ' Skip problematic records but log the error
                    Debug.WriteLine($"Error processing flight status: {ex.Message}")
                End Try
            End While

            reader.Close()

            ' Update statuses
            For Each flightInfo In flightsToUpdate
                Dim updateCmd As New MySqlCommand("UPDATE flight_table SET status = @Status WHERE flight_id = @FlightID", con)
                updateCmd.Parameters.AddWithValue("@Status", flightInfo.Item2)
                updateCmd.Parameters.AddWithValue("@FlightID", flightInfo.Item1)
                updateCmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show($"Error updating flight statuses: {ex.Message}", "Database Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub DeleteOldFlights()
        Try
            Dim today As Date = Date.Today
            openCon()
            cmd = New MySqlCommand("DELETE FROM flight_table WHERE departure_date < @FlightDate", con)
            cmd.Parameters.AddWithValue("@FlightDate", today)
            Dim rowsAffected = cmd.ExecuteNonQuery()
            Debug.WriteLine($"Deleted {rowsAffected} old flights")
        Catch ex As Exception
            MessageBox.Show($"Error deleting old flights: {ex.Message}", "Database Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Public Sub LoadAllDestinations(comboBox As ComboBox)
        Try
            openCon()
            Dim cmd As New MySqlCommand("SELECT DISTINCT destination FROM flight_table ORDER BY destination", con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            comboBox.Items.Clear()
            While reader.Read()
                comboBox.Items.Add(reader("destination").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to load destinations: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Public Sub LoadDepartureTimesForDestination(destination As String, comboBox As ComboBox)
        Try
            openCon()
            Dim cmd As New MySqlCommand("SELECT DISTINCT departure_time FROM flight_table WHERE destination = @Destination ORDER BY departure_time", con)
            cmd.Parameters.AddWithValue("@Destination", destination)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            comboBox.Items.Clear()
            While reader.Read()
                comboBox.Items.Add(reader("departure_time").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to load departure times: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub
    Public Sub ExitToUserForm(currentForm As Form)
        Dim result As DialogResult = MessageBox.Show("Do you want to log out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            currentForm.Hide()


            ' Create and show the login form from the other project
            Dim loginForm As New userForm.Form1()
            loginForm.Show()
        End If
    End Sub


    Public Function GenerateSeats(Type As AircraftType) As (seatmap As Dictionary(Of String, String), capacity As Integer)
        Dim seatmap As New Dictionary(Of String, String)
        Dim seat As String
        Dim capacity As Integer
        Select Case Type
            Case AircraftType.Boeing747_8

                'Add first class seats
                For i As Integer = 1 To 3
                    Dim letters() = {"A", "D", "G", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "First")
                        capacity += 1
                    Next
                Next
                'Add business seats
                For i As Integer = 4 To 11
                    Dim letters() = {"A", "C", "D", "G", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Business")
                        capacity += 1
                    Next
                Next

                For i As Integer = 81 To 88
                    Dim letters() = {"A", "C", "H", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Business")
                        capacity += 1
                    Next
                Next

                'Add economy seats
                For i As Integer = 16 To 20
                    Dim letters() = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                For i As Integer = 34 To 49
                    Dim letters() = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K"}
                    For Each letter In letters

                        ' Stop using A after row 44
                        If letter = "A" And i > 44 Then
                            Continue For
                        End If

                        ' Stop using B, C, H, J after row 47
                        If (letter = "B" Or letter = "C" Or letter = "H" Or letter = "J") And i > 47 Then
                            Continue For
                        End If

                        ' Stop using K after row 44
                        If letter = "K" And i > 44 Then
                            Continue For
                        End If

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                For i As Integer = 22 To 25
                    Dim letters() = {"A", "C", "D", "E", "F", "G", "H", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Premium Economy")
                        capacity += 1
                    Next
                Next
                Return (seatmap, capacity)
            Case AircraftType.Boeing777_300ER

                'generate business
                For i As Integer = 1 To 6
                    Dim letters() = {"A", "C", "D", "E", "G", "H", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Business")
                        capacity += 1
                    Next
                Next
                'generate economy 
                For i As Integer = 31 To 72
                    Dim letters() = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K"}
                    For Each letter In letters
                        If (i > 54 AndAlso i < 61) Then
                            Continue For
                        End If


                        If letter = "B" And (i > 52 AndAlso i < 61) Then
                            Continue For
                        End If


                        If (letter = "A" Or letter = "C" Or letter = "H" Or letter = "K") And (i > 53 AndAlso i < 61) Then
                            Continue For
                        End If

                        If (letter = "C" Or letter = "H") And (i > 68) Then
                            Continue For
                        End If


                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                Return (seatmap, capacity)

            Case AircraftType.Boeing787_9

                'generate business
                For i As Integer = 1 To 8
                    Dim letters() = {"A", "D", "G", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Business")
                        capacity += 1
                    Next
                Next
                'generate economy 
                For i As Integer = 18 To 46
                    Dim letters() = {"A", "B", "C", "D", "E", "G", "H", "J", "K"}
                    For Each letter In letters

                        If (letter = "A" Or letter = "K") And (i > 44) Then
                            Continue For
                        End If


                        If (letter = "D" Or letter = "E" Or letter = "G" Or letter = "H" Or letter = "J" Or letter = "K") And (i = 30) Then
                            Continue For
                        End If

                        If (letter = "B" Or letter = "C" Or letter = "H" Or letter = "J") And (i > 45) Then
                            Continue For
                        End If


                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next
                'generate premium economy
                For i As Integer = 12 To 14
                    Dim letters() = {"A", "C", "D", "E", "G", "H", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Premium Economy")
                        capacity += 1
                    Next
                Next

                Return (seatmap, capacity)

            Case AircraftType.AirbusA350_900

                'generate busines
                For i As Integer = 1 To 8
                    Dim letters() = {"A", "D", "G", "K"}
                    For Each letter In letters

                        If (letter = "A" Or letter = "K") And (i = 8) Then
                            Continue For
                        End If

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Business")
                        capacity += 1
                    Next
                Next

                'generate economy
                For i As Integer = 31 To 43
                    Dim letters() = {"A", "B", "C", "D", "E", "G", "H", "J", "K"}
                    For Each letter In letters
                        If (letter = "D" Or letter = "E" Or letter = "G") And (i = 43) Then
                            Continue For
                        End If


                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                For i As Integer = 51 To 65
                    Dim letters() = {"A", "B", "C", "D", "E", "G", "H", "J", "K"}
                    For Each letter In letters
                        If (letter = "A" Or letter = "K" Or letter = "D" Or letter = "E" Or letter = "G") And (i = 52) Then
                            Continue For
                        End If

                        If (letter = "A" Or letter = "B" Or letter = "C") And (i = 64) Then
                            Continue For
                        End If

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                'generate premium economy
                For i As Integer = 21 To 23
                    Dim letters() = {"A", "C", "D", "E", "F", "G", "H", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Premium Economy")
                        capacity += 1
                    Next
                Next
                Return (seatmap, capacity)
            Case AircraftType.Boeing737_800

                For i As Integer = 1 To 30
                    Dim letters() = {"A", "B", "C", "D", "E", "F"}
                    For Each letter In letters
                        If (letter = "D" Or letter = "E" Or letter = "F") And (i = 1) Then
                            Continue For
                        End If

                        If (letter = "A" Or letter = "F") And (i = 15) Then
                            Continue For
                        End If

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next
                Return (seatmap, capacity)

            Case AircraftType.Boeing737_MAX_8

                'generate business
                For i As Integer = 1 To 3
                    Dim letters() = {"A", "B", "C", "D", "E", "F"}
                    For Each letter In letters
                        If (letter = "B" Or letter = "E") And (i = 2) Then
                            Continue For
                        End If



                        seat = i.ToString & letter
                        seatmap.Add(seat, "Business")
                        capacity += 1
                    Next
                Next

                'generate economy
                For i As Integer = 6 To 32
                    Dim letters() = {"A", "B", "C", "D", "E", "F"}
                    For Each letter In letters

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                Return (seatmap, capacity)

            Case AircraftType.AirbusA320
                'generate economy
                For i As Integer = 1 To 31
                    Dim letters() = {"A", "B", "C", "D", "E", "F"}
                    For Each letter In letters

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                Return (seatmap, capacity)

            Case AircraftType.AirbusA321
                'generate economy
                For i As Integer = 1 To 40
                    Dim letters() = {"A", "B", "C", "D", "E", "F"}
                    For Each letter In letters

                        If (letter = "A" Or letter = "F") And (i = 11 OrElse i = 26) Then
                            Continue For
                        End If

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                Return (seatmap, capacity)

            Case AircraftType.AirbusA330_300

                'generate business
                For i As Integer = 1 To 5
                    Dim letters() = {"A", "D", "G", "D", "K"}
                    For Each letter In letters

                        If (letter = "D" Or letter = "G") And (i = 5) Then
                            Continue For
                        End If

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Business")
                        capacity += 1
                    Next
                Next

                'generate premium economy
                For i As Integer = 21 To 24
                    Dim letters() = {"A", "C", "D", "E", "G", "H", "K"}
                    For Each letter In letters
                        If (letter = "A" Or letter = "C" Or letter = "H" Or letter = "K") And (i = 24) Then
                            Continue For
                        End If
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Premium Economy")
                        capacity += 1
                    Next
                Next

                'generate economy
                For i As Integer = 31 To 47
                    Dim letters() = {"A", "C", "D", "E", "F", "G", "H", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                For i As Integer = 51 To 67
                    Dim letters() = {"A", "C", "D", "E", "F", "G", "H", "K"}
                    For Each letter In letters


                        If (letter = "F") And (i > 62) Then
                            Continue For
                        End If

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                Return (seatmap, capacity)

            Case AircraftType.AirbusA330_800

                'first class
                For i As Integer = 1 To 2
                    Dim letters() = {"A", "E", "F", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "First")
                        capacity += 1
                    Next
                Next

                'business
                For i As Integer = 10 To 22
                    Dim letters() = {"A", "E", "F", "K"}
                    For Each letter In letters
                        seat = i.ToString & letter
                        seatmap.Add(seat, "Business")
                        capacity += 1
                    Next
                Next

                'economy

                For i As Integer = 25 To 32
                    Dim letters() = {"A", "B", "D", "E", "G", "J", "K"}
                    For Each letter In letters
                        If (letter = "A" Or letter = "B" Or letter = "J" Or letter = "K") And (i = 29 OrElse i = 32) Then
                            Continue For
                        End If


                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next

                For i As Integer = 40 To 83
                    Dim letters() = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K"}
                    For Each letter In letters
                        If (letter = "D" Or letter = "E" Or letter = "F" Or letter = "G") And ((i > 40 And i < 42) OrElse i = 49 OrElse i = 62 OrElse i = 75 OrElse i = 75) Then
                            Continue For
                        End If


                        If (letter = "A" Or letter = "B" Or letter = "C") And (i = 50 OrElse i = 74) Then
                            Continue For
                        End If

                        If (letter = "H" Or letter = "J" Or letter = "K") And (i = 74) Then
                            Continue For
                        End If

                        seat = i.ToString & letter
                        seatmap.Add(seat, "Economy")
                        capacity += 1
                    Next
                Next


                Return (seatmap, capacity)

        End Select


    End Function

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
        CoPassengers = New List(Of PassengerInfo)
    End Sub

    Public Sub New(tripType As String, departure As String,
                   destination As String, departDate As Date,
                   arrivalDate As Date, bookingDate As Date,
                   bookerFullName As String, bookerAge As Integer,
                   bookerBirthDate As Date, bookerGender As String,
                   bookerAddress As String, bookerIsPWD As Boolean,
                   bookerSeatNumber As String, bookerBaggageAllowance As String,
                   coPassengers As List(Of PassengerInfo), countPassenger As Integer) ' departTime As String, arrivalTime As String
        Me.TripType = tripType
        Me.Departure = departure
        Me.Destination = destination
        Me.DepartDate = departDate
        Me.ArrivalDate = arrivalDate
        Me.BookingDate = bookingDate
        Me.BookerFullName = bookerFullName
        Me.BookerAge = bookerAge
        Me.BookerBirthDate = bookerBirthDate
        Me.BookerGender = bookerGender
        Me.BookerAddress = bookerAddress
        Me.BookerIsPWD = bookerIsPWD
        Me.BookerSeatNumber = bookerSeatNumber
        Me.BookerBaggageAllowance = bookerBaggageAllowance
        Me.CoPassengers = coPassengers
        Me.countPassenger = countPassenger

    End Sub

End Class

Public Class Flight
    Public Property FlightID As String
    Public Property PlaneType As String
    Public Property Pilot As String
    Public Property Departure As String

    Public Property Destination As String
    Public Property DepartureDate As Date
    Public Property DepartureTime As String
    Public Property ArrivalTime As String
    Public Property Capacity As Integer
    Public Property Status As String ' Added status property
    Public Property FlightDate As Date ' The date this flight was scheduled/generated

    Public Sub New()
    End Sub

    Public Sub New(flightID As String, planeType As String, pilot As String, departure As String, destination As String,
                   departureDate As Date, departureTime As String,
                    arrivalTime As String, capacity As Integer, status As String)
        Me.FlightID = flightID
        Me.PlaneType = planeType
        Me.Pilot = pilot
        Me.Departure = departure
        Me.Destination = destination
        Me.DepartureDate = departureDate
        Me.DepartureTime = departureTime
        Me.ArrivalTime = arrivalTime
        Me.Capacity = capacity
        Me.Status = status ' Default status
        Me.FlightDate = Date.Today
    End Sub
End Class


Public Class RouteInfo
    Public Property FromLocation As String
    Public Property ToLocation As String
    Public Property DistanceKM As Integer
    Public Property EconomyFare As Decimal
    Public Property BusinessFare As Decimal
    Public Property FirstFare As Decimal

    Public Sub New(fromLoc As String, toLoc As String, distance As Integer, economy As Decimal, business As Decimal, firstClass As Decimal)
        FromLocation = fromLoc
        ToLocation = toLoc
        DistanceKM = distance
        EconomyFare = economy
        BusinessFare = business
        FirstFare = firstClass
    End Sub
End Class
' After RouteInfo class definition

Public Enum AircraftType
    Boeing737_800
    Boeing747_8
    Boeing777_300ER
    Boeing787_9
    Boeing737_MAX_8
    AirbusA320
    AirbusA321
    AirbusA330_300
    AirbusA330_800
    AirbusA350_900
End Enum

