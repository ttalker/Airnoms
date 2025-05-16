'Imports cashierform
'Imports userForm
Imports MySql.Data.MySqlClient
Imports SharedModule

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make buttons transparent
        MakeTransparent(btnFlights)
        MakeTransparent(btnTransactions)
        MakeTransparent(btnBookings)
        MakeTransparent(btnExit)

        ' Set button parents for layered transparency
        btnFlights.Parent = pbxAdmin
        btnTransactions.Parent = pbxAdmin
        btnBookings.Parent = pbxAdmin
        btnExit.Parent = pbxAdmin

        ' Apply hover effects
        hoverButton(btnFlights)
        hoverButton(btnTransactions)
        hoverButton(btnBookings)
        hoverButton(btnExit)

        ' Reduce flickering
        Me.DoubleBuffered = True

        ' Load transaction data
        LoadTransactions()
    End Sub

    ' In Form2 and Form3, modify the btnFlights_Click methods:
    Private Sub btnFlights_Click(sender As Object, e As EventArgs) Handles btnFlights.Click
        Form1.Show()
        Me.Hide()
        Form3.Hide()

        ' Instead of calling RefreshFlightData(), directly call LoadFlightsByDate
        Form1.LoadFlightsByDate(Date.Today)
    End Sub
    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Me.Show()
        Form1.Hide()
        Form3.Hide()
        LoadTransactions()
    End Sub

    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        Me.Hide()
        Form1.Hide()
        Form3.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitToUserForm(Me)
    End Sub

    Private Sub LoadTransactions()
        Dim query As String = "SELECT * FROM transaction_table"
        Dim cmd As New MySqlCommand(query, con)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()

        Try
            openCon()
            adapter.Fill(dt)
            dgvTransactionHistory.DataSource = dt

            ' Column sizing
            dgvTransactionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Header styling
            With dgvTransactionHistory.ColumnHeadersDefaultCellStyle
                .BackColor = Color.FromArgb(17, 47, 78) ' Dark blue header
                .ForeColor = Color.White                ' White header text
                .Font = New Font("Segoe UI", 10, FontStyle.Regular)
            End With
            dgvTransactionHistory.EnableHeadersVisualStyles = False

            ' Row styling
            With dgvTransactionHistory.DefaultCellStyle
                .BackColor = Color.White                ' White row background
                .ForeColor = Color.Black                ' Black text
                .Font = New Font("Segoe UI", 10, FontStyle.Regular)
                .SelectionBackColor = Color.LightBlue
                .SelectionForeColor = Color.Black
            End With

            ' Additional settings
            dgvTransactionHistory.ReadOnly = True
            dgvTransactionHistory.RowHeadersVisible = False
            dgvTransactionHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        Catch ex As Exception
            MessageBox.Show("Failed to load transactions: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub dgvTransactionHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionHistory.CellContentClick

    End Sub
End Class
