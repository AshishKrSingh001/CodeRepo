Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class a02_FormEmployee
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Dim inc As Integer = 0
    Dim maxRow As Integer = 0
    Dim gen As String = ""
    Dim marry As String = ""
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbsame.CheckedChanged
        If cbsame.Checked = True Then
            txtpAdd.Text = txtcAdd.Text
        Else
            txtpAdd.Text = ""
        End If
    End Sub
    Sub displayRecords()
        Try
            Dim cmd As New SqlCommand("SELECT EmpTable.EmpNo, EmpTable.EmpName, EmpTable.Salary, DeptTable.DptName, EmpTable.Date_OJ, EmpTable.Email, EmpTable.MobNo, EmpTable.DOB, EmpTable.Gender, EmpTable.MaritalStatus, EmpTable.BloodGroup, EmpTable.CorrospondenceAddress, EmpTable.PermanentAddress FROM EmpTable INNER JOIN DeptTable ON EmpTable.DptNo = DeptTable.DptNo ", con)
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
                .Columns(3).HeaderCell.Value = "Department Name"
                .Columns(4).HeaderCell.Value = "Date of Joining"
                .Columns(5).HeaderCell.Value = "Email"
                .Columns(6).HeaderCell.Value = "Mobile No"
                .Columns(7).HeaderCell.Value = "Date of Birth"
                .Columns(8).HeaderCell.Value = "Gender"
                .Columns(9).HeaderCell.Value = "Marital Status"
                .Columns(10).HeaderCell.Value = "Blood Group"
                .Columns(11).HeaderCell.Value = "Corrospondence Address"
                .Columns(12).HeaderCell.Value = "Permanent Address"
                .Columns(0).FillWeight = 40
                .Columns(1).FillWeight = 80
                .Columns(2).FillWeight = 40
                .Columns(3).FillWeight = 90
                .Columns(4).FillWeight = 60
                .Columns(5).FillWeight = 100
                .Columns(6).FillWeight = 60
                .Columns(7).FillWeight = 70
                .Columns(8).FillWeight = 40
                .Columns(9).FillWeight = 60
                .Columns(10).FillWeight = 40
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
        dtpDob.Value = New Date(1995, 1, 1)
        dtpDob.MaxDate = New Date(2010, 1, 1)
        dtpDate.MaxDate = DateTime.Now.Date
        rbMale.Checked = False
        rbFemale.Checked = False
        rbo.Checked = False
        rbM.Checked = False
        rbUnM.Checked = False
        txtpAdd.Clear()
        txtcAdd.Clear()
        cbsame.Checked = False
        txtEmpNo.Focus()

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
        txtEmpNo.Focus()
    End Sub



    Private Function isEmpty() As Boolean
        If txtEmpNo.Text = "" And txtEmpName.Text = "" And txtSalary.Text = "" And txtMobNo.Text = "" And txtcAdd.Text = "" Then
            If rbFemale.Checked = False And rbMale.Checked = False And rbo.Checked = False Then
                If rbM.Checked = False And rbUnM.Checked = False Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
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
    Sub radioValue()
        If rbMale.Checked = True Then
            gen = "Male"
        ElseIf rbFemale.Checked = True Then
            gen = "Female"
        ElseIf rbo.Checked = True Then
            gen = "Other"
        End If
        If rbM.Checked = True Then
            marry = "Married"
        ElseIf rbUnM.Checked = True Then
            marry = "Unmarried"
        End If
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If isEmpty() = False Then
            radioValue()
            Try
                Dim cmd As New SqlCommand("Insert into EmpTable(EmpNo,EmpName,Salary,DptNo,Date_Oj,Email,MobNo,DOB,Gender,MaritalStatus,BloodGroup,CorrospondenceAddress,PermanentAddress) values(@Empno,@Empname,@salary,@DptNo,@doj,@email,@mob,@dob,@gen,@ms,@bgroup,@ca,@pa)", con)
                cmd.Parameters.Clear()
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = CInt(txtEmpNo.Text)
                cmd.Parameters.Add("@Empname", SqlDbType.VarChar).Value = txtEmpName.Text
                cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = CDec(txtSalary.Text)
                cmd.Parameters.Add("@DptNo", SqlDbType.Int).Value = CInt(cmbDeptName.SelectedValue)
                cmd.Parameters.Add("@doj", SqlDbType.Date).Value = dtpDate.Value
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = GenerateEmail(txtEmpName.Text, CInt(txtEmpNo.Text))
                cmd.Parameters.Add("@mob", SqlDbType.VarChar).Value = txtMobNo.Text
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = dtpDob.Value
                cmd.Parameters.Add("@gen", SqlDbType.VarChar).Value = gen
                cmd.Parameters.Add("@ms", SqlDbType.VarChar).Value = marry
                cmd.Parameters.Add("@bgroup", SqlDbType.VarChar).Value = cmbBlood.Text
                cmd.Parameters.Add("@ca", SqlDbType.VarChar).Value = txtcAdd.Text
                cmd.Parameters.Add("@pa", SqlDbType.VarChar).Value = txtpAdd.Text
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
                radioValue()
                Dim cmd As New SqlCommand("Update EmpTable set EmpNo=@Empno,EmpName=@Empname,Salary=@salary,DptNo=@DptNo,Date_Oj=@doj,MobNo = @mob,DOB = @dob,Gender = @gen,MaritalStatus = @ms,BloodGroup = @bgroup,CorrospondenceAddress = @ca,PermanentAddress = @pa where EmpNo = @Empno", con)
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = CInt(txtEmpNo.Text)
                cmd.Parameters.Add("@Empname", SqlDbType.VarChar).Value = txtEmpName.Text
                cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = CDec(txtSalary.Text)
                cmd.Parameters.Add("@DptNo", SqlDbType.Int).Value = CInt(cmbDeptName.SelectedValue)
                cmd.Parameters.Add("@doj", SqlDbType.Date).Value = dtpDate.Value
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = GenerateEmail(txtEmpName.Text, CInt(txtEmpNo.Text))
                cmd.Parameters.Add("@mob", SqlDbType.VarChar).Value = txtMobNo.Text
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = dtpDob.Value
                cmd.Parameters.Add("@gen", SqlDbType.VarChar).Value = gen
                cmd.Parameters.Add("@ms", SqlDbType.VarChar).Value = marry
                cmd.Parameters.Add("@bgroup", SqlDbType.VarChar).Value = cmbBlood.Text
                cmd.Parameters.Add("@ca", SqlDbType.VarChar).Value = txtcAdd.Text
                cmd.Parameters.Add("@pa", SqlDbType.VarChar).Value = txtpAdd.Text
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
        dtpDate.Value = dgvEmp.CurrentRow.Cells(7).Value
        If dgvEmp.CurrentRow.Cells(8).Value = "Male" Then
            rbMale.Checked = True
        ElseIf dgvEmp.CurrentRow.Cells(8).Value = "Female" Then
            rbFemale.Checked = True
        ElseIf dgvEmp.CurrentRow.Cells(8).Value = "Other" Then
            rbo.Checked = True
        End If
        If dgvEmp.CurrentRow.Cells(9).Value = "Married" Then
            rbM.Checked = True
        ElseIf dgvEmp.CurrentRow.Cells(9).Value = "Unmarried" Then
            rbUnM.Checked = True
        End If
        cmbBlood.Text = dgvEmp.CurrentRow.Cells(10).Value
        txtcAdd.Text = dgvEmp.CurrentRow.Cells(11).Value
        txtpAdd.Text = dgvEmp.CurrentRow.Cells(12).Value
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
                    dtpDate.Value = .Item(7)
                    If .Item(8) = "Male" Then
                        rbMale.Checked = True
                    ElseIf .Item(8) = "Female" Then
                        rbFemale.Checked = True
                    ElseIf .Item(8) = "Other" Then
                        rbo.Checked = True
                    End If
                    If .Item(9) = "Married" Then
                        rbM.Checked = True
                    ElseIf .Item(9) = "Unmarried" Then
                        rbUnM.Checked = True
                    End If
                    cmbBlood.SelectedValue = .Item(10)
                    txtcAdd.Text = .Item(11)
                    txtpAdd.Text = .Item(12)
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