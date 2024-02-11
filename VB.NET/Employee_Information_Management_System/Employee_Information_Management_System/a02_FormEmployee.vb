Imports System.Data
Imports System.Data.SqlClient

Public Class a02_FormEmployee
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Dim inc As Integer = 0
    Dim maxRow As Integer = 0
    Sub displayRecords()
        'Dim rnd As New Form_Round(Me)
        Try
            Dim cmd As New SqlCommand("Select * from EmpTable", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Emp")
            dgvEmp.DataSource = ds.Tables("Emp")
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
                .Columns(2).HeaderCell.Value = "Salary"
                .Columns(3).HeaderCell.Value = "Department No"
                .Columns(4).HeaderCell.Value = "Date of Joining"
                .Columns(5).HeaderCell.Value = "Email"
                .Columns(6).HeaderCell.Value = "Mobile No"
                .Columns(5).FillWeight = 155
            End With
            inc = 0
            maxRow = ds.Tables("Emp").Rows.Count
            With ds.Tables("Emp").Rows(maxRow - 1)
                txtEmpNo.Text = (CInt(.Item(0)) + 1)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub ClearControls()
        txtEmpNo.Text = ""
        txtEmpName.Clear()
        txtSalary.Text = ""
        txtMobNo.Text = ""
        dtpDate.Value = DateTime.Now.Date
        dtpDate.MaxDate = DateTime.Now.Date

    End Sub


    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs)
        If IsNumeric(txtSalary.Text) = False Then
            ErrorProvider1.SetError(txtSalary, "Salary Should be Numeric")
        End If
    End Sub

    Sub ComboBox_Value()
        Try
            Dim cmd As New SqlCommand("Select DptNo,DptName from DeptTable", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Dep")
            cmbDeptName.DataSource = ds.Tables("Dep")
            cmbDeptName.DisplayMember = "DptName"
            cmbDeptName.ValueMember = "DptNo"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_Value()
        displayRecords()
    End Sub



    Private Function isEmpty() As Boolean
        If txtEmpNo.Text = "" And txtEmpName.Text = "" And txtSalary.Text = "" And txtMobNo.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnDes_Click(sender As Object, e As EventArgs) Handles btnDes.Click
        Try
            Dim dv As New DataView(ds.Tables("Emp"))
            dv.Sort = "EmpName Desc"
            dgvEmp.DataSource = dv
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAsc_Click_1(sender As Object, e As EventArgs) Handles btnAsc.Click
        Try
            Dim dv As New DataView(ds.Tables("Emp"))
            dv.Sort = "EmpName Asc"
            dgvEmp.DataSource = dv
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Function GenerateEmail(Name As String, id As Integer)
        Name = Name.Replace(" ", "").Trim
        Return Name.ToLower & "." & id & "@hues.in"
    End Function
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If isEmpty() = False Then
            Try
                Dim cmd As New SqlCommand("Insert into EmpTable(EmpNo,EmpName,Salary,DptNo,Date_Oj,Email,MobNo) values(@Empno,@Empname,@salary,@DptNo,@doj,@email,@mob)", con)
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = CInt(txtEmpNo.Text)
                cmd.Parameters.Add("@Empname", SqlDbType.VarChar).Value = txtEmpName.Text
                cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = CDec(txtSalary.Text)
                cmd.Parameters.Add("@DptNo", SqlDbType.Int).Value = CInt(cmbDeptName.SelectedValue)
                cmd.Parameters.Add("@doj", SqlDbType.Date).Value = dtpDate.Value
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = GenerateEmail(txtEmpName.Text, CInt(txtEmpNo.Text))
                cmd.Parameters.Add("@mob", SqlDbType.VarChar).Value = txtMobNo.Text
                con.Open()
                Dim flag As Integer = 0
                flag = cmd.ExecuteNonQuery()
                con.Close()
                If flag > 0 Then
                    MessageBox.Show("Record is Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    ClearControls()
                    displayRecords()
                Else
                    MessageBox.Show("Something went wrong.....Record not instered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If isEmpty() = False Then
            Try
                Dim cmd As New SqlCommand("Delete from EmpTable Where EmpNo = @Empno", con)
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = CInt(txtEmpNo.Text)
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
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If isEmpty() = False Then
            Try
                Dim cmd As New SqlCommand("Update EmpTable set EmpNo=@Empno,EmpName=@Empname,Salary=@salary,DptNo=@DptNo,Date_Oj=@doj,MobNo = @mob where EmpNo = @Empno", con)
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = CInt(txtEmpNo.Text)
                cmd.Parameters.Add("@Empname", SqlDbType.VarChar).Value = txtEmpName.Text
                cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = CDec(txtSalary.Text)
                cmd.Parameters.Add("@DptNo", SqlDbType.Int).Value = CInt(cmbDeptName.SelectedValue)
                cmd.Parameters.Add("@doj", SqlDbType.Date).Value = dtpDate.Value
                cmd.Parameters.Add("@mob", SqlDbType.VarChar).Value = txtMobNo.Text
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
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearControls()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ComboBox_Value()
        ClearControls()
        displayRecords()
    End Sub

    Private Sub dgvEmp_cellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellContentClick
        txtEmpNo.Text = dgvEmp.CurrentRow.Cells(0).Value
        txtEmpName.Text = dgvEmp.CurrentRow.Cells(1).Value
        txtSalary.Text = dgvEmp.CurrentRow.Cells(2).Value
        cmbDeptName.SelectedValue = dgvEmp.CurrentRow.Cells(3).Value
        dtpDate.Value = dgvEmp.CurrentRow.Cells(4).Value
        txtMobNo.Text = dgvEmp.CurrentRow.Cells(6).Value
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            Dim str As String = InputBox("Enter Employee Name")
            Dim dv As New DataView(ds.Tables("Emp"))
            dv.Sort = "EmpName Asc"
            dv.RowFilter = "EmpName like '%" & str & "%'"
            dgvEmp.DataSource = dv
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub navigate()
        Try
            If ds.Tables("Emp").Rows.Count > 0 Then
                With ds.Tables("Emp").Rows(inc)
                    txtEmpNo.Text = .Item(0)
                    txtEmpName.Text = .Item(1)
                    txtSalary.Text = .Item(2)
                    cmbDeptName.SelectedValue = .Item(3)
                    dtpDate.Value = .Item(4)
                    txtMobNo.Text = .Item(6)
                End With
            Else
                ClearControls()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNav3_Click(sender As Object, e As EventArgs) Handles btnNav3.Click
        Try
            If inc < 0 Then
                MessageBox.Show("Empty Data set", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                inc = 0
                navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNav4_Click(sender As Object, e As EventArgs) Handles btnNav4.Click
        Try
            If inc < 0 Then
                MessageBox.Show("Empty Data set", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                inc = maxRow - 1
                navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNav1_Click(sender As Object, e As EventArgs) Handles btnNav1.Click
        Try
            If inc <= 0 Then
                MessageBox.Show("First Record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                inc -= 1
                navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNav2_Click(sender As Object, e As EventArgs) Handles btnNav2.Click
        Try
            If inc >= maxRow - 1 Then
                MessageBox.Show("Last Record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                inc += 1
                navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(dgvEmp)
    End Sub
End Class