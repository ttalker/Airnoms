Imports SharedModule
Public Class Form2
    Public Property username As String
    Public Property password As String
    Public Property fullname As String
    Public Property email As String
    Public Property user_id As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeTransparent(btnSignIn)
        MakeTransparent(btnSignUp)
        btnSignIn.Parent = pbxSignUp
        btnSignUp.Parent = pbxSignUp
        hoverButton(btnSignIn)
        hoverButton(btnSignUp)
        btnSignUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255, 255)
        btnSignUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 255, 255, 255) ' effects for button
        Me.DoubleBuffered = True
        ErrorProvider.Clear() ' clear previous error
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub tbxFullnameSignUp_TextChanged(sender As Object, e As EventArgs) Handles tbxFullnameSignUp.TextChanged
        fullname = tbxFullnameSignUp.Text
    End Sub
    Private Sub tbxUsernameSignUp_TextChanged(sender As Object, e As EventArgs) Handles tbxUsernameSignUp.TextChanged
        username = tbxUsernameSignUp.Text
    End Sub
    Private Sub tbxPasswordsignUp_TextChanged(sender As Object, e As EventArgs) Handles tbxPasswordSignUp.TextChanged
        password = tbxPasswordSignUp.Text
    End Sub
    Private Sub tbxEmailSignUp_TextChanged(sender As Object, e As EventArgs) Handles tbxEmailSignUp.TextChanged
        email = tbxEmailSignUp.Text
    End Sub

    ' Function to check if username or email already exists
    Private Function CheckDuplication(username As String, email As String) As Boolean
        Dim isDuplicate As Boolean = False
        Try
            openCon()
            cmd.Connection = con

            ' Check for duplicate username
            cmd.CommandText = "SELECT COUNT(*) FROM acc_table WHERE Username = '" & username & "'"
            Dim usernameCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Check for duplicate email
            cmd.CommandText = "SELECT COUNT(*) FROM acc_table WHERE Email = '" & email & "'"
            Dim emailCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Set error messages based on what's duplicated
            If usernameCount > 0 Then
                ErrorProvider.SetError(tbxUsernameSignUp, "Username already exists")
                isDuplicate = True
            End If

            If emailCount > 0 Then
                ErrorProvider.SetError(tbxEmailSignUp, "Email already exists")
                isDuplicate = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error checking for duplicates: " & ex.Message)
            isDuplicate = True ' Assume duplication on error to prevent registration
        Finally
            con.Close()
        End Try

        Return isDuplicate
    End Function

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim hasError As Boolean = False
        ErrorProvider.Clear()

        ' Validate inputs
        If String.IsNullOrWhiteSpace(tbxFullnameSignUp.Text) Then
            ErrorProvider.SetError(tbxFullnameSignUp, "Invalid name")
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(tbxUsernameSignUp.Text) Then
            ErrorProvider.SetError(tbxUsernameSignUp, "Invalid username")
            hasError = True
        End If
        If tbxPasswordSignUp.Text.Length < 8 Then
            ErrorProvider.SetError(tbxPasswordSignUp, "Password must be at least 8 characters long")
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(tbxPasswordSignUp.Text) Then
            ErrorProvider.SetError(tbxPasswordSignUp, "Invalid password")
            hasError = True
        End If
        If String.IsNullOrWhiteSpace(tbxEmailSignUp.Text) Then
            ErrorProvider.SetError(tbxEmailSignUp, "Invalid email")
            hasError = True
        End If

        If hasError = True Then
            Exit Sub
        End If

        ' Check for duplicate username or email
        If CheckDuplication(tbxUsernameSignUp.Text, tbxEmailSignUp.Text) Then
            MessageBox.Show("Registration failed. Username or email already exists.")
            Exit Sub
        End If

        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "ALTER TABLE acc_table MODIFY user_id INT AUTO_INCREMENT;"
            cmd.ExecuteNonQuery()
            cmd.CommandText = "INSERT INTO acc_table (Username, Password, Fullname, Email) VALUES ('" &
                   tbxUsernameSignUp.Text & "', '" &
                   tbxPasswordSignUp.Text & "', '" &
                   tbxFullnameSignUp.Text & "', '" &
                   tbxEmailSignUp.Text & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("User registered successfully!")
            tbxUsernameSignUp.Clear()
            tbxPasswordSignUp.Clear()
            tbxFullnameSignUp.Clear()
            tbxEmailSignUp.Clear()

            Me.Hide()
            Form1.Show()
        Catch ex As Exception
            MessageBox.Show("Connection Failed: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class