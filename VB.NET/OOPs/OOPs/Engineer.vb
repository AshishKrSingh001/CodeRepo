Public MustInherit Class Engineer
    Protected Name As String
    Protected Id As Integer
    Sub New()
        MessageBox.Show("Base class")
    End Sub
    Public MustOverride Sub SetData(Name As String, Id As String)
    Public Sub Data()
        MessageBox.Show("Name : " & Name & vbCrLf & "Id : " & Id)
    End Sub
End Class
Public Interface A
    Sub Add()
    Sub Add(a As Integer)
    Sub Add(a As Integer, b As Integer)
    Sub Add(a As Integer, b As Integer, c As Integer)

End Interface
Public Class Electronics : Inherits Engineer
    Implements A
    Sub New()
        MessageBox.Show("Derived class")
    End Sub
    Sub add() Implements A.Add
        MessageBox.Show("Add1")
    End Sub
    Sub Add(a As Integer) Implements A.Add
        MessageBox.Show("Add4")
    End Sub
    Sub add(a As Integer, b As Integer) Implements A.Add
        MessageBox.Show("Add2")
    End Sub
    Sub add(a As Integer, b As Integer, c As Integer) Implements A.Add
        MessageBox.Show("Add3")
    End Sub
    Public Overrides Sub SetData(Name As String, Id As String)
        MyBase.Name = Name
        MyBase.Id = Id
    End Sub
End Class