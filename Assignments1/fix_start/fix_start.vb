Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim mychar, thischar As Char
        Dim count As Integer

        str1 = ""
        str2 = ""
        mychar = ""
        thischar = ""
        count = 0

        Console.Write("enter your string: ")
        str1 = Console.ReadLine
        mychar = Mid(str1, 1, 1)

        For count = 2 To Len(str1)
            thischar = Mid(str1, count, 2)
            If thischar = mychar Then
                thischar = "*"
            Else
                thischar = thischar
            End If
            str2 = str2 & thischar
        Next
        str1 = mychar & str2
        Console.WriteLine(str1)
        Console.ReadKey()

    End Sub

End Module
