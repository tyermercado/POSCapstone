Imports MySql.Data.MySqlClient

Public Class frmInventory
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnStockin_Click(sender As Object, e As EventArgs) Handles btnStockin.Click
        frmStockin.ShowDialog()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            cn.Open()
            cm = New MySqlCommand("insert into tblstockin(ProductID, ProductName, Category, Quantity, Supplier, Measurement, DateAcquired) VALUES (@ProductID, @ProductName, @Category, @Quantity, @Supplier, @Measurement, @DateAcquired)", cn)
            cm.Parameters.Clear()
            With cm.Parameters
                .AddWithValue("@ProductID", txtPid.Text)
                .AddWithValue("@ProductName", txtProductname.Text)
                .AddWithValue("@Category", cbCategory.Text)
                .AddWithValue("@Quantity", txtQuantity.Text)
                .AddWithValue("@Supplier", txtSupplier.Text)
                .AddWithValue("@Measurement", txtMeasurement.Text)
                .AddWithValue("@DateAcquired", dtPicker.Value)

            End With
            cm.ExecuteNonQuery()
            txtPid.Clear()
            txtProductname.Clear()
            txtQuantity.Clear()
            txtSupplier.Clear()
            txtMeasurement.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub
End Class