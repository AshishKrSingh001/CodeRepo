<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a08_EmpAccordingDptSelected
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a08_EmpAccordingDptSelected))
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        btnExportToExcel = New Button()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Cursor = Cursors.Hand
        DataGridView1.Location = New Point(10, 83)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1627, 398)
        DataGridView1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Bottom
        Label2.Location = New Point(0, 528)
        Label2.Name = "Label2"
        Label2.Size = New Size(1649, 25)
        Label2.TabIndex = 5
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = SystemColors.HotTrack
        btnExportToExcel.Cursor = Cursors.Hand
        btnExportToExcel.Dock = DockStyle.Bottom
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.ForeColor = SystemColors.Control
        btnExportToExcel.Location = New Point(0, 488)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(1649, 40)
        btnExportToExcel.TabIndex = 20
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(1029, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Select"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(763, 36)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(246, 28)
        ComboBox1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(547, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 20)
        Label1.TabIndex = 2
        Label1.Text = "Select Department Name :"
        ' 
        ' a08_EmpAccordingDptSelected
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1649, 553)
        Controls.Add(btnExportToExcel)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a08_EmpAccordingDptSelected"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Accourding to the Department User Selected"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExportToExcel As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
