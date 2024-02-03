Public Class formStudentDetails

    Private Sub llblselect_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblselect.LinkClicked
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ptbphoto.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ptbphoto_Click(sender As Object, e As EventArgs) Handles ptbphoto.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exitb.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles submitb.Click
        Dim info As String
        info = nudrollno.Value() & vbCrLf & nm.Text() & vbCrLf & dob.Text() & vbCrLf
        If male.Checked Then
            info = info & male.Text & vbCrLf
        ElseIf female.Checked Then
            info = info & female.Text & vbCrLf
        End If
        If cdance.Checked Then
            info = info & cdance.Text & vbCrLf
        End If
        If cread.Checked Then
            info = info & cread.Text & vbCrLf
        End If
        If cwc.Checked Then
            info = info & cwc.Text & vbCrLf
        End If
        If cwm.Checked Then
            info = info & cwm.Text & vbCrLf
        End If
        If cother.Checked Then
            info = info & tother.Text & vbCrLf
        End If
        info = info & address.Text() & vbCrLf & tcity.Text & vbCrLf &
            cmbstate.SelectedItem & vbCrLf & mstpin.Text() & vbCrLf &
            mstmob.Text() & vbCrLf
        Dim res As DialogResult
        res = MessageBox.Show(info, "Information Entered", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If res = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("Submitted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf res = Windows.Forms.DialogResult.No Then
            MessageBox.Show("Check properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

End Class