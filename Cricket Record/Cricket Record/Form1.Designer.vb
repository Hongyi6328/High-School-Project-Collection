<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recording
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.ckbNOut = New System.Windows.Forms.CheckBox()
        Me.txtRuns = New System.Windows.Forms.TextBox()
        Me.txtBalls = New System.Windows.Forms.TextBox()
        Me.lblRunsIn = New System.Windows.Forms.Label()
        Me.lblBallsIn = New System.Windows.Forms.Label()
        Me.cmbPlayers = New System.Windows.Forms.ComboBox()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblClubOut = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBallsOut = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNotOutsOut = New System.Windows.Forms.Label()
        Me.lblStrikeRateOut = New System.Windows.Forms.Label()
        Me.lblAvgOut = New System.Windows.Forms.Label()
        Me.lblInningsOut = New System.Windows.Forms.Label()
        Me.lblRunsOut = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(23, 264)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(7)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(175, 91)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'ckbNOut
        '
        Me.ckbNOut.AutoSize = True
        Me.ckbNOut.Location = New System.Drawing.Point(23, 181)
        Me.ckbNOut.Margin = New System.Windows.Forms.Padding(7)
        Me.ckbNOut.Name = "ckbNOut"
        Me.ckbNOut.Size = New System.Drawing.Size(159, 44)
        Me.ckbNOut.TabIndex = 1
        Me.ckbNOut.Text = "Not out"
        Me.ckbNOut.UseVisualStyleBackColor = True
        '
        'txtRuns
        '
        Me.txtRuns.Location = New System.Drawing.Point(174, 59)
        Me.txtRuns.Margin = New System.Windows.Forms.Padding(7)
        Me.txtRuns.Name = "txtRuns"
        Me.txtRuns.Size = New System.Drawing.Size(235, 48)
        Me.txtRuns.TabIndex = 2
        '
        'txtBalls
        '
        Me.txtBalls.Location = New System.Drawing.Point(174, 119)
        Me.txtBalls.Margin = New System.Windows.Forms.Padding(7)
        Me.txtBalls.Name = "txtBalls"
        Me.txtBalls.Size = New System.Drawing.Size(235, 48)
        Me.txtBalls.TabIndex = 3
        '
        'lblRunsIn
        '
        Me.lblRunsIn.AutoSize = True
        Me.lblRunsIn.Location = New System.Drawing.Point(16, 66)
        Me.lblRunsIn.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblRunsIn.Name = "lblRunsIn"
        Me.lblRunsIn.Size = New System.Drawing.Size(101, 40)
        Me.lblRunsIn.TabIndex = 5
        Me.lblRunsIn.Text = "Runs"
        '
        'lblBallsIn
        '
        Me.lblBallsIn.AutoSize = True
        Me.lblBallsIn.Location = New System.Drawing.Point(16, 126)
        Me.lblBallsIn.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblBallsIn.Name = "lblBallsIn"
        Me.lblBallsIn.Size = New System.Drawing.Size(77, 40)
        Me.lblBallsIn.TabIndex = 6
        Me.lblBallsIn.Text = "Ball"
        '
        'cmbPlayers
        '
        Me.cmbPlayers.FormattingEnabled = True
        Me.cmbPlayers.Location = New System.Drawing.Point(0, 0)
        Me.cmbPlayers.Margin = New System.Windows.Forms.Padding(7)
        Me.cmbPlayers.Name = "cmbPlayers"
        Me.cmbPlayers.Size = New System.Drawing.Size(409, 48)
        Me.cmbPlayers.TabIndex = 7
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.btnUpdate)
        Me.grpSummary.Controls.Add(Me.lblClubOut)
        Me.grpSummary.Controls.Add(Me.Label7)
        Me.grpSummary.Controls.Add(Me.lblBallsOut)
        Me.grpSummary.Controls.Add(Me.Label6)
        Me.grpSummary.Controls.Add(Me.lblNotOutsOut)
        Me.grpSummary.Controls.Add(Me.lblStrikeRateOut)
        Me.grpSummary.Controls.Add(Me.lblAvgOut)
        Me.grpSummary.Controls.Add(Me.lblInningsOut)
        Me.grpSummary.Controls.Add(Me.lblRunsOut)
        Me.grpSummary.Controls.Add(Me.Label5)
        Me.grpSummary.Controls.Add(Me.Label4)
        Me.grpSummary.Controls.Add(Me.Label3)
        Me.grpSummary.Controls.Add(Me.Label2)
        Me.grpSummary.Controls.Add(Me.Label1)
        Me.grpSummary.Location = New System.Drawing.Point(419, 12)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(593, 497)
        Me.grpSummary.TabIndex = 8
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Summary"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(192, 354)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(7)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(175, 133)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblClubOut
        '
        Me.lblClubOut.AutoSize = True
        Me.lblClubOut.Location = New System.Drawing.Point(343, 55)
        Me.lblClubOut.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblClubOut.Name = "lblClubOut"
        Me.lblClubOut.Size = New System.Drawing.Size(37, 40)
        Me.lblClubOut.TabIndex = 22
        Me.lblClubOut.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 40)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Club"
        '
        'lblBallsOut
        '
        Me.lblBallsOut.AutoSize = True
        Me.lblBallsOut.Location = New System.Drawing.Point(343, 175)
        Me.lblBallsOut.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblBallsOut.Name = "lblBallsOut"
        Me.lblBallsOut.Size = New System.Drawing.Size(37, 40)
        Me.lblBallsOut.TabIndex = 20
        Me.lblBallsOut.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 175)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 40)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Balls"
        '
        'lblNotOutsOut
        '
        Me.lblNotOutsOut.AutoSize = True
        Me.lblNotOutsOut.Location = New System.Drawing.Point(343, 292)
        Me.lblNotOutsOut.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblNotOutsOut.Name = "lblNotOutsOut"
        Me.lblNotOutsOut.Size = New System.Drawing.Size(37, 40)
        Me.lblNotOutsOut.TabIndex = 18
        Me.lblNotOutsOut.Text = "0"
        '
        'lblStrikeRateOut
        '
        Me.lblStrikeRateOut.AutoSize = True
        Me.lblStrikeRateOut.Location = New System.Drawing.Point(343, 252)
        Me.lblStrikeRateOut.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblStrikeRateOut.Name = "lblStrikeRateOut"
        Me.lblStrikeRateOut.Size = New System.Drawing.Size(89, 40)
        Me.lblStrikeRateOut.TabIndex = 17
        Me.lblStrikeRateOut.Text = "NaN"
        '
        'lblAvgOut
        '
        Me.lblAvgOut.AutoSize = True
        Me.lblAvgOut.Location = New System.Drawing.Point(343, 212)
        Me.lblAvgOut.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblAvgOut.Name = "lblAvgOut"
        Me.lblAvgOut.Size = New System.Drawing.Size(89, 40)
        Me.lblAvgOut.TabIndex = 16
        Me.lblAvgOut.Text = "NaN"
        '
        'lblInningsOut
        '
        Me.lblInningsOut.AutoSize = True
        Me.lblInningsOut.Location = New System.Drawing.Point(343, 95)
        Me.lblInningsOut.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblInningsOut.Name = "lblInningsOut"
        Me.lblInningsOut.Size = New System.Drawing.Size(37, 40)
        Me.lblInningsOut.TabIndex = 15
        Me.lblInningsOut.Text = "0"
        '
        'lblRunsOut
        '
        Me.lblRunsOut.AutoSize = True
        Me.lblRunsOut.Location = New System.Drawing.Point(343, 135)
        Me.lblRunsOut.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblRunsOut.Name = "lblRunsOut"
        Me.lblRunsOut.Size = New System.Drawing.Size(37, 40)
        Me.lblRunsOut.TabIndex = 14
        Me.lblRunsOut.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 292)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 40)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Not Outs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 252)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 40)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Strike Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 212)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 40)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Average"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 40)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Innings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Runs"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(212, 264)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 91)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Recording
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(21.0!, 40.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 521)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.cmbPlayers)
        Me.Controls.Add(Me.lblBallsIn)
        Me.Controls.Add(Me.lblRunsIn)
        Me.Controls.Add(Me.txtBalls)
        Me.Controls.Add(Me.txtRuns)
        Me.Controls.Add(Me.ckbNOut)
        Me.Controls.Add(Me.btnSubmit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Recording"
        Me.Text = "Cricket"
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents ckbNOut As CheckBox
    Friend WithEvents txtRuns As TextBox
    Friend WithEvents txtBalls As TextBox
    Friend WithEvents lblRunsIn As Label
    Friend WithEvents lblBallsIn As Label
    Friend WithEvents cmbPlayers As ComboBox
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents lblNotOutsOut As Label
    Friend WithEvents lblStrikeRateOut As Label
    Friend WithEvents lblAvgOut As Label
    Friend WithEvents lblInningsOut As Label
    Friend WithEvents lblRunsOut As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBallsOut As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblClubOut As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnUpdate As Button
End Class
