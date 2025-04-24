<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        ptbImages = New PictureBox()
        pnlPlane = New Panel()
        Button3 = New Button()
        Label1 = New Label()
        pnlBg = New Panel()
        pnlButtons = New Panel()
        btnAirbus330800 = New Button()
        lblAirbus330800 = New Label()
        btnAirbus330300 = New Button()
        lblAirbus330300 = New Label()
        btnAirbus321 = New Button()
        btnAirbus320 = New Button()
        lblAirbus321 = New Label()
        lblAirbus320 = New Label()
        btnAirbus350900 = New Button()
        lblAirbus350900 = New Label()
        CType(ptbImages, ComponentModel.ISupportInitialize).BeginInit()
        pnlPlane.SuspendLayout()
        pnlBg.SuspendLayout()
        pnlButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' ptbImages
        ' 
        ptbImages.BackColor = Color.Transparent
        ptbImages.BackgroundImageLayout = ImageLayout.None
        ptbImages.Location = New Point(112, 110)
        ptbImages.Name = "ptbImages"
        ptbImages.Size = New Size(400, 100)
        ptbImages.SizeMode = PictureBoxSizeMode.AutoSize
        ptbImages.TabIndex = 1
        ptbImages.TabStop = False
        ' 
        ' pnlPlane
        ' 
        pnlPlane.AutoScroll = True
        pnlPlane.BackColor = Color.Transparent
        pnlPlane.BackgroundImage = CType(resources.GetObject("pnlPlane.BackgroundImage"), Image)
        pnlPlane.BackgroundImageLayout = ImageLayout.Stretch
        pnlPlane.Controls.Add(Button3)
        pnlPlane.Controls.Add(ptbImages)
        pnlPlane.Controls.Add(Label1)
        pnlPlane.Location = New Point(446, 23)
        pnlPlane.Name = "pnlPlane"
        pnlPlane.Size = New Size(692, 917)
        pnlPlane.TabIndex = 2
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Location = New Point(63, 620)
        Button3.Name = "Button3"
        Button3.Size = New Size(381, 79)
        Button3.TabIndex = 10
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Image = My.Resources.Resources.Airbus321pics
        Label1.Location = New Point(112, 368)
        Label1.Name = "Label1"
        Label1.Size = New Size(328, 92)
        Label1.TabIndex = 5
        Label1.Visible = False
        ' 
        ' pnlBg
        ' 
        pnlBg.BackColor = Color.Transparent
        pnlBg.BackgroundImage = CType(resources.GetObject("pnlBg.BackgroundImage"), Image)
        pnlBg.Controls.Add(pnlPlane)
        pnlBg.Controls.Add(pnlButtons)
        pnlBg.Dock = DockStyle.Fill
        pnlBg.Location = New Point(0, 0)
        pnlBg.Name = "pnlBg"
        pnlBg.Size = New Size(1156, 953)
        pnlBg.TabIndex = 3
        ' 
        ' pnlButtons
        ' 
        pnlButtons.BackColor = Color.Transparent
        pnlButtons.BackgroundImage = My.Resources.Resources.buttonpics
        pnlButtons.Controls.Add(btnAirbus330800)
        pnlButtons.Controls.Add(lblAirbus330800)
        pnlButtons.Controls.Add(btnAirbus330300)
        pnlButtons.Controls.Add(lblAirbus330300)
        pnlButtons.Controls.Add(btnAirbus321)
        pnlButtons.Controls.Add(btnAirbus320)
        pnlButtons.Controls.Add(lblAirbus321)
        pnlButtons.Controls.Add(lblAirbus320)
        pnlButtons.Controls.Add(btnAirbus350900)
        pnlButtons.Controls.Add(lblAirbus350900)
        pnlButtons.Location = New Point(12, 23)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New Size(411, 917)
        pnlButtons.TabIndex = 0
        ' 
        ' btnAirbus330800
        ' 
        btnAirbus330800.BackColor = Color.Transparent
        btnAirbus330800.Location = New Point(12, 381)
        btnAirbus330800.Name = "btnAirbus330800"
        btnAirbus330800.Size = New Size(381, 79)
        btnAirbus330800.TabIndex = 11
        btnAirbus330800.UseVisualStyleBackColor = False
        ' 
        ' lblAirbus330800
        ' 
        lblAirbus330800.Image = My.Resources.Resources.Airbus330_800pics
        lblAirbus330800.Location = New Point(37, 368)
        lblAirbus330800.Name = "lblAirbus330800"
        lblAirbus330800.Size = New Size(328, 92)
        lblAirbus330800.TabIndex = 11
        lblAirbus330800.Visible = False
        ' 
        ' btnAirbus330300
        ' 
        btnAirbus330300.BackColor = Color.Transparent
        btnAirbus330300.Location = New Point(12, 205)
        btnAirbus330300.Name = "btnAirbus330300"
        btnAirbus330300.Size = New Size(381, 86)
        btnAirbus330300.TabIndex = 8
        btnAirbus330300.UseVisualStyleBackColor = False
        ' 
        ' lblAirbus330300
        ' 
        lblAirbus330300.Image = My.Resources.Resources.Airbus330_300pics
        lblAirbus330300.Location = New Point(37, 202)
        lblAirbus330300.Name = "lblAirbus330300"
        lblAirbus330300.Size = New Size(328, 92)
        lblAirbus330300.TabIndex = 6
        lblAirbus330300.Visible = False
        ' 
        ' btnAirbus321
        ' 
        btnAirbus321.BackColor = Color.Transparent
        btnAirbus321.Location = New Point(12, 110)
        btnAirbus321.Name = "btnAirbus321"
        btnAirbus321.Size = New Size(381, 89)
        btnAirbus321.TabIndex = 4
        btnAirbus321.UseVisualStyleBackColor = False
        ' 
        ' btnAirbus320
        ' 
        btnAirbus320.BackColor = Color.Transparent
        btnAirbus320.Location = New Point(12, 28)
        btnAirbus320.Name = "btnAirbus320"
        btnAirbus320.Size = New Size(381, 79)
        btnAirbus320.TabIndex = 2
        btnAirbus320.UseVisualStyleBackColor = False
        ' 
        ' lblAirbus321
        ' 
        lblAirbus321.Image = My.Resources.Resources.Airbus321pics
        lblAirbus321.Location = New Point(37, 110)
        lblAirbus321.Name = "lblAirbus321"
        lblAirbus321.Size = New Size(328, 92)
        lblAirbus321.TabIndex = 3
        lblAirbus321.Visible = False
        ' 
        ' lblAirbus320
        ' 
        lblAirbus320.Image = My.Resources.Resources.Airbus320pic
        lblAirbus320.Location = New Point(37, 28)
        lblAirbus320.Name = "lblAirbus320"
        lblAirbus320.Size = New Size(328, 92)
        lblAirbus320.TabIndex = 2
        lblAirbus320.Visible = False
        ' 
        ' btnAirbus350900
        ' 
        btnAirbus350900.BackColor = Color.Transparent
        btnAirbus350900.Location = New Point(12, 297)
        btnAirbus350900.Name = "btnAirbus350900"
        btnAirbus350900.Size = New Size(381, 79)
        btnAirbus350900.TabIndex = 8
        btnAirbus350900.UseVisualStyleBackColor = False
        ' 
        ' lblAirbus350900
        ' 
        lblAirbus350900.Image = My.Resources.Resources.airbus350_900pics
        lblAirbus350900.Location = New Point(37, 286)
        lblAirbus350900.Name = "lblAirbus350900"
        lblAirbus350900.Size = New Size(328, 92)
        lblAirbus350900.TabIndex = 9
        lblAirbus350900.Visible = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1156, 953)
        Controls.Add(pnlBg)
        Name = "Form3"
        Text = "Form3"
        CType(ptbImages, ComponentModel.ISupportInitialize).EndInit()
        pnlPlane.ResumeLayout(False)
        pnlPlane.PerformLayout()
        pnlBg.ResumeLayout(False)
        pnlButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents ptbImages As PictureBox
    Friend WithEvents pnlPlane As Panel
    Friend WithEvents pnlBg As Panel
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnAirbus320 As Button
    Friend WithEvents lblAirbus320 As Label
    Friend WithEvents btnAirbus321 As Button
    Friend WithEvents lblAirbus321 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAirbus330300 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAirbus330300 As Button
    Friend WithEvents btnAirbus350900 As Button
    Friend WithEvents lblAirbus350900 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnAirbus330800 As Button
    Friend WithEvents lblAirbus330800 As Label
End Class
