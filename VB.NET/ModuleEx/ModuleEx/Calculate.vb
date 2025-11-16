Imports System.Security.Cryptography

Module Calculate
    Function ReverseString(str As String) As String
        Dim strrev As String = ""
        For i As Integer = 0 To str.Length - 1
            strrev = strrev + str.Substring(str.Length - 1 - i, 1)
        Next
        Return strrev
    End Function
    Function findSimpleInterest(p As Integer, r As Decimal, t As Decimal) As Decimal
        Return CDec((p * r * t) / 100)
    End Function
End Module
