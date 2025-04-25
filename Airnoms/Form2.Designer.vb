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
        tbxUsernameSignUp.Location = New Point(611, 372)
        tbxUsernameSignUp.MaximumSize = New Size(347, 33)
        tbxUsernameSignUp.Name = "tbxUsernameSignUp"
        tbxUsernameSignUp.Size = New Size(347, 27)
        tbxUsernameSignUp.TabIndex = 17
        ' 
        ' tbxFullnameSignUp
        ' 
        tbxFullnameSignUp.ForeColor = SystemColors.InactiveCaption
        tbxFullnameSignUp.Location = New Point(611, 261)
        tbxFullnameSignUp.MaximumSize = New Size(347, 33)
        tbxFullnameSignUp.Name = "tbxFullnameSignUp"
        tbxFullnameSignUp.Size = New Size(347, 27)
        tbxFullnameSignUp.TabIndex = 16
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(611, 491)
        TextBox1.MaximumSize = New Size(347, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(347, 27)
        TextBox1.TabIndex = 20
        ' 
        ' tbxEmailSignUp
        ' 
        tbxEmailSignUp.Location = New Point(611, 617)
        tbxEmailSignUp.MaximumSize = New Size(347, 33)
        tbxEmailSignUp.Name = "tbxEmailSignUp"
        tbxEmailSignUp.Size = New Size(347, 27)
        tbxEmailSignUp.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(582, 696)
        Button1.Name = "Button1"
        Button1.Size = New Size(197, 55)
        Button1.TabIndex = 23
        Button1.Text = "Sign in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DodgerBlue
        Button2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(783, 695)
        Button2.Name = "Button2"
        Button2.Size = New Size(193, 63)
        Button2.TabIndex = 24
        Button2.Text = "Sign up"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Sign_up
        PictureBox1.Location = New Point(-3, -3)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1051, 820)
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1043, 804)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(tbxEmailSignUp)
        Controls.Add(TextBox1)
        Controls.Add(tbxUsernameSignUp)
        Controls.Add(tbxFullnameSignUp)
        Controls.Add(PictureBox1)
        MaximumSize = New Size(1061, 851)
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
