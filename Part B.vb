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
        Mystr = Console.ReadLine

        If Len(Mystr) < 1 Or Len(Mystr) > 8 Then
            validity = False
        End If
        If validity = True Then
            For counter = 1 To Len(Mystr)
                Mychar = Mid(Mystr, counter, 1)
                If Mychar < 0 Or Mychar > 1 Then
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

        Dim chr2 As Integer
        Dim counter2 As Integer
        Dim sum As Integer
        Dim denaryvalue As Integer
        Dim total As Integer

        chr2 = 0
        counter2 = 0
        sum = 0
        denaryvalue = 0
        total = 0


        If validity = True Then
            total = Len(Mystr)
            For counter2 = 1 To total
                chr2 = Mid(Mystr, counter2, 1)
                denaryvalue = ((2 ^ (total - counter2)) * chr2)
                sum = sum + denaryvalue

            Next

        End If
        Console.WriteLine(Mystr & " = " & sum)

        Console.ReadKey()


    End Sub




End Module




