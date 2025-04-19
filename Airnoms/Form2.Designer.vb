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
        pbxNomAirSignUp = New PictureBox()
        tbxUsernameSignUp = New TextBox()
        tbxFullnameSignUp = New TextBox()
        lblUsernameSignUp = New Label()
        lblFullnameSignUp = New Label()
        lblTitle = New Label()
        lblSignUp = New Label()
        TextBox1 = New TextBox()
        lblPasswordSignUp = New Label()
        tbxEmailSignUp = New TextBox()
        lblEmailSignUp = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(pbxNomAirSignUp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbxNomAirSignUp
        ' 
        pbxNomAirSignUp.BackColor = SystemColors.ActiveCaption
        pbxNomAirSignUp.Location = New Point(27, 31)
        pbxNomAirSignUp.Name = "pbxNomAirSignUp"
        pbxNomAirSignUp.Size = New Size(422, 519)
        pbxNomAirSignUp.TabIndex = 18
        pbxNomAirSignUp.TabStop = False
        ' 
        ' tbxUsernameSignUp
        ' 
        tbxUsernameSignUp.Location = New Point(506, 252)
        tbxUsernameSignUp.MaximumSize = New Size(347, 33)
        tbxUsernameSignUp.Name = "tbxUsernameSignUp"
        tbxUsernameSignUp.Size = New Size(347, 27)
        tbxUsernameSignUp.TabIndex = 17
        ' 
        ' tbxFullnameSignUp
        ' 
        tbxFullnameSignUp.ForeColor = SystemColors.InactiveCaption
        tbxFullnameSignUp.Location = New Point(506, 168)
        tbxFullnameSignUp.MaximumSize = New Size(347, 33)
        tbxFullnameSignUp.Name = "tbxFullnameSignUp"
        tbxFullnameSignUp.Size = New Size(347, 27)
        tbxFullnameSignUp.TabIndex = 16
        ' 
        ' lblUsernameSignUp
        ' 
        lblUsernameSignUp.AutoSize = True
        lblUsernameSignUp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsernameSignUp.Location = New Point(482, 206)
        lblUsernameSignUp.Name = "lblUsernameSignUp"
        lblUsernameSignUp.Size = New Size(99, 28)
        lblUsernameSignUp.TabIndex = 13
        lblUsernameSignUp.Text = "Username"
        ' 
        ' lblFullnameSignUp
        ' 
        lblFullnameSignUp.AutoSize = True
        lblFullnameSignUp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullnameSignUp.Location = New Point(481, 125)
        lblFullnameSignUp.Name = "lblFullnameSignUp"
        lblFullnameSignUp.Size = New Size(91, 28)
        lblFullnameSignUp.TabIndex = 12
        lblFullnameSignUp.Text = "Fullname"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ActiveBorder
        lblTitle.Location = New Point(540, 88)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(265, 28)
        lblTitle.TabIndex = 11
        lblTitle.Text = "International Nom Airlines"
        ' 
        ' lblSignUp
        ' 
        lblSignUp.AutoSize = True
        lblSignUp.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSignUp.Location = New Point(610, 43)
        lblSignUp.Name = "lblSignUp"
        lblSignUp.Size = New Size(120, 38)
        lblSignUp.TabIndex = 10
        lblSignUp.Text = "Sign-up"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(506, 340)
        TextBox1.MaximumSize = New Size(347, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(347, 27)
        TextBox1.TabIndex = 20
        ' 
        ' lblPasswordSignUp
        ' 
        lblPasswordSignUp.AutoSize = True
        lblPasswordSignUp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPasswordSignUp.Location = New Point(482, 292)
        lblPasswordSignUp.Name = "lblPasswordSignUp"
        lblPasswordSignUp.Size = New Size(93, 28)
        lblPasswordSignUp.TabIndex = 19
        lblPasswordSignUp.Text = "Password"
        ' 
        ' tbxEmailSignUp
        ' 
        tbxEmailSignUp.Location = New Point(506, 432)
        tbxEmailSignUp.MaximumSize = New Size(347, 33)
        tbxEmailSignUp.Name = "tbxEmailSignUp"
        tbxEmailSignUp.Size = New Size(347, 27)
        tbxEmailSignUp.TabIndex = 22
        ' 
        ' lblEmailSignUp
        ' 
        lblEmailSignUp.AutoSize = True
        lblEmailSignUp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmailSignUp.Location = New Point(481, 384)
        lblEmailSignUp.Name = "lblEmailSignUp"
        lblEmailSignUp.Size = New Size(59, 28)
        lblEmailSignUp.TabIndex = 21
        lblEmailSignUp.Text = "Email"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(499, 489)
        Button1.Name = "Button1"
        Button1.Size = New Size(178, 48)
        Button1.TabIndex = 23
        Button1.Text = "Sign in"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DodgerBlue
        Button2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(679, 489)
        Button2.Name = "Button2"
        Button2.Size = New Size(178, 48)
        Button2.TabIndex = 24
        Button2.Text = "Sign up"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(913, 582)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(tbxEmailSignUp)
        Controls.Add(lblEmailSignUp)
        Controls.Add(TextBox1)
        Controls.Add(lblPasswordSignUp)
        Controls.Add(pbxNomAirSignUp)
        Controls.Add(tbxUsernameSignUp)
        Controls.Add(tbxFullnameSignUp)
        Controls.Add(lblUsernameSignUp)
        Controls.Add(lblFullnameSignUp)
        Controls.Add(lblTitle)
        Controls.Add(lblSignUp)
        Name = "Form2"
        Text = "Create an Account"
        CType(pbxNomAirSignUp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbxNomAirSignUp As PictureBox
    Friend WithEvents tbxUsernameSignUp As TextBox
    Friend WithEvents tbxFullnameSignUp As TextBox
    Friend WithEvents lblUsernameSignUp As Label
    Friend WithEvents lblFullnameSignUp As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSignUp As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPasswordSignUp As Label
    Friend WithEvents tbxEmailSignUp As TextBox
    Friend WithEvents lblEmailSignUp As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
