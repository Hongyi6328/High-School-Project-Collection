<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReports
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.radAllTime = New System.Windows.Forms.RadioButton()
        Me.radAnnual = New System.Windows.Forms.RadioButton()
        Me.radMonthly = New System.Windows.Forms.RadioButton()
        Me.radWeekly = New System.Windows.Forms.RadioButton()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Yellow
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnBack.Location = New System.Drawing.Point(6, 3)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(166, 52)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "<<Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Yellow
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnGenerate.Location = New System.Drawing.Point(15, 252)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(212, 86)
        Me.btnGenerate.TabIndex = 20
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'radAllTime
        '
        Me.radAllTime.AutoSize = True
        Me.radAllTime.Checked = True
        Me.radAllTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.radAllTime.Location = New System.Drawing.Point(40, 81)
        Me.radAllTime.Name = "radAllTime"
        Me.radAllTime.Size = New System.Drawing.Size(143, 36)
        Me.radAllTime.TabIndex = 21
        Me.radAllTime.TabStop = True
        Me.radAllTime.Text = "All Time"
        Me.radAllTime.UseVisualStyleBackColor = True
        '
        'radAnnual
        '
        Me.radAnnual.AutoSize = True
        Me.radAnnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.radAnnual.Location = New System.Drawing.Point(40, 123)
        Me.radAnnual.Name = "radAnnual"
        Me.radAnnual.Size = New System.Drawing.Size(130, 36)
        Me.radAnnual.TabIndex = 22
        Me.radAnnual.Text = "Annual"
        Me.radAnnual.UseVisualStyleBackColor = True
        '
        'radMonthly
        '
        Me.radMonthly.AutoSize = True
        Me.radMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.radMonthly.Location = New System.Drawing.Point(40, 165)
        Me.radMonthly.Name = "radMonthly"
        Me.radMonthly.Size = New System.Drawing.Size(140, 36)
        Me.radMonthly.TabIndex = 23
        Me.radMonthly.Text = "Monthly"
        Me.radMonthly.UseVisualStyleBackColor = True
        '
        'radWeekly
        '
        Me.radWeekly.AutoSize = True
        Me.radWeekly.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.radWeekly.Location = New System.Drawing.Point(40, 207)
        Me.radWeekly.Name = "radWeekly"
        Me.radWeekly.Size = New System.Drawing.Size(133, 36)
        Me.radWeekly.TabIndex = 24
        Me.radWeekly.Text = "Weekly"
        Me.radWeekly.UseVisualStyleBackColor = True
        '
        'txtReport
        '
        Me.txtReport.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtReport.Location = New System.Drawing.Point(234, 3)
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ReadOnly = True
        Me.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtReport.Size = New System.Drawing.Size(967, 625)
        Me.txtReport.TabIndex = 25
        Me.txtReport.Text = "Hello"
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Yellow
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnExport.Location = New System.Drawing.Point(15, 350)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(6)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(212, 86)
        Me.btnExport.TabIndex = 26
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'formReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.txtReport)
        Me.Controls.Add(Me.radWeekly)
        Me.Controls.Add(Me.radMonthly)
        Me.Controls.Add(Me.radAnnual)
        Me.Controls.Add(Me.radAllTime)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("SimSun", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "formReports"
        Me.Text = "Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents radAllTime As RadioButton
    Friend WithEvents radAnnual As RadioButton
    Friend WithEvents radMonthly As RadioButton
    Friend WithEvents radWeekly As RadioButton
    Friend WithEvents txtReport As TextBox
    Friend WithEvents btnExport As Button
End Class
