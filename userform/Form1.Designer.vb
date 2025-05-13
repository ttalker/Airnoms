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
        components = New ComponentModel.Container()
        btnSignIn = New Button()
        btnCreateAccount = New Button()
        tbxUsername = New TextBox()
        tbxPassword = New TextBox()
        pbxSignIn = New PictureBox()
        ErrorProvider = New ErrorProvider(components)
        CType(pbxSignIn, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.DodgerBlue
        btnSignIn.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignIn.ForeColor = SystemColors.ButtonHighlight
        btnSignIn.Location = New Point(514, 363)
        btnSignIn.Margin = New Padding(3, 2, 3, 2)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(338, 62)
        btnSignIn.TabIndex = 5
        btnSignIn.Text = " "
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
        btnCreateAccount.Text = " "
        btnCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' tbxUsername
        ' 
        tbxUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxUsername.ForeColor = SystemColors.WindowText
        tbxUsername.Location = New Point(529, 205)
        tbxUsername.Margin = New Padding(3, 2, 3, 2)
        tbxUsername.MaximumSize = New Size(304, 33)
        tbxUsername.Name = "tbxUsername"
        tbxUsername.Size = New Size(304, 29)
        tbxUsername.TabIndex = 7
        ' 
        ' tbxPassword
        ' 
        tbxPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxPassword.Location = New Point(529, 299)
        tbxPassword.Margin = New Padding(3, 2, 3, 2)
        tbxPassword.MaximumSize = New Size(304, 33)
        tbxPassword.Name = "tbxPassword"
        tbxPassword.Size = New Size(304, 29)
        tbxPassword.TabIndex = 8
        ' 
        ' pbxSignIn
        ' 
        pbxSignIn.BackgroundImage = My.Resources.Resources.login_form__1_
        pbxSignIn.Location = New Point(-2, -2)
        pbxSignIn.Name = "pbxSignIn"
        pbxSignIn.Size = New Size(917, 615)
        pbxSignIn.TabIndex = 9
        pbxSignIn.TabStop = False
        ' 
        ' ErrorProvider
        ' 
        ErrorProvider.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 611)
        Controls.Add(tbxPassword)
        Controls.Add(tbxUsername)
        Controls.Add(btnCreateAccount)
        Controls.Add(btnSignIn)
        Controls.Add(pbxSignIn)
        DoubleBuffered = True
        Margin = New Padding(2)
        MaximumSize = New Size(931, 650)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "International Nom Airlines"
        CType(pbxSignIn, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSignIn As Button
    Friend WithEvents tbxUsername As TextBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents pbxSignIn As PictureBox
    Friend WithEvents ErrorProvider As ErrorProvider
    'Friend WithEvents pbxNomAirSignIn As PictureBox

End Class
