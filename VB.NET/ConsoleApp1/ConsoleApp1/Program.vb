Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter a String: ")
        Dim str As String = Console.ReadLine()
        Dim rev As String = ""
        Dim ch As String = ""
        Console.WriteLine(vbCrLf & "Original String: " & str & vbCrLf)
        Console.WriteLine("Reverse String Character by Character: ")
        For i As Integer = str.Length To 1 Step -1
            ch = Mid(str, i, 1)
            rev = rev + ch
            Console.WriteLine(ch)
        Next
        Console.WriteLine(vbCrLf & "Reverse String: " & rev)
    End Sub
End Module
