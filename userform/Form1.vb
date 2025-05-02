Imports SharedModule
Imports admin
Imports cashierform
Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnSignIn)
        MakeTransparent(btnCreateAccount)
        btnSignIn.Parent = pbxSignIn
        btnCreateAccount.Parent = pbxSignIn
        hoverButton(btnSignIn)
        hoverButton(btnCreateAccount)
        btnSignIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnSignIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255) ' effects for button
        Me.DoubleBuffered = True
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If String.IsNullOrWhiteSpace(tbxUsername.Text) OrElse String.IsNullOrWhiteSpace(tbxPassword.Text) Then
            MessageBox.Show("Please enter your username and password.")
            Return
        End If

        Try
            openCon()

            Dim query As String = "SELECT * FROM acc_table WHERE Username = @username AND Password = @password"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", tbxUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@password", tbxPassword.Text.Trim())

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                Dim dbUsername As String = table.Rows(0)("Username").ToString()
                Dim dbPassword As String = table.Rows(0)("Password").ToString()

                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                tbxUsername.Clear()
                tbxPassword.Clear()
                Me.Hide()

                If dbUsername = "admin" AndAlso dbPassword = "admin123" Then
                    ' Open the Admin project's Form1
                    Dim adminForm As New admin.Form1()
                    adminForm.Show()
                ElseIf dbUsername = "cashier" AndAlso dbPassword = "cashier123" Then
                    ' Open the Cashier project's Form1
                    Dim cashierForm As New cashierform.Form1()
                    cashierForm.Show()
                Else
                    Form3.Show()
                End If
            Else
                MessageBox.Show("Invalid username or password")
            End If


        Catch ex As Exception
            MessageBox.Show("Login Failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            con.Close()
        End Try
    End Sub


End Class
