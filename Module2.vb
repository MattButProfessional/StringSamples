Imports System.Globalization

Module Module2
    'Write a program that prompts the user to enter b to convert a decimal number to binary and 
    'd to convert a binary number to decimal, and q to quit 
    'B, D and Q in any case should be supported. 
    'if the user chooses to convert to binary, make sure a valid integer is given. 
    'Do not try to convert anything that is not a number 
    'if invalid input is given, report the error and prompt again. 
    'when valid input is given, do the conversion and then print out: 
    '{integer} converted to binary is {binaryStr} 
    'if the user chooses to convert to decimal (from binary), 
    'make sure the string given contains only 0s and 1s. If it contains anything else, report the error 
    'and ask for a new binary string 
    'When a valid string is given print out the conversion as  
    '{binary str} converted to decimal is : {decimal num} 
    'DO NOT HAVE ANY SUBS OR FUNCTIONS WITH MORE THAN 25 LINES 
    Sub main()
        Dim input As String
        Do
            Console.Write("Enter ""B"" to convert to Binary, ""D"" to convert to Decimal, or ""Q"" to quit. -> ")
            input = Console.ReadLine.ToUpper()
            If input = "B" Then
                toBinary()
            ElseIf input = "D" Then
                toDecimal()
            ElseIf input = "Q" Then
                End
            Else
                Console.WriteLine("Thats not an option")
            End If
        Loop While input.ToUpper() <> "Q"
    End Sub
    Sub toBinary()
        Dim num As Integer
        Dim valid As Boolean
        Dim printNum As Integer
        Dim binstring As String = ""
        Console.Write("Please input a number to be converted to binary. -> ")
        valid = Integer.TryParse(Console.ReadLine, num)
        printNum = num
        If valid Then
            Do
                If num Mod 2 = 0 Then
                    binstring = "0" + binstring
                ElseIf num Mod 2 = 1 Then
                    binstring = "1" + binstring
                End If
                num = Math.Floor(num / 2)
            Loop Until num = 0
            Console.WriteLine($"{printNum} as binary number Is {binstring}")
        Else
            Console.WriteLine("That's not a number")
        End If
    End Sub
    Sub toDecimal()
        Dim num As Integer
        Dim input As String
        Dim totalnum As Integer
        Dim printnum As Integer
        Console.Write("Please input a binary number to be converted to decimal. -> ")
        input = Console.ReadLine
        printnum = input
        If isValidBinary(input) = True Then
            For i As Integer = 0 To input.Length - 1
                If input(i) = "1" Then
                    num = 1 * 2 ^ (input.Length - 1 - i)
                    totalnum = totalnum + num
                ElseIf input(i) = "0" Then
                    num = 0
                    totalnum = totalnum + num
                End If
            Next
            Console.WriteLine($"{printnum} converted to decimal is : {totalnum}")
        Else
            Console.WriteLine("That isn't binary!")
        End If
    End Sub

    ''' <summary>
    ''' Accepts a string and checks it to make sure it contains only 1s and 0s
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Function isValidBinary(str As String) As Boolean
        Dim valid As Boolean = True
        For i As Integer = 0 To str.Length - 1
            If str(i) <> "0" AndAlso str(i) <> "1" Then
                valid = False
            End If
        Next
        Return valid
    End Function
End Module