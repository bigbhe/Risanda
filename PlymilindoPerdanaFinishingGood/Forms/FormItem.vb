Public Class FormItem
    Private Sub MstItemBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstItemBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstItemBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetItem)

    End Sub

    Private Sub FormItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetUnit.mstUnit' table. You can move, or remove it, as needed.
        Me.MstUnitTableAdapter.Fill(Me.DataSetUnit.mstUnit)
        'TODO: This line of code loads data into the 'DataSetCategory.mstCategory' table. You can move, or remove it, as needed.
        Me.MstCategoryTableAdapter.Fill(Me.DataSetCategory.mstCategory)
        'TODO: This line of code loads data into the 'DataSetItem.mstItem' table. You can move, or remove it, as needed.
        Me.MstItemTableAdapter.Fill(Me.DataSetItem.mstItem)

    End Sub
End Class