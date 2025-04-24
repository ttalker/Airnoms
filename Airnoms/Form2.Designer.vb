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
        TextBox1 = New TextBox()
        tbxEmailSignUp = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(535, 368)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.MaximumSize = New Size(304, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(304, 23)
        TextBox1.TabIndex = 20
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
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(509, 522)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 41)
        Button1.TabIndex = 23
        Button1.Text = "Sign in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DodgerBlue
        Button2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(685, 521)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 47)
        Button2.TabIndex = 24
        Button2.Text = "Sign up"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Sign_up
        PictureBox1.Location = New Point(-3, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(920, 615)
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 611)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(tbxEmailSignUp)
        Controls.Add(TextBox1)
        Controls.Add(tbxUsernameSignUp)
        Controls.Add(tbxFullnameSignUp)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(931, 650)
        Name = "Form2"
        Text = "Create an Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tbxUsernameSignUp As TextBox
    Friend WithEvents tbxFullnameSignUp As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tbxEmailSignUp As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
