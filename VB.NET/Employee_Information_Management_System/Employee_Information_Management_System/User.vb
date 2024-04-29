Public Class User
    Public user As String = UserSIgnIn.user
    Private Sub ChangePToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePToolStripMenuItem.Click
        User02_ResetUserPassword.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Form1.ShowDialog()
    End Sub

    Private Sub TimeInTimeOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeInTimeOutToolStripMenuItem.Click
        a16_TimeIn_TimeOut.ShowDialog()
    End Sub

    Private Sub AttendanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceReportToolStripMenuItem.Click
        User03_AttendanceReport.ShowDialog()
    End Sub

    Private Sub EmployeeMenuStrip_Click(sender As Object, e As EventArgs) Handles EmployeeMenuStrip.Click
        User01_EmployeesInformation.ShowDialog()
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click
        User04_ViewPayroll.ShowDialog()
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserSIgnIn.ShowDialog()
    End Sub
End Class