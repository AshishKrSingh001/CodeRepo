Imports System.Data.SqlClient
Imports System.Data
Public Class rptEmpSortDOJ
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub rptEmpSortDOJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("Select * from EmpTable order by Date_OJ desc", con)
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class