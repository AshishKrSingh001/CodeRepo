Imports System.Runtime.ConstrainedExecution

Public Class marksDetails
    Private Sub tsub1_TextChanged(sender As Object, e As EventArgs) Handles tsub1.TextChanged
        If tsub1.Text = "" Then
            ProgressBar1.Value = 0
        Else
            Dim m As Integer = CInt(tsub1.Text)
            If (m > 100 Or m < 0) Then
                ErrorProvider1.SetError(tsub1, "Marks must be in between 0 to 100!")
            Else
                ErrorProvider1.Clear()
                If (m <= 40 And m >= 0) Then
                    ProgressBar1.ForeColor = Color.Red
                ElseIf (m <= 75 And m > 40) Then
                    ProgressBar1.ForeColor = Color.Blue
                ElseIf (m <= 100 And m > 75) Then
                    ProgressBar1.ForeColor = Color.Green
                End If
                ProgressBar1.Value = m
            End If
        End If
    End Sub

    Private Sub tsub2_TextChanged(sender As Object, e As EventArgs) Handles tsub2.TextChanged
        If tsub2.Text = "" Then
            ProgressBar2.Value = 0
        Else
            Dim m As Integer = CInt(tsub2.Text)
            If m > 100 Or m < 0 Then
                ErrorProvider1.SetError(tsub2, "Marks must be in between 0 to 100!")
            Else
                ErrorProvider1.Clear()
                If m <= 40 And m >= 0 Then
                    ProgressBar2.ForeColor = Color.Red
                ElseIf m <= 75 And m > 40 Then
                    ProgressBar2.ForeColor = Color.Blue
                ElseIf m <= 100 And m >= 75 Then
                    ProgressBar2.ForeColor = Color.Green
                End If
                ProgressBar2.Value = m
            End If
        End If
    End Sub

    Private Sub tsub3_TextChanged(sender As Object, e As EventArgs) Handles tsub3.TextChanged
        If tsub3.Text = "" Then
            ProgressBar3.Value = 0
        Else
            Dim m As Integer = CInt(tsub3.Text)
            If m > 100 Or m < 0 Then
                ErrorProvider1.SetError(tsub3, "Marks must be in between 0 to 100!")
            Else
                ErrorProvider1.Clear()
                If m <= 40 And m >= 0 Then
                    ProgressBar3.ForeColor = Color.Red
                ElseIf m <= 75 And m > 40 Then
                    ProgressBar3.ForeColor = Color.Blue
                ElseIf m <= 100 And m >= 75 Then
                    ProgressBar3.ForeColor = Color.Green
                End If
                ProgressBar3.Value = m
            End If
        End If
    End Sub

    Private Sub tsub4_TextChanged(sender As Object, e As EventArgs) Handles tsub4.TextChanged
        If tsub4.Text = "" Then
            ProgressBar4.Value = 0
        Else
            Dim m As Integer = CInt(tsub4.Text)
            If m > 100 Or m < 0 Then
                ErrorProvider1.SetError(tsub4, "Marks must be in between 0 to 100!")
            Else
                ErrorProvider1.Clear()
                If m <= 40 And m >= 0 Then
                    ProgressBar4.ForeColor = Color.Red
                ElseIf m <= 75 And m > 40 Then
                    ProgressBar4.ForeColor = Color.Blue
                ElseIf m <= 100 And m >= 75 Then
                    ProgressBar4.ForeColor = Color.Green
                End If
                ProgressBar4.Value = m
            End If
        End If
    End Sub

    Private Sub tsub5_TextChanged(sender As Object, e As EventArgs) Handles tsub5.TextChanged
        If tsub5.Text = "" Then
            ProgressBar5.Value = 0
        Else
            Dim m As Integer = CInt(tsub5.Text)
            If m > 100 Or m < 0 Then
                ErrorProvider1.SetError(tsub5, "Marks must be in between 0 to 100!")
            Else
                ErrorProvider1.Clear()
                If m <= 40 And m >= 0 Then
                    ProgressBar5.ForeColor = Color.Red
                ElseIf m <= 75 And m > 40 Then
                    ProgressBar5.ForeColor = Color.Blue
                ElseIf m <= 100 And m >= 75 Then
                    ProgressBar5.ForeColor = Color.Green
                End If
                ProgressBar5.Value = m
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer
        Dim per As Decimal
        Dim m1 As Integer = CInt(tsub1.Text)
        Dim m2 As Integer = CInt(tsub2.Text)
        Dim m3 As Integer = CInt(tsub3.Text)
        Dim m4 As Integer = CInt(tsub4.Text)
        Dim m5 As Integer = CInt(tsub5.Text)
        total = m1 + m2 + m3 + m4 + m5
        per = CDec(total / 5)
        If per <= 40 And per >= 0 Then
            lresult.BackColor = Color.PaleVioletRed
        ElseIf per <= 75 And per > 40 Then
            lresult.BackColor = Color.Blue
        ElseIf per <= 100 And per >= 75 Then
            lresult.BackColor = Color.Green
        End If
        lresult.Text = "Total marks You got: " & total & " Out of 500" & vbCrLf & "Percentage: " & per.ToString("00.00") & "%"
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value <= 40 And TrackBar1.Value >= 0 Then
            lrate.BackColor = Color.PaleVioletRed
        ElseIf TrackBar1.Value <= 75 And TrackBar1.Value > 40 Then
            lrate.BackColor = Color.Blue
        ElseIf TrackBar1.Value <= 100 And TrackBar1.Value >= 75 Then
            lrate.BackColor = Color.Green
        End If
        lrate.Text = "You have rated yourself " & CInt(TrackBar1.Value / 10) & " Out of 10"
    End Sub

    Private Sub ProgressBar4_Click(sender As Object, e As EventArgs) Handles ProgressBar4.Click

    End Sub
End Class