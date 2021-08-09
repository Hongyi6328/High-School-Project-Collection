<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDepartments
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
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnPrinting = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDepartments = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(529, 95)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(143, 57)
        Me.btnHistory.TabIndex = 26
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnPrinting
        '
        Me.btnPrinting.Location = New System.Drawing.Point(356, 95)
        Me.btnPrinting.Name = "btnPrinting"
        Me.btnPrinting.Size = New System.Drawing.Size(143, 57)
        Me.btnPrinting.TabIndex = 25
        Me.btnPrinting.Text = "Printing"
        Me.btnPrinting.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(178, 95)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(143, 57)
        Me.btnHome.TabIndex = 24
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(822, 62)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Department Summary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDepartments
        '
        Me.dgvDepartments.AllowUserToAddRows = False
        Me.dgvDepartments.AllowUserToDeleteRows = False
        Me.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvDepartments.Location = New System.Drawing.Point(138, 231)
        Me.dgvDepartments.Name = "dgvDepartments"
        Me.dgvDepartments.ReadOnly = True
        Me.dgvDepartments.RowTemplate.Height = 30
        Me.dgvDepartments.Size = New System.Drawing.Size(557, 387)
        Me.dgvDepartments.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.HeaderText = "Department"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Total Cost $"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "To"
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(211, 178)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(200, 28)
        Me.dtpFrom.TabIndex = 31
        Me.dtpFrom.Value = New Date(2020, 3, 23, 6, 40, 0, 0)
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(457, 178)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(200, 28)
        Me.dtpTo.TabIndex = 32
        Me.dtpTo.Value = New Date(2020, 3, 27, 6, 40, 0, 0)
        '
        'btnPick
        '
        Me.btnPick.Location = New System.Drawing.Point(700, 166)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(143, 57)
        Me.btnPick.TabIndex = 33
        Me.btnPick.Text = "Go"
        Me.btnPick.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(701, 231)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(143, 57)
        Me.btnExport.TabIndex = 35
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'formDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 644)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnPick)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvDepartments)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnPrinting)
        Me.Controls.Add(Me.btnHome)
        Me.Name = "formDepartments"
        Me.Text = "Departments"
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHistory As Button
    Friend WithEvents btnPrinting As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDepartments As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents btnPick As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
