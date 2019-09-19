Module Module1
    Dim Topofstack As Integer = 0
    Dim Spooljob(1000) As Num

    Structure Num
        Dim jobref As String
        Dim UserID As String
    End Structure

    Sub main()
        Dim Choice As Integer
        Do
            Console.WriteLine("For PushJob Press 1")
            Console.WriteLine("For PopJob Press 2")
            Console.WriteLine("For Exit Press 3")
            Choice = Console.ReadLine()
            If Choice = 1 Then
                Call Pushjob(Topofstack)
            ElseIf Choice = 2 Then
                Call Popjob(Topofstack)
            ElseIf Choice = 3 Then
                Console.WriteLine("Thank you")
            Else
                Console.WriteLine("Invalid choice")
            End If
        Loop Until Choice = 3

    End Sub

    Function Pushjob(ByRef Topofstack As Integer) As Integer
        Dim NewUserId As String
        Dim Newref As String
        If Topofstack = 5 Then
            Console.WriteLine("Stack is Already full")
        Else
            Console.WriteLine("Insert New User ID")
            NewUserId = Console.ReadLine()
            Console.WriteLine("Insert New Job Reference")
            Newref = Console.ReadLine()
            Topofstack = Topofstack + 1
            Spooljob(Topofstack).jobref = Newref
            Spooljob(Topofstack).UserID = NewUserId
        End If
        Return Topofstack

    End Function
    Function Popjob(ByRef Topofstack As Integer) As Integer
        If Topofstack = 0 Then
            Console.WriteLine("Stack Is Empty")
        Else
            Spooljob(Topofstack).jobref = ""
            Spooljob(Topofstack).UserID = ""
            Topofstack = Topofstack - 1
        End If
        Return Topofstack
    End Function

End Module
