Module Module1

    Sub Main()
        Dim S As String = ""
        Dim x As String = ""
        Dim y As String = ""
        Dim a As Integer = 0
        Dim b As Integer = 0
        Dim c As Integer = 0

        Console.Write("Enter String: ")
        S = Console.ReadLine

        a = InStr(S, "not")
        b = InStr(S, "bad")

        c = Len(S)

        x = Left(S, (a - 1))
        y = Right(S, (c - b) - 2)

        Console.Write("Final String: " & x & "good" & y)

        Console.ReadKey()

    End Sub

End Module
