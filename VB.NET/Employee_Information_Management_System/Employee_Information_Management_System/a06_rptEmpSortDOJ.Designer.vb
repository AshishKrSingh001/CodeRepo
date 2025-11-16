<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a06_rptEmpSortDOJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a06_rptEmpSortDOJ))
        DataGridView1 = New DataGridView()
        lblCount = New Label()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Cursor = Cursors.Hand
        DataGridView1.Location = New Point(0, 37)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1864, 547)
        DataGridView1.TabIndex = 1
        ' 
        ' lblCount
        ' 
        lblCount.Dock = DockStyle.Top
        lblCount.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblCount.Location = New Point(0, 0)
        lblCount.Margin = New Padding(2, 0, 2, 0)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(1876, 34)
        lblCount.TabIndex = 21
        lblCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Bottom
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(0, 590)
        Button1.Name = "Button1"
        Button1.Size = New Size(1876, 40)
        Button1.TabIndex = 22
        Button1.Text = "Export To Excel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' a06_rptEmpSortDOJ
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1876, 630)
        Controls.Add(Button1)
        Controls.Add(lblCount)
        Controls.Add(DataGridView1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a06_rptEmpSortDOJ"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Sorted By Date of Join"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents Button1 As Button
End Class
