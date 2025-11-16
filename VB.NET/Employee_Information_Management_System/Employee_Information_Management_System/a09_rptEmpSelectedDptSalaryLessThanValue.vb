Imports System.Data
Imports System.Data.SqlClient
Public Class a09_rptEmpSelectedDptSalaryLessThanValue
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet

    Sub ComboBox_Value()
        Try
            Dim cmd As New SqlCommand("select DptNo,DptName from DeptTable", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Dept")
            ComboBox1.DataSource = ds.Tables("Dept")
            ComboBox1.DisplayMember = "DptName"
            ComboBox1.ValueMember = "DptNo"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub rptEmpSelectedDptSalaryLessThanValue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ComboBox_Value()
            Dim cmd As New SqlCommand("select EmpNo,EmpName,Salary,Date_OJ from EmpTable where DptNo = @Dno", con)
            cmd.Parameters.Add("@Dno", SqlDbType.Int).Value = ComboBox1.SelectedValue
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
                .Columns(0).HeaderCell.Value = "Employee's No"
                .Columns(1).HeaderCell.Value = "Employee's Name"
                .Columns(2).HeaderCell.Value = "Salary"
                .Columns(3).HeaderCell.Value = "Date of Joining"
            End With

            Dim cmd1 As New SqlCommand("select count(*) from EmpTable where DptNo = @Dno", con)
            cmd1.Parameters.Add("@Dno", SqlDbType.Int).Value = ComboBox1.SelectedValue
            con.Open()
            Label2.Text = "No of Employee : " & cmd1.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand("select EmpNo,EmpName,Salary,Date_OJ from EmpTable where Salary < @salary and DptNo = @Dno", con)
            cmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = CDec(TextBox1.Text)
            cmd.Parameters.Add("@Dno", SqlDbType.Int).Value = ComboBox1.SelectedValue
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Emp")
            DataGridView1.DataSource = ds.Tables("Emp")
            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black

            Dim cmd1 As New SqlCommand("select count(*) from EmpTable where Salary < @salary and DptNo = @Dno", con)
            cmd1.Parameters.Add("@Salary", SqlDbType.Decimal).Value = CDec(TextBox1.Text)
            cmd1.Parameters.Add("@Dno", SqlDbType.Int).Value = ComboBox1.SelectedValue
            con.Open()
            Label2.Text = "No of Employee : " & cmd1.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(DataGridView1)
    End Sub
End Class