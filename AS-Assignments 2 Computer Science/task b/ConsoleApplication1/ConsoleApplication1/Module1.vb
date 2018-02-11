Module Module1

    Sub Main()
        Dim s As String = ""



        Console.WriteLine("Enter the String") : s = Console.ReadLine()
        If Len(s) <= 2 Then
            Console.WriteLine("")
        Else
            Console.WriteLine(Left(s, 2) & Right(s, 2))

        End If

        Console.ReadKey()


    End Sub

End Module
