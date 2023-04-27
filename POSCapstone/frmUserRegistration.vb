Imports MySql.Data.MySqlClient

Public Class frmUserRegistration
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
    Sub Clear()
        txtConfirm.Clear()
        txtName.Clear()
        txtPass.Clear()
        txtUser.Clear()
    End Sub

    Private Sub frmUserRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.PasswordChar = Chr(149)
        txtConfirm.PasswordChar = Chr(149)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtConfirm.Text = "" Or txtName.Text = "" Or txtPass.Text = "" Or txtUser.Text = "" Then
                MsgBox("Please enter missing field!", vbCritical)
                Return
            End If

            If txtPass.Text <> txtConfirm.Text Then
                MsgBox("Invalid confirm password!", vbCritical)
                Return
            End If

            cn.Open()
            cm = New MySqlCommand("insert into tbluser (username,password, name, role)values(@username,sha2(@password,224), @name, @role)", cn)
            With cm
                .Parameters.AddWithValue("@username", txtUser.Text)
                .Parameters.AddWithValue("@password", txtPass.Text)
                .Parameters.AddWithValue("@name", txtName.Text)
                .Parameters.AddWithValue("@role", "Administrator")
                .ExecuteNonQuery()
            End With
            cn.Close()

            MsgBox("New user account has been successfully saved!", vbInformation)
            Me.Dispose()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class