'Filename:  formNotifications.vb
'Purpose:   add, edit, delete, sort notifications
'Author:    Felix Huang
'Started on July 24, 2020

Imports System.IO

Public Class formNotifications
    'Navigation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formHome.Show()
        Hide()
    End Sub

    'A public array storing everything about contacts
    'The second index: from 0 to 3:
    'date, time, task, state (finished or not)
    Friend notifications(0, 3) As String

    'Method:    formNotifications.Load
    'Input:     String
    'Output:    String, dgv values
    'Purpose:   Read data from Notifications.csv, sort it and display it
    Friend Sub formNotifications_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Initialise the format of the date time picker
        dtpTask.Format = DateTimePickerFormat.Custom
        dtpTask.CustomFormat = "dd/MM/yyyy hh:mm tt"

        'Reads data from Notifications.csv
        'create a new instance of stream reader, 
        'an Object that can automatically read stream/text from a file
        'map where the csv file is
        dgvNotifications.Rows.Clear()
        Dim fileName As String = "Notifications.csv"
        Dim fr As New StreamReader(fileName)

        Dim sline As String
        Dim x = 0
        sline = fr.ReadLine()

        'validation, existence check
        If sline = Nothing Then
            MsgBox("Cannot find Notifications.csv or it is empty.")
            fr.Close()
            Exit Sub
        End If

        'words() is an array
        'the method split() is to tell the program the sign that separates each value in the csv file
        'and assign them into words() respectively

        Do
            Dim words() As String = sline.Split(",")
            dgvNotifications.Rows.Add()
            For i = 0 To 3

                'display values on the DataGridView one by one
                dgvNotifications.Rows(x).Cells(i).Value = formContacts.verticalBarToComma(formContacts.existenceCheck(words(i).ToString)) 'Replace "|" with ","
            Next
            dgvNotifications.Rows(dgvNotifications.Rows.Count - 2).Cells(4).Value = "Edit"
            dgvNotifications.Rows(dgvNotifications.Rows.Count - 2).Cells(5).Value = "Delete"

            'Increase the index of the new row by 1
            x += 1
            sline = fr.ReadLine()
        Loop Until sline = Nothing ' Loop to check each row one by one
        'End loop when the next line is nothing

        ReDim notifications(dgvNotifications.Rows.Count - 2, 3)

        'Update the contacts() array.
        For i = 0 To dgvNotifications.Rows.Count - 2
            For j = 0 To 3
                Dim value As String
                If IsNothing(dgvNotifications.Rows(i).Cells(j).Value) Then
                    value = ""
                Else
                    value = dgvNotifications.Rows(i).Cells(j).Value
                End If
                notifications(i, j) = formContacts.commaToVerticalBar(value)
            Next
        Next

        'But this array is not sorted, so those finished tasks may be listed at the top
        'For the user's convenience, the unfinished/pending tasks should be listed at the top
        'Sorting:
        sortNotifications()

        dgvNotifications.Rows.Clear() 'Display notifications() back in the data grid view
        For i = 0 To notifications.GetUpperBound(0)
            dgvNotifications.Rows.Add()
            For j = 0 To 3
                dgvNotifications.Rows(i).Cells(j).Value = notifications(i, j)
            Next
            dgvNotifications.Rows(i).Cells(4).Value = "Edit"
            dgvNotifications.Rows(i).Cells(5).Value = "Delete"
        Next

        fr.Close()
    End Sub

    'Method:    btnSave.Click
    'Purpose:   Save all changes in the form
    'Input:     String, dgv values
    'Output:    String
    'Note:      It is too hard to edit the exact row in the csv.file that is changed
    '           The strategy is to delete the contents in the file and write the whole data into a new one
    Friend Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ReDim notifications(dgvNotifications.Rows.Count - 2, 3)

        'Assign the values in dgvContacts to the array
        'Get rid of commas
        For i = 0 To dgvNotifications.Rows.Count - 2
            For j = 0 To 3
                Dim value As String
                If IsNothing(dgvNotifications.Rows(i).Cells(j).Value) Then
                    value = ""
                Else
                    value = dgvNotifications.Rows(i).Cells(j).Value
                End If
                notifications(i, j) = formContacts.commaToVerticalBar(value)
            Next
        Next

        Dim fileName = "Notifications.csv"

        Dim data As String = ""
        'Add each cell value to "data"
        For i = 0 To notifications.GetUpperBound(0)
            For j = 0 To 2
                data &= notifications(i, j).ToString & "," 'For the first 3 cells of a row, a comma is needed to separate values
            Next
            data &= notifications(i, 3).ToString & vbCrLf 'The last cell needs a new line to write another line
        Next

        'Write to csv file, save and close
        Using file = My.Computer.FileSystem.OpenTextFileWriter(fileName, False) 'CreateNew to overwrite the existing one. False means to overwrite
            file.Write(data)
        End Using
        MsgBox("Saved successfully")
    End Sub

    'The 2 integers indicate the number of pending or finished notifications
    Friend numPendingNotifications As Integer = 0
    Friend numFinishedNotifications As Integer = 0

    'Break notifications() into 2 parts, the pending ones should be listed at the top
    Friend pendingNotifications(0, 3) As String
    Friend finishedNotifications(0, 3) As String

    'Input:     Array
    'Output:    Sorted Array
    'Note:      This subroutine does not actually sort the array.
    'Purpose:   It splits the array into 2 array, one pendingNotifications, and the other finishedNotifications
    '           Then it calls the selection sort function to sort the 2 arrays respectively
    '           Finally it combines the sorted arrays into 1 and display it.
    Private Sub sortNotifications()

        'The 2 integers indicate the number of pending or finished notifications
        numPendingNotifications = 0
        numFinishedNotifications = 0

        For i = 0 To notifications.GetUpperBound(0)
            If notifications(i, 3) = "True" Or notifications(i, 3) = "true" Then '(i,3) is the state of this notification
                numFinishedNotifications += 1
            Else
                numPendingNotifications += 1
            End If
        Next

        If numPendingNotifications > 0 Then
            'Assign those pending tasks to this array
            ReDim pendingNotifications(numPendingNotifications - 1, 3)
            Dim x = 0
            For i = 0 To notifications.GetUpperBound(0)
                If notifications(i, 3) = "False" Or notifications(i, 3) = "false" Or notifications(i, 3) = "" Then '(i,3) is the state of this notification. Nothing means false
                    notifications(i, 3) = "False"
                    For k = 0 To 3
                        'Give values, copy
                        pendingNotifications(x, k) = notifications(i, k)
                    Next
                    x += 1 'x indicates which row of pendingNotifications this process is up to
                End If
            Next
            pendingNotifications = selectionSort(pendingNotifications) 'Sort this array
        End If

        If numFinishedNotifications > 0 Then
            'Assign those finished tasks to this array
            ReDim finishedNotifications(numFinishedNotifications - 1, 3)
            Dim x = 0
            For i = 0 To notifications.GetUpperBound(0)
                If notifications(i, 3) = "True" Or notifications(i, 3) = "true" Then '(i,3) is the state of this notification
                    notifications(i, 3) = "True"
                    For k = 0 To 3
                        'Give values
                        finishedNotifications(x, k) = notifications(i, k)
                    Next
                    x += 1 'x indicates which row of pendingNotifications this process is up to
                End If
            Next
            finishedNotifications = selectionSort(finishedNotifications) 'Sort this array
        End If

        If numPendingNotifications > 0 And numFinishedNotifications > 0 Then

            'Combine the 2 sorted arrays together
            Array.Copy(pendingNotifications, 0, notifications, 0, pendingNotifications.Length)
            Array.Copy(finishedNotifications, 0, notifications, pendingNotifications.Length, finishedNotifications.Length) 'Start from the end of pendingNotifications

        ElseIf numPendingNotifications > 0 Then

            'If notifications() is full of pending notifications
            notifications = pendingNotifications

        ElseIf numFinishedNotifications > 0 Then

            'If notifications() is full of finished notifications
            notifications = finishedNotifications
        End If
    End Sub

    'Function:  Selection Sort, each time it will select the row that has the earliest date and bring it to the first index
    'Input:     Array
    'Output:    A new array that the selected row is brought to the first index
    Function selectionSort(arr As Array) As Array 'Sort the array notifications() with descending dates
        'Using recursion

        'This is the termination condition
        If arr.GetUpperBound(0) = 0 Then
            Return arr
        Else

            'These 2 variable indicate the row which is to be "selected" out
            Dim latestDate As Date = "31/12/1970 13:00:00"
            Dim latestDateIndex As Integer = -1

            'Select the latest date out
            For i = 0 To arr.GetUpperBound(0)
                Dim _dateTime As Date
                Dim dateTimeString As String = ""

                If IsNothing(arr(i, 0)) Or arr(i, 0) = "" Then 'Validation. Give a very early date and time to empty strings
                    dateTimeString = "31/12/1970"
                Else
                    dateTimeString = arr(i, 0)
                End If

                If IsNothing(arr(i, 1)) Or arr(i, 1) = "" Then
                    dateTimeString &= " 23:59:00"
                Else
                    dateTimeString &= " " & arr(i, 1) 'Add a whitespace to split date and time
                End If

                '(i,0) is the date, (i,1) is the time. Combine both together
                _dateTime = Convert.ToDateTime(dateTimeString) 'Convert string to DateTime


                If _dateTime >= latestDate Then
                    latestDate = _dateTime
                    latestDateIndex = i
                End If
            Next

            'A temporary array for recursion
            Dim temp(arr.GetUpperBound(0) - 1, 3)

            'Assign each value to array temp(), except the ones with latestDateIndex
            For i = 0 To arr.GetUpperBound(0)
                If latestDateIndex > i Then
                    For j = 0 To 3
                        temp(i, j) = arr(i, j)
                    Next

                    'Skip the latestDateIndex which is selected out
                ElseIf latestDateIndex < i Then
                    For j = 0 To 3
                        temp(i - 1, j) = arr(i, j)
                    Next
                End If
            Next

            'Recursion
            temp = selectionSort(temp)

            'Bring the selected-out row to the first place
            For j = 0 To 3
                arr(0, j) = arr(latestDateIndex, j)
            Next

            'Copy the sorted temp() to the rest of arr()
            For i = 0 To temp.GetUpperBound(0)
                For j = 0 To 3
                    arr(i + 1, j) = temp(i, j)
                Next
            Next
            Return arr
        End If
    End Function

    'Method:    dgvNotifications.CellClick
    'Input:     Cell index
    'Output:    A row removed
    'Purpose:   Delete a row
    Private Sub dgvNotifications_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNotifications.CellClick
        If e.ColumnIndex = 5 Then 'The "Delete button"
            If e.RowIndex = dgvNotifications.Rows.Count - 1 Then 'The last un-submitted row cannot be deleted
                Exit Sub
            End If
            dgvNotifications.Rows.Remove(dgvNotifications.Rows(e.RowIndex))
        End If
    End Sub

    'Method:    dgvNofifications.RowsAdded
    'Input:     A new row
    'Output:    String
    Private Sub dgvNotifications_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvNotifications.RowsAdded

        'Write the names on the cell buttons
        Try
            Dim lastIndex = dgvNotifications.Rows.Count - 2
            dgvNotifications.Rows(lastIndex).Cells(4).Value = "Edit"
            dgvNotifications.Rows(lastIndex).Cells(5).Value = "Delete"
            lastIndex = dgvNotifications.Rows.Count - 1
            dgvNotifications.Rows(lastIndex).Cells(4).Value = "Edit"
            dgvNotifications.Rows(lastIndex).Cells(5).Value = "Delete"
        Catch ex As Exception
        End Try
    End Sub

    'Method:    btnNewTask.Click
    'Input:     String, DateTime
    'Output:    String, DateTime
    'Purpose:   Add a new notification to both the array and the data grid view
    Private Sub btnNewTask_Click(sender As Object, e As EventArgs) Handles btnNewTask.Click
        If txtTask.Text = "" Then 'Existence check
            MsgBox("Please specify your task.")
            Exit Sub
        End If

        'The index 0 to 9 of the string in the date time picker is the date 
        Dim _date As String = ""
        For i = 0 To 9
            _date &= dtpTask.Text(i)
        Next

        'The index 11 to 18 of the string in the date time picker is the time
        Dim time As String = ""
        For i = 11 To 18
            time &= dtpTask.Text(i)
        Next

        'Add this notification to the data grid view
        dgvNotifications.Rows.Add()
        Dim index = dgvNotifications.Rows.Count - 2
        dgvNotifications.Rows(index).Cells(0).Value = _date
        dgvNotifications.Rows(index).Cells(1).Value = time
        dgvNotifications.Rows(index).Cells(2).Value = txtTask.Text
    End Sub

    'Method:    MyBase.Layout
    'Purpose:   Keep the interface always in the centre
    Private Sub MyForm_Layout(ByVal sender As Object,
    ByVal e As LayoutEventArgs) Handles MyBase.Layout

        ' Center the Form on the user's screen everytime it requires a Layout.
        SetBounds((Screen.GetBounds(Me).Width / 2) - (Width / 2),
            (Screen.GetBounds(Me).Height / 2) - (Height / 2),
            Width, Height, BoundsSpecified.Location)
    End Sub

    'Method:    dgvNotifications.EndEdit
    'Purpose:   Validate data when the user finishes entering
    'Input:     String
    'Output:    String
    Private Sub dgvNotifications_EndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNotifications.CellEndEdit
        Dim x As Integer = e.ColumnIndex
        Dim y As Integer = e.RowIndex
        Dim value As String = dgvNotifications.Rows(y).Cells(x).Value
        If value = "" Then
            Exit Sub
        End If

        Select Case x

            'Validate dates
            Case 0
                Dim _Date As Date
                Try
                    _Date = Convert.ToDateTime(value)
                Catch ex As Exception
                    MsgBox("Please enter the correct date.")
                    value = ""
                    Exit Select
                End Try

                'If passed the check above, convert to the correct format
                value = _Date.ToString("dd/MM/yyyy")

           'Validate time
            Case 1
                Dim time As Date
                Try
                    time = Convert.ToDateTime(value)
                Catch ex As Exception
                    MsgBox("Please enter the correct time.")
                    value = ""
                    Exit Select
                End Try

                'If passed the check above, convert to the correct format
                value = time.ToString("hh:mm tt")

            'Validate task: type check: should not be numeric
            Case 2
                If IsNumeric(value) Then
                    MsgBox("Your task cannot be numeric.")
                    value = ""
                End If
        End Select
        dgvNotifications.Rows(y).Cells(x).Value = value
    End Sub
End Class