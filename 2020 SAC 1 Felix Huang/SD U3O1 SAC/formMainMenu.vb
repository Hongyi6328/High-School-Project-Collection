Public Class formMainMenu
    'Navigation
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Hide()
        formHistory.Show()
    End Sub

    'Navigation
    Private Sub btnPrinting_Click(sender As Object, e As EventArgs) Handles btnPrinting.Click
        Hide()
        formPrinting.Show()
    End Sub

    'Navigation
    Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        Hide()
        formDepartments.Show()
    End Sub

    'If the user clicks on Exit, then close the whole program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class