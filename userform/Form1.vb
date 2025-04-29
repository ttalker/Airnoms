Imports SharedModule
Imports MySql.Data.MySqlClient
Public Class Form1
    Public Property username As String
    Public Property password As String


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
    Private Sub tbxUsername_TextChanged(sender As Object, e As EventArgs) Handles tbxUsername.TextChanged
        username = tbxUsername.Text
    End Sub

    Private Sub tbxPassword_TextChanged(sender As Object, e As EventArgs) Handles tbxPassword.TextChanged
        password = tbxPassword.Text
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        'ErrorProvider.Clear()
        'Try
        '    openCon()

        '    cmd.Connection = con
        '    cmd.CommandText = "SELECT * FROM acc_table WHERE Username ='" + username And "Password ='" + password
        '    cmd.ExecuteNonQuery()
        '    rd = cmd.ExecuteReader()
        '    If rd.Read Then
        '        username = rd("Username").ToString()
        '        password = rd("Password").ToString()
        '        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        ErrorProvider.SetError(tbxUsername, "Invalid username or password")
        '        Return
        '    End If
        '    tbxUsername.Clear()
        '    tbxPassword.Clear()

        'Catch ex As Exception
        '    MessageBox.Show("Login Failed", ex.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally
        '    con.Close()
        '    Me.Hide()
        '    Form3.Show()
        'End Try

    End Sub


End Class
