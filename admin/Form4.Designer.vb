<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        PictureBox1 = New PictureBox()
        btnDelayFlight = New Button()
        btnCancelFlight = New Button()
        btnReturn = New Button()
        lblFlight_Id = New Label()
        RichTextBox1 = New RichTextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.delay_flight_
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(640, 452)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnDelayFlight
        ' 
        btnDelayFlight.Location = New Point(296, 288)
        btnDelayFlight.Name = "btnDelayFlight"
        btnDelayFlight.Size = New Size(130, 41)
        btnDelayFlight.TabIndex = 1
        btnDelayFlight.Text = "Button1"
        btnDelayFlight.UseVisualStyleBackColor = True
        ' 
        ' btnCancelFlight
        ' 
        btnCancelFlight.Location = New Point(436, 288)
        btnCancelFlight.Name = "btnCancelFlight"
        btnCancelFlight.Size = New Size(130, 41)
        btnCancelFlight.TabIndex = 2
        btnCancelFlight.Text = "Button2"
        btnCancelFlight.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(464, 369)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(126, 46)
        btnReturn.TabIndex = 3
        btnReturn.Text = "Button3"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' lblFlight_Id
        ' 
        lblFlight_Id.AutoSize = True
        lblFlight_Id.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFlight_Id.Location = New Point(226, 154)
        lblFlight_Id.Name = "lblFlight_Id"
        lblFlight_Id.Size = New Size(56, 21)
        lblFlight_Id.TabIndex = 4
        lblFlight_Id.Text = "Label1"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(226, 195)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(260, 69)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 450)
        Controls.Add(RichTextBox1)
        Controls.Add(lblFlight_Id)
        Controls.Add(btnReturn)
        Controls.Add(btnCancelFlight)
        Controls.Add(btnDelayFlight)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelayFlight As Button
    Friend WithEvents btnCancelFlight As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblFlight_Id As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
