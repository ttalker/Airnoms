Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Imports SharedModule

Public Class Form5
    ' Optional: Store passed flight data for use inside the form
    Private flightID As String
    'Private destination As String
    'Private depDate As Date
    'Private depTime As String

    ' Call this method from the main form to load passengers for a specific flight
    Public Sub LoadPassengers(fID As String) ', dest As String, dDate As Date, dTime As String) ', dest As String, dDate As Date, dTime As String
        flightID = fID
        'destination = dest
        'depDate = dDate
        'depTime = dTime

        Try
            openCon()

            Dim query As String = "SELECT flight_id, fullname, class, seat_number 
                                   FROM transaction_table 
                                   WHERE flight_id = @flightID"


            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@flightID", flightID)
                'cmd.Parameters.AddWithValue("@destination", destination)
                'cmd.Parameters.AddWithValue("@depDate", depDate)
                'cmd.Parameters.AddWithValue("@depTime", depTime)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvPassengers.DataSource = table

                ' Format the DataGridView
                With dgvPassengers
                    .Columns("flight_id").HeaderText = "Flight ID"
                    .Columns("fullname").HeaderText = "Passenger Name"
                    .Columns("class").HeaderText = "Class"
                    .Columns("seat_number").HeaderText = "Seat Number"

                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
                    .RowHeadersVisible = False
                    .ReadOnly = True
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving passengers: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPassengers.BackgroundColor = Me.BackColor
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = tbxSearchInput.Text.Trim().ToLower()
        Dim found As Boolean = False

        dgvPassengers.ClearSelection()

        If dgvPassengers.Rows.Count = 0 Then
            MessageBox.Show("No data available to search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        For Each row As DataGridViewRow In dgvPassengers.Rows
            If row.Cells("fullname").Value IsNot Nothing AndAlso
           row.Cells("fullname").Value.ToString().ToLower().Contains(searchText) Then

                row.Selected = True
                dgvPassengers.CurrentCell = row.Cells("fullname")
                dgvPassengers.FirstDisplayedScrollingRowIndex = row.Index
                found = True
                Exit For
            End If
        Next

        If Not found Then
            MessageBox.Show("User not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
