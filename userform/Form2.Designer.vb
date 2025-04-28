<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        tbxUsernameSignUp = New TextBox()
        tbxFullnameSignUp = New TextBox()
        tbxPasswordSignUp = New TextBox()
        tbxEmailSignUp = New TextBox()
        btnSignIn = New Button()
        btnSignUp = New Button()
        pbxSignUp = New PictureBox()
        CType(pbxSignUp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbxUsernameSignUp
        ' 
        tbxUsernameSignUp.Location = New Point(535, 279)
        tbxUsernameSignUp.Margin = New Padding(3, 2, 3, 2)
        tbxUsernameSignUp.MaximumSize = New Size(304, 33)
        tbxUsernameSignUp.Name = "tbxUsernameSignUp"
        tbxUsernameSignUp.Size = New Size(304, 23)
        tbxUsernameSignUp.TabIndex = 17
        ' 
        ' tbxFullnameSignUp
        ' 
        tbxFullnameSignUp.ForeColor = SystemColors.InactiveCaption
        tbxFullnameSignUp.Location = New Point(535, 196)
        tbxFullnameSignUp.Margin = New Padding(3, 2, 3, 2)
        tbxFullnameSignUp.MaximumSize = New Size(304, 33)
        tbxFullnameSignUp.Name = "tbxFullnameSignUp"
        tbxFullnameSignUp.Size = New Size(304, 23)
        tbxFullnameSignUp.TabIndex = 16
        ' 
        ' tbxPasswordSignUp
        ' 
        tbxPasswordSignUp.Location = New Point(535, 368)
        tbxPasswordSignUp.Margin = New Padding(3, 2, 3, 2)
        tbxPasswordSignUp.MaximumSize = New Size(304, 33)
        tbxPasswordSignUp.Name = "tbxPasswordSignUp"
        tbxPasswordSignUp.Size = New Size(304, 23)
        tbxPasswordSignUp.TabIndex = 20
        ' 
        ' tbxEmailSignUp
        ' 
        tbxEmailSignUp.Location = New Point(535, 463)
        tbxEmailSignUp.Margin = New Padding(3, 2, 3, 2)
        tbxEmailSignUp.MaximumSize = New Size(304, 33)
        tbxEmailSignUp.Name = "tbxEmailSignUp"
        tbxEmailSignUp.Size = New Size(304, 23)
        tbxEmailSignUp.TabIndex = 22
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = SystemColors.Control
        btnSignIn.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignIn.ForeColor = SystemColors.ActiveCaptionText
        btnSignIn.Location = New Point(516, 521)
        btnSignIn.Margin = New Padding(3, 2, 3, 2)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(167, 41)
        btnSignIn.TabIndex = 23
        btnSignIn.Text = " "
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.DodgerBlue
        btnSignUp.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.ForeColor = SystemColors.ButtonHighlight
        btnSignUp.Location = New Point(689, 519)
        btnSignUp.Margin = New Padding(3, 2, 3, 2)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(164, 47)
        btnSignUp.TabIndex = 24
        btnSignUp.Text = " "
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' pbxSignUp
        ' 
        pbxSignUp.BackgroundImage = My.Resources.Resources.Sign_up
        pbxSignUp.Location = New Point(-3, -2)
        pbxSignUp.Name = "pbxSignUp"
        pbxSignUp.Size = New Size(920, 615)
        pbxSignUp.TabIndex = 25
        pbxSignUp.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(913, 603)
        Controls.Add(btnSignUp)
        Controls.Add(btnSignIn)
        Controls.Add(tbxEmailSignUp)
        Controls.Add(tbxPasswordSignUp)
        Controls.Add(tbxUsernameSignUp)
        Controls.Add(tbxFullnameSignUp)
        Controls.Add(pbxSignUp)
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(930, 648)
        Name = "Form2"
        Text = "Create an Account"
        CType(pbxSignUp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tbxUsernameSignUp As TextBox
    Friend WithEvents tbxFullnameSignUp As TextBox
    Friend WithEvents tbxPasswordSignUp As TextBox
    Friend WithEvents tbxEmailSignUp As TextBox
    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents pbxSignUp As PictureBox
End Class
