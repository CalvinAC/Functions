Option Strict On
Option Explicit On

Module Functions

    Sub Main()
        Dim aLetter As String
        aLetter = "Q"
        Console.WriteLine(aLetter)
        Console.ReadLine()

        'Letter()
        Console.WriteLine(Letter())
        Console.ReadLine()

        Console.WriteLine(AddNum(3I, 7I))
        Console.ReadLine()
        For i = 1 To 3
            Console.WriteLine(RunningTotal(5))
            Console.ReadLine()
        Next

        AccumulateMessage("It is I! Dio!")
        AccumulateMessage("Please stop please")
        AccumulateMessage("oof")
        MsgBox(AccumulateMessage(""))
        'Console.WriteLine(DoesNotReturnStuff())
        'Console.ReadLine()

    End Sub

    Function Letter() As String
        Dim someOtherLetter As String
        someOtherLetter = "Y"
        Return someOtherLetter

    End Function

    Sub DoesNotReturnStuff()
        Dim someOtherLetter As String
        someOtherLetter = "X"
        'Return someOtherLetter

    End Sub

    Function AddNum(ByVal firstNumber As Integer, ByVal secondNumber As Integer) As Integer

        Return firstNumber + secondNumber

    End Function

    Function RunningTotal(ByRef currentAmount As Decimal) As Decimal
        Static total As Decimal
        total += currentAmount
        Return total
    End Function

    Function AccumulateMessage(ByVal newMessage As String) As String

        Static userMessage As String
        userMessage &= newMessage & vbNewLine
        Return userMessage

    End Function

End Module
