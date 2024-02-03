Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Signup
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Dim inc As Integer = 0
    Dim maxRow As Integer = 0

    Sub displayRecords()
        Try
            Dim cmd As New SqlCommand("Select * from Loginn", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Login")
            DataGridview1.DataSource = ds.Tables("Login")
            DataGridview1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            DataGridview1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
            With DataGridview1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Username"
                .Columns(1).HeaderCell.Value = "Password"
                .Columns(2).HeaderCell.Value = "Employee No"
                .Columns(0).FillWeight = 155
            End With
            inc = 0
            maxRow = ds.Tables("Login").Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ClearControls()
        txtNo.Text = ""
        txtPassword.Text = ""
        txtcPassword.Text = ""
        txtEmail.Text = ""
        CheckBox1.Checked = False

    End Sub
    Private Function isEmpty() As Boolean
        If txtNo.Text = "" And txtPassword.Text = "" And txtEmail.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
        displayRecords()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtcPassword.Text <> txtPassword.Text Then
            MessageBox.Show("Password Doesn't Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim cmd As New SqlCommand("Select count(*) from EmpTable Where EmpNo = @eno and Email = @email", con)
                cmd.Parameters.Add("@eno", SqlDbType.Int).Value = CInt(txtNo.Text)
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text
                con.Open()
                Dim Count As Integer = 0
                Count = cmd.ExecuteScalar()
                con.Close()
                If Count = 0 Then
                    MessageBox.Show("Employee Doesn't found in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim cmd1 As New SqlCommand("Insert into Loginn(Username,Password,EmpNo) values(@uname,@pass,@empno)", con)
                    cmd1.Parameters.Add("@uname", SqlDbType.VarChar).Value = txtEmail.Text
                    cmd1.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtcPassword.Text
                    cmd1.Parameters.Add("@empno", SqlDbType.Int).Value = CInt(txtNo.Text)
                    con.Open()
                    Dim flag As Integer = 0
                    flag = cmd1.ExecuteNonQuery()
                    If flag > 0 Then
                        MessageBox.Show("Inserted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearControls()
                        displayRecords()
                    Else
                        MessageBox.Show("Something went wrong.....Record not Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                    ClearControls()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
                displayRecords()
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If isEmpty() = False And txtcPassword.Text = txtPassword.Text Then
            Try
                Dim cmd As New SqlCommand("Delete from Loginn Where Username = @user", con)
                cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = txtEmail.Text
                con.Open()
                Dim flag As Integer = 0
                flag = cmd.ExecuteNonQuery()
                con.Close()
                If flag > 0 Then
                    MessageBox.Show("Record is Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    ClearControls()
                    displayRecords()
                Else
                    MessageBox.Show("Something went wrong.....Record not Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
        displayRecords()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If isEmpty() = False And txtcPassword.Text = txtPassword.Text Then
            Try
                Dim cmd As New SqlCommand("Update Loginn Set Password = @pass where Username = @user", con)
                cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = txtEmail.Text
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text
                con.Open()
                Dim flag As Integer = 0
                flag = cmd.ExecuteNonQuery()
                con.Close()
                If flag > 0 Then
                    MessageBox.Show("Record is Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    ClearControls()
                    displayRecords()
                Else
                    MessageBox.Show("Something went wrong.....Record not Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
        displayRecords()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearControls()
        displayRecords()
    End Sub


    Private Sub DataGridView1_cellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridview1.CellContentClick
        txtEmail.Text = DataGridview1.CurrentRow.Cells(0).Value
        txtcPassword.Text = DataGridview1.CurrentRow.Cells(1).Value
        txtPassword.Text = DataGridview1.CurrentRow.Cells(1).Value
        txtNo.Text = DataGridview1.CurrentRow.Cells(2).Value
    End Sub
End Class