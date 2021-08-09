'Filename:  formHome.vb
'Purpose:   a homepage for navigation and a brief summary of upcoming events and current date
'Author:    Felix Huang
'Started on July 6, 2020

Public Class formHome

    'Navigation
    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        formNotifications.Show()
        Hide()
    End Sub

    'Navigation
    Private Sub btnDeals_Click(sender As Object, e As EventArgs) Handles btnDeals.Click
        formDeals.Show()
        Hide()
    End Sub

    'Navigation
    Private Sub btnContacts_Click(sender As Object, e As EventArgs) Handles btnContacts.Click
        formContacts.Show()
        Hide()
    End Sub

    'Navigation
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        formReports.Show()
        Hide()
    End Sub

    'Navigation
    Private Sub picIcon_Click(sender As Object, e As EventArgs) Handles picIcon.Click
        formPassword.Show()
        Hide()
    End Sub

    'Reference the sorted and categorised array in formNotifications
    Dim pendingNotifications = formNotifications.pendingNotifications

    'Method:    formHome.VisibleChanged
    'Purpose:   Display current date and upcoming events
    'Input:     String, csv file, DateTime
    'Output:    String
    Private Sub formHome_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        lblDateTime.Text = "Today is " & Now.ToLongDateString

        'Call this subroutine to pre-load notifications so that the check boxes can display upcoming events
        formNotifications.formNotifications_Load(sender, e)
        pendingNotifications = formNotifications.pendingNotifications

        'Display 4 most recent events
        Dim checkBoxes = {chkSchedule1, chkSchedule2, chkSchedule3, chkSchedule4}
        For i = 0 To 3
            If i <= pendingNotifications.GetUpperBound(0) Then
                checkBoxes(i).Text = pendingNotifications(pendingNotifications.GetUpperBound(0) - i, 2) & "  " &
                pendingNotifications(pendingNotifications.GetUpperBound(0) - i, 0) & "  " &
                pendingNotifications(pendingNotifications.GetUpperBound(0) - i, 1)
            Else
                checkBoxes(i).Text = "No task"
            End If
        Next
    End Sub

    'Method:    formHome.Load
    'Purpose:   Call the subroutine in formNotification to pre-load the notifications
    'Input:     String, csv file, DateTime
    'Output:    String
    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Call this subroutine to pre-load notifications so that the check boxes can display upcoming events
        formNotifications.formNotifications_Load(sender, e)
        pendingNotifications = formNotifications.pendingNotifications
        formContacts.formContacts_Load(sender, e)
        formDeals.formDeals_Load(sender, e)
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

    'Method:    btnExit.Click
    'Purpose:   Confirm that all changes are saved before closing
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As String = MsgBox("Do you want to save all changes before closing?", vbYesNoCancel).ToString
        Select Case response

            'If yes, call the save subroutines
            'And then close the program
            Case "Yes"
                formNotifications.btnSave_Click(sender, e)
                If formContacts.btnSave.Enabled And formContacts.dgvContacts.Rows.Count > 1 Then
                    formContacts.btnSave_Click(sender, e)
                End If
                If formDeals.btnSave.Enabled And formDeals.dgvDeals.Rows.Count > 1 Then
                    formDeals.btnSave_Click(sender, e)
                End If
                formDealsAdvanced.Close()
                formEntry.Close()
                formPassword.Close()
                formRecommendation.Close()
                formReports.Close()
                formNotifications.Close()
                formContacts.Close()
                formDeals.Close()
                Close()
                End

            'If no, just close the program
            Case "No"
                formDealsAdvanced.Close()
                formEntry.Close()
                formPassword.Close()
                formRecommendation.Close()
                formReports.Close()
                formNotifications.Close()
                formContacts.Close()
                formDeals.Close()
                Close()
                End

            'If cancelled, do nothing
            Case "Cancel"
        End Select
    End Sub

    'Method:    btnHelp.Click
    'Purpose:   Provide a brief instruction to the user
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox(
"Welcome to use the Ultimate Trading Business Manager!
This is a guideline for you.
    
Security:
Username and password are always needed every time you open this program. You can change them by clicking the lock icon. Do not disclose any information about your username and password to others.

Notifications:
You can record your schedules and tasks in this section. The program will remind you of the 4 events that are about to due soonest. Please be aware of that the format of date is dd/MM/yyyy, and the format of time is hh:mm AM/PM.

Contact:
You can record your friends', families' and relatives' contact details here. The name is compulsory for a record to be saved.

Deals:
Similarly, you can track your deals here and use the program to give you a recommendation about a newly proposed deal. Reference numbers are needed for a deal. If you assign a value to the Trans Date field, you should also give a value to the Start Date, Product, Factory, Customer, Quantity and Price.

Reports:
You can be provided a business report that outlines the data in the range you select.

You may be informed with other validation rules if you accidentally break them.

Should you have any other queries, please do not hesitate to contact the author:
Felix Huang
Phone number: 0450095547
Email: hua0143@balwynhs.vic.edu.au

Wish you a very good experience here. Thank you for using the program.")
    End Sub
End Class