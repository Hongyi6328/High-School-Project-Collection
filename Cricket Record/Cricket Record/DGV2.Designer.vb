<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DGV2
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
        Me._Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Runs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balls = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvBatmans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBatmans
        '
        Me.dgvBatmans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBatmans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Batman, Me._Date, Me._Time, Me.Runs, Me.Balls, Me.NotOut})
        Me.dgvBatmans.Location = New System.Drawing.Point(12, 12)
        Me.dgvBatmans.Name = "dgvBatmans"
        Me.dgvBatmans.RowHeadersWidth = 62
        Me.dgvBatmans.RowTemplate.Height = 30
        Me.dgvBatmans.Size = New System.Drawing.Size(1064, 389)
        Me.dgvBatmans.TabIndex = 1
        '
        'Batman
        '
        Me.Batman.HeaderText = "Batman"
        Me.Batman.MinimumWidth = 8
        Me.Batman.Name = "Batman"
        Me.Batman.Width = 250
        '
        '_Date
        '
        Me._Date.HeaderText = "Date"
        Me._Date.MinimumWidth = 8
        Me._Date.Name = "_Date"
        Me._Date.Width = 150
        '
        '_Time
        '
        Me._Time.HeaderText = "Time"
        Me._Time.MinimumWidth = 8
        Me._Time.Name = "_Time"
        Me._Time.Width = 150
        '
        'Runs
        '
        Me.Runs.HeaderText = "Runs"
        Me.Runs.MinimumWidth = 8
        Me.Runs.Name = "Runs"
        Me.Runs.Width = 150
        '
        'Balls
        '
        Me.Balls.HeaderText = "Balls"
        Me.Balls.MinimumWidth = 8
        Me.Balls.Name = "Balls"
        Me.Balls.Width = 150
        '
        'NotOut
        '
        Me.NotOut.HeaderText = "NotOut"
        Me.NotOut.MinimumWidth = 8
        Me.NotOut.Name = "NotOut"
        Me.NotOut.Width = 150
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(16, 476)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 133)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DGV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 625)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvBatmans)
        Me.Name = "DGV2"
        Me.Text = "DGV2"
        CType(Me.dgvBatmans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBatmans As DataGridView
    Friend WithEvents Batman As DataGridViewTextBoxColumn
    Friend WithEvents _Date As DataGridViewTextBoxColumn
    Friend WithEvents _Time As DataGridViewTextBoxColumn
    Friend WithEvents Runs As DataGridViewTextBoxColumn
    Friend WithEvents Balls As DataGridViewTextBoxColumn
    Friend WithEvents NotOut As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
End Class
