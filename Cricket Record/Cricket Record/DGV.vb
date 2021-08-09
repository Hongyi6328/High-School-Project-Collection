Imports System.IO
Imports System.Text
Imports System.Xml

Public Class DGV

    Dim batterData(0, 3) 'This is the master 2D array of all values needed to be calculated
    'It will be re-sized depending on the size of the file the program reads from

    Private Sub btnPick_Click(sender As Object, e As EventArgs) Handles btnPick.Click

        dgvBatmans.Rows.Clear() 'Initialise the DataGridView, clear all cells

        Dim batterInfo = XElement.Load("players.xml") 'It stores all the xml elements from the xml file
        Dim batterCount As Integer = 0 'It counts how many times the "name" element is spotted

        If batterInfo IsNot Nothing Then 'Existence check

            'Get each sub-element of the xml file
            For Each batsman As XElement In batterInfo.Elements

                'Existence check for the sub-elements of "batsman"
                If batsman.Name = "batsman" AndAlso batsman.HasElements Then
                    For Each stat As XElement In batsman.Elements
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
            Throw New Exception("The Players XML file cannot be found or is corrupt")
        End If

        ReDim batterData(batterCount - 1, 3) 'Resize the batterData by the number of batsman
        '-1 because the index counts from 0

        Dim i = 0 'The first index of batterData

        If batterInfo IsNot Nothing Then 'Existence check

            'Get each sub-element of the xml file
            For Each batsman As XElement In batterInfo.Elements

                'Existence check for the sub-elements of "batsman"
                If batsman.Name = "batsman" AndAlso batsman.HasElements Then

                    For Each stat As XElement In batsman.Elements
                        If stat.Name = "name" Then
                            'If the element "name" is spotted, then assign the name to the index of array
                            batterData(i, 0) = stat.Value
                            i += 1
                        End If
                    Next
                End If
            Next
        Else
            batterInfo = Nothing
            'Display a reminder message
            Throw New Exception("The Players XML file cannot be found or is corrupt")
        End If


        Dim fileName As String = "Innings History.csv"
        Dim sr As New StreamReader(fileName, Encoding.Default) 'Open the csv file
        Dim lines() = File.ReadAllLines(fileName) 'lines() is an array of separate lines read from the csv file
        Dim lineCount = lines.Count 'Calculate the length of this array
        Dim colCount = lines(0).Split(",").Count 'Calculate the width of this array
        Dim inningsHistory(lineCount - 1, colCount - 1) 'Create a 2D array to store every cell value
        Dim sline As String = "" 'Initialise an empty string variable to read the csv file line by line

        For i = 0 To inningsHistory.GetUpperBound(0) 'Read every line of Innings History.csv
            sline = sr.ReadLine
            If sline = Nothing Then Exit For 'That means all lines are read
            Dim words() = sline.Split(",") 'words() is an array where cell values are automatically assigned and separated by comma
            For j = 0 To inningsHistory.GetUpperBound(1)
                inningsHistory(i, j) = words(j) 'At the (i+1)th line, assign each cell value
            Next
        Next

        sr.Close() 'Close the streamReader, otherwise this program will interrupt other program to open it

        For i = 0 To batterData.GetUpperBound(0)
            Dim runs = 0
            Dim outs = 0
            Dim avg As Single = 0 'Let it be single because avg can be decimal number
            For j = 0 To inningsHistory.GetUpperBound(0)
                If inningsHistory(j, 0) = batterData(i, 0) Then 'Check if the name of player is the same as listed in batterData()
                    Dim inningsDate As Date = Convert.ToDateTime(inningsHistory(j, 1))
                    If inningsDate >= dtpFrom.Text And inningsDate <= dtpTo.Text Then 'Check if the date is within the range  
                        runs += inningsHistory(j, 3)
                        If inningsHistory(j, 5) = "False" Then
                            outs += 1
                        End If
                    End If
                End If
            Next
            If outs > 0 Then
                avg = Math.Round(runs / outs, 2) 'Calculation
            Else
                avg = 0
            End If
            'Assign calculated values to the rest null indices
            batterData(i, 1) = runs
            batterData(i, 2) = outs
            batterData(i, 3) = avg
        Next

        Dim k = 0 'k represents the index of the last row

        'Display all values in batterData on the DataGridView line by line
        For i = 0 To batterData.GetUpperBound(0)
            dgvBatmans.Rows.Add()
            dgvBatmans.Rows(k).Cells(0).Value = batterData(i, 0)
            dgvBatmans.Rows(k).Cells(1).Value = batterData(i, 1)
            dgvBatmans.Rows(k).Cells(2).Value = batterData(i, 2)
            dgvBatmans.Rows(k).Cells(3).Value = batterData(i, 3)
            k += 1
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainPage.Show()
        Hide()
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        If batterData.GetUpperBound(0) = 0 Then
            'If the batterData() has only one row, then sorting is meaningless
            MsgBox("Your are sorting an array that has only one row")
        Else
            'This method will leave the smallest value in the first row,
            'the second smallest value in the second row.
            'So this is ascending

            Dim min As Integer

            For i = 0 To batterData.GetUpperBound(0) - 1  'Get every row except the last one, 
                'because every row before it will compare to it respectively; 
                'it does not need to compare to itself

                min = i 'Assume that the minimum occur at the index (i)

                For j = i + 1 To batterData.GetUpperBound(0)
                    'Compare each of the rest rows to the (i+2)th row
                    'The first to the (i+1)th rows have already compared to it, so skip them

                    If batterData(j, 1) < batterData(min, 1) Then
                        'The comparison indicator is the second value of a row, that is, index 1
                        'If the value of index (j,1) is smaller, mark it as the new min
                        min = j
                    End If
                Next

                'Swap the (i+1)th row and the min row
                For x = 0 To batterData.GetUpperBound(1) 'x is the cell index
                    Dim temp As String = batterData(min, x) 'temporary variable for swapping
                    batterData(min, x) = batterData(i, x)
                    batterData(i, x) = temp
                Next
            Next

            dgvBatmans.Rows.Clear() 'Initialise the DataGridView, clear all cells

            Dim k = 0 'k represents the index of the last row

            'Display sorted values in batterData on the DataGridView line by line
            For i = 0 To batterData.GetUpperBound(0)
                dgvBatmans.Rows.Add()
                dgvBatmans.Rows(k).Cells(0).Value = batterData(i, 0)
                dgvBatmans.Rows(k).Cells(1).Value = batterData(i, 1)
                dgvBatmans.Rows(k).Cells(2).Value = batterData(i, 2)
                dgvBatmans.Rows(k).Cells(3).Value = batterData(i, 3)
                k += 1
            Next

        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        'Define the current date and time
        '4 digits for year, 2 digits for month and 2 digits for day
        Dim current As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now).ToString

        Dim data = "" 'Define a variable to store the data to write into the new csv file

        'The name of the new file, including the current date
        Dim filename As String = "Cricket_Summary_" & current.ToString & ".csv"

        'Open a FileStream that can create a new blank file
        Dim file As FileStream
        file = New FileStream(filename, FileMode.Create, FileAccess.ReadWrite)

        'Add each cell value to "data"
        For i = 0 To dgvBatmans.Rows.Count - 1
            For j = 0 To 2
                data &= dgvBatmans.Rows(i).Cells(j).Value.ToString & "," 'For the first 3 cells of a row, a comma is needed to separate values
            Next
            data &= dgvBatmans.Rows(i).Cells(3).Value.ToString & vbCrLf 'The last cell needs a new line to write another line
        Next

        'Write to csv file, save and close
        Dim sw As New StreamWriter(file)
        sw.Write(data)
        sw.Close()

    End Sub
End Class