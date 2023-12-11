Module Module1
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
    Sub Main()
        Dim input As String
        Do
            Dim valid As Boolean
            Dim num As Integer
            Console.Write("Please enter an integer and I'll tell you if it's even or odd! -> ")
            input = Console.ReadLine
            valid = Integer.TryParse(input, num)
            If valid Then
                'determine if the num is even or odd
                If num Mod 2 = 0 Then '
                    Console.WriteLine("That's even")
                Else
                    Console.WriteLine("That's odd")
                End If
            Else
                Console.WriteLine("That's not a number")
            End If
        Loop While input.ToUpper() <> "Q"
        StringWalkin("Hola!")
    End Sub

    Sub StringWalkin(somestr As String)
        'assumes string is at lease 3 characters long
        Console.WriteLine($"Original String -> {somestr}")
        Console.WriteLine($"The first character in the string -> {somestr(0)}")
        Console.WriteLine($"The second character in the string -> {somestr(1)}")
        Console.WriteLine($"The third character in the string -> {somestr(2)}")


        For i As Integer = 0 To somestr.Length - 1
            Console.WriteLine(somestr(i))
        Next
    End Sub

End Module
