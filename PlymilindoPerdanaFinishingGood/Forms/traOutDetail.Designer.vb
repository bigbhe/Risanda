<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class traOutDetail
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
        Dim RemainingQuantityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(traOutDetail))
        Me.DataSetOutDetail = New PlymilindoPerdanaFinishingGood.DataSetOutDetail()
        Me.TraOutDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraOutDetailTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetOutDetailTableAdapters.traOutDetailTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetOutDetailTableAdapters.TableAdapterManager()
        Me.TraOutDetailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TraOutDetailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TraOutDetailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GetItem2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GetRemainingQuantityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetRemainingQuantityTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetOutDetailTableAdapters.getRemainingQuantityTableAdapter()
        Me.GetRemainingQuantityGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colunit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivedItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveredItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemainingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.RemainingQuantityLabel1 = New System.Windows.Forms.Label()
        Me.UnitLabel1 = New System.Windows.Forms.Label()
        Me.idTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.codeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.itemLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.GetItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmountTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForcode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAmount = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GetItemTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetOutDetailTableAdapters.getItemTableAdapter()
        Me.GetItem2TableAdapter = New PlymilindoPerdanaFinishingGood.DataSetOutDetailTableAdapters.GetItem2TableAdapter()
        RemainingQuantityLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetOutDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraOutDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraOutDetailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TraOutDetailBindingNavigator.SuspendLayout()
        CType(Me.TraOutDetailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetItem2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetRemainingQuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetRemainingQuantityGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.codeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RemainingQuantityLabel
        '
        RemainingQuantityLabel.Location = New System.Drawing.Point(634, 36)
        RemainingQuantityLabel.Name = "RemainingQuantityLabel"
        RemainingQuantityLabel.Size = New System.Drawing.Size(169, 20)
        RemainingQuantityLabel.TabIndex = 7
        RemainingQuantityLabel.Text = "Remaining Quantity:"
        '
        'DataSetOutDetail
        '
        Me.DataSetOutDetail.DataSetName = "DataSetOutDetail"
        Me.DataSetOutDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TraOutDetailBindingSource
        '
        Me.TraOutDetailBindingSource.DataMember = "traOutDetail"
        Me.TraOutDetailBindingSource.DataSource = Me.DataSetOutDetail
        '
        'TraOutDetailTableAdapter
        '
        Me.TraOutDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.traOutDetailTableAdapter = Me.TraOutDetailTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetOutDetailTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TraOutDetailBindingNavigator
        '
        Me.TraOutDetailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TraOutDetailBindingNavigator.BindingSource = Me.TraOutDetailBindingSource
        Me.TraOutDetailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TraOutDetailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TraOutDetailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TraOutDetailBindingNavigatorSaveItem})
        Me.TraOutDetailBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TraOutDetailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TraOutDetailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TraOutDetailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TraOutDetailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TraOutDetailBindingNavigator.Name = "TraOutDetailBindingNavigator"
        Me.TraOutDetailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TraOutDetailBindingNavigator.Size = New System.Drawing.Size(988, 25)
        Me.TraOutDetailBindingNavigator.TabIndex = 0
        Me.TraOutDetailBindingNavigator.Text = "BindingNavigator1"
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
        'TraOutDetailBindingNavigatorSaveItem
        '
        Me.TraOutDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TraOutDetailBindingNavigatorSaveItem.Image = CType(resources.GetObject("TraOutDetailBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TraOutDetailBindingNavigatorSaveItem.Name = "TraOutDetailBindingNavigatorSaveItem"
        Me.TraOutDetailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TraOutDetailBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TraOutDetailGridControl
        '
        Me.TraOutDetailGridControl.DataSource = Me.TraOutDetailBindingSource
        Me.TraOutDetailGridControl.Location = New System.Drawing.Point(12, 60)
        Me.TraOutDetailGridControl.MainView = Me.GridView1
        Me.TraOutDetailGridControl.Name = "TraOutDetailGridControl"
        Me.TraOutDetailGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.TraOutDetailGridControl.Size = New System.Drawing.Size(964, 463)
        Me.TraOutDetailGridControl.TabIndex = 2
        Me.TraOutDetailGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colcode, Me.colitem, Me.colAmount})
        Me.GridView1.GridControl = Me.TraOutDetailGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colcode
        '
        Me.colcode.FieldName = "code"
        Me.colcode.Name = "colcode"
        '
        'colitem
        '
        Me.colitem.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colitem.FieldName = "item"
        Me.colitem.Name = "colitem"
        Me.colitem.Visible = True
        Me.colitem.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.GetItem2BindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'GetItem2BindingSource
        '
        Me.GetItem2BindingSource.DataMember = "GetItem2"
        Me.GetItem2BindingSource.DataSource = Me.DataSetOutDetail
        '
        'colAmount
        '
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 1
        '
        'GetRemainingQuantityBindingSource
        '
        Me.GetRemainingQuantityBindingSource.DataMember = "getRemainingQuantity"
        Me.GetRemainingQuantityBindingSource.DataSource = Me.DataSetOutDetail
        '
        'GetRemainingQuantityTableAdapter
        '
        Me.GetRemainingQuantityTableAdapter.ClearBeforeFill = True
        '
        'GetRemainingQuantityGridControl
        '
        Me.GetRemainingQuantityGridControl.DataSource = Me.GetRemainingQuantityBindingSource
        Me.GetRemainingQuantityGridControl.Location = New System.Drawing.Point(801, 309)
        Me.GetRemainingQuantityGridControl.MainView = Me.GridView2
        Me.GetRemainingQuantityGridControl.Name = "GetRemainingQuantityGridControl"
        Me.GetRemainingQuantityGridControl.Size = New System.Drawing.Size(113, 83)
        Me.GetRemainingQuantityGridControl.TabIndex = 3
        Me.GetRemainingQuantityGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid1, Me.colname, Me.colunit, Me.colReceivedItem, Me.colDeliveredItem, Me.colRemainingQuantity})
        Me.GridView2.GridControl = Me.GetRemainingQuantityGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colid1
        '
        Me.colid1.FieldName = "id"
        Me.colid1.Name = "colid1"
        Me.colid1.Visible = True
        Me.colid1.VisibleIndex = 0
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 1
        '
        'colunit
        '
        Me.colunit.FieldName = "unit"
        Me.colunit.Name = "colunit"
        Me.colunit.Visible = True
        Me.colunit.VisibleIndex = 2
        '
        'colReceivedItem
        '
        Me.colReceivedItem.FieldName = "ReceivedItem"
        Me.colReceivedItem.Name = "colReceivedItem"
        Me.colReceivedItem.Visible = True
        Me.colReceivedItem.VisibleIndex = 3
        '
        'colDeliveredItem
        '
        Me.colDeliveredItem.FieldName = "DeliveredItem"
        Me.colDeliveredItem.Name = "colDeliveredItem"
        Me.colDeliveredItem.Visible = True
        Me.colDeliveredItem.VisibleIndex = 4
        '
        'colRemainingQuantity
        '
        Me.colRemainingQuantity.FieldName = "RemainingQuantity"
        Me.colRemainingQuantity.Name = "colRemainingQuantity"
        Me.colRemainingQuantity.Visible = True
        Me.colRemainingQuantity.VisibleIndex = 5
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.RemainingQuantityLabel1)
        Me.DataLayoutControl1.Controls.Add(Me.UnitLabel1)
        Me.DataLayoutControl1.Controls.Add(Me.TraOutDetailGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idTextEdit)
        Me.DataLayoutControl1.Controls.Add(RemainingQuantityLabel)
        Me.DataLayoutControl1.Controls.Add(Me.codeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.itemLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AmountTextEdit)
        Me.DataLayoutControl1.DataSource = Me.TraOutDetailBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid, Me.ItemForcode})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 276, 250, 325)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(988, 535)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'RemainingQuantityLabel1
        '
        Me.RemainingQuantityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetRemainingQuantityBindingSource, "RemainingQuantity", True))
        Me.RemainingQuantityLabel1.Location = New System.Drawing.Point(807, 36)
        Me.RemainingQuantityLabel1.Name = "RemainingQuantityLabel1"
        Me.RemainingQuantityLabel1.Size = New System.Drawing.Size(169, 20)
        Me.RemainingQuantityLabel1.TabIndex = 8
        Me.RemainingQuantityLabel1.Text = "Label1"
        '
        'UnitLabel1
        '
        Me.UnitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetRemainingQuantityBindingSource, "unit", True))
        Me.UnitLabel1.Location = New System.Drawing.Point(289, 36)
        Me.UnitLabel1.Name = "UnitLabel1"
        Me.UnitLabel1.Size = New System.Drawing.Size(341, 20)
        Me.UnitLabel1.TabIndex = 6
        Me.UnitLabel1.Text = "Label1"
        '
        'idTextEdit
        '
        Me.idTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraOutDetailBindingSource, "id", True))
        Me.idTextEdit.Location = New System.Drawing.Point(52, 12)
        Me.idTextEdit.Name = "idTextEdit"
        Me.idTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idTextEdit.Properties.Mask.EditMask = "N0"
        Me.idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idTextEdit.Size = New System.Drawing.Size(509, 20)
        Me.idTextEdit.StyleController = Me.DataLayoutControl1
        Me.idTextEdit.TabIndex = 4
        '
        'codeTextEdit
        '
        Me.codeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraOutDetailBindingSource, "code", True))
        Me.codeTextEdit.Location = New System.Drawing.Point(52, 12)
        Me.codeTextEdit.Name = "codeTextEdit"
        Me.codeTextEdit.Size = New System.Drawing.Size(509, 20)
        Me.codeTextEdit.StyleController = Me.DataLayoutControl1
        Me.codeTextEdit.TabIndex = 5
        '
        'itemLookUpEdit
        '
        Me.itemLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraOutDetailBindingSource, "item", True))
        Me.itemLookUpEdit.Location = New System.Drawing.Point(52, 12)
        Me.itemLookUpEdit.Name = "itemLookUpEdit"
        Me.itemLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.itemLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.itemLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemLookUpEdit.Properties.DataSource = Me.GetItemBindingSource
        Me.itemLookUpEdit.Properties.DisplayMember = "name"
        Me.itemLookUpEdit.Properties.NullText = ""
        Me.itemLookUpEdit.Properties.ValueMember = "id"
        Me.itemLookUpEdit.Size = New System.Drawing.Size(924, 20)
        Me.itemLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.itemLookUpEdit.TabIndex = 6
        '
        'GetItemBindingSource
        '
        Me.GetItemBindingSource.DataMember = "getItem"
        Me.GetItemBindingSource.DataSource = Me.DataSetOutDetail
        '
        'AmountTextEdit
        '
        Me.AmountTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TraOutDetailBindingSource, "Amount", True))
        Me.AmountTextEdit.Location = New System.Drawing.Point(52, 36)
        Me.AmountTextEdit.Name = "AmountTextEdit"
        Me.AmountTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.AmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.AmountTextEdit.Properties.Mask.EditMask = "N0"
        Me.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.AmountTextEdit.Size = New System.Drawing.Size(233, 20)
        Me.AmountTextEdit.StyleController = Me.DataLayoutControl1
        Me.AmountTextEdit.TabIndex = 7
        '
        'ItemForid
        '
        Me.ItemForid.Control = Me.idTextEdit
        Me.ItemForid.Location = New System.Drawing.Point(0, 0)
        Me.ItemForid.Name = "ItemForid"
        Me.ItemForid.Size = New System.Drawing.Size(553, 24)
        Me.ItemForid.Text = "id"
        Me.ItemForid.TextSize = New System.Drawing.Size(37, 13)
        '
        'ItemForcode
        '
        Me.ItemForcode.Control = Me.codeTextEdit
        Me.ItemForcode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForcode.Name = "ItemForcode"
        Me.ItemForcode.Size = New System.Drawing.Size(553, 24)
        Me.ItemForcode.Text = "code"
        Me.ItemForcode.TextSize = New System.Drawing.Size(37, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(988, 535)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForitem, Me.ItemForAmount, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(968, 515)
        '
        'ItemForitem
        '
        Me.ItemForitem.Control = Me.itemLookUpEdit
        Me.ItemForitem.Location = New System.Drawing.Point(0, 0)
        Me.ItemForitem.Name = "ItemForitem"
        Me.ItemForitem.Size = New System.Drawing.Size(968, 24)
        Me.ItemForitem.Text = "item"
        Me.ItemForitem.TextSize = New System.Drawing.Size(37, 13)
        '
        'ItemForAmount
        '
        Me.ItemForAmount.Control = Me.AmountTextEdit
        Me.ItemForAmount.Location = New System.Drawing.Point(0, 24)
        Me.ItemForAmount.Name = "ItemForAmount"
        Me.ItemForAmount.Size = New System.Drawing.Size(277, 24)
        Me.ItemForAmount.Text = "Amount"
        Me.ItemForAmount.TextSize = New System.Drawing.Size(37, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TraOutDetailGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(968, 467)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.UnitLabel1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(277, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(345, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = RemainingQuantityLabel
        Me.LayoutControlItem3.Location = New System.Drawing.Point(622, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.RemainingQuantityLabel1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(795, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(173, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'GetItemTableAdapter
        '
        Me.GetItemTableAdapter.ClearBeforeFill = True
        '
        'GetItem2TableAdapter
        '
        Me.GetItem2TableAdapter.ClearBeforeFill = True
        '
        'traOutDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 560)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.GetRemainingQuantityGridControl)
        Me.Controls.Add(Me.TraOutDetailBindingNavigator)
        Me.Name = "traOutDetail"
        Me.Text = "traOutDetail"
        CType(Me.DataSetOutDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraOutDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraOutDetailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TraOutDetailBindingNavigator.ResumeLayout(False)
        Me.TraOutDetailBindingNavigator.PerformLayout()
        CType(Me.TraOutDetailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetItem2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetRemainingQuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetRemainingQuantityGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.codeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmountTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetOutDetail As DataSetOutDetail
    Friend WithEvents TraOutDetailBindingSource As BindingSource
    Friend WithEvents TraOutDetailTableAdapter As DataSetOutDetailTableAdapters.traOutDetailTableAdapter
    Friend WithEvents TableAdapterManager As DataSetOutDetailTableAdapters.TableAdapterManager
    Friend WithEvents TraOutDetailBindingNavigator As BindingNavigator
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
    Friend WithEvents TraOutDetailBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TraOutDetailGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colid As Columns.GridColumn
    Friend WithEvents colcode As Columns.GridColumn
    Friend WithEvents colitem As Columns.GridColumn
    Friend WithEvents colAmount As Columns.GridColumn
    Friend WithEvents GetRemainingQuantityBindingSource As BindingSource
    Friend WithEvents GetRemainingQuantityTableAdapter As DataSetOutDetailTableAdapters.getRemainingQuantityTableAdapter
    Friend WithEvents GetRemainingQuantityGridControl As GridControl
    Friend WithEvents GridView2 As Views.Grid.GridView
    Friend WithEvents colid1 As Columns.GridColumn
    Friend WithEvents colname As Columns.GridColumn
    Friend WithEvents colunit As Columns.GridColumn
    Friend WithEvents colReceivedItem As Columns.GridColumn
    Friend WithEvents colDeliveredItem As Columns.GridColumn
    Friend WithEvents colRemainingQuantity As Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idTextEdit As TextEdit
    Friend WithEvents codeTextEdit As TextEdit
    Friend WithEvents itemLookUpEdit As LookUpEdit
    Friend WithEvents AmountTextEdit As TextEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForid As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForcode As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForitem As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAmount As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents UnitLabel1 As Label
    Friend WithEvents RemainingQuantityLabel1 As Label
    Friend WithEvents GetItemBindingSource As BindingSource
    Friend WithEvents GetItemTableAdapter As DataSetOutDetailTableAdapters.getItemTableAdapter
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemLookUpEdit1 As XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GetItem2BindingSource As BindingSource
    Friend WithEvents GetItem2TableAdapter As DataSetOutDetailTableAdapters.GetItem2TableAdapter
End Class
