Module Module1

    Sub Main()
        Dim a As String = ""
        Dim b As String = ""
        Dim newString As String = ""


        Console.WriteLine("Enter your first String") : a = Console.ReadLine()
        Console.WriteLine("Enter your second String") : b = Console.ReadLine()

        newString = Left(b, 2) & Mid(a, 3, Len(a) - 2) & " " & Left(a, 2) & Mid(b, 3, Len(b) - 2)

        Console.WriteLine(newString)
        Console.ReadKey()





    End Sub

End Module
