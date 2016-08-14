Imports DevExpress.XtraGrid.Views.Grid

Public Class FormItemList
    Private Sub FormItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetItem.ReportRemainingQuantity' table. You can move, or remove it, as needed.
        GridView1.BestFitColumns(True)
        Me.ReportRemainingQuantityTableAdapter.Fill(Me.DataSetItem.ReportRemainingQuantity)

    End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView1.RowStyle
        Dim view As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim RemainingQuantity As Integer
            RemainingQuantity = view.GetRowCellDisplayText(e.RowHandle, view.Columns("RemainingQuantity"))
            If RemainingQuantity = 0 Then
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.SeaShell
            End If
        End If
    End Sub
End Class