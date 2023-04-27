Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmPrintPreview
    Private Sub frmPrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rvPrintPreview.RefreshReport()
    End Sub

    Sub PrintPreview(ByVal sql As String, ByVal amount As Double, ByVal total As Double)
        Dim rptds As ReportDataSource
        Try
            With rvPrintPreview.LocalReport
                ' .ReportPath = "bin\Debug\rptCart.rdlc"
                .ReportPath = Application.StartupPath & "/rptCart.rdlc"
                .DataSources.Clear()

            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter
            da.SelectCommand = New MySqlCommand(sql, cn)
            da.Fill(ds.Tables("dtCart"))

            Dim pAmount As New ReportParameter("pAmount", amount)
            Dim pTotal As New ReportParameter("pTotal", total)

            rvPrintPreview.LocalReport.SetParameters(pAmount)
            rvPrintPreview.LocalReport.SetParameters(pTotal)
            rptds = New ReportDataSource("DataSet1", ds.Tables("dtCart"))
            rvPrintPreview.LocalReport.DataSources.Add(rptds)
            rvPrintPreview.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)


        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

End Class