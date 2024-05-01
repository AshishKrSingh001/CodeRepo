<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a04_rptTotalEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a04_rptTotalEmp))
        DataGridView1 = New DataGridView()
        lblCount = New Label()
        btnExportToExcel = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Cursor = Cursors.Hand
        DataGridView1.Location = New Point(10, 36)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1249, 418)
        DataGridView1.TabIndex = 0
        ' 
        ' lblCount
        ' 
        lblCount.Dock = DockStyle.Top
        lblCount.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblCount.Location = New Point(0, 0)
        lblCount.Margin = New Padding(2, 0, 2, 0)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(1267, 34)
        lblCount.TabIndex = 1
        lblCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = SystemColors.HotTrack
        btnExportToExcel.Cursor = Cursors.Hand
        btnExportToExcel.Dock = DockStyle.Bottom
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.ForeColor = SystemColors.Control
        btnExportToExcel.Location = New Point(0, 544)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(1267, 40)
        btnExportToExcel.TabIndex = 20
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' a04_rptTotalEmp
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1267, 499)
        Controls.Add(btnExportToExcel)
        Controls.Add(lblCount)
        Controls.Add(DataGridView1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a04_rptTotalEmp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Total Employee"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents btnExportToExcel As Button
End Class
