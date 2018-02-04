Module Module1

    Sub Main()
        Dim S As String = ""
        Dim x As String = ""
        Dim y As String = ""

        Console.Write("Enter String: ")
        S = Console.ReadLine

        If Len(S) > 1 Then
            x = Left(S, 2)
            y = Right(S, 2)
            Console.WriteLine("Final String: " & x & y)
        Else
            Console.WriteLine("Final String: " & "")
        End If

        Console.ReadKey()

    End Sub

End Module
