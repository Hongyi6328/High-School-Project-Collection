Imports System.Xml
Imports System.IO

Public Class Recording

    Dim cricketerInfo = XElement.Load("players.xml")
    Dim runs, balls, innings, notOuts As Integer
    Dim avg, strikeRate As Single

    Private Sub Recording_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If cricketerInfo IsNot Nothing Then
            For Each batsman As XElement In cricketerInfo.elements
                If batsman.Name = "batsman" AndAlso batsman.HasElements Then
                    For Each stat As XElement In batsman.Elements
                        If stat.Name = "name" Then
                            cmbPlayers.Items.Add(stat.Value)
                        End If
                    Next
                End If
            Next
        Else
            cricketerInfo = Nothing
            Throw New Exception("The Players XML file cannot be found or is corrupt")
        End If

    End Sub

    Private Sub cmbPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayers.SelectedIndexChanged

        If cricketerInfo IsNot Nothing Then
            For Each batsman As XElement In cricketerInfo.elements
                If batsman.Name = "batsman" AndAlso batsman.HasElements Then
                    For Each stat As XElement In batsman.Elements
                        If stat.Name = "name" Then
                            If stat.Value = cmbPlayers.Text Then
                                For Each item As XElement In batsman.Elements
                                    If item.Name = "innings" Then
                                        innings = item.Value
                                    End If
                                    If item.Name = "runs" Then
                                        runs = item.Value
                                    End If
                                    If item.Name = "balls" Then
                                        balls = item.Value
                                    End If
                                    If item.Name = "notOuts" Then
                                        notOuts = item.Value
                                    End If
                                    If item.Name = "average" Then
                                        avg = item.Value
                                    End If
                                    If item.Name = "strikeRate" Then
                                        strikeRate = item.Value
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If
            Next

            lblAvgOut.Text = avg
            lblInningsOut.Text = innings
            lblNotOutsOut.Text = notOuts
            lblRunsOut.Text = runs
            lblStrikeRateOut.Text = strikeRate
            lblBallsOut.Text = balls
        Else
            cricketerInfo = Nothing
            Throw New Exception("The Players XML file cannot be found or is corrupt")
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        innings += 1
        runs += Val(txtRuns.Text)
        balls += Val(txtBalls.Text)
        If ckbNOut.Checked = True Then
            notOuts += 1
        End If
        avg = Math.Round(runs / (innings - notOuts), 2)
        strikeRate = Math.Round(runs / balls * 100, 2)

        lblAvgOut.Text = avg
        lblInningsOut.Text = innings
        lblNotOutsOut.Text = notOuts
        lblRunsOut.Text = runs
        lblStrikeRateOut.Text = strikeRate
        lblBallsOut.Text = balls

        writeToCSV()

        For Each batsman As XElement In cricketerInfo.elements
            If batsman.Name = "batsman" AndAlso batsman.HasElements Then
                For Each stat As XElement In batsman.Elements
                    If stat.Name = "name" Then
                        If stat.Value = cmbPlayers.Text Then
                            For Each item As XElement In batsman.Elements
                                If item.Name = "innings" Then
                                    item.Value = "test"
                                End If
                            Next
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If cricketerInfo IsNot Nothing Then
            For Each batsman As XElement In cricketerInfo.elements
                If batsman.Name = "batsman" AndAlso batsman.HasElements Then
                    For Each stat As XElement In batsman.Elements
                        If stat.Name = "name" Then
                            If stat.Value = cmbPlayers.Text Then
                                For Each item As XElement In batsman.Elements
                                    If item.Name = "innings" Then
                                        item.Value = innings
                                    End If
                                    If item.Name = "runs" Then
                                        item.Value = runs
                                    End If
                                    If item.Name = "balls" Then
                                        item.Value = balls
                                    End If
                                    If item.Name = "notOuts" Then
                                        item.Value = notOuts
                                    End If
                                    If item.Name = "average" Then
                                        item.Value = avg
                                    End If
                                    If item.Name = "strikeRate" Then
                                        item.Value = strikeRate
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If
            Next

            cricketerInfo.save("players.xml")
            MessageBox.Show("File has been updated", "Good News!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            cricketerInfo = Nothing
            Throw New Exception("The Players XML file cannot be found or is corrupt")
        End If

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        MainPage.Show()
        Hide()
    End Sub

    Sub writeToCSV()
        Dim inningsDate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Dim inningstime As String = String.Format("{0:HH:mm}", DateTime.Now)
        Dim notOut As Boolean
        If ckbNOut.Checked Then
            notOut = True
        Else notout = False
        End If
        Dim fs As Filestream
        Dim file As IO.File
        Dim fileName As String = "Innings History.csv"

        Dim data As String

        If file.Exists(fileName) Then
            fs = New FileStream(fileName, FileMode.Append, FileAccess.Write)
            data =
               vbCrLf & cmbPlayers.Text & "," & inningsDate & "," & inningstime & "," _
                & txtRuns.Text & "," & txtBalls.Text & "," & notOut.ToString
        Else
            fs = New FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)
            data =
                 cmbPlayers.Text & "," & inningsDate & "," & inningstime & "," _
                & txtRuns.Text & "," & txtBalls.Text & "," & notOut.ToString
        End If

        Dim sw As New StreamWriter(fs, System.Text.Encoding.Default)

        If File.Exists(fileName) Then
            sw.BaseStream.Seek(0, SeekOrigin.End)
        Else
            sw.BaseStream.Seek(0, SeekOrigin.Begin)
        End If

        sw.Write(data)

        sw.Close()
    End Sub
End Class