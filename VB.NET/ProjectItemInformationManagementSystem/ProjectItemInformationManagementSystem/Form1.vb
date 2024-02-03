Imports System.Data.SqlClient
Imports System.Data
Public Class Form1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\dotnet\ProjectItemInformationManagementSystem\ProjectItemInformationManagementSystem\ItemDatabBase.mdf;Integrated Security=True")
    Dim ds As DataSet
    Dim maxRow As Integer
    Dim inc As Integer

    Sub GenerateItemNo()
        Dim cmd As New SqlCommand("Select max(ItemNo) from ItemMast", con)
        con.Open()
        If cmd.ExecuteScalar Is System.DBNull.Value Then
            txtNo.Text = 1
        Else
            txtNo.Text = cmd.ExecuteScalar + 1
        End If
        con.Close()
    End Sub
    Sub clearControls()
        txtNo.Text = ""
        txtName.Text = ""
        txtCost.Text = ""
        txtQuan.Text = ""
        GenerateItemNo()
        ButtonInsert.Enabled = True
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim cmd As New SqlCommand("Select ItemNo,ItemName from ItemMast where ItemName like @nm", con)
        cmd.Parameters.Add("@nm", SqlDbType.VarChar).Value = txtSearch.Text.ToString.ToUpper
        Dim dr As SqlDataReader 
        con.Open()
        dr = cmd.ExecuteReader
        If dr.Read Then
            ButtonDelete.Enabled = True
            MessageBox.Show("Item Found....Enter new Cost and Quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            txtNo.Text = dr.GetInt32(0)
            txtName.Text = dr.GetString(1)
            ButtonInsert.Enabled = False
        Else
            MessageBox.Show("Item Not Found....Insert New Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            txtName.Text = txtSearch.Text
            ButtonUpdate.Enabled = False
            txtCost.Focus()
        End If
        dr.Close()
        con.Close()
    End Sub
    Sub displayRecords()
        Dim cmd As New SqlCommand("Select * from ItemMast", con)
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Items")
        DataGridView1.DataSource = ds.Tables("Items")
        maxRow = ds.Tables("Items").Rows.Count
        inc = 0
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayRecords()
        GenerateItemNo()
    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        If txtNo.Text = "" And txtName.Text = "" And txtCost.Text = "" And txtQuan.Text = "" Then
            MessageBox.Show("Empty....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Else
            Dim cmd As New SqlCommand("Insert into ItemMast(ItemNo,ItemName,Cost,Quantity) Values(@no,@name,@cost,@quan)", con)
            cmd.Parameters.Add("@no", SqlDbType.Int).Value = CInt(txtNo.Text)
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text.ToString.ToUpper
            cmd.Parameters.Add("@cost", SqlDbType.Float).Value = CDec(txtCost.Text)
            cmd.Parameters.Add("@quan", SqlDbType.Int).Value = CInt(txtQuan.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            clearControls()
            displayRecords()
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If txtNo.Text = "" And txtName.Text = "" And txtCost.Text = "" And txtQuan.Text = "" Then
            MessageBox.Show("Empty....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Else
            Dim cmd As New SqlCommand("Update ItemMast set ItemNo = @no,ItemName = @name,Cost = @cost,Quantity = @quan where ItemNo = @no", con)
            cmd.Parameters.Add("@no", SqlDbType.Int).Value = CInt(txtNo.Text)
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text.ToString.ToUpper
            cmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = CDec(txtCost.Text)
            cmd.Parameters.Add("@quan", SqlDbType.Int).Value = CInt(txtQuan.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            clearControls()
            displayRecords()
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If txtNo.Text = "" And txtName.Text = "" And txtCost.Text = "" And txtQuan.Text = "" Then
            MessageBox.Show("Empty....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Else
            Dim cmd As New SqlCommand("Delete from ItemMast where ItemNo = @no", con)
            cmd.Parameters.Add("@no", SqlDbType.Int).Value = CInt(txtNo.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            clearControls()
            displayRecords()
        End If
    End Sub

    Sub navigate()
        If ds.Tables("Items").Rows.Count > 0 Then
            With ds.Tables("Items").Rows(inc)
                txtNo.Text = .Item(0)
                txtName.Text = .Item(1)
                txtCost.Text = .Item(2)
                txtQuan.Text = .Item(3)
            End With
        Else
            clearControls()
        End If
    End Sub

    Private Sub ButtonFirst_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click
        If inc < 0 Then
            MessageBox.Show("Item Not Found....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            inc = 0
            navigate()
        End If
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        If inc <= 0 Then
            MessageBox.Show("First Record....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            inc -= 1
            navigate()
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        If inc >= maxRow - 1 Then
            MessageBox.Show("Last Record....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            inc += 1
            navigate()
        End If
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
        If inc < 0 Then
            MessageBox.Show("Item Not Found....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        Else
            inc = maxRow - 1
            navigate()
        End If
    End Sub

    Private Sub ButtonAsc_Click(sender As Object, e As EventArgs) Handles ButtonAsc.Click
        Dim dv As New DataView(ds.Tables("Items"))
        dv.Sort = "ItemName Asc"
        DataGridView1.DataSource = dv
    End Sub

    Private Sub ButtonDesc_Click(sender As Object, e As EventArgs) Handles ButtonDesc.Click
        Dim dv As New DataView(ds.Tables("Items"))
        dv.Sort = "ItemName Desc"
        DataGridView1.DataSource = dv
    End Sub

    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click
        Dim cmd As New SqlCommand("Select * from ItemMast where Quantity = 0", con)
        Dim da As New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Items")
        DataGridView1.DataSource = ds.Tables("Items")
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtNo.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtName.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtCost.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtQuan.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub
End Class
