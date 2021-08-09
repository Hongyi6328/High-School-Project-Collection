<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formNotifications
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
        Me.dgvNotifications = New System.Windows.Forms.DataGridView()
        Me._Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Task = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnNewTask = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.dtpTask = New System.Windows.Forms.DateTimePicker()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.dgvNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightGreen
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnBack.Location = New System.Drawing.Point(5, 5)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(8)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(166, 52)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "<<Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgvNotifications
        '
        Me.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotifications.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._Date, Me._Time, Me.Task, Me.State, Me.Edit, Me.Delete})
        Me.dgvNotifications.Location = New System.Drawing.Point(5, 63)
        Me.dgvNotifications.Name = "dgvNotifications"
        Me.dgvNotifications.RowTemplate.Height = 30
        Me.dgvNotifications.Size = New System.Drawing.Size(1233, 394)
        Me.dgvNotifications.TabIndex = 5
        '
        '_Date
        '
        Me._Date.HeaderText = "Date"
        Me._Date.Name = "_Date"
        Me._Date.Width = 150
        '
        '_Time
        '
        Me._Time.HeaderText = "Time"
        Me._Time.Name = "_Time"
        Me._Time.Width = 150
        '
        'Task
        '
        Me.Task.HeaderText = "Task"
        Me.Task.Name = "Task"
        Me.Task.Width = 400
        '
        'State
        '
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Visible = False
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        '
        'btnNewTask
        '
        Me.btnNewTask.BackColor = System.Drawing.Color.LightGreen
        Me.btnNewTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnNewTask.ForeColor = System.Drawing.Color.Black
        Me.btnNewTask.Location = New System.Drawing.Point(81, 160)
        Me.btnNewTask.Margin = New System.Windows.Forms.Padding(8)
        Me.btnNewTask.Name = "btnNewTask"
        Me.btnNewTask.Size = New System.Drawing.Size(562, 68)
        Me.btnNewTask.TabIndex = 6
        Me.btnNewTask.Text = "Add New Notification"
        Me.btnNewTask.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(Me.dtpTask)
        Me.GroupBox1.Controls.Add(Me.txtTask)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblDateTime)
        Me.GroupBox1.Controls.Add(Me.btnNewTask)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(12, 463)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1079, 252)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Notification"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(739, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 8
        '
        'dtpTask
        '
        Me.dtpTask.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTask.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpTask.Location = New System.Drawing.Point(267, 37)
        Me.dtpTask.Name = "dtpTask"
        Me.dtpTask.ShowUpDown = True
        Me.dtpTask.Size = New System.Drawing.Size(460, 39)
        Me.dtpTask.TabIndex = 11
        '
        'txtTask
        '
        Me.txtTask.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtTask.Location = New System.Drawing.Point(267, 94)
        Me.txtTask.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(376, 53)
        Me.txtTask.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(164, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Task:"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblDateTime.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblDateTime.Location = New System.Drawing.Point(64, 37)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(263, 40)
        Me.lblDateTime.TabIndex = 7
        Me.lblDateTime.Text = "Date and Time:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGreen
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(1100, 463)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 75)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'formNotifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 740)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvNotifications)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("SimSun", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "formNotifications"
        Me.Text = "Notifications"
        CType(Me.dgvNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents dgvNotifications As DataGridView
    Friend WithEvents btnNewTask As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents dtpTask As DateTimePicker
    Friend WithEvents txtTask As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btnSave As Button
    Friend WithEvents _Date As DataGridViewTextBoxColumn
    Friend WithEvents _Time As DataGridViewTextBoxColumn
    Friend WithEvents Task As DataGridViewTextBoxColumn
    Friend WithEvents State As DataGridViewCheckBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
