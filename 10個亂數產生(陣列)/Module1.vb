Module Module1

    Sub Main()
        Randomize()
        Dim a(5) As Integer
        Dim x, i, j, e As Integer
        Dim str, p As String
        str = ""
        x = 0
        For x = 0 To 5
            a(x) = Int(Rnd() * 49) + 1
            str = a(x) & "  " & str
        Next
        For i = 0 To UBound(a) - 1
            For j = i + 1 To UBound(a)
                If a(i) > a(j) Then
                    e = a(i)
                    a(i) = a(j)
                    a(j) = e
                End If
            Next
        Next

        Console.WriteLine("未排序:" & str)
        For i = 0 To UBound(a)
            Console.Write(a(i) & " ")
        Next


        Console.Read()
    End Sub

End Module
