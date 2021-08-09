Public Class Form1

    Dim path As String = "test.bmp"
    Dim rnd As New Random

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim SourceBMP As New Bitmap(path)
        picBoxDisplay.Image = SourceBMP
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        IMGManipulation()
    End Sub

    Sub IMGManipulation()
        Dim SourceBMP As New Bitmap(path)
        Dim width = SourceBMP.Size.Width
        Dim height = SourceBMP.Size.Height

        Dim targetBMP As New Bitmap(width, height)
        Dim strength = TrackBarStrength.Value

        If radFuzzy.Checked Then
            targetBMP = fuzzy(SourceBMP, strength)
        ElseIf radmosaic.checked Then
            targetBMP = mosaic(SourceBMP, strength)
        Else
            For x = 0 To width - 1
                For y = 0 To height - 1
                    Dim _colour = SourceBMP.GetPixel(x, y)
                    Dim r = _colour.R
                    Dim g = _colour.G
                    Dim b = _colour.B

                    _colour = colourOperation(r, g, b, strength)

                    targetBMP.SetPixel(x, y, _colour)
                Next
            Next
        End If

        picBoxDisplay.Image = targetBMP

    End Sub


    Private Sub TrackBarB_ValueChanged(sender As Object, e As EventArgs) Handles TrackBarB.ValueChanged
        displaySampleColour()
    End Sub

    Private Sub TrackBarG_ValueChanged(sender As Object, e As EventArgs) Handles TrackBarG.ValueChanged
        displaySampleColour()
    End Sub

    Private Sub TrackBarR_ValueChanged(sender As Object, e As EventArgs) Handles TrackBarR.ValueChanged
        displaySampleColour()
    End Sub

    Function colourOperation(r As Integer, g As Integer, b As Integer, strength As Integer) As Color
        If radLinearLightening.Checked Then
            r = Math.Round(r + (255 - r) * strength / 20)
            g = Math.Round(g + (255 - g) * strength / 20)
            b = Math.Round(b + (255 - b) * strength / 20)
        End If

        If radExpLightening.Checked Then
            r = Math.Round(256 * Math.Exp(1 / 45 / strength * (r - 255)) - 0.9)
            g = Math.Round(256 * Math.Exp(1 / 45 / strength * (g - 255)) - 0.9)
            b = Math.Round(256 * Math.Exp(1 / 45 / strength * (b - 255)) - 0.9)
            If r < 0 Then r = 0
            If g < 0 Then g = 0
            If b < 0 Then b = 0
        End If

        If radBoundedLightening.Checked Then
            r = Math.Round(255 - 255 * Math.Exp(-(7 + strength) * r / 255))
            g = Math.Round(255 - 255 * Math.Exp(-(7 + strength) * g / 255))
            b = Math.Round(255 - 255 * Math.Exp(-(7 + strength) * b / 255))
        End If

        If radLogisticWhiten.Checked Then
            r = Math.Round(256 / (1 + 255 * Math.Exp(-0.04 * strength * r))) - 1
            g = Math.Round(256 / (1 + 255 * Math.Exp(-0.04 * strength * g))) - 1
            b = Math.Round(256 / (1 + 255 * Math.Exp(-0.04 * strength * b))) - 1
        End If

        Dim r0 = TrackBarR.Value
        Dim g0 = TrackBarG.Value
        Dim b0 = TrackBarB.Value

        If radNonSimilarColourApproach.Checked Then
            r = (r - r0) ^ 2 / 255 * strength / 20
            g = (g - g0) ^ 2 / 255 * strength / 20
            b = (b - b0) ^ 2 / 255 * strength / 20
        End If

        If radSimilarColourApproach.Checked Then
            r = r + (r0 - r) * strength / 20
            g = g + (g0 - g) * strength / 20
            b = b + (b0 - b) * strength / 20
        End If

        If radInverse.Checked Then
            r = 255 - r
            g = 255 - g
            b = 255 - b
        End If

        If radBlackBlock.Checked Then
            If r + b + g >= 382.5 + 38 * (strength - 10) Then '382.5=3*255/2
                r = 255
                b = 255
                g = 255
            Else
                r = 0
                g = 0
                b = 0
            End If
        End If

        If radDistortion.Checked Then
            r = r + Math.Round(rnd.NextDouble() * strength * 4 - 10)
            g = g + Math.Round(rnd.NextDouble() * strength * 4 - 10)
            b = b + Math.Round(rnd.NextDouble() * strength * 4 - 10)
            Select Case r
                Case > 255
                    r = 255
                Case < 0
                    r = 0
            End Select
            Select Case g
                Case > 255
                    g = 255
                Case < 0
                    g = 0
            End Select
            Select Case b
                Case > 255
                    b = 255
                Case < 0
                    b = 0
            End Select

        End If

        Dim _colour = Color.FromArgb(r, g, b)
        Return _colour

    End Function

    Sub displaySampleColour()
        Dim r = TrackBarR.Value
        Dim g = TrackBarG.Value
        Dim b = TrackBarB.Value
        Dim _colour = Color.FromArgb(r, g, b)
        lblRGB.ForeColor = _colour
    End Sub

    Private Sub picBoxDisplay_DoubleClick(sender As Object, e As EventArgs) Handles picBoxDisplay.DoubleClick
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\Users\qo\source\repos\Pic Filter\Pic Filter\bin\Debug"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            path = fd.FileName
        End If

        Dim SourceBMP As New Bitmap(path)
        picBoxDisplay.Image = SourceBMP
    End Sub

    Function fuzzy(sourceBMP As Bitmap, strength As Integer) As Bitmap
        Dim width = sourceBMP.Width
        Dim height = sourceBMP.Height
        Dim targetBMP As New Bitmap(width, height)
        Dim existingNum = 0
        Dim rTotal, gTotal, bTotal
        For x = 0 To width - 1
            For y = 0 To height - 1
                existingNum = 0
                rTotal = 0
                gTotal = 0
                bTotal = 0

                For i = -strength To strength
                    If x + i < 0 Or x + i > width - 1 Then
                    Else
                        For j = -strength To strength
                            If y + j < 0 Or y + j > height - 1 Then
                            Else
                                Dim _colour = sourceBMP.GetPixel(i + x, j + y)
                                rTotal += _colour.R
                                gTotal += _colour.G
                                bTotal += _colour.B
                                existingNum += 1
                            End If
                        Next
                    End If
                Next

                Dim r = Math.Round(rTotal / existingNum)
                Dim g = Math.Round(gTotal / existingNum)
                Dim b = Math.Round(bTotal / existingNum)

                targetBMP.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
        Next

        Return targetBMP
    End Function

    Function mosaic(sourceBMP As Bitmap, strength As Integer) As Bitmap
        Dim width = sourceBMP.Width
        Dim height = sourceBMP.Height
        Dim targetBMP As New Bitmap(width, height)
        Dim pixels(Math.Floor(width / strength), Math.Floor(height / strength)) As Color
        Dim existingNum = 0
        Dim rTotal, gTotal, bTotal
        existingNum = 0

        Dim xStep, yStep
        If Math.IEEERemainder(width, strength) = 0 Then
            xStep = width / strength - 1
        Else
            xStep = Math.Floor(width / strength)
        End If
        If Math.IEEERemainder(height, strength) = 0 Then
            yStep = height / strength - 1
        Else
            yStep = Math.Floor(height / strength)
        End If

        If strength = 1 Then
            Return sourceBMP
        Else
            For x = 0 To xStep
                For y = 0 To yStep
                    rTotal = 0
                    gTotal = 0
                    bTotal = 0
                    existingNum = 0
                    For i = 0 To strength - 1
                        If x * strength + i > width - 1 Then
                        Else
                            For j = 0 To strength - 1
                                If y * strength + j > height - 1 Then
                                Else
                                    rTotal += sourceBMP.GetPixel(x * strength + i, y * strength + j).R
                                    gTotal += sourceBMP.GetPixel(x * strength + i, y * strength + j).G
                                    bTotal += sourceBMP.GetPixel(x * strength + i, y * strength + j).B
                                    existingNum += 1
                                End If
                            Next
                        End If
                    Next

                    Dim r = rTotal / existingNum
                    Dim g = gTotal / existingNum
                    Dim b = bTotal / existingNum

                    Dim _colour = Color.FromArgb(r, g, b)

                    For i = 0 To strength - 1
                        If x * strength + i > width - 1 Then
                        Else
                            For j = 0 To strength - 1
                                If y * strength + j > height - 1 Then
                                Else
                                    targetBMP.SetPixel(x * strength + i, y * strength + j, _colour)
                                End If
                            Next
                        End If
                    Next
                Next
            Next

            Return targetBMP
        End If
    End Function

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click

        Dim targetBMP As New Bitmap(600, 600)

        If radColour.Checked Then
            For i = 0 To 599
                For j = 0 To 599
                    Dim r = Math.Round(rnd.NextDouble * 255, 0)
                    Dim g = Math.Round(rnd.NextDouble * 255, 0)
                    Dim b = Math.Round(rnd.NextDouble * 255, 0)
                    Dim colour As Color = Color.FromArgb(r, g, b)
                    targetBMP.SetPixel(i, j, colour)
                Next
            Next
        End If

        If radBlackAndWhite.Checked Then
            For i = 0 To 599
                For j = 0 To 599
                    Dim colour As Color
                    If Math.Round(rnd.NextDouble, 0) = 0 Then
                        colour = Color.Black
                    Else
                        colour = Color.White
                    End If
                    targetBMP.SetPixel(i, j, colour)
                Next
            Next
        End If

        picBoxDisplay.Image = targetBMP
    End Sub
End Class
