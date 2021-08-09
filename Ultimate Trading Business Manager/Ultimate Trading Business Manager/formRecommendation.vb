'Filename:  formRecommendation.vb
'Purpose:   generate a recommendation about what factory is to be chosen for the next deal
'Author:    Felix Huang
'Started on July 18, 2020

Public Class formRecommendation
    'Navigation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        formDeals.Show()
    End Sub

    'Method:    btnRecommend.Click
    'Input:     String, integer, array
    'Output:    String
    'Use scoring method - recommend the factory that gains the highest score in a past deal, comparing to this newly proposed deal
    Private Sub btnRecommend_Click(sender As Object, e As EventArgs) Handles btnRecommend.Click
        Dim validated As Boolean = True

        'Validation: existence check
        If txtPrice.Text = "" Or txtQuantity.Text = "" Or txtProduct.Text = "" Or txtSize.Text = "" Or txtPassRate.Text = "" Then
            MsgBox("Please fill in all items.")
            Validated = False
        End If

        'Validation: type check
        If Not IsNumeric(txtPrice.Text) Then
            MsgBox("Price should be a number.")
            validated = False
        End If
        If Not IsNumeric(txtQuantity.Text) Then
            MsgBox("Quantity should be a number")
            validated = False
        End If
        If Not IsNumeric(txtPassRate.Text) Then
            MsgBox("Pass rate should be a number")
            validated = False
        End If

        'Validation: range check
        If Val(txtPrice.Text) <= 0 Then
            MsgBox("Price should be positive")
            validated = False
        End If
        If Val(txtQuantity.Text) <= 0 Or Val(txtQuantity.Text) Mod 1 <> 0 Then
            MsgBox("Quantity should be a positive whole number")
            validated = False
        End If
        If Val(txtPassRate.Text) < 0 Or Val(txtPassRate.Text) > 1 Then
            MsgBox("Pass rate should be between 0 and 1")
            validated = False
        End If

        If Not validated Then Exit Sub

        'These 5 parameters are the new proposed deal's requirements
        Dim price As Single = Convert.ToSingle(txtPrice.Text)
        Dim quantity As Single = Convert.ToSingle(txtQuantity.Text)
        Dim product As String = txtProduct.Text
        Dim size As String = txtSize.Text
        Dim passRate As Single = Convert.ToSingle(txtPassRate.Text)

        'Define a local array, just for convenience
        Dim upperBound0 = formDeals.deals.GetUpperBound(0)
        Dim deals(upperBound0, 16)
        Array.Copy(formDeals.deals, deals, formDeals.deals.Length)

        'An array that stores the scores
        Dim scores(upperBound0) As Single

        'Start giving a score to a deal via the comparison between the proposed requirements and the deal's parameters
        For i = 0 To upperBound0
            Dim score As Single = 0

            'Comparison of prices, if a deal's price gets closer to the requirement, its score increases 
            score += 1000 - (price - Convert.ToSingle(deals(i, 7))) ^ 2 / 10


            'Comparison of quantities, if a deal's quantity is closer to the requirement, then the score increases. 
            'Divided by 10000 to lower the effect of quantity (because quantity is often thousands)
            score += 1000 - (Convert.ToSingle(deals(i, 6)) - quantity) ^ 2 / 10000

            'If this factory used to produce this product
            If product = deals(i, 3) Then
                score += 2000
            End If

            If size = deals(i, 8) Then
                score += 500
            End If

            'Multiply by 100000 to increase the weight of pass rate (because the difference between pass rates is often around 0.01)
            score += 1000 - 50000 * (deals(i, 14) - passRate) ^ 2

            scores(i) = score
        Next

        'Finding which deal has the highest score and display it
        Dim highestScore As Single = -9999999
        Dim index As Single = -1
        For i = 0 To upperBound0
            If scores(i) > highestScore Then
                highestScore = scores(i)
                index = i
            End If
        Next

        'This is to be displayed
        Dim message As String = ""
        message &= "Please choose " & deals(index, 4) & vbCrLf '(index,4) is the name of the factory
        message &= "Its score is " & Math.Round(scores(index), 2) & vbCrLf
        message &= "According to the deal that: " & vbCrLf
        message &= "    Ref NO.: " & deals(index, 0) & vbCrLf
        message &= "    Price: " & deals(index, 7) & vbCrLf
        message &= "    Quantity: " & deals(index, 6) & vbCrLf
        message &= "    Size: " & deals(index, 8) & vbCrLf
        message &= "    Pass Rate: " & deals(index, 14) & vbCrLf

        'If this factory used to produce this product
        If product = deals(index, 3) Then
            message &= "AND THIS FACTORY USED TO PRODUCE THE PRODUCT YOU WANT"
        Else
            message &= "But this factory did not produce the product you want"
        End If

        MsgBox(message)
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