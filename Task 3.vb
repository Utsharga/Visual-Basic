Module Module1
    Sub main()
        'Dim Word(10) As String
        'Dim j As Integer = 1
        'Dim mean As String = " "
        Call Input()
        'While Word(j) <> "(empty)"
        'mean = mean + " " + Word(j)
        'j = j + 1
        'End While
        'Console.Write(mean)
    End Sub
    Sub Input()
        Dim j As Integer = 1
        Dim mean As String = " "
        Dim Word(10) As String
        Dim sent As String
        Dim line As String
        Dim s As Integer
        Dim i As Integer = 1
        Dim c As Integer = 1
        Dim pos As Integer = 1
        Console.Write("Enter String:")
        line = Console.ReadLine()
        line = line + " "

        Do
            While (Asc(Mid(line, pos, 1)) >= 65 And Asc(Mid(line, pos, 1)) <= 90) And pos < Len(line)
                s = pos
                pos = pos + 1
                c = c + 1
                While ((Asc(Mid(line, pos, 1)) >= 97 And Asc(Mid(line, pos, 1)) <= 122)) And pos < Len(line)
                    pos = pos + 1
                    c = c + 1
                    'Console.WriteLine(c)
                    'Console.WriteLine(pos)
                End While
                sent = Mid(line, s, c - 1)
                'Console.WriteLine(sent)
                Word(i) = sent
                i = i + 1
                c = 1
                'Console.ReadKey()
            End While
        Loop Until Len(line) = pos
        Do
            i = i + 1
            Word(i) = "(empty)"
        Loop Until i = 10
        Console.ReadKey()
        While Word(j) <> "(empty)"
            mean = mean + " " + Word(j)
            j = j + 1
        End While
        Console.Write("The Sentence Is:" & mean)
        Console.ReadKey()
    End Sub
End Module
