Public Class formMDI
    Private Sub StudentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetailsToolStripMenuItem.Click
        Dim f1 As New formStudentDetails
        f1.Owner = Me
        f1.ShowInTaskbar = False
        f1.Show()
    End Sub

    Private Sub SubjectDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectDetailsToolStripMenuItem.Click
        Dim f2 As New SubjectDetails
        f2.Owner = Me
        f2.ShowInTaskbar = False
        f2.ShowDialog()
    End Sub

    Private Sub MarksDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarksDetailsToolStripMenuItem.Click
        Dim f3 As New marksDetails
        f3.Owner = Me
        f3.ShowInTaskbar = False
        f3.ShowDialog()
    End Sub

    Private Sub formMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = "Ashish Kr Singh"
        ToolStripStatusLabel3.Text = DateTime.Now().Date
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = DateTime.Now.Hour & " : " & DateTime.Now.Minute & " : " & DateTime.Now.Second
    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click

    End Sub
End Class