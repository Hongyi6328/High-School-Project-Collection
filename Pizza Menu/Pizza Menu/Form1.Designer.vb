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
        Me.grpStyle = New System.Windows.Forms.GroupBox()
        Me.cmbStyle = New System.Windows.Forms.ComboBox()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.rbtnExLrg = New System.Windows.Forms.RadioButton()
        Me.rbtnLrg = New System.Windows.Forms.RadioButton()
        Me.rbtnMed = New System.Windows.Forms.RadioButton()
        Me.rbtnSmall = New System.Windows.Forms.RadioButton()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.chkPick = New System.Windows.Forms.CheckBox()
        Me.BtnCal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.grpStyle.SuspendLayout()
        Me.grpSize.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpStyle
        '
        Me.grpStyle.Controls.Add(Me.cmbStyle)
        Me.grpStyle.Location = New System.Drawing.Point(12, 12)
        Me.grpStyle.Name = "grpStyle"
        Me.grpStyle.Size = New System.Drawing.Size(329, 142)
        Me.grpStyle.TabIndex = 0
        Me.grpStyle.TabStop = False
        Me.grpStyle.Text = "Style"
        '
        'cmbStyle
        '
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.Items.AddRange(New Object() {"Hawaiian $ 10", "Capricciosa $ 7", "Meat Lover $ 12", "Aussie $ 14", "Margarita $ 8", "Supreme $ 9"})
        Me.cmbStyle.Location = New System.Drawing.Point(0, 67)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(329, 54)
        Me.cmbStyle.TabIndex = 0
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.rbtnExLrg)
        Me.grpSize.Controls.Add(Me.rbtnLrg)
        Me.grpSize.Controls.Add(Me.rbtnMed)
        Me.grpSize.Controls.Add(Me.rbtnSmall)
        Me.grpSize.Location = New System.Drawing.Point(335, 12)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(329, 343)
        Me.grpSize.TabIndex = 1
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Size"
        '
        'rbtnExLrg
        '
        Me.rbtnExLrg.AutoSize = True
        Me.rbtnExLrg.Location = New System.Drawing.Point(12, 236)
        Me.rbtnExLrg.Name = "rbtnExLrg"
        Me.rbtnExLrg.Size = New System.Drawing.Size(299, 50)
        Me.rbtnExLrg.TabIndex = 4
        Me.rbtnExLrg.TabStop = True
        Me.rbtnExLrg.Text = "Extra Large *2"
        Me.rbtnExLrg.UseVisualStyleBackColor = True
        '
        'rbtnLrg
        '
        Me.rbtnLrg.AutoSize = True
        Me.rbtnLrg.Location = New System.Drawing.Point(12, 180)
        Me.rbtnLrg.Name = "rbtnLrg"
        Me.rbtnLrg.Size = New System.Drawing.Size(227, 50)
        Me.rbtnLrg.TabIndex = 3
        Me.rbtnLrg.TabStop = True
        Me.rbtnLrg.Text = "Large *1.5"
        Me.rbtnLrg.UseVisualStyleBackColor = True
        '
        'rbtnMed
        '
        Me.rbtnMed.AutoSize = True
        Me.rbtnMed.Location = New System.Drawing.Point(12, 124)
        Me.rbtnMed.Name = "rbtnMed"
        Me.rbtnMed.Size = New System.Drawing.Size(234, 50)
        Me.rbtnMed.TabIndex = 2
        Me.rbtnMed.TabStop = True
        Me.rbtnMed.Text = "Medium *1"
        Me.rbtnMed.UseVisualStyleBackColor = True
        '
        'rbtnSmall
        '
        Me.rbtnSmall.AutoSize = True
        Me.rbtnSmall.Location = New System.Drawing.Point(12, 68)
        Me.rbtnSmall.Name = "rbtnSmall"
        Me.rbtnSmall.Size = New System.Drawing.Size(237, 50)
        Me.rbtnSmall.TabIndex = 1
        Me.rbtnSmall.TabStop = True
        Me.rbtnSmall.Text = "Small *0.8 "
        Me.rbtnSmall.UseVisualStyleBackColor = True
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(746, 67)
        Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(120, 53)
        Me.nudQuantity.TabIndex = 0
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(726, 9)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(168, 46)
        Me.lblQuantity.TabIndex = 5
        Me.lblQuantity.Text = "Quantity"
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(675, 125)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(244, 50)
        Me.chkDelivery.TabIndex = 6
        Me.chkDelivery.Text = "Delivery $5"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'chkPick
        '
        Me.chkPick.AutoSize = True
        Me.chkPick.Location = New System.Drawing.Point(675, 182)
        Me.chkPick.Name = "chkPick"
        Me.chkPick.Size = New System.Drawing.Size(235, 50)
        Me.chkPick.TabIndex = 7
        Me.chkPick.Text = "Pick-up $0"
        Me.chkPick.UseVisualStyleBackColor = True
        '
        'BtnCal
        '
        Me.BtnCal.Location = New System.Drawing.Point(4, 361)
        Me.BtnCal.Name = "BtnCal"
        Me.BtnCal.Size = New System.Drawing.Size(318, 71)
        Me.BtnCal.TabIndex = 8
        Me.BtnCal.Text = "Calculate Total Cost"
        Me.BtnCal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(712, 361)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 71)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(844, 361)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 71)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(328, 370)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(262, 53)
        Me.txtTotal.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(23.0!, 46.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 463)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.BtnCal)
        Me.Controls.Add(Me.chkPick)
        Me.Controls.Add(Me.chkDelivery)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.grpStyle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "Form1"
        Me.Text = "Choose your Pizza"
        Me.grpStyle.ResumeLayout(False)
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpStyle As System.Windows.Forms.GroupBox
    Friend WithEvents grpSize As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStyle As System.Windows.Forms.ComboBox
    Friend WithEvents rbtnExLrg As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnLrg As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMed As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSmall As System.Windows.Forms.RadioButton
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents chkDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents chkPick As System.Windows.Forms.CheckBox
    Friend WithEvents BtnCal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox

End Class
