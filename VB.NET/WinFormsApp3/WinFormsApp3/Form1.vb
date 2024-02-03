Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = InputBox("Enter you name: ", "Name ", "Your name ", 100, 100)
        Dim res As DialogResult = MessageBox.Show(str, "Your name ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show(str)
        Else
            MessageBox.Show("No value")
        End If
    End Sub
End Class
