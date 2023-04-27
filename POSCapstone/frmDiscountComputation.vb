Imports System.Drawing.Imaging
Imports System.Management
Imports MySql.Data.MySqlClient

Public Class frmDiscountComputation
    'Private Sub txtxUBian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtxUBian.KeyPress, txttDining.KeyPress
    '    Select Case Asc(e.KeyChar)
    '        Case 48 To 57 '0-9
    '        Case 8 'backspace
    '        Case Else
    '            e.Handled = True
    '    End Select


    'End Sub



    Sub Compute()
        Try
            'If txtxUBian.Text = String.Empty Or txttDining.Text = String.Empty Then
            '    MsgBox("Required to input!", vbExclamation)
            '    Return
            'End If
            'txttDining.Text = 0
            'txtxUBian.Text = 0
            'txtTotal.Text = 0
            Dim ubian As Integer = Convert.ToInt32(txtxUBian.Text)
            Dim dining As Integer = Convert.ToInt32(txttDining.Text)
            Dim bill As Double = Convert.ToDouble(txtAmount.Text)


            Dim total As Double = (bill / 1.12) * 0.08
            Dim total_bill As Double = bill - total
            Dim total_dining As Double = total_bill / dining
            Dim total_ubian As Double = total_dining * 0.2
            Dim discount As Double = bill - total_ubian

            txtTotal.Text = Format(discount, "#,##0.00")
            frmSettle.txtVat.Text = 0.00
            frmSettle.txtTotal.Text = Format(discount, "#,##0.00")
            frmSettle.txtDiscount.Text = Format(CDbl(txtAmount.Text) - CDbl(txtTotal.Text), "#,##0.00")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            txtAmount.Text = frmSettle.txtBill.Text
            txtTotal.Text = "0.00"
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtID.Text = String.Empty Or txtName.Text = String.Empty Then
                MsgBox("required all field", vbExclamation)
                Return

            End If
            If MsgBox("Do you want to add this record?", vbYesNo + vbQuestion) = vbYes Then
                Dim sdate As String = Now.ToString("yyyy-MM-dd")
                cn.Open()
                cm = New MySqlCommand("insert into tblubian (transno, sid, name, sdate)values(@transno, @sid, @name, @sdate)", cn)
                With cm
                    .Parameters.AddWithValue("@transno", POS.lblTransNo.Text)
                    .Parameters.AddWithValue("@sid", txtID.Text)
                    .Parameters.AddWithValue("@name", txtName.Text)
                    .Parameters.AddWithValue("@sdate", sdate)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                MsgBox("Record has been successfully saved!", vbInformation)
                LoadRecords()
                txtID.Clear()
                txtName.Clear()
                txtID.Focus()
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Sub LoadRecords()
        Try
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from tblubian where transno like '" & POS.lblTransNo.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("sid").ToString, dr.Item("name").ToString)
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "colRemove" Then
                cn.Open()
                cm = New MySqlCommand("delete from tblubian where id = @id", cn)
                cm.Parameters.AddWithValue("@id", DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully removed!", vbInformation)
                LoadRecords()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub txttDining_TextChanged(sender As Object, e As EventArgs) Handles txttDining.TextChanged
        'Compute()

    End Sub

    Private Sub txtxUBian_TextChanged(sender As Object, e As EventArgs) Handles txtxUBian.TextChanged
        ' Compute()

    End Sub


    Private Sub frmDiscountComputation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txttDining.Text = 0
        txtxUBian.Text = 0
        'txtAmount.Text = 0
    End Sub

    Private Sub txttDining_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttDining.KeyPress

    End Sub

    Private Sub txttDining_KeyDown(ByVal sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txttDining.KeyDown
        If e.KeyCode = Keys.Enter Then
            Compute()

        End If
    End Sub
End Class