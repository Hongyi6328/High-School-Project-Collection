'This program is made by Hongyi Huang(Felix)
'Started on 27/04/2018
'Done on 5/5/2018
'Basically provides a function to help show, compare then order a motor bike
Imports System.IO

Public Class Form1
    'Identified variables
    Dim bike, cost, total, extra, color, rate, con, dis, a, b, o, ex1, ex2, ex3, ex4, ex5, ex6 As Single
    Public Const OutputFile As String = "TestFile.txt" 'TO create a file to save personal details
    Public Const Introduction As String = "Introduction.txt"
    Dim sw As StreamWriter      ' Create an instance of StreamWriter to write text to a file.  
    Dim sr As StreamReader      ' Create an instance of StreamReader to read text to a file.

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Initial Settings
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        TXBoxIntro.TextAlign = HorizontalAlignment.Center
        ComboBox1.SelectedIndex = 1
        ComboBox2.SelectedIndex = 1
        ComboBox1.SelectedItem = "Honda"
        ComboBox2.SelectedItem = "Black"
        TXBoxIntro.Text = "!WELCOME!
BY USING THIS FORM, YOU CAN ENJOY FANTASTIC MOTORCYCLE SHOPPING.
CHOOSE ANY YOU DO LIKE!
CLICK '?' TO LEARN MORE.
WISH YOU GOT A GOOD MEMORY."   'Introduction text
        CheckBox1.Checked = False    'To make everything preset
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox4.Checked = False
        TXBoxC.Text = "0 Total"
        con = Nothing
        o = 0
        TXBoxIntro.ReadOnly = True
        TXBoxC.ReadOnly = True
        TXBoxDis.ReadOnly = True
        TXBoxEX.ReadOnly = True
        TXBoxGST.ReadOnly = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Reset function, methods are same as Me.Load
        TXBoxIntro.TextAlign = HorizontalAlignment.Center
        ComboBox1.SelectedIndex = 1
        ComboBox2.SelectedIndex = 1
        ComboBox1.SelectedItem = "Honda"
        ComboBox2.SelectedItem = "Black"
        TXBoxIntro.Text = "!WELCOME!
BY USING THIS FORM, YOU CAN ENJOY FANTASTIC MOTORCYCLE SHOPPING.
CHOOSE ANY YOU DO LIKE!
CLICK '?' TO LEARN MORE.
WISH YOU GOT A GOOD MEMORY."
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox4.Checked = False
        TXBoxC.Text = "0 Total"
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        TextBox6.ResetText()
        TextBox7.ResetText()
        TextBox8.ResetText()
        o = 0    'To make everything initial
    End Sub

    Sub CostCalc() 'CostCalc method
        'To give a value to the price of each brand, "a" is for showing the sequence of images of bikes
        If ComboBox1.SelectedItem = "Honda" Then
            bike = 13455.8
            dis = 0.9
            a = 1
        End If
        If ComboBox1.SelectedItem = "Suzuki" Then
            bike = 7598
            dis = 0.85
            a = 2
        End If
        If ComboBox1.SelectedItem = "BMW" Then
            bike = 19192.8
            dis = 1
            a = 3
        End If
        If ComboBox1.SelectedItem = "Harley" Then
            bike = 26245
            dis = 1
            a = 4
        End If
        'To give a value to extra color cost, "b" is for the same purpose as "a"
        If ComboBox2.SelectedItem = "Green" Then
            color = 1000
            b = 1
        End If
        If ComboBox2.SelectedItem = "Yellow" Then
            color = 1000
            b = 2
        End If
        If ComboBox2.SelectedItem = "Red" Then
            color = 1000
            b = 3
        End If
        If ComboBox2.SelectedItem = "Black" Then
            color = 0
            b = 4
        End If
        If ComboBox2.SelectedItem = "Blue" Then
            color = 0
            b = 5
        End If
        'Extra accessories cost
        If CheckBox1.Checked = True Then
            ex1 = 50
        Else
            ex1 = 0
        End If
        If CheckBox2.Checked = True Then
            ex2 = 20
        Else
            ex2 = 0
        End If
        If CheckBox3.Checked = True Then
            ex3 = 35
        Else
            ex3 = 0
        End If
        If CheckBox4.Checked = True Then
            ex4 = 14
        Else
            ex4 = 0
        End If
        If CheckBox5.Checked = True Then
            ex5 = 5
        Else
            ex5 = 0
        End If
        If CheckBox6.Checked = True Then
            ex6 = 45
        Else
            ex6 = 0
        End If
        'To calculate then display each project of cost and the total cost
        extra = ex1 + ex2 + ex3 + ex4 + ex5 + ex6
        TXBoxEX.text = Val(extra + color)
        TXBoxDis.Text = Val(bike * (1 - dis))
        cost = extra + bike + color - (bike * (1 - dis))
        TXBoxGST.text = Val(cost / 10)
        total = cost * 11 / 10
        TXBoxC.Text = Val(total)
        con = 10 * a + b
        'To show a diagram/picture of motorcycle's apprearance
        PictureBox1.Refresh()
        PictureBox1.ImageLocation = "C:\Users\qo\source\repos\Motorcycle Transport\Motorcycle Transport\resources\'con.ToString'.jpg"
        If Not o = 0 Then    'To prevent the RESET function making the align always left
            TXBoxIntro.TextAlign = HorizontalAlignment.Left
        Else
            o = 1
        End If
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\qo\source\repos\Motorcycle Transport\Motorcycle Transport\bin\DeBug\Introduction.txt")
            Dim stringReader As String
            stringReader = fileReader.ReadLine()
            TXBoxIntro.Text = stringReader
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        If con = 34 Then
            TXBoxIntro.Text = "The new BMW K 1600 GT with its 6-cylinder in-line engine is already considered an icon with its power delivery and running smoothness. Added to this are the absolute long-distance suitability with wind and weather protection and equipment which makes you want to ride right away. You can be assured that you will leave quite an impression whether you are at a standstill or on the move."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Record details of customers
        Try
            sw = New StreamWriter(OutputFile)
            sw.WriteLine("-------------------")
            sw.WriteLine(DateTime.Now & ";")
            sw.WriteLine("Tittle:" & TextBox1.Text & ";")    'Personal details
            sw.WriteLine("First Name:" & TextBox2.Text & ";")
            sw.WriteLine("Surname:" & TextBox3.Text & ";")
            sw.WriteLine("Age:" & TextBox4.Text & ";")
            sw.WriteLine("Country:" & TextBox5.Text & ";")
            sw.WriteLine("Phone:" & TextBox6.Text & ";")
            sw.WriteLine("Email:" & TextBox7.Text & ";")
            sw.WriteLine("Address:" & TextBox8.Text & ";")
            sw.WriteLine("Product:" & ComboBox2.SelectedItem.ToString & " " & ComboBox1.SelectedItem.ToString & ";")
            sw.WriteLine("With ")
            If CheckBox1.Checked Then
                sw.Write("Helmet, ")
            End If
            If CheckBox2.Checked Then
                sw.Write("Leather Gloves, ")
            End If
            If CheckBox3.Checked Then
                sw.Write("Leather Boots, ")
            End If
            If CheckBox4.Checked Then
                sw.Write("Engine, ")
            End If
            If CheckBox5.Checked Then
                sw.Write("Duster, ")
            End If
            If CheckBox6.Checked Then
                sw.Write("Leather Jacket")
            End If
            sw.WriteLine(";")
            sw.WriteLine("-------------------")
            sw.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Review the information
        Try
            sr = New StreamReader(OutputFile)
            'read text from the file.
            TXBoxIntro.Text = sr.ReadToEnd
            sr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'The quit function
        End
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        'To call CostCalc Sub to calculate the cost once grand or color changed
        CostCalc()
    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
        CostCalc()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CostCalc()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CostCalc()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CostCalc()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        CostCalc()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        CostCalc()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        CostCalc()
    End Sub

    'To prevent entering unnesassary type of data
    Private Sub TextBox1_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^Mrsi\.]" & "")
        TextBox1.Text = regex.Replace(TextBox1.Text, "")
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^A-Za-z]")
        TextBox2.Text = regex.Replace(TextBox3.Text, "")
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox3.TextChanged
        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^A-Za-z]")
        TextBox3.Text = regex.Replace(TextBox3.Text, "")
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^\d]")
        TextBox4.Text = regex.Replace(TextBox4.Text, "")
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox5.TextChanged
        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^A-Za-z]")
        TextBox5.Text = regex.Replace(TextBox5.Text, "")
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox6.TextChanged
        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[^\d]")
        TextBox6.Text = regex.Replace(TextBox6.Text, "")
    End Sub
End Class
