<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnFibonacci = New System.Windows.Forms.Button()
        Me.btnSineRule = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.btnSequences = New System.Windows.Forms.Button()
        Me.btn6174 = New System.Windows.Forms.Button()
        Me.btnPrimeNum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFibonacci
        '
        Me.btnFibonacci.Location = New System.Drawing.Point(12, 12)
        Me.btnFibonacci.Name = "btnFibonacci"
        Me.btnFibonacci.Size = New System.Drawing.Size(246, 116)
        Me.btnFibonacci.TabIndex = 0
        Me.btnFibonacci.Text = "First n terms of the Fibonacci"
        Me.btnFibonacci.UseVisualStyleBackColor = True
        '
        'btnSineRule
        '
        Me.btnSineRule.Location = New System.Drawing.Point(12, 134)
        Me.btnSineRule.Name = "btnSineRule"
        Me.btnSineRule.Size = New System.Drawing.Size(246, 116)
        Me.btnSineRule.TabIndex = 1
        Me.btnSineRule.Text = "Sine Rule"
        Me.btnSineRule.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        Me.btnPi.Location = New System.Drawing.Point(12, 256)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(246, 116)
        Me.btnPi.TabIndex = 2
        Me.btnPi.Text = "Pi"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'btnSequences
        '
        Me.btnSequences.Location = New System.Drawing.Point(12, 378)
        Me.btnSequences.Name = "btnSequences"
        Me.btnSequences.Size = New System.Drawing.Size(246, 116)
        Me.btnSequences.TabIndex = 3
        Me.btnSequences.Text = "Sequences & series"
        Me.btnSequences.UseVisualStyleBackColor = True
        '
        'btn6174
        '
        Me.btn6174.Location = New System.Drawing.Point(12, 500)
        Me.btn6174.Name = "btn6174"
        Me.btn6174.Size = New System.Drawing.Size(246, 116)
        Me.btn6174.TabIndex = 4
        Me.btn6174.Text = "6174 Number Black Holes"
        Me.btn6174.UseVisualStyleBackColor = True
        '
        'btnPrimeNum
        '
        Me.btnPrimeNum.Location = New System.Drawing.Point(264, 12)
        Me.btnPrimeNum.Name = "btnPrimeNum"
        Me.btnPrimeNum.Size = New System.Drawing.Size(246, 116)
        Me.btnPrimeNum.TabIndex = 5
        Me.btnPrimeNum.Text = "Prime Number"
        Me.btnPrimeNum.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 680)
        Me.Controls.Add(Me.btnPrimeNum)
        Me.Controls.Add(Me.btn6174)
        Me.Controls.Add(Me.btnSequences)
        Me.Controls.Add(Me.btnPi)
        Me.Controls.Add(Me.btnSineRule)
        Me.Controls.Add(Me.btnFibonacci)
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFibonacci As Button
    Friend WithEvents btnSineRule As Button
    Friend WithEvents btnPi As Button
    Friend WithEvents btnSequences As Button
    Friend WithEvents btn6174 As Button
    Friend WithEvents btnPrimeNum As Button
End Class
