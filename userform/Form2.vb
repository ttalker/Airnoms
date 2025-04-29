'Imports cashierform
'Imports admin.Module1
'Imports Windows.Win32.System
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

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Dim hasError As Boolean = False
        ErrorProvider.Clear()
        If String.IsNullOrWhiteSpace(tbxFullnameSignUp.Text) Then
            ErrorProvider.SetError(tbxFullnameSignUp, "Invalid name")
            hasError = True
        End If

        If String.IsNullOrWhiteSpace(tbxUsernameSignUp.Text) Then
            ErrorProvider.SetError(tbxUsernameSignUp, "Invalid username")
            hasError = True
        End If

        If tbxPasswordSignUp.Text.Length < 8 Then 'error on password error provider
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

        Try
            openCon()
            MessageBox.Show("Connection Successful!")
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
        Catch ex As Exception
            MessageBox.Show("Connection Failed: " & ex.Message)
        Finally
            con.Close()
            Me.Hide()
            Form1.Show()
        End Try
    End Sub
End Class