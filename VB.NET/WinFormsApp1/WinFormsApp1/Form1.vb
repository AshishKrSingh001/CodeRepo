Public Class Form1
    Dim msg As String = "This is VB.net program"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(msg)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "1" Then
            Label1.Text = "Hindi"
        End If
        If TextBox1.Text = "2" Then
            Label1.Text = "English"
        End If
        If TextBox1.Text = "3" Then
            Label1.Text = "Bhojpuri"
        End If
        If TextBox1.Text = "4" Then
            Label1.Text = "Maithili"
        End If
        If TextBox1.Text = "5" Then
            Label1.Text = "Maghi"
        End If
    End Sub
End Class
