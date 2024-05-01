Imports System.Data
Imports System.Data.SqlClient
Public Class a07_DptWiseCountEmp
    Dim con As New SqlConnection(Form1.conString)
    Private Sub DptWiseCountEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim rnd As New Form_Round(Me)
        Try
            Dim cmd As New SqlCommand("Select DptName,Count(EmpNo) as count from DeptTable,EmpTable Where DeptTable.DptNo = EmpTable.DptNo group by DptName", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
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
                .Columns(0).HeaderCell.Value = "Department Name"
                .Columns(1).HeaderCell.Value = "Count"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(DataGridView1)
    End Sub
End Class