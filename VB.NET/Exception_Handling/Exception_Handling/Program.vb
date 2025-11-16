Imports System

Module Program

    Public Class NotElegible : Inherits ApplicationException
        Public Sub New(msg As String)
            MyBase.New(msg)
        End Sub
    End Class
    Public Class AgeVerification
        Dim age As Integer = 101
        Sub New(age As Integer)
            Me.age = age
        End Sub
        Sub AgeMethod()
            If (age < 18) Then
                Throw (New NotElegible("ARE JAKE PEHLE DOODH PIII "))
            ElseIf (age > 100 And age < 200) Then
                Throw (New NotElegible("Are Chacha APKI JANE KI UMAR HO GAYI"))
            ElseIf (Age > 200) Then
                Throw (New NotElegible("MuBBARK HO! APP KABR ME HAIN"))
            End If
        End Sub
    End Class

    Sub Main(args As String())
        Dim Age As Integer
        Try
            Console.WriteLine("Enter your age : ")
            Age = CInt(Console.ReadLine())
            Dim a As AgeVerification = New AgeVerification(Age)
            a.AgeMethod()
            Console.WriteLine("Mubbark ho! App YOGYA hai ")
        Catch ex As Exception
            Console.WriteLine("{0}", ex.Message)
        Finally
            Console.WriteLine("Bye")
        End Try

    End Sub
End Module
