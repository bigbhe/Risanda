Imports DevExpress.XtraReports.UI

Public Class FormReportItemByDate
    Private Sub loadReport()
        If (DateEdit1.EditValue Is Nothing) Then
            alertDialogUc(Me, "Please Select Start Date before loading the report")
            Exit Sub
        End If
        If (DateEdit2.EditValue Is Nothing) Then
            alertDialogUc(Me, "Please Select End Date before loading the report")
            Exit Sub
        End If

        Try
            Me.ReportTransactionByDateTableAdapter.Fill(Me.DataSetReportItem.ReportTransactionByDate, New System.Nullable(Of Date)(CType(DateEdit1.EditValue, Date)), New System.Nullable(Of Date)(CType(DateEdit2.EditValue, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim Report As New ReportItemByDate With {.DataSource = DataSetReportItem.Tables("ReportTransactionByDate"), .DataMember = "ReportTransactionByDate"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        oReport.StartDate = DateEdit1.EditValue
        oReport.endDate = DateEdit2.EditValue
        loadReport()

    End Sub
End Class