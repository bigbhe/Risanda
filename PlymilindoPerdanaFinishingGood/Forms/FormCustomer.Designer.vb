<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomer))
        Me.MstCustomerGridControl = New DevExpress.XtraGrid.GridControl()
        Me.MstCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCustomer = New PlymilindoPerdanaFinishingGood.DataSetCustomer()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.idTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AddressMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.phoneNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.faximileTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.websiteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.logoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAddress = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForphoneNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForfaximile = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForwebsite = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForlogo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MstCustomerTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetCustomerTableAdapters.mstCustomerTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetCustomerTableAdapters.TableAdapterManager()
        Me.MstCustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstCustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.MstCustomerGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phoneNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.faximileTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.websiteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForphoneNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForfaximile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForwebsite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstCustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstCustomerBindingNavigator.SuspendLayout()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MstCustomerGridControl
        '
        Me.MstCustomerGridControl.DataSource = Me.MstCustomerBindingSource
        Me.MstCustomerGridControl.Location = New System.Drawing.Point(316, 12)
        Me.MstCustomerGridControl.MainView = Me.GridView1
        Me.MstCustomerGridControl.Name = "MstCustomerGridControl"
        Me.MstCustomerGridControl.Size = New System.Drawing.Size(573, 524)
        Me.MstCustomerGridControl.TabIndex = 0
        Me.MstCustomerGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MstCustomerBindingSource
        '
        Me.MstCustomerBindingSource.DataMember = "mstCustomer"
        Me.MstCustomerBindingSource.DataSource = Me.DataSetCustomer
        '
        'DataSetCustomer
        '
        Me.DataSetCustomer.DataSetName = "DataSetCustomer"
        Me.DataSetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.MstCustomerGridControl
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.DataLayoutControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(905, 570)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "GroupControl2"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.MstCustomerGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AddressMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.phoneNumberTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.faximileTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.websiteTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.logoPictureEdit)
        Me.DataLayoutControl1.DataSource = Me.MstCustomerBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 20)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(673, 361, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(901, 548)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'idTextEdit
        '
        Me.idTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstCustomerBindingSource, "id", True))
        Me.idTextEdit.Location = New System.Drawing.Point(85, 12)
        Me.idTextEdit.Name = "idTextEdit"
        Me.idTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idTextEdit.Properties.Mask.EditMask = "N0"
        Me.idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idTextEdit.Size = New System.Drawing.Size(227, 20)
        Me.idTextEdit.StyleController = Me.DataLayoutControl1
        Me.idTextEdit.TabIndex = 4
        '
        'NameTextEdit
        '
        Me.NameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstCustomerBindingSource, "Name", True))
        Me.NameTextEdit.Location = New System.Drawing.Point(85, 12)
        Me.NameTextEdit.Name = "NameTextEdit"
        Me.NameTextEdit.Size = New System.Drawing.Size(227, 20)
        Me.NameTextEdit.StyleController = Me.DataLayoutControl1
        Me.NameTextEdit.TabIndex = 5
        '
        'AddressMemoEdit
        '
        Me.AddressMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstCustomerBindingSource, "Address", True))
        Me.AddressMemoEdit.Location = New System.Drawing.Point(85, 36)
        Me.AddressMemoEdit.Name = "AddressMemoEdit"
        Me.AddressMemoEdit.Size = New System.Drawing.Size(227, 80)
        Me.AddressMemoEdit.StyleController = Me.DataLayoutControl1
        Me.AddressMemoEdit.TabIndex = 6
        '
        'phoneNumberTextEdit
        '
        Me.phoneNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstCustomerBindingSource, "phoneNumber", True))
        Me.phoneNumberTextEdit.Location = New System.Drawing.Point(85, 120)
        Me.phoneNumberTextEdit.Name = "phoneNumberTextEdit"
        Me.phoneNumberTextEdit.Properties.Mask.BeepOnError = True
        Me.phoneNumberTextEdit.Properties.Mask.EditMask = "(\d?\d?\d?) \d\d\d\d\d\d\d\d"
        Me.phoneNumberTextEdit.Properties.Mask.IgnoreMaskBlank = False
        Me.phoneNumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.phoneNumberTextEdit.Size = New System.Drawing.Size(227, 20)
        Me.phoneNumberTextEdit.StyleController = Me.DataLayoutControl1
        Me.phoneNumberTextEdit.TabIndex = 7
        '
        'faximileTextEdit
        '
        Me.faximileTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstCustomerBindingSource, "faximile", True))
        Me.faximileTextEdit.Location = New System.Drawing.Point(85, 144)
        Me.faximileTextEdit.Name = "faximileTextEdit"
        Me.faximileTextEdit.Properties.Mask.BeepOnError = True
        Me.faximileTextEdit.Properties.Mask.EditMask = "(\d?\d?\d?) \d\d\d\d\d\d\d\d"
        Me.faximileTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.faximileTextEdit.Size = New System.Drawing.Size(227, 20)
        Me.faximileTextEdit.StyleController = Me.DataLayoutControl1
        Me.faximileTextEdit.TabIndex = 8
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstCustomerBindingSource, "e-mail", True))
        Me.TextEdit1.Location = New System.Drawing.Point(85, 168)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Mask.EditMask = "(\w|[\.\-])+@(\w|[\-]+\.)*(\w|[\-]){2,63}\.[a-zA-Z]{2,4}"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.TextEdit1.Size = New System.Drawing.Size(227, 20)
        Me.TextEdit1.StyleController = Me.DataLayoutControl1
        Me.TextEdit1.TabIndex = 9
        '
        'websiteTextEdit
        '
        Me.websiteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstCustomerBindingSource, "website", True))
        Me.websiteTextEdit.Location = New System.Drawing.Point(85, 192)
        Me.websiteTextEdit.Name = "websiteTextEdit"
        Me.websiteTextEdit.Size = New System.Drawing.Size(227, 20)
        Me.websiteTextEdit.StyleController = Me.DataLayoutControl1
        Me.websiteTextEdit.TabIndex = 10
        '
        'logoPictureEdit
        '
        Me.logoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstCustomerBindingSource, "logo", True))
        Me.logoPictureEdit.Location = New System.Drawing.Point(85, 216)
        Me.logoPictureEdit.Name = "logoPictureEdit"
        Me.logoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.logoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.logoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.logoPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.logoPictureEdit.Size = New System.Drawing.Size(227, 229)
        Me.logoPictureEdit.StyleController = Me.DataLayoutControl1
        Me.logoPictureEdit.TabIndex = 11
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(901, 548)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForName, Me.ItemForAddress, Me.ItemForphoneNumber, Me.ItemForfaximile, Me.LayoutControlItem1, Me.ItemForwebsite, Me.ItemForlogo, Me.LayoutControlItem2, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(881, 528)
        '
        'ItemForid
        '
        Me.ItemForid.Control = Me.idTextEdit
        Me.ItemForid.Location = New System.Drawing.Point(0, 0)
        Me.ItemForid.Name = "ItemForid"
        Me.ItemForid.Size = New System.Drawing.Size(304, 24)
        Me.ItemForid.Text = "id"
        Me.ItemForid.TextSize = New System.Drawing.Size(70, 13)
        '
        'ItemForName
        '
        Me.ItemForName.Control = Me.NameTextEdit
        Me.ItemForName.Location = New System.Drawing.Point(0, 0)
        Me.ItemForName.Name = "ItemForName"
        Me.ItemForName.Size = New System.Drawing.Size(304, 24)
        Me.ItemForName.Text = "Name"
        Me.ItemForName.TextSize = New System.Drawing.Size(70, 13)
        '
        'ItemForAddress
        '
        Me.ItemForAddress.Control = Me.AddressMemoEdit
        Me.ItemForAddress.Location = New System.Drawing.Point(0, 24)
        Me.ItemForAddress.Name = "ItemForAddress"
        Me.ItemForAddress.Size = New System.Drawing.Size(304, 84)
        Me.ItemForAddress.StartNewLine = True
        Me.ItemForAddress.Text = "Address"
        Me.ItemForAddress.TextSize = New System.Drawing.Size(70, 13)
        '
        'ItemForphoneNumber
        '
        Me.ItemForphoneNumber.Control = Me.phoneNumberTextEdit
        Me.ItemForphoneNumber.Location = New System.Drawing.Point(0, 108)
        Me.ItemForphoneNumber.Name = "ItemForphoneNumber"
        Me.ItemForphoneNumber.Size = New System.Drawing.Size(304, 24)
        Me.ItemForphoneNumber.Text = "phone Number"
        Me.ItemForphoneNumber.TextSize = New System.Drawing.Size(70, 13)
        '
        'ItemForfaximile
        '
        Me.ItemForfaximile.Control = Me.faximileTextEdit
        Me.ItemForfaximile.Location = New System.Drawing.Point(0, 132)
        Me.ItemForfaximile.Name = "ItemForfaximile"
        Me.ItemForfaximile.Size = New System.Drawing.Size(304, 24)
        Me.ItemForfaximile.Text = "faximile"
        Me.ItemForfaximile.TextSize = New System.Drawing.Size(70, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TextEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem1.Name = "ItemFore-mail"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(304, 24)
        Me.LayoutControlItem1.Text = "e-mail"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(70, 13)
        '
        'ItemForwebsite
        '
        Me.ItemForwebsite.Control = Me.websiteTextEdit
        Me.ItemForwebsite.Location = New System.Drawing.Point(0, 180)
        Me.ItemForwebsite.Name = "ItemForwebsite"
        Me.ItemForwebsite.Size = New System.Drawing.Size(304, 24)
        Me.ItemForwebsite.Text = "website"
        Me.ItemForwebsite.TextSize = New System.Drawing.Size(70, 13)
        '
        'ItemForlogo
        '
        Me.ItemForlogo.Control = Me.logoPictureEdit
        Me.ItemForlogo.Location = New System.Drawing.Point(0, 204)
        Me.ItemForlogo.Name = "ItemForlogo"
        Me.ItemForlogo.Size = New System.Drawing.Size(304, 233)
        Me.ItemForlogo.StartNewLine = True
        Me.ItemForlogo.Text = "logo"
        Me.ItemForlogo.TextSize = New System.Drawing.Size(70, 13)
        '
        'MstCustomerTableAdapter
        '
        Me.MstCustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstCustomerTableAdapter = Me.MstCustomerTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetCustomerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstCustomerBindingNavigator
        '
        Me.MstCustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstCustomerBindingNavigator.BindingSource = Me.MstCustomerBindingSource
        Me.MstCustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstCustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstCustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstCustomerBindingNavigatorSaveItem})
        Me.MstCustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstCustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstCustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstCustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstCustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstCustomerBindingNavigator.Name = "MstCustomerBindingNavigator"
        Me.MstCustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstCustomerBindingNavigator.Size = New System.Drawing.Size(905, 25)
        Me.MstCustomerBindingNavigator.TabIndex = 2
        Me.MstCustomerBindingNavigator.Text = "BindingNavigator1"
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
        'MstCustomerBindingNavigatorSaveItem
        '
        Me.MstCustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstCustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstCustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstCustomerBindingNavigatorSaveItem.Name = "MstCustomerBindingNavigatorSaveItem"
        Me.MstCustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstCustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.MstCustomerGridControl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(304, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(577, 528)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 437)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(304, 91)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'FormCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 570)
        Me.Controls.Add(Me.MstCustomerBindingNavigator)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "FormCustomer"
        Me.Text = "FormCustomer"
        CType(Me.MstCustomerGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phoneNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.faximileTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.websiteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForphoneNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForfaximile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForwebsite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstCustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstCustomerBindingNavigator.ResumeLayout(False)
        Me.MstCustomerBindingNavigator.PerformLayout()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl2 As GroupControl
    Friend WithEvents DataSetCustomer As DataSetCustomer
    Friend WithEvents MstCustomerBindingSource As BindingSource
    Friend WithEvents MstCustomerTableAdapter As DataSetCustomerTableAdapters.mstCustomerTableAdapter
    Friend WithEvents TableAdapterManager As DataSetCustomerTableAdapters.TableAdapterManager
    Friend WithEvents MstCustomerBindingNavigator As BindingNavigator
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
    Friend WithEvents MstCustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstCustomerGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idTextEdit As TextEdit
    Friend WithEvents NameTextEdit As TextEdit
    Friend WithEvents AddressMemoEdit As MemoEdit
    Friend WithEvents phoneNumberTextEdit As TextEdit
    Friend WithEvents faximileTextEdit As TextEdit
    Friend WithEvents TextEdit1 As TextEdit
    Friend WithEvents websiteTextEdit As TextEdit
    Friend WithEvents logoPictureEdit As PictureEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForid As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForName As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAddress As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForphoneNumber As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForfaximile As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForwebsite As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForlogo As XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As XtraLayout.EmptySpaceItem
End Class
