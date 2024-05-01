Imports System.Data.SqlClient

Public Class UserSIgnIn
    Public user As String
    Dim con As New SqlConnection(Form1.conString)

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtUname.Text = ""
        txtPasswd.Text = ""
        CheckBox1.Checked = False
        txtUname.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPasswd.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub UserSIgnIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rnd As New Form_Round(Me)
        txtPasswd.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            user = txtUname.Text.ToString.Trim
            Dim cmd As New SqlCommand("Select count(*) from EmpTable Where Email = @uname and password = @passwd", con)
            cmd.Parameters.Add("@uname", SqlDbType.VarChar).Value = user
            cmd.Parameters.Add("@passwd", SqlDbType.VarChar).Value = txtPasswd.Text.ToString.Trim
            con.Open()
            Dim Count As Integer = 0
            Count = cmd.ExecuteScalar()
            If Count = 0 Then
                MessageBox.Show("Employee Doesn't found in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUname.Focus()
            Else
                Me.Close()
                MessageBox.Show("Login Successfully", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

End Class