<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSignIn = New Button()
        btnCreateAccount = New Button()
        tbxUsername = New TextBox()
        tbxPassword = New TextBox()
        SuspendLayout()
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.DodgerBlue
        btnSignIn.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignIn.ForeColor = SystemColors.ButtonHighlight
        btnSignIn.Location = New Point(514, 364)
        btnSignIn.Margin = New Padding(3, 2, 3, 2)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(338, 62)
        btnSignIn.TabIndex = 5
        btnSignIn.Text = "Sign In"
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateAccount.Location = New Point(514, 447)
        btnCreateAccount.Margin = New Padding(3, 2, 3, 2)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(338, 57)
        btnCreateAccount.TabIndex = 6
        btnCreateAccount.Text = "Create an Account"
        btnCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' tbxUsername
        ' 
        tbxUsername.ForeColor = SystemColors.InactiveCaption
        tbxUsername.Location = New Point(529, 211)
        tbxUsername.Margin = New Padding(3, 2, 3, 2)
        tbxUsername.MaximumSize = New Size(304, 33)
        tbxUsername.Name = "tbxUsername"
        tbxUsername.Size = New Size(304, 23)
        tbxUsername.TabIndex = 7
        ' 
        ' tbxPassword
        ' 
        tbxPassword.Location = New Point(529, 299)
        tbxPassword.Margin = New Padding(3, 2, 3, 2)
        tbxPassword.MaximumSize = New Size(304, 33)
        tbxPassword.Name = "tbxPassword"
        tbxPassword.Size = New Size(304, 23)
        tbxPassword.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.login_form__1_
        ClientSize = New Size(915, 611)
        Controls.Add(tbxPassword)
        Controls.Add(tbxUsername)
        Controls.Add(btnCreateAccount)
        Controls.Add(btnSignIn)
        DoubleBuffered = True
        Margin = New Padding(2)
        MaximumSize = New Size(931, 650)
        Name = "Form1"
        Text = "International Nom Airlines"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSignIn As Button
    Friend WithEvents tbxUsername As TextBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxPassword As TextBox
    'Friend WithEvents pbxNomAirSignIn As PictureBox

End Class
