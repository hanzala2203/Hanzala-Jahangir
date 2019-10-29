Module Module1

    Sub Main()
        Dim Mystr As String
        Dim counter As Integer
        Dim validity As Boolean
        Dim Mychar As String

        Mystr = " "
        counter = 0
        validity = True
        Mychar = " "

        Console.Write("Enter Binary Number: ")
        mystr = Console.ReadLine

        If Len(Mystr) < 1 Or Len(Mystr) > 8 Then
            validity = False
        End If
        If validity = True Then
            For counter = 1 To Len(mystr)
                Mychar = Mid(Mystr, counter, 1)
                If mychar < 0 Or mychar > 1 Then
                    validity = False
                End If
            Next

        End If

        If validity = True Then
            Console.WriteLine("The Number Is Binary")
            Console.ReadKey()
        ElseIf validity = False Then
            Console.WriteLine("The Number Is Not Binary")
            Console.ReadKey()
        End If
        Console.ReadKey()
    End Sub

End Module
