Imports System
Imports System.Console

Module Program
    Dim Name As String
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        'Properties
        BackgroundColor = ConsoleColor.White
        ForegroundColor = ConsoleColor.Black
        Title = "First Console Application"

        'Methods
        WriteLine("Enter your name: ")
        Name = ReadLine()
        Write("Your Name is " + Name)
        Read()

    End Sub
End Module
