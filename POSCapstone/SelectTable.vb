Imports MySql.Data.MySqlClient

Public Class SelectTable
    Dim btnTable As New Button
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Sub LoadTable()
        cn.Open()
        cm = New MySqlCommand("select * from vwtable", cn)
        dr = cm.ExecuteReader
        While dr.Read
            btnTable = New Button
            btnTable.Width = 150
            btnTable.Height = 50
            If CDbl(dr.Item("bill").ToString) > 1 Then
                btnTable.Text = dr.Item("tableno").ToString & " - ₱" & dr.Item("bill").ToString
                btnTable.BackColor = Color.Crimson
            Else
                btnTable.Text = dr.Item("tableno").ToString
                btnTable.BackColor = Color.FromArgb(5, 196, 107)
            End If

            btnTable.Tag = dr.Item("tableno").ToString
            btnTable.FlatStyle = FlatStyle.Flat

            btnTable.ForeColor = Color.White
            btnTable.Cursor = Cursors.Hand
            btnTable.TextAlign = ContentAlignment.MiddleCenter
            FlowLayoutPanel1.Controls.Add(btnTable)
            AddHandler btnTable.Click, AddressOf GetTable_Click

        End While
        dr.Close()
        cn.Close()
    End Sub

    Sub GetTable_Click(sender As Object, e As EventArgs)
        Dim table As String = sender.tag.ToString
        With POS
            .lblTable.Text = table
            .GetOrder()
        End With
        Me.Dispose()

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class