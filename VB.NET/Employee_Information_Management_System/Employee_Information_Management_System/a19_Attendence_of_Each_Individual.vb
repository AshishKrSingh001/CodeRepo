Imports System.Data.SqlClient
Imports System.Data

Public Class a19_Attendence_of_Each_Individual
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Dim no As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExport_to_Excel.Click
        Dim ete As New Export_to_Excel(dgvEmp)
    End Sub

    Sub displayRecords()
        Try
            Dim cmd As New SqlCommand("Select attenDate,inTime,inStatus,outTime,outStatus,TimeDuration from AttendanceTable where EmpNo = @empno", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@empno", no)
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
                .Columns(0).HeaderCell.Value = "Date"
                .Columns(1).HeaderCell.Value = "In Time"
                .Columns(2).HeaderCell.Value = "In Status"
                .Columns(3).HeaderCell.Value = "Out Time"
                .Columns(4).HeaderCell.Value = "Out Status"
                .Columns(5).HeaderCell.Value = "Time Duration"
            End With
            Dim cmd1 As New SqlCommand("Select EmpNo,EmpName,DptName,Emptable.DptNo from EmpTable,DeptTable where EmpTable.EmpNo = @empno AND EmpTable.DptNo = DeptTable.DptNo", con)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@empno", no)
            Dim da1 As New SqlDataAdapter(cmd1)
            ds = New DataSet
            da1.Fill(ds, "Emp")
            Label5.Text = ds.Tables("Emp").Rows(0).Item(1)
            Label6.Text = ds.Tables("Emp").Rows(0).Item(0)
            Label7.Text = ds.Tables("Emp").Rows(0).Item(2) & "(" & ds.Tables("Emp").Rows(0).Item(3) & ")"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub Attendance_of_Each_Individual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        no = 10001
        displayRecords()
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        no = CInt(txtEmpNo.Text)
        displayRecords()
    End Sub

End Class
