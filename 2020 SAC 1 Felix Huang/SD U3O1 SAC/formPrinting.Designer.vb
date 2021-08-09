<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrinting
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudCopies = New System.Windows.Forms.NumericUpDown()
        Me.nudSides = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radA3 = New System.Windows.Forms.RadioButton()
        Me.radA4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radBinding = New System.Windows.Forms.RadioButton()
        Me.rad2Staple = New System.Windows.Forms.RadioButton()
        Me.rad1Staple = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalPages = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFinalCost = New System.Windows.Forms.Label()
        Me.lblFinishingCost = New System.Windows.Forms.Label()
        Me.lblPrintCost = New System.Windows.Forms.Label()
        Me.lblImpCost = New System.Windows.Forms.Label()
        Me.lblTotalImp = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.chkDoubleSided = New System.Windows.Forms.CheckBox()
        Me.chkColour = New System.Windows.Forms.CheckBox()
        Me.cmbDepartments = New System.Windows.Forms.ComboBox()
        Me.lblDepartmentValue = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblBalanceValue = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnDepartments = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSides, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(822, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zippy Printing Services"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 243)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Original Sides:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Copies:"
        '
        'nudCopies
        '
        Me.nudCopies.Location = New System.Drawing.Point(288, 205)
        Me.nudCopies.Margin = New System.Windows.Forms.Padding(4)
        Me.nudCopies.Name = "nudCopies"
        Me.nudCopies.Size = New System.Drawing.Size(98, 28)
        Me.nudCopies.TabIndex = 3
        '
        'nudSides
        '
        Me.nudSides.Location = New System.Drawing.Point(288, 241)
        Me.nudSides.Margin = New System.Windows.Forms.Padding(4)
        Me.nudSides.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudSides.Name = "nudSides"
        Me.nudSides.Size = New System.Drawing.Size(98, 28)
        Me.nudSides.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radA3)
        Me.GroupBox1.Controls.Add(Me.radA4)
        Me.GroupBox1.Location = New System.Drawing.Point(142, 313)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(129, 159)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paper Size"
        '
        'radA3
        '
        Me.radA3.AutoSize = True
        Me.radA3.Location = New System.Drawing.Point(18, 90)
        Me.radA3.Margin = New System.Windows.Forms.Padding(4)
        Me.radA3.Name = "radA3"
        Me.radA3.Size = New System.Drawing.Size(51, 22)
        Me.radA3.TabIndex = 1
        Me.radA3.Text = "A3"
        Me.radA3.UseVisualStyleBackColor = True
        '
        'radA4
        '
        Me.radA4.AutoSize = True
        Me.radA4.Checked = True
        Me.radA4.Location = New System.Drawing.Point(18, 44)
        Me.radA4.Margin = New System.Windows.Forms.Padding(4)
        Me.radA4.Name = "radA4"
        Me.radA4.Size = New System.Drawing.Size(51, 22)
        Me.radA4.TabIndex = 0
        Me.radA4.TabStop = True
        Me.radA4.Text = "A4"
        Me.radA4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radBinding)
        Me.GroupBox2.Controls.Add(Me.rad2Staple)
        Me.GroupBox2.Controls.Add(Me.rad1Staple)
        Me.GroupBox2.Controls.Add(Me.radNone)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 313)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(154, 159)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Finishing"
        '
        'radBinding
        '
        Me.radBinding.AutoSize = True
        Me.radBinding.Location = New System.Drawing.Point(18, 122)
        Me.radBinding.Margin = New System.Windows.Forms.Padding(4)
        Me.radBinding.Name = "radBinding"
        Me.radBinding.Size = New System.Drawing.Size(96, 22)
        Me.radBinding.TabIndex = 3
        Me.radBinding.Text = "Binding"
        Me.radBinding.UseVisualStyleBackColor = True
        '
        'rad2Staple
        '
        Me.rad2Staple.AutoSize = True
        Me.rad2Staple.Location = New System.Drawing.Point(18, 90)
        Me.rad2Staple.Margin = New System.Windows.Forms.Padding(4)
        Me.rad2Staple.Name = "rad2Staple"
        Me.rad2Staple.Size = New System.Drawing.Size(105, 22)
        Me.rad2Staple.TabIndex = 2
        Me.rad2Staple.Text = "2 Staple"
        Me.rad2Staple.UseVisualStyleBackColor = True
        '
        'rad1Staple
        '
        Me.rad1Staple.AutoSize = True
        Me.rad1Staple.Location = New System.Drawing.Point(18, 58)
        Me.rad1Staple.Margin = New System.Windows.Forms.Padding(4)
        Me.rad1Staple.Name = "rad1Staple"
        Me.rad1Staple.Size = New System.Drawing.Size(105, 22)
        Me.rad1Staple.TabIndex = 1
        Me.rad1Staple.Text = "1 Staple"
        Me.rad1Staple.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Checked = True
        Me.radNone.Location = New System.Drawing.Point(18, 26)
        Me.radNone.Margin = New System.Windows.Forms.Padding(4)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(69, 22)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalPages)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblFinalCost)
        Me.GroupBox3.Controls.Add(Me.lblFinishingCost)
        Me.GroupBox3.Controls.Add(Me.lblPrintCost)
        Me.GroupBox3.Controls.Add(Me.lblImpCost)
        Me.GroupBox3.Controls.Add(Me.lblTotalImp)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(493, 223)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(352, 249)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totals"
        '
        'lblTotalPages
        '
        Me.lblTotalPages.Location = New System.Drawing.Point(262, 104)
        Me.lblTotalPages.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPages.Name = "lblTotalPages"
        Me.lblTotalPages.Size = New System.Drawing.Size(68, 18)
        Me.lblTotalPages.TabIndex = 11
        Me.lblTotalPages.Text = "0"
        Me.lblTotalPages.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 104)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Total Pages:"
        '
        'lblFinalCost
        '
        Me.lblFinalCost.Location = New System.Drawing.Point(262, 212)
        Me.lblFinalCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinalCost.Name = "lblFinalCost"
        Me.lblFinalCost.Size = New System.Drawing.Size(68, 18)
        Me.lblFinalCost.TabIndex = 9
        Me.lblFinalCost.Text = "$0.00"
        Me.lblFinalCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFinishingCost
        '
        Me.lblFinishingCost.Location = New System.Drawing.Point(262, 165)
        Me.lblFinishingCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinishingCost.Name = "lblFinishingCost"
        Me.lblFinishingCost.Size = New System.Drawing.Size(68, 18)
        Me.lblFinishingCost.TabIndex = 8
        Me.lblFinishingCost.Text = "$0.00"
        Me.lblFinishingCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPrintCost
        '
        Me.lblPrintCost.Location = New System.Drawing.Point(262, 134)
        Me.lblPrintCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrintCost.Name = "lblPrintCost"
        Me.lblPrintCost.Size = New System.Drawing.Size(68, 18)
        Me.lblPrintCost.TabIndex = 7
        Me.lblPrintCost.Text = "$0.00"
        Me.lblPrintCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblImpCost
        '
        Me.lblImpCost.Location = New System.Drawing.Point(262, 60)
        Me.lblImpCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblImpCost.Name = "lblImpCost"
        Me.lblImpCost.Size = New System.Drawing.Size(68, 18)
        Me.lblImpCost.TabIndex = 6
        Me.lblImpCost.Text = "$0.00"
        Me.lblImpCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalImp
        '
        Me.lblTotalImp.Location = New System.Drawing.Point(272, 29)
        Me.lblTotalImp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalImp.Name = "lblTotalImp"
        Me.lblTotalImp.Size = New System.Drawing.Size(58, 18)
        Me.lblTotalImp.TabIndex = 5
        Me.lblTotalImp.Text = "0"
        Me.lblTotalImp.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 212)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Final Cost:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Finishing Cost per Copy:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 134)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total Printing Cost:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Printing Cost per Impression:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Impressions:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(128, 562)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(165, 32)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'chkDoubleSided
        '
        Me.chkDoubleSided.AutoSize = True
        Me.chkDoubleSided.Location = New System.Drawing.Point(150, 281)
        Me.chkDoubleSided.Margin = New System.Windows.Forms.Padding(4)
        Me.chkDoubleSided.Name = "chkDoubleSided"
        Me.chkDoubleSided.Size = New System.Drawing.Size(142, 22)
        Me.chkDoubleSided.TabIndex = 7
        Me.chkDoubleSided.Text = "Double-Sided"
        Me.chkDoubleSided.UseVisualStyleBackColor = True
        '
        'chkColour
        '
        Me.chkColour.AutoSize = True
        Me.chkColour.Location = New System.Drawing.Point(306, 281)
        Me.chkColour.Margin = New System.Windows.Forms.Padding(4)
        Me.chkColour.Name = "chkColour"
        Me.chkColour.Size = New System.Drawing.Size(88, 22)
        Me.chkColour.TabIndex = 8
        Me.chkColour.Text = "Colour"
        Me.chkColour.UseVisualStyleBackColor = True
        '
        'cmbDepartments
        '
        Me.cmbDepartments.FormattingEnabled = True
        Me.cmbDepartments.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbDepartments.Location = New System.Drawing.Point(141, 491)
        Me.cmbDepartments.Name = "cmbDepartments"
        Me.cmbDepartments.Size = New System.Drawing.Size(301, 26)
        Me.cmbDepartments.TabIndex = 9
        Me.cmbDepartments.Text = "Choose Department"
        '
        'lblDepartmentValue
        '
        Me.lblDepartmentValue.Location = New System.Drawing.Point(623, 491)
        Me.lblDepartmentValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartmentValue.Name = "lblDepartmentValue"
        Me.lblDepartmentValue.Size = New System.Drawing.Size(175, 18)
        Me.lblDepartmentValue.TabIndex = 13
        Me.lblDepartmentValue.Text = "0"
        Me.lblDepartmentValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(490, 491)
        Me.lblDepartment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(98, 18)
        Me.lblDepartment.TabIndex = 12
        Me.lblDepartment.Text = "Department"
        '
        'lblBalanceValue
        '
        Me.lblBalanceValue.Location = New System.Drawing.Point(626, 520)
        Me.lblBalanceValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalanceValue.Name = "lblBalanceValue"
        Me.lblBalanceValue.Size = New System.Drawing.Size(172, 18)
        Me.lblBalanceValue.TabIndex = 15
        Me.lblBalanceValue.Text = "0"
        Me.lblBalanceValue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(490, 520)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(71, 18)
        Me.lblBalance.TabIndex = 14
        Me.lblBalance.Text = "Balance"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(521, 562)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(165, 32)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit Job"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnDepartments
        '
        Me.btnDepartments.Location = New System.Drawing.Point(597, 90)
        Me.btnDepartments.Name = "btnDepartments"
        Me.btnDepartments.Size = New System.Drawing.Size(143, 57)
        Me.btnDepartments.TabIndex = 20
        Me.btnDepartments.Text = "Departments"
        Me.btnDepartments.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(410, 90)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(143, 57)
        Me.btnHistory.TabIndex = 19
        Me.btnHistory.Text = "View History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(232, 90)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(143, 57)
        Me.btnHome.TabIndex = 18
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'formPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 607)
        Me.Controls.Add(Me.btnDepartments)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblBalanceValue)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblDepartmentValue)
        Me.Controls.Add(Me.cmbDepartments)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.chkColour)
        Me.Controls.Add(Me.chkDoubleSided)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nudSides)
        Me.Controls.Add(Me.nudCopies)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formPrinting"
        Me.Text = "Calculation & xml"
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSides, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudCopies As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSides As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radA3 As System.Windows.Forms.RadioButton
    Friend WithEvents radA4 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radBinding As System.Windows.Forms.RadioButton
    Friend WithEvents rad2Staple As System.Windows.Forms.RadioButton
    Friend WithEvents rad1Staple As System.Windows.Forms.RadioButton
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFinalCost As System.Windows.Forms.Label
    Friend WithEvents lblFinishingCost As System.Windows.Forms.Label
    Friend WithEvents lblPrintCost As System.Windows.Forms.Label
    Friend WithEvents lblImpCost As System.Windows.Forms.Label
    Friend WithEvents lblTotalImp As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents chkDoubleSided As System.Windows.Forms.CheckBox
    Friend WithEvents chkColour As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotalPages As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbDepartments As ComboBox
    Friend WithEvents lblDepartmentValue As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblBalanceValue As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnDepartments As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnHome As Button
End Class
