'This program is made by Felix Huang for Computer Programming CAT2
'To wholesale Mapple devices
'Started on 2/5/2018
'Done on 9/5/2818
'PS:I put three classes of three forms into one site
Imports System.IO
Imports WindowsApp1.Form1    'To make sure that all classes share important variables

Public Class Form1
    'Identified variables
    Private total, MyCube, MapBookPro, MyPad, MyPhone, DiscountMC, DiscountMB, DiscountMP, DiscountMPH As Single
    Private CostMC, CostMP, CostMPH, CostMB As Single
    Private OT1, OT2, OT3, OT4 As Integer    'Description with the operating condition of Form1.TextBoxes
    Public Const OutputFile As String = "File.txt"
    Private Shared _sw As StreamWriter      ' Create an instance of StreamWriter to write text to a file.  
    Public Shared sr As StreamReader      ' Create an instance of StreamReader to read text to a file.
    Public Shared p As Integer = 0
    Public Shared password As String

    Public Shared Property Sw As StreamWriter
        Get
            Return _sw
        End Get
        Set(value As StreamWriter)
            _sw = value
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Initial Settings
        Form2.Hide()
        Form3.Hide()
        'Introduction text
        TextBoxIntro.Text = "!WELCOME!
BY USING THESE FORMS, YOU CAN ENJOY FANTASTIC MAPPLE PURCHASING.
ORDER ANY YOU DO LIKE!
CLICK 'HELP' TO LEARN MORE.
WISH YOU GOT A GOOD MEMORY." & vbCrLf & ("Prices:MyCube: $") & Val(1299.9) & "; MapBook Pro: $" & Val(1119.5) & "; MyPad: $" & Val(765.75) & "; MyPhone: $" & Val(579.9) & "."
        OT1 = 0
        OT2 = 0
        OT3 = 0
        OT4 = 0
        TXB1.SelectedText = False    'Not to hide "Try Greater Than..." 'Cause once it is selected, the text will be reset
        TXB2.SelectedText = False
        TXB3.SelectedText = False
        TXB4.SelectedText = False
        TXB1.Text = "Try Greater Than 10!"    'To tell customers the criteria of discounts
        TXB2.Text = "Try Greater Than 20!"
        TXB3.Text = "Try Greater Than 30!"
        TXB4.Text = "Try Greater Than 40!"
        MyCube = 0    'To avoid calculating any real value without anything entered
        MapBookPro = 0
        MyPad = 0
        MyPhone = 0
        DiscountMP = 1
        DiscountMPH = 1
        DiscountMB = 1
        DiscountMC = 1
        Bclear.PerformClick()
    End Sub

    Private Sub Bclear_Click(sender As Object, e As EventArgs) Handles Bclear.Click
        'Reset function, methods are same as Me.Load
        TextBoxIntro.Text = "!WELCOME!
BY USING THIS FORM, YOU CAN ENJOY FANTASTIC MOTORCYCLE SHOPPING.
CHOOSE ANY YOU DO LIKE!
CLICK '?' TO LEARN MORE.
WISH YOU GOT A GOOD MEMORY." & vbCrLf & ("Prices:MyCube: $") & Val(1299.9) & "; MapBook Pro: $" & Val(1119.5) & "; MyPad: $" & Val(765.75) & "; MyPhone: $" & Val(579.9) & "."
        'To make everything initial
        OT1 = 0
        OT2 = 0
        OT3 = 0
        OT4 = 0
        TXB1.SelectedText = False    'Not to hide the "Try Greater Than..." 'Cause once it is selected, the text will be reset
        TXB2.SelectedText = False
        TXB3.SelectedText = False
        TXB4.SelectedText = False
        TXB1.Text = "Try Greater Than 10!"    'To tell customers the criteria of discounts
        TXB2.Text = "Try Greater Than 20!"
        TXB3.Text = "Try Greater Than 30!"
        TXB4.Text = "Try Greater Than 40!"
        MyCube = 0    'To avoid calculating any real value but without anything entered
        MapBookPro = 0
        MyPad = 0
        MyPhone = 0
        DiscountMP = 1
        DiscountMPH = 1
        DiscountMB = 1
        DiscountMC = 1
        p = 0
    End Sub

    Sub CostCalc() 'CostCalc method
        'To give a value to the price of each product
        If MyCube >= 10 Or MyCube = 0 Then
            DiscountMC = 0.87
        Else
            DiscountMC = 1
        End If
        If MapBookPro >= 20 Or MapBookPro = 0 Then
            DiscountMB = 0.89
        Else
            DiscountMB = 1
        End If
        If MyPad >= 30 Or MyPad = 0 Then
            DiscountMP = 0.91
        Else
            DiscountMP = 1
        End If
        If MyPhone >= 40 Or MyPhone = 0 Then
            DiscountMPH = 0.93
        Else
            DiscountMPH = 1
        End If
        'To calculate each object's cost and the total cost
        CostMC = 1299.9 * MyCube * DiscountMC
        CostMB = 1119.5 * MapBookPro * DiscountMB
        CostMPH = 579.9 * MyPhone * DiscountMPH
        CostMP = 765.75 * MyPad * DiscountMP
        total = CostMB + CostMC + CostMP + CostMPH
        'To display all the resualts of calculations 
        TextBoxIntro.Text = (("Prices:MyCube: $") & Val(1299.9) & "; MapBook Pro: $" & Val(1119.5) & "; MyPad: $" & Val(765.75) & "; MyPhone: $" & Val(579.9) & ";" & vbCrLf & vbCrLf & "Discounts:MyCube: $" & Format(Val(CostMC * (1 - DiscountMC)), "0.00") & "; MapBook Pro: $" & Format(Val(CostMB * (1 - DiscountMB)), "0.00") & "; MyPad: $" & Format(Val(CostMP * (1 - DiscountMP)), "0.00") & "; MyPhone: $" & Format(Val(CostMPH * (1 - DiscountMPH)), "0.00") & vbCrLf & vbCrLf & "Costs:MyCube: $" & Format(Val(CostMC), "0.00") & "; MapBook Pro: $" & Format(Val(CostMB), "0.00") & "; MyPad: $" & Format(Val(CostMP), "0.00") & "; MyPhone: $" & Format(Val(CostMPH), "0.00") & ";" & vbCrLf & vbCrLf & "Total: $" & Format(Val(total), "0.00") & ";")
    End Sub

    Private Sub Bsubmit_Click(sender As Object, e As EventArgs) Handles Bsubmit.Click
        'Record details of customers;
        'p is to describe if it's already operated once 
        Try
            If (((OT1 = 1 AndAlso OT2 = 1) AndAlso OT3 = 1) AndAlso OT4 = 1) = True Then    'To prevent submitting strings but not amount
                If p = 0 Then
                    'To create a file to save personal details
                    Sw = New StreamWriter(OutputFile)
                    Sw.WriteLine("-------------------")
                    Sw.WriteLine(DateTime.Now & ";")
                    Sw.WriteLine("Products:")    'To record how many products are ordered
                    Sw.WriteLine("Number of MyCube: " & Val(MyCube) & "__(" & Format(Val(CostMC), "0.00") & " AUD);")
                    Sw.WriteLine("Number of MapBook Pro: " & Val(MapBookPro) & "__(" & Format(Val(CostMB), "0.00") & " AUD);")
                    Sw.WriteLine("Number of MyPad: " & Val(MyPad) & "__(" & Format(Val(CostMP), "0.00") & " AUD);")
                    Sw.WriteLine("Number of MyPhone: " & Val(MyPhone) & "__(" & Format(Val(CostMPH), "0.00") & "AUD);")
                    Sw.WriteLine("Total: $" & Format(Val(total), "0.00") & "AUD")
                    p = 1
                Else
                    'To prevent two continued product records without a business record in one file
                    MessageBox.Show("Please done submitting the details next page first" & vbCrLf & "Because you've already submitted this page.")
                End If
            Else
                MessageBox.Show("Please fill all in first")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Bread_Click(sender As Object, e As EventArgs) Handles Bread.Click
        'Review the information
        Try
            sr = New StreamReader(OutputFile)
            'read text from the file.
            TextBoxIntro.Text = sr.ReadToEnd
            sr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles Bexit.Click
        'The quit function
        End
    End Sub

    'To prevent entering unnesassary type of data
    Private Sub TextBox1_KeyPress(sender As Object, ByVal e As KeyPressEventArgs) Handles TXB1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'To prevent entering unnesassary type of data
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXB1.TextChanged
        If OT1 = 1 Then     'To prevent displacing the discount reminder before first entering
            Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^\d]")
            TXB1.Text = regex.Replace(TXB1.Text, "")
        End If
    End Sub

    'To prevent regex working when resetting the form
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TXB1.GotFocus
        If OT1 = 0 Then
            TXB1.ResetText()
            OT1 = 1
        End If
    End Sub

    'To call the CostCalc Sub to calculate the cost when finish entering numbers so it save process resources
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TXB1.LostFocus
        If Val(TXB1.Text) > 0 And Val(TXB1.Text) < 5 Then
            TXB1.ResetText()
            MessageBox.Show("Under Minimum Amount!")    'Reminds users not to order under the minimun amount
        Else
            MyCube = Val(TXB1.Text)
            CostCalc()
        End If
    End Sub

    'All the same functions as Textbox1's
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXB2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TXB2.TextChanged
        If OT2 = 1 Then
            Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^\d]")
            TXB2.Text = regex.Replace(TXB2.Text, "")
        End If
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TXB2.GotFocus
        If OT2 = 0 Then
            TXB2.ResetText()
            OT2 = 1
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TXB2.LostFocus
        If Val(TXB2.Text) > 0 And Val(TXB2.Text) < 10 Then
            TXB2.ResetText()
            MessageBox.Show("Under Minimum Amount!")
        Else
            MapBookPro = Val(TXB2.Text)
            CostCalc()
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXB3.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TXB3.TextChanged
        If OT3 = 1 Then
            Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^\d]")
            TXB3.Text = regex.Replace(TXB3.Text, "")
        End If
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TXB3.GotFocus
        If OT3 = 0 Then
            TXB3.ResetText()
            OT3 = 1
        End If
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TXB3.LostFocus
        If Val(TXB3.Text) > 0 And Val(TXB3.Text) < 15 Then
            TXB3.ResetText()
            MessageBox.Show("Under Minimum Amount!")
        Else
            MyPad = Val(TXB3.Text)
            CostCalc()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXB4.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TXB4.TextChanged
        If OT4 = 1 Then
            Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^\d]")
            TXB4.Text = regex.Replace(TXB4.Text, "")
        End If
    End Sub

    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TXB4.GotFocus
        If OT4 = 0 Then
            TXB4.ResetText()
            OT4 = 1
        End If
    End Sub

    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles TXB4.LostFocus
        If Val(TXB4.Text) > 0 And Val(TXB4.Text) < 20 Then
            TXB4.ResetText()
            MessageBox.Show("Under Minimum Amount!")
        Else
            MyPhone = Val(TXB4.Text)
            CostCalc()
        End If
    End Sub

    'To provide an openfiledialog to browse
    Public Sub Bopenfile_Click(sender As Object, e As EventArgs) Handles Bopenfile.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName IsNot Nothing Then
            If OpenFileDialog1.FileName.Contains(".txt") Then
                Try
                    sr = New StreamReader(OpenFileDialog1.FileName)
                    TextBoxIntro.Text = sr.ReadToEnd()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                MessageBox.Show(".txt documents only requiered")
            End If
        End If
    End Sub

    'Help function
    Private Sub Bhelp_Click(sender As Object, e As EventArgs) Handles Bhelp.Click
        TextBoxIntro.Text = "Enter how many you'd like to buy for each product" & vbCrLf & "Or you can fill up the form next page first" & vbCrLf & "We have some discounts for you when you ordered at least a specific amount of products" & vbCrLf & "Finally don't forget to submit your information or you'll lose it." & vbCrLf & "Ps: You'll get discount if you buy >=10 MyCube, >=20 MapBook Pro, >=30 MyPad or >=40 MyPhone."
    End Sub

    'To call the other form
    Private Sub Bnextpage_Click(sender As Object, e As EventArgs) Handles Bnextpage.Click
        Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'To prevent text in Form2 appear on Form1
        TextBoxIntro.Text = "!WELCOME!
BY USING THIS FORM, YOU CAN ENJOY FANTASTIC MOTORCYCLE SHOPPING.
CHOOSE ANY YOU DO LIKE!
CLICK '?' TO LEARN MORE.
WISH YOU GOT A GOOD MEMORY." & vbCrLf & ("Prices:MyCube: $") & Val(1299.9) & "; MapBook Pro: $" & Val(1119.5) & "; MyPad: $" & Val(765.75) & "; MyPhone: $" & Val(579.9) & "."
    End Sub
End Class

'Form for entering details
Public Class Form2
    Private Sub Form2_Bback_Click(sender As Object, e As EventArgs) Handles Bback.Click
        'Calls back
        Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBoxIntro.Text = "!WELCOME!
BY USING THESE FORMS, YOU CAN ENJOY FANTASTIC MAPPLE PURCHASING.
ORDER ANY YOU DO LIKE!
CLICK 'HELP' TO LEARN MORE.
WISH YOU GOT A GOOD MEMORY."
    End Sub

    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles Bexit.Click
        End
    End Sub

    Private Sub Form2_Bsubmit_Click(sender As Object, e As EventArgs) Handles Bsubmit.Click
        'Record details of business;
        'p is to describe if it's already operated once 
        If ((((((TXBAddress.Text IsNot Nothing) AndAlso TXBbusiness.Text IsNot Nothing) AndAlso TXBDdate.Text IsNot Nothing) AndAlso TXBOdate.Text IsNot Nothing) AndAlso TXBperson.Text IsNot Nothing) AndAlso TXBPhone.Text IsNot Nothing) AndAlso (RadioButton1.Checked = True Or RadioButton2.Checked = True) Then
            'To prevent submitting nothing
            Try
                If p = 1 Then
                    Sw.WriteLine("")
                    Sw.WriteLine("Business:" & TXBbusiness.Text)    'To record business details
                    Sw.WriteLine("Contact Person:" & TXBperson.Text)
                    Sw.WriteLine("Phone:" & TXBPhone.Text)
                    Sw.WriteLine("Ordered Date:" & TXBOdate.Text)
                    Sw.WriteLine("Delivery Date:" & TXBDdate.Text)
                    Sw.WriteLine("Address:" & TXBAddress.Text)
                    Sw.WriteLine("")
                    If RadioButton1.Checked = True Then
                        Sw.WriteLine("Paid By Cash")
                    Else    'To record bank Info
                        If Form3.RadioButton1.Checked = True Then
                            Sw.WriteLine("Paid By Visa Card")
                        End If
                        If Form3.RadioButton2.Checked = True Then
                            Sw.WriteLine("Paid By MasterCard")
                        End If
                        If Form3.RadioButton3.Checked = True Then
                            Sw.WriteLine("Card Type: Credit")
                        End If
                        If Form3.RadioButton4.Checked = True Then
                            Sw.WriteLine("Card Type: Saver")
                        End If
                        If Form3.RadioButton5.Checked = True Then
                            Sw.WriteLine("Card Type: Other")
                        End If
                        Sw.WriteLine("Account:" & Form3.TextBox1.Text)
                        Sw.WriteLine("Customer:" & Form3.TextBox2.Text)
                        Sw.WriteLine(value:=$"BSB:{Form3.TextBox3.Text}")
                        Dim passwordlength As Integer = password.Length
                        Dim passwordmaskedcode = New String("*"c, passwordlength)
                        Sw.WriteLine("Password:" & passwordmaskedcode & "(Masked)")  'To keep safety of password
                    End If
                    Sw.WriteLine("-------------------")
                    p = 0
                    Sw.Close()
                Else
                    'To prevent two continued business records without a product record in one file
                    MessageBox.Show("Please done submitting the details previous page first" & vbCrLf & "Because you've already submitted this page.")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            MessageBox.Show("Please Type in All the Objects!")
        End If
    End Sub

    Private Sub Form2_Bread_Click(sender As Object, e As EventArgs) Handles Bread.Click
        'Review the information
        Try
            sr = New StreamReader(OutputFile)
            'read text from the file.
            TextBoxIntro.Text = sr.ReadToEnd
            sr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'To provide an openfiledialog to browse
    Public Sub Form2_Bopenfile_Click(sender As Object, e As EventArgs) Handles Bopenfile.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName IsNot Nothing Then
            If OpenFileDialog1.FileName.Contains(".txt") Then
                Try
                    sr = New StreamReader(OpenFileDialog1.FileName)
                    TextBoxIntro.Text = sr.ReadToEnd()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                MessageBox.Show(".txt document requiered only")
            End If
        End If
    End Sub

    'Reset Function
    Private Sub Form2_Bclear_Click(sender As Object, e As EventArgs) Handles Bclear.Click
        TXBAddress.ResetText()
        TXBbusiness.ResetText()
        TXBPhone.ResetText()
        TXBperson.ResetText()
        TXBOdate.ResetText()
        TXBDdate.ResetText()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        password = Nothing
        TextBoxIntro.Text = "!WELCOME!
BY USING THESE FORMS, YOU CAN ENJOY FANTASTIC MAPPLE PURCHASING.
ORDER ANY YOU DO LIKE!
CLICK 'HELP' TO LEARN MORE.
WISH YOU GOT A GOOD MEMORY."
        p = 0
    End Sub

    'Help function
    Private Sub Form2_Bhelp_Click(sender As Object, e As EventArgs) Handles Bhelp.Click
        TextBoxIntro.Text = "In this slide, you are to enter your information about your payment, details and business. " & vbCrLf & "Notice that some types of data are not acceptable in some textboxes."
    End Sub

    'To prevent entering unnesassary type of data
    Private Sub TXBPhone_KeyPress(sender As Object, ByVal e As KeyPressEventArgs) Handles TXBPhone.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'To prevent entering unnesassary type of data
    Private Sub TXBPhone_TextChanged(sender As Object, e As EventArgs) Handles TXBPhone.TextChanged
        Dim regex As System.Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^\d]")
        TXBPhone.Text = regex.Replace(TXBPhone.Text, "")
    End Sub

    Private Sub TXBPerson_KeyPress(sender As Object, ByVal e As KeyPressEventArgs) Handles TXBperson.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXBPerson_TextChanged(sender As Object, e As EventArgs) Handles TXBperson.TextChanged
        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^A-Za-z \s]")
        TXBperson.Text = regex.Replace(TXBperson.Text, "")
    End Sub

    Private Sub TXBOdate_KeyPress(sender As Object, ByVal e As KeyPressEventArgs) Handles TXBOdate.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXBOdate_TextChanged(sender As Object, e As EventArgs) Handles TXBOdate.TextChanged
        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^0-9\\\-\./]")
        TXBOdate.Text = regex.Replace(TXBOdate.Text, "")
    End Sub

    Private Sub TXBDdate_KeyPress(sender As Object, ByVal e As KeyPressEventArgs) Handles TXBDdate.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXBDdate_TextChanged(sender As Object, e As EventArgs) Handles TXBDdate.TextChanged
        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^0-9\\\-\./]")
        TXBDdate.Text = regex.Replace(TXBDdate.Text, "")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'To prevent submitting the wrong payment if uses changed the choice after finished Form3 
        If RadioButton2.Checked = True Then
            Hide()
            Form3.Show()
        End If
    End Sub
End Class

'Form for banking
Public Class Form3
    'Prevent unnecessary entering
    Private Sub TextBox1_KeyPress(sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^0-9]")
        TextBox1.Text = regex.Replace(TextBox1.Text, "")
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (((Not Char.IsControl(e.KeyChar)) AndAlso (Not Char.IsDigit(e.KeyChar))) AndAlso (TextBox3.TextLength <= 6)) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textbox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^0-9]")
        TextBox3.Text = regex.Replace(TextBox3.Text, "")
    End Sub

    'Keeps the password secret and private
    Private Sub Textbox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^.]")
        password = TextBox4.Text
        TextBox4.Text = regex.Replace(TextBox4.Text, "*")
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("[^A-Za-z \s]")
        TextBox2.Text = regex.Replace(TextBox2.Text, "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((((((RadioButton1.Checked = True Or RadioButton2.Checked = True) AndAlso (RadioButton3.Checked = True Or RadioButton4.Checked = True Or RadioButton5.Checked = True)) AndAlso TextBox1.Text IsNot Nothing) AndAlso TextBox2.Text IsNot Nothing) AndAlso TextBox3.TextLength = 6) AndAlso TextBox4.Text IsNot Nothing) Then
            Hide()
            Form2.Show()
        Else
            MessageBox.Show("Don't forget to finish all and BSB has and only has 6 places!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form2.Show()
        Form2.RadioButton1.Checked = True    'To prevent record nothing about payment but shown by "Paid by card"
    End Sub
End Class