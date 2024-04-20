Public Class Form1
    Public conString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Repo\CodeRepo\VB.NET\Employee_Information_Management_System\Employee_Information_Management_System\Employee_DepartmentDB.mdf;Integrated Security=True"
    Private Sub DeptMenuStrip_Click(sender As Object, e As EventArgs) Handles DeptMenuStrip.Click
        a01_FormDept.ShowDialog()
    End Sub

    Private Sub EmployeeMenuStrip_Click(sender As Object, e As EventArgs) Handles EmployeeMenuStrip.Click
        a02_FormEmployee.ShowDialog()
    End Sub

    Private Sub AddUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUsersToolStripMenuItem.Click
        a03_Signup.ShowDialog()
    End Sub

    Private Sub TotalEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalEmployeesToolStripMenuItem.Click
        a04_rptTotalEmp.ShowDialog()
    End Sub

    Private Sub EmployeeDetailsWithDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDetailsWithDepartmentToolStripMenuItem.Click
        a05_rptEmpWithDept.ShowDialog()
    End Sub

    Private Sub EmployeeSortedByDateOfJoinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeSortedByDateOfJoinToolStripMenuItem.Click
        a06_rptEmpSortDOJ.ShowDialog()
    End Sub

    Private Sub DepartmentWiseEmployeeCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentWiseEmployeeCountToolStripMenuItem.Click
        a07_DptWiseCountEmp.ShowDialog()
    End Sub

    Private Sub EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Click
        a08_EmpAccordingDptSelected.ShowDialog()
    End Sub

    Private Sub EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Click
        a09_rptEmpSelectedDptSalaryLessThanValue.ShowDialog()
    End Sub

    Private Sub EmployeesBetweenRangeOfSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesBetweenRangeOfSalaryToolStripMenuItem.Click
        a10_EmployeesBetweenRangeofSalary.ShowDialog()
    End Sub

    Private Sub EmployeeJoinsAfterGivenDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeJoinsAfterGivenDateToolStripMenuItem.Click
        a11_EmployeesJoinAfterDate.ShowDialog()
    End Sub

    Private Sub StartingCharacterOfEmployeeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartingCharacterOfEmployeeNameToolStripMenuItem.Click
        a12_rptStartCharName.ShowDialog()
    End Sub

    Private Sub DepartmentAndEmployeeRelationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentAndEmployeeRelationToolStripMenuItem.Click
        a13_rptDeptNoWiseEmployee.ShowDialog()
    End Sub

    Private Sub EmailAndMobileNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailAndMobileNoToolStripMenuItem.Click
        a14_rptEmailandMobileNo.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub AttendenceRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendenceRecordToolStripMenuItem.Click
        a15_rptAttendenceRecord.ShowDialog()
    End Sub

    Private Sub TimeInTimeOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeInTimeOutToolStripMenuItem.Click
        a16_TimeIn_TimeOut.ShowDialog()
    End Sub

    Private Sub ReportOfAllRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportOfAllRecordToolStripMenuItem.Click
        a17_ReportOfAllRecord.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a18_signin.ShowDialog()
    End Sub

    Private Sub EmployeesAttendenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesAttendenceToolStripMenuItem.Click
        a19_Attendence_of_Each_Individual.ShowDialog()
    End Sub
End Class
