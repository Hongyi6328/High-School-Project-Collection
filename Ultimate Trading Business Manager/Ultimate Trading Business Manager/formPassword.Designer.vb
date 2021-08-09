<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPassword
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword1 = New System.Windows.Forms.TextBox()
        Me.txtNewPassword2 = New System.Windows.Forms.TextBox()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.txtOldUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightGreen
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnBack.Location = New System.Drawing.Point(2, 3)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(8)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(185, 70)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "<<Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightGreen
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(316, 418)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(8)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(211, 82)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(123, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 40)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(107, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 40)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(107, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 40)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "New Password"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtOldPassword.Location = New System.Drawing.Point(371, 212)
        Me.txtOldPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(447, 53)
        Me.txtOldPassword.TabIndex = 2
        '
        'txtNewPassword1
        '
        Me.txtNewPassword1.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtNewPassword1.Location = New System.Drawing.Point(371, 274)
        Me.txtNewPassword1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPassword1.Name = "txtNewPassword1"
        Me.txtNewPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword1.Size = New System.Drawing.Size(447, 53)
        Me.txtNewPassword1.TabIndex = 3
        '
        'txtNewPassword2
        '
        Me.txtNewPassword2.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtNewPassword2.Location = New System.Drawing.Point(371, 335)
        Me.txtNewPassword2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPassword2.Name = "txtNewPassword2"
        Me.txtNewPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword2.Size = New System.Drawing.Size(447, 53)
        Me.txtNewPassword2.TabIndex = 4
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtNewUsername.Location = New System.Drawing.Point(371, 148)
        Me.txtNewUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(447, 53)
        Me.txtNewUsername.TabIndex = 1
        '
        'txtOldUsername
        '
        Me.txtOldUsername.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtOldUsername.Location = New System.Drawing.Point(371, 86)
        Me.txtOldUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOldUsername.Name = "txtOldUsername"
        Me.txtOldUsername.Size = New System.Drawing.Size(447, 53)
        Me.txtOldUsername.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(107, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 40)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "New Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(123, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 40)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Old Username"
        '
        'formPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNewUsername)
        Me.Controls.Add(Me.txtOldUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNewPassword2)
        Me.Controls.Add(Me.txtNewPassword1)
        Me.Controls.Add(Me.txtOldPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("SimSun", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "formPassword"
        Me.Text = "Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents txtNewPassword1 As TextBox
    Friend WithEvents txtNewPassword2 As TextBox
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents txtOldUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
