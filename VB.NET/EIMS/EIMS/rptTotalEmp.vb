Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Common

Public Class rptTotalEmp
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub rptTotalEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,EmpTable.DptNo,DptName,Date_Oj from EmpTable,DeptTable where EmpTable.DptNo = DeptTable.DptNo", con)
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
                .Columns(4).HeaderCell.Value = "Department Name"
                .Columns(5).HeaderCell.Value = "Date of Join"
            End With
            Dim cmd1 As New SqlCommand("Select Count(*) from EmpTable", con)
            con.Open()
            lblCount.Text = "No of Employee : " & cmd1.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class