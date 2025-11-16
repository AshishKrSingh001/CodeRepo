Imports System.Data
Imports System.Data.SqlClient

Public Class a11_EmployeesJoinAfterDate
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub EmployeesJoinAfterDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,DptName,Date_OJ from EmpTable,DeptTable where DeptTable.Dptno = EmpTable.Dptno", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Emp")
            DataGridView1.DataSource = ds.Tables("Emp")
            With DataGridView1.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Black
                .ForeColor = Color.White
                .Font = New Font(DataGridView1.Font, FontStyle.Bold)
            End With
            DataGridView1.EnableHeadersVisualStyles = False
            With DataGridView1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Employee's No"
                .Columns(1).HeaderCell.Value = "Employee's Name"
                .Columns(2).HeaderCell.Value = "Salary"
                .Columns(3).HeaderCell.Value = "Department Name"
                .Columns(4).HeaderCell.Value = "Date of Join"
            End With

            Dim cmd1 As New SqlCommand("Select Count(*) from EmpTable", con)
            con.Open()
            Label2.Text = "No of Employees : " & cmd1.ExecuteScalar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,DptName,Date_OJ from EmpTable,DeptTable where DeptTable.Dptno = EmpTable.Dptno and Date_OJ > @d", con)
            cmd.Parameters.Add("@d", SqlDbType.Date).Value = DateTimePicker1.Value
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Emp")
            DataGridView1.DataSource = ds.Tables("Emp")

            Dim cmd1 As New SqlCommand("Select Count(*) from EmpTable where Date_OJ > @do", con)
            cmd1.Parameters.Add("@do", SqlDbType.Date).Value = DateTimePicker1.Value
            con.Open()
            Label2.Text = "No of Employee : " & cmd1.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(DataGridView1)
    End Sub
End Class