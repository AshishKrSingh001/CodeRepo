Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If CInt(TextBox1.Text) < 1 And CInt(TextBox1.Text) > 15 Then
                ErrorProvider1.SetError(TextBox1, "Number Should be In between 1 To 15")
            End If
        Catch ex As Exception
            ErrorProvider1.SetError(TextBox1, ex.Message)
        End Try
    End Sub
End Class
