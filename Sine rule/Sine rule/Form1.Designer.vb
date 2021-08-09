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
        Me.TBsideA = New System.Windows.Forms.TextBox()
        Me.TBangleA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBangleB = New System.Windows.Forms.TextBox()
        Me.TBsideB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Lambiguous = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBangleC = New System.Windows.Forms.TextBox()
        Me.TBsideC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBsideA
        '
        Me.TBsideA.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBsideA.Location = New System.Drawing.Point(104, 84)
        Me.TBsideA.Name = "TBsideA"
        Me.TBsideA.Size = New System.Drawing.Size(100, 55)
        Me.TBsideA.TabIndex = 0
        '
        'TBangleA
        '
        Me.TBangleA.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBangleA.Location = New System.Drawing.Point(104, 145)
        Me.TBangleA.Name = "TBangleA"
        Me.TBangleA.Size = New System.Drawing.Size(100, 55)
        Me.TBangleA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label1.Location = New System.Drawing.Point(-4, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "sin "
        '
        'TBangleB
        '
        Me.TBangleB.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBangleB.Location = New System.Drawing.Point(297, 145)
        Me.TBangleB.Name = "TBangleB"
        Me.TBangleB.Size = New System.Drawing.Size(151, 55)
        Me.TBangleB.TabIndex = 4
        '
        'TBsideB
        '
        Me.TBsideB.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBsideB.Location = New System.Drawing.Point(297, 84)
        Me.TBsideB.Name = "TBsideB"
        Me.TBsideB.Size = New System.Drawing.Size(151, 55)
        Me.TBsideB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label2.Location = New System.Drawing.Point(210, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 42)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label3.Location = New System.Drawing.Point(210, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 42)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "sin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label4.Location = New System.Drawing.Point(97, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 42)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "known"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Button1.Location = New System.Drawing.Point(387, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 71)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Get"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.Lambiguous.Location = New System.Drawing.Point(25, 422)
        Me.Lambiguous.Name = "Lambiguous"
        Me.Lambiguous.Size = New System.Drawing.Size(354, 42)
        Me.Lambiguous.TabIndex = 11
        Me.Lambiguous.Text = "ambiguous or not"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 166)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'TBangleC
        '
        Me.TBangleC.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBangleC.Location = New System.Drawing.Point(541, 145)
        Me.TBangleC.Name = "TBangleC"
        Me.TBangleC.ReadOnly = True
        Me.TBangleC.Size = New System.Drawing.Size(163, 55)
        Me.TBangleC.TabIndex = 14
        '
        'TBsideC
        '
        Me.TBsideC.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.TBsideC.Location = New System.Drawing.Point(541, 84)
        Me.TBsideC.Name = "TBsideC"
        Me.TBsideC.ReadOnly = True
        Me.TBsideC.Size = New System.Drawing.Size(163, 55)
        Me.TBsideC.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label5.Location = New System.Drawing.Point(454, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 42)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "sin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("SimSun", 21.0!)
        Me.Label6.Location = New System.Drawing.Point(454, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 42)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 580)
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
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBsideA As TextBox
    Friend WithEvents TBangleA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBangleB As TextBox
    Friend WithEvents TBsideB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Lambiguous As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBangleC As TextBox
    Friend WithEvents TBsideC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
