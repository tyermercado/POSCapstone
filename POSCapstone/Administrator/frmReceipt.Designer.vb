<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Me.rvReceipt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvReceipt
        '
        Me.rvReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvReceipt.Location = New System.Drawing.Point(0, 0)
        Me.rvReceipt.Name = "rvReceipt"
        Me.rvReceipt.ServerReport.BearerToken = Nothing
        Me.rvReceipt.Size = New System.Drawing.Size(451, 638)
        Me.rvReceipt.TabIndex = 0
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 638)
        Me.Controls.Add(Me.rvReceipt)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmReceipt"
        Me.Text = "frmReceipt"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvReceipt As Microsoft.Reporting.WinForms.ReportViewer
End Class
