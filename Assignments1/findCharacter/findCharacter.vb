Module Module1

    Sub Main()
        Dim str1, x, nextChar As String
        Dim count, cCount As Integer

        str1 = ""
        x = ""
        nextChar = ""
        count = 0
        cCount = 0

        Console.Write("Enter your string: ")
        str1 = Console.ReadLine

        Console.Write("enter the character to be found: ")
        x = Console.ReadLine

        For count = 1 To Len(str1)
            nextChar = Mid(str1, count, 1)

            If UCase(nextChar) = UCase(x) Then
                cCount = cCount + 1

            End If
        Next

        Console.WriteLine("The character appeared" & " " & cCount & " " & "times")
        Console.ReadKey()


    End Sub

End Module
