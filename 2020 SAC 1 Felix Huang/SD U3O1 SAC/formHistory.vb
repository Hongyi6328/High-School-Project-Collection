Imports System.IO
Public Class formHistory
    'Navigation
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Hide()
        formMainMenu.Show()
    End Sub

    'Navigation
    Private Sub btnPrinting_Click(sender As Object, e As EventArgs) Handles btnPrinting.Click
        Hide()
        formPrinting.Show()
    End Sub

    'Navigation
    Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        Hide()
        formDepartments.Show()
    End Sub

    Private Sub formHistory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Clear it to refresh
        'not to collide with the existing grid values
        dgvHistory.Rows.Clear()
        Dim fileName As String = "history.csv" 'map where the csv file is
        Dim fr As New StreamReader(fileName)
        'create a new instance of stream reader, 
        'an Object that can automatically read stream/text from a file
        Dim sline As String
        Dim x = 0
        sline = fr.ReadLine()
        Do
            'words() is an array
            'the method of split is to tell the program the sign that separates each value in the csv file
            'and assign them into words() respectively
            Dim words() As String = sline.Split(",")
            dgvHistory.Rows.Add()
            For i = 0 To 9
                'display values on the DataGridView one by one
                dgvHistory.Rows(x).Cells(i).Value = words(i)
            Next
            'Increase the index of the new row by 1
            x += 1
            sline = fr.ReadLine()
        Loop Until sline = Nothing ' Loop to check each row one by one
        'End loop when the next line is nothing
    End Sub

    'Provide a button to refresh the DataGridView
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        formHistory_Shown(sender, e)
    End Sub

End Class