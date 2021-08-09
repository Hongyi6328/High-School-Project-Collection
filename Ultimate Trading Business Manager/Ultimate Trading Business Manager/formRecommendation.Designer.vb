<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRecommendation
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
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRecommend = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtPassRate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtPrice.Location = New System.Drawing.Point(249, 129)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(447, 53)
        Me.txtPrice.TabIndex = 1
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtQuantity.Location = New System.Drawing.Point(249, 190)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(447, 53)
        Me.txtQuantity.TabIndex = 2
        '
        'txtProduct
        '
        Me.txtProduct.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtProduct.Location = New System.Drawing.Point(249, 251)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(447, 53)
        Me.txtProduct.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightCoral
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnBack.Location = New System.Drawing.Point(6, 3)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(166, 52)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "<<Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRecommend
        '
        Me.btnRecommend.BackColor = System.Drawing.Color.LightCoral
        Me.btnRecommend.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnRecommend.Location = New System.Drawing.Point(249, 462)
        Me.btnRecommend.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRecommend.Name = "btnRecommend"
        Me.btnRecommend.Size = New System.Drawing.Size(273, 81)
        Me.btnRecommend.TabIndex = 6
        Me.btnRecommend.Text = "Recommend"
        Me.btnRecommend.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(59, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 40)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Pass Rate"
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtSize.Location = New System.Drawing.Point(249, 312)
        Me.txtSize.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(447, 53)
        Me.txtSize.TabIndex = 4
        '
        'txtPassRate
        '
        Me.txtPassRate.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtPassRate.Location = New System.Drawing.Point(249, 373)
        Me.txtPassRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassRate.Name = "txtPassRate"
        Me.txtPassRate.Size = New System.Drawing.Size(447, 53)
        Me.txtPassRate.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(59, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 40)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(59, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 40)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Product"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(59, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 40)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(59, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 40)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Price"
        '
        'formRecommendation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(793, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPassRate)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRecommend)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Font = New System.Drawing.Font("SimSun", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "formRecommendation"
        Me.Text = "Recommendation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRecommend As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtPassRate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
