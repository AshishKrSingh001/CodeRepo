Imports System.Data.SqlClient


Public Class a17_ReportOfAllRecord
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Sub displayRecords()
        Try
            Dim cmd As New SqlCommand("Select Id,EmpTable.EmpNo,EmpName,EmpTable.DptNo,DptName,Location,Date_OJ,Email,MobNo,Salary,attenDate,inTime,inStatus,outTime,outStatus,TimeDuration from AttendanceTable,EmpTable,DeptTable where AttendanceTable.EmpNo = EmpTable.EmpNo AND EmpTable.DptNo = DeptTable.DptNo", con)
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
                .Columns(0).HeaderCell.Value = "S. NO"
                .Columns(1).HeaderCell.Value = "Employee's No"
                .Columns(2).HeaderCell.Value = "Employee's Name"
                .Columns(3).HeaderCell.Value = "Department No"
                .Columns(4).HeaderCell.Value = "Department Name"
                .Columns(5).HeaderCell.Value = "Location"
                .Columns(6).HeaderCell.Value = "Date of Join"
                .Columns(7).HeaderCell.Value = "Email"
                .Columns(8).HeaderCell.Value = "Mobile No"
                .Columns(9).HeaderCell.Value = "Salary"
                .Columns(10).HeaderCell.Value = "Date"
                .Columns(11).HeaderCell.Value = "In Time"
                .Columns(12).HeaderCell.Value = "In Status"
                .Columns(13).HeaderCell.Value = "Out Time"
                .Columns(14).HeaderCell.Value = "Out Status"
                .Columns(14).HeaderCell.Value = "Time Duration"

                .Columns(0).FillWeight = 20
                .Columns(1).FillWeight = 40
                .Columns(2).FillWeight = 100
                .Columns(3).FillWeight = 50
                .Columns(4).FillWeight = 70
                .Columns(5).FillWeight = 70
                .Columns(6).FillWeight = 50
                .Columns(7).FillWeight = 150
                .Columns(8).FillWeight = 70
                .Columns(9).FillWeight = 40
                .Columns(10).FillWeight = 60
                .Columns(11).FillWeight = 40
                .Columns(12).FillWeight = 40
                .Columns(13).FillWeight = 40
                .Columns(14).FillWeight = 40
                .Columns(15).FillWeight = 40
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