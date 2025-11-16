Public Class Form1
    Dim emp As Employee
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        emp = New Employee()
        emp.p_Write_Name = InputBox("Enter your name: ")
        emp.p_ID = InputBox("Enter your Id")
        MessageBox.Show("Name: " & emp.p_Read_Name & vbCrLf & "Id: " & emp.p_ID)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        emp = New Employee
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim e1 As New Employee("Ashish")
        MessageBox.Show("Name: " & e1.p_Read_Name & vbCrLf & "Id: " & e1.p_ID)
        Dim e2 As New Employee(10)
        MessageBox.Show("Name: " & e2.p_Read_Name & vbCrLf & "Id: " & e2.p_ID)
        Dim e3 As New Employee("Ayush", 20)
        MessageBox.Show("Name: " & e3.p_Read_Name & vbCrLf & "Id: " & e3.p_ID)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim em As New Employee("Ayush", 20)
        emp = New Employee(em)
        MessageBox.Show("Name: " & em.p_Read_Name & vbCrLf & "Id: " & em.p_ID)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        emp = New IT
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim eng As Engineer
        eng = New Electronics
        eng.SetData("Ashish0", 1)
        eng.Data()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim eng As Electronics = New Electronics
        eng.add()
        eng.Add(1)
        eng.add(1, 2)
        eng.add(1, 2, 3)
    End Sub
End Class
