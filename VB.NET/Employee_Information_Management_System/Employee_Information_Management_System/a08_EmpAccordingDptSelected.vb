Imports System.Data
Imports System.Data.SqlClient

Public Class a08_EmpAccordingDptSelected
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Sub ComboBox_Value()
        Dim cmd As New SqlCommand("Select DptNo,DptName from DeptTable", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "Dep")
        ComboBox1.DataSource = ds.Tables("Dep")
        ComboBox1.DisplayMember = "DptName"
        ComboBox1.ValueMember = "DptNo"
    End Sub
    Sub DisplayContents()
        Try
            Dim cmd As New SqlCommand("Select * from EmpTable Where DptNo = @Dno", con)
            cmd.Parameters.Add("@Dno", SqlDbType.Int).Value = ComboBox1.SelectedValue
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
                .Columns(3).HeaderCell.Value = "Date of Join"
                .Columns(5).HeaderCell.Value = "Email"
                .Columns(6).HeaderCell.Value = "Mobile No"
                .Columns(5).FillWeight = 155
            End With

            Dim cmd1 As New SqlCommand("Select count(*) from EmpTable Where DptNo = @Dno", con)
            cmd1.Parameters.Add("@Dno", SqlDbType.Int).Value = ComboBox1.SelectedValue
            con.Open()
            Label2.Text = "No of Employees : " & cmd1.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EmpAccordingDptSelected_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_Value()
        DisplayContents()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayContents()
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(DataGridView1)
    End Sub
End Class
