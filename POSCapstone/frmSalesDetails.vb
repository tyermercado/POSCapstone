Imports MySql.Data.MySqlClient

Public Class frmSalesDetails
    Private Sub frmSalesDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub LoadSales()
        Dim _total As Double
        Dim i As Integer
        DataGridView1.Rows.Clear()
        Dim sdate As String = Now.ToString("yyyy-MM-dd")
        cn.Open()
        cm = New MySqlCommand("SELECT c.id, c.transno, c.pid, p.description, c.price, c.qty, c.total FROM tblcart as c inner join tblproducts as p on c.pid = p.id where c.tdate between '" & sdate & "' and '" & sdate & "' and c.status like 'Completed'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            _total += CDbl(dr.Item("total").ToString)
            DataGridView1.Rows.Add(i, dr.Item("transno").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)
        End While
        dr.Close()
        cn.Close()
        lblTotal.Text = "TOTAL : " & Format(_total, "#,##0.00")
    End Sub

    Private Sub tsbClose_Click(sender As Object, e As EventArgs) Handles tsbClose.Click
        Me.Dispose()
    End Sub
End Class