Imports System.IO
Imports System.Text
Imports System.Xml


Public Class formDepartments
    'Navigation
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        formMainMenu.Show()
    End Sub

    'Navigation
    Private Sub btnPrinting_Click(sender As Object, e As EventArgs) Handles btnPrinting.Click
        Me.Hide()
        formPrinting.Show()
    End Sub

    'Navigation
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Me.Hide()
        formHistory.Show()
    End Sub

    Dim batterData(0, 1) 'This is the master 2D array of all values needed to be calculated
    'It will be re-sized depending on the size of the file the program reads from

    Private Sub btnPick_Click(sender As Object, e As EventArgs) Handles btnPick.Click

        dgvDepartments.Rows.Clear() 'Initialise the DataGridView, clear all cells

        Dim batterInfo = XElement.Load("departments.xml") 'It stores all the xml elements from the xml file
        Dim batterCount As Integer = 0 'It counts how many times the "name" element is spotted


        'Read how many departments there are 

        If batterInfo IsNot Nothing Then 'Existence check

            'Get each sub-element of the xml file
            For Each department As XElement In batterInfo.Elements

                'Existence check for the sub-elements of "department"
                If department.Name = "department" AndAlso department.HasElements Then

                    '"name" is a sub-element of "department"
                    For Each stat As XElement In department.Elements
                        If stat.Name = "name" Then
                            'If the element "name" is spotted, then increase batterCount by 1
                            batterCount += 1
                        End If
                    Next
                End If
            Next
        Else
            batterInfo = Nothing
            'Display a reminder message
            Throw New Exception("The departments XML file cannot be found or is corrupt")
        End If

        ReDim batterData(batterCount - 1, 1) 'Resize the batterData by the number of departments
        '-1 because the index counts from 0



        'Give a department name to each row in batterData 

        Dim i = 0 'Starting from the first index of batterData
        If batterInfo IsNot Nothing Then 'Existence check

            'Get each sub-element of the xml file
            For Each department As XElement In batterInfo.Elements

                'Existence check for the sub-elements of "department"
                If department.Name = "department" AndAlso department.HasElements Then

                    For Each stat As XElement In department.Elements
                        If stat.Name = "name" Then
                            'If the element "name" is spotted, then assign the name to the index of array
                            batterData(i, 0) = stat.Value.ToString
                            i += 1
                        End If
                    Next
                End If
            Next
        Else
            batterInfo = Nothing
            'Display a reminder message
            Throw New Exception("The department XML file cannot be found or is corrupt")
        End If


        'Read from history.csv and copy the data into an array for further calculation and searching

        Dim fileName As String = "history.csv"
        Dim sr As New StreamReader(fileName, Encoding.Default) 'Open the csv file
        Dim lines() = File.ReadAllLines(fileName) 'lines() is an array of separate lines read from the csv file
        Dim lineCount = lines.Count 'Calculate the length of this array
        Dim colCount = lines(0).Split(",").Count 'Calculate the width of this array
        Dim history(lineCount - 1, colCount - 1) 'Create a 2D array to store every cell value
        Dim sline As String = "" 'Initialise an empty string variable to read the csv file line by line

        For i = 0 To history.GetUpperBound(0) 'Read every line of history.csv
            sline = sr.ReadLine
            If sline = Nothing Then Exit For 'That means all lines are read
            Dim words() = sline.Split(",") 'words() is an array where cell values are automatically assigned and separated by comma
            For j = 0 To history.GetUpperBound(1)
                history(i, j) = words(j) 'At the (i+1)th line, assign each cell value
            Next
        Next

        sr.Close() 'Close the streamReader, otherwise this program will interrupt other program to open it


        'Calculate the total cost of each department, and put the results into the batterData

        For i = 0 To batterData.GetUpperBound(0)
            Dim cost As Single = 0 'Let it be single because cost can be decimal number
            For j = 0 To history.GetUpperBound(0)
                If history(j, 0) = batterData(i, 0) Then 'Check if the name of department is the same as listed in batterData()
                    Dim printingDate As Date = Convert.ToDateTime(history(j, 1)) 'The date is listed in the second column, index 1
                    If printingDate >= dtpFrom.Text And printingDate <= dtpTo.Text Then 'Check if the date is within the range  
                        cost += history(j, 9) 'Index 9 is the total cost of each printing
                    End If
                End If
            Next

            'Assign calculated values to the second column
            batterData(i, 1) = Math.Round(cost, 2)
        Next

        sorting()
    End Sub

    Sub sorting()

        'Sorting batterData and display it on the DataGridView

        If batterData.GetUpperBound(0) = 0 Then
            'If the batterData() has only one row, then sorting is meaningless
            MsgBox("Your are sorting an array that has only one row")
        Else

            'This method will leave the smallest value in the first row,
            'the second smallest value in the second row.
            'So this is ascending, at the top is the department that spent least

            Dim min As Integer

            For i = 0 To batterData.GetUpperBound(0) - 1  'Get every row except the last one, 
                'because every row before it will compare to it respectively; 
                'it does not need to compare to itself

                min = i 'Assume that the min occurs at the index (i)

                For j = i + 1 To batterData.GetUpperBound(0)
                    'Compare each of the rest rows to the (i+2)th row
                    'The rows between (and including) the first row and the (i+1)th row have already compared to it, so skip them

                    If batterData(j, 1) < batterData(min, 1) Then
                        'The comparison indicator, the total cost, is the second value of a row, index 1
                        'If the value of index (j,1) is smaller than min, mark it as the new min
                        min = j
                    End If
                Next

                'Swap the (i+1)th row and the min row
                'The first column
                Dim temp As String = batterData(min, 0) 'temporary variable for swapping
                batterData(min, 0) = batterData(i, 0)
                batterData(i, 0) = temp

                'the second column
                temp = batterData(min, 1)
                batterData(min, 1) = batterData(i, 1)
                batterData(i, 1) = temp

            Next

            dgvDepartments.Rows.Clear() 'Initialise the DataGridView, clear all cells

            Dim k = 0 'k represents the index of the last row of the DataGridView

            'Display sorted values in batterData on the DataGridView line by line
            For i = 0 To batterData.GetUpperBound(0)
                dgvDepartments.Rows.Add()
                dgvDepartments.Rows(k).Cells(0).Value = batterData(i, 0)
                dgvDepartments.Rows(k).Cells(1).Value = batterData(i, 1)
                k += 1
            Next

        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        'Export the batterData to a new csv file


        'Define the current date and time
        '4 digits for year, 2 digits for month and 2 digits for day, no separation
        Dim current As String = String.Format("{0:yyyyMMdd}", DateTime.Now).ToString

        Dim data = "" 'Define a variable to store the data that will be written into the new csv file

        'The name of the new file, including the current date
        Dim filename As String = "summary_" & current.ToString & ".csv"
        'The path will be "2020 SAC 1 Module 4 Felix Huang\SD U3O1 SAC\bin\Debug"

        'Open a FileStream that can create a new blank file
        Dim file As FileStream

        file = New FileStream(filename, FileMode.Create, FileAccess.ReadWrite)

        'Add each cell value to "data"
        For i = 0 To batterData.GetUpperBound(0)
            data &= batterData(i, 0).ToString & "," 'For the first cell of a row, a comma is needed to separate values
            data &= batterData(i, 1) & vbCrLf 'The last cell needs a new line to write another line
        Next

        'Write to csv file, save and close
        Dim sw As New StreamWriter(file)
        sw.Write(data)
        sw.Close()

    End Sub
End Class