Imports System.ComponentModel

Public Class FormFibonacci

    Dim a As String,
        b As String,
        c As String
    Dim IntegerPlaces As Integer = 50
    Dim overflow As Boolean = False

    Function C_(A As String, B As String) As String
        Dim contem1 As Integer
        Dim contem2 As Integer = 0
        Dim contem3 As String = ""
        For i = 0 To IntegerPlaces - 1
            contem1 = Val(A.Chars(IntegerPlaces - 1 - i)) + Val(B.Chars(IntegerPlaces - 1 - i)) + contem2
            If contem1 > 9 Then
                contem1 -= 10
                contem2 = 1
                If i = IntegerPlaces - 1 Then
                    overflow = True
                End If
            Else
                contem2 = 0
            End If
            contem3 = contem1.ToString & contem3
        Next
        Return contem3
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        txtResults.ResetText()
        overflow = False
        IntegerPlaces = nudIntPlaces.Value
        a = "1"
        b = "1"
        For i = 1 To IntegerPlaces - 1
            a = "0" & a
            b = "0" & b
        Next
        For i = 1 To 2
            txtResults.Text += i & " : --------" & a & vbCrLf
        Next
        For i = 3 To nudTerms.Value - 1
            c = C_(a, b)
            txtResults.Text += i & " : --------" & c & vbCrLf
            a = b
            b = c
        Next
        c = C_(a, b)
        txtResults.Text += nudTerms.Value & " : --------" & c & vbCrLf
        txtResults.Text += "Done. Overflow occurred: " & overflow.ToString
    End Sub

    Private Sub FormFibonacci_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormMenu.Show()
    End Sub
End Class