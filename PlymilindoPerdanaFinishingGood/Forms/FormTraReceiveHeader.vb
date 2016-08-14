Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI

Public Class FormTraReceiveHeader

    Public receiveNumber As String

    Private Sub TraReceiveHeaderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TraReceiveHeaderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TraReceiveHeaderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetReceiveHeader)

    End Sub

    Private Sub FormTraReceiveHeader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetReceiveHeader.traReceiveHeader' table. You can move, or remove it, as needed.
        Me.TraReceiveHeaderTableAdapter.Fill(Me.DataSetReceiveHeader.traReceiveHeader)
        GridView1.BestFitColumns(True)
        ToolStripButton1.Text = "Fill Receive Detail"
        ToolStripButton2.Text = "Print Selected Receive Item"
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        If IsDBNull(GridView1.GetFocusedRowCellValue(colid)) Then
            Exit Sub
        Else
            oTraReceive.idReceive = GridView1.GetFocusedRowCellValue(colid)
            oTraReceive.receiveData = GridView1.GetFocusedRowCellValue(coldate)
            FormReceiveDetail.ShowDialog()
        End If


    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 1 Then
            If IsDBNull(GridView1.GetFocusedRowCellValue(colreceiveNumber)) Then
                receiveNumber = 0
            Else
                receiveNumber = GridView1.GetFocusedRowCellValue(colreceiveNumber)
            End If
            ToolStripButton1.Text = "Fill Receive Detail for Receive Iten Number: " & receiveNumber
        End If
    End Sub

    Private Sub report()
        Try
            Me.ReportReceivePerNumberTableAdapter.Fill(Me.DataSetReceiveHeader.reportReceivePerNumber, receiveNumber)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim report As New ReportReceivePerNumber With {.DataSource = DataSetReceiveHeader.Tables("reportReceivePerNumber"), .DataMember = "reportReceivePerNumber"}
        Dim Tools As New ReportPrintTool(report)
        Tools.ShowPreview()


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        report()

    End Sub
End Class