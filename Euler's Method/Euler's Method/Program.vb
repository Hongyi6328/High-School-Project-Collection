Imports System

Module Program
    Sub Main(args As String())
        EulersMethod(2, 1, 1 / 50, 50)
        Console.Read()
    End Sub

    Function EulersMethod(x, y, h, repeat)
        Dim yn = y - 6 * x * h
        Dim xn = Math.Round(x + h, 2)
        Dim dy_dx = Math.Round(-6 * x, 2)
        Console.WriteLine(xn & ", " & Math.Round(yn, 5) & ", " & dy_dx)
        If repeat = 1 Then
            Return yn
        Else
            Return EulersMethod(xn, yn, h, repeat - 1)
        End If
    End Function
End Module
