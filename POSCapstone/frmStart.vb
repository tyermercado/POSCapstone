Imports MySql.Data.MySqlClient

Public Class frmStart
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Dispose()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            If txtCash.Text = String.Empty Then
                Return
            End If
            Dim sdate As String = Now.ToString("yyyy-MM-dd")
            cn.Open()
            cm = New MySqlCommand("insert into tblstart (sdate, initialcash)values(@sdate, @initialcash)", cn)
            cm.Parameters.AddWithValue("sdate", sdate)
            cm.Parameters.AddWithValue("initialcash", CDbl(txtCash.Text))
            cm.ExecuteNonQuery()
            cn.Close()

            With POS
                .btnNewOrder.Enabled = True
                If CheckStatus() = True Then

                    .btnStart.Enabled = False
                    .btnEnd.Enabled = True
                Else
                    .btnStart.Enabled = True
                    .btnEnd.Enabled = False
                End If
            End With
            Me.Dispose()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class