<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formContacts
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
        Me.dgvContacts = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me._Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnBack.Location = New System.Drawing.Point(6, 4)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(166, 52)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "<<Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgvContacts
        '
        Me.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContacts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._Name, Me.Phone, Me.Address, Me.Email, Me.Tag, Me.Fax, Me.Edit, Me.Delete})
        Me.dgvContacts.Location = New System.Drawing.Point(39, 110)
        Me.dgvContacts.Name = "dgvContacts"
        Me.dgvContacts.RowTemplate.Height = 30
        Me.dgvContacts.Size = New System.Drawing.Size(1196, 452)
        Me.dgvContacts.TabIndex = 20
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("SimSun", 20.0!)
        Me.txtSearch.Location = New System.Drawing.Point(596, 610)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(320, 53)
        Me.txtSearch.TabIndex = 22
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSearch.Location = New System.Drawing.Point(938, 594)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(202, 79)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnSave.Location = New System.Drawing.Point(15, 594)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(202, 79)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        '_Name
        '
        Me._Name.HeaderText = "Name*"
        Me._Name.Name = "_Name"
        '
        'Phone
        '
        Me.Phone.HeaderText = "Phone"
        Me.Phone.Name = "Phone"
        Me.Phone.Width = 150
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.Width = 350
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Width = 200
        '
        'Tag
        '
        Me.Tag.HeaderText = "Tag"
        Me.Tag.Name = "Tag"
        Me.Tag.Width = 180
        '
        'Fax
        '
        Me.Fax.HeaderText = "Fax"
        Me.Fax.Name = "Fax"
        Me.Fax.Width = 150
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
        'formContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvContacts)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("SimSun", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "formContacts"
        Me.Text = "Contacts"
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents dgvContacts As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents _Name As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Tag As DataGridViewTextBoxColumn
    Friend WithEvents Fax As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
