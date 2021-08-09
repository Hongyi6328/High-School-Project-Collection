Public Class Form1
    Dim s1 As String
    Dim display = {"Penny", "Jimmy", "Kerry", "Felix", "Tina", "Helen", "Jacky", "Oscar"}
    Dim penny = 0, jimmy = 0, kerry = 0, felix = 0, tina = 0, helen = 0, jacky = 0, oscar = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim s2 As Integer

        TextBox1.ResetText()
        Randomize()
        s2 = Int((8 - 1 + 1) * Rnd())
        s1 = display(s2)
        TextBox1.Text = s1
        Select Case s1
            Case "Penny"
                penny += 1
            Case "Jimmy"
                jimmy += 1
            Case "Kerry"
                kerry += 1
            Case "Felix"
                felix += 1
            Case "Tina"
                tina += 1
            Case "Helen"
                helen += 1
            Case "Jacky"
                jacky += 1
            Case "Oscar"
                oscar += 1
        End Select
        TextBox2.Text = "Penny: " & penny & vbCrLf &
            "Jimmy: " & jimmy & vbCrLf &
            "Kerry: " & kerry & vbCrLf &
            "Felix: " & felix & vbCrLf &
            "Tina: " & tina & vbCrLf &
            "Helen: " & helen & vbCrLf &
            "Jacky: " & jacky & vbCrLf &
            "Oscar: " & oscar & vbCrLf
    End Sub


End Class
