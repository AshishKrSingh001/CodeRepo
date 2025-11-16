Public Class Form1
    Dim num As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles rod.Click
        num = TextBox1.Text
        Dim rev As Double = 0
        Dim d As Integer
        If num > 0 Then
            While num > 0
                d = num Mod 10
                rev = rev * 10 + d
                num = num \ 10
            End While
        Else
            num = 0 - num
            While num > 0
                d = num Mod 10
                rev = rev * 10 + d
                num = num \ 10
            End While
            rev = 0 - rev
        End If
        MessageBox.Show(rev)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles mood.Click
        num = TextBox1.Text
        Dim mult As Double = 1
        Dim d As Integer
        If num > 0 Then
            While num > 0
                d = num Mod 10
                mult = mult * d
                num = num \ 10
            End While
        Else
            num = 0 - num
            While num > 0
                d = num Mod 10
                mult = mult * d
                num = num \ 10
            End While
        End If
        MessageBox.Show(mult)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sod.Click
        num = TextBox1.Text
        Dim sum As Double = 0
        Dim d As Integer
        If num > 0 Then
            While num > 0
                d = num Mod 10
                sum = sum + d
                num = num \ 10
            End While
        Else
            num = 0 - num
            While num > 0
                d = num Mod 10
                sum = sum + d
                num = num \ 10
            End While
            sum = 0 - sum
        End If
        MessageBox.Show(sum)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles sc.Click
        num = TextBox1.Text
        If num > 0 Then
            MessageBox.Show("Positive number")
        Else
            MessageBox.Show("Negative number")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles eoc.Click
        num = TextBox1.Text
        If num Mod 2 = 0 Then
            MessageBox.Show("Even number")
        Else
            MessageBox.Show("Odd number")
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles pcc.Click
        num = TextBox1.Text
        Dim count As Integer = 0
        For index As Integer = 2 To num \ 2
            If num Mod index = 0 Then
                count = count + 1
            End If
        Next
        If count = 0 Then
            MessageBox.Show("prime number")
        Else
            MessageBox.Show("composite number")
        End If
    End Sub

    Private Sub pc_Click(sender As Object, e As EventArgs) Handles pc.Click
        num = TextBox1.Text
        Dim rev As Double = 0
        Dim num2 As Double
        Dim d As Integer
        If num > 0 Then
            num2 = num
            While num > 0
                d = num Mod 10
                rev = rev * 10 + d
                num = num \ 10
            End While
        Else
            num = 0 - num
            num2 = num
            While num > 0
                d = num Mod 10
                rev = rev * 10 + d
                num = num \ 10
            End While
            rev = 0 - rev
        End If
        If rev = num2 Then
            MessageBox.Show("Palindrome number")
        Else
            MessageBox.Show("Not Palindrome number")
        End If
    End Sub

    Private Sub resett_Click(sender As Object, e As EventArgs) Handles resett.Click
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Me.Close()
    End Sub
End Class
