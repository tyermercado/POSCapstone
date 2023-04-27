Imports System.Drawing.Design
Imports MySql.Data.MySqlClient



Module Module1
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public str_user, str_pass, str_name, str_role As String
    Public startid As String
    Public id, transno As String
    Public amount As Double
    Public currencysymbol As String = "₱"
    'Public vatrate As Double
    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server=localhost;user id=root;password=;database=posresto"
        End With
    End Sub

    Function GetVat() As Double
        Dim vatrate As Double
        cn.Open()
        cm = New MySqlCommand("select taxrate from tbltax", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then vatrate = (CDbl(dr.Item("taxrate").ToString) / 100) + 1 Else vatrate = 0
        dr.Close()
        cn.Close()
        Return vatrate
    End Function

    Function CheckTransaction() As Boolean
        Dim isOpen As Boolean
        cn.Open()
        cm = New MySqlCommand("select * from tblstart where id like '" & startid & "'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            isOpen = True
        Else
            isOpen = False

        End If
        dr.Close()
        cn.Close()
        Return isOpen
    End Function


    Sub Dashboard()
        Try
            With frmMain
                Dim sdate As String = Now.ToString("yyyy-MM-dd")
                cn.Open()
                cm = New MySqlCommand("select ifnull(sum(total),0) from tblsales", cn) 'where sdate between '" & sdate & "'and '" & sdate & "'", cn)
                Dim total As Double = CDbl(cm.ExecuteScalar)
                .lblTotalSales.Text = Format(total, currencysymbol & " #,##0.00")
                cn.Close()

                cn.Open()
                cm = New MySqlCommand("select count(*) from tblproducts", cn)
                Dim totproduct As Integer = CInt(cm.ExecuteScalar)
                .lblProduct.Text = totproduct
                cn.Close()
            End With


        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub
    Function CheckStatus() As Boolean
        Dim found As Boolean
        Dim sdate As String = Now.ToString("yyyy-MM-dd")


        cn.Open()
        cm = New MySqlCommand("select * from tblstart where sdate between '" & sdate & "' and '" & sdate & "'and status like 'open'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            startid = dr.Item("id").ToString
            found = True
        Else
            found = False
        End If
        dr.Close()
        cn.Close()
        Return found
    End Function

    Function CountRecords(ByVal sql As String) As Integer
        Dim count As Integer
        cn.Open()
        cm = New MySqlCommand(sql, cn)
        count = CInt(cm.ExecuteScalar)
        cn.Close()
        Return count


    End Function
End Module
