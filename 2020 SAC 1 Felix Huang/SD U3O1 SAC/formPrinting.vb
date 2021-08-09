'SAC 1 MODULE 3
'Felix Huang
'June 19th, 2020
'Zippy Printing
Imports System.Xml
Imports System.IO
Public Class formPrinting
    'Declare variables
    Dim copies, pages, impressions, pagesPerCopy, totalPages As Integer
    Dim impressionCost, printingCost, finishingCost, finishingTotalCost, totalCost As Single

    'Assign all elements and their sub-elements to the object, departmentsInfo, 
    'For further mapping of the value needed
    Dim departmentsInfo = XElement.Load("departments.xml")
    Dim balance As Single

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Get values from the input on the interface
        pages = nudSides.Value
        copies = nudCopies.Value
        impressions = pages * copies
        'Doubled sided means half pages to print
        'ceiling means it still needs a paper for an impression
        If chkDoubleSided.Checked = True Then
            pagesPerCopy = Math.Ceiling(pages / 2)
        Else
            pagesPerCopy = pages
        End If

        totalPages = pagesPerCopy * copies
        'Extra cost calculations
        impressionCost = 0.06
        If radA3.Checked = True Then
            impressionCost *= 2
        End If

        If chkColour.Checked = True Then
            impressionCost *= 1.5
        End If

        printingCost = impressions * impressionCost
        'call the subroutine for finishing cost calculation
        finishing()

        totalCost = printingCost + finishingTotalCost
        'Display the results of calculations on the interface, rounded to 2 decimal places
        lblTotalImp.Text = impressions
        lblImpCost.Text = FormatCurrency(impressionCost, 2)
        lblTotalPages.Text = totalPages
        lblPrintCost.Text = FormatCurrency(printingCost, 2)
        lblFinishingCost.Text = FormatCurrency(finishingCost, 2)
        lblFinalCost.Text = FormatCurrency(totalCost, 2)

        'Validate if the cost is higher than the balance
        If totalCost > balance Then
            'If yes, pop up an error message to instruct the user 
            'Disable the button for submitting the change of balance, that is, the user cannot click on it
            MsgBox("Your cost is higher than your balance. Please select another job or recharge your balance.")
            btnSubmit.Enabled = False
        Else
            'Bring back the situation of the button to normal
            'the user is able to click on it
            btnSubmit.Enabled = True
        End If
    End Sub

    Sub finishing()
        'Input:     the RadioButton checked in the GroupBox1
        'Process:   assign different value of finishing cost 
        '           with respect To different RadioButton checked
        'Output:    the value of finishingCost, this is for a single copy
        If rad1Staple.Checked = True Then
            finishingCost = 0.01
        ElseIf rad2Staple.Checked = True Then
            finishingCost = 0.02
        ElseIf radBinding.Checked = True Then
            If pages <= 50 Then
                finishingCost = 3.2
            ElseIf pages <= 120 Then
                finishingCost = 4.35
            ElseIf pages <= 200 Then
                finishingCost = 5.65
            Else
                'Validate if the number of pages is out of limit
                'If so, then pop up a message reminding the user
                MessageBox.Show("Too many pages to bind", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                finishingCost = 0
            End If
        Else
            finishingCost = 0
        End If
        'Return the total finishing cost, which will be used in the previous subroutine
        finishingTotalCost = finishingCost * copies

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Extract data from the xml file
        If departmentsInfo IsNot Nothing Then
            For Each department As XElement In departmentsInfo.elements
                'check if an element represents a department name one by one
                'if yes, add the name to the item list of cmbDepartments
                If department.Name = "department" AndAlso department.HasElements Then
                    For Each stat As XElement In department.Elements
                        If stat.Name = "name" Then
                            cmbDepartments.Items.Add(stat.Value)
                        End If
                    Next
                End If
            Next
        Else
            'Existence Check, if the file is not there, pop up an error message
            departmentsInfo = Nothing
            Throw New Exception("The Department XML file cannot be found or is corrupt")
        End If

    End Sub


    Private Sub CmbDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartments.SelectedIndexChanged
        If departmentsInfo IsNot Nothing Then
            For Each department As XElement In departmentsInfo.elements
                If department.Name = "department" AndAlso department.HasElements Then
                    For Each stat As XElement In department.Elements
                        'find where the element that represents the current-selected department is
                        'if found, the balance is a parallel element of the department name element
                        'that is, the balance does not belong to the department name element 
                        'they are peers, so balance cannot be found in the element list of the sub-elements of <name>
                        If stat.Name = "name" Then
                            If stat.Value.ToString = cmbDepartments.SelectedItem Then
                                For Each item As XElement In department.Elements
                                    If item.Name = "balance" Then
                                        balance = item.Value
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If
            Next
            lblBalanceValue.Text = FormatCurrency(balance, 2)
            lblDepartmentValue.Text = cmbDepartments.Text
        Else
            'Existence Check, if the file is not there, pop up an error message
            departmentsInfo = Nothing
            Throw New Exception("The Departments XML file cannot be found or is corrupt")
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cmbDepartments.Text = "Choose Department" Then
            MsgBox("Please choose a department")
            Exit Sub
        End If

        If lblFinalCost.Text = "$0.00" Then
            'Validate the input, 0 cost is meaningless
            MsgBox("You have not selected a job yet.")
        Else
            'Calculate the new balance and write it into the corresponding element value
            balance = balance - totalCost
            lblBalanceValue.Text = FormatCurrency(balance, 2)
            For Each department As XElement In departmentsInfo.elements
                If department.Name = "department" AndAlso department.HasElements Then
                    For Each stat As XElement In department.Elements
                        If stat.Name = "name" Then
                            If stat.Value = cmbDepartments.Text Then
                                For Each item As XElement In department.Elements
                                    'the steps so far are the same as the process to load balance from a department element
                                    'these steps are to target where the new balance should be written
                                    If item.Name = "balance" Then
                                        'assign the element value with the new balance
                                        item.Value = Math.Round(balance, 2)
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If
            Next
            'update the change, this can be done multiple times
            departmentsInfo.save("departments.xml")
            'a message to make the program responsive
            MsgBox("Change updated successfully.")
        End If

        'call a subroutine to append new record of printing to the .csv file
        writeToCSV()
    End Sub

    'Navigation
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Hide()
        formMainMenu.Show()
    End Sub

    'Navigation
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Hide()
        formHistory.Show()
    End Sub

    'Navigation
    Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        Hide()
        formDepartments.Show()
    End Sub

    Sub writeToCSV()

        'Declare variables for writing a single record into the csv file
        Dim department = cmbDepartments.Text

        'M represents month, m represents minute
        'Set the format of date and time
        'An example for date: 09/06/2020, if the day and month are one place long,
        'add a place holder before them
        'An example for time: 15:23, 24 hours, not am or pm
        Dim printingDate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Dim printingTime As String = String.Format("{0:HH:mm}", DateTime.Now)

        'Assign value to the size of paper, according to the radioButton selected
        Dim paperSize
        If radA3.Checked Then
            paperSize = "A3"
        Else
            paperSize = "A4"
        End If

        'Assign values for further writing to the csv file
        Dim pageNum = lblTotalPages.Text
        Dim impressionNum = lblTotalImp.Text
        Dim colour As String
        If chkColour.Checked Then
            colour = "True"
        Else
            colour = "False"
        End If

        'Use system.IO to map where the file is (should be) with its file name
        Dim fs As FileStream
        Dim file As IO.File
        Dim fileName As String = "history.csv"
        'This "data" is to be written in the the csv file
        Dim data As String

        If File.Exists(fileName) Then
            'Append means add things to the exising csv file (if there is)
            fs = New FileStream(fileName, FileMode.Append, FileAccess.Write)
            data =
               vbCrLf & department & "," & printingDate & "," & printingTime & "," _
                & impressionNum & "," & paperSize & "," & pageNum & "," & colour & "," _
                & printingCost & "," & finishingTotalCost & "," & totalCost
            'the difference between the "data" here and the "data" below is:
            'an extra line is needed for an existing file
            'if a new file is created, there is already an empty line to use.
            'assign value to "data", following the checklist provided by the SAC paper
            'split by comma
        Else
            fs = New FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)
            data =
                 department & "," & printingDate & "," & printingTime & "," _
                & impressionNum & "," & paperSize & "," & pageNum & "," & colour & "," _
                & printingCost & "," & finishingTotalCost & "," & totalCost
        End If

        'Created an instance of StreamWriter, an object to automatically write stream/text
        Dim sw As New StreamWriter(fs, System.Text.Encoding.Default)

        'Seek origin means find where to insert the value of "data"
        'origin is the place where the first character locates, that is, data(0)
        'If the file is already existing, then the origin should be the end of it
        'If the file is new, then the origin is the very beginning of it
        If File.Exists(fileName) Then
            sw.BaseStream.Seek(0, SeekOrigin.End)
        Else
            sw.BaseStream.Seek(0, SeekOrigin.Begin)
        End If

        'Use the method of sw.write
        sw.Write(data)

        'if sw is not closed, the file will be occupied and cannot be open by other app
        sw.Close()
    End Sub
End Class
