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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        btnSearch = New Button()
        btnBack = New Button()
        dgvPassengers = New DataGridView()
        CType(dgvPassengers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(226, 72)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(101, 35)
        btnSearch.TabIndex = 0
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(478, 432)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(110, 44)
        btnBack.TabIndex = 1
        btnBack.Text = "BACK"
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
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(626, 500)
        Controls.Add(dgvPassengers)
        Controls.Add(btnBack)
        Controls.Add(btnSearch)
        Name = "Form5"
        Text = "Form5"
        CType(dgvPassengers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvPassengers As DataGridView
End Class
