'Filename:  formReports.vb
'Purpose:   generate and export a report
'Author:    Felix Huang
'Started on Aug 16, 2020

Imports System.IO
Public Class formReports
    'Navigation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formHome.Show()
        Hide()
    End Sub

    'Method:    btnGenerate.Click
    'Purpose:   Generate a business report that outlines some statistics of data in selected range
    'Input:     array, csv file, string
    'Output:    String
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        'Call this subroutine to pre-load the deals
        If formDeals.dealsLoaded Then
        Else
            formDeals.formDeals_Load(sender, e)
            formDeals.dealsLoaded = True
        End If
        Dim deals = formDeals.deals
        Dim dealsInRange(0, 16)

        'Calculate how many deals are in the time range
        Dim numDealsInRange As Integer = 0
        Dim timeInterval As Integer = 0
        If radAllTime.Checked Then
            txtReport.Text = "Report about deals from all time:" & vbCrLf
            For i = 0 To deals.GetUpperBound(0)
                Dim _date As Date = Convert.ToDateTime("31/12/1970 13:00:00")

                'If the transaction date (deals(i,2)) cannot be converted to date, then it is not in the range
                Try
                    _date = Convert.ToDateTime(deals(i, 2))
                Catch ex As Exception
                    GoTo skipCounting
                End Try
                numDealsInRange += 1
skipCounting:
            Next
        Else

            'Assigns time interval in days
            If radAnnual.Checked Then
                timeInterval = 365
            ElseIf radMonthly.Checked Then
                timeInterval = 30
            Else
                timeInterval = 7
            End If

            'Outline the exact range of deals selected
            txtReport.Text = "Deals from " & DateAdd(DateInterval.Day, -timeInterval, Now).ToLongDateString _
                    & " to " & Now.ToLongDateString & vbCrLf
            For i = 0 To deals.GetUpperBound(0)
                Dim _date As Date = Convert.ToDateTime("31/12/1970 13:00:00")

                'If the transaction date (deals(i,2)) cannot be converted to date, then it is not in the range
                Try
                    _date = Convert.ToDateTime(deals(i, 2))
                Catch ex As Exception
                    GoTo skipCounting2
                End Try

                'Check if this deal is done within the date range
                If _date >= DateAdd(DateInterval.Day, -timeInterval, Now) Then
                    numDealsInRange += 1
                End If
skipCounting2:
            Next
        End If

        'If no enough deals can be analysed, stop generating a report
        If numDealsInRange <= 3 Then
            txtReport.Text = "Hello"
            MsgBox("There are insufficient deals for the program to analyse. Please expand the date range or add more deals.")
            Exit Sub
        End If

        ReDim dealsInRange(numDealsInRange - 1, 16)
        Dim index = 0

        'Copy the deals in the date range into a new array
        For i = 0 To deals.GetUpperBound(0)
            Dim _date As Date = Convert.ToDateTime("31/12/1970 13:00:00")

            'If the transaction date (deals(i,2)) cannot be converted to date, then it is not in the range
            Try
                _date = Convert.ToDateTime(deals(i, 2))
            Catch ex As Exception
                GoTo skipcounting3
            End Try

            'Check if this deal is done within the date range. If true, copy this deal
            If radAllTime.Checked Or _date >= DateAdd(DateInterval.Day, -timeInterval, Now) Then
                For j = 0 To 16
                    dealsInRange(index, j) = deals(i, j)
                Next
                index += 1
            End If
skipcounting3:
        Next

        'Calculates profits
        Dim highestProfit = {0, 0, 0}
        Dim highestProfitDealsIndex = {-1, -1, -1}
        For i = 0 To dealsInRange.GetUpperBound(0)
            Dim profit = Val(dealsInRange(i, 6)) * Val(dealsInRange(i, 7)) 'Index 6: quantity, Index 7: price
            For j = 0 To 2
                If profit > highestProfit(j) Then
                    highestProfit(j) = profit
                    highestProfitDealsIndex(j) = i
                    GoTo profitListed
                End If
            Next
profitListed:
        Next

        'Display the top 3 deals that make the most profits
        txtReport.Text &= vbCrLf & "Deals that earn the highest profits: " & vbCrLf & vbCrLf
        For i = 0 To 2
            If highestProfitDealsIndex(i) > -1 Then
                txtReport.Text &=
                     "  Profit:   $" & Math.Round(highestProfit(i), 2) & vbCrLf &
                     "  Ref No.:  " & dealsInRange(highestProfitDealsIndex(i), 0) & vbCrLf &
                     "  Product:  " & dealsInRange(highestProfitDealsIndex(i), 3) & vbCrLf &
                     "  Factory:  " & dealsInRange(highestProfitDealsIndex(i), 4) & vbCrLf &
                     "  Customer: " & dealsInRange(highestProfitDealsIndex(i), 5) & vbCrLf & vbCrLf
            End If
        Next

        'Calculate the top 3 customers who made most deals with the client
        Dim customers As New List(Of String)
        For i = 0 To dealsInRange.GetUpperBound(0)
            customers.Add(dealsInRange(i, 5))
        Next

        'Get rid of repeated elements in the list
        customers = customers.Distinct().ToList
        Dim customersDeals(customers.Count - 1) As Integer
        For i = 0 To dealsInRange.GetUpperBound(0)
            For j = 0 To customers.Count - 1
                If dealsInRange(i, 5) = customers(j) Then
                    customersDeals(j) += 1
                    GoTo endOfFor1
                End If
            Next
endOfFor1:
        Next

        'Compare, and find the most frequently cooperated customers
        Dim closestCustomersDeals = {1, 1, 1}
        Dim closestCustomersIndex = {-1, -1, -1}
        For i = 0 To customersDeals.GetUpperBound(0)
            For j = 0 To 2
                If customersDeals(i) > closestCustomersDeals(j) Then
                    closestCustomersDeals(j) = customersDeals(i)
                    closestCustomersIndex(j) = i
                    GoTo endOfFor2
                End If
            Next
endOfFor2:
        Next

        'Display these customers
        If closestCustomersDeals(0) = 1 Then
            txtReport.Text &= "You have no outstanding customers who you have made the most deals with" &
                       vbCrLf & vbCrLf
        Else
            txtReport.Text &= "Top customers whom you have made the most deals with:" &
                        vbCrLf & vbCrLf
            For i = 0 To 2
                If closestCustomersDeals(i) > 1 Then
                    txtReport.Text &= "  Customer: " & customers(closestCustomersIndex(i)) & vbCrLf &
                        "  Deals: " & customersDeals(closestCustomersIndex(i)) & vbCrLf & vbCrLf
                End If
            Next
        End If

        'Calculate the top 3 factories who made most deals with the client
        Dim factories As New List(Of String)
        For i = 0 To dealsInRange.GetUpperBound(0)
            factories.Add(dealsInRange(i, 4))
        Next

        'Get rid of repeated elements in the list
        factories = factories.Distinct().ToList
        Dim factoriesDeals(factories.Count - 1) As Integer
        For i = 0 To dealsInRange.GetUpperBound(0)
            For j = 0 To factories.Count - 1
                If dealsInRange(i, 4) = factories(j) Then
                    factoriesDeals(j) += 1
                    GoTo endOfFor3
                End If
            Next
endOfFor3:
        Next

        'Compare, and find the most frequently cooperated factories
        Dim closestFactoriesDeals = {1, 1, 1}
        Dim closestFactoriesIndex = {-1, -1, -1}
        For i = 0 To factoriesDeals.GetUpperBound(0)
            For j = 0 To 2
                If factoriesDeals(i) > closestFactoriesDeals(j) Then
                    closestFactoriesDeals(j) = factoriesDeals(i)
                    closestFactoriesIndex(j) = i
                    GoTo endOfFor4
                End If
            Next
endOfFor4:
        Next

        'Display these factories
        If closestFactoriesDeals(0) = 1 Then
            txtReport.Text &= "You have no outstanding factories that you have made the most deals with" &
                       vbCrLf & vbCrLf
        Else
            txtReport.Text &= "Top factories that you have made the most deals with:" &
                        vbCrLf & vbCrLf
            For i = 0 To 2
                If closestFactoriesDeals(i) > 1 Then
                    txtReport.Text &= "  Factory: " & factories(closestFactoriesIndex(i)) & vbCrLf &
                        "  Deals: " & factoriesDeals(closestFactoriesIndex(i)) & vbCrLf & vbCrLf
                End If
            Next
        End If
    End Sub

    'Method:    btnExport.Click
    'Purpose:   Export the report to a txt file
    'Input:     String
    'Output:    String
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If txtReport.Text = "Hello" Then
            MsgBox("Please generate a report before you export it.")
            Exit Sub
        End If

        'Define the current date and time
        Dim current As String = String.Format("{0:yyyy_MM_dd hh_mm tt}", Now).ToString

        Dim data = txtReport.Text 'Define a variable to store the data that will be written

        'The name of the new file, including the current date
        Dim filename As String = "Report_" & current.ToString & ".txt"

        'Open a FileStream that can create a new blank file
        Dim file As FileStream
        file = New FileStream(filename, FileMode.Create, FileAccess.ReadWrite)

        'Write to txt file, save and close
        Dim sw As New StreamWriter(file)
        sw.Write(data)
        sw.Close()
        MsgBox("Exported successfully!")
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
End Class
