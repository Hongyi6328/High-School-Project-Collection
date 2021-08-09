<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TXBAddress = New System.Windows.Forms.TextBox()
        Me.TXBDdate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXBOdate = New System.Windows.Forms.TextBox()
        Me.TXBPhone = New System.Windows.Forms.TextBox()
        Me.TXBperson = New System.Windows.Forms.TextBox()
        Me.TXBbusiness = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxIntro = New System.Windows.Forms.TextBox()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.Bhelp = New System.Windows.Forms.Button()
        Me.Bclear = New System.Windows.Forms.Button()
        Me.Bopenfile = New System.Windows.Forms.Button()
        Me.Bback = New System.Windows.Forms.Button()
        Me.Bsubmit = New System.Windows.Forms.Button()
        Me.Bread = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.TXBAddress)
        Me.GroupBox2.Controls.Add(Me.TXBDdate)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TXBOdate)
        Me.GroupBox2.Controls.Add(Me.TXBPhone)
        Me.GroupBox2.Controls.Add(Me.TXBperson)
        Me.GroupBox2.Controls.Add(Me.TXBbusiness)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(579, 575)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Business Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 347)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 51)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(269, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(126, 44)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cash"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(401, 1)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(138, 44)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Credit"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TXBAddress
        '
        Me.TXBAddress.BackColor = System.Drawing.Color.LawnGreen
        Me.TXBAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TXBAddress.Location = New System.Drawing.Point(186, 405)
        Me.TXBAddress.Multiline = True
        Me.TXBAddress.Name = "TXBAddress"
        Me.TXBAddress.Size = New System.Drawing.Size(377, 155)
        Me.TXBAddress.TabIndex = 14
        '
        'TXBDdate
        '
        Me.TXBDdate.BackColor = System.Drawing.Color.GreenYellow
        Me.TXBDdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TXBDdate.Location = New System.Drawing.Point(293, 290)
        Me.TXBDdate.Multiline = True
        Me.TXBDdate.Name = "TXBDdate"
        Me.TXBDdate.Size = New System.Drawing.Size(226, 51)
        Me.TXBDdate.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label11.Location = New System.Drawing.Point(31, 404)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 40)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Address"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label13.Location = New System.Drawing.Point(31, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(233, 40)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Delivery Date"
        '
        'TXBOdate
        '
        Me.TXBOdate.BackColor = System.Drawing.Color.GreenYellow
        Me.TXBOdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TXBOdate.Location = New System.Drawing.Point(293, 233)
        Me.TXBOdate.Multiline = True
        Me.TXBOdate.Name = "TXBOdate"
        Me.TXBOdate.Size = New System.Drawing.Size(226, 51)
        Me.TXBOdate.TabIndex = 8
        '
        'TXBPhone
        '
        Me.TXBPhone.BackColor = System.Drawing.Color.GreenYellow
        Me.TXBPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TXBPhone.Location = New System.Drawing.Point(293, 176)
        Me.TXBPhone.Multiline = True
        Me.TXBPhone.Name = "TXBPhone"
        Me.TXBPhone.Size = New System.Drawing.Size(226, 51)
        Me.TXBPhone.TabIndex = 7
        '
        'TXBperson
        '
        Me.TXBperson.BackColor = System.Drawing.Color.GreenYellow
        Me.TXBperson.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TXBperson.Location = New System.Drawing.Point(293, 119)
        Me.TXBperson.Multiline = True
        Me.TXBperson.Name = "TXBperson"
        Me.TXBperson.Size = New System.Drawing.Size(226, 51)
        Me.TXBperson.TabIndex = 6
        '
        'TXBbusiness
        '
        Me.TXBbusiness.BackColor = System.Drawing.Color.GreenYellow
        Me.TXBbusiness.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TXBbusiness.Location = New System.Drawing.Point(293, 62)
        Me.TXBbusiness.Multiline = True
        Me.TXBbusiness.Name = "TXBbusiness"
        Me.TXBbusiness.Size = New System.Drawing.Size(226, 51)
        Me.TXBbusiness.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label14.Location = New System.Drawing.Point(31, 233)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(245, 40)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Ordered Date "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label15.Location = New System.Drawing.Point(31, 174)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 40)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Phone"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label16.Location = New System.Drawing.Point(31, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(265, 40)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Contact Person"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label17.Location = New System.Drawing.Point(31, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(269, 40)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Business Name"
        '
        'TextBoxIntro
        '
        Me.TextBoxIntro.BackColor = System.Drawing.Color.LightGreen
        Me.TextBoxIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBoxIntro.Location = New System.Drawing.Point(782, 13)
        Me.TextBoxIntro.Multiline = True
        Me.TextBoxIntro.Name = "TextBoxIntro"
        Me.TextBoxIntro.ReadOnly = True
        Me.TextBoxIntro.Size = New System.Drawing.Size(491, 575)
        Me.TextBoxIntro.TabIndex = 16
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.GreenYellow
        Me.Bexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Bexit.Location = New System.Drawing.Point(597, 378)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(179, 55)
        Me.Bexit.TabIndex = 29
        Me.Bexit.Text = "Exit"
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'Bhelp
        '
        Me.Bhelp.BackColor = System.Drawing.Color.GreenYellow
        Me.Bhelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Bhelp.Location = New System.Drawing.Point(597, 317)
        Me.Bhelp.Name = "Bhelp"
        Me.Bhelp.Size = New System.Drawing.Size(179, 55)
        Me.Bhelp.TabIndex = 28
        Me.Bhelp.Text = "Help"
        Me.Bhelp.UseVisualStyleBackColor = False
        '
        'Bclear
        '
        Me.Bclear.BackColor = System.Drawing.Color.GreenYellow
        Me.Bclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Bclear.Location = New System.Drawing.Point(597, 256)
        Me.Bclear.Name = "Bclear"
        Me.Bclear.Size = New System.Drawing.Size(179, 55)
        Me.Bclear.TabIndex = 27
        Me.Bclear.Text = "Clear"
        Me.Bclear.UseVisualStyleBackColor = False
        '
        'Bopenfile
        '
        Me.Bopenfile.BackColor = System.Drawing.Color.GreenYellow
        Me.Bopenfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Bopenfile.Location = New System.Drawing.Point(597, 195)
        Me.Bopenfile.Name = "Bopenfile"
        Me.Bopenfile.Size = New System.Drawing.Size(179, 55)
        Me.Bopenfile.TabIndex = 26
        Me.Bopenfile.Text = "OpenFile"
        Me.Bopenfile.UseVisualStyleBackColor = False
        '
        'Bback
        '
        Me.Bback.BackColor = System.Drawing.Color.GreenYellow
        Me.Bback.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Bback.Location = New System.Drawing.Point(598, 12)
        Me.Bback.Name = "Bback"
        Me.Bback.Size = New System.Drawing.Size(179, 55)
        Me.Bback.TabIndex = 25
        Me.Bback.Text = "Back"
        Me.Bback.UseVisualStyleBackColor = False
        '
        'Bsubmit
        '
        Me.Bsubmit.BackColor = System.Drawing.Color.GreenYellow
        Me.Bsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Bsubmit.Location = New System.Drawing.Point(597, 73)
        Me.Bsubmit.Name = "Bsubmit"
        Me.Bsubmit.Size = New System.Drawing.Size(179, 55)
        Me.Bsubmit.TabIndex = 24
        Me.Bsubmit.Text = "Submit"
        Me.Bsubmit.UseVisualStyleBackColor = False
        '
        'Bread
        '
        Me.Bread.BackColor = System.Drawing.Color.GreenYellow
        Me.Bread.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Bread.Location = New System.Drawing.Point(597, 134)
        Me.Bread.Name = "Bread"
        Me.Bread.Size = New System.Drawing.Size(179, 55)
        Me.Bread.TabIndex = 30
        Me.Bread.Text = "Read"
        Me.Bread.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1286, 600)
        Me.Controls.Add(Me.Bread)
        Me.Controls.Add(Me.Bexit)
        Me.Controls.Add(Me.Bhelp)
        Me.Controls.Add(Me.Bclear)
        Me.Controls.Add(Me.Bopenfile)
        Me.Controls.Add(Me.Bback)
        Me.Controls.Add(Me.Bsubmit)
        Me.Controls.Add(Me.TextBoxIntro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form2"
        Me.Text = "Mapple"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXBAddress As TextBox
    Friend WithEvents TXBDdate As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TXBOdate As TextBox
    Friend WithEvents TXBPhone As TextBox
    Friend WithEvents TXBperson As TextBox
    Friend WithEvents TXBbusiness As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxIntro As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Bexit As Button
    Friend WithEvents Bhelp As Button
    Friend WithEvents Bclear As Button
    Friend WithEvents Bopenfile As Button
    Friend WithEvents Bback As Button
    Friend WithEvents Bsubmit As Button
    Friend WithEvents Bread As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

    Private Sub Bback_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bsubmit_Click(sender As Object, e As EventArgs) Handles Bsubmit.Click

    End Sub

    Private Sub Bread_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bclear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bopenfile_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bhelp_Click(sender As Object, e As EventArgs)

    End Sub
End Class
