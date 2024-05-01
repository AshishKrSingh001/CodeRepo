Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class a10_EmployeesBetweenRangeofSalary
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub EmployeesBetweenRangeofSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,DptName,Date_OJ from EmpTable,DeptTable where DeptTable.Dptno = EmpTable.Dptno", con)
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
                .Columns(3).HeaderCell.Value = "Department Name"
                .Columns(4).HeaderCell.Value = "Date of Join"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If CDec(TextBox1.Text) < CDec(TextBox2.Text) Then
                Try
                    Dim cmd As New SqlCommand("Select EmpNo,EmpName,Salary,DptName,Date_OJ from EmpTable,DeptTable where DeptTable.Dptno = EmpTable.Dptno AND Salary > @sal1 and Salary < @sal2", con)
                    cmd.Parameters.Add("@sal1", SqlDbType.Int).Value = CDec(TextBox1.Text)
                    cmd.Parameters.Add("@sal2", SqlDbType.Int).Value = CDec(TextBox2.Text)
                    Dim da As New SqlDataAdapter(cmd)
                    ds = New DataSet
                    da.Fill(ds, "Emp")
                    DataGridView1.DataSource = ds.Tables("Emp")
                    With DataGridView1.ColumnHeadersDefaultCellStyle
                        .BackColor = Color.Black
                        .ForeColor = Color.White
                        .Font = New Font(DataGridView1.Font, FontStyle.Bold)
                    End With
                    With DataGridView1
                        .RowHeadersVisible = False
                        .Columns(0).HeaderCell.Value = "Employee's No"
                        .Columns(1).HeaderCell.Value = "Employee's Name"
                        .Columns(2).HeaderCell.Value = "Salary"
                        .Columns(3).HeaderCell.Value = "Department Name"
                        .Columns(4).HeaderCell.Value = "Date of Join"
                    End With

                    Dim cmd1 As New SqlCommand("select count(*) from EmpTable where Salary > @sal1 and Salary < @sal2", con)
                    cmd1.Parameters.Add("@sal1", SqlDbType.Int).Value = CDec(TextBox1.Text)
                    cmd1.Parameters.Add("@sal2", SqlDbType.Int).Value = CDec(TextBox2.Text)
                    con.Open()
                    Label2.Text = "No of Employee : " & cmd1.ExecuteScalar()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try
            Else
                Throw (New NotSpecifiedFormatEnteredBetweenSalary("You have not Entered A specified Fromat"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
Class NotSpecifiedFormatEnteredBetweenSalary : Inherits ApplicationException
    Public Sub New(Msg As String)
        MyBase.New(Msg)
    End Sub
End Class