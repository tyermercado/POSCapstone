<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailySales
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblInitial = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnViewSalesDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Location = New System.Drawing.Point(526, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "[ Close ]"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(82, 15)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Product Entry"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 10)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SALES"
        '
        'lblSales
        '
        Me.lblSales.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(111, 72)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(466, 26)
        Me.lblSales.TabIndex = 8
        Me.lblSales.Text = "0.00"
        Me.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInitial
        '
        Me.lblInitial.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitial.Location = New System.Drawing.Point(146, 107)
        Me.lblInitial.Name = "lblInitial"
        Me.lblInitial.Size = New System.Drawing.Size(431, 26)
        Me.lblInitial.TabIndex = 10
        Me.lblInitial.Text = "0.00"
        Me.lblInitial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "INITIAL CASH"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(111, 145)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(466, 26)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 26)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "TOTAL"
        '
        'btnViewSalesDetails
        '
        Me.btnViewSalesDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnViewSalesDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewSalesDetails.FlatAppearance.BorderSize = 0
        Me.btnViewSalesDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSalesDetails.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSalesDetails.ForeColor = System.Drawing.Color.White
        Me.btnViewSalesDetails.Location = New System.Drawing.Point(364, 188)
        Me.btnViewSalesDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewSalesDetails.Name = "btnViewSalesDetails"
        Me.btnViewSalesDetails.Size = New System.Drawing.Size(213, 31)
        Me.btnViewSalesDetails.TabIndex = 15
        Me.btnViewSalesDetails.Text = "View Sales Details"
        Me.btnViewSalesDetails.UseVisualStyleBackColor = False
        '
        'frmDailySales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 249)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnViewSalesDetails)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblInitial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmDailySales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblInitial As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnViewSalesDetails As Button
End Class
