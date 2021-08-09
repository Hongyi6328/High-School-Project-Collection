Public Class FormPi
    Const r = 1, d = 2, h = 2 ^ (1 / 2) / 2
    Dim pi As Decimal, rt As Decimal = 1, b As Decimal = (2 ^ (1 / 2) / 2), θ As Decimal = 45D, p As ULong = 1D, result As Decimal, bt As Decimal
    Dim q As Integer = 1, o As Integer = 1, tb1 As Integer = 0, tb2 As Integer = 0, con As Integer
    Dim time1, time2 As DateTime
    Dim interval As TimeSpan

    Friend Structure Structname
        Dim longlong As Type()
    End Structure

    Sub WasteTime(ByVal timeToWaste As Single)
        Dim startTime As Single
        startTime = DateAndTime.Timer
        Do While startTime + timeToWaste > DateAndTime.Timer
            Application.DoEvents()
        Loop
    End Sub

    Sub Mth1()
        If tb1 = 0 Then
            Timer1.Dispose()
            Timer1.Start()
            time1 = Now
            tb1 = 1
        End If
        For f = 1 To q
            result = (result + (o * 4 / (p)))
            TextBox1.Text = (Val(result))
            p = p + 2
            o = (-1) * o
            WasteTime(0)
            TTimes.Text = Val(con + f)
        Next
        con = con + q
        q = 10 * q
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Sub Mth2()
        If tb2 = 0 Then
            Timer1.Dispose()
            Timer1.Start()
            time1 = Now
            tb2 = 1
        End If
        For f = 1 To 25
            θ = θ / 2
            bt = b
            b = b + rt
            rt = (b ^ 2 + h ^ 2) ^ (1 / 2)
            pi = (360 / θ) * (1 / (rt)) * h / 2
            WasteTime(0.5)
            TTimes.Text = Val(con + f)
            TextBox1.Text = String.Format("{0:N18}", Val(pi))
        Next
        con = con + 25
        Timer1.Stop()
    End Sub

    Private Sub BReset_Click(sender As Object, e As EventArgs) Handles BReset.Click
        Timer1.Dispose()
        con = 1
        θ = 45
        tb1 = 0
        tb2 = 0
        pi = Nothing
        result = Nothing
        bt = Nothing
        o = 1
        p = 1
        rt = 1
        b = 2 ^ (1 / 2) / 2
        TextBox1.ResetText()
        TTime.Text = "00:00:0000"
        TTimes.Text = "0"
    End Sub

    Private Sub BStop_Click(sender As Object, e As EventArgs) Handles BStop.Click

    End Sub

    Private Sub BM1_Click(sender As Object, e As EventArgs) Handles BM1.Click
        Mth1()
    End Sub

    Private Sub BM2_Click(sender As Object, e As EventArgs) Handles BM2.Click
        Mth2()
    End Sub
End Class