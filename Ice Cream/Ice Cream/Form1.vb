'This program is made by Felix
'To manage the selling ice creams
'Done on 23/4/2018
Public Class Form1
    Dim cost = 0, extra, siz, num, sale, salee As Decimal
    Dim quan As Integer = 0, a = 0

    Sub Initial()
        'For original settings
        ComboBox1.SelectedIndex = 1
        VScrollBar1.Value = 1
        TextBox1.Text = VScrollBar1.Value
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        Rsin.Checked = True
        a = 1
        'Call the sub
        Costcalc()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        'Reset function
        Initial()
        cost = 0
        num = 0
        Costcalc()
    End Sub

    Private Sub Rkid_CheckedChanged(sender As Object, e As EventArgs) Handles Rkid.CheckedChanged
        'Set the price of each size
        If Rkid.Checked = True Then
            siz = 1
            Costcalc()
        End If
    End Sub

    Private Sub Rsin_CheckedChanged(sender As Object, e As EventArgs) Handles Rsin.CheckedChanged
        If Rsin.Checked = True Then
            siz = 1.8
            Costcalc()
        End If
    End Sub

    Private Sub Rdou_CheckedChanged(sender As Object, e As EventArgs) Handles Rdou.CheckedChanged
        If Rdou.Checked = True Then
            siz = 2.4
            Costcalc()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            num = num + 1
        Else
            num = num - 1 'prevent num is negative
        End If
        If num < 0 Then
            num = 0
        End If
        Costcalc()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            num = num + 1
        Else
            num = num - 1
        End If
        If num < 0 Then
            num = 0
        End If
        Costcalc()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            num = num + 1
        Else
            num = num - 1
        End If
        If num < 0 Then
            num = 0
        End If
        Costcalc()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            num = num + 1
        Else
            num = num - 1
            If num < 0 Then
                num = 0
            End If
        End If
        Costcalc()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            num = num + 1
        Else
            num = num - 1
        End If
        If num < 0 Then
            num = 0
        End If
        Costcalc()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            num = num + 1
        Else
            num = num - 1
        End If
        If num < 0 Then
            num = 0
        End If
        Costcalc()
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            num = num + 1
            If num < 0 Then
                num = 0
            End If
        Else
            num = num - 1
        End If
        If num < 0 Then
            num = 0
        End If
        Costcalc()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Also original settings
        ComboBox1.Items.Add("Chocolate")
        ComboBox1.Items.Add("Vanilla")
        ComboBox1.Items.Add("Strawberry")
        ComboBox1.Items.Add("Butterscotch")
        ComboBox1.Items.Add("Caramel")
        ComboBox1.Items.Add("Chocolate Chip")
        ComboBox1.Items.Add("Raspberry")
        ComboBox1.Items.Add("Coconut")
        VScrollBar1.Value = 1
        quan = 1
        Costcalc()
    End Sub

    Sub Costcalc()
        'Calculate the total amount of payment then display
        If a = 1 Then
            cost = 0
            a = 0
        Else
            If num <= 1 Then
                sale = 0.6
            Else
                If num = 2 Or num = 3 Then
                    sale = 0.4
                Else
                    If num > 3 Then
                        sale = 0.33
                    End If
                End If
            End If
            If quan = 1 Then
                salee = 1
            Else
                salee = 1 - (quan - 1) * 0.05
            End If
            TextBox1.Text = quan
            cost = (siz + num * sale) * (quan * salee)
            If siz = Nothing Then
                cost = 0
            End If
            TextBox2.Text = cost
            TextBox2.Text = Format(Val(cost), "Currency")
            a = 0
        End If
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        quan = VScrollBar1.Value
        Costcalc()
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        'Prevent ordering withour any flavour
        If ComboBox1.SelectedItem = Nothing Then
            Rkid.Enabled = False
            Rsin.Enabled = False
            Rdou.Enabled = False
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
        Else
            Rkid.Enabled = True
            Rsin.Enabled = True
            Rdou.Enabled = True
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
        End If
    End Sub
End Class
