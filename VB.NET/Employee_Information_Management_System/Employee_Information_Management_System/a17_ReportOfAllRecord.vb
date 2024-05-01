Imports System.Data.SqlClient


Public Class a17_ReportOfAllRecord
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Sub displayRecords()
        Try
            Dim cmd As New SqlCommand("Select EmpTable.EmpNo,EmpName,DptName,Location,Date_OJ,Salary,attenDate,inTime,inStatus,outTime,outStatus,TimeDuration from AttendanceTable,EmpTable,DeptTable where AttendanceTable.EmpNo = EmpTable.EmpNo AND EmpTable.DptNo = DeptTable.DptNo", con)
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
                .Columns(0).HeaderCell.Value = "Employee's No"
                .Columns(1).HeaderCell.Value = "Employee's Name"
                .Columns(2).HeaderCell.Value = "Department Name"
                .Columns(3).HeaderCell.Value = "Location"
                .Columns(4).HeaderCell.Value = "Date of Join"
                .Columns(5).HeaderCell.Value = "Salary"
                .Columns(6).HeaderCell.Value = "Date"
                .Columns(7).HeaderCell.Value = "In Time"
                .Columns(8).HeaderCell.Value = "In Status"
                .Columns(9).HeaderCell.Value = "Out Time"
                .Columns(10).HeaderCell.Value = "Out Status"
                .Columns(11).HeaderCell.Value = "Time Duration"

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ReportOfAllRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayRecords()
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(dgvEmp)
    End Sub
End Class