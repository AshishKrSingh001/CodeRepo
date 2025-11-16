<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a02_FormEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(a02_FormEmployee))
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
        btnExportToExcel = New Button()
        GroupBox2 = New GroupBox()
        cmbBlood = New ComboBox()
        Label8 = New Label()
        GroupBox4 = New GroupBox()
        rbUnM = New RadioButton()
        rbM = New RadioButton()
        GroupBox3 = New GroupBox()
        rbo = New RadioButton()
        rbFemale = New RadioButton()
        rbMale = New RadioButton()
        dtpDob = New DateTimePicker()
        Label7 = New Label()
        txtcAdd = New TextBox()
        txtpAdd = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        GroupBox5 = New GroupBox()
        cbsame = New CheckBox()
        Label11 = New Label()
        CType(dgvEmp, ComponentModel.ISupportInitialize).BeginInit()
        gbOperations.SuspendLayout()
        gbSorting.SuspendLayout()
        gbNavigation.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvEmp
        ' 
        dgvEmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmp.Cursor = Cursors.Hand
        dgvEmp.Location = New Point(453, 57)
        dgvEmp.Margin = New Padding(2)
        dgvEmp.Name = "dgvEmp"
        dgvEmp.RowHeadersWidth = 51
        dgvEmp.Size = New Size(1361, 660)
        dgvEmp.TabIndex = 29
        ' 
        ' gbOperations
        ' 
        gbOperations.Controls.Add(btnShow)
        gbOperations.Controls.Add(btnClear)
        gbOperations.Controls.Add(btnDelete)
        gbOperations.Controls.Add(btnFilter)
        gbOperations.Controls.Add(btnUpdate)
        gbOperations.Controls.Add(btnInsert)
        gbOperations.Location = New Point(11, 721)
        gbOperations.Margin = New Padding(2)
        gbOperations.Name = "gbOperations"
        gbOperations.Padding = New Padding(2)
        gbOperations.Size = New Size(815, 74)
        gbOperations.TabIndex = 16
        gbOperations.TabStop = False
        gbOperations.Text = "Operations"
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = SystemColors.HotTrack
        btnShow.Cursor = Cursors.Hand
        btnShow.FlatStyle = FlatStyle.Flat
        btnShow.ForeColor = SystemColors.Control
        btnShow.Location = New Point(295, 31)
        btnShow.Margin = New Padding(2)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(125, 35)
        btnShow.TabIndex = 18
        btnShow.Text = "Reset"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.HotTrack
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = SystemColors.Control
        btnClear.Location = New Point(682, 31)
        btnClear.Margin = New Padding(2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(125, 35)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.HotTrack
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = SystemColors.Control
        btnDelete.Location = New Point(424, 31)
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(125, 35)
        btnDelete.TabIndex = 19
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = SystemColors.HotTrack
        btnFilter.Cursor = Cursors.Hand
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.ForeColor = SystemColors.Control
        btnFilter.Location = New Point(553, 31)
        btnFilter.Margin = New Padding(2)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(125, 35)
        btnFilter.TabIndex = 20
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.HotTrack
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = SystemColors.Control
        btnUpdate.Location = New Point(166, 31)
        btnUpdate.Margin = New Padding(2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(125, 35)
        btnUpdate.TabIndex = 17
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnInsert
        ' 
        btnInsert.BackColor = SystemColors.HotTrack
        btnInsert.Cursor = Cursors.Hand
        btnInsert.FlatStyle = FlatStyle.Flat
        btnInsert.ForeColor = SystemColors.Control
        btnInsert.Location = New Point(37, 30)
        btnInsert.Margin = New Padding(2)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(125, 35)
        btnInsert.TabIndex = 16
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = False
        ' 
        ' gbSorting
        ' 
        gbSorting.Controls.Add(btnDes)
        gbSorting.Controls.Add(btnAsc)
        gbSorting.Location = New Point(1421, 722)
        gbSorting.Margin = New Padding(2)
        gbSorting.Name = "gbSorting"
        gbSorting.Padding = New Padding(2)
        gbSorting.Size = New Size(393, 74)
        gbSorting.TabIndex = 26
        gbSorting.TabStop = False
        gbSorting.Text = "Sorting"
        ' 
        ' btnDes
        ' 
        btnDes.BackColor = SystemColors.HotTrack
        btnDes.Cursor = Cursors.Hand
        btnDes.FlatStyle = FlatStyle.Flat
        btnDes.ForeColor = SystemColors.Control
        btnDes.Location = New Point(247, 29)
        btnDes.Margin = New Padding(2)
        btnDes.Name = "btnDes"
        btnDes.Size = New Size(125, 35)
        btnDes.TabIndex = 27
        btnDes.Text = "Decending"
        btnDes.UseVisualStyleBackColor = False
        ' 
        ' btnAsc
        ' 
        btnAsc.BackColor = SystemColors.HotTrack
        btnAsc.Cursor = Cursors.Hand
        btnAsc.FlatStyle = FlatStyle.Flat
        btnAsc.ForeColor = SystemColors.Control
        btnAsc.Location = New Point(92, 30)
        btnAsc.Margin = New Padding(2)
        btnAsc.Name = "btnAsc"
        btnAsc.Size = New Size(125, 35)
        btnAsc.TabIndex = 26
        btnAsc.Text = "Ascending"
        btnAsc.UseVisualStyleBackColor = False
        ' 
        ' gbNavigation
        ' 
        gbNavigation.Controls.Add(btnNav3)
        gbNavigation.Controls.Add(btnNav2)
        gbNavigation.Controls.Add(btnNav4)
        gbNavigation.Controls.Add(btnNav1)
        gbNavigation.Location = New Point(830, 722)
        gbNavigation.Margin = New Padding(2)
        gbNavigation.Name = "gbNavigation"
        gbNavigation.Padding = New Padding(2)
        gbNavigation.Size = New Size(587, 74)
        gbNavigation.TabIndex = 22
        gbNavigation.TabStop = False
        gbNavigation.Text = "Navigation"
        ' 
        ' btnNav3
        ' 
        btnNav3.BackColor = SystemColors.HotTrack
        btnNav3.Cursor = Cursors.Hand
        btnNav3.FlatStyle = FlatStyle.Flat
        btnNav3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNav3.ForeColor = SystemColors.Control
        btnNav3.Location = New Point(69, 28)
        btnNav3.Margin = New Padding(2)
        btnNav3.Name = "btnNav3"
        btnNav3.Size = New Size(125, 35)
        btnNav3.TabIndex = 22
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
        btnNav2.Location = New Point(327, 28)
        btnNav2.Margin = New Padding(2)
        btnNav2.Name = "btnNav2"
        btnNav2.Size = New Size(125, 35)
        btnNav2.TabIndex = 24
        btnNav2.Text = "Next"
        btnNav2.UseVisualStyleBackColor = False
        ' 
        ' btnNav4
        ' 
        btnNav4.BackColor = SystemColors.HotTrack
        btnNav4.Cursor = Cursors.Hand
        btnNav4.FlatStyle = FlatStyle.Flat
        btnNav4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNav4.ForeColor = SystemColors.Control
        btnNav4.Location = New Point(456, 28)
        btnNav4.Margin = New Padding(2)
        btnNav4.Name = "btnNav4"
        btnNav4.Size = New Size(125, 35)
        btnNav4.TabIndex = 25
        btnNav4.Text = "Last"
        btnNav4.UseVisualStyleBackColor = False
        ' 
        ' btnNav1
        ' 
        btnNav1.BackColor = SystemColors.HotTrack
        btnNav1.Cursor = Cursors.Hand
        btnNav1.FlatStyle = FlatStyle.Flat
        btnNav1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnNav1.ForeColor = SystemColors.Control
        btnNav1.Location = New Point(198, 28)
        btnNav1.Margin = New Padding(2)
        btnNav1.Name = "btnNav1"
        btnNav1.Size = New Size(125, 35)
        btnNav1.TabIndex = 23
        btnNav1.Text = "Prev"
        btnNav1.UseVisualStyleBackColor = False
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
        GroupBox1.Location = New Point(14, 58)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(434, 236)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Employee Details"
        ' 
        ' txtMobNo
        ' 
        txtMobNo.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals
        txtMobNo.Location = New Point(162, 201)
        txtMobNo.Mask = "0000000000"
        txtMobNo.Name = "txtMobNo"
        txtMobNo.PromptChar = "#"c
        txtMobNo.Size = New Size(245, 27)
        txtMobNo.TabIndex = 5
        txtMobNo.ValidatingType = GetType(Integer)
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 204)
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
        txtEmpNo.TabIndex = 0
        txtEmpNo.ValidatingType = GetType(Integer)
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(162, 166)
        dtpDate.Margin = New Padding(2)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(245, 27)
        dtpDate.TabIndex = 4
        ' 
        ' cmbDeptName
        ' 
        cmbDeptName.FormattingEnabled = True
        cmbDeptName.Location = New Point(162, 132)
        cmbDeptName.Margin = New Padding(2)
        cmbDeptName.Name = "cmbDeptName"
        cmbDeptName.Size = New Size(245, 28)
        cmbDeptName.TabIndex = 3
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(162, 98)
        txtSalary.Margin = New Padding(2)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(245, 27)
        txtSalary.TabIndex = 2
        ' 
        ' txtEmpName
        ' 
        txtEmpName.Location = New Point(162, 62)
        txtEmpName.Margin = New Padding(2)
        txtEmpName.Name = "txtEmpName"
        txtEmpName.Size = New Size(245, 27)
        txtEmpName.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 172)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 20)
        Label5.TabIndex = 23
        Label5.Text = "Date of Joining : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 135)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 20)
        Label4.TabIndex = 22
        Label4.Text = "Department Name : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 65)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 20)
        Label3.TabIndex = 21
        Label3.Text = "Employee Name : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 100)
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
        ' btnExportToExcel
        ' 
        btnExportToExcel.BackColor = SystemColors.HotTrack
        btnExportToExcel.Cursor = Cursors.Hand
        btnExportToExcel.Dock = DockStyle.Bottom
        btnExportToExcel.FlatStyle = FlatStyle.Flat
        btnExportToExcel.ForeColor = SystemColors.Control
        btnExportToExcel.Location = New Point(0, 803)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(1825, 40)
        btnExportToExcel.TabIndex = 28
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cmbBlood)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(GroupBox4)
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Controls.Add(dtpDob)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(14, 300)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(434, 224)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Personal Details"
        ' 
        ' cmbBlood
        ' 
        cmbBlood.FormattingEnabled = True
        cmbBlood.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-", "Other"})
        cmbBlood.Location = New Point(162, 184)
        cmbBlood.Margin = New Padding(2)
        cmbBlood.Name = "cmbBlood"
        cmbBlood.Size = New Size(245, 28)
        cmbBlood.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(7, 187)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 20)
        Label8.TabIndex = 31
        Label8.Text = "Blood Group :"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(rbUnM)
        GroupBox4.Controls.Add(rbM)
        GroupBox4.Location = New Point(7, 121)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(400, 58)
        GroupBox4.TabIndex = 10
        GroupBox4.TabStop = False
        GroupBox4.Text = "Marital Status : "
        ' 
        ' rbUnM
        ' 
        rbUnM.AutoSize = True
        rbUnM.Location = New Point(253, 26)
        rbUnM.Name = "rbUnM"
        rbUnM.Size = New Size(107, 24)
        rbUnM.TabIndex = 11
        rbUnM.TabStop = True
        rbUnM.Text = "Unmarried"
        rbUnM.UseVisualStyleBackColor = True
        ' 
        ' rbM
        ' 
        rbM.AutoSize = True
        rbM.Location = New Point(133, 26)
        rbM.Name = "rbM"
        rbM.Size = New Size(86, 24)
        rbM.TabIndex = 10
        rbM.TabStop = True
        rbM.Text = "Married"
        rbM.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rbo)
        GroupBox3.Controls.Add(rbFemale)
        GroupBox3.Controls.Add(rbMale)
        GroupBox3.Location = New Point(7, 57)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(400, 58)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "Gender : "
        ' 
        ' rbo
        ' 
        rbo.AutoSize = True
        rbo.Location = New Point(237, 26)
        rbo.Name = "rbo"
        rbo.Size = New Size(70, 24)
        rbo.TabIndex = 9
        rbo.TabStop = True
        rbo.Text = "Other"
        rbo.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(149, 26)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(82, 24)
        rbFemale.TabIndex = 8
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(72, 26)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(65, 24)
        rbMale.TabIndex = 7
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' dtpDob
        ' 
        dtpDob.Location = New Point(162, 25)
        dtpDob.Margin = New Padding(2)
        dtpDob.MaxDate = New Date(2050, 1, 1, 0, 0, 0, 0)
        dtpDob.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        dtpDob.Name = "dtpDob"
        dtpDob.Size = New Size(245, 27)
        dtpDob.TabIndex = 6
        dtpDob.Value = New Date(1995, 1, 1, 0, 0, 0, 0)
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 30)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 20)
        Label7.TabIndex = 31
        Label7.Text = "Date of Birth : "
        ' 
        ' txtcAdd
        ' 
        txtcAdd.Location = New Point(12, 74)
        txtcAdd.Margin = New Padding(2)
        txtcAdd.Multiline = True
        txtcAdd.Name = "txtcAdd"
        txtcAdd.Size = New Size(200, 108)
        txtcAdd.TabIndex = 13
        ' 
        ' txtpAdd
        ' 
        txtpAdd.Location = New Point(228, 74)
        txtpAdd.Margin = New Padding(2)
        txtpAdd.Multiline = True
        txtpAdd.Name = "txtpAdd"
        txtpAdd.Size = New Size(200, 108)
        txtpAdd.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 52)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(184, 20)
        Label9.TabIndex = 31
        Label9.Text = "Corrspondence Address :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(228, 52)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(160, 20)
        Label10.TabIndex = 36
        Label10.Text = "Permanent Address : "
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(cbsame)
        GroupBox5.Controls.Add(Label10)
        GroupBox5.Controls.Add(txtcAdd)
        GroupBox5.Controls.Add(Label9)
        GroupBox5.Controls.Add(txtpAdd)
        GroupBox5.Location = New Point(14, 530)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(434, 186)
        GroupBox5.TabIndex = 13
        GroupBox5.TabStop = False
        GroupBox5.Text = "Address"
        ' 
        ' cbsame
        ' 
        cbsame.AutoSize = True
        cbsame.Location = New Point(191, 25)
        cbsame.Name = "cbsame"
        cbsame.Size = New Size(108, 24)
        cbsame.TabIndex = 14
        cbsame.Text = "Both Same"
        cbsame.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.IndianRed
        Label11.Dock = DockStyle.Top
        Label11.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label11.Location = New Point(0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(1825, 55)
        Label11.TabIndex = 45
        Label11.Text = "Employee's Details"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' a02_FormEmployee
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ButtonShadow
        ClientSize = New Size(1825, 843)
        Controls.Add(Label11)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox2)
        Controls.Add(btnExportToExcel)
        Controls.Add(GroupBox1)
        Controls.Add(gbNavigation)
        Controls.Add(gbSorting)
        Controls.Add(gbOperations)
        Controls.Add(dgvEmp)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "a02_FormEmployee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Form"
        CType(dgvEmp, ComponentModel.ISupportInitialize).EndInit()
        gbOperations.ResumeLayout(False)
        gbSorting.ResumeLayout(False)
        gbNavigation.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
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
    Friend WithEvents btnExportToExcel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbo As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents cmbBlood As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtpAdd As TextBox
    Friend WithEvents txtcAdd As TextBox
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbsame As CheckBox
    Friend WithEvents rbUnM As RadioButton
    Friend WithEvents rbM As RadioButton
    Friend WithEvents Label11 As Label

End Class
