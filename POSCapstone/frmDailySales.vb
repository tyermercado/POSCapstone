Imports MySql.Data.MySqlClient
Public Class frmDailySales
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()
    End Sub

    Private Sub frmDailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub GenerateSales()
        Try
            Dim sdate As String = Now.ToString("yyyy-MM-dd")

            cn.Open()
            cm = New MySqlCommand("select ifnull(sum(total),0) as total from tblcart where tdate between '" & sdate & "' and '" & sdate & "' and status like 'Completed'", cn)
            lblSales.Text = Format(CDbl(cm.ExecuteScalar), "#,##0.00")
            cn.Close()

            cn.Open()
            cm = New MySqlCommand("select ifnull(sum(initialcash),0) as total from tblstart where sdate between '" & sdate & "' and '" & sdate & "'", cn)
            lblInitial.Text = Format(CDbl(cm.ExecuteScalar), "#,##0.00")
            cn.Close()

            Dim _total As Double = CDbl(lblSales.Text) + CDbl(lblInitial.Text)

            lblTotal.Text = Format(_total, ",#,##0.00")
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnViewSalesDetails_Click(sender As Object, e As EventArgs) Handles btnViewSalesDetails.Click
        With frmSalesDetails
            .LoadSales()
            .ShowDialog()
        End With
    End Sub
End Class