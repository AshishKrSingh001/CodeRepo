Imports System.Data.SqlClient
Imports System.Data
Public Class DptWiseCountEmp
    Dim con As New SqlConnection(Form1.conString)
    Private Sub DptWiseCountEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("Select DptName,Count(EmpNo) as count from DeptTable,EmpTable Where DeptTable.DptNo = EmpTable.DptNo group by DptName", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Emp")
            DataGridView1.DataSource = ds.Tables("Emp")
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            With DataGridView1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Department Name"
                .Columns(1).HeaderCell.Value = "Count"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class