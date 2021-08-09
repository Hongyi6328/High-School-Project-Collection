<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblWallHeight = New System.Windows.Forms.Label()
        Me.lblWallWidth = New System.Windows.Forms.Label()
        Me.lblWalls = New System.Windows.Forms.Label()
        Me.lblDesiredStyle = New System.Windows.Forms.Label()
        Me.lblWindows = New System.Windows.Forms.Label()
        Me.lblWindowHeight = New System.Windows.Forms.Label()
        Me.lblWindowWidth = New System.Windows.Forms.Label()
        Me.cbxWindows = New System.Windows.Forms.CheckBox()
        Me.cbxRemoving = New System.Windows.Forms.CheckBox()
        Me.cbxRecommanded = New System.Windows.Forms.CheckBox()
        Me.cbbStyles = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtWallHeight = New System.Windows.Forms.TextBox()
        Me.txtWalls = New System.Windows.Forms.TextBox()
        Me.txtWindowHeight = New System.Windows.Forms.TextBox()
        Me.txtWallWidth = New System.Windows.Forms.TextBox()
        Me.txtWindowWidth = New System.Windows.Forms.TextBox()
        Me.txtWindows = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(11, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(192, 40)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Your name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(12, 126)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(253, 40)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(12, 74)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(149, 40)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address"
        '
        'lblWallHeight
        '
        Me.lblWallHeight.AutoSize = True
        Me.lblWallHeight.Location = New System.Drawing.Point(12, 202)
        Me.lblWallHeight.Name = "lblWallHeight"
        Me.lblWallHeight.Size = New System.Drawing.Size(297, 40)
        Me.lblWallHeight.TabIndex = 4
        Me.lblWallHeight.Text = "Your wall's height"
        '
        'lblWallWidth
        '
        Me.lblWallWidth.AutoSize = True
        Me.lblWallWidth.Location = New System.Drawing.Point(12, 253)
        Me.lblWallWidth.Name = "lblWallWidth"
        Me.lblWallWidth.Size = New System.Drawing.Size(283, 40)
        Me.lblWallWidth.TabIndex = 5
        Me.lblWallWidth.Text = "Your wall's width"
        '
        'lblWalls
        '
        Me.lblWalls.AutoSize = True
        Me.lblWalls.Location = New System.Drawing.Point(12, 307)
        Me.lblWalls.Name = "lblWalls"
        Me.lblWalls.Size = New System.Drawing.Size(297, 40)
        Me.lblWalls.TabIndex = 6
        Me.lblWalls.Text = "How many walls?"
        '
        'lblDesiredStyle
        '
        Me.lblDesiredStyle.AutoSize = True
        Me.lblDesiredStyle.Location = New System.Drawing.Point(451, 9)
        Me.lblDesiredStyle.Name = "lblDesiredStyle"
        Me.lblDesiredStyle.Size = New System.Drawing.Size(225, 40)
        Me.lblDesiredStyle.TabIndex = 7
        Me.lblDesiredStyle.Text = "Desired style"
        '
        'lblWindows
        '
        Me.lblWindows.AutoSize = True
        Me.lblWindows.Location = New System.Drawing.Point(12, 527)
        Me.lblWindows.Name = "lblWindows"
        Me.lblWindows.Size = New System.Drawing.Size(355, 40)
        Me.lblWindows.TabIndex = 8
        Me.lblWindows.Text = "How many windows?"
        '
        'lblWindowHeight
        '
        Me.lblWindowHeight.AutoSize = True
        Me.lblWindowHeight.Location = New System.Drawing.Point(11, 427)
        Me.lblWindowHeight.Name = "lblWindowHeight"
        Me.lblWindowHeight.Size = New System.Drawing.Size(355, 40)
        Me.lblWindowHeight.TabIndex = 9
        Me.lblWindowHeight.Text = "Your window's height"
        '
        'lblWindowWidth
        '
        Me.lblWindowWidth.AutoSize = True
        Me.lblWindowWidth.Location = New System.Drawing.Point(12, 476)
        Me.lblWindowWidth.Name = "lblWindowWidth"
        Me.lblWindowWidth.Size = New System.Drawing.Size(341, 40)
        Me.lblWindowWidth.TabIndex = 10
        Me.lblWindowWidth.Text = "Your window's width"
        '
        'cbxWindows
        '
        Me.cbxWindows.AutoSize = True
        Me.cbxWindows.Location = New System.Drawing.Point(18, 369)
        Me.cbxWindows.Name = "cbxWindows"
        Me.cbxWindows.Size = New System.Drawing.Size(529, 44)
        Me.cbxWindows.TabIndex = 11
        Me.cbxWindows.Text = "There are windows on the wall"
        Me.cbxWindows.UseVisualStyleBackColor = True
        '
        'cbxRemoving
        '
        Me.cbxRemoving.AutoSize = True
        Me.cbxRemoving.Location = New System.Drawing.Point(458, 85)
        Me.cbxRemoving.Name = "cbxRemoving"
        Me.cbxRemoving.Size = New System.Drawing.Size(491, 44)
        Me.cbxRemoving.TabIndex = 12
        Me.cbxRemoving.Text = "Need to remove the existing"
        Me.cbxRemoving.UseVisualStyleBackColor = True
        '
        'cbxRecommanded
        '
        Me.cbxRecommanded.AutoSize = True
        Me.cbxRecommanded.Location = New System.Drawing.Point(458, 135)
        Me.cbxRecommanded.Name = "cbxRecommanded"
        Me.cbxRecommanded.Size = New System.Drawing.Size(287, 44)
        Me.cbxRecommanded.TabIndex = 13
        Me.cbxRecommanded.Text = "Recommanded"
        Me.cbxRecommanded.UseVisualStyleBackColor = True
        '
        'cbbStyles
        '
        Me.cbbStyles.FormattingEnabled = True
        Me.cbbStyles.Items.AddRange(New Object() {"Driftwood", "Mojave", "Jungle Friends", "Trieste Swirl Pattern", "Flamingo"})
        Me.cbbStyles.Location = New System.Drawing.Point(693, 6)
        Me.cbbStyles.Name = "cbbStyles"
        Me.cbbStyles.Size = New System.Drawing.Size(256, 48)
        Me.cbbStyles.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(209, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(236, 48)
        Me.txtName.TabIndex = 15
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(209, 66)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(236, 48)
        Me.txtAddress.TabIndex = 16
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(271, 120)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(174, 48)
        Me.txtPhoneNumber.TabIndex = 17
        '
        'txtWallHeight
        '
        Me.txtWallHeight.Location = New System.Drawing.Point(315, 199)
        Me.txtWallHeight.Name = "txtWallHeight"
        Me.txtWallHeight.Size = New System.Drawing.Size(236, 48)
        Me.txtWallHeight.TabIndex = 18
        '
        'txtWalls
        '
        Me.txtWalls.Location = New System.Drawing.Point(315, 304)
        Me.txtWalls.Name = "txtWalls"
        Me.txtWalls.Size = New System.Drawing.Size(236, 48)
        Me.txtWalls.TabIndex = 19
        '
        'txtWindowHeight
        '
        Me.txtWindowHeight.Location = New System.Drawing.Point(372, 419)
        Me.txtWindowHeight.Name = "txtWindowHeight"
        Me.txtWindowHeight.Size = New System.Drawing.Size(236, 48)
        Me.txtWindowHeight.TabIndex = 20
        '
        'txtWallWidth
        '
        Me.txtWallWidth.Location = New System.Drawing.Point(315, 250)
        Me.txtWallWidth.Name = "txtWallWidth"
        Me.txtWallWidth.Size = New System.Drawing.Size(236, 48)
        Me.txtWallWidth.TabIndex = 21
        '
        'txtWindowWidth
        '
        Me.txtWindowWidth.Location = New System.Drawing.Point(372, 473)
        Me.txtWindowWidth.Name = "txtWindowWidth"
        Me.txtWindowWidth.Size = New System.Drawing.Size(236, 48)
        Me.txtWindowWidth.TabIndex = 22
        '
        'txtWindows
        '
        Me.txtWindows.Location = New System.Drawing.Point(372, 527)
        Me.txtWindows.Name = "txtWindows"
        Me.txtWindows.Size = New System.Drawing.Size(236, 48)
        Me.txtWindows.TabIndex = 23
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(567, 211)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(178, 65)
        Me.btnCalculate.TabIndex = 24
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(751, 211)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(159, 65)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(751, 282)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 65)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(645, 369)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(313, 206)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(21.0!, 40.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 576)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtWindows)
        Me.Controls.Add(Me.txtWindowWidth)
        Me.Controls.Add(Me.txtWallWidth)
        Me.Controls.Add(Me.txtWindowHeight)
        Me.Controls.Add(Me.txtWalls)
        Me.Controls.Add(Me.txtWallHeight)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cbbStyles)
        Me.Controls.Add(Me.cbxRecommanded)
        Me.Controls.Add(Me.cbxRemoving)
        Me.Controls.Add(Me.cbxWindows)
        Me.Controls.Add(Me.lblWindowWidth)
        Me.Controls.Add(Me.lblWindowHeight)
        Me.Controls.Add(Me.lblWindows)
        Me.Controls.Add(Me.lblDesiredStyle)
        Me.Controls.Add(Me.lblWalls)
        Me.Controls.Add(Me.lblWallWidth)
        Me.Controls.Add(Me.lblWallHeight)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblWallHeight As System.Windows.Forms.Label
    Friend WithEvents lblWallWidth As System.Windows.Forms.Label
    Friend WithEvents lblWalls As System.Windows.Forms.Label
    Friend WithEvents lblDesiredStyle As System.Windows.Forms.Label
    Friend WithEvents lblWindows As System.Windows.Forms.Label
    Friend WithEvents lblWindowHeight As System.Windows.Forms.Label
    Friend WithEvents lblWindowWidth As System.Windows.Forms.Label
    Friend WithEvents cbxWindows As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRemoving As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRecommanded As System.Windows.Forms.CheckBox
    Friend WithEvents cbbStyles As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtWallHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWalls As System.Windows.Forms.TextBox
    Friend WithEvents txtWindowHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWallWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtWindowWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtWindows As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
