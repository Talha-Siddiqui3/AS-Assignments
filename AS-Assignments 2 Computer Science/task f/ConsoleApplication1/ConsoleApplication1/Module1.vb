Module Module1

    Sub Main()
        Dim a As String = ""
        Dim b As String = "'"
        Dim aFront As String = ""
        Dim aBack As String = ""
        Dim bFront As String = ""
        Dim bBack As String = ""

        Console.WriteLine("Enter String1") : a = Console.ReadLine
        Console.WriteLine("Enter String2") : b = Console.ReadLine

        If Len(a) Mod 2 = 0 Then
            aFront = Left(a, Len(a) / 2)
            aBack = Right(a, Len(a) / 2)
        Else
            aFront = Left(a, (Len(a) / 2) + 0.5)
            aBack = Right(a, (Len(a) / 2) - 0.5)

        End If

        If Len(b) Mod 2 = 0 Then
            bFront = Left(b, Len(b) / 2)
            bBack = Right(b, Len(b) / 2)
        Else
            bFront = Left(b, (Len(b) / 2) + 0.5)
            bBack = Right(b, (Len(b) / 2) - 0.5)

        End If

        Console.WriteLine(aFront & bFront & aBack & bBack)
        Console.ReadKey()













    End Sub

End Module
