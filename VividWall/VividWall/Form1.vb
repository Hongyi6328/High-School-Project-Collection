'Programmer: Felix Huang
'Started on 20 Aug
'Finished on 21 Aug
'For Vivid Wall calculations
Public Class Form1

    'Define variables
    Public WindowHeight, WindowWidth, WallHeight, WallWidth, Prepping, GST, Discount, LabourCost, RemovingCost, _
    Windows, Walls, SinglePrice, Recommanded, PaperArea, Rolls, SingleArea, RollsCost, FinalCost As Single

    'Return the total area 
    Public Function EffectiveArea(WindowHeight, WindowWidth, WallHeight, WallWidth, Walls, Windows) As Single
        Return (WallHeight * WallWidth * Walls - WindowHeight * WindowWidth * Windows)
    End Function

    'Allocate single price and area depending on what user selects
    Private Sub cbbStyle_ItemSelectedChanged(e As Object, sender As EventArgs) _
        Handles cbbStyles.TextChanged
        Select Case cbbStyles.ValueMember
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
    End Sub

    'Call the main calculation module
    Public Sub btnCalculate_Click(e As Object, sender As EventArgs) Handles btnCalculate.Click
        'Validation
        If cbbStyles.Text = "Wallpaper Styles" Or IsNothing(txtAddress.Text) _
            Or (Not IsNumeric(txtPhoneNumber.Text)) Or IsNothing(txtName) Or (IsNumeric(txtName.Text)) Or _
           (Not IsNumeric(txtWallHeight.Text)) Or (Not IsNumeric(txtWallWidth.Text)) Or (Not IsNumeric(txtWalls.Text)) _
            Or (Not IsNumeric(txtWindowHeight.Text)) Or (Not IsNumeric(txtWindowWidth.Text)) Or _
           (Not IsNumeric(txtWindows.Text)) Or Val(txtWallHeight.Text) < 0 Or Val(txtWallWidth.Text) < 0 _
            Or Val(txtWalls.Text) < 0 Or Val(txtWindowHeight.Text) < 0 Or Val(txtWindowWidth.Text) < 0 _
            Or Val(txtWindows.Text) < 0 Then
            MsgBox("Please input valid entries")
            Stop
        Else
            'Switch to the other form
            Me.Hide()
            Form2.Show()
            If cbxWindows.Checked Then
                WindowHeight = Val(txtWindowHeight.Text)
                WindowWidth = Val(txtWindowWidth.Text)
            Else
                WindowHeight = 0
                WindowWidth = 0
            End If
            WallHeight = Val(txtWallHeight.Text)
            WallWidth = Val(txtWallWidth.Text)
        End If
    End Sub

    'An easy way to get Cost = Cost * Recommanded
    Private Sub cbxRecommanded_StatusChanged(e As Object, sender As EventArgs) _
        Handles cbxRecommanded.CheckedChanged
        Select Case cbxRecommanded.Checked
            Case True
                Recommanded = 1
            Case False
                Recommanded = 0.95
        End Select
    End Sub

    'Hide or show 3 textboxes as user wants
    Private Sub cbxWindows_StatusChanged(e As Object, sender As EventArgs) _
        Handles cbxWindows.CheckedChanged
        If cbxWindows.Checked Then
            txtWindowHeight.Show()
            txtWindowWidth.Show()
            txtWindows.Show()
            lblWindowHeight.Show()
            lblWindowWidth.Show()
            lblWindows.Show()
        Else
            txtWindowHeight.Hide()
            txtWindowWidth.Hide()
            txtWindows.Hide()
            lblWindowHeight.Hide()
            lblWindowWidth.Hide()
            lblWindows.Hide()
        End If
    End Sub

    'Clear all entries
    Private Sub btnClear_Click(e As Object, sender As EventArgs) _
        Handles btnClear.Click
        txtWindowHeight.ResetText()
        txtWindowWidth.ResetText()
        txtWallHeight.ResetText()
        txtWallWidth.ResetText()
        txtName.ResetText()
        txtAddress.ResetText()
        txtPhoneNumber.ResetText()
        txtWindows.ResetText()
        txtWalls.ResetText()
        cbbStyles.Text = "Wallpaper Styles"
        cbxWindows.Checked = False
        cbxRecommanded.Checked = False
        cbxRemoving.Checked = False
    End Sub

    'Quick way to end the program
    Private Sub btnExit_Click(e As Object, sender As EventArgs) _
        Handles btnExit.Click
        End
    End Sub

    'Initialize
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtWindowHeight.Hide()
        txtWindowWidth.Hide()
        txtWindows.Hide()
        lblWindowHeight.Hide()
        lblWindowWidth.Hide()
        lblWindows.Hide()
        cbbStyles.Text = "Wallpaper Styles"
        cbxWindows.Checked = False
        cbxRecommanded.Checked = False
        cbxRemoving.Checked = False
    End Sub
End Class
