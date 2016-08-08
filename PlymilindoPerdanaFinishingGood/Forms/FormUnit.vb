Public Class FormUnit
    Private Sub MstUnitBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstUnitBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstUnitBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetUnit)

    End Sub

    Private Sub FormUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetUnit.mstUnit' table. You can move, or remove it, as needed.
        Me.MstUnitTableAdapter.Fill(Me.DataSetUnit.mstUnit)

    End Sub
End Class