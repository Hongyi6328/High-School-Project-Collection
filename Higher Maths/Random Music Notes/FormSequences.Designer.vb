<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSequences
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
        Me.btnRun = New System.Windows.Forms.Button()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(806, 10)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(240, 89)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(437, 56)
        Me.nudFrom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.Size = New System.Drawing.Size(120, 28)
        Me.nudFrom.TabIndex = 1
        Me.nudFrom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(639, 56)
        Me.nudTo.Maximum = New Decimal(New Integer() {101, 0, 0, 0})
        Me.nudTo.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(120, 28)
        Me.nudTo.TabIndex = 2
        Me.nudTo.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(607, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(413, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Terms interval (use -1 to represent infinite)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 36)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "T(n+1)="
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(127, 12)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(254, 28)
        Me.txtInput.TabIndex = 7
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(20, 169)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(1026, 483)
        Me.txtOutput.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 108)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "NOTE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use Tn for the n th term;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Legal operators: + - * / ^ ( ) . log" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Legal con" &
    "stants: e, pi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Log(a,b) means a^(log(a,b))=b" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No whitespace allowed"
        '
        'FormSequences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 664)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudTo)
        Me.Controls.Add(Me.nudFrom)
        Me.Controls.Add(Me.btnRun)
        Me.Name = "FormSequences"
        Me.Text = "FormSequences"
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRun As Button
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label5 As Label
End Class
