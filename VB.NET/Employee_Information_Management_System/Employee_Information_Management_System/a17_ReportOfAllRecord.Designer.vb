<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a17_ReportOfAllRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a17_ReportOfAllRecord))
        dgvEmp = New DataGridView()
        btnExportToExcel = New Button()
        SaveFileDialog1 = New SaveFileDialog()
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
        dgvEmp.Size = New Size(1790, 723)
        dgvEmp.TabIndex = 18
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = SystemColors.HotTrack
        btnExportToExcel.Cursor = Cursors.Hand
        btnExportToExcel.Dock = DockStyle.Bottom
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.ForeColor = SystemColors.Control
        btnExportToExcel.Location = New Point(0, 683)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(1790, 40)
        btnExportToExcel.TabIndex = 19
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' a17_ReportOfAllRecord
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1790, 723)
        Controls.Add(btnExportToExcel)
        Controls.Add(dgvEmp)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a17_ReportOfAllRecord"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Report of All Record"
        CType(dgvEmp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents btnExportToExcel As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
