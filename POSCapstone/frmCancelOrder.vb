Imports MySql.Data.MySqlClient
Public Class frmCancelOrder
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Sub LoadRecords()
        Try
            Dim sdate1 As String = Now.ToString("yyyy-MM-dd")
            Dim sdate2 As String = Now.ToString("yyyy-MM-dd")
            Dim i As Integer
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from vwcart where status like 'Completed' and tdate between '" & sdate1 & "' and '" & sdate2 & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("transno").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString, dr.Item("tableno").ToString, dr.Item("user").ToString, dr.Item("status").ToString, "Cancel Order")

            End While
            dr.Close()
            cn.Close()

            cn.Open()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub frmCancelOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblTimer_Tick(sender As Object, e As EventArgs) Handles lblTimer.Tick
        lblDate.Text = "Sales as of " & Now.ToShortDateString & " " & Now.ToLongDateString
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colCancel" Then
            With frmAdminPassword
                id = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                transno = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                amount = CDbl(DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
                .ShowDialog()
            End With
        End If
    End Sub
End Class