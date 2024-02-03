<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        DataEntryToolStripMenuItem1 = New ToolStripMenuItem()
        DeptMenuStrip = New ToolStripMenuItem()
        EmployeeMenuStrip = New ToolStripMenuItem()
        AddUsersToolStripMenuItem = New ToolStripMenuItem()
        ReportToolStripMenuItem = New ToolStripMenuItem()
        TotalEmployeesToolStripMenuItem = New ToolStripMenuItem()
        EmployeeDetailsWithDepartmentToolStripMenuItem = New ToolStripMenuItem()
        EmployeeSortedByDateOfJoinToolStripMenuItem = New ToolStripMenuItem()
        DepartmentWiseEmployeeCountToolStripMenuItem = New ToolStripMenuItem()
        EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem = New ToolStripMenuItem()
        EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem = New ToolStripMenuItem()
        EmployeesBetweenRangeOfSalaryToolStripMenuItem = New ToolStripMenuItem()
        EmployeeJoinsAfterGivenDateToolStripMenuItem = New ToolStripMenuItem()
        StartingCharacterOfEmployeeNameToolStripMenuItem = New ToolStripMenuItem()
        DepartmentAndEmployeeRelationToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        EmailAndMobileNoToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DataEntryToolStripMenuItem1, ReportToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 1, 0, 1)
        MenuStrip1.Size = New Size(718, 26)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DataEntryToolStripMenuItem1
        ' 
        DataEntryToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {DeptMenuStrip, EmployeeMenuStrip, AddUsersToolStripMenuItem})
        DataEntryToolStripMenuItem1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        DataEntryToolStripMenuItem1.Name = "DataEntryToolStripMenuItem1"
        DataEntryToolStripMenuItem1.Size = New Size(101, 24)
        DataEntryToolStripMenuItem1.Text = "Data Entry"
        ' 
        ' DeptMenuStrip
        ' 
        DeptMenuStrip.Name = "DeptMenuStrip"
        DeptMenuStrip.Size = New Size(187, 26)
        DeptMenuStrip.Text = "Department"
        ' 
        ' EmployeeMenuStrip
        ' 
        EmployeeMenuStrip.Name = "EmployeeMenuStrip"
        EmployeeMenuStrip.Size = New Size(187, 26)
        EmployeeMenuStrip.Text = "Employee"
        ' 
        ' AddUsersToolStripMenuItem
        ' 
        AddUsersToolStripMenuItem.Name = "AddUsersToolStripMenuItem"
        AddUsersToolStripMenuItem.Size = New Size(187, 26)
        AddUsersToolStripMenuItem.Text = "Register User"
        ' 
        ' ReportToolStripMenuItem
        ' 
        ReportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TotalEmployeesToolStripMenuItem, EmployeeDetailsWithDepartmentToolStripMenuItem, EmployeeSortedByDateOfJoinToolStripMenuItem, DepartmentWiseEmployeeCountToolStripMenuItem, EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem, EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem, EmployeesBetweenRangeOfSalaryToolStripMenuItem, EmployeeJoinsAfterGivenDateToolStripMenuItem, StartingCharacterOfEmployeeNameToolStripMenuItem, DepartmentAndEmployeeRelationToolStripMenuItem, EmailAndMobileNoToolStripMenuItem})
        ReportToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        ReportToolStripMenuItem.Size = New Size(71, 24)
        ReportToolStripMenuItem.Text = "Report"
        ' 
        ' TotalEmployeesToolStripMenuItem
        ' 
        TotalEmployeesToolStripMenuItem.Name = "TotalEmployeesToolStripMenuItem"
        TotalEmployeesToolStripMenuItem.Size = New Size(566, 26)
        TotalEmployeesToolStripMenuItem.Text = "Total Employees"
        ' 
        ' EmployeeDetailsWithDepartmentToolStripMenuItem
        ' 
        EmployeeDetailsWithDepartmentToolStripMenuItem.Name = "EmployeeDetailsWithDepartmentToolStripMenuItem"
        EmployeeDetailsWithDepartmentToolStripMenuItem.Size = New Size(566, 26)
        EmployeeDetailsWithDepartmentToolStripMenuItem.Text = "Employees Details With Department"
        ' 
        ' EmployeeSortedByDateOfJoinToolStripMenuItem
        ' 
        EmployeeSortedByDateOfJoinToolStripMenuItem.Name = "EmployeeSortedByDateOfJoinToolStripMenuItem"
        EmployeeSortedByDateOfJoinToolStripMenuItem.Size = New Size(566, 26)
        EmployeeSortedByDateOfJoinToolStripMenuItem.Text = "Employee Sorted By date of Join"
        ' 
        ' DepartmentWiseEmployeeCountToolStripMenuItem
        ' 
        DepartmentWiseEmployeeCountToolStripMenuItem.Name = "DepartmentWiseEmployeeCountToolStripMenuItem"
        DepartmentWiseEmployeeCountToolStripMenuItem.Size = New Size(566, 26)
        DepartmentWiseEmployeeCountToolStripMenuItem.Text = "Department Wise Employee count"
        ' 
        ' EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem
        ' 
        EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Name = "EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem"
        EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Size = New Size(566, 26)
        EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Text = "Employee Accourding to the Department User Select"
        ' 
        ' EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem
        ' 
        EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Name = "EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem"
        EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Size = New Size(566, 26)
        EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Text = "Employee Accourding to the Selected Department And Less Salary"
        ' 
        ' EmployeesBetweenRangeOfSalaryToolStripMenuItem
        ' 
        EmployeesBetweenRangeOfSalaryToolStripMenuItem.Name = "EmployeesBetweenRangeOfSalaryToolStripMenuItem"
        EmployeesBetweenRangeOfSalaryToolStripMenuItem.Size = New Size(566, 26)
        EmployeesBetweenRangeOfSalaryToolStripMenuItem.Text = "Employees Between Range of Salary"
        ' 
        ' EmployeeJoinsAfterGivenDateToolStripMenuItem
        ' 
        EmployeeJoinsAfterGivenDateToolStripMenuItem.Name = "EmployeeJoinsAfterGivenDateToolStripMenuItem"
        EmployeeJoinsAfterGivenDateToolStripMenuItem.Size = New Size(566, 26)
        EmployeeJoinsAfterGivenDateToolStripMenuItem.Text = "Employee Joins After Given Date"
        ' 
        ' StartingCharacterOfEmployeeNameToolStripMenuItem
        ' 
        StartingCharacterOfEmployeeNameToolStripMenuItem.Name = "StartingCharacterOfEmployeeNameToolStripMenuItem"
        StartingCharacterOfEmployeeNameToolStripMenuItem.Size = New Size(566, 26)
        StartingCharacterOfEmployeeNameToolStripMenuItem.Text = "Starting Character of Employee Name "
        ' 
        ' DepartmentAndEmployeeRelationToolStripMenuItem
        ' 
        DepartmentAndEmployeeRelationToolStripMenuItem.Name = "DepartmentAndEmployeeRelationToolStripMenuItem"
        DepartmentAndEmployeeRelationToolStripMenuItem.Size = New Size(566, 26)
        DepartmentAndEmployeeRelationToolStripMenuItem.Text = "Department No Wise Employees"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(51, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ActiveCaptionText
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(718, 418)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' EmailAndMobileNoToolStripMenuItem
        ' 
        EmailAndMobileNoToolStripMenuItem.Name = "EmailAndMobileNoToolStripMenuItem"
        EmailAndMobileNoToolStripMenuItem.Size = New Size(566, 26)
        EmailAndMobileNoToolStripMenuItem.Text = "Email and MobileNo"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(718, 444)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = " Department & Employee Information Management"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataEntryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeptMenuStrip As ToolStripMenuItem
    Friend WithEvents EmployeeMenuStrip As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeDetailsWithDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmployeeSortedByDateOfJoinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentWiseEmployeeCountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeesBetweenRangeOfSalaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeJoinsAfterGivenDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartingCharacterOfEmployeeNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentAndEmployeeRelationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailAndMobileNoToolStripMenuItem As ToolStripMenuItem
End Class
