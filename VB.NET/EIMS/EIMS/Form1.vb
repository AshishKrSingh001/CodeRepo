Public Class Form1
    Public conString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\EIMS\EIMS\Employee_DepartmentDB.mdf;Integrated Security=True"
    Private Sub DeptMenuStrip_Click(sender As Object, e As EventArgs) Handles DeptMenuStrip.Click
        FormDept.ShowDialog()
    End Sub

    Private Sub EmployeeMenuStrip_Click(sender As Object, e As EventArgs) Handles EmployeeMenuStrip.Click
        FormEmployee.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub DepartmentWiseEmployeeCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentWiseEmployeeCountToolStripMenuItem.Click
        DptWiseCountEmp.ShowDialog()
    End Sub

    Private Sub TotalEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalEmployeesToolStripMenuItem.Click
        rptTotalEmp.ShowDialog()
    End Sub

    Private Sub EmployeeDetailsWithDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDetailsWithDepartmentToolStripMenuItem.Click
        rptEmpWithDept.ShowDialog()
    End Sub

    Private Sub EmployeeSortedByDateOfJoinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeSortedByDateOfJoinToolStripMenuItem.Click
        rptEmpSortDOJ.ShowDialog()
    End Sub

    Private Sub EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeAccourdingToTheDepartmentUserSelectToolStripMenuItem.Click
        EmpAccordingDptSelected.ShowDialog()
    End Sub

    Private Sub EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeAccourdingToTheSelectedDepartmentAndLessSalaryToolStripMenuItem.Click
        rptEmpSelectedDptSalaryLessThanValue.ShowDialog()
    End Sub

    Private Sub EmployeesBetweenRangeOfSalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesBetweenRangeOfSalaryToolStripMenuItem.Click
        EmployeesBetweenRangeofSalary.ShowDialog()
    End Sub
    Private Sub EmployeeJoinsAfterGivenDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeJoinsAfterGivenDateToolStripMenuItem.Click
        EmployeesJoinAfterDate.ShowDialog()
    End Sub

    Private Sub StartingCharacterOfEmployeeNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartingCharacterOfEmployeeNameToolStripMenuItem.Click
        rptStartCharName.ShowDialog()
    End Sub

    Private Sub DepartmentAndEmployeeRelationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentAndEmployeeRelationToolStripMenuItem.Click
        rptDeptNoWiseEmployee.ShowDialog()
    End Sub

    Private Sub AddUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUsersToolStripMenuItem.Click
        Signup.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        signin.ShowDialog()
    End Sub

    Private Sub EmailAndMobileNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmailAndMobileNoToolStripMenuItem.Click
        rptEmailandMobileNo.ShowDialog()
    End Sub
End Class
