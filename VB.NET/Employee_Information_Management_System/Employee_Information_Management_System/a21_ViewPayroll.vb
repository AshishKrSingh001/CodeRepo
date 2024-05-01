Imports System.Data.SqlClient

Public Class a21_ViewPayroll
    Dim connection As New SqlConnection(Form1.conString)
    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(dgvEmployees)
    End Sub

    Sub displayRecords()
        'Dim rnd As New Form_Round(Me)
        Try
            Dim ds As DataSet = New DataSet
            Dim cmd As New SqlCommand("SELECT Payroll.EmpNo,EmpName, BaseSalary, TotalHours, TotalWorkingHours, CalculatedSalary,PayrollDate, ProvidentFund, TravelAllowance, DearnessAllowance, HouseRentAllowance, NetSalary, StartDate, EndDate, month FROM Payroll,EmpTable where Payroll.EmpNo = EmpTable.EmpNo", connection)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet

            Using da
                da.Fill(ds, "Pay")
            End Using

            dgvEmployees.DataSource = ds.Tables("Pay")

            With dgvEmployees.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Black
                .ForeColor = Color.White
                .Font = New Font(dgvEmployees.Font, FontStyle.Bold)
            End With

            dgvEmployees.EnableHeadersVisualStyles = False

            With dgvEmployees
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "Employee Number"
                .Columns(1).HeaderText = "Employee Name"
                .Columns(2).HeaderText = "Base Salary"
                .Columns(3).HeaderText = "Total Hours"
                .Columns(4).HeaderText = "Total Working Hours"
                .Columns(5).HeaderText = "Calculated Salary"
                .Columns(6).HeaderText = "Payroll Date"
                .Columns(7).HeaderText = "Provident Fund"
                .Columns(8).HeaderText = "Travel Allowance"
                .Columns(9).HeaderText = "Dearness Allowance"
                .Columns(10).HeaderText = "House Rent Allowance"
                .Columns(11).HeaderText = "Net Salary"
                .Columns(12).HeaderText = "Start Date"
                .Columns(13).HeaderText = "End Date"
                .Columns(14).HeaderText = "Month"
            End With

        Catch ex As Exception
            MessageBox.Show("Error occurred at line " & New StackFrame(True).GetFileLineNumber & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub a21_ViewPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayRecords()
    End Sub
End Class