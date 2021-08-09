<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnHello = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnGoodbye = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnHello.Location = New System.Drawing.Point(98, 66)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(199, 85)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "&Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(97, 442)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(199, 85)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnClear.Location = New System.Drawing.Point(98, 316)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(199, 85)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnGoodbye
        '
        Me.btnGoodbye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnGoodbye.Location = New System.Drawing.Point(98, 191)
        Me.btnGoodbye.Name = "btnGoodbye"
        Me.btnGoodbye.Size = New System.Drawing.Size(199, 85)
        Me.btnGoodbye.TabIndex = 3
        Me.btnGoodbye.Text = "&Goodbye"
        Me.btnGoodbye.UseVisualStyleBackColor = True
        '
        'txtOut
        '
        Me.txtOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtOut.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtOut.Location = New System.Drawing.Point(446, 66)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.ReadOnly = True
        Me.txtOut.Size = New System.Drawing.Size(375, 35)
        Me.txtOut.TabIndex = 4
        Me.txtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 687)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.btnGoodbye)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHello)
        Me.Name = "Form1"
        Me.Text = "Hello Universe!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHello As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnGoodbye As Button
    Private WithEvents txtOut As TextBox
End Class
