<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReceiveDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReceiveDetail))
        Me.DataSetReceiveDetail = New PlymilindoPerdanaFinishingGood.DataSetReceiveDetail()
        Me.TraReceiveDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraReceiveDetailTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetReceiveDetailTableAdapters.traReceiveDetailTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetReceiveDetailTableAdapters.TableAdapterManager()
        Me.TraReceiveDetailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TraReceiveDetailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TraReceiveDetailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidReceiveHeader = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridLookUpItem = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SelectItemCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.idReceiveHeaderTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.amountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.itemIdTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForidReceiveHeader = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForitemId = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForamount = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SelectItemCategoryTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetReceiveDetailTableAdapters.selectItemCategoryTableAdapter()
        CType(Me.DataSetReceiveDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraReceiveDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraReceiveDetailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TraReceiveDetailBindingNavigator.SuspendLayout()
        CType(Me.TraReceiveDetailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridLookUpItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectItemCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idReceiveHeaderTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidReceiveHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForitemId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForamount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetReceiveDetail
        '
        Me.DataSetReceiveDetail.DataSetName = "DataSetReceiveDetail"
        Me.DataSetReceiveDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TraReceiveDetailBindingSource
        '
        Me.TraReceiveDetailBindingSource.DataMember = "traReceiveDetail"
        Me.TraReceiveDetailBindingSource.DataSource = Me.DataSetReceiveDetail
        '
        'TraReceiveDetailTableAdapter
        '
        Me.TraReceiveDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.traReceiveDetailTableAdapter = Me.TraReceiveDetailTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetReceiveDetailTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TraReceiveDetailBindingNavigator
        '
        Me.TraReceiveDetailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TraReceiveDetailBindingNavigator.BindingSource = Me.TraReceiveDetailBindingSource
        Me.TraReceiveDetailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TraReceiveDetailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TraReceiveDetailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TraReceiveDetailBindingNavigatorSaveItem})
        Me.TraReceiveDetailBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TraReceiveDetailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TraReceiveDetailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TraReceiveDetailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TraReceiveDetailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TraReceiveDetailBindingNavigator.Name = "TraReceiveDetailBindingNavigator"
        Me.TraReceiveDetailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TraReceiveDetailBindingNavigator.Size = New System.Drawing.Size(919, 25)
        Me.TraReceiveDetailBindingNavigator.TabIndex = 0
        Me.TraReceiveDetailBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TraReceiveDetailBindingNavigatorSaveItem
        '
        Me.TraReceiveDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TraReceiveDetailBindingNavigatorSaveItem.Image = CType(resources.GetObject("TraReceiveDetailBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TraReceiveDetailBindingNavigatorSaveItem.Name = "TraReceiveDetailBindingNavigatorSaveItem"
        Me.TraReceiveDetailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TraReceiveDetailBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TraReceiveDetailGridControl
        '
        Me.TraReceiveDetailGridControl.DataSource = Me.TraReceiveDetailBindingSource
        Me.TraReceiveDetailGridControl.Location = New System.Drawing.Point(351, 12)
        Me.TraReceiveDetailGridControl.MainView = Me.GridView1
        Me.TraReceiveDetailGridControl.Name = "TraReceiveDetailGridControl"
        Me.TraReceiveDetailGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.gridLookUpItem})
        Me.TraReceiveDetailGridControl.Size = New System.Drawing.Size(556, 542)
        Me.TraReceiveDetailGridControl.TabIndex = 2
        Me.TraReceiveDetailGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidReceiveHeader, Me.colitemId, Me.colamount})
        Me.GridView1.GridControl = Me.TraReceiveDetailGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidReceiveHeader
        '
        Me.colidReceiveHeader.FieldName = "idReceiveHeader"
        Me.colidReceiveHeader.Name = "colidReceiveHeader"
        '
        'colitemId
        '
        Me.colitemId.ColumnEdit = Me.gridLookUpItem
        Me.colitemId.FieldName = "itemId"
        Me.colitemId.Name = "colitemId"
        Me.colitemId.Visible = True
        Me.colitemId.VisibleIndex = 0
        '
        'gridLookUpItem
        '
        Me.gridLookUpItem.AutoHeight = False
        Me.gridLookUpItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridLookUpItem.DataSource = Me.SelectItemCategoryBindingSource
        Me.gridLookUpItem.DisplayMember = "ItemName"
        Me.gridLookUpItem.Name = "gridLookUpItem"
        Me.gridLookUpItem.ValueMember = "id"
        '
        'SelectItemCategoryBindingSource
        '
        Me.SelectItemCategoryBindingSource.DataMember = "selectItemCategory"
        Me.SelectItemCategoryBindingSource.DataSource = Me.DataSetReceiveDetail
        '
        'colamount
        '
        Me.colamount.FieldName = "amount"
        Me.colamount.Name = "colamount"
        Me.colamount.Visible = True
        Me.colamount.VisibleIndex = 1
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.TraReceiveDetailGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idReceiveHeaderTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.amountTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.itemIdTextEdit)
        Me.DataLayoutControl1.DataSource = Me.TraReceiveDetailBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidReceiveHeader, Me.ItemForid})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(919, 566)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idTextEdit
        '
        Me.idTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraReceiveDetailBindingSource, "id", True))
        Me.idTextEdit.Location = New System.Drawing.Point(52, 12)
        Me.idTextEdit.Name = "idTextEdit"
        Me.idTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idTextEdit.Properties.Mask.EditMask = "N0"
        Me.idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idTextEdit.Size = New System.Drawing.Size(295, 20)
        Me.idTextEdit.StyleController = Me.DataLayoutControl1
        Me.idTextEdit.TabIndex = 4
        '
        'idReceiveHeaderTextEdit
        '
        Me.idReceiveHeaderTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraReceiveDetailBindingSource, "idReceiveHeader", True))
        Me.idReceiveHeaderTextEdit.Location = New System.Drawing.Point(102, 36)
        Me.idReceiveHeaderTextEdit.Name = "idReceiveHeaderTextEdit"
        Me.idReceiveHeaderTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idReceiveHeaderTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idReceiveHeaderTextEdit.Properties.Mask.EditMask = "N0"
        Me.idReceiveHeaderTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idReceiveHeaderTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idReceiveHeaderTextEdit.Size = New System.Drawing.Size(245, 20)
        Me.idReceiveHeaderTextEdit.StyleController = Me.DataLayoutControl1
        Me.idReceiveHeaderTextEdit.TabIndex = 5
        '
        'amountTextEdit
        '
        Me.amountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraReceiveDetailBindingSource, "amount", True))
        Me.amountTextEdit.Location = New System.Drawing.Point(52, 36)
        Me.amountTextEdit.Name = "amountTextEdit"
        Me.amountTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.amountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.amountTextEdit.Properties.Mask.EditMask = "N0"
        Me.amountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.amountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.amountTextEdit.Size = New System.Drawing.Size(295, 20)
        Me.amountTextEdit.StyleController = Me.DataLayoutControl1
        Me.amountTextEdit.TabIndex = 7
        '
        'itemIdTextEdit
        '
        Me.itemIdTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraReceiveDetailBindingSource, "itemId", True))
        Me.itemIdTextEdit.Location = New System.Drawing.Point(52, 12)
        Me.itemIdTextEdit.Name = "itemIdTextEdit"
        Me.itemIdTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.itemIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.itemIdTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemIdTextEdit.Properties.DataSource = Me.SelectItemCategoryBindingSource
        Me.itemIdTextEdit.Properties.DisplayMember = "ItemName"
        Me.itemIdTextEdit.Properties.NullText = ""
        Me.itemIdTextEdit.Properties.ValueMember = "id"
        Me.itemIdTextEdit.Size = New System.Drawing.Size(295, 20)
        Me.itemIdTextEdit.StyleController = Me.DataLayoutControl1
        Me.itemIdTextEdit.TabIndex = 6
        '
        'ItemForidReceiveHeader
        '
        Me.ItemForidReceiveHeader.Control = Me.idReceiveHeaderTextEdit
        Me.ItemForidReceiveHeader.Location = New System.Drawing.Point(0, 24)
        Me.ItemForidReceiveHeader.Name = "ItemForidReceiveHeader"
        Me.ItemForidReceiveHeader.Size = New System.Drawing.Size(339, 24)
        Me.ItemForidReceiveHeader.Text = "id Receive Header"
        Me.ItemForidReceiveHeader.TextSize = New System.Drawing.Size(87, 13)
        '
        'ItemForid
        '
        Me.ItemForid.Control = Me.idTextEdit
        Me.ItemForid.Location = New System.Drawing.Point(0, 0)
        Me.ItemForid.Name = "ItemForid"
        Me.ItemForid.Size = New System.Drawing.Size(339, 24)
        Me.ItemForid.Text = "id"
        Me.ItemForid.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(919, 566)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForitemId, Me.ItemForamount, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(899, 546)
        '
        'ItemForitemId
        '
        Me.ItemForitemId.Control = Me.itemIdTextEdit
        Me.ItemForitemId.Location = New System.Drawing.Point(0, 0)
        Me.ItemForitemId.Name = "ItemForitemId"
        Me.ItemForitemId.Size = New System.Drawing.Size(339, 24)
        Me.ItemForitemId.Text = "Item"
        Me.ItemForitemId.TextSize = New System.Drawing.Size(37, 13)
        '
        'ItemForamount
        '
        Me.ItemForamount.Control = Me.amountTextEdit
        Me.ItemForamount.Location = New System.Drawing.Point(0, 24)
        Me.ItemForamount.Name = "ItemForamount"
        Me.ItemForamount.Size = New System.Drawing.Size(339, 522)
        Me.ItemForamount.Text = "Amount"
        Me.ItemForamount.TextSize = New System.Drawing.Size(37, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TraReceiveDetailGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(339, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(560, 546)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'SelectItemCategoryTableAdapter
        '
        Me.SelectItemCategoryTableAdapter.ClearBeforeFill = True
        '
        'FormReceiveDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 591)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.TraReceiveDetailBindingNavigator)
        Me.Name = "FormReceiveDetail"
        Me.Text = "FormReceiveDetail"
        CType(Me.DataSetReceiveDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraReceiveDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraReceiveDetailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TraReceiveDetailBindingNavigator.ResumeLayout(False)
        Me.TraReceiveDetailBindingNavigator.PerformLayout()
        CType(Me.TraReceiveDetailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridLookUpItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectItemCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idReceiveHeaderTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidReceiveHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForitemId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForamount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetReceiveDetail As DataSetReceiveDetail
    Friend WithEvents TraReceiveDetailBindingSource As BindingSource
    Friend WithEvents TraReceiveDetailTableAdapter As DataSetReceiveDetailTableAdapters.traReceiveDetailTableAdapter
    Friend WithEvents TableAdapterManager As DataSetReceiveDetailTableAdapters.TableAdapterManager
    Friend WithEvents TraReceiveDetailBindingNavigator As BindingNavigator
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
    Friend WithEvents TraReceiveDetailBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TraReceiveDetailGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colid As Columns.GridColumn
    Friend WithEvents colidReceiveHeader As Columns.GridColumn
    Friend WithEvents colitemId As Columns.GridColumn
    Friend WithEvents colamount As Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idTextEdit As TextEdit
    Friend WithEvents idReceiveHeaderTextEdit As TextEdit
    Friend WithEvents amountTextEdit As TextEdit
    Friend WithEvents itemIdTextEdit As LookUpEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForid As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidReceiveHeader As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForitemId As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForamount As XtraLayout.LayoutControlItem
    Friend WithEvents SelectItemCategoryBindingSource As BindingSource
    Friend WithEvents SelectItemCategoryTableAdapter As DataSetReceiveDetailTableAdapters.selectItemCategoryTableAdapter
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents gridLookUpItem As XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
