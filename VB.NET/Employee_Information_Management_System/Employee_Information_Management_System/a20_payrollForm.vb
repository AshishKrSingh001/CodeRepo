Imports System.Data.SqlClient

Public Class a20_PayrollForm
    Dim connection As New SqlConnection(Form1.conString)

    Private Sub PayrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load employee data into DataGridView
        Try
            displayRecords()
        Catch ex As Exception
            MessageBox.Show("Error occurred at line " & New StackFrame(True).GetFileLineNumber & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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


    Private Function GetBasicSalary(empNo As Integer) As Decimal
        ' Retrieve basic salary from EmpTable for the selected employee
        Dim query As String = "SELECT Salary FROM EmpTable WHERE EmpNo = @EmpNo"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@EmpNo", empNo)
        Dim basicSalary As Decimal = Convert.ToDecimal(command.ExecuteScalar())

        Return basicSalary
    End Function

    Private Function GetTotalWorkingHours(empNo As Integer) As Decimal
        ' Retrieve total working hours from AttendanceTable for the selected employee
        Dim query As String = "SELECT SUM(CONVERT(DECIMAL(5, 2), REPLACE(TimeDuration, ':', '.'))) FROM AttendanceTable WHERE EmpNo = @EmpNo"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@EmpNo", empNo)
        Dim totalWorkingHours As Decimal = Convert.ToDecimal(command.ExecuteScalar())

        Return totalWorkingHours
    End Function

    Private Function CalculateSalary(basicSalary As Decimal, totalWorkingHours As Decimal) As Decimal
        ' Sample salary calculation logic (you can adjust it based on your requirements)
        Dim calculatedSalary As Decimal
        calculatedSalary = (basicSalary / (CDec(txtDays.Text) * 8)) * totalWorkingHours
        Return calculatedSalary
    End Function

    Private Function CalculateProvidentFund(basicSalary As Decimal) As Decimal
        ' Sample calculation logic for Provident Fund (adjust it based on your requirements)
        Return basicSalary * 0.1 ' Example: 10% of basic salary
    End Function

    Private Function CalculateTravelAllowance(basicSalary As Decimal) As Decimal
        ' Sample calculation logic for Travel Allowance (adjust it based on your requirements)
        Return basicSalary * 0.05 ' Example: 5% of basic salary
    End Function

    Private Function CalculateDearnessAllowance(basicSalary As Decimal) As Decimal
        ' Sample calculation logic for Dearness Allowance (adjust it based on your requirements)
        Return basicSalary * 0.03 ' Example: 3% of basic salary
    End Function

    Private Function CalculateHouseRentAllowance(basicSalary As Decimal) As Decimal
        ' Sample calculation logic for House Rent Allowance (adjust it based on your requirements)
        Return basicSalary * 0.07 ' Example: 7% of basic salary
    End Function

    Private Sub InsertPayroll(empNo As Integer, basicSalary As Decimal, totalWorkingHours As Decimal, calculatedSalary As Decimal, payrollDate As Date, providentFund As Decimal, travelAllowance As Decimal, dearnessAllowance As Decimal, houseRentAllowance As Decimal, netSalary As Decimal)
        Try
            ' Insert payroll data into Payroll table

            Dim query As String = "INSERT INTO Payroll (EmpNo, BaseSalary,TotalHours, TotalWorkingHours, CalculatedSalary, PayrollDate, ProvidentFund, TravelAllowance, DearnessAllowance, HouseRentAllowance, NetSalary, StartDate, EndDate, Month) VALUES (@EmpNo, @BaseSalary,@totalHours, @TotalWorkingHours, @CalculatedSalary, @PayrollDate, @ProvidentFund, @TravelAllowance, @DearnessAllowance, @HouseRentAllowance, @NetSalary, @StartDate, @EndDate,@month)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.Add("@EmpNo", SqlDbType.Int).Value = empNo
            command.Parameters.Add("@BaseSalary", SqlDbType.Decimal).Value = basicSalary
            command.Parameters.Add("@totalHours", SqlDbType.Decimal).Value = CDec(txtDays.Text) * 8
            command.Parameters.Add("@TotalWorkingHours", SqlDbType.Decimal).Value = totalWorkingHours
            command.Parameters.Add("@CalculatedSalary", SqlDbType.Decimal).Value = calculatedSalary
            command.Parameters.Add("@PayrollDate", SqlDbType.Date).Value = payrollDate
            command.Parameters.Add("@ProvidentFund", SqlDbType.Decimal).Value = providentFund
            command.Parameters.Add("@TravelAllowance", SqlDbType.Decimal).Value = travelAllowance
            command.Parameters.Add("@DearnessAllowance", SqlDbType.Decimal).Value = dearnessAllowance
            command.Parameters.Add("@HouseRentAllowance", SqlDbType.Decimal).Value = houseRentAllowance
            command.Parameters.Add("@NetSalary", SqlDbType.Decimal).Value = netSalary
            command.Parameters.Add("@StartDate", SqlDbType.Date).Value = dtpStartDate.Value
            command.Parameters.Add("@EndDate", SqlDbType.Date).Value = dtpEndDate.Value
            command.Parameters.Add("@month", SqlDbType.VarChar).Value = cmbMonth.SelectedItem

            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error occurred at line " & New StackFrame(True).GetFileLineNumber & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(dgvEmployees)
    End Sub

    Private Sub btnGeneratePayroll_Click(sender As Object, e As EventArgs) Handles btnGeneratePayroll.Click
        Try
            ' Open connection
            connection.Open()

            ' Retrieve the list of all employees
            Dim query As String = "SELECT EmpNo FROM EmpTable"
            Dim command As New SqlCommand(query, connection)

            ' Create a DataTable to store the employee data
            Dim employeeTable As New DataTable()
            Using da As New SqlDataAdapter(command)
                ' Fill the DataTable with employee data
                da.Fill(employeeTable)
            End Using

            ' Loop through the employee data in the DataTable
            For Each row As DataRow In employeeTable.Rows
                Dim empNo As Integer = Convert.ToInt32(row("EmpNo"))

                ' Calculate payroll for the current employee
                Dim basicSalary As Decimal = GetBasicSalary(empNo)
                Dim totalWorkingHours As Decimal = GetTotalWorkingHours(empNo)
                Dim calculatedSalary As Decimal = CalculateSalary(basicSalary, totalWorkingHours)
                Dim payrollDate As Date = dtpPayrollDate.Value
                Dim providentFund As Decimal = CalculateProvidentFund(basicSalary)
                Dim travelAllowance As Decimal = CalculateTravelAllowance(basicSalary)
                Dim dearnessAllowance As Decimal = CalculateDearnessAllowance(basicSalary)
                Dim houseRentAllowance As Decimal = CalculateHouseRentAllowance(basicSalary)
                Dim netSalary As Decimal = calculatedSalary - providentFund + travelAllowance + dearnessAllowance + houseRentAllowance

                ' Insert payroll data into Payroll table
                InsertPayroll(empNo, basicSalary, totalWorkingHours, calculatedSalary, payrollDate, providentFund, travelAllowance, dearnessAllowance, houseRentAllowance, netSalary)
            Next

            ' Display success message
            MessageBox.Show("Payroll generated successfully for all employees", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh displayed records
            displayRecords()

        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error occurred at line " & New StackFrame(True).GetFileLineNumber & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub



End Class
