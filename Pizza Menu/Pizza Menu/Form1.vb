'This program is done by Felix Huang on 26th June
'For pizza ordering
Public Class Form1
    'The global variable
    Dim price As Decimal

    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        If cmbStyle.SelectedItem = Nothing Then
            MsgBox("Please choose a style") 'to prevent null exception
            price = 0
        Else
            'Allocate price by style
            Select Case cmbStyle.SelectedItem
                Case "Hawaiian $ 10"
                    price = 10
                Case "Capricciosa $ 7"
                    price = 7
                Case "Meat Lover $ 12"
                    price = 12
                Case "Aussie $ 14"
                    price = 14
                Case "Margarita $ 8"
                    price = 8
                Case "Supreme $ 9"
                    price = 9
            End Select
        End If
        'Use a factor to adjust the price by its size
        If rbtnExLrg.Checked = True Then
            price *= 2
        ElseIf rbtnLrg.Checked = True Then
            price *= 1.5
        ElseIf rbtnSmall.Checked = True Then
            price *= 0.8
        ElseIf rbtnMed.Checked = False Then
            MsgBox("Please choose a size") 'to prevent null exception
            price = 0
        End If
        price *= nudQuantity.Value
        If chkDelivery.Checked = True Then
            If chkPick.Checked = True Then
                MsgBox("Either delivery or pick-up") 'cannot check both checkboxes at the same time
                price = 0
            Else
                price += 5 'extra cost for delivery
            End If
        Else
            If chkPick.Checked = False Then
                MsgBox("Either delivery or pick-up") 'cannot choose nothing
                price = 0
            End If
        End If
        If price > 0 Then
            txtTotal.Text = FormatCurrency(price, 2) 'display the total cost
        Else
            txtTotal.Text = "Invalid Input"
        End If
    End Sub

    'clear all assigned values on the interface
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbStyle.SelectedItem = Nothing
        rbtnExLrg.Checked = False
        rbtnLrg.Checked = False
        rbtnMed.Checked = False
        rbtnSmall.Checked = False
        nudQuantity.Value = 1
        chkDelivery.Checked = False
        chkPick.Checked = False
        txtTotal.ResetText()
        price = 0
    End Sub

    'close the whole program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
