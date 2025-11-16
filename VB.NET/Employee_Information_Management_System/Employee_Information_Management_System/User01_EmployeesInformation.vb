Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class User01_EmployeesInformation
    Private Sub User01_EmployeesInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim commandText As String = "SELECT EmpTable.EmpNo, EmpTable.EmpName, EmpTable.Salary, EmpTable.DptNo, EmpTable.Date_OJ, " &
                      "EmpTable.Email, EmpTable.MobNo, EmpTable.DOB, EmpTable.Gender, EmpTable.MaritalStatus, " &
                      "EmpTable.BloodGroup, EmpTable.CorrospondenceAddress, EmpTable.PermanentAddress, " &
                      "DeptTable.DptName, DeptTable.Location " &
                      "FROM EmpTable " &
                      "INNER JOIN DeptTable ON EmpTable.DptNo = DeptTable.DptNo WHERE EmpTable.EmpNo = @empNo;"

            Dim con As New SqlConnection(Form1.conString)
            Dim cmd As New SqlCommand(commandText, con)
            cmd.Parameters.AddWithValue("@empNo", User.empNo)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds = New DataSet
            da.Fill(ds, "emp")


            For Each row As DataRow In ds.Tables("emp").Rows
                empNo.Text = row("EmpNo").ToString()
                Label11.Text = row("EmpName").ToString()
                Label16.Text = row("Salary").ToString()
                Label12.Text = row("DptNo").ToString()
                Label15.Text = row("Date_OJ").ToString()
                Label33.Text = row("Email").ToString()
                Label31.Text = row("MobNo").ToString()
                Label29.Text = If(row.IsNull("DOB"), "", Convert.ToDateTime(row("DOB")).ToString())
                Label27.Text = If(row.IsNull("Gender"), "", row("Gender").ToString())
                Label25.Text = If(row.IsNull("MaritalStatus"), "", row("MaritalStatus").ToString())
                Label23.Text = If(row.IsNull("BloodGroup"), "", row("BloodGroup").ToString())
                Label21.Text = If(row.IsNull("CorrospondenceAddress"), "", row("CorrospondenceAddress").ToString())
                Label19.Text = If(row.IsNull("PermanentAddress"), "", row("PermanentAddress").ToString())
                Label13.Text = row("DptName").ToString()
                Label14.Text = row("Location").ToString()
                Label17.Text = GetLastNetSalary()
            Next

        Catch ex As Exception
            MessageBox.Show("Error occurred at line " & New StackFrame(True).GetFileLineNumber & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetLastNetSalary() As Decimal
        Try
            Dim empNo As Integer = User.empNo
            Dim lastNetSalary As Decimal = 0

            Dim query As String = "SELECT NetSalary FROM Payroll WHERE EmpNo = @empNo AND PayrollDate = (SELECT MAX(PayrollDate) FROM Payroll WHERE EmpNo = @empNo)"

            Using connection As New SqlConnection(Form1.conString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@empNo", empNo)

                    Try
                        connection.Open()
                        Dim result As Object = command.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                            lastNetSalary = Convert.ToDecimal(result)
                        End If
                    Catch ex As Exception
                        ' Handle exception
                        Console.WriteLine("Error: " & ex.Message)
                    End Try
                End Using
            End Using

            Return lastNetSalary
        Catch ex As Exception
            MessageBox.Show("Error occurred at line " & New StackFrame(True).GetFileLineNumber & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Class