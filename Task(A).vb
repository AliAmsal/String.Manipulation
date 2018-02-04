Module Module1

    Sub Main()
        Dim count As Integer = 0

        Console.Write("Enter Number of Donuts: ")
        count = Console.ReadLine

        If count >= 10 Then
            Console.WriteLine("Number of donuts: Many")
        Else
            Console.WriteLine("Number of donuts: " & count)
        End If

        Console.ReadKey()

    End Sub

End Module
