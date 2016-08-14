Public Class FormMappingUserPosition
    Private Sub MapUserPositionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MapUserPositionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MapUserPositionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetMappingUser)

    End Sub

    Private Sub FormMappingUserPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetMappingUser.selectMstPosition' table. You can move, or remove it, as needed.
        Me.SelectMstPositionTableAdapter.Fill(Me.DataSetMappingUser.selectMstPosition)
        'TODO: This line of code loads data into the 'DataSetMappingUser.getUser' table. You can move, or remove it, as needed.
        Me.GetUserTableAdapter.Fill(Me.DataSetMappingUser.getUser)
        'TODO: This line of code loads data into the 'DataSetMappingUser.mapUserPosition' table. You can move, or remove it, as needed.
        Me.MapUserPositionTableAdapter.Fill(Me.DataSetMappingUser.mapUserPosition)

    End Sub
End Class