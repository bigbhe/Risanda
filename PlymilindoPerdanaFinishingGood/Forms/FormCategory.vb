Public Class FormCategory
    Private Sub MstCategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstCategoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstCategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCategory)

    End Sub

    Private Sub FormCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetCategory.mstCategory' table. You can move, or remove it, as needed.
        Me.MstCategoryTableAdapter.Fill(Me.DataSetCategory.mstCategory)

    End Sub

    Sub save()
        Me.Validate()
        Me.MstCategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCategory)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        save()

    End Sub
End Class