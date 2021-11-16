Module Module1

    Sub Main()
        Dim str1, Ing, Ily, thischar As String

        str1 = ""
        Ing = "ing"
        Ily = "ily"
        thischar = ""


        Console.Write("input string: ")
        str1 = Console.ReadLine
        thischar = Right(str1, 3)

        If Len(str1) < 3 Then
            Console.WriteLine(str1)
            Console.ReadKey()

            Exit Sub
        End If

        If thischar = Ing Then
            str1 = str1 & Ily
        Else
            str1 = str1 & Ing
        End If

        Console.WriteLine(str1)
        Console.ReadKey()

    End Sub

End Module
