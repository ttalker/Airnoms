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
        Panel2 = New Panel()
        pnlButtons = New Panel()
        lblAirbus320 = New Label()
        btnAirbus320 = New Button()
        CType(ptbImages, ComponentModel.ISupportInitialize).BeginInit()
        pnlPlane.SuspendLayout()
        Panel2.SuspendLayout()
        pnlButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' ptbImages
        ' 
        ptbImages.BackColor = Color.Transparent
        ptbImages.BackgroundImageLayout = ImageLayout.None
        ptbImages.Location = New Point(193, 84)
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Controls.Add(pnlPlane)
        Panel2.Controls.Add(pnlButtons)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1142, 952)
        Panel2.TabIndex = 3
        ' 
        ' pnlButtons
        ' 
        pnlButtons.BackColor = Color.Transparent
        pnlButtons.BackgroundImage = My.Resources.Resources.buttonpics
        pnlButtons.Controls.Add(lblAirbus320)
        pnlButtons.Controls.Add(btnAirbus320)
        pnlButtons.Location = New Point(12, 23)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New Size(411, 917)
        pnlButtons.TabIndex = 0
        ' 
        ' lblAirbus320
        ' 
        lblAirbus320.Image = My.Resources.Resources.Airbus320pic
        lblAirbus320.Location = New Point(37, 34)
        lblAirbus320.Name = "lblAirbus320"
        lblAirbus320.Size = New Size(328, 92)
        lblAirbus320.TabIndex = 2
        lblAirbus320.Visible = False
        ' 
        ' btnAirbus320
        ' 
        btnAirbus320.BackColor = Color.Transparent
        btnAirbus320.Location = New Point(12, 28)
        btnAirbus320.Name = "btnAirbus320"
        btnAirbus320.Size = New Size(381, 98)
        btnAirbus320.TabIndex = 2
        btnAirbus320.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1142, 952)
        Controls.Add(Panel2)
        Name = "Form3"
        Text = "Form3"
        CType(ptbImages, ComponentModel.ISupportInitialize).EndInit()
        pnlPlane.ResumeLayout(False)
        pnlPlane.PerformLayout()
        Panel2.ResumeLayout(False)
        pnlButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents ptbImages As PictureBox
    Friend WithEvents pnlPlane As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnAirbus320 As Button
    Friend WithEvents lblAirbus320 As Label
End Class
