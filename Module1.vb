Module Module1
    'brooks keller
    '10/24/23
    'loops demos, with a taste of subs
    Sub Main()
        Console.WriteLine("helloooo, im in main")
        'first, just a taste of a sub
        sayhello()
        Console.WriteLine("welcome back to main")
        Console.WriteLine("letys try a function, it returns a value")

        demoForNextLoop()

        DemoForNextCountingByFives(50)
        DemoForNextCountingByFives(500)

        demowhileloops()
        demoDoWhileLoops()

        For i As Integer = 1 To 50
            Console.Write(i Mod 10)
        Next

        Console.WriteLine(myPadLeft(50, "over here!"))
        Console.ReadKey()
    End Sub


    Sub demoForNextLoop()
        'for/next (a "For Loop") is typically a counter controlled loop
        'you start at a number, do something, and then the number is incremente by a set value
        For i As Integer = 1 To 10
            Console.WriteLine("Counting: " & i)
        Next
    End Sub


    Sub DemoForNextCountingByFives(numToCountTo As Integer)
        Console.WriteLine("counting to {0} by 5s", numToCountTo)
        For i As Integer = 0 To numToCountTo Step 5 'the step 5 will add 5 to each i every time
            Console.WriteLine("counting: " & i)
        Next
    End Sub


    Sub sayhello()
        'a sub is a block of code that can be called from
        'other parts of the program and run over and over again
        Console.WriteLine("welcome to the sub")
        Console.WriteLine("hello")
    End Sub

    Sub demoForNextCountByGivenValue(numToCountTo As Integer, stepSize As Integer)

    End Sub

    Sub demowhileloops()
        'a while loop checks the condition before any code is executed
        'if a condition is met, the loop body does not run
        Dim smiley As String = ""
        While smiley <> ":)"
            Console.Write("smile please")
            smiley = Console.ReadLine
        End While
        Console.Write("thank you")
    End Sub
    Sub demoDoWhileLoops()
        Dim smiley As String = ""
        'note: a do while loop is always going to execute at least once
        Do
            Console.Write("whats your dissapointed face?")
            smiley = Console.ReadLine
        Loop While smiley <> ":/"
        Console.WriteLine("thanks")
    End Sub
    Function myPadLeft(spaces As Integer, originalString As String)
        'find out how many spaces we need to add
        'by finding out how long our original string is, and then
        'subtracting it from spaces
        Dim spacesNeeded As Integer = spaces - originalString.Length
        Dim newstring = ""
        For i As Integer = 1 To spacesNeeded
            newstring = newstring + " "
        Next
        newstring = newstring + originalString
        Return newstring
    End Function


    'this is an intellisense comment

    ''' <summary>
    ''' prompts the user for a one or two and repeats until it gets a valid value
    ''' </summary>
    ''' <returns> an integer that is a one or  two </returns>
    Function getaoneortwo() As Integer
        Dim input As String

        Do
            Console.Write("please enter a one or two >> ")
            input = Console.ReadLine
            If Not (input = "1" OrElse input = "2") Then
                Console.WriteLine("thats not a one or two")
            End If
        Loop While Not (input = "1" OrElse input = "2")
        Dim num As Integer
        Integer.TryParse(input, num)
        Return (input)
    End Function
End Module
