<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancel_Delay_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cancel_Delay_Form))
        btnDelay = New Button()
        btnCancel = New Button()
        lblFlightID = New Label()
        txtReason = New TextBox()
        btnReturn = New Button()
        SuspendLayout()
        ' 
        ' btnDelay
        ' 
        btnDelay.BackColor = Color.Transparent
        btnDelay.Location = New Point(298, 289)
        btnDelay.Name = "btnDelay"
        btnDelay.Size = New Size(127, 39)
        btnDelay.TabIndex = 0
        btnDelay.Text = "DELAY"
        btnDelay.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Transparent
        btnCancel.Location = New Point(437, 287)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(128, 40)
        btnCancel.TabIndex = 1
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblFlightID
        ' 
        lblFlightID.AutoSize = True
        lblFlightID.BackColor = Color.Transparent
        lblFlightID.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFlightID.Location = New Point(215, 150)
        lblFlightID.Name = "lblFlightID"
        lblFlightID.Size = New Size(67, 25)
        lblFlightID.TabIndex = 2
        lblFlightID.Text = "Label1"
        ' 
        ' txtReason
        ' 
        txtReason.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtReason.Location = New Point(215, 193)
        txtReason.Name = "txtReason"
        txtReason.Size = New Size(210, 27)
        txtReason.TabIndex = 3
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(465, 371)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(121, 42)
        btnReturn.TabIndex = 4
        btnReturn.Text = "RETURN"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' Cancel_Delay_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(612, 450)
        Controls.Add(btnReturn)
        Controls.Add(txtReason)
        Controls.Add(lblFlightID)
        Controls.Add(btnCancel)
        Controls.Add(btnDelay)
        Name = "Cancel_Delay_Form"
        Text = "Cancel_Delay_Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDelay As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblFlightID As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents btnReturn As Button
End Class
