Imports System.Data.SqlClient
Imports System.Data
Imports System.Reflection.Metadata

Public Class Form1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectVehicleServiceInformation\ProjectVehicleServiceInformation\VehicleService.mdf;Integrated Security=True")
    Dim ds As DataSet
    Dim inc As Integer = 0
    Dim maxRow As Integer = 0
    Sub DisplayRecords()
        Try
            Dim cmd As New SqlCommand("Select * from Service", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Service")
            DataGridView1.DataSource = ds.Tables("Service")
            maxRow = ds.Tables("Service").Rows.Count
            txtSNo.Text = (CInt(ds.Tables("Service").Rows(maxRow - 1).Item(0) + 1)).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Sub ClearControls()
        txtSNo.Text = ""
        TxtVNo.Text = ""
        TextBox1.Text = ""
        EDate.Value = Now.Date
        DDate.Value = Now.Date
        lbJob.SelectedIndex = -1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        DisplayRecords()
    End Sub
    Function ISNotFilled()
        If txtSNo.Text = "" Then
            txtSNo.Focus()
            Return False
        ElseIf TxtVNo.Text = "" Then
            TxtVNo.Focus()
            Return False
        ElseIf TextBox1.Text = "" Then
            TextBox1.Focus()
            Return False
        ElseIf lbJob.SelectedIndex = -1 Then
            lbJob.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If txtSNo.Text = "" Then
            txtSNo.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("Delete from Service where ServiceNo = @sno", con)
                cmd.Parameters.Add("@sno", SqlDbType.Int).Value = CInt(txtSNo.Text)
                con.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Finally
                con.Close()
                ClearControls()
                DisplayRecords()
            End Try
        End If
    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        If ISNotFilled() Then
            Try
                Dim cmd As New SqlCommand("Insert into Service(ServiceNo,VehicleNo,Attend,Type_Of_Job,JobDescription,EntryDate,DeliveryDate) Values(@sno,@vno,@attend,@toj,@jd,@ed,@dd)", con)
                cmd.Parameters.Add("@sno", SqlDbType.Int).Value = txtSNo.Text()
                cmd.Parameters.Add("@vno", SqlDbType.Int).Value = TxtVNo.Text()
                If CheckedBox.Checked Then
                    cmd.Parameters.Add("@attend", SqlDbType.VarChar).Value = "Yes"
                Else
                    cmd.Parameters.Add("@attend", SqlDbType.VarChar).Value = "No"
                End If
                cmd.Parameters.Add("@toj", SqlDbType.VarChar).Value = lbJob.Text
                cmd.Parameters.Add("@jd", SqlDbType.Text).Value = TextBox1.Text
                cmd.Parameters.Add("@ed", SqlDbType.Date).Value = EDate.Value
                cmd.Parameters.Add("@dd", SqlDbType.Date).Value = DDate.Value
                con.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Finally
                con.Close()
                ClearControls()
                DisplayRecords()
            End Try
        End If


    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If ISNotFilled() Then
            Try
                Dim cmd As New SqlCommand("Update Service set ServiceNo=@sno,VehicleNo=@vno,Attend=@attend,Type_Of_Job=@toj,JobDescription=@jd,EntryDate=@ed,DeliveryDate=@dd where ServiceNo = @sno", con)
                cmd.Parameters.Add("@sno", SqlDbType.Int).Value = txtSNo.Text()
                cmd.Parameters.Add("@vno", SqlDbType.Int).Value = TxtVNo.Text()
                If CheckedBox.Checked Then
                    cmd.Parameters.Add("@attend", SqlDbType.VarChar).Value = "Yes"
                Else
                    cmd.Parameters.Add("@attend", SqlDbType.VarChar).Value = "No"
                End If
                cmd.Parameters.Add("@toj", SqlDbType.VarChar).Value = lbJob.Text
                cmd.Parameters.Add("@jd", SqlDbType.Text).Value = TextBox1.Text
                cmd.Parameters.Add("@ed", SqlDbType.Date).Value = EDate.Value
                cmd.Parameters.Add("@dd", SqlDbType.Date).Value = DDate.Value
                con.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Finally
                con.Close()
                ClearControls()
                DisplayRecords()
            End Try
        End If
    End Sub

    Private Sub DataGridView1_Cell_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtSNo.Text = DataGridView1.CurrentRow.Cells(0).Value
        TxtVNo.Text = DataGridView1.CurrentRow.Cells(1).Value
        If DataGridView1.CurrentRow.Cells(2).Value = "Yes" Then
            CheckedBox.Checked = True
        ElseIf DataGridView1.CurrentRow.Cells(2).Value = "No" Then
            CheckedBox.Checked = False
        Else
            CheckedBox.Checked = False
        End If
        lbJob.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(4).Value
        EDate.Value = DataGridView1.CurrentRow.Cells(5).Value
        DDate.Value = DataGridView1.CurrentRow.Cells(6).Value
    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click

    End Sub

    Sub Navigate()
        If ds.Tables("Service").Rows.Count > 0 Then
            With ds.Tables("Service").Rows(inc)
                txtSNo.Text = .Item(0)
                TxtVNo.Text = .Item(1)
                If .Item(2) = "Yes" Then
                    CheckedBox.Checked = True
                ElseIf .item(2) = "No" Then
                    CheckedBox.Checked = False
                Else
                    CheckedBox.Checked = False
                End If
                lbJob.Text = .Item(3)
                TextBox1.Text = .Item(4)
                EDate.Value = .Item(5)
                DDate.Value = .Item(6)
            End With
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If inc < 0 Then
                MessageBox.Show("Empty DataSet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Else
                inc = 0
                Navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If inc < 0 Then
                MessageBox.Show("EmptyDataset", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Else
                inc = maxRow - 1
                Navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If inc <= 0 Then
                MessageBox.Show("First Record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Else
                inc = -1
                Navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If inc >= maxRow - 1 Then
                MessageBox.Show("Last Record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Else
                inc += 1
                Navigate()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub ButtonService_Click(sender As Object, e As EventArgs) Handles ButtonService.Click
        Try
            Dim cmd As New SqlCommand("Select * from Service where Attend = 'No' and Type_Of_Job = 'Service'", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Service")
            DataGridView1.DataSource = ds.Tables("Service")
            maxRow = ds.Tables("Service").Rows.Count
            txtSNo.Text = (CInt(ds.Tables("Service").Rows(maxRow - 1).Item(0) + 1)).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub ButtonColor_Click(sender As Object, e As EventArgs) Handles ButtonColor.Click
        Try
            Dim cmd As New SqlCommand("Select * from Service where Attend = 'No' and Type_Of_Job = 'Color'", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Service")
            DataGridView1.DataSource = ds.Tables("Service")
            maxRow = ds.Tables("Service").Rows.Count
            txtSNo.Text = (CInt(ds.Tables("Service").Rows(maxRow - 1).Item(0) + 1)).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub ButtonAccident_Click(sender As Object, e As EventArgs) Handles ButtonAccident.Click
        Try
            Dim cmd As New SqlCommand("Select * from Service where Attend = 'No' and Type_Of_Job = 'Accident'", con)
            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Service")
            DataGridView1.DataSource = ds.Tables("Service")
            maxRow = ds.Tables("Service").Rows.Count
            txtSNo.Text = (CInt(ds.Tables("Service").Rows(maxRow - 1).Item(0) + 1)).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClearControls()
        DisplayRecords()
    End Sub
End Class
