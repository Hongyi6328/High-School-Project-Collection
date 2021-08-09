Imports System.ComponentModel

Public Class FormSineRule
    Dim o 'by Felix Huang

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TBsideB.ReadOnly = True
            TBangleB.ReadOnly = False
            o = 0
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TBsideB.ReadOnly = False
            TBangleB.ReadOnly = True
            o = 1
        End If 'by Felix Huang
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sideA As Decimal = Val(TBsideA.Text)
        Dim angleA_deg As Decimal = Val(TBangleA.Text)
        Dim angleA_rad As Decimal = angleA_deg * Math.PI / 180
        Dim sideB As Decimal
        Dim angleB_deg As Decimal
        Dim angleB_rad As Decimal
        If o = 0 Then
            angleB_deg = Val(TBangleB.Text)
            angleB_rad = angleB_deg * Math.PI / 180
            sideB = sideA / Math.Sin(angleA_rad) * Math.Sin(angleB_rad)
            TBsideB.Text = sideB
        End If
        If o = 1 Then
            sideB = Val(TBsideB.Text)
            angleB_rad = Math.Asin((Math.Sin(angleA_rad)) / sideA * sideB)
            angleB_deg = angleB_rad * 180 / Math.PI
            TBangleB.Text = angleB_deg
        End If
        Dim angleC As Decimal = 180 - angleA_deg - angleB_deg
        TBangleC.Text = angleC
        Dim sideC As Decimal = sideA / (Math.Sin(angleA_rad)) * Math.Sin(angleC / 180 * Math.PI)
        TBsideC.Text = sideC 'by Felix Huang
    End Sub

    Private Sub TBknownlength_GotFocus(sender As Object, e As EventArgs) Handles TBsideA.GotFocus
        TBsideA.ResetText()
    End Sub

    Private Sub TBknownsine_GotFocus(sender As Object, e As EventArgs) Handles TBangleA.GotFocus
        TBangleA.ResetText()
    End Sub

    Private Sub TBunknownlength_GotFocus(sender As Object, e As EventArgs) Handles TBsideB.GotFocus
        TBsideB.ResetText()
    End Sub

    Private Sub TBunknownsine_GotFocus(sender As Object, e As EventArgs) Handles TBangleB.GotFocus
        TBangleB.ResetText()
    End Sub

    Private Sub FormSineRule_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormMenu.Show()
    End Sub
End Class