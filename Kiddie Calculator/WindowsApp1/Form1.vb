'this program is written bt Felix
'done on 21/06/2019, edited on 21/06/2019
'to do some simple calculating
Imports System.Text.RegularExpressions

Public Class Form1
    Public c As Decimal
    Public a As Long
    Public b As Long
    Dim n
    'to prevent entering non-number
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextBox1.Text = digitsOnly.Replace(TextBox1.Text, "")
        a = Val(TextBox1.Text)
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        TextBox2.Text = digitsOnly.Replace(TextBox2.Text, "")
        b = Val(TextBox2.Text)
    End Sub
    'definit how the two numbers are precessed
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = Val(a) + Val(b)
        n = 0
    End Sub
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = a - b
        n = 0
    End Sub
    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = a * b
        n = 0
    End Sub
    'to prevent 0 being the divisor and give a reminder
    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.Text = "0" Then
            TextBox4.Text = "Warning! Number 0 cannot be the divisor.Press Clear to continue"
            TextBox3.Text = "Error"
            Button5.Hide()
            n = 0
        Else
            n = 1
        End If
    End Sub
    Public Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Val(TextBox2.Text) = "0" Then
            TextBox4.Text = "Warning! Number 0 cannot be the divisor.Press Clear to continue"
            TextBox3.Text = "Error"
            Button5.Hide()
        Else
            If n = 1 Then
                c = a / b
                TextBox3.Text = Val(c)
            Else
                TextBox3.Text = Val(c)
            End If
        End If
    End Sub
    'to be able to be cleared
    Public Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Text = "WELCOME,
This Kiddie Calculator is able to input positive integer numbers And output decimal numbers."
        Button5.Show()
        a = 0
        b = 0
    End Sub
    Public Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub
End Class
