<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSineRule
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBangleC = New System.Windows.Forms.TextBox()
        Me.TBsideC = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Lambiguous = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBangleB = New System.Windows.Forms.TextBox()
        Me.TBsideB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBangleA = New System.Windows.Forms.TextBox()
        Me.TBsideA = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label6.Location = New System.Drawing.Point(469, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 42)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label5.Location = New System.Drawing.Point(469, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 42)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "sin"
        '
        'TBangleC
        '
        Me.TBangleC.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBangleC.Location = New System.Drawing.Point(556, 133)
        Me.TBangleC.Name = "TBangleC"
        Me.TBangleC.ReadOnly = True
        Me.TBangleC.Size = New System.Drawing.Size(163, 55)
        Me.TBangleC.TabIndex = 29
        '
        'TBsideC
        '
        Me.TBsideC.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBsideC.Location = New System.Drawing.Point(556, 72)
        Me.TBsideC.Name = "TBsideC"
        Me.TBsideC.ReadOnly = True
        Me.TBsideC.Size = New System.Drawing.Size(163, 55)
        Me.TBsideC.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 166)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(43, 41)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(274, 46)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Side length"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(43, 103)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(253, 46)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Sine theta"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Lambiguous
        '
        Me.Lambiguous.AutoSize = True
        Me.Lambiguous.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Lambiguous.Location = New System.Drawing.Point(40, 410)
        Me.Lambiguous.Name = "Lambiguous"
        Me.Lambiguous.Size = New System.Drawing.Size(354, 42)
        Me.Lambiguous.TabIndex = 26
        Me.Lambiguous.Text = "ambiguous or not"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Button1.Location = New System.Drawing.Point(402, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 71)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Get"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label4.Location = New System.Drawing.Point(112, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 42)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "known"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label3.Location = New System.Drawing.Point(225, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 42)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "sin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label2.Location = New System.Drawing.Point(225, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 42)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "="
        '
        'TBangleB
        '
        Me.TBangleB.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBangleB.Location = New System.Drawing.Point(312, 133)
        Me.TBangleB.Name = "TBangleB"
        Me.TBangleB.Size = New System.Drawing.Size(151, 55)
        Me.TBangleB.TabIndex = 21
        '
        'TBsideB
        '
        Me.TBsideB.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBsideB.Location = New System.Drawing.Point(312, 72)
        Me.TBsideB.Name = "TBsideB"
        Me.TBsideB.Size = New System.Drawing.Size(151, 55)
        Me.TBsideB.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 42)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "sin "
        '
        'TBangleA
        '
        Me.TBangleA.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBangleA.Location = New System.Drawing.Point(119, 133)
        Me.TBangleA.Name = "TBangleA"
        Me.TBangleA.Size = New System.Drawing.Size(100, 55)
        Me.TBangleA.TabIndex = 18
        '
        'TBsideA
        '
        Me.TBsideA.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBsideA.Location = New System.Drawing.Point(119, 72)
        Me.TBsideA.Name = "TBsideA"
        Me.TBsideA.Size = New System.Drawing.Size(100, 55)
        Me.TBsideA.TabIndex = 17
        '
        'FormSineRule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 472)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBangleC)
        Me.Controls.Add(Me.TBsideC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lambiguous)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBangleB)
        Me.Controls.Add(Me.TBsideB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBangleA)
        Me.Controls.Add(Me.TBsideA)
        Me.Name = "FormSineRule"
        Me.Text = "FormSineRule"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBangleC As TextBox
    Friend WithEvents TBsideC As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Lambiguous As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBangleB As TextBox
    Friend WithEvents TBsideB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBangleA As TextBox
    Friend WithEvents TBsideA As TextBox
End Class
