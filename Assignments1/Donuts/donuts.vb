Module Module1

    Sub Main()
        Dim str1 As Integer

        str1 = 0

        Console.Write("enter the number of donuts: ")
        str1 = Console.ReadLine

        If str1 > 9 Then
            Console.WriteLine("Number of donuts: many")
        Else
            Console.WriteLine("Number of donuts: " & str1)
        End If

        Console.ReadKey()

    End Sub



End Module
