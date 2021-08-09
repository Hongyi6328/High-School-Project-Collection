Public Class Form6174

    Dim target As String

    Function Bigger(a As String) As String
        Dim ContempInteger As String = ""
        Dim ContempString As String = a
        Dim ContempArray(3) As Integer
        For i = 0 To 3
            ContempArray(i) = Val(ContempString.Chars(i))
        Next
        Array.Sort(ContempArray)
        Array.Reverse(ContempArray)
        For i = 0 To 3
            ContempInteger &= ContempArray(i)
        Next
        Return ContempInteger
    End Function

    Function Smaller(a As String) As String
        Dim ContempInteger As String = ""
        Dim ContempString As String = a
        Dim ContempArray(3) As Integer
        For i = 0 To 3
            ContempArray(i) = Val(ContempString.Chars(i))
        Next
        Array.Sort(ContempArray)
        For i = 0 To 3
            ContempInteger &= ContempArray(i)
        Next
        Return ContempInteger
    End Function

    Function Difference(a As String, b As String) As String
        Dim negativeplace As Boolean = False
        Dim a1 = 0, b1 = 0
        Dim c As String = ""
        For i = 0 To 3
            a1 = Val(a(3 - i))
            b1 = Val(b(3 - i))
            If negativeplace Then
                a1 -= 1
            End If
            If a1 < b1 Then
                c = (a1 - b1 + 10).ToString & c
                negativeplace = True
            Else
                c = (a1 - b1).ToString & c
                negativeplace = False
            End If
        Next
        Return c
    End Function

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        target = nudNumber.Value.ToString
        Dim a, b As String
        TextBox1.ResetText()
        For i = 1 To 10
            a = Bigger(target)
            b = Smaller(target)
            TextBox1.Text += "Step " & i.ToString & ". Bigger: " & a & " . Smaller: " & b & " .. Result= " & Difference(a, b) & vbCrLf
            target = Difference(a, b)
        Next
        TextBox1.Text += "Done!"
    End Sub
End Class