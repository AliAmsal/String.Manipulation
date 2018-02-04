Module Module1

    Sub Main()
        Dim a As String = ""
        Dim b As String = ""
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim u As String = ""
        Dim v As String = ""
        Dim c As String = ""
        Dim d As String = ""

        Console.Write("Enter String A: ")
        a = Console.ReadLine

        Console.Write("Enter String B: ")
        b = Console.ReadLine

        x = Len(a)
        y = Len(b)

        If x Mod 2 = 0 Then
            c = Left(a, (x / 2))
            d = Right(a, (x / 2))
        Else
            c = Left(a, ((x - 1) / 2) + 1)
            d = Right(a, ((x - 1) / 2))
        End If

        If y Mod 2 = 0 Then
            u = Left(b, (y / 2))
            v = Right(b, (y / 2))
        Else
            u = Left(b, ((y - 1) / 2) + 1)
            v = Right(b, ((y - 1) / 2))
        End If

        Console.WriteLine("A-Front: " & c)
        Console.WriteLine("A-Back: " & d)
        Console.WriteLine("B-Front: " & u)
        Console.WriteLine("B-Back: " & v)
        Console.WriteLine("Final String: " & c & " + " & u & " + " & d & " + " & v)
        Console.ReadKey()

    End Sub

End Module
