<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User04_ViewPayroll
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User04_ViewPayroll))
        GroupBox1 = New GroupBox()
        PictureBox3 = New PictureBox()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnExport_to_Excel = New Button()
        dgvEmp = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEmp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox3)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1661, 288)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Employee Details"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.EmpImage2
        PictureBox3.Location = New Point(751, 26)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 105)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 27
        PictureBox3.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label8.ForeColor = SystemColors.HotTrack
        Label8.Location = New Point(704, 140)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 28)
        Label8.TabIndex = 26
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.logo
        PictureBox2.Location = New Point(1188, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(461, 262)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.bImage1
        PictureBox1.Location = New Point(12, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(475, 257)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label7.ForeColor = SystemColors.HotTrack
        Label7.Location = New Point(699, 238)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 28)
        Label7.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label6.ForeColor = SystemColors.HotTrack
        Label6.Location = New Point(699, 205)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 28)
        Label6.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(699, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 28)
        Label5.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(536, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 20)
        Label4.TabIndex = 20
        Label4.Text = "Department Name : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(536, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 20)
        Label3.TabIndex = 19
        Label3.Text = "Employee's No : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(536, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 20)
        Label2.TabIndex = 18
        Label2.Text = "Employee's Name : "
        ' 
        ' btnExport_to_Excel
        ' 
        btnExport_to_Excel.BackColor = SystemColors.HotTrack
        btnExport_to_Excel.Cursor = Cursors.Hand
        btnExport_to_Excel.Dock = DockStyle.Bottom
        btnExport_to_Excel.FlatStyle = FlatStyle.Flat
        btnExport_to_Excel.ForeColor = SystemColors.Control
        btnExport_to_Excel.Location = New Point(0, 599)
        btnExport_to_Excel.Name = "btnExport_to_Excel"
        btnExport_to_Excel.Size = New Size(1661, 40)
        btnExport_to_Excel.TabIndex = 0
        btnExport_to_Excel.Text = "Export to Excel"
        btnExport_to_Excel.UseVisualStyleBackColor = False
        ' 
        ' dgvEmp
        ' 
        dgvEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmp.Cursor = Cursors.Hand
        dgvEmp.Dock = DockStyle.Fill
        dgvEmp.Location = New Point(0, 288)
        dgvEmp.Margin = New Padding(2)
        dgvEmp.Name = "dgvEmp"
        dgvEmp.RowHeadersWidth = 51
        dgvEmp.Size = New Size(1661, 311)
        dgvEmp.TabIndex = 30
        ' 
        ' User04_ViewPayroll
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1661, 639)
        Controls.Add(dgvEmp)
        Controls.Add(btnExport_to_Excel)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "User04_ViewPayroll"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Payroll"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEmp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExport_to_Excel As Button
    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class


