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
        Me.components = New System.ComponentModel.Container()
        Me.BM1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TTime = New System.Windows.Forms.TextBox()
        Me.TTimes = New System.Windows.Forms.TextBox()
        Me.BStop = New System.Windows.Forms.Button()
        Me.BReset = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BM2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BM1
        '
        Me.BM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BM1.Location = New System.Drawing.Point(31, 30)
        Me.BM1.Name = "BM1"
        Me.BM1.Size = New System.Drawing.Size(193, 107)
        Me.BM1.TabIndex = 0
        Me.BM1.Text = "Method fractions"
        Me.BM1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.Location = New System.Drawing.Point(31, 214)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(812, 170)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(23, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 46)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(394, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 46)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Times"
        '
        'TTime
        '
        Me.TTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TTime.Location = New System.Drawing.Point(123, 407)
        Me.TTime.Multiline = True
        Me.TTime.Name = "TTime"
        Me.TTime.ReadOnly = True
        Me.TTime.Size = New System.Drawing.Size(275, 69)
        Me.TTime.TabIndex = 5
        '
        'TTimes
        '
        Me.TTimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TTimes.Location = New System.Drawing.Point(528, 407)
        Me.TTimes.Multiline = True
        Me.TTimes.Name = "TTimes"
        Me.TTimes.ReadOnly = True
        Me.TTimes.Size = New System.Drawing.Size(233, 69)
        Me.TTimes.TabIndex = 6
        '
        'BStop
        '
        Me.BStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BStop.Location = New System.Drawing.Point(36, 494)
        Me.BStop.Name = "BStop"
        Me.BStop.Size = New System.Drawing.Size(154, 59)
        Me.BStop.TabIndex = 7
        Me.BStop.Text = "Stop"
        Me.BStop.UseVisualStyleBackColor = True
        '
        'BReset
        '
        Me.BReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BReset.Location = New System.Drawing.Point(228, 494)
        Me.BReset.Name = "BReset"
        Me.BReset.Size = New System.Drawing.Size(154, 59)
        Me.BReset.TabIndex = 8
        Me.BReset.Text = "Reset"
        Me.BReset.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'BM2
        '
        Me.BM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BM2.Location = New System.Drawing.Point(230, 30)
        Me.BM2.Name = "BM2"
        Me.BM2.Size = New System.Drawing.Size(263, 107)
        Me.BM2.TabIndex = 9
        Me.BM2.Text = "Method trigonometry"
        Me.BM2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 669)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BM1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TTime As TextBox
    Friend WithEvents TTimes As TextBox
    Friend WithEvents BStop As Button
    Friend WithEvents BReset As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BM2 As Button
End Class
