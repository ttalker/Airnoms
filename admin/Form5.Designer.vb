<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        btnSearch = New Button()
        btnBack = New Button()
        dgvPassengers = New DataGridView()
        tbxSearchInput = New TextBox()
        pbxViewFlight = New PictureBox()
        CType(dgvPassengers, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxViewFlight, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(225, 72)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(101, 35)
        btnSearch.TabIndex = 0
        btnSearch.Text = " "
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(479, 431)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(110, 44)
        btnBack.TabIndex = 1
        btnBack.Text = " "
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' dgvPassengers
        ' 
        dgvPassengers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPassengers.Location = New Point(68, 131)
        dgvPassengers.Name = "dgvPassengers"
        dgvPassengers.Size = New Size(499, 263)
        dgvPassengers.TabIndex = 2
        ' 
        ' tbxSearchInput
        ' 
        tbxSearchInput.Font = New Font("Segoe UI", 11F)
        tbxSearchInput.Location = New Point(68, 77)
        tbxSearchInput.Name = "tbxSearchInput"
        tbxSearchInput.Size = New Size(152, 27)
        tbxSearchInput.TabIndex = 3
        ' 
        ' pbxViewFlight
        ' 
        pbxViewFlight.BackgroundImage = My.Resources.Resources.Admin_Panel_view_flight___2_
        pbxViewFlight.Location = New Point(1, -2)
        pbxViewFlight.Name = "pbxViewFlight"
        pbxViewFlight.Size = New Size(625, 503)
        pbxViewFlight.TabIndex = 5
        pbxViewFlight.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(626, 500)
        Controls.Add(tbxSearchInput)
        Controls.Add(dgvPassengers)
        Controls.Add(btnBack)
        Controls.Add(btnSearch)
        Controls.Add(pbxViewFlight)
        Name = "Form5"
        Text = "VIEW FLIGHT"
        CType(dgvPassengers, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxViewFlight, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvPassengers As DataGridView
    Friend WithEvents tbxSearchInput As TextBox
    Friend WithEvents pbxViewFlight As PictureBox
End Class
