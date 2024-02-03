Public Class Form1
    Private Sub TicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPname.Text = "Player 1"
    End Sub
    Sub ClearControls()
        lblPname.Text = "Player 1"
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
    End Sub
    Sub CheckWinner()
        If (Button1.Text = Button2.Text And Button2.Text = Button3.Text And Button1.Text <> "" And Button2.Text <> "" And Button3.Text <> "") _
            Or (Button1.Text = Button5.Text And Button5.Text = Button9.Text And Button1.Text <> "" And Button5.Text <> "" And Button9.Text <> "") _
            Or (Button1.Text = Button4.Text And Button4.Text = Button7.Text And Button1.Text <> "" And Button4.Text <> "" And Button7.Text <> "") _
            Or (Button2.Text = Button5.Text And Button5.Text = Button8.Text And Button2.Text <> "" And Button5.Text <> "" And Button8.Text <> "") _
            Or (Button3.Text = Button5.Text And Button5.Text = Button7.Text And Button3.Text <> "" And Button5.Text <> "" And Button7.Text <> "") _
            Or (Button3.Text = Button6.Text And Button6.Text = Button9.Text And Button3.Text <> "" And Button6.Text <> "" And Button9.Text <> "") _
            Or (Button4.Text = Button5.Text And Button5.Text = Button6.Text And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "") _
            Or (Button7.Text = Button8.Text And Button8.Text = Button9.Text And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "") _
            Then
            If lblPname.Text = "Player 1" Then
                MessageBox.Show("Player 2 is the winner", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Player 1 is the winner", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            ClearControls()
        ElseIf (Button1.Text <> "" And Button2.Text <> "" And Button3.Text <> "" And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "" And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "") Then
            MessageBox.Show("Game over!" & vbCrLf & "Nobody is the Winner", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ClearControls()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles _
        Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Dim btn1 As Button = sender
        Display(btn1)
    End Sub
    Sub Display(ByVal btn1 As Button)
        If btn1.Text = "" Then
            If lblPname.Text = "Player 1" Then
                btn1.Text = "X"
                lblPname.Text = "Player 2"
            Else
                btn1.Text = "O"
                lblPname.Text = "Player 1"
            End If
            CheckWinner()
        End If
    End Sub

    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        ClearControls()
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()
    End Sub
End Class
