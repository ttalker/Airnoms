'Imports cashierform
'Imports userForm.Module1
Imports SharedModule
Imports MySql.Data.MySqlClient
Imports userForm

Public Class Form3
    Private selectedRow As DataGridViewRow = Nothing

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnFlights)
        MakeTransparent(btnTransactions)
        MakeTransparent(btnBookings)
        MakeTransparent(btnExit)
        btnFlights.Parent = pbxAdmin
        btnTransactions.Parent = pbxAdmin
        btnBookings.Parent = pbxAdmin
        btnExit.Parent = pbxAdmin


        ' transparency of the buttons
        hoverButton(btnFlights)
        hoverButton(btnTransactions)
        hoverButton(btnBookings)
        hoverButton(btnExit)
        ' transparency of the background

        Me.DoubleBuffered = True
        LoadBookings()
        FormatBookingGrid()
    End Sub

    Private Sub btnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Form1.Show()
        Me.Hide()
        Form2.Hide()
    End Sub
    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Me.Show()
        Form1.Hide()
        Form2.Hide()
    End Sub
    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        Me.Hide()
        Form1.Hide()
        Form2.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitToUserForm(Me)
    End Sub

    Private Sub LoadBookings()
        Try
            openCon() ' Opens the MySQL connection (con)
            Dim query As String = "
                        SELECT 
                            customer_id AS 'Customer ID',
                            fullname AS 'Full Name',
                            destination AS 'Destination',
                            booking_date,
                            seat_number,
                            baggage_allowance,
                            age,
                            date_of_birth,
                            gender,
                            address,
                            pwd_status
                        FROM customer_table"

            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvBookings.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading bookings: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub FormatBookingGrid()
        With dgvBookings
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .RowTemplate.Height = 30
            .AllowUserToAddRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
        dgvBookings.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvBookings.ScrollBars = ScrollBars.Both

        dgvBookings.Columns("booking_date").Visible = False
        dgvBookings.Columns("seat_number").Visible = False
        dgvBookings.Columns("baggage_allowance").Visible = False
        dgvBookings.Columns("age").Visible = False
        dgvBookings.Columns("date_of_birth").Visible = False
        dgvBookings.Columns("gender").Visible = False
        dgvBookings.Columns("address").Visible = False
        dgvBookings.Columns("pwd_status").Visible = False
        ' Repeat for other columns that are only shown in labels
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = tbxSearchInput.Text.Trim().ToLower()
        Dim found As Boolean = False

        dgvBookings.ClearSelection() ' Deselect previous selections before searching

        If dgvBookings.Rows.Count = 0 Then
            MessageBox.Show("No data available to search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        For Each row As DataGridViewRow In dgvBookings.Rows
            If row.Cells("Full Name").Value.ToString().ToLower().Contains(searchText) Then
                row.Selected = True
                dgvBookings.FirstDisplayedScrollingRowIndex = row.Index
                found = True
                Exit For
            End If
        Next

        If Not found Then
            MessageBox.Show("User not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub dgvBookings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookings.CellClick
        If e.RowIndex >= 0 Then
            selectedRow = dgvBookings.Rows(e.RowIndex)
        End If
    End Sub
    Private Sub btnViewInfo_Click(sender As Object, e As EventArgs) Handles btnViewInfo.Click
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a booking row first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        lblFullNameAdmin.Text = selectedRow.Cells("Full Name").Value.ToString()
        lblBookingDateAdmin.Text = selectedRow.Cells("booking_date").Value.ToString()
        lblSeatNumAdmin.Text = selectedRow.Cells("seat_number").Value.ToString()
        lblBaggageAllowanceAdmin.Text = selectedRow.Cells("baggage_allowance").Value.ToString()
        lblAgeAdmin.Text = selectedRow.Cells("age").Value.ToString()
        lblDateOfBirthAdmin.Text = selectedRow.Cells("date_of_birth").Value.ToString()
        lblGenderAdmin.Text = selectedRow.Cells("gender").Value.ToString()
        lblAddressAdmin.Text = selectedRow.Cells("address").Value.ToString()
        lblPWDAdmin.Text = selectedRow.Cells("pwd_status").Value.ToString()
    End Sub



End Class