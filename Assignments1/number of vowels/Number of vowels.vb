Module Module1

    Sub Main()
        Dim myStr, myChar As String
        Dim Count, vNum As Integer
        Const vowels = "AEIOU"

        myStr = ""
        myChar = ""
        vNum = 0
        Count = 0

        Console.Write("Enter string to look for vowels: ")
        myStr = Console.ReadLine
        myStr = UCase(myStr)

        For Count = 1 To Len(myStr)
            myChar = Mid(myStr, Count, 1)
            If InStr(vowels, myChar) > 0 Then
                vNum = vNum + 1
            End If
        Next

        Console.WriteLine("Number of vowels in the given string = " & vNum)
        Console.ReadKey()
    End Sub

End Module
