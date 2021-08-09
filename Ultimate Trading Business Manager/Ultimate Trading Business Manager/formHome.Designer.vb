<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHome))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSchedule1 = New System.Windows.Forms.CheckBox()
        Me.chkSchedule2 = New System.Windows.Forms.CheckBox()
        Me.chkSchedule3 = New System.Windows.Forms.CheckBox()
        Me.chkSchedule4 = New System.Windows.Forms.CheckBox()
        Me.btnNotifications = New System.Windows.Forms.Button()
        Me.btnDeals = New System.Windows.Forms.Button()
        Me.btnContacts = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Forte", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblWelcome.Location = New System.Drawing.Point(229, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(558, 132)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome!"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblDateTime.Location = New System.Drawing.Point(291, 141)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(124, 28)
        Me.lblDateTime.TabIndex = 1
        Me.lblDateTime.Text = "Today is"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Upcoming schedules: "
        '
        'chkSchedule1
        '
        Me.chkSchedule1.AutoSize = True
        Me.chkSchedule1.Location = New System.Drawing.Point(251, 274)
        Me.chkSchedule1.Name = "chkSchedule1"
        Me.chkSchedule1.Size = New System.Drawing.Size(164, 32)
        Me.chkSchedule1.TabIndex = 3
        Me.chkSchedule1.Text = "CheckBox1"
        Me.chkSchedule1.UseVisualStyleBackColor = True
        '
        'chkSchedule2
        '
        Me.chkSchedule2.AutoSize = True
        Me.chkSchedule2.Location = New System.Drawing.Point(251, 313)
        Me.chkSchedule2.Name = "chkSchedule2"
        Me.chkSchedule2.Size = New System.Drawing.Size(164, 32)
        Me.chkSchedule2.TabIndex = 4
        Me.chkSchedule2.Text = "CheckBox2"
        Me.chkSchedule2.UseVisualStyleBackColor = True
        '
        'chkSchedule3
        '
        Me.chkSchedule3.AutoSize = True
        Me.chkSchedule3.Location = New System.Drawing.Point(251, 352)
        Me.chkSchedule3.Name = "chkSchedule3"
        Me.chkSchedule3.Size = New System.Drawing.Size(164, 32)
        Me.chkSchedule3.TabIndex = 5
        Me.chkSchedule3.Text = "CheckBox3"
        Me.chkSchedule3.UseVisualStyleBackColor = True
        '
        'chkSchedule4
        '
        Me.chkSchedule4.AutoSize = True
        Me.chkSchedule4.Location = New System.Drawing.Point(251, 391)
        Me.chkSchedule4.Name = "chkSchedule4"
        Me.chkSchedule4.Size = New System.Drawing.Size(164, 32)
        Me.chkSchedule4.TabIndex = 6
        Me.chkSchedule4.Text = "CheckBox4"
        Me.chkSchedule4.UseVisualStyleBackColor = True
        '
        'btnNotifications
        '
        Me.btnNotifications.BackColor = System.Drawing.Color.LightGreen
        Me.btnNotifications.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnNotifications.Location = New System.Drawing.Point(124, 460)
        Me.btnNotifications.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Size = New System.Drawing.Size(253, 66)
        Me.btnNotifications.TabIndex = 7
        Me.btnNotifications.Text = "Notifications"
        Me.btnNotifications.UseVisualStyleBackColor = False
        '
        'btnDeals
        '
        Me.btnDeals.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeals.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnDeals.Location = New System.Drawing.Point(373, 524)
        Me.btnDeals.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDeals.Name = "btnDeals"
        Me.btnDeals.Size = New System.Drawing.Size(162, 66)
        Me.btnDeals.TabIndex = 8
        Me.btnDeals.Text = "Deals"
        Me.btnDeals.UseVisualStyleBackColor = False
        '
        'btnContacts
        '
        Me.btnContacts.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnContacts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnContacts.Location = New System.Drawing.Point(529, 460)
        Me.btnContacts.Margin = New System.Windows.Forms.Padding(5)
        Me.btnContacts.Name = "btnContacts"
        Me.btnContacts.Size = New System.Drawing.Size(195, 66)
        Me.btnContacts.TabIndex = 9
        Me.btnContacts.Text = "Contacts"
        Me.btnContacts.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.Yellow
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnReports.Location = New System.Drawing.Point(723, 524)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(173, 66)
        Me.btnReports.TabIndex = 10
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'picIcon
        '
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(926, 9)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(50, 70)
        Me.picIcon.TabIndex = 11
        Me.picIcon.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnExit.Location = New System.Drawing.Point(849, 87)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 66)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnHelp.Location = New System.Drawing.Point(14, 14)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(127, 66)
        Me.btnHelp.TabIndex = 13
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'formHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 670)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnContacts)
        Me.Controls.Add(Me.btnDeals)
        Me.Controls.Add(Me.btnNotifications)
        Me.Controls.Add(Me.chkSchedule4)
        Me.Controls.Add(Me.chkSchedule3)
        Me.Controls.Add(Me.chkSchedule2)
        Me.Controls.Add(Me.chkSchedule1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblWelcome)
        Me.Font = New System.Drawing.Font("SimSun", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "formHome"
        Me.Text = "Ultimate Trading Business Manager v1.0 Aug 19, 2020"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkSchedule1 As CheckBox
    Friend WithEvents chkSchedule2 As CheckBox
    Friend WithEvents chkSchedule3 As CheckBox
    Friend WithEvents chkSchedule4 As CheckBox
    Friend WithEvents btnNotifications As Button
    Friend WithEvents btnDeals As Button
    Friend WithEvents btnContacts As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnHelp As Button
End Class
