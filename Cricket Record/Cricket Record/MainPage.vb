Public Class MainPage
    Private Sub btnRecording_Click(sender As Object, e As EventArgs) Handles btnRecording.Click
        Recording.Show()
        Hide()
    End Sub

    Private Sub btnDGV_Click(sender As Object, e As EventArgs) Handles btnDGV.Click
        DGV.show
        Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnDGV2_Click(sender As Object, e As EventArgs) Handles btnDGV2.Click
        DGV2.Show()
        Hide()
    End Sub
End Class