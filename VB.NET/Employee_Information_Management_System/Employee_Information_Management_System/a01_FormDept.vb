Imports System.Data.SqlClient

Public Class a01_FormDept
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Dim maxRow As Integer = 0
    Dim inc As Integer = 0
    Sub displayRecords()
        'Dim rnd As New Form_Round(Me)
        Try
            Dim cmd As New SqlCommand("Select * from DeptTable", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Dept")
            DataGridView1.DataSource = ds.Tables("Dept")

            With DataGridView1.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Black
                .ForeColor = Color.White
                .Font = New Font(DataGridView1.Font, FontStyle.Bold)
            End With

            DataGridView1.EnableHeadersVisualStyles = False
            With DataGridView1
                .RowHeadersVisible = False
                .Columns(0).HeaderCell.Value = "Department No"
                .Columns(1).HeaderCell.Value = "Department Name"
                .Columns(2).HeaderCell.Value = "Location"
            End With
            inc = 0
            maxRow = ds.Tables("Dept").Rows.Count
            With ds.Tables("Dept").Rows(maxRow - 1)
                txtDeptNo.Text = (CInt(.Item(0)) + 1)
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub clearControls()
        txtDeptNo.Text = ""
        txtDeptName.Text = ""
        txtLocation.Text = ""
        inc = 0
        txtDeptNo.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearControls()
    End Sub

    Private Function isEmpty() As Boolean
        If txtDeptNo.Text = "" And txtDeptName.Text = "" And txtLocation.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If isEmpty() = False Then
            Try
                Dim cmd As New SqlCommand("Insert into DeptTable(DptNo,DptName,Location) values(@dNo,@dName,@Location)", con)
                cmd.Parameters.Add("@dNo", SqlDbType.Int).Value = CInt(txtDeptNo.Text)
                cmd.Parameters.Add("@dName", SqlDbType.VarChar).Value = txtDeptName.Text
                cmd.Parameters.Add("@Location", SqlDbType.VarChar).Value = txtLocation.Text
                con.Open()
                Dim flag As Integer = 0
                flag = cmd.ExecuteNonQuery()
                con.Close()
                If flag > 0 Then
                    MessageBox.Show("Record Inserted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    clearControls()
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

    Private Sub FormDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayRecords()
        txtDeptNo.Focus()
    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        clearControls()
        displayRecords()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtDeptNo.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtDeptName.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtLocation.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If isEmpty() = False Then
            Try
                Dim cmd As New SqlCommand("Delete from DeptTable Where DeptTable.DptNo=@DNo", con)
                cmd.Parameters.Add("@DNo", SqlDbType.Int).Value = CInt(txtDeptNo.Text)
                Dim flag As Integer = 0
                con.Open()
                flag = cmd.ExecuteNonQuery()
                con.Close()
                If flag > 0 Then
                    MessageBox.Show("Record is Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    clearControls()
                    displayRecords()
                Else
                    MessageBox.Show("Something went Wrong ....Record is not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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
                Dim cmd As New SqlCommand("Update DeptTable set DptNo=@DNo,DptName=@DName,Location=@Location where DptNo=@DNo", con)
                cmd.Parameters.Add("@DNo", SqlDbType.Int).Value = CInt(txtDeptNo.Text)
                cmd.Parameters.Add("@DName", SqlDbType.VarChar).Value = txtDeptName.Text
                cmd.Parameters.Add("@Location", SqlDbType.VarChar).Value = txtLocation.Text
                Dim flag As Integer = 0
                con.Open()
                flag = cmd.ExecuteNonQuery()
                con.Close()
                If flag > 0 Then
                    MessageBox.Show("Record Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    clearControls()
                    displayRecords()
                Else
                    MessageBox.Show("Something went wrong in updating", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            Dim str As String = InputBox("Enter Department Name : ")
            Dim dv As New DataView(ds.Tables("Dept"))
            dv.Sort = "DptName asc"
            dv.RowFilter = "DptName Like'%" & str & "%' "
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Navigate()
        Try
            If ds.Tables("Dept").Rows.Count > 0 Then
                With ds.Tables("Dept").Rows(inc)
                    txtDeptNo.Text = .Item(0)
                    txtDeptName.Text = .Item(1)
                    txtLocation.Text = .Item(2)
                End With
            Else
                clearControls()
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
                Navigate()
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
                Navigate()
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
                Navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNav4_Click(sender As Object, e As EventArgs) Handles btnNav4.Click
        Try
            If inc < 0 Then
                MessageBox.Show("Empty Record", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                inc = maxRow - 1
                Navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAsc_Click(sender As Object, e As EventArgs) Handles btnAsc.Click
        Try
            Dim dv As New DataView(ds.Tables("Dept"))
            dv.Sort = "DptName asc"
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDes_Click(sender As Object, e As EventArgs) Handles btnDes.Click
        Try
            Dim dv As New DataView(ds.Tables("Dept"))
            dv.Sort = "DptName desc"
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Dim ete As New Export_to_Excel(DataGridView1)
    End Sub
End Class