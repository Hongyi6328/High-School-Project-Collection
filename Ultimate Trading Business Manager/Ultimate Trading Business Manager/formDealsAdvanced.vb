'Filename:  formRecommendation.vb
'Purpose:   display, edit and deleted advanced information of a deal
'Author:    Felix Huang
'Started on July 18, 2020

Public Class formDealsAdvanced
    'Navigation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        formDeals.Show()
    End Sub

    Dim index As Integer = formDeals.advancedIndex 'The "bridge" variable

    'Method:    btnSave.Click
    'Purpose:   Validate and save data
    'Input:     String
    'Output:    String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        index = formDeals.advancedIndex

        Dim validated As Boolean = True

        'Validation: type check and range check
        If Val(txtDamagedGoods.Text) < 0 Or (Not IsNumeric(txtDamagedGoods.Text)) Then
            MsgBox("Damaged goods should be numeric and positive.")
            validated = False
        End If

        'Validation: type check and range check
        If Val(txtPassRate.Text) < 0 Or Val(txtPassRate.Text) > 1 Or (Not IsNumeric(txtPassRate.Text)) Then
            MsgBox("Pass rate should be numeric and between 0 and 1")
            validated = False
        End If

        'Validation: type check and range check
        If Val(txtProductionDuration.Text) <= 0 Or (Not IsNumeric(txtProductionDuration.Text)) Then
            MsgBox("Production duration should be numeric and positive.")
            validated = False
        End If

        'Save values in the array, not the file
        If validated Then
            formDeals.deals(index, 11) = txtPayments.Text
            formDeals.deals(index, 12) = txtTechnicalDetails.Text
            formDeals.deals(index, 13) = txtProductionDuration.Text
            formDeals.deals(index, 14) = txtPassRate.Text
            formDeals.deals(index, 15) = txtDamagedGoods.Text
        End If
    End Sub

    'Method:    formDealsAdvanced.VisibleChanged
    'Input:     String
    'Output:    String
    'Note:      Instead of Me.Shown, Me.VisibleChanged will be raised when Me.Show() method is used
    Private Sub formDealsAdvance_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Not Visible Then
            Exit Sub
        End If

        index = formDeals.advancedIndex

        'Show relevant data according to the "bridge" variable
        txtPayments.Text = formDeals.deals(index, 11)
        txtTechnicalDetails.Text = formDeals.deals(index, 12)
        txtProductionDuration.Text = formDeals.deals(index, 13)
        txtPassRate.Text = formDeals.deals(index, 14)
        txtDamagedGoods.Text = formDeals.deals(index, 15)
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