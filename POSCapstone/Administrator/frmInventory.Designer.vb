<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStockin = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMeasurement = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtPicker = New System.Windows.Forms.DateTimePicker()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pCATAGORY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pQUANTITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pSUPPLIER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pMEASUREMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pDATEACQUIRED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1125, 65)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'btnStockin
        '
        Me.btnStockin.Location = New System.Drawing.Point(45, 32)
        Me.btnStockin.Name = "btnStockin"
        Me.btnStockin.Size = New System.Drawing.Size(130, 23)
        Me.btnStockin.TabIndex = 3
        Me.btnStockin.Text = "Stocks - In"
        Me.btnStockin.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Filter By:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(313, 31)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(169, 20)
        Me.TextBox3.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(110, 31)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtQuantity)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtSupplier)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtMeasurement)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtPicker)
        Me.GroupBox2.Controls.Add(Me.cbCategory)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtProductname)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtPid)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 451)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(916, 190)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'txtSupplier
        '
        Me.txtSupplier.Location = New System.Drawing.Point(535, 25)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(166, 20)
        Me.txtSupplier.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(484, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Supplier"
        '
        'txtMeasurement
        '
        Me.txtMeasurement.Location = New System.Drawing.Point(535, 60)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(166, 20)
        Me.txtMeasurement.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Date Acquired"
        '
        'dtPicker
        '
        Me.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPicker.Location = New System.Drawing.Point(535, 93)
        Me.dtPicker.Name = "dtPicker"
        Me.dtPicker.Size = New System.Drawing.Size(200, 20)
        Me.dtPicker.TabIndex = 11
        '
        'cbCategory
        '
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Items.AddRange(New Object() {"Sweets", "Coffee", "Creams", "Milks", "Breads", ""})
        Me.cbCategory.Location = New System.Drawing.Point(112, 88)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(165, 21)
        Me.cbCategory.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(458, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Measurement"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Category"
        '
        'txtProductname
        '
        Me.txtProductname.Location = New System.Drawing.Point(112, 60)
        Me.txtProductname.Name = "txtProductname"
        Me.txtProductname.Size = New System.Drawing.Size(166, 20)
        Me.txtProductname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name"
        '
        'txtPid
        '
        Me.txtPid.Location = New System.Drawing.Point(112, 29)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(110, 20)
        Me.txtPid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnStockin)
        Me.GroupBox3.Controls.Add(Me.btnDelete)
        Me.GroupBox3.Controls.Add(Me.btnClose)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.Controls.Add(Me.btnUpdate)
        Me.GroupBox3.Location = New System.Drawing.Point(935, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 441)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(45, 151)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(45, 262)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(45, 70)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(45, 110)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dgvInventory
        '
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pID, Me.pNAME, Me.pCATAGORY, Me.pQUANTITY, Me.pSUPPLIER, Me.pMEASUREMENT, Me.pDATEACQUIRED})
        Me.dgvInventory.Location = New System.Drawing.Point(12, 200)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.Size = New System.Drawing.Size(915, 245)
        Me.dgvInventory.TabIndex = 12
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Calibri", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.White
        Me.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduct.Location = New System.Drawing.Point(0, -2)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btnProduct.Size = New System.Drawing.Size(1150, 107)
        Me.btnProduct.TabIndex = 13
        Me.btnProduct.Text = "LIST OF PRODUCTS"
        Me.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(111, 119)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(166, 20)
        Me.txtQuantity.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Quantity"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(921, 31)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(155, 20)
        Me.txtSearch.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(840, 29)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pID
        '
        Me.pID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pID.HeaderText = "Product ID"
        Me.pID.Name = "pID"
        Me.pID.Width = 83
        '
        'pNAME
        '
        Me.pNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.pNAME.HeaderText = "ProductName"
        Me.pNAME.Name = "pNAME"
        '
        'pCATAGORY
        '
        Me.pCATAGORY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pCATAGORY.HeaderText = "Category"
        Me.pCATAGORY.Name = "pCATAGORY"
        Me.pCATAGORY.Width = 74
        '
        'pQUANTITY
        '
        Me.pQUANTITY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pQUANTITY.HeaderText = "Quantity"
        Me.pQUANTITY.Name = "pQUANTITY"
        Me.pQUANTITY.Width = 71
        '
        'pSUPPLIER
        '
        Me.pSUPPLIER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pSUPPLIER.HeaderText = "Supplier"
        Me.pSUPPLIER.Name = "pSUPPLIER"
        Me.pSUPPLIER.Width = 70
        '
        'pMEASUREMENT
        '
        Me.pMEASUREMENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pMEASUREMENT.HeaderText = "Measurement"
        Me.pMEASUREMENT.Name = "pMEASUREMENT"
        Me.pMEASUREMENT.Width = 96
        '
        'pDATEACQUIRED
        '
        Me.pDATEACQUIRED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.pDATEACQUIRED.HeaderText = "Date Acquired"
        Me.pDATEACQUIRED.Name = "pDATEACQUIRED"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtPicker As DateTimePicker
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents btnStockin As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents txtMeasurement As TextBox
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pID As DataGridViewTextBoxColumn
    Friend WithEvents pNAME As DataGridViewTextBoxColumn
    Friend WithEvents pCATAGORY As DataGridViewTextBoxColumn
    Friend WithEvents pQUANTITY As DataGridViewTextBoxColumn
    Friend WithEvents pSUPPLIER As DataGridViewTextBoxColumn
    Friend WithEvents pMEASUREMENT As DataGridViewTextBoxColumn
    Friend WithEvents pDATEACQUIRED As DataGridViewTextBoxColumn
End Class
