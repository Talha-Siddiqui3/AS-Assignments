Module Module1

    Sub Main()
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

End Module
