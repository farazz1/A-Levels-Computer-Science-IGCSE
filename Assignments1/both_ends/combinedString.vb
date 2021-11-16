Module Module1

    Sub Main()
        Dim str1, str2, str As String

        str1 = ""
        str2 = ""
        str = ""

        Console.Write("enter your string: ")
        str = Console.ReadLine

        If Len(str) < 2 Then
            Console.WriteLine(str)
        Else
            str1 = Left(str, 2)
            str2 = Right(str, 2)
            str = str1 & str2
            Console.WriteLine(str)
        End If

        Console.ReadKey()

    End Sub

End Module
