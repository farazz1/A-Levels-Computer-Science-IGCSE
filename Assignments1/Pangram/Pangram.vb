Module Module1

    Sub Main()
        Dim Str1, Abc As String
        Dim count As Integer
        Dim nextChar As Char
        Dim isPangram As Boolean

        Str1 = ""
        Abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        nextChar = ""
        count = 0
        isPangram = True

        Console.Write("enter string: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        For count = 1 To Len(Abc)
            nextChar = Mid(Abc, count)
            If InStr(Str1, nextChar) = 0 Then
                isPangram = False
                Exit For
            End If

        Next

        If isPangram = True Then
            Console.WriteLine("Sentense entered has all alphabets")
        Else
            Console.WriteLine("sentence does not have all alphabets")
        End If

        Console.ReadKey()

    End Sub

End Module
