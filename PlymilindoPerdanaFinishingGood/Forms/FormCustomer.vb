Public Class FormCustomer
    Private Sub MstCustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstCustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MstCustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCustomer)

    End Sub

    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetCustomer.mstCustomer' table. You can move, or remove it, as needed.
        Me.MstCustomerTableAdapter.Fill(Me.DataSetCustomer.mstCustomer)

    End Sub
End Class