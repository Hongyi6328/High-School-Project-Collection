<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDeals
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRecommend = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvDeals = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.RefNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Package = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tags = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Advanced = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDeals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightCoral
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnBack.Location = New System.Drawing.Point(3, 4)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(166, 52)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "<<Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightCoral
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSearch.Location = New System.Drawing.Point(636, 546)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(202, 79)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnRecommend
        '
        Me.btnRecommend.BackColor = System.Drawing.Color.LightCoral
        Me.btnRecommend.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnRecommend.Location = New System.Drawing.Point(993, 546)
        Me.btnRecommend.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRecommend.Name = "btnRecommend"
        Me.btnRecommend.Size = New System.Drawing.Size(273, 81)
        Me.btnRecommend.TabIndex = 7
        Me.btnRecommend.Text = "Recommend"
        Me.btnRecommend.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtSearch.Location = New System.Drawing.Point(306, 562)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(320, 53)
        Me.txtSearch.TabIndex = 11
        '
        'dgvDeals
        '
        Me.dgvDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RefNumber, Me.StartDate, Me.TransDate, Me.Product, Me.Factory, Me.Customer, Me.Quantity, Me.Price, Me.Size, Me.Package, Me.Tags, Me.Advanced, Me.Edit, Me.Delete, Me.ID})
        Me.dgvDeals.Location = New System.Drawing.Point(3, 64)
        Me.dgvDeals.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDeals.Name = "dgvDeals"
        Me.dgvDeals.RowTemplate.Height = 30
        Me.dgvDeals.Size = New System.Drawing.Size(1258, 474)
        Me.dgvDeals.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightCoral
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSave.Location = New System.Drawing.Point(15, 548)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(202, 79)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'RefNumber
        '
        Me.RefNumber.HeaderText = "Ref No.*"
        Me.RefNumber.Name = "RefNumber"
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "Start Date"
        Me.StartDate.Name = "StartDate"
        '
        'TransDate
        '
        Me.TransDate.HeaderText = "Trans. Date"
        Me.TransDate.Name = "TransDate"
        '
        'Product
        '
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        '
        'Factory
        '
        Me.Factory.HeaderText = "Factory"
        Me.Factory.Name = "Factory"
        '
        'Customer
        '
        Me.Customer.HeaderText = "Customer"
        Me.Customer.Name = "Customer"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        '
        'Size
        '
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        '
        'Package
        '
        Me.Package.HeaderText = "Package"
        Me.Package.Name = "Package"
        '
        'Tags
        '
        Me.Tags.HeaderText = "Tags"
        Me.Tags.Name = "Tags"
        '
        'Advanced
        '
        Me.Advanced.HeaderText = "Advanced"
        Me.Advanced.Name = "Advanced"
        Me.Advanced.Text = "Advanced"
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Visible = False
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'formDeals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 636)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvDeals)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRecommend)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("SimSun", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formDeals"
        Me.Text = "Deals"
        CType(Me.dgvDeals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRecommend As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvDeals As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents RefNumber As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents TransDate As DataGridViewTextBoxColumn
    Friend WithEvents Product As DataGridViewTextBoxColumn
    Friend WithEvents Factory As DataGridViewTextBoxColumn
    Friend WithEvents Customer As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents Package As DataGridViewTextBoxColumn
    Friend WithEvents Tags As DataGridViewTextBoxColumn
    Friend WithEvents Advanced As DataGridViewButtonColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
End Class
