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
        cmbPlanes = New ComboBox()
        ptbImages = New PictureBox()
        Panel1 = New Panel()
        CType(ptbImages, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbPlanes
        ' 
        cmbPlanes.FormattingEnabled = True
        cmbPlanes.Items.AddRange(New Object() {"Airbus A320", "Airbus A321", "Airbus A330-300", "Airbus A350-900", "Airbus A380-800", "Boeing 737-800", "Boeing 737 MAX 8", "Boeing 777-300ER", "Boeing 787-9", "Boeing 747-8"})
        cmbPlanes.Location = New Point(294, 33)
        cmbPlanes.Name = "cmbPlanes"
        cmbPlanes.Size = New Size(182, 33)
        cmbPlanes.TabIndex = 0
        ' 
        ' ptbImages
        ' 
        ptbImages.Location = New Point(194, 180)
        ptbImages.Name = "ptbImages"
        ptbImages.Size = New Size(705, 2028)
        ptbImages.SizeMode = PictureBoxSizeMode.AutoSize
        ptbImages.TabIndex = 1
        ptbImages.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(cmbPlanes)
        Panel1.Controls.Add(ptbImages)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 1108)
        Panel1.TabIndex = 2
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 1108)
        Controls.Add(Panel1)
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
