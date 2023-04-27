Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class frmReceipt
    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub PrintPreview(ByVal sql As String)
        Dim rptds As ReportDataSource
        Try
            With rvReceipt.LocalReport
                ' .ReportPath = "bin\Debug\rptCart.rdlc"
                .ReportPath = Application.StartupPath & "/rptReceipt.rdlc"
                .DataSources.Clear()

            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter
            da.SelectCommand = New MySqlCommand(sql, cn)
            da.Fill(ds.Tables("dtReceipt"))

            Dim pCashier As New ReportParameter("pCashier", "CASHIER: " & str_user)
            Dim pDate As New ReportParameter("pDate", "DATE | TIME: " & Now)
            Dim pVat As New ReportParameter("pVat", frmSettle.txtVat.Text)
            Dim pDisc As New ReportParameter("pDisc", frmSettle.txtDiscount.Text)
            Dim pBill As New ReportParameter("pBill", frmSettle.txtBill.Text)
            Dim pCash As New ReportParameter("pCash", frmSettle.txtCash.Text)
            Dim pChange As New ReportParameter("pChange", frmSettle.txtChange.Text)

            rvReceipt.LocalReport.SetParameters(pCashier)
            rvReceipt.LocalReport.SetParameters(pDate)
            rvReceipt.LocalReport.SetParameters(pVat)
            rvReceipt.LocalReport.SetParameters(pDisc)
            rvReceipt.LocalReport.SetParameters(pBill)
            rvReceipt.LocalReport.SetParameters(pCash)
            rvReceipt.LocalReport.SetParameters(pChange)
            rptds = New ReportDataSource("DataSet1", ds.Tables("dtReceipt"))
            rvReceipt.LocalReport.DataSources.Add(rptds)
            rvReceipt.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)


        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class