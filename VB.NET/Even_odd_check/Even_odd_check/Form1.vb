Public Class Form1
    Dim number1 As Double
    Dim number2 As Double
    Dim result As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        number1 = TextBox1.Text
        number2 = TextBox2.Text
        result = number1 + number2
        MessageBox.Show(result)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        number1 = TextBox1.Text
        number2 = TextBox2.Text
        result = number1 - number2
        MessageBox.Show(result)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        number1 = TextBox1.Text
        number2 = TextBox2.Text
        result = number1 / number2
        MessageBox.Show(result)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        number1 = TextBox1.Text
        number2 = TextBox2.Text
        result = number1 * number2
        MessageBox.Show(result)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class
