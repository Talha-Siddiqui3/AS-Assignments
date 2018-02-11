Module Module1

    Sub Main()
        Dim s As String = ""
        Dim newString As String = ""
        Dim charToChange, currentChracter As Char
        Dim x As Integer = 0
        Console.WriteLine("Enter Your String(min length=1):") : s = Console.ReadLine()
        charToChange = (Left(s, 1))
        newString = charToChange
        For x = 1 To Len(s)
            currentChracter = Mid(s, x + 1, 1)
            If currentChracter = charToChange Then
                newString = newString & "*"
            Else
                newString = newString & currentChracter

            End If
        Next

        Console.WriteLine(newString)
        Console.ReadKey()


    End Sub

End Module
