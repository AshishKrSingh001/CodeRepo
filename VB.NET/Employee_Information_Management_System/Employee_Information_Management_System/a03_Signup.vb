Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class a03_Signup
    Dim con As New SqlConnection(Form1.conString)
    Dim ds As DataSet
    Dim inc As Integer = 0
    Dim maxRow As Integer = 0

    Sub ClearControls()
        txtNo.Text = ""
        txtPassword.Text = ""
        txtcPassword.Text = ""
        txtEmail.Text = ""
        CheckBox1.Checked = False

    End Sub
    Function ValidatePassword(ByVal pwd As String, Optional ByVal minLength As Integer = 8, Optional ByVal numUpper As Integer = 2, Optional ByVal numLower As Integer = 2, Optional ByVal numNumbers As Integer = 2, Optional ByVal numSpecial As Integer = 2) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function
    Private Function isEmpty() As Boolean
        If txtNo.Text = "" And txtPassword.Text = "" And txtEmail.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim rnd As New Form_Round(Me)
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim pwd As String = txtPassword.Text
        If ValidatePassword(pwd, 8, 1, 1, 1) Then
            If txtcPassword.Text <> pwd Then
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
                        Else
                            MessageBox.Show("Something went wrong.....Record not Inserted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        End If
                        ClearControls()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()
                End Try

            End If
        Else
            MessageBox.Show("Password Should contain atleast 8 Character which consists of Lowercase, Uppercase, Number, SpecialChars etc  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearControls()
    End Sub
End Class