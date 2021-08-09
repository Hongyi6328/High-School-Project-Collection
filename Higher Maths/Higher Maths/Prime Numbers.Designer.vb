<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrimeNumbers
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
        Me.nudDomain = New System.Windows.Forms.NumericUpDown()
        Me.rbtnListPri = New System.Windows.Forms.RadioButton()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.rbtnListFac = New System.Windows.Forms.RadioButton()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        CType(Me.nudDomain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudDomain
        '
        Me.nudDomain.Location = New System.Drawing.Point(12, 577)
        Me.nudDomain.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nudDomain.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudDomain.Name = "nudDomain"
        Me.nudDomain.Size = New System.Drawing.Size(222, 28)
        Me.nudDomain.TabIndex = 1
        Me.nudDomain.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'rbtnListPri
        '
        Me.rbtnListPri.AutoSize = True
        Me.rbtnListPri.Checked = True
        Me.rbtnListPri.Location = New System.Drawing.Point(567, 577)
        Me.rbtnListPri.Name = "rbtnListPri"
        Me.rbtnListPri.Size = New System.Drawing.Size(456, 22)
        Me.rbtnListPri.TabIndex = 3
        Me.rbtnListPri.TabStop = True
        Me.rbtnListPri.Text = "List all prime numbers smaller than this number"
        Me.rbtnListPri.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(12, 611)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(222, 77)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'rbtnListFac
        '
        Me.rbtnListFac.AutoSize = True
        Me.rbtnListFac.Location = New System.Drawing.Point(258, 577)
        Me.rbtnListFac.Name = "rbtnListFac"
        Me.rbtnListFac.Size = New System.Drawing.Size(303, 22)
        Me.rbtnListFac.TabIndex = 5
        Me.rbtnListFac.Text = "List all factor of this number"
        Me.rbtnListFac.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(8, 8)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.txtOutput.Size = New System.Drawing.Size(1188, 553)
        Me.txtOutput.TabIndex = 6
        Me.txtOutput.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(1161, 553)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(8, 8)
        Me.RichTextBox2.TabIndex = 7
        Me.RichTextBox2.Text = ""
        '
        'FormPrimeNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 754)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.rbtnListFac)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.rbtnListPri)
        Me.Controls.Add(Me.nudDomain)
        Me.Name = "FormPrimeNumbers"
        Me.Text = "Prime Numbers"
        CType(Me.nudDomain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudDomain As NumericUpDown
    Friend WithEvents rbtnListPri As RadioButton
    Friend WithEvents btnRun As Button
    Friend WithEvents rbtnListFac As RadioButton
    Friend WithEvents txtOutput As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
