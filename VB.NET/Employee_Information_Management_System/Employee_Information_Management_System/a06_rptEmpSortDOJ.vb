Imports System.Data
Imports System.Data.SqlClient
Public Class a06_rptEmpSortDOJ
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub rptEmpSortDOJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim rnd As New Form_Round(Me)
        Try
            Dim cmd As New SqlCommand("SELECT EmpTable.EmpNo, EmpTable.EmpName, EmpTable.Salary, EmpTable.DptNo, EmpTable.Date_OJ, EmpTable.Email, EmpTable.MobNo, EmpTable.DOB, EmpTable.Gender, EmpTable.MaritalStatus, EmpTable.BloodGroup, EmpTable.CorrospondenceAddress, EmpTable.PermanentAddress, DeptTable.DptName, DeptTable.Location FROM EmpTable INNER JOIN DeptTable ON EmpTable.DptNo = DeptTable.DptNo ORDER BY EmpTable.Date_OJ DESC;
", con)
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
                .Columns(0).HeaderText = "Employee's No"
                .Columns(1).HeaderText = "Employee's Name"
                .Columns(2).HeaderText = "Salary"
                .Columns(3).HeaderText = "Department No"
                .Columns(4).HeaderText = "Date of Joining"
                .Columns(5).HeaderText = "Email"
                .Columns(6).HeaderText = "Mobile No"
                .Columns(7).HeaderText = "Date of Birth"
                .Columns(8).HeaderText = "Gender"
                .Columns(9).HeaderText = "Marital Status"
                .Columns(10).HeaderText = "Blood Group"
                .Columns(11).HeaderText = "Correspondence Address"
                .Columns(12).HeaderText = "Permanent Address"
                .Columns(13).HeaderText = "Department Name"
                .Columns(14).HeaderText = "Location"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ete As New Export_to_Excel(DataGridView1)
    End Sub
End Class