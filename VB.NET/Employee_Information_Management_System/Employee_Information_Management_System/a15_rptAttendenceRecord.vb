Imports System.Data.SqlClient
Imports System.Data
Imports Windows.Win32.System
Imports System.Reflection.Emit

Public Class a15_rptAttendenceRecord
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Sub displayRecords()
        Try
            Dim cmd As New SqlCommand("Select EmpTable.EmpNo,EmpName,DptNo,attenDate,inTime,inStatus,outTime,outStatus,TimeDuration from AttendanceTable,EmpTable where AttendanceTable.EmpNo = EmpTable.EmpNo", con)
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
                .Columns(2).HeaderCell.Value = "Department No"
                .Columns(3).HeaderCell.Value = "Date"
                .Columns(4).HeaderCell.Value = "In Time"
                .Columns(5).HeaderCell.Value = "In Status"
                .Columns(6).HeaderCell.Value = "Out Time"
                .Columns(7).HeaderCell.Value = "Out Status"
                .Columns(8).HeaderCell.Value = "Time Duration"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub rptAttendanceRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayRecords()
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(dgvEmp)
    End Sub


End Class