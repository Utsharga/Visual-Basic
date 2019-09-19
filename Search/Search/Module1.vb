Imports System.IO
Imports System.String

Module Module1

    Sub Main()
        Dim Search As String
        Dim dataretrive As String
        Dim Found As Boolean = False
        Dim sfilereader As StreamReader

        sfilereader = File.OpenText("F:/Studennt.Text")
        Console.WriteLine("Enter Search")
        Search = Console.ReadLine()
        While Not sfilereader.EndOfStream And Found = False
            dataretrive
        End While

    End Sub

End Module
