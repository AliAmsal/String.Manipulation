Module Module1

    Sub Main()
        Dim S As String = ""
        Dim x As String = ""
        Dim y As String = ""
        Dim z As Integer = 0
        Dim w As Integer = 0
        Dim character As String = ""
        Dim FinalStr As String = ""
        Dim COUNT As Integer

        Console.Write("Enter String s: ")
        S = Console.ReadLine

        x = Left(S, 1)
        y = Len(S)

        z = Asc(x)

        FinalStr = FinalStr & x

        For COUNT = 2 To y
            character = Mid(S, COUNT, 1)
            w = Asc(character)
            If w <> z Then
                FinalStr = FinalStr & character
            Else
                FinalStr = FinalStr & "*"
            End If
        Next

        Console.Write("Final String: " & FinalStr)

        Console.ReadKey()

    End Sub

End Module
