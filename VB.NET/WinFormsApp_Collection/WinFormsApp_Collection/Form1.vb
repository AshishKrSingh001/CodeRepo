Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emp As New Collection
        emp.Add("Ashish Kumar Singh", "Name")
        emp.Add(13089, "Id")
        emp.Add(33, "RollNo")
        emp.Add("BCA", "Course")
        For Each element As Object In emp
            MessageBox.Show(element.ToString())
        Next
    End Sub
End Class
