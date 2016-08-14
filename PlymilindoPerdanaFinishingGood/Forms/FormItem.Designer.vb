<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormItem))
        Me.DataSetItem = New PlymilindoPerdanaFinishingGood.DataSetItem()
        Me.MstItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstItemTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetItemTableAdapters.mstItemTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetItemTableAdapters.TableAdapterManager()
        Me.MstItemBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstItemBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstItemGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditCategory = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCategory = New PlymilindoPerdanaFinishingGood.DataSetCategory()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colunit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditUnit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MstUnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetUnit = New PlymilindoPerdanaFinishingGood.DataSetUnit()
        Me.LookUpEditCOde = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.codeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.nameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.unitTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.idCategoryTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForcode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForname = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForunit = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MstCategoryTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetCategoryTableAdapters.mstCategoryTableAdapter()
        Me.MstUnitTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetUnitTableAdapters.mstUnitTableAdapter()
        CType(Me.DataSetItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstItemBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstItemBindingNavigator.SuspendLayout()
        CType(Me.MstItemGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstUnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditCOde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.codeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForunit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetItem
        '
        Me.DataSetItem.DataSetName = "DataSetItem"
        Me.DataSetItem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstItemBindingSource
        '
        Me.MstItemBindingSource.DataMember = "mstItem"
        Me.MstItemBindingSource.DataSource = Me.DataSetItem
        '
        'MstItemTableAdapter
        '
        Me.MstItemTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstItemTableAdapter = Me.MstItemTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetItemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstItemBindingNavigator
        '
        Me.MstItemBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstItemBindingNavigator.BindingSource = Me.MstItemBindingSource
        Me.MstItemBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstItemBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstItemBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstItemBindingNavigatorSaveItem})
        Me.MstItemBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstItemBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstItemBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstItemBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstItemBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstItemBindingNavigator.Name = "MstItemBindingNavigator"
        Me.MstItemBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstItemBindingNavigator.Size = New System.Drawing.Size(1109, 25)
        Me.MstItemBindingNavigator.TabIndex = 0
        Me.MstItemBindingNavigator.Text = "BindingNavigator1"
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
        'MstItemBindingNavigatorSaveItem
        '
        Me.MstItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstItemBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstItemBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstItemBindingNavigatorSaveItem.Name = "MstItemBindingNavigatorSaveItem"
        Me.MstItemBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstItemBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstItemGridControl
        '
        Me.MstItemGridControl.DataSource = Me.MstItemBindingSource
        Me.MstItemGridControl.Location = New System.Drawing.Point(256, 12)
        Me.MstItemGridControl.MainView = Me.GridView1
        Me.MstItemGridControl.Name = "MstItemGridControl"
        Me.MstItemGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditCOde, Me.LookUpEditCategory, Me.LookUpEditUnit})
        Me.MstItemGridControl.Size = New System.Drawing.Size(837, 447)
        Me.MstItemGridControl.TabIndex = 1
        Me.MstItemGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colcode, Me.colidCategory, Me.colname, Me.colunit})
        Me.GridView1.GridControl = Me.MstItemGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
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
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 0
        '
        'colidCategory
        '
        Me.colidCategory.ColumnEdit = Me.LookUpEditCategory
        Me.colidCategory.FieldName = "idCategory"
        Me.colidCategory.Name = "colidCategory"
        Me.colidCategory.Visible = True
        Me.colidCategory.VisibleIndex = 1
        '
        'LookUpEditCategory
        '
        Me.LookUpEditCategory.AutoHeight = False
        Me.LookUpEditCategory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditCategory.DataSource = Me.MstCategoryBindingSource
        Me.LookUpEditCategory.DisplayMember = "Name"
        Me.LookUpEditCategory.Name = "LookUpEditCategory"
        Me.LookUpEditCategory.ValueMember = "id"
        '
        'MstCategoryBindingSource
        '
        Me.MstCategoryBindingSource.DataMember = "mstCategory"
        Me.MstCategoryBindingSource.DataSource = Me.DataSetCategory
        '
        'DataSetCategory
        '
        Me.DataSetCategory.DataSetName = "DataSetCategory"
        Me.DataSetCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 2
        '
        'colunit
        '
        Me.colunit.ColumnEdit = Me.LookUpEditUnit
        Me.colunit.FieldName = "unit"
        Me.colunit.Name = "colunit"
        Me.colunit.Visible = True
        Me.colunit.VisibleIndex = 3
        '
        'LookUpEditUnit
        '
        Me.LookUpEditUnit.AutoHeight = False
        Me.LookUpEditUnit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditUnit.DataSource = Me.MstUnitBindingSource
        Me.LookUpEditUnit.DisplayMember = "unit"
        Me.LookUpEditUnit.Name = "LookUpEditUnit"
        Me.LookUpEditUnit.ValueMember = "id"
        '
        'MstUnitBindingSource
        '
        Me.MstUnitBindingSource.DataMember = "mstUnit"
        Me.MstUnitBindingSource.DataSource = Me.DataSetUnit
        '
        'DataSetUnit
        '
        Me.DataSetUnit.DataSetName = "DataSetUnit"
        Me.DataSetUnit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LookUpEditCOde
        '
        Me.LookUpEditCOde.AutoHeight = False
        Me.LookUpEditCOde.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditCOde.Name = "LookUpEditCOde"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.DataLayoutControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1109, 493)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.MstItemGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.codeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.nameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.unitTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idCategoryTextEdit)
        Me.DataLayoutControl1.DataSource = Me.MstItemBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 20)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(1105, 471)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idTextEdit
        '
        Me.idTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstItemBindingSource, "id", True))
        Me.idTextEdit.Location = New System.Drawing.Point(72, 12)
        Me.idTextEdit.Name = "idTextEdit"
        Me.idTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idTextEdit.Properties.Mask.EditMask = "N0"
        Me.idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idTextEdit.Size = New System.Drawing.Size(180, 20)
        Me.idTextEdit.StyleController = Me.DataLayoutControl1
        Me.idTextEdit.TabIndex = 4
        '
        'codeTextEdit
        '
        Me.codeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstItemBindingSource, "code", True))
        Me.codeTextEdit.Location = New System.Drawing.Point(71, 12)
        Me.codeTextEdit.Name = "codeTextEdit"
        Me.codeTextEdit.Properties.Mask.BeepOnError = True
        Me.codeTextEdit.Properties.Mask.EditMask = "\p{Lu}+"
        Me.codeTextEdit.Size = New System.Drawing.Size(181, 20)
        Me.codeTextEdit.StyleController = Me.DataLayoutControl1
        Me.codeTextEdit.TabIndex = 5
        '
        'nameTextEdit
        '
        Me.nameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstItemBindingSource, "name", True))
        Me.nameTextEdit.Location = New System.Drawing.Point(71, 60)
        Me.nameTextEdit.Name = "nameTextEdit"
        Me.nameTextEdit.Size = New System.Drawing.Size(181, 20)
        Me.nameTextEdit.StyleController = Me.DataLayoutControl1
        Me.nameTextEdit.TabIndex = 7
        '
        'unitTextEdit
        '
        Me.unitTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstItemBindingSource, "unit", True))
        Me.unitTextEdit.Location = New System.Drawing.Point(71, 84)
        Me.unitTextEdit.Name = "unitTextEdit"
        Me.unitTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.unitTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.unitTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.unitTextEdit.Properties.DataSource = Me.MstUnitBindingSource
        Me.unitTextEdit.Properties.DisplayMember = "unit"
        Me.unitTextEdit.Properties.NullText = ""
        Me.unitTextEdit.Properties.ValueMember = "id"
        Me.unitTextEdit.Size = New System.Drawing.Size(181, 20)
        Me.unitTextEdit.StyleController = Me.DataLayoutControl1
        Me.unitTextEdit.TabIndex = 8
        '
        'idCategoryTextEdit
        '
        Me.idCategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstItemBindingSource, "idCategory", True))
        Me.idCategoryTextEdit.Location = New System.Drawing.Point(71, 36)
        Me.idCategoryTextEdit.Name = "idCategoryTextEdit"
        Me.idCategoryTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idCategoryTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idCategoryTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idCategoryTextEdit.Properties.DataSource = Me.MstCategoryBindingSource
        Me.idCategoryTextEdit.Properties.DisplayMember = "Name"
        Me.idCategoryTextEdit.Properties.NullText = ""
        Me.idCategoryTextEdit.Properties.ValueMember = "id"
        Me.idCategoryTextEdit.Size = New System.Drawing.Size(181, 20)
        Me.idCategoryTextEdit.StyleController = Me.DataLayoutControl1
        Me.idCategoryTextEdit.TabIndex = 6
        '
        'ItemForid
        '
        Me.ItemForid.Control = Me.idTextEdit
        Me.ItemForid.Location = New System.Drawing.Point(0, 0)
        Me.ItemForid.Name = "ItemForid"
        Me.ItemForid.Size = New System.Drawing.Size(244, 24)
        Me.ItemForid.Text = "id"
        Me.ItemForid.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1105, 471)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForcode, Me.ItemForidCategory, Me.ItemForname, Me.ItemForunit, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1085, 451)
        '
        'ItemForcode
        '
        Me.ItemForcode.Control = Me.codeTextEdit
        Me.ItemForcode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForcode.Name = "ItemForcode"
        Me.ItemForcode.Size = New System.Drawing.Size(244, 24)
        Me.ItemForcode.Text = "code"
        Me.ItemForcode.TextSize = New System.Drawing.Size(56, 13)
        '
        'ItemForidCategory
        '
        Me.ItemForidCategory.Control = Me.idCategoryTextEdit
        Me.ItemForidCategory.Location = New System.Drawing.Point(0, 24)
        Me.ItemForidCategory.Name = "ItemForidCategory"
        Me.ItemForidCategory.Size = New System.Drawing.Size(244, 24)
        Me.ItemForidCategory.Text = "id Category"
        Me.ItemForidCategory.TextSize = New System.Drawing.Size(56, 13)
        '
        'ItemForname
        '
        Me.ItemForname.Control = Me.nameTextEdit
        Me.ItemForname.Location = New System.Drawing.Point(0, 48)
        Me.ItemForname.Name = "ItemForname"
        Me.ItemForname.Size = New System.Drawing.Size(244, 24)
        Me.ItemForname.Text = "name"
        Me.ItemForname.TextSize = New System.Drawing.Size(56, 13)
        '
        'ItemForunit
        '
        Me.ItemForunit.Control = Me.unitTextEdit
        Me.ItemForunit.Location = New System.Drawing.Point(0, 72)
        Me.ItemForunit.Name = "ItemForunit"
        Me.ItemForunit.Size = New System.Drawing.Size(244, 379)
        Me.ItemForunit.Text = "unit"
        Me.ItemForunit.TextSize = New System.Drawing.Size(56, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.MstItemGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(244, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(841, 451)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'MstCategoryTableAdapter
        '
        Me.MstCategoryTableAdapter.ClearBeforeFill = True
        '
        'MstUnitTableAdapter
        '
        Me.MstUnitTableAdapter.ClearBeforeFill = True
        '
        'FormItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 518)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.MstItemBindingNavigator)
        Me.Name = "FormItem"
        Me.Text = "FormItem"
        CType(Me.DataSetItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstItemBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstItemBindingNavigator.ResumeLayout(False)
        Me.MstItemBindingNavigator.PerformLayout()
        CType(Me.MstItemGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstUnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditCOde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.codeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idCategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForunit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetItem As DataSetItem
    Friend WithEvents MstItemBindingSource As BindingSource
    Friend WithEvents MstItemTableAdapter As DataSetItemTableAdapters.mstItemTableAdapter
    Friend WithEvents TableAdapterManager As DataSetItemTableAdapters.TableAdapterManager
    Friend WithEvents MstItemBindingNavigator As BindingNavigator
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
    Friend WithEvents MstItemBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstItemGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents colid As Columns.GridColumn
    Friend WithEvents colcode As Columns.GridColumn
    Friend WithEvents colidCategory As Columns.GridColumn
    Friend WithEvents colname As Columns.GridColumn
    Friend WithEvents colunit As Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idTextEdit As TextEdit
    Friend WithEvents codeTextEdit As TextEdit
    Friend WithEvents nameTextEdit As TextEdit
    Friend WithEvents unitTextEdit As LookUpEdit
    Friend WithEvents idCategoryTextEdit As LookUpEdit
    Friend WithEvents ItemForid As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForcode As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidCategory As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForname As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForunit As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents DataSetCategory As DataSetCategory
    Friend WithEvents MstCategoryBindingSource As BindingSource
    Friend WithEvents MstCategoryTableAdapter As DataSetCategoryTableAdapters.mstCategoryTableAdapter
    Friend WithEvents DataSetUnit As DataSetUnit
    Friend WithEvents MstUnitBindingSource As BindingSource
    Friend WithEvents MstUnitTableAdapter As DataSetUnitTableAdapters.mstUnitTableAdapter
    Friend WithEvents LookUpEditCategory As XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookUpEditUnit As XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookUpEditCOde As XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
