Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = "Reverse of " & TextBox1.Text & " is : " & Calculate.ReverseString(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label9.Text = "Simple Interest : " & Calculate.findSimpleInterest(CInt(TextBox2.Text), CInt(TextBox3.Text), CInt(TextBox4.Text))
    End Sub
End Class
