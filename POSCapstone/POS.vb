Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports Org.BouncyCastle.Bcpg
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics.PerformanceData
Imports System.IO
Imports System.Management
Imports System.Net.Sockets
Imports System.Xml.Schema

Public Class POS
    Dim btnCategory As New Button
    Dim pic As New PictureBox
    Dim lblDesc As New Label
    Dim lblPrice As New Label

    Dim _filter As String = ""
    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection()
        LoadCategory()
        LoadMenu()
        Me.KeyPreview = True

    End Sub



    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click

        If CheckTransaction() = True Then
            generateOrderno()
            lblTransNo.Text = GetTransno()
            With SelectTable
                .LoadTable()
                .ShowDialog()
            End With
            LoadCart()
        Else
            MsgBox("Transaction is already closed!", vbExclamation)
        End If

    End Sub


    Function GetTransno() As String
        Try
            Dim sdate As String = Now.ToString("yyyyMMdd")
            cn.Open()
            cm = New MySqlCommand("select * from tblcart where transno like '" & sdate & "%'order by id desc", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                GetTransno = dr.Item("transno").ToString + 1
            Else
                GetTransno = sdate & "0001"
            End If
            dr.Close()
            cn.Close()
            Return GetTransno

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Function

    Private Sub btnTable_Click(sender As Object, e As EventArgs)
        With Table
            .btnUpdate.Enabled = False
            .Loadrecord()
            .ShowDialog()
        End With
    End Sub



    Private Sub LoadMenu()
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.Controls.Clear()
        cn.Open()
        cm = New MySqlCommand("Select image, id, description, price, status from tblproducts where category Like '" & _filter & "%' order by description", cn)
        cm = New MySqlCommand("Select image, id, description, price, status from tblproducts", cn)
        dr = cm.ExecuteReader
        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))
            pic = New PictureBox
            pic.Width = 150
            pic.Height = 150
            pic.BackgroundImageLayout = ImageLayout.Stretch

            Dim ms As New MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            pic.Tag = dr.Item("id").ToString

            lblDesc = New Label
            lblDesc.BackColor = Color.FromArgb(161, 110, 45)
            lblDesc.ForeColor = Color.White
            lblDesc.Text = dr.Item("description").ToString
            lblDesc.Font = New Font("Calibri", 8, FontStyle.Regular)
            lblDesc.Dock = DockStyle.Top
            lblDesc.Cursor = Cursors.Hand
            lblPrice.AutoSize = True
            lblDesc.TextAlign = ContentAlignment.MiddleCenter
            lblDesc.Tag = dr.Item("id").ToString

            lblPrice = New Label
            lblPrice.BackColor = Color.FromArgb(161, 110, 45)
            lblPrice.ForeColor = Color.White
            lblPrice.Text = dr.Item("price").ToString
            lblPrice.Font = New Font("Calibri", 8, FontStyle.Regular)
            lblPrice.Dock = DockStyle.Bottom
            lblPrice.Cursor = Cursors.Hand
            lblPrice.AutoSize = True
            lblPrice.TextAlign = ContentAlignment.MiddleCenter
            lblPrice.Tag = dr.Item("id").ToString


            pic.Controls.Add(lblDesc)
            pic.Controls.Add(lblPrice)
            FlowLayoutPanel2.Controls.Add(pic)
            AddHandler pic.Click, AddressOf select_Click
            AddHandler lblDesc.Click, AddressOf select_Click
            AddHandler lblPrice.Click, AddressOf select_Click


        End While
        dr.Close()
        cn.Close()
    End Sub



    Sub LoadCategory()
        cn.Open()
        cm = New MySqlCommand("select * from tblcategory", cn)
        dr = cm.ExecuteReader
        While dr.Read
            btnCategory = New Button
            btnCategory.Width = 150
            btnCategory.Height = 50
            btnCategory.Text = dr.Item("category").ToString
            btnCategory.FlatStyle = FlatStyle.Flat
            btnCategory.BackColor = Color.FromArgb(161, 110, 45)
            btnCategory.ForeColor = Color.White
            btnCategory.Cursor = Cursors.Hand
            btnCategory.TextAlign = ContentAlignment.MiddleCenter
            FlowLayoutPanel1.Controls.Add(btnCategory)

            AddHandler btnCategory.Click, AddressOf filter_Click
        End While
        dr.Close()
        cn.Close()
    End Sub

    Public Sub select_Click(sender As Object, e As EventArgs)
        Try
            If lblTransNo.Text = String.Empty Then
                MsgBox("Click New Order First!", vbCritical)
                Return
            End If
            Dim price As Double
            Dim id As String = sender.tag.ToString()
            cn.Open()
            cm = New MySqlCommand("select * from tblproducts where id like '" & id & "'", cn)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                price = CDbl(dr.Item("price").ToString)
            End If
            dr.Close()
            cn.Close()

            With Qty
                .AddToCart(id, price)
                .Show()
            End With

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub LoadCart()
        Dim _total As Double
        DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select c.id, p.description, c.price, c.qty, c.total from tblcart as c inner join tblproducts as p on p.id = c.pid where c.transno like '" & lblTransNo.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            _total += CDbl(dr.Item("total").ToString)
            DataGridView1.Rows.Add(dr.Item("id").ToString, dr.Item("description").ToString, dr.Item("price").ToString, dr.Item("qty").ToString, dr.Item("total").ToString)
        End While
        dr.Close()
        cn.Close()
        lblTotal.Text = Format(_total, "#,##0.00")

        If DataGridView1.Rows.Count < 1 Then
            btnPayment.Enabled = False

        Else
            btnPayment.Enabled = True

        End If
    End Sub

    Sub AddToCart(ByVal id As String, ByVal price As Double)
        Dim sdate As String = Now.ToString("yyyy-MM-dd")
        cn.Open()
        cm = New MySqlCommand("insert into tblcart (transno, pid, price, tdate, tableno)values(@transno, @pid, @price, @tdate, @tableno)", cn)
        With cm
            .Parameters.AddWithValue("@transno", lblTransNo.Text)
            .Parameters.AddWithValue("@pid", id)
            .Parameters.AddWithValue("@price", price)
            .Parameters.AddWithValue("@tdate", sdate)
            .Parameters.AddWithValue("@tableno", lblTable.Text)
            .ExecuteNonQuery()
        End With
        cn.Close()

        cn.Open()
        cm = New MySqlCommand("Update tblcart set total = price * qty", cn)
        cm.ExecuteNonQuery()
        cn.Close()

    End Sub

    Public Sub filter_Click(sender As Object, e As EventArgs)
        If lblTransNo.Text = String.Empty Then
            MsgBox("Click New Order First!", vbCritical)
            Return
        End If

        _filter = sender.text.ToString

        LoadMenu()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colRemove" Then
            If MsgBox("Remove this item from the list?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tblcart where id like '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Item has been successfully removed from the cart!", vbInformation)
                LoadCart()
            End If
        End If
    End Sub

    Sub GetOrder()
        Dim found As Boolean
        Dim tno As String
        cn.Open()
        cm = New MySqlCommand("select * from tblcart where tableno like '" & lblTable.Text & "' and status like 'Pending'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            found = True
            tno = dr.Item("transno").ToString
        Else
            found = False
        End If
        dr.Close()
        cn.Close()

        If found = True Then
            lblTransNo.Text = tno
            LoadCart()
        End If
    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel2.Paint

    End Sub

    Private Sub POS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnNewOrder_Click(sender, e)
        ElseIf e.KeyCode = Keys.F2 Then
            btnPayment_Click(sender, e)

        ElseIf e.KeyCode = Keys.F5 Then
            btnTable_Click(sender, e)
        ElseIf e.KeyCode = keys.F6 Then
            btnSales_Click(sender, e)
        End If
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        With frmSettle
            .txtBill.Text = lblTotal.Text
            .CalculateVat()
            .ShowDialog()
        End With
    End Sub



    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Try
            cn.Open()
            cm = New MySqlCommand("select count(*) from tblcart where status like 'Pending'", cn)
            Dim icount As Integer = CInt(cm.ExecuteScalar)
            cn.Close()

            If icount > 0 Then
                MsgBox("Please settle the pending bills.", vbExclamation)
            Else
                If MsgBox("Do you want to close the transaction?", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New MySqlCommand("update tblstart set status = 'close' where id like '" & startid & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Sales transaction has been successfully closed!", vbInformation)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        With frmDailySales
            .lblTitle.Text = "DAILY SALES [" & Now.ToString("MMM-dd-yyyy") & "]"
            .GenerateSales()
            .ShowDialog()
        End With
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If CheckTransaction() = True Then
            With frmStart
                .ShowDialog()
            End With
        Else
            Dim sdate As String = Now.ToString("yyyy-MM-dd")
            cn.Open()
            cm = New MySqlCommand("select count(*) from tblstart where sdate between '" & sdate & "' and '" & sdate & "'and status like 'close'", cn)
            Dim count As Integer = CInt(cm.ExecuteScalar)
            cn.Close()

            If count = 0 Then
                With frmStart
                    .ShowDialog()
                End With
            Else
                MsgBox("Transaction today is already closed!", vbExclamation)
            End If

        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure you want to logout?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
        Else
            Return
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        With frmCancelOrder
            .LoadRecords()
            .ShowDialog()
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub generateOrderno()
        Dim queue As Integer
        Dim cmd As New MySqlCommand
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        cm = New MySqlCommand("Select RIGHT(MAX(transno),6) as queue from tblsales", cn)
        cm.CommandType = CommandType.Text
        ''cm.Connection =
        queue = Convert.ToInt64(cm.ExecuteScalar() + 1)
        lblorderno.Text = queue
        cn.Close()

    End Sub
End Class
