Imports System
Imports ConsoleHelpers.ConsoleKeysHelper
Module Program
    Sub Main(args As String())
        Dim value = ReadLineFiveSeconds("Please enter your name within the next 5 seconds.")
        Console.WriteLine(value)
        Console.ReadLine()
    End Sub
End Module
