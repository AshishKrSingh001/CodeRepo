﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployee
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormEmployee))
        dgvEmp = New DataGridView()
        gbOperations = New GroupBox()
        btnShow = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnFilter = New Button()
        btnUpdate = New Button()
        btnInsert = New Button()
        gbSorting = New GroupBox()
        btnDes = New Button()
        btnAsc = New Button()
        gbNavigation = New GroupBox()
        btnNav3 = New Button()
        btnNav2 = New Button()
        btnNav4 = New Button()
        btnNav1 = New Button()
        GroupBox1 = New GroupBox()
        txtMobNo = New MaskedTextBox()
        Label6 = New Label()
        txtEmpNo = New MaskedTextBox()
        dtpDate = New DateTimePicker()
        cmbDeptName = New ComboBox()
        txtSalary = New TextBox()
        txtEmpName = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvEmp, ComponentModel.ISupportInitialize).BeginInit()
        gbOperations.SuspendLayout()
        gbSorting.SuspendLayout()
        gbNavigation.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvEmp
        ' 
        dgvEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmp.Location = New Point(462, 29)
        dgvEmp.Margin = New Padding(2)
        dgvEmp.Name = "dgvEmp"
        dgvEmp.RowHeadersWidth = 51
        dgvEmp.RowTemplate.Height = 29
        dgvEmp.Size = New Size(1002, 556)
        dgvEmp.TabIndex = 5
        ' 
        ' gbOperations
        ' 
        gbOperations.Controls.Add(btnShow)
        gbOperations.Controls.Add(btnClear)
        gbOperations.Controls.Add(btnDelete)
        gbOperations.Controls.Add(btnFilter)
        gbOperations.Controls.Add(btnUpdate)
        gbOperations.Controls.Add(btnInsert)
        gbOperations.Location = New Point(13, 263)
        gbOperations.Margin = New Padding(2)
        gbOperations.Name = "gbOperations"
        gbOperations.Padding = New Padding(2)
        gbOperations.Size = New Size(435, 156)
        gbOperations.TabIndex = 14
        gbOperations.TabStop = False
        gbOperations.Text = "Operations"
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(272, 41)
        btnShow.Margin = New Padding(2)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(106, 36)
        btnShow.TabIndex = 5
        btnShow.Text = "Reset"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(272, 89)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 36)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(52, 89)
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(106, 36)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnFilter
        ' 
        btnFilter.Location = New Point(162, 89)
        btnFilter.Margin = New Padding(2)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(106, 36)
        btnFilter.TabIndex = 2
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(162, 41)
        btnUpdate.Margin = New Padding(2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(106, 36)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(52, 41)
        btnInsert.Margin = New Padding(2)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(106, 36)
        btnInsert.TabIndex = 0
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' gbSorting
        ' 
        gbSorting.Controls.Add(btnDes)
        gbSorting.Controls.Add(btnAsc)
        gbSorting.Location = New Point(13, 423)
        gbSorting.Margin = New Padding(2)
        gbSorting.Name = "gbSorting"
        gbSorting.Padding = New Padding(2)
        gbSorting.Size = New Size(434, 74)
        gbSorting.TabIndex = 16
        gbSorting.TabStop = False
        gbSorting.Text = "Sorting"
        ' 
        ' btnDes
        ' 
        btnDes.Location = New Point(250, 27)
        btnDes.Margin = New Padding(2)
        btnDes.Name = "btnDes"
        btnDes.Size = New Size(131, 36)
        btnDes.TabIndex = 3
        btnDes.Text = "Decending"
        btnDes.UseVisualStyleBackColor = True
        ' 
        ' btnAsc
        ' 
        btnAsc.Location = New Point(70, 27)
        btnAsc.Margin = New Padding(2)
        btnAsc.Name = "btnAsc"
        btnAsc.Size = New Size(131, 36)
        btnAsc.TabIndex = 1
        btnAsc.Text = "Ascending"
        btnAsc.UseVisualStyleBackColor = True
        ' 
        ' gbNavigation
        ' 
        gbNavigation.Controls.Add(btnNav3)
        gbNavigation.Controls.Add(btnNav2)
        gbNavigation.Controls.Add(btnNav4)
        gbNavigation.Controls.Add(btnNav1)
        gbNavigation.Location = New Point(11, 501)
        gbNavigation.Margin = New Padding(2)
        gbNavigation.Name = "gbNavigation"
        gbNavigation.Padding = New Padding(2)
        gbNavigation.Size = New Size(436, 84)
        gbNavigation.TabIndex = 17
        gbNavigation.TabStop = False
        gbNavigation.Text = "Navigation"
        ' 
        ' btnNav3
        ' 
        btnNav3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav3.Location = New Point(15, 36)
        btnNav3.Margin = New Padding(2)
        btnNav3.Name = "btnNav3"
        btnNav3.Size = New Size(100, 36)
        btnNav3.TabIndex = 4
        btnNav3.Text = "First"
        btnNav3.UseVisualStyleBackColor = True
        ' 
        ' btnNav2
        ' 
        btnNav2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav2.Location = New Point(223, 36)
        btnNav2.Margin = New Padding(2)
        btnNav2.Name = "btnNav2"
        btnNav2.Size = New Size(100, 36)
        btnNav2.TabIndex = 3
        btnNav2.Text = "Next"
        btnNav2.UseVisualStyleBackColor = True
        ' 
        ' btnNav4
        ' 
        btnNav4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav4.Location = New Point(327, 36)
        btnNav4.Margin = New Padding(2)
        btnNav4.Name = "btnNav4"
        btnNav4.Size = New Size(100, 36)
        btnNav4.TabIndex = 2
        btnNav4.Text = "Last"
        btnNav4.UseVisualStyleBackColor = True
        ' 
        ' btnNav1
        ' 
        btnNav1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav1.Location = New Point(119, 36)
        btnNav1.Margin = New Padding(2)
        btnNav1.Name = "btnNav1"
        btnNav1.Size = New Size(100, 36)
        btnNav1.TabIndex = 1
        btnNav1.Text = "Prev"
        btnNav1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtMobNo)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtEmpNo)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Controls.Add(cmbDeptName)
        GroupBox1.Controls.Add(txtSalary)
        GroupBox1.Controls.Add(txtEmpName)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(14, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(434, 229)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "Form"
        ' 
        ' txtMobNo
        ' 
        txtMobNo.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals
        txtMobNo.Location = New Point(162, 185)
        txtMobNo.Mask = "0000000000"
        txtMobNo.Name = "txtMobNo"
        txtMobNo.PromptChar = "#"c
        txtMobNo.Size = New Size(245, 27)
        txtMobNo.TabIndex = 30
        txtMobNo.ValidatingType = GetType(Integer)
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 188)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 20)
        Label6.TabIndex = 29
        Label6.Text = "Mobile No :"
        ' 
        ' txtEmpNo
        ' 
        txtEmpNo.Location = New Point(162, 27)
        txtEmpNo.Mask = "00000"
        txtEmpNo.Name = "txtEmpNo"
        txtEmpNo.PromptChar = "#"c
        txtEmpNo.Size = New Size(245, 27)
        txtEmpNo.TabIndex = 28
        txtEmpNo.ValidatingType = GetType(Integer)
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(162, 150)
        dtpDate.Margin = New Padding(2)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(245, 27)
        dtpDate.TabIndex = 27
        ' 
        ' cmbDeptName
        ' 
        cmbDeptName.FormattingEnabled = True
        cmbDeptName.Location = New Point(162, 118)
        cmbDeptName.Margin = New Padding(2)
        cmbDeptName.Name = "cmbDeptName"
        cmbDeptName.Size = New Size(245, 28)
        cmbDeptName.TabIndex = 26
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(162, 87)
        txtSalary.Margin = New Padding(2)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(245, 27)
        txtSalary.TabIndex = 25
        ' 
        ' txtEmpName
        ' 
        txtEmpName.Location = New Point(162, 58)
        txtEmpName.Margin = New Padding(2)
        txtEmpName.Name = "txtEmpName"
        txtEmpName.Size = New Size(245, 27)
        txtEmpName.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 155)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 20)
        Label5.TabIndex = 23
        Label5.Text = "Date of Joining : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 121)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 20)
        Label4.TabIndex = 22
        Label4.Text = "Department Name : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 61)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 20)
        Label3.TabIndex = 21
        Label3.Text = "Employee Name : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 90)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 20
        Label2.Text = "Salary : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 30)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 20)
        Label1.TabIndex = 19
        Label1.Text = "Employee No : "
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormEmployee
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1467, 596)
        Controls.Add(GroupBox1)
        Controls.Add(gbNavigation)
        Controls.Add(gbSorting)
        Controls.Add(gbOperations)
        Controls.Add(dgvEmp)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormEmployee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Information"
        CType(dgvEmp, ComponentModel.ISupportInitialize).EndInit()
        gbOperations.ResumeLayout(False)
        gbSorting.ResumeLayout(False)
        gbNavigation.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents gbOperations As GroupBox
    Friend WithEvents btnShow As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents gbSorting As GroupBox
    Friend WithEvents btnDes As Button
    Friend WithEvents btnAsc As Button
    Friend WithEvents gbNavigation As GroupBox
    Friend WithEvents btnNav3 As Button
    Friend WithEvents btnNav2 As Button
    Friend WithEvents btnNav4 As Button
    Friend WithEvents btnNav1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMobNo As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmpNo As MaskedTextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cmbDeptName As ComboBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class