<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettle))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbClose = New System.Windows.Forms.PictureBox()
        Me.llblCompute = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL BILL"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(37, 295)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(295, 40)
        Me.txtTotal.TabIndex = 1
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.White
        Me.txtCash.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(39, 361)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(295, 40)
        Me.txtCash.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CASH"
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.White
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(38, 443)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(295, 40)
        Me.txtChange.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CHANGE"
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccept.FlatAppearance.BorderSize = 0
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccept.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Location = New System.Drawing.Point(38, 488)
        Me.btnAccept.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(295, 39)
        Me.btnAccept.TabIndex = 16
        Me.btnAccept.Text = "ACCEPT PAYMENT"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TOTAL "
        '
        'txtBill
        '
        Me.txtBill.BackColor = System.Drawing.Color.White
        Me.txtBill.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBill.Location = New System.Drawing.Point(37, 59)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(295, 40)
        Me.txtBill.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "DISCOUNTED AMOUNT"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.White
        Me.txtDiscount.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(39, 207)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(295, 40)
        Me.txtDiscount.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, -96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "TOTAL BILL (INCLUDING VAT)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PbClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 31)
        Me.Panel1.TabIndex = 17
        '
        'PbClose
        '
        Me.PbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbClose.ErrorImage = Nothing
        Me.PbClose.Image = CType(resources.GetObject("PbClose.Image"), System.Drawing.Image)
        Me.PbClose.Location = New System.Drawing.Point(348, 0)
        Me.PbClose.Name = "PbClose"
        Me.PbClose.Size = New System.Drawing.Size(32, 32)
        Me.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PbClose.TabIndex = 23
        Me.PbClose.TabStop = False
        '
        'llblCompute
        '
        Me.llblCompute.AutoSize = True
        Me.llblCompute.LinkColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.llblCompute.Location = New System.Drawing.Point(176, 189)
        Me.llblCompute.Name = "llblCompute"
        Me.llblCompute.Size = New System.Drawing.Size(156, 15)
        Me.llblCompute.TabIndex = 18
        Me.llblCompute.TabStop = True
        Me.llblCompute.Text = "[ CLICK HERE TO COMPUTE ]"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(209, 250)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(123, 15)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[ CANCEL DISCOUNT  ]"
        '
        'txtVat
        '
        Me.txtVat.BackColor = System.Drawing.Color.White
        Me.txtVat.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.Location = New System.Drawing.Point(39, 128)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(295, 40)
        Me.txtVat.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "VAT EXEMPT SALES"
        '
        'frmSettle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 551)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.llblCompute)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmSettle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBill As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PbClose As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtVat As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents llblCompute As LinkLabel
End Class
