Imports MySql.Data.MySqlClient


Public Class Qty
    Dim id As String, price As Double
    Private Sub Qty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Qty_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            Dim sdate As String = Now.ToString("yyyy-MM-dd")

            If DuplicateEntry(POS.lblTransNo.Text, id) = False Then
                cn.Open()
                cm = New MySqlCommand("insert into tblcart (transno, pid, price, tdate, tableno, qty, user)values(@transno, @pid, @price, @tdate, @tableno, @qty, @user)", cn)
                With cm
                    .Parameters.AddWithValue("@transno", POS.lblTransNo.Text)
                    .Parameters.AddWithValue("@pid", id)
                    .Parameters.AddWithValue("@price", price)
                    .Parameters.AddWithValue("@tdate", sdate)
                    .Parameters.AddWithValue("@tableno", POS.lblTable.Text)
                    .Parameters.AddWithValue("@qty", CDbl(txtQty.Text))
                    .Parameters.AddWithValue("@user", str_user)
                    .ExecuteNonQuery()
                End With
                cn.Close()
            Else
                cn.Open()
                cm = New MySqlCommand("update tblcart set qty = qty + @qty where transno = @transno and pid = @pid", cn)
                With cm
                    .Parameters.AddWithValue("@qty", CDbl(txtQty.Text))
                    .Parameters.AddWithValue("@transno", POS.lblTransNo.Text)
                    .Parameters.AddWithValue("@pid", id)
                    .ExecuteNonQuery()
                End With
                cn.Close()
            End If
            cn.Open()
            cm = New MySqlCommand("Update tblcart set total = price * qty where transno = @transno", cn)
            cm.Parameters.AddWithValue("@transno", POS.lblTransNo.Text)
            cm.ExecuteNonQuery()
            cn.Close()
            POS.LoadCart()
            Me.Dispose()
        End If
    End Sub

    Sub AddToCart(ByVal id As String, ByVal price As Double)
        Me.price = price
        Me.id = id

    End Sub

    Public Function DuplicateEntry(ByVal transno As String, ByVal pid As String) As Boolean
        cn.Open()
        cm = New MySqlCommand("select count(*) from tblcart where transno = @transno and pid=@pid", cn)
        With cm
            .Parameters.AddWithValue("@transno", transno)
            .Parameters.AddWithValue("@pid", pid)
        End With
        Dim i As Integer = CInt(cm.ExecuteScalar)
        cn.Close()
        If i > 0 Then Return True Else Return False
    End Function

    Private Sub Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class