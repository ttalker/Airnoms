Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports SharedModule



Public Class Form2

    Private ProcessedPassengers As New HashSet(Of String)
    Private TotalFare As Decimal = 0


    Public BaggagePrices As New Dictionary(Of String, Integer) From {
    {"10kg", 1000},
    {"20kg", 1800},
    {"40kg", 3000}
}
    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click

        Show()
        Form1.Hide()
    End Sub

    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click

        Form1.support_form.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitToUserForm(Me)
    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnBooking)
        MakeTransparent(btnTicket)
        MakeTransparent(btnSupport)
        MakeTransparent(btnExit)
        MakeTransparent(btnCalculate)
        MakeTransparent(btnResetTicket)
        MakeTransparent(btnNextTicket)
        MakeTransparent(btnProcessTicket)
        MakeTransparent(btnSearch)

        btnBooking.Parent = pbxCashierTicket
        btnTicket.Parent = pbxCashierTicket
        btnSupport.Parent = pbxCashierTicket
        btnExit.Parent = pbxCashierTicket
        btnCalculate.Parent = pbxCashierTicket
        btnResetTicket.Parent = pbxCashierTicket
        btnNextTicket.Parent = pbxCashierTicket
        btnSearch.Parent = pbxCashierTicket
        btnProcessTicket.Parent = pbxCashierTicket ' transparency of the buttons

        hoverButton(btnBooking)
        hoverButton(btnTicket)
        hoverButton(btnSupport)
        hoverButton(btnExit)
        hoverButton(btnCalculate)
        hoverButton(btnResetTicket)
        hoverButton(btnSearch)
        hoverButton(btnProcessTicket) ' hover effect of the buttons

        btnNextTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnNextTicket.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)
        btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnCalculate.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255) ' hover effect of the button next ticket and calculate
        btnProcessTicket.Enabled = False

        ' Set the background color of the form to transparent   

        Me.DoubleBuffered = True ' double buffered so the form wont tweak or lag

        cbxPassengerTicket.AutoCompleteMode = AutoCompleteMode.None
        cbxPassengerTicket.DropDownStyle = ComboBoxStyle.DropDown

        'Load bookers
        Dim bookers = LoadBookers()

        For Each booker In bookers
            cbxPassengerTicket.Items.Add(booker)
        Next
        Dim current_dict = bookingDictionary
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

    End Sub

    Private Sub cbxPassengerTicket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPassengerTicket.SelectedIndexChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchText As String = cbxPassengerTicket.Text.Trim().ToLower()
            cbxPassengerTicket.Items.Clear()

            For Each key In bookingDictionary.Keys
                If searchText = "" OrElse key.ToLower().Contains(searchText) Then
                    cbxPassengerTicket.Items.Add(key)
                End If
            Next

            ' Show dropdown if there are results
            If cbxPassengerTicket.Items.Count > 0 Then
                cbxPassengerTicket.DroppedDown = True
            End If

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    Private Sub cbxPassengerTicket_TextChanged(sender As Object, e As EventArgs) Handles cbxPassengerTicket.TextChanged
        Dim text As String = cbxPassengerTicket.Text
        Dim selectionStart As Integer = cbxPassengerTicket.SelectionStart

        ' Filter matches
        Dim matches = bookingDictionary.Keys.Where(Function(k) k.ToLower().Contains(text.ToLower())).ToList()

        ' Only update if there are matches
        If matches.Count > 0 Then
            ' Temporarily prevent event re-firing
            RemoveHandler cbxPassengerTicket.TextChanged, AddressOf cbxPassengerTicket_TextChanged

            cbxPassengerTicket.BeginUpdate()
            cbxPassengerTicket.Items.Clear()
            cbxPassengerTicket.Items.AddRange(matches.ToArray())
            cbxPassengerTicket.DroppedDown = True
            cbxPassengerTicket.SelectedIndex = -1
            cbxPassengerTicket.Text = text
            cbxPassengerTicket.SelectionStart = selectionStart
            cbxPassengerTicket.SelectionLength = 0
            cbxPassengerTicket.EndUpdate()

            AddHandler cbxPassengerTicket.TextChanged, AddressOf cbxPassengerTicket_TextChanged
        Else
            cbxPassengerTicket.DroppedDown = False
        End If
    End Sub
End Class