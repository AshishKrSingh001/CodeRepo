Imports System.Data.SqlClient

Public Class User04_ViewPayroll
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub btnExport_to_Excel_Click(sender As Object, e As EventArgs) Handles btnExport_to_Excel.Click
        Dim ete As New Export_to_Excel(dgvEmp)
    End Sub

    Private Sub User04_ViewPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("SELECT BaseSalary, TotalHours, TotalWorkingHours, CalculatedSalary, PayrollDate, ProvidentFund, TravelAllowance, DearnessAllowance, HouseRentAllowance, NetSalary, StartDate, EndDate, month FROM Payroll where EmpNo = @eno", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@eno", User.empNo)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Atten")

            dgvEmp.DataSource = ds.Tables("Atten")

            With dgvEmp.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Black
                .ForeColor = Color.White
                .Font = New Font(dgvEmp.Font, FontStyle.Bold)
            End With
            dgvEmp.EnableHeadersVisualStyles = False
            With dgvEmp
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "Base Salary"
                .Columns(1).HeaderText = "Total Hours"
                .Columns(2).HeaderText = "Total Working Hours"
                .Columns(3).HeaderText = "Calculated Salary"
                .Columns(4).HeaderText = "Payroll Date"
                .Columns(5).HeaderText = "Provident Fund"
                .Columns(6).HeaderText = "Travel Allowance"
                .Columns(7).HeaderText = "Dearness Allowance"
                .Columns(8).HeaderText = "House Rent Allowance"
                .Columns(9).HeaderText = "Net Salary"
                .Columns(10).HeaderText = "Start Date"
                .Columns(11).HeaderText = "End Date"
                .Columns(12).HeaderText = "Month"

            End With
            Dim cmd1 As New SqlCommand("Select EmpNo,EmpName,DptName,Emptable.DptNo from EmpTable,DeptTable where EmpNo = @empno AND EmpTable.DptNo = DeptTable.DptNo", con)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@empno", User.empNo)
            Dim da1 As New SqlDataAdapter(cmd1)
            ds = New DataSet
            da1.Fill(ds, "Emp")
            Label5.Text = ds.Tables("Emp").Rows(0).Item(1)
            Label6.Text = ds.Tables("Emp").Rows(0).Item(0)
            Label7.Text = ds.Tables("Emp").Rows(0).Item(2) & "(" & ds.Tables("Emp").Rows(0).Item(3) & ")"
        Catch ex As Exception
            MessageBox.Show("Error occurred at line " & New StackFrame(True).GetFileLineNumber & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class