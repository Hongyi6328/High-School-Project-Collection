Public Class FormPrimeNumbers
    Dim KnownPrimeNumbers(0) As Integer
    Dim NumberNumbers As Integer = 0

    Function Target() As Integer
        Return nudDomain.Value
    End Function

    Function FactorList(index As Integer) As String
        FactorList = "All factors of " & index.ToString & " :" & vbCrLf
        For i = 1 To Math.Floor(index / 2)
            If Math.IEEERemainder(index, i) = 0 Then
                FactorList += i.ToString & " , "
            End If
        Next
        FactorList += index.ToString
        Return FactorList
    End Function

    Function IsPrime(index As Integer) As Boolean
        For i = 0 To NumberNumbers
            If Math.IEEERemainder(index, KnownPrimeNumbers(i)) = 0 Then
                Return False
                Exit Function
            End If
        Next
        NumberNumbers += 1
        ReDim Preserve KnownPrimeNumbers(NumberNumbers)
        KnownPrimeNumbers(NumberNumbers) = index
        Return True
    End Function

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        txtOutput.ResetText()
        NumberNumbers = 0
        KnownPrimeNumbers(NumberNumbers) = 2
        If rbtnListPri.Checked Then
            txtOutput.Text = "All prime numbers that are smaller than " & Target() & ": 2 , "
            For i = 2 To Target()
                If IsPrime(i) Then
                    txtOutput.Text += i.ToString & " , "
                End If
            Next
            txtOutput.Text += vbCrLf & "Done!"
        ElseIf rbtnListFac.Checked Then
            txtOutput.Text = FactorList(Target)
        Else
            MsgBox("Invalid input")
        End If
    End Sub
End Class