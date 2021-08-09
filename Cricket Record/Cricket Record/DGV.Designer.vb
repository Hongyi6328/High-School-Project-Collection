<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGV
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
        Me.dgvBatmans = New System.Windows.Forms.DataGridView()
        Me.Batman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Runs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Outs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Avg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvBatmans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBatmans
        '
        Me.dgvBatmans.AllowUserToAddRows = False
        Me.dgvBatmans.AllowUserToDeleteRows = False
        Me.dgvBatmans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBatmans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Batman, Me.Runs, Me.Outs, Me.Avg})
        Me.dgvBatmans.Location = New System.Drawing.Point(0, 82)
        Me.dgvBatmans.Name = "dgvBatmans"
        Me.dgvBatmans.ReadOnly = True
        Me.dgvBatmans.RowHeadersWidth = 62
        Me.dgvBatmans.RowTemplate.Height = 30
        Me.dgvBatmans.Size = New System.Drawing.Size(1064, 389)
        Me.dgvBatmans.TabIndex = 0
        '
        'Batman
        '
        Me.Batman.HeaderText = "Batman"
        Me.Batman.MinimumWidth = 8
        Me.Batman.Name = "Batman"
        Me.Batman.Width = 250
        '
        'Runs
        '
        Me.Runs.HeaderText = "Runs"
        Me.Runs.MinimumWidth = 8
        Me.Runs.Name = "Runs"
        Me.Runs.Width = 150
        '
        'Outs
        '
        Me.Outs.HeaderText = "NotOuts"
        Me.Outs.MinimumWidth = 8
        Me.Outs.Name = "Outs"
        Me.Outs.Width = 150
        '
        'Avg
        '
        Me.Avg.HeaderText = "Average"
        Me.Avg.MinimumWidth = 8
        Me.Avg.Name = "Avg"
        Me.Avg.Width = 150
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(205, 481)
        Me.btnSort.Margin = New System.Windows.Forms.Padding(7)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(175, 133)
        Me.btnSort.TabIndex = 10
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(394, 481)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(7)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(175, 133)
        Me.btnExport.TabIndex = 11
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(583, 481)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 133)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnPick
        '
        Me.btnPick.Location = New System.Drawing.Point(16, 481)
        Me.btnPick.Margin = New System.Windows.Forms.Padding(7)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(175, 133)
        Me.btnPick.TabIndex = 13
        Me.btnPick.Text = "Pick Data"
        Me.btnPick.UseVisualStyleBackColor = True
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(128, 22)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(215, 28)
        Me.dtpFrom.TabIndex = 14
        Me.dtpFrom.Value = New Date(2020, 3, 26, 16, 44, 0, 0)
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(494, 22)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(215, 28)
        Me.dtpTo.TabIndex = 15
        Me.dtpTo.Value = New Date(2020, 4, 4, 16, 44, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "To"
        '
        'DGV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 623)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.btnPick)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.dgvBatmans)
        Me.Name = "DGV"
        Me.Text = "DGV"
        CType(Me.dgvBatmans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBatmans As DataGridView
    Friend WithEvents btnSort As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnPick As Button
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Batman As DataGridViewTextBoxColumn
    Friend WithEvents Runs As DataGridViewTextBoxColumn
    Friend WithEvents Outs As DataGridViewTextBoxColumn
    Friend WithEvents Avg As DataGridViewTextBoxColumn
End Class
