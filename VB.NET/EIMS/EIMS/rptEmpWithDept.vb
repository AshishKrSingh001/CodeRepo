Imports System.Data.SqlClient
Imports System.Data
Public Class rptEmpWithDept
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet

    Private Sub rptEmpWithDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,Date_Oj,EmpTable.DptNo,DptName,Location from EmpTable,DeptTable where EmpTable.DptNo = DeptTable.DptNo", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Emp")
            DataGridView1.DataSource = ds.Tables("Emp")
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            With DataGridView1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Employee's No"
                .Columns(1).HeaderCell.Value = "Employee's Name"
                .Columns(2).HeaderCell.Value = "Salary"
                .Columns(3).HeaderCell.Value = "Department No"
                .Columns(4).HeaderCell.Value = "Date of Joining"
            End With

            Dim cmd1 As New SqlCommand("Select Count(*) from EmpTable", con)
            con.Open()
            Label1.Text = "No Of Employees: " & cmd1.ExecuteScalar
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class