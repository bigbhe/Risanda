Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class FormTraOutHeader
    Private finalCode As String
    Private Sub TraOutHeaderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TraOutHeaderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TraOutHeaderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetTraOutHeader)

    End Sub

    Private Sub FormTraOutHeader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetTraOutHeader.getCustomer' table. You can move, or remove it, as needed.
        Me.GetCustomerTableAdapter.Fill(Me.DataSetTraOutHeader.getCustomer)
        'TODO: This line of code loads data into the 'DataSetCustomer.mstCustomer' table. You can move, or remove it, as needed.
        Me.MstCustomerTableAdapter.Fill(Me.DataSetCustomer.mstCustomer)
        'TODO: This line of code loads data into the 'DataSetTraOutHeader.traOutHeader' table. You can move, or remove it, as needed.
        Me.TraOutHeaderTableAdapter.Fill(Me.DataSetTraOutHeader.traOutHeader)
        ToolStripButton1.Text = "FIll Detail Data"
    End Sub

    Public Shared Function GetUniqueKey(ByVal MaxSize As Integer) As String
        Dim chars As Char() = New Char(61) {}
        chars = "123456789".ToCharArray()
        Dim data As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(data)
        data = New Byte(MaxSize - 1) {}
        crypto.GetNonZeroBytes(data)
        Dim result As New StringBuilder(MaxSize)
        For Each b As Byte In data
            result.Append(chars(b Mod (chars.Length)))
        Next
        Return result.ToString()
    End Function

    Private Sub GetCodeTransactionOut()
        Dim code As String
        Dim trimmedCode As String
        code = Date.Today
        trimmedCode = Replace(code, "/", "")
        finalCode = String.Format("TO/{0}/{1}", trimmedCode, GetUniqueKey(3))
    End Sub



    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs)
        GetCodeTransactionOut()
        GridView1.SetFocusedRowCellValue(colcode, finalCode)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        otraOut.code = GridView1.GetFocusedRowCellValue(colcode)
        traOutDetail.ShowDialog()

    End Sub

    Private Sub loadReport()

        otraOut.code = GridView1.GetFocusedRowCellValue(colcode)
        Try
            Me.ReportDeliveryPerNumberTableAdapter.Fill(Me.DataSetTraOutHeader.reportDeliveryPerNumber, otraOut.code)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        Dim report As New ReportDeliveryPerNumber With {.DataSource = DataSetTraOutHeader.Tables("reportDeliveryPerNumber"), .DataMember = "reportDeliveryPerNumber"}
        Dim Tools As New ReportPrintTool(report)
        Tools.ShowPreview()


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        loadReport()
    End Sub
End Class