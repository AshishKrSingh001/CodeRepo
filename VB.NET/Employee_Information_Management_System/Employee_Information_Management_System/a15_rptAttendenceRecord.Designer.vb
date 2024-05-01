<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a15_rptAttendenceRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a15_rptAttendenceRecord))
        dgvEmp = New DataGridView()
        btnExportToExcel = New Button()
        CType(dgvEmp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvEmp
        ' 
        dgvEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmp.Cursor = Cursors.Hand
        dgvEmp.Dock = DockStyle.Fill
        dgvEmp.Location = New Point(0, 0)
        dgvEmp.Margin = New Padding(2)
        dgvEmp.Name = "dgvEmp"
        dgvEmp.RowHeadersWidth = 51
        dgvEmp.Size = New Size(1636, 687)
        dgvEmp.TabIndex = 17
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = SystemColors.HotTrack
        btnExportToExcel.Cursor = Cursors.Hand
        btnExportToExcel.Dock = DockStyle.Bottom
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.ForeColor = SystemColors.Control
        btnExportToExcel.Location = New Point(0, 647)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(1636, 40)
        btnExportToExcel.TabIndex = 20
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' a15_rptAttendenceRecord
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1636, 687)
        Controls.Add(btnExportToExcel)
        Controls.Add(dgvEmp)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a15_rptAttendenceRecord"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance Record"
        CType(dgvEmp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents btnExportToExcel As Button
End Class
