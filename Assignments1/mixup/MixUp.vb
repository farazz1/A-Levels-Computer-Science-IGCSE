Module Module1

    Sub Main()
        Dim str1, str2, half1, half2, thischar, str3, str4 As String

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        half1 = ""
        half2 = ""
        thischar = ""

        Console.Write("enter string one: ")
        str1 = Console.ReadLine
        Console.Write("enter string two: ")
        str2 = Console.ReadLine

        half1 = Left(str1, 2)
        half2 = Left(str2, 2)

        thischar = Mid(str1, 3, Len(str1) - 2)
        str3 = str3 & thischar

        thischar = Mid(str2, 3, Len(str2) - 2)
        str4 = str4 & thischar

        str1 = half2 & str3
        str2 = half1 & str4

        Console.WriteLine(str1 & " " & str2)
        Console.ReadKey()

    End Sub

End Module
