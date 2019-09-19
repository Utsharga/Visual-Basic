Imports System.IO
Imports System.String
Module Module1
    Sub Main()
        'Dim inputagain As String
        Dim Sfilewriter As StreamWriter
        Dim Sname, DOB As String
        Dim i, SID As Integer
        Sfilewriter = File.CreateText("F:/Student.text")

        For i = 0 To 2
            Console.Write("Enter ID")
            SID = Console.ReadLine()
            Sfilewriter.WriteLine(SID)

            Console.Write("Enter NAme")
            Sname = Console.ReadLine()
            Sfilewriter.WriteLine(Sname)

            Console.Write("Enter DOB")
            DOB = Console.ReadLine()
            Sfilewriter.WriteLine(DOB)

        Next
        Sfilewriter.Close()

    End Sub

End Module
