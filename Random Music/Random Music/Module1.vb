Module Module1

    Sub Main()
        Dim rnd As New Random
        Dim A_major = {-12, -10, -8, -7, -5, -3, -1, 0, 2, 4, 5, 7, 9, 11, 12}

        If False Then
            Dim posi = 0
            Dim tunes = {"A3", "B3", "C#4", "D4", "E4", "F#4", "G#4", "A4", "B4", "C#5", "D5", "E5", "F#5", "G#5", "A5"}
            For i = 0 To 10000
                Dim freq = 440 * 2 ^ (1 / 12 * A_major(posi))
                Console.Write(tunes(posi) & ", ")
                posi = Math.Round(rnd.NextDouble * 14)
                Console.Beep(freq, 1000)
            Next
        End If

        If True Then
            Dim twinkleStars = {0, 0, 7, 7, 9, 9, 7, 0.5, 5, 5, 4, 4, 2, 2, 0, 0.5}
            Dim odeToJoy = {4, 4, 5, 7, 7, 5, 4, 2, 0, 0, 2, 4, 4, 0.5, 2, 2, 0.5, 0.5, 4, 4, 5, 7, 7, 5, 4, 2, 0, 0, 2, 4, 2, 0.5, 0, 0}

            Dim notes = odeToJoy
            For i = 0 To notes.GetUpperBound(0)
                Dim freq As Double
                If notes(i) = 0.5 Then
                    Threading.Thread.Sleep(1000)
                Else
                    freq = 440 * 2 ^ ((2 + notes(i)) / 12)
                    Console.Beep(freq, 1000)
                End If
            Next
        End If

        If False Then
            Dim notes = {0, 2, 4, 5, 7, 9, 11, 12, 14, 16, 17, 19, 21, 23, 24}
            Dim posi As Integer = 7
            For i = 0 To 10000
                If posi = 0 Then
                    posi += Math.Round(rnd.NextDouble)
                    GoTo freqIndicated
                End If
                If posi = 14 Then
                    posi -= Math.Round(rnd.NextDouble)
                    GoTo freqIndicated
                End If
                posi += Math.Round(rnd.NextDouble * 2) - 1
freqIndicated:
                Dim freq As Double = 220 * 2 ^ (notes(posi) / 12 + 3)
                Console.Beep(freq, 1000)
            Next
        End If
    End Sub

End Module