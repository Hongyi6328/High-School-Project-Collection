<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFibonacci
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
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.nudTerms = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudIntPlaces = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.nudTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIntPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(12, 12)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResults.Size = New System.Drawing.Size(1034, 614)
        Me.txtResults.TabIndex = 5
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 632)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(108, 44)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'nudTerms
        '
        Me.nudTerms.Location = New System.Drawing.Point(185, 643)
        Me.nudTerms.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudTerms.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudTerms.Name = "nudTerms"
        Me.nudTerms.Size = New System.Drawing.Size(345, 28)
        Me.nudTerms.TabIndex = 6
        Me.nudTerms.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 645)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "n="
        '
        'nudIntPlaces
        '
        Me.nudIntPlaces.Location = New System.Drawing.Point(690, 643)
        Me.nudIntPlaces.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudIntPlaces.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudIntPlaces.Name = "nudIntPlaces"
        Me.nudIntPlaces.Size = New System.Drawing.Size(345, 28)
        Me.nudIntPlaces.TabIndex = 8
        Me.nudIntPlaces.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(586, 645)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Int Places"
        '
        'FormFibonacci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 688)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudIntPlaces)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudTerms)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "FormFibonacci"
        Me.Text = "FormFibonacci"
        CType(Me.nudTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIntPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResults As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents nudTerms As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nudIntPlaces As NumericUpDown
    Friend WithEvents Label2 As Label
End Class
