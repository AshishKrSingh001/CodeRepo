Public Class Form1
    Public Function genrateRandomNumberFun(initial As Integer, final As Integer) As Integer
        Dim ran As New Random
        Dim rNumber As Integer = ran.Next(initial, final)
        'Return rNumber
        genrateRandomNumberFun = rNumber
    End Function
    Public Sub genrateRandomNumberSub(ByRef rNumber As Integer)
        Dim ran As New Random
        rNumber = ran.Next(CInt(txtInitial.Text), CInt(txtxFinal.Text))
    End Sub

    Private Sub btnfun_Click(sender As Object, e As EventArgs) Handles btnfun.Click
        Dim rNumber As Integer = 0
        genrateRandomNumberSub(rNumber)
        MessageBox.Show("By Sub-Routine Generated Random Number is : " & rNumber, "Random Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        Dim rNumber As Integer = genrateRandomNumberFun(CInt(txtInitial.Text), CInt(txtxFinal.Text))
        MessageBox.Show("By Function Generated Random Number is : " & rNumber, "Random Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
