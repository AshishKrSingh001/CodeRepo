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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        EmailAndMobileNoToolStripMenuItem = New ToolStripMenuItem()
        AttendenceToolStripMenuItem = New ToolStripMenuItem()
        TimeInTimeOutToolStripMenuItem = New ToolStripMenuItem()
        AttendenceRecordToolStripMenuItem = New ToolStripMenuItem()
        ReportOfAllRecordToolStripMenuItem = New ToolStripMenuItem()
        EmployeesAttendenceToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        GeneratePayrollToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        ViewPayrollToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DataEntryToolStripMenuItem1, ReportToolStripMenuItem, AttendenceToolStripMenuItem, ExitToolStripMenuItem1, ExitToolStripMenuItem})
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
        DataEntryToolStripMenuItem1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        DataEntryToolStripMenuItem1.Name = "DataEntryToolStripMenuItem1"
        DataEntryToolStripMenuItem1.Size = New Size(101, 24)
        DataEntryToolStripMenuItem1.Text = "Data Entry"
        ' 
        ' DeptMenuStrip
        ' 
        DeptMenuStrip.Name = "DeptMenuStrip"
        DeptMenuStrip.Size = New Size(204, 26)
        DeptMenuStrip.Text = "1. Department"
        ' 
        ' EmployeeMenuStrip
        ' 
        EmployeeMenuStrip.Name = "EmployeeMenuStrip"
        EmployeeMenuStrip.Size = New Size(204, 26)
        EmployeeMenuStrip.Text = "2. Employee"
        ' 
        ' AddUsersToolStripMenuItem
        ' 
        AddUsersToolStripMenuItem.Name = "AddUsersToolStripMenuItem"
        AddUsersToolStripMenuItem.Size = New Size(204, 26)
        AddUsersToolStripMenuItem.Text = "3. Register User"
        ' 
        ' ReportToolStripMenuItem
        ' 
        ReportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TotalEmployeesToolStripMenuItem, EmployeeDetailsWithDepartmentToolStripMenuItem, EmployeeSortedByDateOfJoinToolStripMenuItem, DepartmentWiseEmployeeCountToolStripMenuItem, EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem, EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem, EmployeesBetweenRangeOfSalaryToolStripMenuItem, EmployeeJoinsAfterGivenDateToolStripMenuItem, StartingCharacterOfEmployeeNameToolStripMenuItem, DepartmentAndEmployeeRelationToolStripMenuItem, EmailAndMobileNoToolStripMenuItem})
        ReportToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        ReportToolStripMenuItem.Size = New Size(71, 24)
        ReportToolStripMenuItem.Text = "Report"
        ' 
        ' TotalEmployeesToolStripMenuItem
        ' 
        TotalEmployeesToolStripMenuItem.Name = "TotalEmployeesToolStripMenuItem"
        TotalEmployeesToolStripMenuItem.Size = New Size(584, 26)
        TotalEmployeesToolStripMenuItem.Text = "1. Total Employees"
        ' 
        ' EmployeeDetailsWithDepartmentToolStripMenuItem
        ' 
        EmployeeDetailsWithDepartmentToolStripMenuItem.Name = "EmployeeDetailsWithDepartmentToolStripMenuItem"
        EmployeeDetailsWithDepartmentToolStripMenuItem.Size = New Size(584, 26)
        EmployeeDetailsWithDepartmentToolStripMenuItem.Text = "2. Employees Details With Department"
        ' 
        ' EmployeeSortedByDateOfJoinToolStripMenuItem
        ' 
        EmployeeSortedByDateOfJoinToolStripMenuItem.Name = "EmployeeSortedByDateOfJoinToolStripMenuItem"
        EmployeeSortedByDateOfJoinToolStripMenuItem.Size = New Size(584, 26)
        EmployeeSortedByDateOfJoinToolStripMenuItem.Text = "3. Employee Sorted By date of Join"
        ' 
        ' DepartmentWiseEmployeeCountToolStripMenuItem
        ' 
        DepartmentWiseEmployeeCountToolStripMenuItem.Name = "DepartmentWiseEmployeeCountToolStripMenuItem"
        DepartmentWiseEmployeeCountToolStripMenuItem.Size = New Size(584, 26)
        DepartmentWiseEmployeeCountToolStripMenuItem.Text = "4. Department Wise Employee count"
        ' 
        ' EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem
        ' 
        EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Name = "EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem"
        EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Size = New Size(584, 26)
        EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Text = "5. Employee Accourding to the Department User Select"
        ' 
        ' EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem
        ' 
        EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Name = "EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem"
        EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Size = New Size(584, 26)
        EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Text = "6. Employee Accourding to the Selected Department And Less Salary"
        ' 
        ' EmployeesBetweenRangeOfSalaryToolStripMenuItem
        ' 
        EmployeesBetweenRangeOfSalaryToolStripMenuItem.Name = "EmployeesBetweenRangeOfSalaryToolStripMenuItem"
        EmployeesBetweenRangeOfSalaryToolStripMenuItem.Size = New Size(584, 26)
        EmployeesBetweenRangeOfSalaryToolStripMenuItem.Text = "7. Employees Between Range of Salary"
        ' 
        ' EmployeeJoinsAfterGivenDateToolStripMenuItem
        ' 
        EmployeeJoinsAfterGivenDateToolStripMenuItem.Name = "EmployeeJoinsAfterGivenDateToolStripMenuItem"
        EmployeeJoinsAfterGivenDateToolStripMenuItem.Size = New Size(584, 26)
        EmployeeJoinsAfterGivenDateToolStripMenuItem.Text = "8. Employee Joins After Given Date"
        ' 
        ' StartingCharacterOfEmployeeNameToolStripMenuItem
        ' 
        StartingCharacterOfEmployeeNameToolStripMenuItem.Name = "StartingCharacterOfEmployeeNameToolStripMenuItem"
        StartingCharacterOfEmployeeNameToolStripMenuItem.Size = New Size(584, 26)
        StartingCharacterOfEmployeeNameToolStripMenuItem.Text = "9 Starting Character of Employee Name "
        ' 
        ' DepartmentAndEmployeeRelationToolStripMenuItem
        ' 
        DepartmentAndEmployeeRelationToolStripMenuItem.Name = "DepartmentAndEmployeeRelationToolStripMenuItem"
        DepartmentAndEmployeeRelationToolStripMenuItem.Size = New Size(584, 26)
        DepartmentAndEmployeeRelationToolStripMenuItem.Text = "10. Department No Wise Employees"
        ' 
        ' EmailAndMobileNoToolStripMenuItem
        ' 
        EmailAndMobileNoToolStripMenuItem.Name = "EmailAndMobileNoToolStripMenuItem"
        EmailAndMobileNoToolStripMenuItem.Size = New Size(584, 26)
        EmailAndMobileNoToolStripMenuItem.Text = "11. Email and MobileNo"
        ' 
        ' AttendenceToolStripMenuItem
        ' 
        AttendenceToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TimeInTimeOutToolStripMenuItem, AttendenceRecordToolStripMenuItem, ReportOfAllRecordToolStripMenuItem, EmployeesAttendenceToolStripMenuItem})
        AttendenceToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        AttendenceToolStripMenuItem.Name = "AttendenceToolStripMenuItem"
        AttendenceToolStripMenuItem.Size = New Size(104, 24)
        AttendenceToolStripMenuItem.Text = "Attendence"
        ' 
        ' TimeInTimeOutToolStripMenuItem
        ' 
        TimeInTimeOutToolStripMenuItem.Name = "TimeInTimeOutToolStripMenuItem"
        TimeInTimeOutToolStripMenuItem.Size = New Size(277, 26)
        TimeInTimeOutToolStripMenuItem.Text = "1. Time_In/Time_Out"
        ' 
        ' AttendenceRecordToolStripMenuItem
        ' 
        AttendenceRecordToolStripMenuItem.Name = "AttendenceRecordToolStripMenuItem"
        AttendenceRecordToolStripMenuItem.Size = New Size(277, 26)
        AttendenceRecordToolStripMenuItem.Text = "2. Attendence Record"
        ' 
        ' ReportOfAllRecordToolStripMenuItem
        ' 
        ReportOfAllRecordToolStripMenuItem.Name = "ReportOfAllRecordToolStripMenuItem"
        ReportOfAllRecordToolStripMenuItem.Size = New Size(277, 26)
        ReportOfAllRecordToolStripMenuItem.Text = "3. Report of all record"
        ' 
        ' EmployeesAttendenceToolStripMenuItem
        ' 
        EmployeesAttendenceToolStripMenuItem.Name = "EmployeesAttendenceToolStripMenuItem"
        EmployeesAttendenceToolStripMenuItem.Size = New Size(277, 26)
        EmployeesAttendenceToolStripMenuItem.Text = "4. Employee's Attendence"
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {GeneratePayrollToolStripMenuItem, ViewPayrollToolStripMenuItem})
        ExitToolStripMenuItem1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(76, 24)
        ExitToolStripMenuItem1.Text = "Payroll"
        ' 
        ' GeneratePayrollToolStripMenuItem
        ' 
        GeneratePayrollToolStripMenuItem.Name = "GeneratePayrollToolStripMenuItem"
        GeneratePayrollToolStripMenuItem.Size = New Size(224, 26)
        GeneratePayrollToolStripMenuItem.Text = "GeneratePayroll"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic)
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(51, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = SystemColors.ActiveCaptionText
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(718, 418)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' ViewPayrollToolStripMenuItem
        ' 
        ViewPayrollToolStripMenuItem.Name = "ViewPayrollToolStripMenuItem"
        ViewPayrollToolStripMenuItem.Size = New Size(224, 26)
        ViewPayrollToolStripMenuItem.Text = "View Payroll"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ButtonShadow
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(718, 444)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents AttendenceToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TimeInTimeOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendenceRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportOfAllRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeesAttendenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneratePayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPayrollToolStripMenuItem As ToolStripMenuItem

End Class
