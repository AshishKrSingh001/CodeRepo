﻿Imports System.Data.SqlClient

Public Class rptEmailandMobileNo
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Private Sub rptEmailandMobileNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New SqlCommand("Select EmpNo,EmpName,Email,MobNo from EmpTable", con)
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
                .Columns(2).HeaderCell.Value = "Email"
                .Columns(3).HeaderCell.Value = "Mobile No"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class