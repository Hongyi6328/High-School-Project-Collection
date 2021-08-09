'Filename:  formEntry.vb
'Purpose:   Give access to other form if username and password are correct. User authentication.
'Author:    Felix Huang
'Started on Aug 9, 2020

Public Class formEntry

    'The correct ratio of encrypted username and password
    Friend realRatio As Double

    'Load all elements in the xml file
    Friend XElementList = XElement.Load("General Information.xml")

    'Method:    formEntry.Load
    'Input:     Xml file
    'Output:    Double floating point number
    'Purpose:   Load the correct ratio of username and password from the xml file
    Private Sub formEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each element As XElement In XElementList.elements
            If element.Name = "security" Then
                realRatio = Convert.ToDouble(element.Value) 'Ensures that the type is correct (double)
                Exit For 'If the element is mapped, there no need to waste time on finding that
            End If
        Next
    End Sub

    'Method:    btnEnter.Click
    'Input:     String, double floating point
    'Output:    Access to other forms
    'Purpose:   Encrypt username and password as a double floating-point number in which every 3 digits represent a character. 
    '           And compare it to the correct ratio
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        'Existence check. Validation
        If password = "" Or username = "" Then
            MsgBox("Please enter your username and password.")
            Exit Sub
        End If

        'Encryption, changing string to double and divide one by the other.
        Dim encryptedUsername As Double = encryption(username)
        Dim encryptedPassword As Double = encryption(password)
        Dim ratio As Double = encryptedUsername / encryptedPassword

        'Check if the ratio is correct
        If ratio.ToString = realRatio.ToString Then
            'Give access to other forms.
            formHome.Show()
            Hide()
        Else
            MsgBox("Incorrect pair of username and password. Please try again!")
        End If
    End Sub

    'Function:  Using ASCII codes, convert each character to a 3-digit integer and combine them
    'Input:     String
    'Output:    Double
    Friend Function encryption(str As String) As Double
        Dim number As Double = 0
        For i = 0 To str.Length - 1
            Dim temp As Integer = Asc(str(i))
            'The purpose of using "Try" statement:
            '   Some characters may not be in the ASCII table. This is a validation
            Try

                'If temp is out of range [0,255] then it means there is an illegal character
                If temp < 0 Or temp > 255 Then
                    Return -1
                    Exit Function
                End If
                number += temp * 10 ^ i
            Catch ex As Exception

                'If the character str(i) is not in the ASCII table, it means that it is definitely wrong
                'Return 0. Since realRatio cannot be negative, so ratio must not be equal to realRatio
                Return -1
                Exit Function
            End Try
        Next
        Return number
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
End Class
