<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a20_payrollForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a20_PayrollForm))
        dgvEmployees = New DataGridView()
        btnExportToExcel = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        cmbMonth = New ComboBox()
        dtpPayrollDate = New DateTimePicker()
        Label5 = New Label()
        dtpStartDate = New DateTimePicker()
        txtDays = New TextBox()
        dtpEndDate = New DateTimePicker()
        Label4 = New Label()
        Label2 = New Label()
        btnGeneratePayroll = New Button()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        dgvEmployees.Location = New Point(0, 169)
        dgvEmployees.Margin = New Padding(2)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.RowHeadersWidth = 51
        dgvEmployees.Size = New Size(1781, 499)
        dgvEmployees.TabIndex = 19
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = SystemColors.HotTrack
        btnExportToExcel.Cursor = Cursors.Hand
        btnExportToExcel.Dock = DockStyle.Bottom
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.ForeColor = SystemColors.Control
        btnExportToExcel.Location = New Point(0, 673)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(1781, 40)
        btnExportToExcel.TabIndex = 26
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cmbMonth)
        Panel1.Controls.Add(dtpPayrollDate)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dtpStartDate)
        Panel1.Controls.Add(txtDays)
        Panel1.Controls.Add(dtpEndDate)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnGeneratePayroll)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1781, 164)
        Panel1.TabIndex = 28
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.IndianRed
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1781, 63)
        Label1.TabIndex = 44
        Label1.Text = "Generate Payroll Of Employees"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1387, 90)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 20)
        Label6.TabIndex = 43
        Label6.Text = "Month"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(422, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 38
        Label3.Text = "Start Date"
        ' 
        ' cmbMonth
        ' 
        cmbMonth.FormattingEnabled = True
        cmbMonth.Items.AddRange(New Object() {"January - 31 days", "February - 28/29 days", "March - 31 days", "April - 30 days", "May - 31 days", "June - 30 days", "July - 31 days", "August - 31 days", "September - 30 days", "October - 31 days", "November - 30 days", "December - 31 days"})
        cmbMonth.Location = New Point(1287, 114)
        cmbMonth.Name = "cmbMonth"
        cmbMonth.Size = New Size(281, 28)
        cmbMonth.TabIndex = 42
        ' 
        ' dtpPayrollDate
        ' 
        dtpPayrollDate.Location = New Point(12, 115)
        dtpPayrollDate.Name = "dtpPayrollDate"
        dtpPayrollDate.Size = New Size(281, 27)
        dtpPayrollDate.TabIndex = 34
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1020, 90)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 20)
        Label5.TabIndex = 41
        Label5.Text = "Total Working Days"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Location = New Point(324, 115)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(281, 27)
        dtpStartDate.TabIndex = 36
        ' 
        ' txtDays
        ' 
        txtDays.Location = New Point(972, 115)
        txtDays.Margin = New Padding(2)
        txtDays.Name = "txtDays"
        txtDays.Size = New Size(281, 27)
        txtDays.TabIndex = 39
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Location = New Point(639, 115)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(281, 27)
        dtpEndDate.TabIndex = 35
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(740, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 40
        Label4.Text = "End Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(94, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 37
        Label2.Text = "Payroll Date"
        ' 
        ' btnGeneratePayroll
        ' 
        btnGeneratePayroll.BackColor = Color.Navy
        btnGeneratePayroll.Cursor = Cursors.Hand
        btnGeneratePayroll.FlatStyle = FlatStyle.Flat
        btnGeneratePayroll.ForeColor = Color.White
        btnGeneratePayroll.Location = New Point(1600, 108)
        btnGeneratePayroll.Margin = New Padding(2)
        btnGeneratePayroll.Name = "btnGeneratePayroll"
        btnGeneratePayroll.Size = New Size(170, 39)
        btnGeneratePayroll.TabIndex = 33
        btnGeneratePayroll.Text = "Generate Payroll"
        btnGeneratePayroll.UseVisualStyleBackColor = False
        ' 
        ' a20_PayrollForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1781, 713)
        Controls.Add(Panel1)
        Controls.Add(btnExportToExcel)
        Controls.Add(dgvEmployees)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a20_PayrollForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll Details"
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents btnExportToExcel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents dtpPayrollDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents txtDays As TextBox
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGeneratePayroll As Button
    Friend WithEvents Label1 As Label

End Class
