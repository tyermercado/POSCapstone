﻿Imports MySql.Data.MySqlClient
Public Class Table
    Dim table As String
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtTable.Text = String.Empty Then Return
            If MsgBox("Save tableno", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("insert into tbltable (tableno) values (@tableno)", cn)
                cm.Parameters.AddWithValue("@tableno", txtTable.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully saved!", vbInformation)
                Loadrecord()
                btnCancel_Click(sender, e)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Loadrecord()
        Dim i As Integer
        DataGridView1.Rows.Clear()
        cn.Open()
        cm = New MySqlCommand("select * from tbltable", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i += 1
            DataGridView1.Rows.Add(i, dr.Item("tableno").ToString)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colname = "colEdit" Then
            table = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            txtTable.Text = table
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        ElseIf colname = "colDelete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("delete from tbltable where tableno like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully deleted!", vbInformation)
                Loadrecord()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        table = ""
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        txtTable.Clear()
        txtTable.Focus()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtTable.Text = String.Empty Then Return
            If MsgBox("Update tableno", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("update tbltable set tableno = @tableno where tableno like '" & table & "'", cn)
                cm.Parameters.AddWithValue("@tableno", txtTable.Text)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Record has been successfully updateed!", vbInformation)
                Loadrecord()
                btnCancel_Click(sender, e)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class