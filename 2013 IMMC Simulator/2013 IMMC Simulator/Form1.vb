Public Class Form1
    'Initialize inputs
    Function Arri0() As Decimal
        Return Val(TBarri0.Text)
    End Function

    Function Arri1() As Decimal
        Return Val(TBarri1.Text)
    End Function

    Function Arri2() As Decimal
        Return Val(TBarri2.Text)
    End Function

    Function Arri3() As Decimal
        Return Val(TBarri3.Text)
    End Function

    Function Arri4() As Decimal
        Return Val(TBarri4.Text)
    End Function

    Function Arri5() As Decimal
        Return Val(TBarri5.Text)
    End Function

    Function Serv1() As Decimal
        Return Val(TBserv1.Text)
    End Function

    Function Serv2() As Decimal
        Return Val(TBserv2.Text)
    End Function

    Function Serv3() As Decimal
        Return Val(TBserv3.Text)
    End Function

    Function Serv4() As Decimal
        Return Val(TBserv4.Text)
    End Function

    Dim arriRandom As New Random
    Dim servRandom As New Random

    Dim CustomerServeTimeList(149) As Integer '(Number)(Service Time)
    Dim CustomerArriveTimeList(149) As Integer
    Dim CustomerWaitingTimeList(149) As Integer
    Dim PreviousCustomersServeTimeSum

    'operation
    Private Sub Bstart_Click(sender As Object, e As EventArgs) Handles Bstart.Click
        Dim TotalSimulationResults As Decimal = 0
        Dim TotalSimulationWaitingCustomers As Decimal = 0
        For SimulateTimes = 1 To NumericUpDown1.Value
            Dim WaitingList(149) As Integer
            Array.Clear(CustomerServeTimeList, 0, 150)
            Array.Clear(CustomerArriveTimeList, 0, 150)
            Array.Clear(CustomerWaitingTimeList, 0, 150)
            TBresult.ResetText()
            For i = 0 To 149
                Select Case (Math.Round(servRandom.NextDouble(), 3))
                    Case 0 To Serv1()
                        CustomerServeTimeList(i) = 1
                    Case Serv1() + 0.001 To Serv1() + Serv2()
                        CustomerServeTimeList(i) = 2
                    Case Serv1() + Serv2() + 0.001 To Serv1() + Serv2() + Serv3()
                        CustomerServeTimeList(i) = 3
                    Case Serv1() + Serv2() + Serv3() + 0.001 To 1
                        CustomerServeTimeList(i) = 4
                End Select
            Next

            Dim AssignedArriveTimeCustomers = 0
            Dim GlobalTime = 0
            Do While AssignedArriveTimeCustomers < 150
                Randomize()
                Select Case (Math.Round(arriRandom.NextDouble(), 5))
                    Case 0 To Arri1()
                        CustomerArriveTimeList(AssignedArriveTimeCustomers) = GlobalTime
                    Case Arri1() + 0.00001 To Arri1() + Arri2()
                        CustomerArriveTimeList(AssignedArriveTimeCustomers) = GlobalTime + 1
                        GlobalTime += 1
                    Case Arri1() + Arri2() + 0.00001 To Arri1() + Arri2() + Arri3()
                        CustomerArriveTimeList(AssignedArriveTimeCustomers) = GlobalTime + 2
                        GlobalTime += 2
                    Case Arri1() + Arri2() + Arri3() + 0.00001 To Arri1() + Arri2() + Arri3() + Arri4()
                        CustomerArriveTimeList(AssignedArriveTimeCustomers) = GlobalTime + 3
                        GlobalTime += 3
                    Case Arri1() + Arri2() + Arri3() + Arri4() + 0.00001 To Arri1() + Arri2() + Arri3() + Arri4() + Arri5()
                        CustomerArriveTimeList(AssignedArriveTimeCustomers) = GlobalTime + 4
                        GlobalTime += 4
                    Case Else
                        CustomerArriveTimeList(AssignedArriveTimeCustomers) = GlobalTime + 5
                        GlobalTime += 5
                End Select
                AssignedArriveTimeCustomers += 1
            Loop

            GlobalTime = 0
            Dim InQueue = 0
            Dim ServedCustomers = 0
            Dim WaitingCustomers = 0
            Dim TotalWaitingCustomers = 0

            Do While ServedCustomers < 150
                TotalWaitingCustomers += WaitingCustomers
                For i = 0 To 149
                    If CustomerArriveTimeList(i) = GlobalTime Then
                        CustomerWaitingTimeList(i) = InQueue + CustomerServeTimeList(i)
                        InQueue += CustomerServeTimeList(i)
                        WaitingList(i) = i
                        WaitingCustomers += 1
                    End If
                Next
                For i = 0 To 149
                    If GlobalTime = CustomerArriveTimeList(i) + CustomerWaitingTimeList(i) Then
                        For j = 0 To 149
                            If WaitingList(j) = i Then
                                WaitingList(j) = 0
                                WaitingCustomers -= 1
                            End If
                        Next
                    End If
                Next
                InQueue -= 1
                If InQueue < 0 Then
                    InQueue = 0
                End If
                GlobalTime += 1
                ServedCustomers += 1
                If WaitingCustomers < 0 Then
                    WaitingCustomers = 0
                End If
            Loop
            TotalSimulationWaitingCustomers += TotalWaitingCustomers / GlobalTime

            Dim TotalWaitingTime = 0
            For i = 0 To 149
                TotalWaitingTime += CustomerWaitingTimeList(i)
            Next
            Dim AverageWaitingTime As Decimal = TotalWaitingTime / 150
            TotalSimulationResults += AverageWaitingTime

        Next
        TBresult.Text &= "Simulations Waiting Time Average: " & (TotalSimulationResults / NumericUpDown1.Value).ToString & vbCrLf &
            "Simulations Waiting Customers Average: " & (TotalSimulationWaitingCustomers / NumericUpDown1.Value).ToString
    End Sub
End Class
