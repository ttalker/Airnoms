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
        Panel3 = New Panel()
        CType(ptbImages, ComponentModel.ISupportInitialize).BeginInit()
        pnlPlane.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ptbImages
        ' 
        ptbImages.BackColor = Color.Transparent
        ptbImages.BackgroundImageLayout = ImageLayout.None
        ptbImages.Location = New Point(142, 25)
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
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1142, 952)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.Location = New Point(12, 23)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(411, 917)
        Panel3.TabIndex = 0
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
        ResumeLayout(False)
    End Sub
    Friend WithEvents ptbImages As PictureBox
    Friend WithEvents pnlPlane As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
