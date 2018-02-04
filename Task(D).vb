Module Module1

    Sub Main()
        Dim a As String = ""
        Dim b As String = ""
        Dim x As String = ""
        Dim y As String = ""
        Dim u As String = ""
        Dim v As String = ""
        Dim c As String = ""
        Dim d As String = ""

        Console.Write("Enter String a: ")
        a = Console.ReadLine

        Console.Write("Enter String b: ")
        b = Console.ReadLine

        x = Left(a, 2)
        y = Left(b, 2)

        c = Len(a)
        d = Len(b)

        u = Mid(a, 3, c)
        v = Mid(b, 3, d)

        Console.Write("Final String: " & y & u & " " & x & v)

        Console.ReadKey()

    End Sub

End Module
