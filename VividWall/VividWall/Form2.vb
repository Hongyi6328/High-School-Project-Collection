Public Class Form2

    Dim PaperArea, SinglePrice As Single

    'Quick exit
    Private Sub btnExit_Click(e As Object, sender As EventArgs) _
        Handles btnExit.Click
        End
    End Sub

    'Calculate and display the results
    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Select Case Form1.cbbStyles.SelectedItem
            Case "Driftwood"
                SinglePrice = 115
                PaperArea = 0.6 * 7.3
            Case "Mojave"
                SinglePrice = 199
                PaperArea = 0.68 * 10.05
            Case "Jungle Friends"
                SinglePrice = 41
                PaperArea = 0.53 * 5.6
            Case "Trieste Swirl Pattern"
                SinglePrice = 84
                PaperArea = 0.82 * 8.4
            Case "Flamingo"
                SinglePrice = 423.5
                PaperArea = 7
            Case Else
                SinglePrice = 0
                PaperArea = 1
        End Select
        Dim Temp = Form1.EffectiveArea(Val(Form1.txtWindowHeight.Text), Val(Form1.txtWindowWidth.Text), Val(Form1.txtWallHeight.Text), Val(Form1.txtWallWidth.Text), _
                Val(Form1.txtWalls.Text), Val(Form1.txtWindows.Text))
        txtTotalArea.Text = Math.Round(Temp, 2)
        Form1.Rolls = Math.Ceiling(Temp / PaperArea)
        txtRolls.Text = Form1.Rolls.ToString
        Form1.RollsCost = Form1.Rolls * SinglePrice
        txtRollsCost.Text = FormatCurrency(Form1.RollsCost, 2)
        Form1.LabourCost = Temp * 20
        txtLabourCost.Text = FormatCurrency(Form1.LabourCost, 2)
        Form1.Prepping = Temp * 10
        txtPreppingCost.Text = FormatCurrency(Form1.Prepping, 2)
        If Form1.cbxRemoving.Checked Then
            Form1.RemovingCost = Temp * 5
        Else
            Form1.RemovingCost = 0
        End If
        txtRemovingCost.Text = FormatCurrency(Form1.RemovingCost, 2)
        If Form1.cbxRecommanded.Checked Then
            Form1.Recommanded = 0.95
        Else
            Form1.Recommanded = 1
        End If
        Form1.Discount = (Form1.RollsCost + Form1.LabourCost + Form1.Prepping + Form1.RemovingCost) * (1 - Form1.Recommanded)
        txtDiscount.Text = FormatCurrency(Form1.Discount, 2)
        Dim JobCost = Form1.LabourCost + Form1.Prepping + Form1.RemovingCost
        txtJobCost.Text = FormatCurrency((Form1.LabourCost + Form1.Prepping + Form1.RemovingCost), 2)
        Form1.GST = (Form1.RollsCost + Form1.LabourCost + Form1.Prepping + Form1.RemovingCost) * Form1.Recommanded * 0.1
        txtGST.Text = FormatCurrency(Form1.GST, 2)
        Form1.FinalCost = (Form1.RollsCost + JobCost) * Form1.Recommanded * 1.1
        txtFinalCost.Text = FormatCurrency(Form1.FinalCost, 2)
    End Sub

    'Switch between 2 forms
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class