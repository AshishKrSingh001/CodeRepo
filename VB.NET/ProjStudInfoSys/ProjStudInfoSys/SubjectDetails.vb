Public Class SubjectDetails
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles font1.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub color1_Click(sender As Object, e As EventArgs) Handles color1.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub save1_Click(sender As Object, e As EventArgs) Handles save1.Click
        SaveFileDialog1.Filter = "Text Files(*.txt) |*.txt|" & "All Files|*.*"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Name = "bca101" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem1\BCA_101.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca102" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem1\BCA_102.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca103" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem1\BCA_103.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca104" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem1\BCA_104.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca105" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem1\BCA_105.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca201" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem2\BCA_201.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca202" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem2\BCA_202.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca203" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem2\BCA_203.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca204" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem2\BCA_204.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca205" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem2\BCA_205.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca301" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem3\BCA_301.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca302" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem3\BCA_302.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca303" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem3\BCA_303.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca304" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem3\BCA_304.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca401" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem4\BCA_401.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca402" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem4\BCA_402.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca403" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem4\BCA_403.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca404" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem4\BCA_404.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca501" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem5\BCA_501.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca502" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem5\BCA_502.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca503" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem5\BCA_503.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca504" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem5\BCA_504.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca601" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem6\BCA_601.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca602" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem6\BCA_602.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca603" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem6\BCA_603.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bca604" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BCA\sem6\BCA_604.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba101" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem1\BBA_101.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba102" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem1\BBA_102.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba103" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem1\BBA_103.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba104" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem1\BBA_104.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba105" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem1\BBA_105.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba106" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem1\BBA_106.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba201" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem2\BBA_201.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba202" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem2\BBA_202.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba203" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem2\BBA_203.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba204" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem2\BBA_204.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba205" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem2\BBA_205.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba206" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem2\BBA_206.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba301" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem3\BBA_301.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba302" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem3\BBA_302.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba303" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem3\BBA_303.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba304" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem3\BBA_304.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba305" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem3\BBA_305.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba306a" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem3\BBA_306A.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba306b" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem3\BBA_306B.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba401" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem4\BBA_401.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba402" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem4\BBA_402.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba403" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem4\BBA_403.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba404" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem4\BBA_404.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba405" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem4\BBA_405.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba406a" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem4\BBA_406A.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba406b" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem4\BBA_406B.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba501" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem5\BBA_501.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba502" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem5\BBA_502.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba503" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem5\BBA_503.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba504" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem5\BBA_504.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba601" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem6\BBA_601.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba602" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem6\BBA_602.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba603" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem6\BBA_603.txt", RichTextBoxStreamType.PlainText)
        ElseIf TreeView1.SelectedNode.Name = "bba604" Then
            RichTextBox1.LoadFile("D:\Programming\dotnet\ProjStudInfoSys\ProjStudInfoSys\notes\BBA\sem6\BBA_604.txt", RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RichTextBox1.Redo()
    End Sub

    Private Sub csub_Click(sender As Object, e As EventArgs) Handles csub.Click
        If CheckedListBox1.CheckedItems.Count = 2 Then
            MessageBox.Show("Successful Selection", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You have to select two subject", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class