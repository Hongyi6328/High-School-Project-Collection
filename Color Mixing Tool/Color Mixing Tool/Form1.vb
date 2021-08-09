'This program is written by Felix 
'Started on 14 March
'For color mixing 
Public Class Form1
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll, TrackBar2.Scroll, TrackBar3.Scroll
        'It is for default setting and it determines which scroll matches which basic color
        Label4.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
        NumericUpDown1.Value = TrackBar1.Value
        NumericUpDown2.Value = TrackBar2.Value
        NumericUpDown3.Value = TrackBar3.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CLEAR function
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        NumericUpDown3.Value = 0
        TrackBar1.Value = 0
        TrackBar2.Value = 0
        TrackBar3.Value = 0
        Label4.BackColor = Color.FromArgb(0, 0, 0)
        'Reset the background color default
        Me.BackColor = Color.FromKnownColor(KnownColor.LightGray)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'It shows the final-mixed color with the background color
        Me.BackColor = Color.FromArgb(TrackBar1.Value, TrackBar2.Value, TrackBar3.Value)
    End Sub
End Class
