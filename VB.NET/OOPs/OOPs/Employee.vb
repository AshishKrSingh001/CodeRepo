Public Class Employee
    Dim Name As String
    Dim Id As Integer

    Public Sub New()
        MessageBox.Show("Parent class Constructor")
    End Sub
    Public Sub New(Name As String)
        Me.Name = Name
        Me.Id = 1111
    End Sub
    Public Sub New(ID As Integer)
        Me.Id = ID
        Me.Name = "AAAAAA"
    End Sub
    Public Sub New(Name As String, ID As Integer)
        Me.Id = ID
        Me.Name = Name
    End Sub
    Public Sub New(obj As Employee)
        Me.Id = obj.Id
        Me.Name = obj.Name
    End Sub
    Protected Overrides Sub finalize()
        MessageBox.Show("Parent class Destructor")
    End Sub
    Public ReadOnly Property p_Read_Name As String
        Get
            Return Name
        End Get
    End Property
    Public WriteOnly Property p_Write_Name() As String
        Set(Name As String)
            Me.Name = Name
        End Set
    End Property

    Public Property p_ID As Integer
        Get
            Return Id
        End Get
        Set(ID As Integer)
            Me.Id = ID
        End Set
    End Property
    Protected x As Integer = 10
End Class
Public Class IT : Inherits Employee
    Public Sub New()
        MessageBox.Show("Child class constructor")
    End Sub
    Protected Overrides Sub finalize()
        MessageBox.Show("Child class destructor")
    End Sub

End Class
