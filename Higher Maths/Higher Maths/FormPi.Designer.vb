<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPi
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
        Me.components = New System.ComponentModel.Container()
        Me.BM2 = New System.Windows.Forms.Button()
        Me.BReset = New System.Windows.Forms.Button()
        Me.BStop = New System.Windows.Forms.Button()
        Me.TTimes = New System.Windows.Forms.TextBox()
        Me.TTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BM1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BM2
        '
        Me.BM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BM2.Location = New System.Drawing.Point(317, 96)
        Me.BM2.Name = "BM2"
        Me.BM2.Size = New System.Drawing.Size(263, 107)
        Me.BM2.TabIndex = 19
        Me.BM2.Text = "Method trigonometry"
        Me.BM2.UseVisualStyleBackColor = True
        '
        'BReset
        '
        Me.BReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BReset.Location = New System.Drawing.Point(315, 560)
        Me.BReset.Name = "BReset"
        Me.BReset.Size = New System.Drawing.Size(154, 59)
        Me.BReset.TabIndex = 18
        Me.BReset.Text = "Reset"
        Me.BReset.UseVisualStyleBackColor = True
        '
        'BStop
        '
        Me.BStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BStop.Location = New System.Drawing.Point(123, 560)
        Me.BStop.Name = "BStop"
        Me.BStop.Size = New System.Drawing.Size(154, 59)
        Me.BStop.TabIndex = 17
        Me.BStop.Text = "Stop"
        Me.BStop.UseVisualStyleBackColor = True
        '
        'TTimes
        '
        Me.TTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TTimes.Location = New System.Drawing.Point(615, 473)
        Me.TTimes.Multiline = True
        Me.TTimes.Name = "TTimes"
        Me.TTimes.ReadOnly = True
        Me.TTimes.Size = New System.Drawing.Size(233, 69)
        Me.TTimes.TabIndex = 16
        '
        'TTime
        '
        Me.TTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TTime.Location = New System.Drawing.Point(210, 473)
        Me.TTime.Multiline = True
        Me.TTime.Name = "TTime"
        Me.TTime.ReadOnly = True
        Me.TTime.Size = New System.Drawing.Size(275, 69)
        Me.TTime.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(481, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 46)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Times"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(110, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 46)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(115, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 46)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Result"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.Location = New System.Drawing.Point(118, 280)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(812, 170)
        Me.TextBox1.TabIndex = 11
        '
        'BM1
        '
        Me.BM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BM1.Location = New System.Drawing.Point(118, 96)
        Me.BM1.Name = "BM1"
        Me.BM1.Size = New System.Drawing.Size(193, 107)
        Me.BM1.TabIndex = 10
        Me.BM1.Text = "Method fractions"
        Me.BM1.UseVisualStyleBackColor = True
        '
        'FormPi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 715)
        Me.Controls.Add(Me.BM2)
        Me.Controls.Add(Me.BReset)
        Me.Controls.Add(Me.BStop)
        Me.Controls.Add(Me.TTimes)
        Me.Controls.Add(Me.TTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BM1)
        Me.Name = "FormPi"
        Me.Text = "FormPi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BM2 As Button
    Friend WithEvents BReset As Button
    Friend WithEvents BStop As Button
    Friend WithEvents TTimes As TextBox
    Friend WithEvents TTime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BM1 As Button
    Friend WithEvents Timer1 As Timer
End Class
