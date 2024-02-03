Public Class Form1
    Sub AddItem(ParamArray Name() As String)
        Dim x As Object
        For Each x In Name
            ListView1.Items().Add(x & vbCrLf)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddItem("Delhi", "Mumbai", "Patna", "Kolkata")
        MessageBox.Show("Added Successfully")
    End Sub

    Dim num() As Integer = {}
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReDim Preserve num(num.Length + 1)
        num(num.Count - 1) = CInt(TextBox1.Text)
        TextBox1.Text = ""
    End Sub

    Function addition(ParamArray NumArray() As Integer)
        Dim sum As Integer = 0
        For Each n In NumArray
            sum = sum + n
        Next
        Return sum
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show(addition(num).ToString())
    End Sub
End Class
