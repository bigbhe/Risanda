Imports DevExpress.XtraGrid.Views.Base

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
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        oTraReceive.idReceive = GridView1.GetFocusedRowCellValue(colid)
        oTraReceive.receiveData = GridView1.GetFocusedRowCellValue(coldate)
        FormReceiveDetail.ShowDialog()

    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        receiveNumber = GridView1.GetFocusedRowCellValue(colreceiveNumber)
        ToolStripButton1.Text = "Fill Receive Detail for Receive Iten Number: " & receiveNumber
    End Sub
End Class