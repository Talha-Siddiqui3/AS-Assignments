Module Module1

    Sub Main()

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

End Module
