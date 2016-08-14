Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Public Class traOutDetail
    Private idItemRemaining As Integer



    Private Sub TraOutDetailBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TraOutDetailBindingNavigatorSaveItem.Click, TraOutDetailBindingNavigatorSaveItem.Click, TraOutDetailBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TraOutDetailBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSetOutDetail)
        Catch ex As Exception
            If ex.Message.ToString.ToLower.Contains("unique") Then
                Beep()
                alertDialogUc(Me, "Data Must be unique")
            End If
        End Try


    End Sub

    Sub LoadData()
        Try
            Me.TraOutDetailTableAdapter.Fill(Me.DataSetOutDetail.traOutDetail, otraOut.code)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub traOutDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetOutDetail.GetItem2' table. You can move, or remove it, as needed.
        Me.GetItem2TableAdapter.Fill(Me.DataSetOutDetail.GetItem2)
        'TODO: This line of code loads data into the 'DataSetOutDetail.getItem' table. You can move, or remove it, as needed.
        Me.GetItemTableAdapter.Fill(Me.DataSetOutDetail.getItem)
        LoadData()
        FormAddMode = False
    End Sub

    Private Sub loadRemaining()
        Try
            Me.GetRemainingQuantityTableAdapter.Fill(Me.DataSetOutDetail.getRemainingQuantity, New System.Nullable(Of Integer)(CType(itemLookUpEdit.EditValue, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colcode, otraOut.code)
    End Sub

    Private Sub itemLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles itemLookUpEdit.EditValueChanged
        If IsDBNull(itemLookUpEdit.EditValue) Then
            itemLookUpEdit.EditValue = 0
        End If
        loadRemaining()
    End Sub


End Class