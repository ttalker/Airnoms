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
        pbxCancelFlight = New PictureBox()
        btnDelayFlight = New Button()
        btnCancelFlight = New Button()
        btnReturn = New Button()
        lblFlight_Id = New Label()
        RichTextBox1 = New RichTextBox()
        CType(pbxCancelFlight, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbxCancelFlight
        ' 
        pbxCancelFlight.BackgroundImage = My.Resources.Resources.delay_flight_
        pbxCancelFlight.Location = New Point(0, 0)
        pbxCancelFlight.Name = "pbxCancelFlight"
        pbxCancelFlight.Size = New Size(640, 452)
        pbxCancelFlight.TabIndex = 0
        pbxCancelFlight.TabStop = False
        ' 
        ' btnDelayFlight
        ' 
        btnDelayFlight.Location = New Point(296, 288)
        btnDelayFlight.Name = "btnDelayFlight"
        btnDelayFlight.Size = New Size(130, 41)
        btnDelayFlight.TabIndex = 1
        btnDelayFlight.Text = " "
        btnDelayFlight.UseVisualStyleBackColor = True
        ' 
        ' btnCancelFlight
        ' 
        btnCancelFlight.Location = New Point(436, 288)
        btnCancelFlight.Name = "btnCancelFlight"
        btnCancelFlight.Size = New Size(130, 41)
        btnCancelFlight.TabIndex = 2
        btnCancelFlight.Text = " "
        btnCancelFlight.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(464, 369)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(126, 46)
        btnReturn.TabIndex = 3
        btnReturn.Text = " "
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' lblFlight_Id
        ' 
        lblFlight_Id.AutoSize = True
        lblFlight_Id.BackColor = Color.FromArgb(CByte(233), CByte(244), CByte(251))
        lblFlight_Id.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFlight_Id.ForeColor = Color.FromArgb(CByte(11), CByte(39), CByte(66))
        lblFlight_Id.Location = New Point(224, 155)
        lblFlight_Id.Name = "lblFlight_Id"
        lblFlight_Id.Size = New Size(14, 21)
        lblFlight_Id.TabIndex = 4
        lblFlight_Id.Text = " "
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
        Controls.Add(pbxCancelFlight)
        Name = "Form4"
        Text = "FLIGHT CANCELLATION"
        CType(pbxCancelFlight, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbxCancelFlight As PictureBox
    Friend WithEvents btnDelayFlight As Button
    Friend WithEvents btnCancelFlight As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblFlight_Id As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
