'Filename:  formContacts.vb
'Function:  display, sort, edit, delete and search contact details
'Author:    Felix Huang
'Started on July 14, 2020
Imports System.IO

Public Class formContacts
    'Navigation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formHome.Show()
        Hide()
    End Sub

    'Declare a public array storing everything about contacts
    'The second index: from 0 to 5:
    'name, phone, address, email, tag and fax
    Dim contacts(0, 5) As String

    'Method:    formContacts.Load
    'Input:     string
    'Output:    string, array
    'Purpose:   Reads data from Contacts.csv and display it
    Friend Sub formContacts_Load(sender As Object, e As EventArgs) Handles Me.Load

        dgvContacts.Rows.Clear()
        Dim fileName As String = "Contacts.csv" 'map where the csv file is
        Dim fr As New StreamReader(fileName)

        'create a new instance of stream reader, 
        'an Object that can automatically read stream/text from a file
        Dim sline As String
        Dim x = 0
        sline = fr.ReadLine()

        'validation
        If sline = Nothing Then
            MsgBox("Cannot find Contacts.csv or it is empty.")
            fr.Close()
            Exit Sub
        End If

        'words() is an array
        'the method of split is to tell the program the sign that separates each value in the csv file
        'and assign them into words() respectively
        Do
            Dim words() As String = sline.Split(",")
            dgvContacts.Rows.Add()
            For i = 0 To 5
                'display values on the DataGridView one by one
                dgvContacts.Rows(x).Cells(i).Value = verticalBarToComma(existenceCheck(words(i).ToString)) 'Replace "|" with ","
            Next
            dgvContacts.Rows(dgvContacts.Rows.Count - 2).Cells(6).Value = "Edit"
            dgvContacts.Rows(dgvContacts.Rows.Count - 2).Cells(7).Value = "Delete"

            'Increase the index of the new row by 1
            x += 1

            sline = fr.ReadLine()

            ' Loop to check each row one by one
            'End loop when the next line is nothing
        Loop Until sline = Nothing

        'Update the contacts() array.
        ReDim contacts(dgvContacts.Rows.Count - 2, 5)
        For i = 0 To dgvContacts.Rows.Count - 2
            For j = 0 To 5
                Dim value As String
                If IsNothing(dgvContacts.Rows(i).Cells(j).Value) Then
                    value = ""
                Else
                    value = dgvContacts.Rows(i).Cells(j).Value
                End If
                contacts(i, j) = commaToVerticalBar(value)
            Next
        Next

        fr.Close()
    End Sub

    'Method:    btnSave.Click
    'Function:  Save all changes in the form, if validated
    'Input:     String
    'Output:    String
    'Note:      It is too hard to edit the exact row in the csv.file that is changed.
    '           The strategy is to delete the contents in the file and write the whole data into a new one
    Friend Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Validation, item "name" is compulsory
        For i = 0 To dgvContacts.Rows.Count - 2
            If dgvContacts.Rows(i).Cells(0).Value = "" Then
                MsgBox("You left at least one name blank, please fill in it before saving!")
                Exit Sub
            End If
        Next

        ReDim contacts(dgvContacts.Rows.Count - 2, 5)

        'Assign the values in dgvContacts to the array
        'Get rid of commas
        For i = 0 To dgvContacts.Rows.Count - 2
            For j = 0 To 5
                Dim value As String
                If IsNothing(dgvContacts.Rows(i).Cells(j).Value) Then
                    value = ""
                Else
                    value = dgvContacts.Rows(i).Cells(j).Value
                End If
                contacts(i, j) = commaToVerticalBar(value)
            Next
        Next

        Dim fileName = "Contacts.csv"

        Dim data As String = ""
        'Add each cell value to "data"
        For i = 0 To contacts.GetUpperBound(0)
            'For the first 5 cells of a row, a comma is needed to separate values
            For j = 0 To 4
                data &= contacts(i, j).ToString & ","
            Next
            data &= contacts(i, 5).ToString & vbCrLf 'The last cell needs a new line to write another line
        Next

        'Write to csv file, save and close
        Using file = My.Computer.FileSystem.OpenTextFileWriter(fileName, False) 'CreateNew to overwrite the existing one. False means to overwrite
            file.Write(data)
        End Using
        MsgBox("Saved successfully")
    End Sub


    'Function:  Convert comma to vertical bar to prevent clashes when reading from and writing to csv file 
    'Input:     String, comma
    'Output:    String, "|"
    Public Function commaToVerticalBar(str As String) As String
        Return str.Replace(",", "|")
    End Function

    'Function:  Convert vertical bar back to comma for displaying
    'Input:     String, vertical bar
    'Output:    String, comma
    Public Function verticalBarToComma(str As String) As String
        Return str.Replace("|", ",")
    End Function

    'Function:  Validation, existence check
    'Input:     String
    'Output:    String
    Public Function existenceCheck(str As String) As String
        If str = Nothing Then
            Return ""
        Else
            Return str
        End If
    End Function

    'Method:    btnSearch.Click
    'Input:     String, data grid view values
    'Output:    Selected data grid view rows
    'Purpose:   Select rows that contain the keyword and display them
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'If nothing to search for, then display all data
        'And the user can save the changes
        If txtSearch.Text = Nothing Then
            btnSave.Enabled = True

            'Display the whole data
            dgvContacts.Rows.Clear()
            For i = 0 To contacts.GetUpperBound(0)
                dgvContacts.Rows.Add()
                For j = 0 To 5
                    dgvContacts.Rows(i).Cells(j).Value = verticalBarToComma(contacts(i, j).ToString)
                Next
                dgvContacts.Rows(dgvContacts.Rows.Count - 2).Cells(6).Value = "Edit"
                dgvContacts.Rows(dgvContacts.Rows.Count - 2).Cells(7).Value = "Delete"
            Next
        Else
            'If the result of searching is being displayed, then the user cannot save
            'because to do so will lose the other part of data that is not displayed
            btnSave.Enabled = False

            'Search for what is input in txtSearch
            'and display the results in the data grid view
            dgvContacts.Rows.Clear()
            Dim NoResults As Boolean = True
            Dim target As String = txtSearch.Text
            For i = 0 To contacts.GetUpperBound(0)

                'This varaible represents whether anything is matched in the i+1 th row of contacts()
                'to prevent repeating rows in the data grid view if more than one piece is matched in the i+1 th row of contacts()
                Dim matchedInThisRow As Boolean = False

                For j = 0 To 5
                    'convert to comma first in case that the user searches for something that contains comma
                    Dim temp As String = verticalBarToComma(contacts(i, j).ToString)

                    'string.contains method enables quick check of whether the string includes the target
                    If temp.Contains(target) Then
                        matchedInThisRow = True
                        NoResults = False
                    End If
                Next

                'If matched, display results
                If matchedInThisRow Then
                    dgvContacts.Rows.Add()
                    For j = 0 To 5

                        'Minus 2 because there is an extra line for adding a row mannually
                        Dim temp As String = verticalBarToComma(contacts(i, j).ToString)
                        dgvContacts.Rows(dgvContacts.Rows.Count - 2).Cells(j).Value = temp
                    Next
                    dgvContacts.Rows(dgvContacts.Rows.Count - 2).Cells(6).Value = "Edit"
                    dgvContacts.Rows(dgvContacts.Rows.Count - 2).Cells(7).Value = "Delete"
                End If
            Next

            'Pop up a reminder if no results
            If NoResults Then
                MsgBox("Sorry, cannot find any results. Try another keyword.")
            End If
        End If
    End Sub

    'Method:    dgvContacts.RowsAdded
    'Input:     A new row
    'Output:    String
    Private Sub dgvContacts_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvContacts.RowsAdded
        'Write names on the cell buttons
        Dim rowCount = dgvContacts.Rows.Count - 1
        dgvContacts.Rows(rowCount).Cells(6).Value = "Edit"
        dgvContacts.Rows(rowCount).Cells(7).Value = "Delete"
    End Sub

    'Method:    dgvContacts.CellClick (Delete button)
    'Input:     Cell index
    'Output:    A dgv row removed
    Private Sub dgvContacts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContacts.CellClick
        If btnSave.Enabled Then 'It true, it means the user is not searching for something, the row can be deleted
            If e.ColumnIndex = 7 Then 'The "Delete button"
                dgvContacts.Rows.Remove(dgvContacts.Rows(e.RowIndex))
            End If
        End If
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

    'Method:    dgvContacts.EndEdit
    'Purpose:   Validate data when the user finishes entering
    'Input:     String
    'Output:    String
    Private Sub dgvContacts_EndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContacts.CellEndEdit
        Dim x As Integer = e.ColumnIndex
        Dim y As Integer = e.RowIndex
        Dim value As String = dgvContacts.Rows(y).Cells(x).Value
        If value = "" Then
            Exit Sub
        End If

        Select Case x

            'Validate name, should be string, not numeric, type check
            Case 0
                If containsDigits(value) Then
                    MsgBox("Names cannot contain digits.")
                    value = RemoveDigitsInAString(value)
                End If

            'Validate phone number, type check
            Case 1
                If containsLetters(value) Then
                    MsgBox("Phone numbers cannot contain letters")
                    value = removeLettersInAString(value)
                End If

            'Validate email: the pattern should be "something@something.something"
            Case 3
                If Not value Like "*@*.*" Then
                    value = ""
                    MsgBox("Email addresses should be something@something.something")
                End If
        End Select
        dgvContacts.Rows(y).Cells(x).Value = value
    End Sub

    'Function:  Indicates whether a string contains letters
    'Purpose:   For validation
    'Input:     String
    'Output:    Boolean
    Friend Function containsLetters(str As String) As Boolean
        If str.Length = 0 Or str = "" Then
            Return False
        Else
            For i = 0 To str.Length - 1
                If Not IsNumeric(str(i)) Then
                    Return True
                    Exit Function
                End If
            Next
            Return False
        End If
    End Function

    'Function:  Indicates whether a string contains digits
    'Purpose:   For validation
    'Input:     String
    'Output:    Boolean
    Friend Function containsDigits(str As String) As Boolean
        If str.Length = 0 Or str = "" Then
            Return False
        Else
            For i = 0 To str.Length - 1
                If IsNumeric(str(i)) Then
                    Return True
                    Exit Function
                End If
            Next
            Return False
        End If
    End Function

    'Function:  Get rid of numbers in a string, and return other characters
    'Purpose:   For validation
    'Input:     String
    'Output:    String
    Friend Function RemoveDigitsInAString(str As String) As String
        Dim temp As String = ""
        For i = 0 To str.Length - 1
            If Not IsNumeric(str(i)) Then
                temp &= str(i)
            End If
        Next
        Return temp
    End Function

    'Function:  Get rid of letters in a string, and return other characters
    'Purpose:   For validation
    'Input:     String
    'Output:    String
    Friend Function removeLettersInAString(str As String) As String
        Dim temp As String = ""
        For i = 0 To str.Length - 1
            If IsNumeric(str(i)) Then
                temp &= str(i)
            End If
        Next
        Return temp
    End Function
End Class