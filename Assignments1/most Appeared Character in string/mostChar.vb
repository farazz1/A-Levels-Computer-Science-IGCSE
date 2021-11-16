Module Module1

    Sub Main()
        Dim mychar, thischar, nextchar As Char
        Dim highest, count, x, b As Integer
        Dim str1 As String
        mychar = ""
        highest = 0
        count = 0

        Console.Write("Enter string to process: ")
        str1 = Console.ReadLine

        For x = 1 To Len(str1)
            nextchar = Mid(str1, x, 1)
            count = 0
            For b = 1 To Len(str1)
                thischar = Mid(str1, b, 1)
                If thischar = nextchar Then count = count + 1
            Next
            If count > highest Then
                highest = count
                mychar = nextchar

            End If
        Next

        Console.WriteLine(mychar & "  " & "appeared the most" & " " & highest & " " & "times.")
        Console.ReadKey()


    End Sub

End Module
