<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a09_rptEmpSelectedDptSalaryLessThanValue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a09_rptEmpSelectedDptSalaryLessThanValue))
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        btnExportToExcel = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Bottom
        Label2.Location = New Point(0, 529)
        Label2.Name = "Label2"
        Label2.Size = New Size(1090, 29)
        Label2.TabIndex = 9
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Cursor = Cursors.Hand
        DataGridView1.Location = New Point(9, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1069, 442)
        DataGridView1.TabIndex = 22
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(9, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1069, 64)
        GroupBox1.TabIndex = 23
        GroupBox1.TabStop = False
        GroupBox1.Text = "Form"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(624, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(237, 27)
        TextBox1.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(552, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 20
        Label3.Text = " Salary :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(922, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 32)
        Button1.TabIndex = 19
        Button1.Text = "Select"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(255, 22)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(246, 28)
        ComboBox1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 20)
        Label1.TabIndex = 17
        Label1.Text = "Select Department Name :"
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = SystemColors.HotTrack
        btnExportToExcel.Cursor = Cursors.Hand
        btnExportToExcel.Dock = DockStyle.Bottom
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.ForeColor = SystemColors.Control
        btnExportToExcel.Location = New Point(0, 489)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(1090, 40)
        btnExportToExcel.TabIndex = 24
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' a09_rptEmpSelectedDptSalaryLessThanValue
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1090, 558)
        Controls.Add(btnExportToExcel)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a09_rptEmpSelectedDptSalaryLessThanValue"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Accourding to the Selected Department And Less Salary"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnExportToExcel As Button
End Class
