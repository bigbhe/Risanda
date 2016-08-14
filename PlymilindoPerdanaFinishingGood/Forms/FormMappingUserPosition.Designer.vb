<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMappingUserPosition
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMappingUserPosition))
        Me.DataSetMappingUser = New PlymilindoPerdanaFinishingGood.DataSetMappingUser()
        Me.MapUserPositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MapUserPositionTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetMappingUserTableAdapters.mapUserPositionTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetMappingUserTableAdapters.TableAdapterManager()
        Me.MapUserPositionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.MapUserPositionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MapUserPositionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coluserId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpositionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GetUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetUserTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetMappingUserTableAdapters.getUserTableAdapter()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectMstPositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectMstPositionTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetMappingUserTableAdapters.selectMstPositionTableAdapter()
        CType(Me.DataSetMappingUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapUserPositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapUserPositionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MapUserPositionBindingNavigator.SuspendLayout()
        CType(Me.MapUserPositionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectMstPositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetMappingUser
        '
        Me.DataSetMappingUser.DataSetName = "DataSetMappingUser"
        Me.DataSetMappingUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MapUserPositionBindingSource
        '
        Me.MapUserPositionBindingSource.DataMember = "mapUserPosition"
        Me.MapUserPositionBindingSource.DataSource = Me.DataSetMappingUser
        '
        'MapUserPositionTableAdapter
        '
        Me.MapUserPositionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mapUserPositionTableAdapter = Me.MapUserPositionTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetMappingUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MapUserPositionBindingNavigator
        '
        Me.MapUserPositionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MapUserPositionBindingNavigator.BindingSource = Me.MapUserPositionBindingSource
        Me.MapUserPositionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MapUserPositionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MapUserPositionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MapUserPositionBindingNavigatorSaveItem})
        Me.MapUserPositionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MapUserPositionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MapUserPositionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MapUserPositionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MapUserPositionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MapUserPositionBindingNavigator.Name = "MapUserPositionBindingNavigator"
        Me.MapUserPositionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MapUserPositionBindingNavigator.Size = New System.Drawing.Size(779, 25)
        Me.MapUserPositionBindingNavigator.TabIndex = 0
        Me.MapUserPositionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MapUserPositionBindingNavigatorSaveItem
        '
        Me.MapUserPositionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MapUserPositionBindingNavigatorSaveItem.Image = CType(resources.GetObject("MapUserPositionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MapUserPositionBindingNavigatorSaveItem.Name = "MapUserPositionBindingNavigatorSaveItem"
        Me.MapUserPositionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MapUserPositionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MapUserPositionGridControl
        '
        Me.MapUserPositionGridControl.DataSource = Me.MapUserPositionBindingSource
        Me.MapUserPositionGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MapUserPositionGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MapUserPositionGridControl.MainView = Me.GridView1
        Me.MapUserPositionGridControl.Name = "MapUserPositionGridControl"
        Me.MapUserPositionGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.MapUserPositionGridControl.Size = New System.Drawing.Size(779, 512)
        Me.MapUserPositionGridControl.TabIndex = 1
        Me.MapUserPositionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.coluserId, Me.colpositionID})
        Me.GridView1.GridControl = Me.MapUserPositionGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'coluserId
        '
        Me.coluserId.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.coluserId.FieldName = "userId"
        Me.coluserId.Name = "coluserId"
        Me.coluserId.Visible = True
        Me.coluserId.VisibleIndex = 0
        '
        'colpositionID
        '
        Me.colpositionID.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colpositionID.FieldName = "positionID"
        Me.colpositionID.Name = "colpositionID"
        Me.colpositionID.Visible = True
        Me.colpositionID.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.GetUserBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "fullname"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "idUser"
        '
        'GetUserBindingSource
        '
        Me.GetUserBindingSource.DataMember = "getUser"
        Me.GetUserBindingSource.DataSource = Me.DataSetMappingUser
        '
        'GetUserTableAdapter
        '
        Me.GetUserTableAdapter.ClearBeforeFill = True
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.SelectMstPositionBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Name"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "id"
        '
        'SelectMstPositionBindingSource
        '
        Me.SelectMstPositionBindingSource.DataMember = "selectMstPosition"
        Me.SelectMstPositionBindingSource.DataSource = Me.DataSetMappingUser
        '
        'SelectMstPositionTableAdapter
        '
        Me.SelectMstPositionTableAdapter.ClearBeforeFill = True
        '
        'FormMappingUserPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 537)
        Me.Controls.Add(Me.MapUserPositionGridControl)
        Me.Controls.Add(Me.MapUserPositionBindingNavigator)
        Me.Name = "FormMappingUserPosition"
        Me.Text = "FormMappingUserPosition"
        CType(Me.DataSetMappingUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapUserPositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapUserPositionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MapUserPositionBindingNavigator.ResumeLayout(False)
        Me.MapUserPositionBindingNavigator.PerformLayout()
        CType(Me.MapUserPositionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectMstPositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetMappingUser As DataSetMappingUser
    Friend WithEvents MapUserPositionBindingSource As BindingSource
    Friend WithEvents MapUserPositionTableAdapter As DataSetMappingUserTableAdapters.mapUserPositionTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMappingUserTableAdapters.TableAdapterManager
    Friend WithEvents MapUserPositionBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MapUserPositionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MapUserPositionGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colid As Columns.GridColumn
    Friend WithEvents coluserId As Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colpositionID As Columns.GridColumn
    Friend WithEvents GetUserBindingSource As BindingSource
    Friend WithEvents GetUserTableAdapter As DataSetMappingUserTableAdapters.getUserTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SelectMstPositionBindingSource As BindingSource
    Friend WithEvents SelectMstPositionTableAdapter As DataSetMappingUserTableAdapters.selectMstPositionTableAdapter
End Class
