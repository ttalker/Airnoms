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
        btnBoeing7478 = New Button()
        lblBoeing7478 = New Label()
        btnBoeing737MAX = New Button()
        pnlBg = New Panel()
        pnlButtons = New Panel()
        btnBoeing7879 = New Button()
        lblBoeing7879 = New Label()
        btnBoeing77300er = New Button()
        lblBoeing777300er = New Label()
        lblBoeing737MAX = New Label()
        btnBoeing737800 = New Button()
        lblBoeing737800 = New Label()
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

        ' cmbPlanes
        ' 
        cmbPlanes.FormattingEnabled = True
        cmbPlanes.Items.AddRange(New Object() {"Airbus A320", "Airbus A321", "Airbus A330-300", "Airbus A350-900", "Airbus A380-800", "Boeing 737-800", "Boeing 737 MAX 8", "Boeing 777-300ER", "Boeing 787-9", "Boeing 747-8"})
        cmbPlanes.Location = New Point(235, 26)
        cmbPlanes.Margin = New Padding(2, 2, 2, 2)
        cmbPlanes.Name = "cmbPlanes"
        cmbPlanes.Size = New Size(146, 28)
        cmbPlanes.TabIndex = 0
        ' 
        ' ptbImages
        ' 
        ptbImages.Location = New Point(155, 144)
        ptbImages.Margin = New Padding(2, 2, 2, 2)
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
        pnlPlane.Controls.Add(ptbImages)
        pnlPlane.Location = New Point(446, 23)
        pnlPlane.Name = "pnlPlane"
        pnlPlane.Size = New Size(692, 917)
        pnlPlane.TabIndex = 2
        ' 
        ' btnBoeing7478
        ' 
        btnBoeing7478.BackColor = Color.Transparent
        btnBoeing7478.Location = New Point(16, 808)
        btnBoeing7478.Name = "btnBoeing7478"
        btnBoeing7478.Size = New Size(381, 79)
        btnBoeing7478.TabIndex = 12
        btnBoeing7478.UseVisualStyleBackColor = False
        ' 
        ' lblBoeing7478
        ' 
        lblBoeing7478.Image = My.Resources.Resources.Boeing747_8pics
        lblBoeing7478.Location = New Point(37, 805)
        lblBoeing7478.Name = "lblBoeing7478"
        lblBoeing7478.Size = New Size(328, 92)
        lblBoeing7478.TabIndex = 11
        lblBoeing7478.Visible = False
        ' 
        ' btnBoeing737MAX
        ' 
        btnBoeing737MAX.BackColor = Color.Transparent
        btnBoeing737MAX.Location = New Point(16, 543)
        btnBoeing737MAX.Name = "btnBoeing737MAX"
        btnBoeing737MAX.Size = New Size(381, 79)
        btnBoeing737MAX.TabIndex = 10
        btnBoeing737MAX.UseVisualStyleBackColor = False
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
        pnlButtons.Controls.Add(btnBoeing7478)
        pnlButtons.Controls.Add(btnBoeing7879)
        pnlButtons.Controls.Add(lblBoeing7478)
        pnlButtons.Controls.Add(lblBoeing7879)
        pnlButtons.Controls.Add(btnBoeing77300er)
        pnlButtons.Controls.Add(lblBoeing777300er)
        pnlButtons.Controls.Add(btnBoeing737MAX)
        pnlButtons.Controls.Add(lblBoeing737MAX)
        pnlButtons.Controls.Add(btnBoeing737800)
        pnlButtons.Controls.Add(lblBoeing737800)
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
        ' btnBoeing7879
        ' 
        btnBoeing7879.BackColor = Color.Transparent
        btnBoeing7879.Location = New Point(16, 716)
        btnBoeing7879.Name = "btnBoeing7879"
        btnBoeing7879.Size = New Size(381, 79)
        btnBoeing7879.TabIndex = 13
        btnBoeing7879.UseVisualStyleBackColor = False
        ' 
        ' lblBoeing7879
        ' 
        lblBoeing7879.Image = My.Resources.Resources.Boeing787_9pics
        lblBoeing7879.Location = New Point(37, 713)
        lblBoeing7879.Name = "lblBoeing7879"
        lblBoeing7879.Size = New Size(328, 92)
        lblBoeing7879.TabIndex = 13
        lblBoeing7879.Visible = False
        ' 
        ' btnBoeing77300er
        ' 
        btnBoeing77300er.BackColor = Color.Transparent
        btnBoeing77300er.Location = New Point(12, 631)
        btnBoeing77300er.Name = "btnBoeing77300er"
        btnBoeing77300er.Size = New Size(381, 79)
        btnBoeing77300er.TabIndex = 13
        btnBoeing77300er.UseVisualStyleBackColor = False
        ' 
        ' lblBoeing777300er
        ' 
        lblBoeing777300er.Image = My.Resources.Resources.Boeing777_300ERpics
        lblBoeing777300er.Location = New Point(37, 631)
        lblBoeing777300er.Name = "lblBoeing777300er"
        lblBoeing777300er.Size = New Size(328, 92)
        lblBoeing777300er.TabIndex = 13
        lblBoeing777300er.Visible = False
        ' 
        ' lblBoeing737MAX
        ' 
        lblBoeing737MAX.Image = My.Resources.Resources.Boeing737Maxpics
        lblBoeing737MAX.Location = New Point(37, 539)
        lblBoeing737MAX.Name = "lblBoeing737MAX"
        lblBoeing737MAX.Size = New Size(328, 92)
        lblBoeing737MAX.TabIndex = 12
        lblBoeing737MAX.Visible = False
        ' 
        ' btnBoeing737800
        ' 

        btnBoeing737800.BackColor = Color.Transparent
        btnBoeing737800.Location = New Point(16, 463)
        btnBoeing737800.Name = "btnBoeing737800"
        btnBoeing737800.Size = New Size(381, 79)
        btnBoeing737800.TabIndex = 11
        btnBoeing737800.UseVisualStyleBackColor = False
        ' 
        ' lblBoeing737800
        ' 
        lblBoeing737800.Image = My.Resources.Resources.Boeing737_800pics
        lblBoeing737800.Location = New Point(37, 460)
        lblBoeing737800.Name = "lblBoeing737800"
        lblBoeing737800.Size = New Size(328, 92)
        lblBoeing737800.TabIndex = 11
        lblBoeing737800.Visible = False
        ' 
        ' btnAirbus330800
        ' 
        btnAirbus330800.BackColor = Color.Transparent
        btnAirbus330800.Location = New Point(12, 373)
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

        Panel1.AutoScroll = True
        Panel1.Controls.Add(cmbPlanes)
        Panel1.Controls.Add(ptbImages)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(639, 844)
        Panel1.TabIndex = 2

        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font

        ClientSize = New Size(1156, 953)
        Controls.Add(pnlBg)

        ClientSize = New Size(639, 844)
        Controls.Add(Panel1)
        Margin = New Padding(2, 2, 2, 2)

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
    Friend WithEvents lblAirbus330300 As Label
    Friend WithEvents btnBoeing7478 As Button
    Friend WithEvents btnAirbus330300 As Button
    Friend WithEvents btnAirbus350900 As Button
    Friend WithEvents lblAirbus350900 As Label
    Friend WithEvents btnBoeing737MAX As Button
    Friend WithEvents btnAirbus330800 As Button
    Friend WithEvents lblAirbus330800 As Label
    Friend WithEvents btnBoeing737800 As Button
    Friend WithEvents lblBoeing737800 As Label
    Friend WithEvents lblBoeing7478 As Label
    Friend WithEvents lblBoeing737MAX As Label
    Friend WithEvents btnBoeing77300er As Button
    Friend WithEvents lblBoeing777300er As Label
    Friend WithEvents btnBoeing7879 As Button
    Friend WithEvents lblBoeing7879 As Label
End Class
