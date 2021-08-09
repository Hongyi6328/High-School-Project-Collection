Module Module1

    Sub Main()

        If False Then
            Dim uppers = "QWERTYUIOPASDFGHJKLZXCVBNM"
            Dim lowers = "qwertyuiopasdfghjklzxcvbnm"
            Dim rnd = New Random
            Dim wordLen, sentLen
            For sent = 0 To 1000
                sentLen = Math.Round(rnd.NextDouble * 13) + 2
                Console.Write(uppers(Math.Round(rnd.NextDouble() * 25)))
                For word = 0 To sentLen
                    wordLen = Math.Round(rnd.NextDouble * 8) + 2
                    For chars = 0 To wordLen
                        Console.Write(lowers(Math.Round(rnd.NextDouble * 25)))
                    Next
                    If Not word = sentLen Then
                        Console.Write(" ")
                    End If
                Next
                Console.Write(". ")
            Next
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''

        If False Then
            Dim rnd0 As New Random
            Dim chars = " ,.;'[]\`=-)(*&^%$#@!|?><:/}{~1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"
            For i = 0 To 10000
                Dim posi = Math.Round(rnd0.NextDouble * (chars.Length - 1))
                Console.Write(chars(posi))
            Next
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''

        If False Then
            Dim rnd0 As New Random
            Dim chars = "         qwertyuiopasdfghjklzxcvbnm"
            For i = 0 To 10000
                Dim posi = Math.Round(rnd0.NextDouble * (chars.Length - 1))
                Console.Write(chars(posi))
            Next
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''

        If True Then
            Dim a = 0
            Dim rnd As New Random
            Dim posi1 = 30, posi2 = 60, posi3 = 90, posi4 = 120
            Dim posis1(2), posis2(2), posis3(2), posis4(2)
            Dim acc_flat = 0
            Dim posi_flat = 0
            Dim posis_flat(10)
            Dim next_flat = 0
            While a = 0
                posi1 = Math.Round(rnd.NextDouble * 140) + 5
                posi2 = Math.Round(rnd.NextDouble * 140) + 5
                Dim move1 = Math.Round(rnd.NextDouble * 2) - 1
                Dim move2 = Math.Round(rnd.NextDouble * 2) - 1
                Dim move3 = Math.Round(rnd.NextDouble * 2) - 1
                Dim move4 = Math.Round(rnd.NextDouble * 2) - 1
                If acc_flat = 0 Then
                    next_flat = Math.Round(rnd.NextDouble * 40)
                    posi_flat = Math.Round(rnd.NextDouble * 140) + 5
                    For i = 0 To 10
                        posis_flat(i) = posi_flat + i - 5
                    Next
                End If
                posi1 += move1
                posi2 += move2
                posi3 += move3
                posi4 += move4
                If posi1 > 150 Then
                    posi1 = 150
                End If
                If posi1 < 1 Then
                    posi1 = 1
                End If
                If posi2 > 150 Then
                    posi2 = 150
                End If
                If posi2 < 1 Then
                    posi2 = 1
                End If
                If posi3 > 150 Then
                    posi3 = 150
                End If
                If posi3 < 1 Then
                    posi3 = 1
                End If
                If posi4 > 150 Then
                    posi4 = 150
                End If
                If posi4 < 1 Then
                    posi4 = 1
                End If
                For i = 0 To 2
                    posis1(i) = posi1 + i - 1
                    posis2(i) = posi2 + i - 1
                    posis3(i) = posi3 + i - 1
                    posis4(i) = posi4 + i - 1
                Next
                For i = 0 To 151
                    Dim line As Boolean = False
                    Dim collide As Boolean = False
                    For j = 0 To 2
                        If i = posis1(j) Or i = posis2(j) Or i = posis3(j) Or i = posis4(j) Then
                            line = True
                            GoTo line_true
                        End If
                    Next
line_true:
                    For Each ele1 In posis_flat
                        For Each ele2 In posis1
                            If ele1 = ele2 Then
                                collide = True
                                posi_flat = Math.Round(rnd.NextDouble * 140) + 5
                                GoTo collided
                            End If
                        Next
                    Next
collided:
                    If line Then
                        Console.Write("|")
                    Else
                        Console.Write("*")
                    End If
                Next
                Console.WriteLine()
                acc_flat = 0
            End While
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''

        Console.Read()

    End Sub

End Module
