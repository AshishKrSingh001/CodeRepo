Public Structure Employee
    Dim name As String
    Dim id As Integer
    Dim Experience As Double
    Sub Fill(id1 As Integer, Experience1 As Double, name1 As String)
        name = name1
        id = id1
        Experience = Experience1
    End Sub

    Sub Fill(id1 As Integer, name1 As String, Experience1 As Double)
        name = name1
        id = id1
        Experience = Experience1
    End Sub
    Sub Fill(Experience1 As Double, id1 As Integer, name1 As String)
        name = name1
        id = id1
        Experience = Experience1
    End Sub
    Sub Fill(Experience1 As Double, name1 As String, id1 As Integer)
        name = name1
        id = id1
        Experience = Experience1
    End Sub

    Sub Fill(name1 As String, id1 As Integer, Experience1 As Double)
        name = name1
        id = id1
        Experience = Experience1
    End Sub
    Sub Fill(name1 As String, Experience1 As Double, id1 As Integer)
        name = name1
        id = id1
        Experience = Experience1
    End Sub
    Sub Fill(name1 As String, Experience1 As Double)
        name = name1
        id = 101
        Experience = Experience1
    End Sub
    Sub Fill(name1 As String, id1 As Integer)
        name = name1
        id = id1
        Experience = 2.2
    End Sub
    Sub Fill(id1 As Integer, Experience1 As Double)
        name = "Ashish Kumar Singh"
        id = id1
        Experience = Experience1
    End Sub
End Structure
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emp As Employee
        emp.Fill(TextBox1.Text, CInt(TextBox2.Text), CDec(TextBox3.Text))
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        emp.Fill("Ashish", 2.5, 5)
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        emp.Fill(4, "Aditya", 2.2)
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        emp.Fill(5.2, "Abhishek", 1)
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        emp.Fill("Anish", 2, 5.0)
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        emp.Fill(3, 3.3, "Amit")
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        emp.Fill(5.5, 6, "Ashish")
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        emp.Fill("Ashish", 2.5)
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        emp.Fill(7, 5.1)
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        emp.Fill("Ashish", 5)
        MessageBox.Show("Name: " & emp.name & vbCrLf & "Id: " & emp.id & vbCrLf & "Experience: " & emp.Experience, "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
