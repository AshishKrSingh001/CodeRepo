Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iArray(5) As Integer
        Dim sArray(5) As String
        Dim oArray(2) As Object

        'Assining value to Integer Array
        iArray(0) = 13089
        iArray(1) = 13088
        iArray(2) = 12581
        iArray(3) = 15051
        iArray(4) = 14333
        iArray(5) = 12305

        'Displaying Integer Array
        For i As Integer = 0 To 5
            MessageBox.Show(iArray(5))
        Next

        'Assining value to String Array
        sArray(0) = "Ashish"
        sArray(1) = "Anish"
        sArray(2) = "Aditya"
        sArray(3) = "Anshu"
        sArray(4) = "Abhishek"
        sArray(5) = "Anirudh"

        'Displaying Integer Array
        For i As Integer = 0 To 5
            MessageBox.Show(sArray(5))
        Next

        oArray(0) = iArray
        oArray(1) = sArray

        'Displaying Integer Array
        MessageBox.Show(oArray(0)(5))

    End Sub
End Class
