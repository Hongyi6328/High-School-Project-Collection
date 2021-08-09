<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6174
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
        Me.nudNumber = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudNumber
        '
        Me.nudNumber.Location = New System.Drawing.Point(0, 0)
        Me.nudNumber.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudNumber.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudNumber.Name = "nudNumber"
        Me.nudNumber.Size = New System.Drawing.Size(69, 28)
        Me.nudNumber.TabIndex = 0
        Me.nudNumber.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 54)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(1151, 673)
        Me.TextBox1.TabIndex = 1
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(75, 12)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 26)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'Form6174
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 739)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.nudNumber)
        Me.Name = "Form6174"
        Me.Text = "Form6174"
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudNumber As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRun As Button
End Class
