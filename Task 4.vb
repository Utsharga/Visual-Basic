Imports System.IO
Imports System.String

Module Module1

    Sub main()
        Dim Choice As Integer

        Console.WriteLine("1 for Create")
        Console.WriteLine("2 for Append")
        Console.WriteLine("3 for Find")
        Console.WriteLine("4 for Exit")

        Choice = Console.ReadLine()
        Select Case Choice
            Case 1
                Call Create()
            Case 2
                Call Append()
            Case 3
                Call Find()
            Case 4
                Exit Sub
        End Select

    End Sub
    Sub Create()
        Dim MemId As String
        Dim VDate As String
        Dim rogue As String
        Dim record As String
        Dim sfilewriter As StreamWriter

        sfilewriter = File.CreateText("D:/Task4.txt")
        Do
            MemId = Console.ReadLine()
            VDate = Console.ReadLine()
            If Len(MemId) = 6 And Len(VDate) = 8 Then
                record = MemId + " " + VDate
                sfilewriter.WriteLine(record)
            Else
                Console.WriteLine("Error")
            End If
            rogue = Console.ReadLine()
        Loop Until rogue = "X"
        sfilewriter.Close()
    End Sub
    Sub Append()
        Dim rogue As String = " "
        Dim MemId As String
        Dim VDate As String
        Dim record As String
        Dim sfileappend As StreamWriter
        sfileappend = File.AppendText("D:/Task4.txt")
        While rogue <> "X"
            MemId = Console.ReadLine()
            VDate = Console.ReadLine()
            If Len(MemId) = 6 And Len(VDate) = 8 Then
                record = MemId + " " + VDate
                sfileappend.WriteLine(record)
            Else
                Console.WriteLine("Error")
            End If
            rogue = Console.ReadLine()
        End While
        sfileappend.Close()
    End Sub
    Sub Find()
        Dim MemId As String = " "
        Dim sfilereader As StreamReader
        Dim Dataretrive As String
        Dim Found As Boolean

        sfilereader = File.OpenText("D:/Task4.txt")
        MemId = Console.ReadLine()
        While Len(MemId) <> 6
            Console.Write("Please Input Again:")
            MemId = Console.ReadLine()
        End While
        While Not sfilereader.EndOfStream
            Dataretrive = sfilereader.ReadLine()
            If MemId = Mid(Dataretrive, 1, 6) Then
                Console.WriteLine(Mid(Dataretrive, 8, 8))
                Found = True
            End If
        End While

        If Found = False Then
            Console.WriteLine("Member Not Found")
        End If

        sfilereader.Close()
    End Sub
End Module
