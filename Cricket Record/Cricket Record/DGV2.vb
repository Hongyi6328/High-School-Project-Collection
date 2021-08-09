Imports System.IO
Imports System.Text

Public Class DGV2
    Dim batmans(,)
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        MainPage.Show()
    End Sub

    Private Sub DGV2_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dgvBatmans.Rows.Clear()
        Dim fileName As String = "Innings History.csv"
        Dim fr As New StreamReader(fileName)
        Dim sline As String
        Dim x = 0
        Do
            sline = fr.ReadLine()
            If sline = Nothing Then Exit Do
            Dim words() As String = sline.Split(",")
            dgvBatmans.Rows.Add()
            For i = 0 To 5
                dgvBatmans.Rows(x).Cells(i).Value = words(i)
            Next
            x += 1
        Loop
    End Sub

    Private Sub DGV2_Load(sender As Object, e As EventArgs) Handles Me.Load
        DGV2_Shown(sender, e)
    End Sub
End Class