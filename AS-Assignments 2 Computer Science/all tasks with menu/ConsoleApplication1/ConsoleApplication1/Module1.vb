Module Module1

    Sub Main()
        Dim x As Integer = 0
        Do

            Console.Clear()
            Console.WriteLine("Select the number of task you want to perform")
            Console.WriteLine("1: taska(donuts)")
            Console.WriteLine("2: taskb(both_ends)")
            Console.WriteLine("3: taskc(fix_start)")
            Console.WriteLine("4: taskd(Mixup)")
            Console.WriteLine("5: taske(not_bad)")
            Console.WriteLine("6: taskf(front_back)")
            Console.WriteLine("-1: to exit")
            x = Console.ReadLine

            Select Case x
                Case 1 : Call taska()
                Case 2 : Call taskb()
                Case 3 : Call taskc()
                Case 4 : Call taskd()
                Case 5 : Call taske()
                Case 6 : Call taskf()
                Case -1
                Case Else
                    Console.WriteLine("Wrong input. Please select a number between 1-5. Select -1 to exit the program.")
            End Select
        Loop Until x = -1
    End Sub
    Sub taska()
        Dim numberOfDonuts As Integer = 0
        Dim donuts As String = "Number of donuts: "

        Console.WriteLine("Enter no of donuts: ") : numberOfDonuts = Console.ReadLine
        If numberOfDonuts < 10 Then
            Console.WriteLine(donuts & numberOfDonuts)
        Else
            Console.WriteLine(donuts & "many")

        End If

        Console.ReadKey()
    End Sub

    Sub taskb()
        Dim s As String = ""

        Console.WriteLine("Enter the String") : s = Console.ReadLine()
        If Len(s) <= 2 Then
            Console.WriteLine("")
        Else
            Console.WriteLine(Left(s, 2) & Right(s, 2))

        End If

        Console.ReadKey()
    End Sub

    Sub taskc()
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

    Sub taskd()
        Dim a As String = ""
        Dim b As String = ""
        Dim newString As String = ""


        Console.WriteLine("Enter your first String") : a = Console.ReadLine()
        Console.WriteLine("Enter your second String") : b = Console.ReadLine()

        newString = Left(b, 2) & Mid(a, 3, Len(a) - 2) & " " & Left(a, 2) & Mid(b, 3, Len(b) - 2)

        Console.WriteLine(newString)
        Console.ReadKey()

    End Sub

    Sub taske()
        Dim s As String = ""
        Dim newString As String = ""
        Dim posNotStart As String = ""
        Dim posBadEnd As String = ""
        Dim alreadyChecked As Boolean = False
        Dim notfound As Boolean = False
        Dim x As Integer

        Console.WriteLine("Enter Your String:") : s = Console.ReadLine
        posNotStart = InStr(s, "not") - 1
        posBadEnd = InStr(s, "bad") - 1 + 2


        If posBadEnd = 1 Then
            newString = s
        Else
            For x = 0 To Len(s) - 1


                If x >= posNotStart And x <= posBadEnd And alreadyChecked = False Then
                    newString = newString & "good"
                    alreadyChecked = True

                ElseIf x < posNotStart Or x > posBadEnd Then
                    newString = newString & s(x)

                End If

            Next

        End If

        Console.WriteLine(newString)
        Console.ReadKey()
    End Sub

    Sub taskf()
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
