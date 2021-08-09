<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnReStart = New System.Windows.Forms.Button()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstFeedback = New System.Windows.Forms.ListBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInfo
        '
        Me.txtInfo.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.txtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtInfo.Location = New System.Drawing.Point(3, 0)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(789, 342)
        Me.txtInfo.TabIndex = 0
        Me.txtInfo.Text = resources.GetString("txtInfo.Text")
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtInput.Location = New System.Drawing.Point(12, 348)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(228, 56)
        Me.txtInput.TabIndex = 2
        '
        'btnReStart
        '
        Me.btnReStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnReStart.Location = New System.Drawing.Point(246, 348)
        Me.btnReStart.Name = "btnReStart"
        Me.btnReStart.Size = New System.Drawing.Size(178, 56)
        Me.btnReStart.TabIndex = 3
        Me.btnReStart.Text = "ReStart"
        Me.btnReStart.UseVisualStyleBackColor = True
        '
        'btnGuess
        '
        Me.btnGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnGuess.Location = New System.Drawing.Point(430, 348)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(178, 56)
        Me.btnGuess.TabIndex = 4
        Me.btnGuess.Text = "Guess!"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnExit.Location = New System.Drawing.Point(614, 348)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(178, 56)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstFeedback
        '
        Me.lstFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lstFeedback.FormattingEnabled = True
        Me.lstFeedback.HorizontalScrollbar = True
        Me.lstFeedback.ItemHeight = 40
        Me.lstFeedback.Location = New System.Drawing.Point(798, 0)
        Me.lstFeedback.Name = "lstFeedback"
        Me.lstFeedback.ScrollAlwaysVisible = True
        Me.lstFeedback.Size = New System.Drawing.Size(560, 724)
        Me.lstFeedback.TabIndex = 6
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txt.Location = New System.Drawing.Point(3, 472)
        Me.txt.Multiline = True
        Me.txt.Name = "txt"
        Me.txt.ReadOnly = True
        Me.txt.Size = New System.Drawing.Size(789, 113)
        Me.txt.TabIndex = 7
        '
        'txtTimer
        '
        Me.txtTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.txtTimer.Location = New System.Drawing.Point(3, 591)
        Me.txtTimer.Multiline = True
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.ReadOnly = True
        Me.txtTimer.Size = New System.Drawing.Size(789, 112)
        Me.txtTimer.TabIndex = 8
        '
        'Timer1
        '
        '
        'btnInfo
        '
        Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnInfo.Location = New System.Drawing.Point(246, 410)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(178, 56)
        Me.btnInfo.TabIndex = 9
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1359, 722)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.txtTimer)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.lstFeedback)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.btnReStart)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.txtInfo)
        Me.Name = "Form1"
        Me.Text = "Guess What Number!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInfo As TextBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnReStart As Button
    Friend WithEvents btnGuess As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstFeedback As ListBox
    Friend WithEvents txt As TextBox
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnInfo As Button
End Class
