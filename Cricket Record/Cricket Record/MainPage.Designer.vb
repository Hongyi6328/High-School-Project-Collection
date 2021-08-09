<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.btnRecording = New System.Windows.Forms.Button()
        Me.btnDGV = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDGV2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRecording
        '
        Me.btnRecording.Location = New System.Drawing.Point(313, 28)
        Me.btnRecording.Margin = New System.Windows.Forms.Padding(7)
        Me.btnRecording.Name = "btnRecording"
        Me.btnRecording.Size = New System.Drawing.Size(175, 91)
        Me.btnRecording.TabIndex = 10
        Me.btnRecording.Text = "Recording"
        Me.btnRecording.UseVisualStyleBackColor = True
        '
        'btnDGV
        '
        Me.btnDGV.Location = New System.Drawing.Point(313, 238)
        Me.btnDGV.Margin = New System.Windows.Forms.Padding(7)
        Me.btnDGV.Name = "btnDGV"
        Me.btnDGV.Size = New System.Drawing.Size(175, 91)
        Me.btnDGV.TabIndex = 11
        Me.btnDGV.Text = "View Statistics"
        Me.btnDGV.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(313, 343)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(175, 91)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDGV2
        '
        Me.btnDGV2.Location = New System.Drawing.Point(313, 133)
        Me.btnDGV2.Margin = New System.Windows.Forms.Padding(7)
        Me.btnDGV2.Name = "btnDGV2"
        Me.btnDGV2.Size = New System.Drawing.Size(175, 91)
        Me.btnDGV2.TabIndex = 13
        Me.btnDGV2.Text = "View History"
        Me.btnDGV2.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDGV2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDGV)
        Me.Controls.Add(Me.btnRecording)
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRecording As Button
    Friend WithEvents btnDGV As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDGV2 As Button
End Class
