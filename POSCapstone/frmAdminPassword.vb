Imports MySql.Data.MySqlClient

Public Class frmAdminPassword
    Private Sub frmAdminPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.PasswordChar = Chr(149)
        Me.KeyPreview = True
    End Sub

    Private Sub frmAdminPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Enter Then
            ValidatePassword()
        End If
    End Sub


    Sub ValidatePassword()
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tbluser where role = @role and password = sha2(@password,224)", cn)

            With cm
                .Parameters.AddWithValue("@role", "Administrator")
                .Parameters.AddWithValue("@password", txtPass.Text)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dr.Close()
                cn.Close()
                CancelOrder()

            Else
                dr.Close()
                cn.Close()
                MsgBox("Invalid password", vbCritical)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Sub CancelOrder()
        Try

            If MsgBox("Cancel this order?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("update tblcart set status = 'Cancel order' where id like '" & id & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()

                cn.Open()
                cm = New MySqlCommand("update tblsales set total = total - @total where transno = @transno", cn)
                cm.Parameters.AddWithValue("@total", amount)
                cm.Parameters.AddWithValue("@transno", transno)
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Order successfully cancelled!", vbInformation)
                Me.Dispose()
                frmCancelOrder.LoadRecords()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class