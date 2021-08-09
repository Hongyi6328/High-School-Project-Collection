'Filename:  formDeals.vb
'Purpose:   Display, sort, edit, delete and search deals
'Author:    Felix Huang
'Started on July 18, 2020
Imports System.IO

Public Class formDeals
    'Navigation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formHome.Show()
        Hide()
    End Sub

    'Navigation
    Private Sub btnRecommend_Click(sender As Object, e As EventArgs) Handles btnRecommend.Click
        formRecommendation.Show()
        Hide()
    End Sub

    'Declare a public array storing everything about contacts
    'The second index: from 0 to 16:
    'ref No., start date, transaction date, product, factory, customer, quantity, 
    'price, size, package, tags, payments, technical details, production duration, 
    'pass rate, damaged goods, ID.
    'ref No. is compulsory because it is the unique ID of a deal in real life
    Public deals(0, 16) As String

    'There will be an invisible column in the data grid view, 
    'indicating the temporary (that Is, this ID would not be saved in 
    'the csv file) ID of a deal. If the user changes of order of data and then 
    'edits some cells, especially the reference number, this ID can help me map 
    'which deal is being edited without looking at its relative position in
    'the data grid view.
    Dim highestID As Integer = 0

    'This variable indicates whether it is the user that adds a row in the data grid view.
    'To prevent repeated generation of the ID.
    Dim userAddsRow As Boolean = False

    'A Boolean variable indicates whether deals are loaded.
    Friend dealsLoaded As Boolean = False

    'Method:    formDeals.Load
    'Function:  Reads data from Deals.csv and display it
    'Input:     String
    'Output:    String, data grid view values
    Friend Sub formDeals_Load(sender As Object, e As EventArgs) Handles Me.Load
        userAddsRow = False
        dgvDeals.Rows.Clear()
        Dim fileName As String = "Deals.csv" 'map where the csv file is
        Dim fr1 As New StreamReader(fileName)

        'create a new instance of stream reader, 
        'an Object that can automatically read stream/text from a file
        Dim sline As String
        Dim x = 0
        sline = fr1.ReadLine()

        'validation
        If sline = Nothing Then
            MsgBox("Cannot find Deals.csv or it is empty.")
            fr1.Close()
            Exit Sub
        End If

        Do
            'The same thing as the previous Do loop
            'But this time for loading data to the data grid view
            Dim words() As String = sline.Split(",")
            dgvDeals.Rows.Add()
            For i = 0 To 10
                'display values on the data grid view one by one
                dgvDeals.Rows(x).Cells(i).Value =
                    formContacts.verticalBarToComma(
                    formContacts.existenceCheck(words(i).ToString)) 'Replace "|" with ","
            Next
            userAddsRow = False 'This is automated row adding
            dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(11).Value = "Advanced"
            dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(12).Value = "Edit"
            dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(13).Value = "Delete"
            dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(14).Value = x.ToString
            'Increase the index of the new row by 1
            x += 1
            sline = fr1.ReadLine()
        Loop Until sline = Nothing ' Loop to check each row one by one
        'End loop when the next line is nothing
        fr1.Close()

        userAddsRow = True

        'Update the size of deals() array
        'This is also the reason for loading to data grid view first and then the array
        ReDim deals(dgvDeals.Rows.Count - 2, 16)

        'create a new instance of stream reader, 
        'an Object that can automatically read stream/text from a file
        Dim fr2 As New StreamReader(fileName)

        x = 0
        sline = fr2.ReadLine()

        'words() is an array
        'the method of split is to tell the program the sign that separates each value in the csv file
        'and assign them into words() respectively
        'Load data to the array  
        Do
            Dim words() As String = sline.Split(",")
            For i = 0 To 10
                'display values on the DataGridView one by one
                deals(x, i) =
                    formContacts.verticalBarToComma(
                    formContacts.existenceCheck(words(i).ToString)) 'Replace "|" with ","
            Next

            For i = 11 To 15 'Index 11 to 15 may be multi-line
                deals(x, i) =
                    slashToNewLine('Replace "\n" with vbCrLf
                    formContacts.verticalBarToComma(
                    formContacts.existenceCheck(words(i).ToString))) 'Replace "|" with ","
            Next

            'The temporary ID to track a deal just in case that the user changes the order of data or the ref no. 
            deals(x, 16) = x
            highestID += 1

            'Increase the index of the new row by 1
            x += 1
            sline = fr2.ReadLine()

            ' Loop to check each row one by one
            'End loop when the next line is nothing
        Loop Until sline = Nothing
        fr2.Close()
        dealsLoaded = True
    End Sub

    'Method:    btnSave.Click
    'Purpose:   Save all changes and write the whole data to the csv file
    'Input:     Data grid view values,
    'Output:    String
    Friend Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Validation: existence check: the ref no is compulsory
        For i = 0 To dgvDeals.Rows.Count - 2
            If dgvDeals.Rows(i).Cells(0).Value = "" Then
                MsgBox("Please fill in all ref no.")
                Exit Sub
            End If
        Next

        'Validation: if a deal has got its trans date (which means it is done), then some crucial fields cannot be blank
        'This is the foundation of generating a report
        'No garbage in, no garbage out
        For i = 0 To dgvDeals.Rows.Count - 2
            If Not dgvDeals.Rows(i).Cells(2).Value = "" Then
                Dim requiredFieldsList() As Integer = {3, 4, 5, 6, 7} 'They are product, factory, customer, quantity and price
                For j = 0 To requiredFieldsList.GetUpperBound(0)
                    If dgvDeals.Rows(i).Cells(requiredFieldsList(j)).Value = "" Then
                        MsgBox("If you have given a deal its trans date, you must fill in its product, factory, customer, quantity and price as well")
                        Exit Sub
                    End If
                Next
            End If
        Next

        'Define a temporary array that is to be saved into the csv file.
        Dim temp(dgvDeals.Rows.Count - 2, 16) As String

        'Assign the values in dgvContacts to the array temp()
        'Get rid of commas
        For i = 0 To dgvDeals.Rows.Count - 2
            For j = 0 To 10
                Dim value As String
                If IsNothing(dgvDeals.Rows(i).Cells(j).Value) Then
                    value = ""
                Else
                    value = dgvDeals.Rows(i).Cells(j).Value
                End If
                temp(i, j) = value
                'Make sure the data is saved in the correct format (without commas and enter)
            Next
            temp(i, 16) = dgvDeals.Rows(i).Cells(14).Value
        Next

        'Assign the advanced values that are not shown in the data grid view,
        'Using the ID and deals()
        For i = 0 To temp.GetUpperBound(0)

            'This variable indicates if this deal is new and not listed in the array
            Dim isInArrayDeals As Boolean = False

            For j = 0 To deals.GetUpperBound(0)
                If temp(i, 16) = deals(j, 16) Then 'If there IDs are the same
                    Dim value As String = ""
                    For k = 11 To 15
                        If IsNothing(deals(j, k)) = False Then 'Existence check
                            value = deals(j, k)
                        End If
                        temp(i, k) = value  'k index 11 to 15 are the advanced parameters that are not listed in the data grid view
                    Next
                    isInArrayDeals = True
                    Exit For
                End If
            Next

            'If this deal is not listed in the array deals(), then it means it has no advanced information
            If isInArrayDeals = False Then
                For k = 11 To 15
                    temp(i, k) = ""
                Next
            End If
        Next

        'Copy temp() to deals()
        ReDim deals(temp.GetUpperBound(0), temp.GetUpperBound(1))
        Array.Copy(temp, deals, temp.Length)

        Dim fileName = "Deals.csv"
        Dim data As String = ""

        'Add each cell value to "data"
        For i = 0 To deals.GetUpperBound(0)
            Dim value As String = ""
            For j = 0 To 14
                value = newLineToSlash(formContacts.commaToVerticalBar(deals(i, j).ToString))

                'For the first 15 cells of a row, a comma is needed to separate values
                data &= value & ","
            Next
            value = newLineToSlash(formContacts.commaToVerticalBar(deals(i, 15).ToString))

            'The last cell needs a new line to write another line, the ID numder does not need to be saved
            data &= value & vbCrLf
        Next

        'Write to csv file, save and close
        Using file = My.Computer.FileSystem.OpenTextFileWriter(fileName, False) 'CreateNew to overwrite the existing one. False means to overwrite
            file.Write(data)
        End Using
        MsgBox("Saved successfully")
    End Sub

    'Method:    btnSearch.Click
    'Input:     String, array
    'Output:    String, Selected data grid view rows
    'Purpose:   Select rows that contain the keyword and display them
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'If nothing to search for, then display all data
        'And the user can save the changes
        If txtSearch.Text = Nothing Then
            btnSave.Enabled = True

            'This is automated row adding
            userAddsRow = False

            'Display the data
            dgvDeals.Rows.Clear()
            For i = 0 To deals.GetUpperBound(0)
                dgvDeals.Rows.Add()
                For j = 0 To 10
                    dgvDeals.Rows(i).Cells(j).Value =
                        formContacts.verticalBarToComma(deals(i, j).ToString)
                Next
                dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(11).Value = "Advanced"
                dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(12).Value = "Edit"
                dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(13).Value = "Delete"
                dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(14).Value = deals(i, 16)
            Next

            'Defult: except automated row adding, all row adding is assumed to be user's action
            userAddsRow = True
        Else

            'If the result of searching is being displayed, then the user cannot save
            'because to do so will lose the other part of data that is not displayed
            btnSave.Enabled = False

            'Search for what is input in txtSearch
            'and display the results in the data grid view
            Dim NoResults As Boolean = True
            Dim target As String = txtSearch.Text
            userAddsRow = False 'This is automated row adding
            dgvDeals.Rows.Clear()

            For i = 0 To deals.GetUpperBound(0)
                'This varaible represents whether anything is matched in the i+1 th row of contacts()
                'to prevent repeating rows in the data grid view if more than one piece is matched in the i+1 th row of contacts()

                Dim matchedInThisRow As Boolean = False
                For j = 0 To 15 'The index 16, which is the ID, is not in the range of searching
                    Dim temp As String = formContacts.verticalBarToComma(deals(i, j).ToString) 'convert to comma first in case that the user searches for something that contains comma

                    'string.contains method enables quick check of whether the string includes the target
                    If temp.Contains(target) Then
                        matchedInThisRow = True
                        NoResults = False
                    End If
                Next

                'If matched, display results
                If matchedInThisRow Then
                    dgvDeals.Rows.Add()
                    For j = 0 To 10
                        Dim temp As String = formContacts.verticalBarToComma(deals(i, j).ToString) 'Minus 2 because there is an extra line for adding a row mannually
                        dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(j).Value = temp
                    Next

                    dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(11).Value = "Advanced"
                    dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(12).Value = "Edit"
                    dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(13).Value = "Delete"
                    dgvDeals.Rows(dgvDeals.Rows.Count - 2).Cells(14).Value = deals(i, 16)
                End If
            Next

            'Default: except automated row adding, all adding is assumed as the user's action
            userAddsRow = True

            'Pop up a reminder if no results
            If NoResults Then
                MsgBox("Sorry, cannot find any results. Try another keyword.")
            End If
        End If
    End Sub

    'Method:    dgvDeals.RowsAdded
    'Input:     Nothing
    'Output:    A new data grid view row, string
    Private Sub dgvDeals_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvDeals.RowsAdded

        'Write the names on the cell buttons
        Dim lastIndex = dgvDeals.Rows.Count - 1
        dgvDeals.Rows(lastIndex).Cells(11).Value = "Advanced"
        dgvDeals.Rows(lastIndex).Cells(12).Value = "Edit"
        dgvDeals.Rows(lastIndex).Cells(13).Value = "Delete"

        'Give an ID number to the new deal
        If userAddsRow Then
            dgvDeals.Rows(lastIndex - 1).Cells(10).Value = "new" 'Default tag
            dgvDeals.Rows(lastIndex - 1).Cells(14).Value = highestID
            highestID += 1
        End If
    End Sub

    'This is a "bridge" variable between formDeals and formAdvance
    'To indicate which deal's advanced information is to be shown and updated
    Public advancedIndex As Integer

    'Method:    dgvDeals.CellClick
    'Input:     Cell index
    'Output:    formDealsAdvanced
    'Purpose:   Depending on which button is clicked. Delete a row or show relevant information of a deal
    Private Sub dgvDeals_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDeals.CellClick

        'If true, it means the user is not searching for something, the row can be deleted
        If btnSave.Enabled Then

            If e.ColumnIndex = 13 Then 'The "Delete button"

                If e.RowIndex = dgvDeals.Rows.Count - 1 Then 'The last un-submitted row cannot be deleted
                    Exit Sub
                End If

                'Map which deal is being deleted
                Dim ID As Integer = dgvDeals.Rows(e.RowIndex).Cells(14).Value
                Dim index As Integer = -1
                For i = 0 To deals.GetUpperBound(0)
                    If deals(i, 16) = ID Then
                        index = i
                        Exit For
                    End If
                Next

                If index > -1 Then 'This index is not in the array

                    'Delete this deal from the array, by creating a tempoaray array
                    Dim newUpperBound0 = deals.GetUpperBound(0) - 1
                    Dim temp(newUpperBound0, 16)
                    For i = 0 To deals.GetUpperBound(0)
                        If i < index Then
                            For j = 0 To 16
                                temp(i, j) = deals(i, j)
                            Next
                        ElseIf i > index Then
                            For j = 0 To 16
                                temp(i - 1, j) = deals(i, j) 'i-1 to fill in the gap of deleted row
                            Next
                        End If
                        'Hence, the deal that is being deleted will not be recorded in the new array
                    Next

                    'Update array deals()
                    ReDim deals(newUpperBound0, 16)
                    Array.Copy(temp, deals, temp.Length)

                    'Delete the deal visually
                    dgvDeals.Rows.Remove(dgvDeals.Rows(e.RowIndex))
                Else

                    'If the row has not been added to the array yet, then just delete it from the data grid view
                    dgvDeals.Rows.Remove(dgvDeals.Rows(e.RowIndex))
                End If
            End If
        End If

        If e.ColumnIndex = 11 Then 'Index 11 is the "Advanced" button

            'Check which deal is selected to see its advanced information
            Dim ID = dgvDeals.Rows(e.RowIndex).Cells(14).Value
            advancedIndex = -1 'The index of selected deal; formAdvanced will use this

            'If there is no deal of which the ID is what the program seeks for, then it means this deal is newly added.
            Dim NotMatched As Boolean = True
            For i = 0 To deals.GetUpperBound(0)
                If deals(i, 16) = ID Then
                    NotMatched = False
                    advancedIndex = i
                    Exit For
                End If
            Next

            If NotMatched Then 'There is no recorded deal that has this ID
                MsgBox("This is a newly added deal. Please click Save before you edit its advanced information.")
            Else
                Hide()
                formDealsAdvanced.Show()
            End If
        End If
    End Sub

    'Function:  Convert a new line to "\n" to save in a csv file
    'Input:     String, line 
    'Output:    String, "\n"
    Public Function newLineToSlash(str As String) As String
        str = str.Replace(vbCrLf, "\n")
        Return str
    End Function

    'Function:  Convert "\n" to a new line to display normally
    'Input:     String, "\n"
    'Output:    String, line
    Public Function slashToNewLine(str As String) As String
        str = str.Replace("\n", vbCrLf)
        Return str
    End Function

    'Method:    MyBase.Layout
    'Purpose:   Keep the interface always in the centre
    Private Sub MyForm_Layout(ByVal sender As Object,
    ByVal e As LayoutEventArgs) Handles MyBase.Layout

        ' Center the Form on the user's screen everytime it requires a Layout.
        SetBounds((Screen.GetBounds(Me).Width / 2) - (Width / 2),
            (Screen.GetBounds(Me).Height / 2) - (Height / 2),
            Width, Height, BoundsSpecified.Location)
    End Sub

    'Method:    dgvDeals.EndEdit
    'Purpose:   Validate data when the user finishes entering
    'Input:     String
    'Output:    String
    Private Sub dgvDeals_EndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDeals.CellEndEdit
        Dim x As Integer = e.ColumnIndex
        Dim y As Integer = e.RowIndex
        Dim value As String = dgvDeals.Rows(y).Cells(x).Value
        If value = "" Then
            Exit Sub
        End If

        Select Case x

            'Validate ref no. Type check: should be numeric and positive
            Case 0
                If formContacts.containsletters(value) Then
                    MsgBox("Ref no. cannot contain letters.")
                    value = formContacts.RemoveDigitsInAString(value)
                End If

            'Validate start dates: start dates should be in the correct form and earlier than trans date
            Case 1
                Dim startDate As Date, transDate As Date
                Try
                    startDate = Convert.ToDateTime(value)
                Catch ex As Exception
                    MsgBox("Please enter the correct date: dd/MM/yyyy.")
                    value = ""
                    Exit Select
                End Try

                'Compare the start date and the trans date
                If Not dgvDeals.Rows(y).Cells(2).Value = "" Then
                    transDate = Convert.ToDateTime(dgvDeals.Rows(y).Cells(2).Value)
                    If transDate < startDate Then
                        MsgBox("Start date should be not later than trans date")
                        value = ""
                        Exit Select
                    End If
                End If

                'If passed the checks above, convert to the correct format
                value = startDate.ToString("dd/MM/yyyy")

            'Validate trans dates: the same rule
            Case 2
                Dim startDate As Date, transDate As Date
                Try
                    transDate = Convert.ToDateTime(value)
                Catch ex As Exception
                    MsgBox("Please enter the correct date: dd/MM/yyyy.")
                    value = ""
                    Exit Select
                End Try

                'Compare the start date and the trans date
                If Not dgvDeals.Rows(y).Cells(1).Value = "" Then
                    startDate = Convert.ToDateTime(dgvDeals.Rows(y).Cells(1).Value)
                    If transDate < startDate Then
                        MsgBox("Start date should be not later than trans date")
                        value = ""
                        Exit Select
                    End If
                End If

                'If passed the checks above, convert to the correct format
                value = transDate.ToString("dd/MM/yyyy")

            'Validate factory, customer, package and tags: not numeric; type check
            Case 4
                If IsNumeric(value) Then
                    MsgBox("Factory cannot be numeric.")
                    value = ""
                End If
            Case 5
                If IsNumeric(value) Then
                    MsgBox("Customer cannot be numeric.")
                    value = ""
                End If
            Case 9
                If IsNumeric(value) Then
                    MsgBox("Package cannot be numeric.")
                    value = ""
                End If
            Case 10
                If IsNumeric(value) Then
                    MsgBox("Tags cannot be numeric.")
                    value = ""
                End If

            'Validate quantity: type check: should be positive whole number
            Case 6
                If formContacts.containsLetters(value) Or Val(value) <= 0 Or (Not Val(value) Mod 1 = 0) Then
                    MsgBox("Quantity cannot contain letters and should be positive whole number.")
                    value = ""
                End If

            'Validate price: type check: should be positive number
            Case 7
                If (Not IsNumeric(value)) Or Val(value) <= 0 Then
                    MsgBox("Price should be a positive number.")
                    value = ""
                End If

        End Select
        dgvDeals.Rows(y).Cells(x).Value = value
    End Sub
End Class
