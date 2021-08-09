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
        Me.btnSimulate = New System.Windows.Forms.Button()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InilQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.finQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Damaged = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoneyEarned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimulate
        '
        Me.btnSimulate.Location = New System.Drawing.Point(788, 31)
        Me.btnSimulate.Name = "btnSimulate"
        Me.btnSimulate.Size = New System.Drawing.Size(115, 66)
        Me.btnSimulate.TabIndex = 2
        Me.btnSimulate.Text = "Simulate"
        Me.btnSimulate.UseVisualStyleBackColor = True
        '
        'picMain
        '
        Me.picMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(200, 200)
        Me.picMain.TabIndex = 3
        Me.picMain.TabStop = False
        '
        'dgvResult
        '
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product, Me.Location, Me.InilQuantity, Me.finQuantity, Me.Damaged, Me.MoneyEarned, Me.Pop})
        Me.dgvResult.Location = New System.Drawing.Point(0, 206)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.RowHeadersWidth = 62
        Me.dgvResult.RowTemplate.Height = 30
        Me.dgvResult.Size = New System.Drawing.Size(1120, 842)
        Me.dgvResult.TabIndex = 4
        '
        'Product
        '
        Me.Product.HeaderText = "Product"
        Me.Product.MinimumWidth = 8
        Me.Product.Name = "Product"
        Me.Product.Width = 150
        '
        'Location
        '
        Me.Location.HeaderText = "Location"
        Me.Location.MinimumWidth = 8
        Me.Location.Name = "Location"
        Me.Location.Width = 150
        '
        'InilQuantity
        '
        Me.InilQuantity.HeaderText = "Initial Quantity"
        Me.InilQuantity.MinimumWidth = 8
        Me.InilQuantity.Name = "InilQuantity"
        Me.InilQuantity.Width = 150
        '
        'finQuantity
        '
        Me.finQuantity.HeaderText = "Final Quantity"
        Me.finQuantity.MinimumWidth = 8
        Me.finQuantity.Name = "finQuantity"
        Me.finQuantity.Width = 150
        '
        'Damaged
        '
        Me.Damaged.HeaderText = "Damaged"
        Me.Damaged.MinimumWidth = 8
        Me.Damaged.Name = "Damaged"
        Me.Damaged.Width = 150
        '
        'MoneyEarned
        '
        Me.MoneyEarned.HeaderText = "MoneyEarned"
        Me.MoneyEarned.MinimumWidth = 8
        Me.MoneyEarned.Name = "MoneyEarned"
        Me.MoneyEarned.Width = 150
        '
        'Pop
        '
        Me.Pop.HeaderText = "Popularity"
        Me.Pop.MinimumWidth = 8
        Me.Pop.Name = "Pop"
        Me.Pop.Width = 150
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1126, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(707, 731)
        Me.TextBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.btnSimulate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimulate As Button
    Friend WithEvents picMain As PictureBox
    Friend WithEvents dgvResult As DataGridView
    Friend WithEvents Product As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents InilQuantity As DataGridViewTextBoxColumn
    Friend WithEvents finQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Damaged As DataGridViewTextBoxColumn
    Friend WithEvents MoneyEarned As DataGridViewTextBoxColumn
    Friend WithEvents Pop As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
End Class
