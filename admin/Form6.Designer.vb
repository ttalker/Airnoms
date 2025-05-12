<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        PictureBox1 = New PictureBox()
        cbxDepartureAddFlight = New ComboBox()
        btnAddPilot = New Button()
        btnReturn = New Button()
        btnAddFlight = New Button()
        btnClear = New Button()
        cbxDestinationAddFlight = New ComboBox()
        cbxPilotAddFlight = New ComboBox()
        cbxPlaneTypeAddFlight = New ComboBox()
        tbxDepartTimeAddFlight = New TextBox()
        dtpDepartureDateAddFlight = New DateTimePicker()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(1, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(642, 505)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' cbxDepartureAddFlight
        ' 
        cbxDepartureAddFlight.Font = New Font("Segoe UI", 10F)
        cbxDepartureAddFlight.FormattingEnabled = True
        cbxDepartureAddFlight.Location = New Point(239, 118)
        cbxDepartureAddFlight.Name = "cbxDepartureAddFlight"
        cbxDepartureAddFlight.Size = New Size(171, 25)
        cbxDepartureAddFlight.TabIndex = 2
        ' 
        ' btnAddPilot
        ' 
        btnAddPilot.Location = New Point(425, 286)
        btnAddPilot.Name = "btnAddPilot"
        btnAddPilot.Size = New Size(67, 36)
        btnAddPilot.TabIndex = 6
        btnAddPilot.Text = "Button1"
        btnAddPilot.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(44, 408)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(135, 55)
        btnReturn.TabIndex = 7
        btnReturn.Text = "Button2"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnAddFlight
        ' 
        btnAddFlight.Location = New Point(428, 408)
        btnAddFlight.Name = "btnAddFlight"
        btnAddFlight.Size = New Size(165, 55)
        btnAddFlight.TabIndex = 8
        btnAddFlight.Text = "Button3"
        btnAddFlight.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(298, 408)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(121, 55)
        btnClear.TabIndex = 9
        btnClear.Text = "Button4"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' cbxDestinationAddFlight
        ' 
        cbxDestinationAddFlight.Font = New Font("Segoe UI", 10F)
        cbxDestinationAddFlight.FormattingEnabled = True
        cbxDestinationAddFlight.Location = New Point(239, 159)
        cbxDestinationAddFlight.Name = "cbxDestinationAddFlight"
        cbxDestinationAddFlight.Size = New Size(171, 25)
        cbxDestinationAddFlight.TabIndex = 10
        ' 
        ' cbxPilotAddFlight
        ' 
        cbxPilotAddFlight.Font = New Font("Segoe UI", 10F)
        cbxPilotAddFlight.FormattingEnabled = True
        cbxPilotAddFlight.Location = New Point(237, 292)
        cbxPilotAddFlight.Name = "cbxPilotAddFlight"
        cbxPilotAddFlight.Size = New Size(171, 25)
        cbxPilotAddFlight.TabIndex = 12
        ' 
        ' cbxPlaneTypeAddFlight
        ' 
        cbxPlaneTypeAddFlight.Font = New Font("Segoe UI", 10F)
        cbxPlaneTypeAddFlight.FormattingEnabled = True
        cbxPlaneTypeAddFlight.Location = New Point(237, 334)
        cbxPlaneTypeAddFlight.Name = "cbxPlaneTypeAddFlight"
        cbxPlaneTypeAddFlight.Size = New Size(171, 25)
        cbxPlaneTypeAddFlight.TabIndex = 13
        ' 
        ' tbxDepartTimeAddFlight
        ' 
        tbxDepartTimeAddFlight.Font = New Font("Segoe UI", 10F)
        tbxDepartTimeAddFlight.Location = New Point(237, 248)
        tbxDepartTimeAddFlight.Name = "tbxDepartTimeAddFlight"
        tbxDepartTimeAddFlight.Size = New Size(173, 25)
        tbxDepartTimeAddFlight.TabIndex = 14
        ' 
        ' dtpDepartureDateAddFlight
        ' 
        dtpDepartureDateAddFlight.CalendarFont = New Font("Segoe UI", 11F)
        dtpDepartureDateAddFlight.Location = New Point(237, 207)
        dtpDepartureDateAddFlight.Name = "dtpDepartureDateAddFlight"
        dtpDepartureDateAddFlight.Size = New Size(173, 23)
        dtpDepartureDateAddFlight.TabIndex = 15
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(645, 497)
        Controls.Add(dtpDepartureDateAddFlight)
        Controls.Add(tbxDepartTimeAddFlight)
        Controls.Add(cbxPlaneTypeAddFlight)
        Controls.Add(cbxPilotAddFlight)
        Controls.Add(cbxDestinationAddFlight)
        Controls.Add(btnClear)
        Controls.Add(btnAddFlight)
        Controls.Add(btnReturn)
        Controls.Add(btnAddPilot)
        Controls.Add(cbxDepartureAddFlight)
        Controls.Add(PictureBox1)
        Name = "Form6"
        Text = "Form6"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbxDepartureAddFlight As ComboBox
    Friend WithEvents btnAddPilot As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cbxDestinationAddFlight As ComboBox
    Friend WithEvents cbxPilotAddFlight As ComboBox
    Friend WithEvents cbxPlaneTypeAddFlight As ComboBox
    Friend WithEvents tbxDepartTimeAddFlight As TextBox
    Friend WithEvents dtpDepartureDateAddFlight As DateTimePicker
End Class
