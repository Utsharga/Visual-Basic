Module Module1
    Dim Grid(0 To 5, 0 To 6) As Char
    Dim empty As Char = "-"
    Dim White As Char = "0"
    Dim Black As Char = "X"
    Dim row, col As Integer
    Dim Nextplayer As Char = "A"
    Dim W As Integer = 0
    Dim K As Integer = 0
    Dim i As Integer
    Dim Winner As String
    Dim Finish As Boolean

    Sub Main()
        Call Arrayinit()
        Call Display()
        Do
            Call Player()
            Call Display()
            Call Win()
        Loop Until Finish = True
        If Winner = "TrueA" Then
            Console.WriteLine("Winner is Player A")
        Else
            Console.WriteLine("Winner is Player B")
        End If
        Console.ReadKey()
    End Sub

    Sub Arrayinit()
        Dim row, col As Integer
        For row = 0 To 5
            For col = 0 To 6
                Grid(row, col) = empty
            Next
        Next
    End Sub

    Sub Display()
        For row = 5 To 0 Step -1
            For col = 0 To 6
                Console.Write(Grid(row, col))
            Next
            Console.WriteLine()
        Next
    End Sub

    Function Colnovalid(ByVal X As Integer)
        Dim Valid As Boolean
        If X < 0 Or X > 6 Then
            Valid = False
            Console.WriteLine("Outside Range")
        Else
            If Grid(5, X) = empty Then
                Valid = True
            Else
                Valid = False
                Console.WriteLine("This column is Full")
            End If
        End If
        Return Valid
    End Function

    Sub Player()
        Dim choosecol As Integer
        row = 0
        Do
            Console.Write("Input Column Number")
            choosecol = Console.ReadLine
        Loop Until Colnovalid(choosecol) = True
        While Grid(row, choosecol) <> empty
            row = row + 1
        End While
        If Nextplayer = "A" Then
            'Do
            'Console.Write("Input Column Number")
            'choosecol = Console.ReadLine
            'Loop Until Colnovalid(choosecol) = True
            'While Grid(row, choosecol) <> empty
            'row = row + 1
            'End While
            Grid(row, choosecol) = White
            Nextplayer = "B"
            row = 0
        Else
            'Call Getcol(Nextplayer)
            'choosecol = Getcol(Nextplayer)
            Grid(row, choosecol) = Black
            Nextplayer = "A"
            row = 0
        End If
    End Sub

    Function Getcol(ByVal Nextplayer As Char)
        Dim Number As Integer
        If Nextplayer = "B" Then
            Number = Rnd(6)
        Else
            Console.ReadLine()
        End If
        Return Number
    End Function

    Sub Win()
        row = 0
        For row = 0 To 5
            col = 0
            W = 0
            K = 0
            Do
                If Grid(row, col) = White Then
                    W = W + 1
                    col = col + 1
                    If Grid(row, col) = White Then
                        W = W + 1
                        col = col + 1
                        If Grid(row, col) = White Then
                            W = W + 1
                            Winner = "TrueA"
                        End If
                    End If
                ElseIf Grid(row, col) = Black Then
                    K = K + 1
                    col = col + 1
                    If Grid(row, col) = Black Then
                        K = K + 1
                        col = col + 1
                        If Grid(row, col) = Black Then
                            K = K + 1
                            Winner = "TrueB"
                        End If
                    End If
                ElseIf Grid(row, col) = empty Then
                    col = col + 1
                End If
            Loop Until col = 6
        Next
        If Winner = "TrueA" Then
            Finish = True
        ElseIf Winner = "TrueB" Then
            Finish = True
        Else
            Finish = False
        End If
    End Sub

End Module
