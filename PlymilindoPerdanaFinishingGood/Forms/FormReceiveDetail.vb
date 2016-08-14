Imports DevExpress.XtraGrid.Views.Grid

Public Class FormReceiveDetail
    Private Sub TraReceiveDetailBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TraReceiveDetailBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TraReceiveDetailBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSetReceiveDetail)
        Catch ex As Exception
            If ex.Message.ToString.ToLower.Contains("constrained") Then
                Beep()
                alertDialogUc(Me, "Cannot Insert Duplicate Data")
            End If
        End Try


    End Sub

    Private Sub LoadData()

        Try
            Me.TraReceiveDetailTableAdapter.Fill(Me.DataSetReceiveDetail.traReceiveDetail, CType(oTraReceive.idReceive, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FormReceiveDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetReceiveDetail.selectItemCategory' table. You can move, or remove it, as needed.
        Me.SelectItemCategoryTableAdapter.Fill(Me.DataSetReceiveDetail.selectItemCategory)
        LoadData()
    End Sub


    Private Sub GridView1_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidReceiveHeader, oTraReceive.idReceive)

    End Sub
End Class