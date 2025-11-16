Public Class Form1
    Dim p As String = ""
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "a" And e.KeyChar <= "z") Then
            p = p + e.KeyChar
            e.KeyChar = "*"
            e.Handled = False
        ElseIf Asc(e.KeyChar) = Keys.Back Then
            p = Mid(p, 1, p.Length - 1)
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Your Password is : " & p, "Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub





End Class
