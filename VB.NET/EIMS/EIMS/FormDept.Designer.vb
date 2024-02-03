<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDept
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormDept))
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
        btnNav3 = New Button()
        btnNav2 = New Button()
        btnNav4 = New Button()
        btnNav1 = New Button()
        gbSorting = New GroupBox()
        btnDes = New Button()
        btnAsc = New Button()
        DataGridView1 = New DataGridView()
        txtDeptNo = New MaskedTextBox()
        GroupBox1 = New GroupBox()
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
        Label1.TabIndex = 0
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
        Label9.TabIndex = 8
        Label9.Text = "Department Name : "
        ' 
        ' Label10
        ' 
        Label10.Location = New Point(56, 101)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(94, 24)
        Label10.TabIndex = 9
        Label10.Text = "Location : "
        ' 
        ' txtDeptName
        ' 
        txtDeptName.Location = New Point(213, 58)
        txtDeptName.Margin = New Padding(2)
        txtDeptName.Name = "txtDeptName"
        txtDeptName.Size = New Size(219, 27)
        txtDeptName.TabIndex = 11
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(213, 98)
        txtLocation.Margin = New Padding(2)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(219, 27)
        txtLocation.TabIndex = 12
        ' 
        ' gbOperations
        ' 
        gbOperations.Controls.Add(btnShow)
        gbOperations.Controls.Add(btnClear)
        gbOperations.Controls.Add(btnDelete)
        gbOperations.Controls.Add(btnFilter)
        gbOperations.Controls.Add(btnUpdate)
        gbOperations.Controls.Add(btnInsert)
        gbOperations.Location = New Point(12, 156)
        gbOperations.Margin = New Padding(2)
        gbOperations.Name = "gbOperations"
        gbOperations.Padding = New Padding(2)
        gbOperations.Size = New Size(461, 143)
        gbOperations.TabIndex = 13
        gbOperations.TabStop = False
        gbOperations.Text = "Operations"
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(323, 39)
        btnShow.Margin = New Padding(2)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(106, 36)
        btnShow.TabIndex = 5
        btnShow.Text = "Reset"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(213, 79)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 36)
        btnClear.TabIndex = 4
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(323, 79)
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(106, 36)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnFilter
        ' 
        btnFilter.Location = New Point(103, 79)
        btnFilter.Margin = New Padding(2)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(106, 36)
        btnFilter.TabIndex = 2
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(213, 39)
        btnUpdate.Margin = New Padding(2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(106, 36)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(103, 39)
        btnInsert.Margin = New Padding(2)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(106, 36)
        btnInsert.TabIndex = 0
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' gbNavigation
        ' 
        gbNavigation.Controls.Add(btnNav4)
        gbNavigation.Controls.Add(btnNav3)
        gbNavigation.Controls.Add(btnNav2)
        gbNavigation.Controls.Add(btnNav1)
        gbNavigation.Location = New Point(499, 316)
        gbNavigation.Margin = New Padding(2)
        gbNavigation.Name = "gbNavigation"
        gbNavigation.Padding = New Padding(2)
        gbNavigation.Size = New Size(560, 78)
        gbNavigation.TabIndex = 14
        gbNavigation.TabStop = False
        gbNavigation.Text = "Navigation"
        ' 
        ' btnNav3
        ' 
        btnNav3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav3.Location = New Point(20, 31)
        btnNav3.Margin = New Padding(2)
        btnNav3.Name = "btnNav3"
        btnNav3.Size = New Size(131, 36)
        btnNav3.TabIndex = 4
        btnNav3.Text = "First"
        btnNav3.UseVisualStyleBackColor = True
        ' 
        ' btnNav2
        ' 
        btnNav2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav2.Location = New Point(290, 31)
        btnNav2.Margin = New Padding(2)
        btnNav2.Name = "btnNav2"
        btnNav2.Size = New Size(131, 36)
        btnNav2.TabIndex = 3
        btnNav2.Text = "Next"
        btnNav2.UseVisualStyleBackColor = True
        ' 
        ' btnNav4
        ' 
        btnNav4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav4.Location = New Point(425, 31)
        btnNav4.Margin = New Padding(2)
        btnNav4.Name = "btnNav4"
        btnNav4.Size = New Size(131, 36)
        btnNav4.TabIndex = 2
        btnNav4.Text = "Last"
        btnNav4.UseVisualStyleBackColor = True
        ' 
        ' btnNav1
        ' 
        btnNav1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNav1.Location = New Point(155, 31)
        btnNav1.Margin = New Padding(2)
        btnNav1.Name = "btnNav1"
        btnNav1.Size = New Size(131, 36)
        btnNav1.TabIndex = 1
        btnNav1.Text = "Prev"
        btnNav1.UseVisualStyleBackColor = True
        ' 
        ' gbSorting
        ' 
        gbSorting.Controls.Add(btnDes)
        gbSorting.Controls.Add(btnAsc)
        gbSorting.Location = New Point(12, 316)
        gbSorting.Margin = New Padding(2)
        gbSorting.Name = "gbSorting"
        gbSorting.Padding = New Padding(2)
        gbSorting.Size = New Size(461, 74)
        gbSorting.TabIndex = 15
        gbSorting.TabStop = False
        gbSorting.Text = "Sorting"
        ' 
        ' btnDes
        ' 
        btnDes.Location = New Point(298, 24)
        btnDes.Margin = New Padding(2)
        btnDes.Name = "btnDes"
        btnDes.Size = New Size(131, 36)
        btnDes.TabIndex = 3
        btnDes.Text = "Decending"
        btnDes.UseVisualStyleBackColor = True
        ' 
        ' btnAsc
        ' 
        btnAsc.Location = New Point(136, 24)
        btnAsc.Margin = New Padding(2)
        btnAsc.Name = "btnAsc"
        btnAsc.Size = New Size(131, 36)
        btnAsc.TabIndex = 1
        btnAsc.Text = "Ascending"
        btnAsc.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(499, 16)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(560, 296)
        DataGridView1.TabIndex = 15
        ' 
        ' txtDeptNo
        ' 
        txtDeptNo.Location = New Point(213, 20)
        txtDeptNo.Mask = "000"
        txtDeptNo.Name = "txtDeptNo"
        txtDeptNo.PromptChar = "#"c
        txtDeptNo.Size = New Size(219, 27)
        txtDeptNo.TabIndex = 16
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
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(461, 139)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Form"
        ' 
        ' FormDept
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1071, 399)
        Controls.Add(GroupBox1)
        Controls.Add(gbSorting)
        Controls.Add(DataGridView1)
        Controls.Add(gbNavigation)
        Controls.Add(gbOperations)
        Controls.Add(Label8)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormDept"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Department Information"
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
End Class
