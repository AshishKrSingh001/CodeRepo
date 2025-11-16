Imports System.Data.SqlClient

Public Class User
    Public empNo As Integer
    Function GetEmpNoByEmail(ByVal email As String) As Integer
        Dim empNo As Integer = -1 ' Default value in case email is not found

        ' SQL query to retrieve EmpNo based on email
        Dim query As String = "SELECT EmpNo FROM EmpTable WHERE Email = @Email"

        Using connection As New SqlConnection(Form1.conString)
            Using command As New SqlCommand(query, connection)
                ' Add parameter for email
                command.Parameters.AddWithValue("@Email", email)

                Try
                    connection.Open()
                    ' Execute the query
                    Dim result As Object = command.ExecuteScalar()

                    ' Check if result is not null
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        empNo = Convert.ToInt32(result)
                    End If

                Catch ex As Exception
                    Console.WriteLine("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return empNo
    End Function
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
        empNo = GetEmpNoByEmail(UserSIgnIn.user)
    End Sub
End Class