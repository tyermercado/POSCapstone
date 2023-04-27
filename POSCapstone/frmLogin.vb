Imports System.Management
Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.PasswordChar = Chr(149)
        Connection()
        If CountRecords("select count(*) from tbluser where role like 'Administrator'") = 0 Then
            With frmUserRegistration
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Dim found As Boolean = False
            If txtUser.Text = String.Empty Or txtPass.Text = String.Empty Then
                MsgBox("Required empty field", vbExclamation)
                Return
            End If
            cn.Open()
            cm = New MySqlCommand("select * from tbluser where username = @username and password = sha2(@password,224)", cn)
            'cm = New MySqlCommand("select * from tbluser where username = '" & txtUser.Text & "'and password = SHA2('" & txtPass.Text & "',224)", cn)
            With cm
                .Parameters.AddWithValue("@username", txtUser.Text)
                .Parameters.AddWithValue("@password", txtPass.Text)

            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                str_user = dr.Item("username").ToString
                str_pass = dr.Item("password").ToString
                str_name = dr.Item("name").ToString
                str_role = dr.Item("role").ToString

            Else
                found = False
            End If
            dr.Close()
            cn.Close()
            txtPass.Clear()
            txtUser.Clear()

            If found = True Then
                MsgBox("Access Granted! Welcome " & str_name, vbInformation)
                If str_role = "Administrator" Then

                    With frmMain
                        Dashboard()
                        .lblName.Text = str_name
                        .lblRole.Text = str_role
                        .lblDate.Text = Now.ToString("dddd MMM dd, yyyy hh:mm:ss tt")

                        .ShowDialog()
                    End With
                Else
                    With POS
                        If CheckStatus() = True Then
                            .btnStart.Enabled = False
                            .btnEnd.Enabled = True
                        Else
                            .btnStart.Enabled = True
                            .btnEnd.Enabled = False
                        End If
                        .lblName.Text = "Name: " & str_name
                        .lblRole.Text = "Role: " & str_role
                        .Show()
                    End With
                End If
            Else
                MsgBox("Invalid username of password!", vbExclamation)
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to close this application?", vbYesNo + vbQuestion) = vbYes Then
            Application.Exit()
        End If

    End Sub
End Class