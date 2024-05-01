<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class a01_FormDept
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a01_FormDept))
        Label1 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtDeptName = New TextBox()
        txtLocation = New TextBox()
        gbOperations = New GroupBox()
        btnShow = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnFilter = New Button()
        btnUpdate = New Button()
        btnInsert = New Button()
        gbNavigation = New GroupBox()
        btnNav4 = New Button()
        btnNav3 = New Button()
        btnNav2 = New Button()
        btnNav1 = New Button()
        gbSorting = New GroupBox()
        btnDes = New Button()
        btnAsc = New Button()
        DataGridView1 = New DataGridView()
        txtDeptNo = New MaskedTextBox()
        GroupBox1 = New GroupBox()
        btnExportToExcel = New Button()
        Label2 = New Label()
        gbOperations.SuspendLayout()
        gbNavigation.SuspendLayout()
        gbSorting.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(56, 23)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 24)
        Label1.TabIndex = 23
        Label1.Text = "Department No : "
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(64, 90)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 0)
        Label8.TabIndex = 7
        Label8.Text = "Label8"
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(56, 61)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(160, 24)
        Label9.TabIndex = 24
        Label9.Text = "Department Name : "
        ' 
        ' Label10
        ' 
        Label10.Location = New Point(56, 101)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(94, 24)
        Label10.TabIndex = 25
        Label10.Text = "Location : "
        ' 
        ' txtDeptName
        ' 
        txtDeptName.Location = New Point(213, 58)
        txtDeptName.Margin = New Padding(2)
        txtDeptName.Name = "txtDeptName"
        txtDeptName.Size = New Size(219, 27)
        txtDeptName.TabIndex = 1
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(213, 98)
        txtLocation.Margin = New Padding(2)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(219, 27)
        txtLocation.TabIndex = 2
        ' 
        ' gbOperations
        ' 
        gbOperations.Controls.Add(btnShow)
        gbOperations.Controls.Add(btnClear)
        gbOperations.Controls.Add(btnDelete)
        gbOperations.Controls.Add(btnFilter)
        gbOperations.Controls.Add(btnUpdate)
        gbOperations.Controls.Add(btnInsert)
        gbOperations.Location = New Point(12, 202)
        gbOperations.Margin = New Padding(2)
        gbOperations.Name = "gbOperations"
        gbOperations.Padding = New Padding(2)
        gbOperations.Size = New Size(461, 143)
        gbOperations.TabIndex = 20
        gbOperations.TabStop = False
        gbOperations.Text = "Operations"
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = SystemColors.HotTrack
        btnShow.Cursor = Cursors.Hand
        btnShow.FlatStyle = FlatStyle.Flat
        btnShow.ForeColor = SystemColors.Control
        btnShow.Location = New Point(323, 39)
        btnShow.Margin = New Padding(2)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(106, 36)
        btnShow.TabIndex = 7
        btnShow.Text = "Reset"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.HotTrack
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = SystemColors.Control
        btnClear.Location = New Point(213, 79)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 36)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.HotTrack
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = SystemColors.Control
        btnDelete.Location = New Point(323, 79)
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(106, 36)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = SystemColors.HotTrack
        btnFilter.Cursor = Cursors.Hand
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.ForeColor = SystemColors.Control
        btnFilter.Location = New Point(103, 79)
        btnFilter.Margin = New Padding(2)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(106, 36)
        btnFilter.TabIndex = 8
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.HotTrack
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = SystemColors.Control
        btnUpdate.Location = New Point(213, 39)
        btnUpdate.Margin = New Padding(2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(106, 36)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnInsert
        ' 
        btnInsert.BackColor = SystemColors.HotTrack
        btnInsert.Cursor = Cursors.Hand
        btnInsert.FlatStyle = FlatStyle.Flat
        btnInsert.ForeColor = SystemColors.Control
        btnInsert.Location = New Point(103, 39)
        btnInsert.Margin = New Padding(2)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(106, 36)
        btnInsert.TabIndex = 4
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = False
        ' 
        ' gbNavigation
        ' 
        gbNavigation.Controls.Add(btnNav4)
        gbNavigation.Controls.Add(btnNav3)
        gbNavigation.Controls.Add(btnNav2)
        gbNavigation.Controls.Add(btnNav1)
        gbNavigation.Location = New Point(499, 362)
        gbNavigation.Margin = New Padding(2)
        gbNavigation.Name = "gbNavigation"
        gbNavigation.Padding = New Padding(2)
        gbNavigation.Size = New Size(560, 78)
        gbNavigation.TabIndex = 22
        gbNavigation.TabStop = False
        gbNavigation.Text = "Navigation"
        ' 
        ' btnNav4
        ' 
        btnNav4.BackColor = SystemColors.HotTrack
        btnNav4.Cursor = Cursors.Hand
        btnNav4.FlatStyle = FlatStyle.Flat
        btnNav4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNav4.ForeColor = SystemColors.Control
        btnNav4.Location = New Point(425, 31)
        btnNav4.Margin = New Padding(2)
        btnNav4.Name = "btnNav4"
        btnNav4.Size = New Size(131, 36)
        btnNav4.TabIndex = 16
        btnNav4.Text = "Last"
        btnNav4.UseVisualStyleBackColor = False
        ' 
        ' btnNav3
        ' 
        btnNav3.BackColor = SystemColors.HotTrack
        btnNav3.Cursor = Cursors.Hand
        btnNav3.FlatStyle = FlatStyle.Flat
        btnNav3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNav3.ForeColor = SystemColors.Control
        btnNav3.Location = New Point(20, 31)
        btnNav3.Margin = New Padding(2)
        btnNav3.Name = "btnNav3"
        btnNav3.Size = New Size(131, 36)
        btnNav3.TabIndex = 13
        btnNav3.Text = "First"
        btnNav3.UseVisualStyleBackColor = False
        ' 
        ' btnNav2
        ' 
        btnNav2.BackColor = SystemColors.HotTrack
        btnNav2.Cursor = Cursors.Hand
        btnNav2.FlatStyle = FlatStyle.Flat
        btnNav2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNav2.ForeColor = SystemColors.Control
        btnNav2.Location = New Point(290, 31)
        btnNav2.Margin = New Padding(2)
        btnNav2.Name = "btnNav2"
        btnNav2.Size = New Size(131, 36)
        btnNav2.TabIndex = 15
        btnNav2.Text = "Next"
        btnNav2.UseVisualStyleBackColor = False
        ' 
        ' btnNav1
        ' 
        btnNav1.BackColor = SystemColors.HotTrack
        btnNav1.Cursor = Cursors.Hand
        btnNav1.FlatStyle = FlatStyle.Flat
        btnNav1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNav1.ForeColor = SystemColors.Control
        btnNav1.Location = New Point(155, 31)
        btnNav1.Margin = New Padding(2)
        btnNav1.Name = "btnNav1"
        btnNav1.Size = New Size(131, 36)
        btnNav1.TabIndex = 14
        btnNav1.Text = "Prev"
        btnNav1.UseVisualStyleBackColor = False
        ' 
        ' gbSorting
        ' 
        gbSorting.Controls.Add(btnDes)
        gbSorting.Controls.Add(btnAsc)
        gbSorting.Location = New Point(12, 362)
        gbSorting.Margin = New Padding(2)
        gbSorting.Name = "gbSorting"
        gbSorting.Padding = New Padding(2)
        gbSorting.Size = New Size(461, 74)
        gbSorting.TabIndex = 21
        gbSorting.TabStop = False
        gbSorting.Text = "Sorting"
        ' 
        ' btnDes
        ' 
        btnDes.BackColor = SystemColors.HotTrack
        btnDes.Cursor = Cursors.Hand
        btnDes.FlatStyle = FlatStyle.Flat
        btnDes.ForeColor = SystemColors.Control
        btnDes.Location = New Point(298, 24)
        btnDes.Margin = New Padding(2)
        btnDes.Name = "btnDes"
        btnDes.Size = New Size(131, 36)
        btnDes.TabIndex = 12
        btnDes.Text = "Decending"
        btnDes.UseVisualStyleBackColor = False
        ' 
        ' btnAsc
        ' 
        btnAsc.BackColor = SystemColors.HotTrack
        btnAsc.Cursor = Cursors.Hand
        btnAsc.FlatStyle = FlatStyle.Flat
        btnAsc.ForeColor = SystemColors.Control
        btnAsc.Location = New Point(136, 24)
        btnAsc.Margin = New Padding(2)
        btnAsc.Name = "btnAsc"
        btnAsc.Size = New Size(131, 36)
        btnAsc.TabIndex = 11
        btnAsc.Text = "Ascending"
        btnAsc.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        DataGridViewCellStyle1.ForeColor = SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Cursor = Cursors.Hand
        DataGridView1.Location = New Point(499, 62)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(560, 296)
        DataGridView1.TabIndex = 18
        ' 
        ' txtDeptNo
        ' 
        txtDeptNo.Location = New Point(213, 20)
        txtDeptNo.Mask = "000"
        txtDeptNo.Name = "txtDeptNo"
        txtDeptNo.PromptChar = "#"c
        txtDeptNo.Size = New Size(219, 27)
        txtDeptNo.TabIndex = 0
        txtDeptNo.TextMaskFormat = MaskFormat.IncludePrompt
        txtDeptNo.ValidatingType = GetType(Integer)
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtDeptNo)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtDeptName)
        GroupBox1.Controls.Add(txtLocation)
        GroupBox1.Location = New Point(12, 58)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(461, 139)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "Form"
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = SystemColors.HotTrack
        btnExportToExcel.Cursor = Cursors.Hand
        btnExportToExcel.Dock = DockStyle.Bottom
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.ForeColor = SystemColors.Control
        btnExportToExcel.Location = New Point(0, 446)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(1070, 40)
        btnExportToExcel.TabIndex = 17
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.IndianRed
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(1070, 49)
        Label2.TabIndex = 45
        Label2.Text = "Department Details"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' a01_FormDept
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1070, 486)
        Controls.Add(Label2)
        Controls.Add(btnExportToExcel)
        Controls.Add(GroupBox1)
        Controls.Add(gbSorting)
        Controls.Add(DataGridView1)
        Controls.Add(gbNavigation)
        Controls.Add(gbOperations)
        Controls.Add(Label8)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a01_FormDept"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Department Form"
        gbOperations.ResumeLayout(False)
        gbNavigation.ResumeLayout(False)
        gbSorting.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDeptName As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents gbOperations As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents gbNavigation As GroupBox
    Friend WithEvents btnNav3 As Button
    Friend WithEvents btnNav2 As Button
    Friend WithEvents btnNav4 As Button
    Friend WithEvents btnNav1 As Button
    Friend WithEvents gbSorting As GroupBox
    Friend WithEvents btnDes As Button
    Friend WithEvents btnAsc As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtDeptNo As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExportToExcel As Button
    Friend WithEvents Label2 As Label
End Class