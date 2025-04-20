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
        ErrorProvider1 = New ErrorProvider(components)
        lblPassword = New Label()
        btnSignIn = New Button()
        btnCreateAccount = New Button()
        tbxUsername = New TextBox()
        lblSignIn = New Label()
        lblTitle = New Label()
        tbxPassword = New TextBox()
        lblUsername = New Label()
        pbxNomAirSignIn = New PictureBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxNomAirSignIn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(473, 233)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(93, 28)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.DodgerBlue
        btnSignIn.Font = New Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignIn.ForeColor = SystemColors.ButtonHighlight
        btnSignIn.Location = New Point(497, 346)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(347, 59)
        btnSignIn.TabIndex = 5
        btnSignIn.Text = "Sign In"
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateAccount.Location = New Point(497, 428)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(347, 59)
        btnCreateAccount.TabIndex = 6
        btnCreateAccount.Text = "Create an Account"
        btnCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' tbxUsername
        ' 
        tbxUsername.ForeColor = SystemColors.InactiveCaption
        tbxUsername.Location = New Point(497, 189)
        tbxUsername.MaximumSize = New Size(347, 33)
        tbxUsername.Name = "tbxUsername"
        tbxUsername.Size = New Size(347, 27)
        tbxUsername.TabIndex = 7
        ' 
        ' lblSignIn
        ' 
        lblSignIn.AutoSize = True
        lblSignIn.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSignIn.Location = New Point(610, 43)
        lblSignIn.Name = "lblSignIn"
        lblSignIn.Size = New Size(109, 38)
        lblSignIn.TabIndex = 0
        lblSignIn.Text = "Sign In"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ActiveBorder
        lblTitle.Location = New Point(540, 88)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(265, 28)
        lblTitle.TabIndex = 2
        lblTitle.Text = "International Nom Airlines"
        ' 
        ' tbxPassword
        ' 
        tbxPassword.Location = New Point(497, 281)
        tbxPassword.MaximumSize = New Size(347, 33)
        tbxPassword.Name = "tbxPassword"
        tbxPassword.Size = New Size(347, 27)
        tbxPassword.TabIndex = 8
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(472, 141)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(99, 28)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username"
        ' 
        ' pbxNomAirSignIn
        ' 
        pbxNomAirSignIn.BackColor = SystemColors.ActiveCaption
        pbxNomAirSignIn.Location = New Point(27, 31)
        pbxNomAirSignIn.Name = "pbxNomAirSignIn"
        pbxNomAirSignIn.Size = New Size(422, 519)
        pbxNomAirSignIn.TabIndex = 9
        pbxNomAirSignIn.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(913, 582)
        Controls.Add(pbxNomAirSignIn)
        Controls.Add(tbxPassword)
        Controls.Add(tbxUsername)
        Controls.Add(btnCreateAccount)
        Controls.Add(btnSignIn)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(lblTitle)
        Controls.Add(lblSignIn)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "International Nom Airlines"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxNomAirSignIn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSignIn As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnSignIn As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbxUsername As TextBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents pbxNomAirSignIn As PictureBox
    Friend WithEvents lblUsername As Label
    'Friend WithEvents pbxNomAirSignIn As PictureBox

End Class
