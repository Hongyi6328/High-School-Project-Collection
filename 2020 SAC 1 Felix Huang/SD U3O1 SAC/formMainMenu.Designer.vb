<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMainMenu
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
        Me.btnDepartments = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnPrinting = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDepartments
        '
        Me.btnDepartments.Location = New System.Drawing.Point(320, 293)
        Me.btnDepartments.Name = "btnDepartments"
        Me.btnDepartments.Size = New System.Drawing.Size(143, 57)
        Me.btnDepartments.TabIndex = 0
        Me.btnDepartments.Text = "Departments"
        Me.btnDepartments.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(3, 9)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(793, 62)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Zippy Printing Services"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(320, 220)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(143, 57)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.Text = "View History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnPrinting
        '
        Me.btnPrinting.Location = New System.Drawing.Point(320, 147)
        Me.btnPrinting.Name = "btnPrinting"
        Me.btnPrinting.Size = New System.Drawing.Size(143, 57)
        Me.btnPrinting.TabIndex = 3
        Me.btnPrinting.Text = "Printing"
        Me.btnPrinting.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(320, 371)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 57)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(793, 62)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Main Menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrinting)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnDepartments)
        Me.Name = "formMainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDepartments As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnPrinting As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class
