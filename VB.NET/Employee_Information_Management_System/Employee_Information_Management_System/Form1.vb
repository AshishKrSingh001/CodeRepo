Public Class Form1
    ' Connection string for the database
    Public conString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Repo\CodeRepo\VB.NET\Employee_Information_Management_System\Employee_Information_Management_System\Employee_DepartmentDB.mdf;Integrated Security=True"

    ' Method to open Department Form
    Private Sub DeptMenuStrip_Click(sender As Object, e As EventArgs) Handles DeptMenuStrip.Click
        a01_FormDept.ShowDialog()
    End Sub

    ' Method to open Employee Form
    Private Sub EmployeeMenuStrip_Click(sender As Object, e As EventArgs) Handles EmployeeMenuStrip.Click
        a02_FormEmployee.ShowDialog()
    End Sub

    ' Method to open Signup Form
    Private Sub AddUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUsersToolStripMenuItem.Click
        a03_Signup.ShowDialog()
    End Sub

    ' Method to open Total Employees Report Form
    Private Sub TotalEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalEmployeesToolStripMenuItem.Click
        a04_rptTotalEmp.ShowDialog()
    End Sub

    ' Method to open Employee Details with Department Report Form
    Private Sub EmployeeDetailsWithDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDetailsWithDepartmentToolStripMenuItem.Click
        a05_rptEmpWithDept.ShowDialog()
    End Sub

    ' Method to open Employee Sorted by Date of Joining Report Form
    Private Sub EmployeeSortedByDateOfJoinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeSortedByDateOfJoinToolStripMenuItem.Click
        a06_rptEmpSortDOJ.ShowDialog()
    End Sub

    ' Method to open Department-wise Employee Count Report Form
    Private Sub DepartmentWiseEmployeeCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentWiseEmployeeCountToolStripMenuItem.Click
        a07_DptWiseCountEmp.ShowDialog()
    End Sub

    ' Method to open Employee According to the Department (User Select) Report Form
    Private Sub EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Click
        a08_EmpAccordingDptSelected.ShowDialog()
    End Sub

    ' Method to open Employees according to the Selected Department and Less Salary Report Form
    Private Sub EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Click
        a09_rptEmpSelectedDptSalaryLessThanValue.ShowDialog()
    End Sub

    ' Method to open Employees Between Range of Salary Report Form
    Private Sub EmployeesBetweenRangeOfSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesBetweenRangeOfSalaryToolStripMenuItem.Click
        a10_EmployeesBetweenRangeofSalary.ShowDialog()
    End Sub

    ' Method to open Employees Join After Given Date Report Form
    Private Sub EmployeeJoinsAfterGivenDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeJoinsAfterGivenDateToolStripMenuItem.Click
        a11_EmployeesJoinAfterDate.ShowDialog()
    End Sub

    ' Method to open Report of Employees with Names Starting with a Particular Character Form
    Private Sub StartingCharacterOfEmployeeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartingCharacterOfEmployeeNameToolStripMenuItem.Click
        a12_rptStartCharName.ShowDialog()
    End Sub

    ' Method to open Department and Employee Relation Report Form
    Private Sub DepartmentAndEmployeeRelationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentAndEmployeeRelationToolStripMenuItem.Click
        a13_rptDeptNoWiseEmployee.ShowDialog()
    End Sub

    ' Method to open Email and Mobile No Report Form
    Private Sub EmailAndMobileNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailAndMobileNoToolStripMenuItem.Click
        a14_rptEmailandMobileNo.ShowDialog()
    End Sub


    ' Method to open Attendence Record Report Form
    Private Sub AttendenceRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendenceRecordToolStripMenuItem.Click
        a15_rptAttendenceRecord.ShowDialog()
    End Sub

    ' Method to open Time In Time Out Form
    Private Sub TimeInTimeOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeInTimeOutToolStripMenuItem.Click
        a16_TimeIn_TimeOut.ShowDialog()
    End Sub

    ' Method to open Report of All Records Form
    Private Sub ReportOfAllRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportOfAllRecordToolStripMenuItem.Click
        a17_ReportOfAllRecord.ShowDialog()
    End Sub

    ' Method to open Sign-in Form when the application loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a18_signin.ShowDialog()
    End Sub

    ' Method to open Attendence of Each Individual Report Form
    Private Sub EmployeesAttendenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesAttendenceToolStripMenuItem.Click
        a19_Attendence_of_Each_Individual.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub GeneratePayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneratePayrollToolStripMenuItem.Click
        a20_PayrollForm.ShowDialog()
    End Sub

    Private Sub ViewPayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPayrollToolStripMenuItem.Click
        a21_ViewPayroll.ShowDialog()
    End Sub
End Class
