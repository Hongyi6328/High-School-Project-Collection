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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(279, 54)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(513, 69)
        Me.TrackBar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 53)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RED"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.Label2.Location = New System.Drawing.Point(33, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 52)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "GREEN"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.Label3.Location = New System.Drawing.Point(33, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 55)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "BLUE"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(279, 195)
        Me.TrackBar2.Maximum = 255
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(513, 69)
        Me.TrackBar2.TabIndex = 4
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(279, 335)
        Me.TrackBar3.Maximum = 255
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(513, 69)
        Me.TrackBar3.TabIndex = 5
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(877, 54)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.ReadOnly = True
        Me.NumericUpDown1.Size = New System.Drawing.Size(124, 60)
        Me.NumericUpDown1.TabIndex = 6
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.NumericUpDown2.Location = New System.Drawing.Point(877, 193)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.ReadOnly = True
        Me.NumericUpDown2.Size = New System.Drawing.Size(124, 60)
        Me.NumericUpDown2.TabIndex = 7
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.NumericUpDown3.Location = New System.Drawing.Point(877, 330)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.ReadOnly = True
        Me.NumericUpDown3.Size = New System.Drawing.Size(124, 60)
        Me.NumericUpDown3.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.Button1.Location = New System.Drawing.Point(877, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 122)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(30, 434)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(762, 122)
        Me.Label4.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.Button2.Location = New System.Drawing.Point(577, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 122)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "GO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1126, 586)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TrackBar3)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Name = "Form1"
        Me.Text = "Felix' Color Mixing Tool"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
