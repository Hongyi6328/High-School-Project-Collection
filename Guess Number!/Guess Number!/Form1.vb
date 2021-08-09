'This program is written by Felix 
'On 26 July
'For providing environment to play a number guesing game
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class Form1
    'to preset
    Dim secret As Integer
    Dim number As Integer
    Dim TimeStarted, TimeInterval, TimeFinished As DateTime
    Dim interval, record, display, TotalTime As TimeSpan
    Dim TurnIsDone
    Dim RightOrWrong = 0
    Dim operation = 0, RecordedOperation
    Dim TotalOperation As Integer = 0, turn As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'to preset
        TurnIsDone = 0
        secret = 1
        Randomize()
        secret = Int((100 - 1 + 1) * Rnd() + 1)
        lstFeedback.Items.Add("Tips are showed below:")
        timestarted = DateTime.Now
        Timer1.Dispose()
        Timer1.Start()
        txtInput.Select()
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        'to prevent entering characters
        Dim index As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^\d]")
        txtInput.Text = index.Replace(txtInput.Text, "")
        number = Val(txtInput.Text)
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        'to prevent entering characters
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnReStart.Click
        'to clear all shown information
        secret = 1
        Randomize()
        secret = Int(Rnd() * 100 + 1)
        number = Nothing
        txtInput.ReadOnly = False
        txtInput.ResetText()
        txtInput.Select()
        lstFeedback.Items.Clear()
        lstFeedback.Items.Add("Tips are showed below:")
        operation = 0
        TimeStarted = DateTime.Now
        Timer1.Dispose()
        Timer1.Start()
    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        'to compare the two numbers and show users resaults
        operation = operation + 1
        If number > secret Then
            lstFeedback.Items.Add(lstFeedback.Text & vbCrLf & Val(number) & " is too high.")
        Else
            If number < secret Then
                lstFeedback.Items.Add(lstFeedback.Text & vbCrLf & Val(number) & " is too low.")
            Else
                turn = turn + 1
                lstFeedback.Items.Clear()
                lstFeedback.Items.Add("Yeah! You guessed correctly!")
                lstFeedback.Items.Add(Val(number) & " is the number.")
                txtInput.ReadOnly = True
                TimeInterval = DateTime.Now
                If TurnIsDone = 0 Then
                    record = TimeInterval - TimeStarted
                    RecordedOperation = operation
                    TurnIsDone = 1
                    Timer1.Stop()
                End If
                If TurnIsDone = 1 Then
                    interval = TimeInterval - TimeStarted
                    TurnIsDone = 1
                    If operation < RecordedOperation Then
                        RecordedOperation = operation
                    End If
                    Timer1.Stop()
                End If
                If interval < record Then
                    record = interval
                End If
                totaltime = totaltime + interval
                TotalOperation = TotalOperation + operation
                txtTimer.Text = (" Your best record is " & record.TotalSeconds.ToString & "s." & vbCrLf & "Or with " & Val(RecordedOperation) & " times of guessing.")
            End If
        End If
        txtInput.Clear()
        txtInput.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit function
        End
    End Sub

    Private Sub Timer1_Ticking(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeFinished = DateTime.Now
        display = TimeFinished - TimeStarted
        txt.Text = ("You've spent " & display.TotalSeconds.ToString & "s in this turn." & vbCrLf & "You've guessed for " & Val(operation) & " times.")
    End Sub

    Private Sub txtInfo_ReadOnlyChanged(sender As Object, e As EventArgs) Handles txtInput.ReadOnlyChanged
        If txtInput.ReadOnly = True Then
            btnGuess.Enabled = False
        End If
        If txtInput.ReadOnly = False Then
            btnGuess.Enabled = True
        End If
    End Sub

    Private Sub txtInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If txtInput.ReadOnly = False Then
            If e.KeyCode = Keys.Enter Then
                'to compare the two numbers and show users resaults
                operation = operation + 1
                If number > secret Then
                    lstFeedback.Items.Add(lstFeedback.Text & vbCrLf & Val(number) & " is too high.")
                Else
                    If number < secret Then
                        lstFeedback.Items.Add(lstFeedback.Text & vbCrLf & Val(number) & " is too low.")
                    Else
                        turn = turn + 1
                        lstFeedback.Items.Clear()
                        lstFeedback.Items.Add("Yeah! You guessed correctly!")
                        lstFeedback.Items.Add(Val(number) & " is the number.")
                        txtInput.ReadOnly = True
                        TimeInterval = DateTime.Now
                        If TurnIsDone = 0 Then
                            record = TimeInterval - TimeStarted
                            RecordedOperation = operation
                            TurnIsDone = 1
                            Timer1.Stop()
                        End If
                        If TurnIsDone = 1 Then
                            interval = TimeInterval - TimeStarted
                            TurnIsDone = 1
                            If operation < RecordedOperation Then
                                RecordedOperation = operation
                            End If
                            Timer1.Stop()

                        End If
                        If interval < record Then
                            record = interval
                        End If
                        totaltime = totaltime + interval
                        TotalOperation = TotalOperation + operation
                        txtTimer.Text = (" Your best record is " & record.TotalSeconds.ToString & "s." & vbCrLf & "Or with " & Val(RecordedOperation) & " times of guessing.")
                    End If
                End If
                txtInput.Clear()
                txtInput.Select()
            End If
            If e.KeyCode = Keys.R And Keys.ControlKey Then
                secret = 1
                Randomize()
                secret = Int(Rnd() * 1000 + 1)
                number = Nothing
                txtInput.ReadOnly = False
                txtInput.ResetText()
                txtInput.Select()
                lstFeedback.Items.Clear()
                lstFeedback.Items.Add("Tips are showed below:")
                operation = 0
                TimeStarted = DateTime.Now
                Timer1.Dispose()
                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        If turn > 0 Then
            txtInput.Clear()
            txtInput.ReadOnly = True
            btnGuess.Enabled = False
            lstFeedback.Items.Clear()
            lstFeedback.Items.Add("You've won " & Val(turn) & " turns.")
            lstFeedback.Items.Add("Your total times of guessing are ")
            lstFeedback.Items.Add(Val(TotalOperation) & ".")
            lstFeedback.Items.Add("You correct rate is ")
            lstFeedback.Items.Add(Val(turn / TotalOperation * 100) & "%.")
            lstFeedback.Items.Add("You've totally spent ")
            lstFeedback.Items.Add(totaltime.TotalMinutes.ToString)
            lstFeedback.Items.Add("min on game.")
            lstFeedback.Items.Add("In average, you're correct per")
            lstFeedback.Items.Add(Val(TotalOperation / turn) & " operations")
            lstFeedback.Items.Add("Also, you guess in ")
            lstFeedback.Items.Add(Val(TotalTime.TotalSeconds / TotalOperation) & "s each once.")
            lstFeedback.Items.Add("Keep fighting, good luck.")
            lstFeedback.Items.Add("Click ReStart or press Ctrl+R")
            lstFeedback.Items.Add("to continue.")
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.R And Keys.ControlKey Then
            secret = 1
            Randomize()
            secret = Int(Rnd() * 1000 + 1)
            number = Nothing
            txtInput.ReadOnly = False
            txtInput.ResetText()
            txtInput.Select()
            lstFeedback.Items.Clear()
            lstFeedback.Items.Add("Tips are showed below:")
            operation = 0
            TimeStarted = DateTime.Now
            Timer1.Dispose()
            Timer1.Start()
        End If
    End Sub
End Class
