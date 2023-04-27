Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class frmSettle
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label6.Click, Label5.Click, Label4.Click

    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Try
            Dim total As Double = CDbl(txtTotal.Text)
            Dim change As Double = CDbl(txtCash.Text) - total
            If change < 0 Then
                txtChange.Text = "0.00"
            Else
                txtChange.Text = Format(change, "#,##0.00")
            End If
        Catch ex As Exception
            txtChange.Text = "0.00"
        End Try
    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case 13
                btnAccept_Click(sender, e)
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            Dim total As Double = CDbl(txtTotal.Text)
            Dim change As Double = CDbl(txtCash.Text) - total
            If change < 0 Then
                MsgBox("Insufficient Cash! Please enter correct amount!", vbExclamation)
                Return
            Else
                If MsgBox("Save this payment?", vbYesNo + vbQuestion) = vbYes Then
                    SavePayment()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub SavePayment()
        Try
            Dim sdate As String = Now.ToString("yyy-MM-dd")
            Dim stime As String = Now.ToString("hh:mm:ss")
            cn.Open()
            cm = New MySqlCommand("insert into tblsales(transno, total, sdate, stime, cashier, discount, totalbill, cash, cashchange) values (@transno, @total, @sdate, @stime, @cashier, @discount, @totalbill, @cash, @cashchange)", cn)
            With cm
                .Parameters.AddWithValue("@transno", POS.lblTransNo.Text)
                .Parameters.AddWithValue("@total", CDbl(txtBill.Text))
                .Parameters.AddWithValue("@sdate", sdate)
                .Parameters.AddWithValue("@stime", stime)
                .Parameters.AddWithValue("@cashier", str_user)
                .Parameters.AddWithValue("@discount", CDbl(txtDiscount.Text))
                .Parameters.AddWithValue("@totalbill", CDbl(txtBill.Text))
                .Parameters.AddWithValue("@cash", CDbl(txtCash.Text))
                .Parameters.AddWithValue("@cashchange", CDbl(txtChange.Text))
                .ExecuteNonQuery()
            End With
            cn.Close()

            cn.Open()
            cm = New MySqlCommand("update tblcart set status = 'Completed' where transno like '" & POS.lblTransNo.Text & "'", cn)
            cm.ExecuteNonQuery()
            cn.Close()

            MsgBox("Payment successfully saved", vbInformation)

            With frmReceipt
                .PrintPreview("select c.id, p.description, c.price, c.qty, c.total from tblcart as c inner join tblproducts as p on c.pid = p.id where c.status like 'Completed' and transno like '" & POS.lblTransNo.Text & "'")
                .ShowDialog()
            End With


            With POS
                .lblTransNo.Text = .GetTransno()
                .LoadCart()

            End With



            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmSettle_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked

    End Sub

    Private Sub frmSettle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub


    Public Sub CalculateVat()
        txtVat.Text = Format((CDbl(txtBill.Text) - CDbl(txtBill.Text) / GetVat()), "#,##0.00")
        txtDiscount.Text = "0.00"
        txtTotal.Text = Format(CDbl(txtBill.Text) + CDbl(txtVat.Text))
    End Sub
    Private Sub frmSettle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()

        End If
    End Sub


    Private Sub llblCompute_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblCompute.LinkClicked
        With frmDiscountComputation
            .txtAmount.Text = txtBill.Text
            .ShowDialog()
        End With
    End Sub





    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txtDiscount.Text = "0.00"
        CalculateVat()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class