'Filename:  formPassword.vb
'Purpose:   To change the username and password
'Author:    Felix Huang
'Started on Aug 9, 2020

Public Class formPassword

    'Inherit some variables from class formEntry
    Dim realRatio = formEntry.realRatio
    Dim XElementList = formEntry.XElementList

    'Navigation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        formHome.Show()
        Hide()
    End Sub

    'Method:    btnUpdate.Click
    'Input:     String
    'Output:    Double
    'Purpose:   Update the new ratio of encrypted username and password to the xml file
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim exitSub As Boolean = False

        'Validation: existence check
        If txtNewUsername.Text = "" Or txtOldPassword.Text = "" Or
txtNewPassword1.Text = "" Or txtNewPassword2.Text = "" Or txtOldUsername.Text = "" Then
            MsgBox("Please fill in all gaps.")
            exitSub = True
        End If

        'Validation: the 2 new passwords entered should be the same
        If txtNewPassword1.Text <> txtNewPassword2.Text Then
            MsgBox("Please confirm your new password")
            exitSub = True
        End If

        'Check if the old pair of username and password is correct
        Dim oldUsername As Double = formEntry.encryption(txtOldUsername.Text)
        Dim oldPassword As Double = formEntry.encryption(txtOldPassword.Text)
        If Not (oldUsername / oldPassword).ToString = realRatio.ToString Then
            MsgBox("Please enter the correct pair of the old username and the password.")
            exitSub = True
        End If

        'Check if the length of username and password is appropriate ([4,13] and [7,13]) 
        If txtNewUsername.Text.Length < 4 Or txtNewPassword1.Text.Length < 8 _
            Or txtNewUsername.Text.Length > 13 Or txtNewPassword1.Text.Length > 13 Then
            MsgBox("The length of your username should be between 4 and 13 characters, and the length of password should be between 7 and 13 characters")
            exitSub = True
        End If

        'Validation: Check if the new username and password contain illegal characters
        Dim newUsername As Double = formEntry.encryption(txtNewUsername.Text)
        Dim newPassword As Double = formEntry.encryption(txtNewPassword1.Text)
        If newPassword = -1 Or newUsername = -1 Then
            MsgBox("Your username and password should contain only Latin alphabets (lowercase and uppercase letters), numbers and basic symbols")
            exitSub = True
        End If

        'Rather than exiting the subroutine at once when a check is failed,
        'The program should tell all things that need to be fixed 
        'This will save the user's time because she doesn't have to try many times
        If exitSub Then
            Exit Sub
        End If

        'If passed the checks above, then update the xml file with the new pair of username and password
        realRatio = newUsername / newPassword
        For Each element As XElement In XElementList.elements
            If element.Name = "security" Then
                element.Value = realRatio
                Exit For 'If the element is mapped, there no need to waste time on finding that
            End If
        Next
        XElementList.save("General Information.xml")
        MsgBox("Updated successfully!")
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