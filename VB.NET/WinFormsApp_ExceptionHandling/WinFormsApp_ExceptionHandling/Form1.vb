Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim num1 As Integer = CInt(TextBox1.Text)
            Dim num2 As Integer = CInt(TextBox2.Text)
            MessageBox.Show(num1 Mod num2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MessageBox.Show("Hello")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Try
            num1 = CInt(TextBox1.Text)
            num2 = CInt(TextBox2.Text)
            MessageBox.Show(num1 Mod num2)
        Catch When Err.Number = 11
            MessageBox.Show("Error Occur")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If CInt(TextBox1.Text()) > 18 Then
                If CInt(TextBox2.Text()) < 60 Then
                    MessageBox.Show("Hey")
                Else
                    Throw New ApplicationException("Invalid Input2")
                End If
            Else
                Throw New ApplicationException("Invalid Input1")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MessageBox.Show("Hello")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim num1 As Integer = CInt(TextBox1.Text)
            Dim num2 As Integer = CInt(TextBox2.Text)
            MessageBox.Show(num1 Mod num2)
        Catch ex As DivideByZeroException
            MessageBox.Show(ex.Message)
        Finally
            MessageBox.Show("Hello")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Try
            num1 = CInt(TextBox1.Text)
            num2 = CInt(TextBox2.Text)
            MessageBox.Show(num1 Mod num2)
        Catch When num2 = 0
            MessageBox.Show("Num2 is Equal to Zero")
        Finally
            MessageBox.Show("Hello")
        End Try
    End Sub
End Class
