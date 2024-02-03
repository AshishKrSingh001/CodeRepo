Public Class Form1
    Dim email As String = "ashish@123"
    Dim pass As String = "ashish123"
    Dim email1 As String
    Dim pass1 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        email1 = TextBox1.Text
        pass1 = TextBox2.Text
        If email = email1 Then
            If pass = pass1 Then
                MessageBox.Show("Login Successfully", "Answer", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Password is incorrect")
            End If
        Else
            MessageBox.Show("Username not found")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
