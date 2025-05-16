Imports MySql.Data.MySqlClient
Imports SharedModule
Public Class Form4
    Private flightID As String
    Public FlightWasCancelled As Boolean = False
    Public FlightWasDelayed As Boolean = False

    ' Reference to Form1 to call refresh directly
    Private parentForm As Form1

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnDelayFlight)
        MakeTransparent(btnCancelFlight)
        MakeTransparent(btnReturn)
        ' Set the form's background color to transparent

        btnDelayFlight.Parent = pbxCancelFlight
        btnCancelFlight.Parent = pbxCancelFlight
        btnReturn.Parent = pbxCancelFlight

        hoverButton(btnDelayFlight)
        hoverButton(btnCancelFlight)
        hoverButton(btnReturn)
        ' Set the form's background color to transparent
        btnDelayFlight.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnDelayFlight.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255)

    End Sub

    ' Modified constructor to accept parent form
    Public Sub New(form1Reference As Form1)
        InitializeComponent()
        parentForm = form1Reference
    End Sub

    ' Default constructor for designer
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Call this when showing the form
    Public Sub LoadFlightDetails(selectedFlightID As String)
        flightID = selectedFlightID
        lblFlight_Id.Text = selectedFlightID ' Show in label
    End Sub

    Private Function GetFlightStatus() As String
        Try
            openCon()
            Dim query As String = "SELECT status FROM flight_table WHERE flight_id = @FlightID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@FlightID", flightID)
            Dim statusObj = cmd.ExecuteScalar()
            Return If(statusObj IsNot Nothing, statusObj.ToString(), "")
        Catch ex As Exception
            MessageBox.Show("Error fetching flight status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function

    ' Delay flight by 2–3 hours

    Private Sub btnDelayFlight_Click(sender As Object, e As EventArgs) Handles btnDelayFlight.Click
        Dim delayHours As Integer = (New Random()).Next(2, 4) ' 2 or 3
        DelayFlight(flightID, delayHours) ' Call from module
        FlightWasDelayed = True

        ' Force the parent form to refresh in multiple ways
        Try
            ' Try getting the owner form and casting to Form1
            If Me.Owner IsNot Nothing AndAlso TypeOf Me.Owner Is Form1 Then
                Dim ownerForm As Form1 = DirectCast(Me.Owner, Form1)
                MessageBox.Show("About to refresh data through Owner form", "Debug", MessageBoxButtons.OK)
                ownerForm.RefreshFlightData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error refreshing through Owner: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Try forcing the DataGridView to refresh directly
        Try
            For Each form In Application.OpenForms
                If TypeOf form Is Form1 Then
                    Dim mainForm As Form1 = DirectCast(form, Form1)
                    MessageBox.Show("About to refresh data through Application.OpenForms", "Debug", MessageBoxButtons.OK)
                    mainForm.RefreshFlightData()
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error refreshing through OpenForms: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MessageBox.Show($"Flight {flightID} delayed by {delayHours} hour(s).", "Delayed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    ' Cancel the flight
    Private Sub btnCancelFlight_Click(sender As Object, e As EventArgs) Handles btnCancelFlight.Click
        CancelFlight(flightID)
        FlightWasCancelled = True

        ' Direct refresh of parent form's data
        If parentForm IsNot Nothing Then
            MessageBox.Show("Parent form reference found — refreshing...")
            parentForm.RefreshFlightData()
        Else
            MessageBox.Show("Parent form reference is NOTHING!")
        End If

        MessageBox.Show($"Flight {flightID} has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Me.Close()
    End Sub

    ' Close popup
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

End Class