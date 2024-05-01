<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a21_ViewPayroll
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a21_ViewPayroll))
        btnExportToExcel = New Button()
        Label1 = New Label()
        dgvEmployees = New DataGridView()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = SystemColors.HotTrack
        btnExportToExcel.Cursor = Cursors.Hand
        btnExportToExcel.Dock = DockStyle.Bottom
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.ForeColor = SystemColors.Control
        btnExportToExcel.Location = New Point(0, 614)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(1924, 40)
        btnExportToExcel.TabIndex = 46
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.IndianRed
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1924, 63)
        Label1.TabIndex = 47
        Label1.Text = "Payroll Of Employees"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvEmployees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Cursor = Cursors.Hand
        dgvEmployees.Location = New Point(0, 65)
        dgvEmployees.Margin = New Padding(2)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.RowHeadersWidth = 51
        dgvEmployees.Size = New Size(1924, 544)
        dgvEmployees.TabIndex = 45
        ' 
        ' a21_ViewPayroll
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 654)
        Controls.Add(btnExportToExcel)
        Controls.Add(Label1)
        Controls.Add(dgvEmployees)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a21_ViewPayroll"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll"
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnExportToExcel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEmployees As DataGridView
End Class
