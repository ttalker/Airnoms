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
        cmbPlanes = New ComboBox()
        ptbImages = New PictureBox()
        Panel1 = New Panel()
        CType(ptbImages, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbPlanes
        ' 
        cmbPlanes.BackColor = Color.White
        cmbPlanes.FormattingEnabled = True
        cmbPlanes.Items.AddRange(New Object() {"Airbus A320", "Airbus A321", "Airbus A330-300", "Airbus A350-900", "Airbus A380-800", "Boeing 737-800", "Boeing 737 MAX 8", "Boeing 777-300ER", "Boeing 787-9", "Boeing 747-8"})
        cmbPlanes.Location = New Point(12, 122)
        cmbPlanes.Name = "cmbPlanes"
        cmbPlanes.Size = New Size(182, 33)
        cmbPlanes.TabIndex = 0
        ' 
        ' ptbImages
        ' 
        ptbImages.BackColor = Color.Transparent
        ptbImages.Location = New Point(142, 25)
        ptbImages.Name = "ptbImages"
        ptbImages.Size = New Size(400, 600)
        ptbImages.SizeMode = PictureBoxSizeMode.AutoSize
        ptbImages.TabIndex = 1
        ptbImages.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(ptbImages)
        Panel1.Location = New Point(478, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(576, 801)
        Panel1.TabIndex = 2
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1075, 828)
        Controls.Add(Panel1)
        Controls.Add(cmbPlanes)
        Name = "Form3"
        Text = "Form3"
        CType(ptbImages, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbPlanes As ComboBox
    Friend WithEvents ptbImages As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
