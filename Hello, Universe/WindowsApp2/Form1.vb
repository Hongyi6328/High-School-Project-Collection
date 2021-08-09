Public Class Form1
    Private Sub BtnHello_click(ByVal sender As Object, e As EventArgs) Handles btnHello.Click
        txtOut.Text = "Hello,Universe!"
    End Sub
    Private Sub BtnGoodbye_click(ByVal sender As Object, e As EventArgs) Handles btnGoodbye.Click
        txtOut.Text = "Goodbye,Universe!"
    End Sub
    Private Sub BtnClear_click(ByVal sender As Object, e As EventArgs) Handles btnClear.Click
        txtOut.Clear()
    End Sub
    Private Sub BtnExit_click(ByVal sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

End Class
