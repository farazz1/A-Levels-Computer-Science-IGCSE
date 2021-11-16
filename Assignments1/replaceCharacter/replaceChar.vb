Module Module1

    Sub Main()
        Dim str1, newStr, char1, char2, nextchar As String
        Dim count As Integer

        str1 = ""
        newStr = ""
        char1 = ""
        char2 = ""
        nextChar = ""
        count = 0

        Console.Write("enter sentence: ")
        str1 = Console.ReadLine

        Console.Write("enter character you wish to replace: ")
        char1 = Console.ReadLine

        Console.Write("enter new character: ")
        char2 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextChar = char1 Then
                nextChar = char2

            End If
            newStr = newStr & nextChar
        Next

        Console.WriteLine("final string: " & newStr)
        Console.ReadKey()





    End Sub

End Module
