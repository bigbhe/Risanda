<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.DataSetUser = New PlymilindoPerdanaFinishingGood.DataSetUser()
        Me.MstUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstUserTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetUserTableAdapters.mstUserTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetUserTableAdapters.TableAdapterManager()
        Me.MstUserBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstUserBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstUserGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colusername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfullname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsignature = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastLogon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisLogon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TextEditRePassword = New DevExpress.XtraEditors.TextEdit()
        Me.idUserTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.usernameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.fullnameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.passwordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.signaturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.lastIPTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lastLogonDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.isLogonCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.isActiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ItemForidUser = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForlastIP = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForlastLogon = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForisLogon = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForisActive = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForusername = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForfullname = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForpassword = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForsignature = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstUserBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstUserBindingNavigator.SuspendLayout()
        CType(Me.MstUserGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.TextEditRePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fullnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signaturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastIPTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastLogonDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastLogonDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isLogonCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForlastIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForlastLogon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForisLogon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForisActive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForusername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForfullname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForpassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForsignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSetUser
        '
        Me.DataSetUser.DataSetName = "DataSetUser"
        Me.DataSetUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstUserBindingSource
        '
        Me.MstUserBindingSource.DataMember = "mstUser"
        Me.MstUserBindingSource.DataSource = Me.DataSetUser
        '
        'MstUserTableAdapter
        '
        Me.MstUserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstUserTableAdapter = Me.MstUserTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstUserBindingNavigator
        '
        Me.MstUserBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstUserBindingNavigator.BindingSource = Me.MstUserBindingSource
        Me.MstUserBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstUserBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstUserBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstUserBindingNavigatorSaveItem})
        Me.MstUserBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstUserBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstUserBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstUserBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstUserBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstUserBindingNavigator.Name = "MstUserBindingNavigator"
        Me.MstUserBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstUserBindingNavigator.Size = New System.Drawing.Size(929, 25)
        Me.MstUserBindingNavigator.TabIndex = 0
        Me.MstUserBindingNavigator.Text = "BindingNavigator1"
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
        'MstUserBindingNavigatorSaveItem
        '
        Me.MstUserBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstUserBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstUserBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstUserBindingNavigatorSaveItem.Name = "MstUserBindingNavigatorSaveItem"
        Me.MstUserBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstUserBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstUserGridControl
        '
        Me.MstUserGridControl.DataSource = Me.MstUserBindingSource
        Me.MstUserGridControl.Location = New System.Drawing.Point(278, 12)
        Me.MstUserGridControl.MainView = Me.GridView1
        Me.MstUserGridControl.Name = "MstUserGridControl"
        Me.MstUserGridControl.Size = New System.Drawing.Size(635, 408)
        Me.MstUserGridControl.TabIndex = 1
        Me.MstUserGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidUser, Me.colusername, Me.colfullname, Me.colpassword, Me.colsignature, Me.collastIP, Me.collastLogon, Me.colisLogon, Me.colisActive})
        Me.GridView1.GridControl = Me.MstUserGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        '
        'colusername
        '
        Me.colusername.Caption = "User Name"
        Me.colusername.FieldName = "username"
        Me.colusername.Name = "colusername"
        Me.colusername.Visible = True
        Me.colusername.VisibleIndex = 0
        '
        'colfullname
        '
        Me.colfullname.Caption = "Full Name"
        Me.colfullname.FieldName = "fullname"
        Me.colfullname.Name = "colfullname"
        Me.colfullname.Visible = True
        Me.colfullname.VisibleIndex = 1
        '
        'colpassword
        '
        Me.colpassword.FieldName = "password"
        Me.colpassword.Name = "colpassword"
        '
        'colsignature
        '
        Me.colsignature.Caption = "Signature"
        Me.colsignature.FieldName = "signature"
        Me.colsignature.Name = "colsignature"
        Me.colsignature.Visible = True
        Me.colsignature.VisibleIndex = 2
        '
        'collastIP
        '
        Me.collastIP.FieldName = "lastIP"
        Me.collastIP.Name = "collastIP"
        '
        'collastLogon
        '
        Me.collastLogon.FieldName = "lastLogon"
        Me.collastLogon.Name = "collastLogon"
        '
        'colisLogon
        '
        Me.colisLogon.FieldName = "isLogon"
        Me.colisLogon.Name = "colisLogon"
        '
        'colisActive
        '
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.Name = "colisActive"
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.MstUserGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.TextEditRePassword)
        Me.DataLayoutControl1.Controls.Add(Me.idUserTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.usernameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.fullnameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.passwordTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.signaturePictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.lastIPTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.lastLogonDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.isLogonCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.isActiveCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.MstUserBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidUser, Me.ItemForlastIP, Me.ItemForlastLogon, Me.ItemForisLogon, Me.ItemForisActive})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 20)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(549, 279, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(925, 432)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TextEditRePassword
        '
        Me.TextEditRePassword.Location = New System.Drawing.Point(101, 84)
        Me.TextEditRePassword.Name = "TextEditRePassword"
        Me.TextEditRePassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(61)
        Me.TextEditRePassword.Properties.UseSystemPasswordChar = True
        Me.TextEditRePassword.Size = New System.Drawing.Size(173, 20)
        Me.TextEditRePassword.StyleController = Me.DataLayoutControl1
        Me.TextEditRePassword.TabIndex = 4
        '
        'idUserTextEdit
        '
        Me.idUserTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "idUser", True))
        Me.idUserTextEdit.Location = New System.Drawing.Point(101, 12)
        Me.idUserTextEdit.Name = "idUserTextEdit"
        Me.idUserTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idUserTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idUserTextEdit.Properties.Mask.EditMask = "N0"
        Me.idUserTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idUserTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idUserTextEdit.Size = New System.Drawing.Size(164, 20)
        Me.idUserTextEdit.StyleController = Me.DataLayoutControl1
        Me.idUserTextEdit.TabIndex = 1
        '
        'usernameTextEdit
        '
        Me.usernameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "username", True))
        Me.usernameTextEdit.Location = New System.Drawing.Point(101, 12)
        Me.usernameTextEdit.Name = "usernameTextEdit"
        Me.usernameTextEdit.Size = New System.Drawing.Size(173, 20)
        Me.usernameTextEdit.StyleController = Me.DataLayoutControl1
        Me.usernameTextEdit.TabIndex = 0
        '
        'fullnameTextEdit
        '
        Me.fullnameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "fullname", True))
        Me.fullnameTextEdit.Location = New System.Drawing.Point(101, 36)
        Me.fullnameTextEdit.Name = "fullnameTextEdit"
        Me.fullnameTextEdit.Size = New System.Drawing.Size(173, 20)
        Me.fullnameTextEdit.StyleController = Me.DataLayoutControl1
        Me.fullnameTextEdit.TabIndex = 2
        '
        'passwordTextEdit
        '
        Me.passwordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "password", True))
        Me.passwordTextEdit.Location = New System.Drawing.Point(101, 60)
        Me.passwordTextEdit.Name = "passwordTextEdit"
        Me.passwordTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(61)
        Me.passwordTextEdit.Properties.UseSystemPasswordChar = True
        Me.passwordTextEdit.Size = New System.Drawing.Size(173, 20)
        Me.passwordTextEdit.StyleController = Me.DataLayoutControl1
        Me.passwordTextEdit.TabIndex = 3
        '
        'signaturePictureEdit
        '
        Me.signaturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "signature", True))
        Me.signaturePictureEdit.Location = New System.Drawing.Point(101, 108)
        Me.signaturePictureEdit.Name = "signaturePictureEdit"
        Me.signaturePictureEdit.Properties.InitialImage = CType(resources.GetObject("signaturePictureEdit.Properties.InitialImage"), System.Drawing.Image)
        Me.signaturePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.signaturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.signaturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.signaturePictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.signaturePictureEdit.Size = New System.Drawing.Size(173, 148)
        Me.signaturePictureEdit.StyleController = Me.DataLayoutControl1
        Me.signaturePictureEdit.TabIndex = 1
        '
        'lastIPTextEdit
        '
        Me.lastIPTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "lastIP", True))
        Me.lastIPTextEdit.Location = New System.Drawing.Point(101, 347)
        Me.lastIPTextEdit.Name = "lastIPTextEdit"
        Me.lastIPTextEdit.Size = New System.Drawing.Size(164, 20)
        Me.lastIPTextEdit.StyleController = Me.DataLayoutControl1
        Me.lastIPTextEdit.TabIndex = 1
        '
        'lastLogonDateEdit
        '
        Me.lastLogonDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "lastLogon", True))
        Me.lastLogonDateEdit.EditValue = Nothing
        Me.lastLogonDateEdit.Location = New System.Drawing.Point(101, 371)
        Me.lastLogonDateEdit.Name = "lastLogonDateEdit"
        Me.lastLogonDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lastLogonDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lastLogonDateEdit.Size = New System.Drawing.Size(164, 20)
        Me.lastLogonDateEdit.StyleController = Me.DataLayoutControl1
        Me.lastLogonDateEdit.TabIndex = 1
        '
        'isLogonCheckEdit
        '
        Me.isLogonCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "isLogon", True))
        Me.isLogonCheckEdit.Location = New System.Drawing.Point(101, 395)
        Me.isLogonCheckEdit.Name = "isLogonCheckEdit"
        Me.isLogonCheckEdit.Properties.Caption = "is Logon"
        Me.isLogonCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.isLogonCheckEdit.Size = New System.Drawing.Size(164, 19)
        Me.isLogonCheckEdit.StyleController = Me.DataLayoutControl1
        Me.isLogonCheckEdit.TabIndex = 1
        '
        'isActiveCheckEdit
        '
        Me.isActiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MstUserBindingSource, "isActive", True))
        Me.isActiveCheckEdit.Location = New System.Drawing.Point(101, 418)
        Me.isActiveCheckEdit.Name = "isActiveCheckEdit"
        Me.isActiveCheckEdit.Properties.Caption = "is Active"
        Me.isActiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.isActiveCheckEdit.Size = New System.Drawing.Size(164, 19)
        Me.isActiveCheckEdit.StyleController = Me.DataLayoutControl1
        Me.isActiveCheckEdit.TabIndex = 1
        '
        'ItemForidUser
        '
        Me.ItemForidUser.Control = Me.idUserTextEdit
        Me.ItemForidUser.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidUser.Name = "ItemForidUser"
        Me.ItemForidUser.Size = New System.Drawing.Size(257, 24)
        Me.ItemForidUser.Text = "id User"
        Me.ItemForidUser.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForlastIP
        '
        Me.ItemForlastIP.Control = Me.lastIPTextEdit
        Me.ItemForlastIP.Location = New System.Drawing.Point(0, 335)
        Me.ItemForlastIP.Name = "ItemForlastIP"
        Me.ItemForlastIP.Size = New System.Drawing.Size(257, 24)
        Me.ItemForlastIP.Text = "last IP"
        Me.ItemForlastIP.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForlastLogon
        '
        Me.ItemForlastLogon.Control = Me.lastLogonDateEdit
        Me.ItemForlastLogon.Location = New System.Drawing.Point(0, 359)
        Me.ItemForlastLogon.Name = "ItemForlastLogon"
        Me.ItemForlastLogon.Size = New System.Drawing.Size(257, 24)
        Me.ItemForlastLogon.Text = "last Logon"
        Me.ItemForlastLogon.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForisLogon
        '
        Me.ItemForisLogon.Control = Me.isLogonCheckEdit
        Me.ItemForisLogon.Location = New System.Drawing.Point(0, 383)
        Me.ItemForisLogon.Name = "ItemForisLogon"
        Me.ItemForisLogon.Size = New System.Drawing.Size(257, 23)
        Me.ItemForisLogon.Text = "is Logon"
        Me.ItemForisLogon.TextSize = New System.Drawing.Size(49, 13)
        '
        'ItemForisActive
        '
        Me.ItemForisActive.Control = Me.isActiveCheckEdit
        Me.ItemForisActive.Location = New System.Drawing.Point(0, 406)
        Me.ItemForisActive.Name = "ItemForisActive"
        Me.ItemForisActive.Size = New System.Drawing.Size(257, 23)
        Me.ItemForisActive.Text = "is Active"
        Me.ItemForisActive.TextSize = New System.Drawing.Size(49, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(925, 432)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForusername, Me.ItemForfullname, Me.ItemForpassword, Me.ItemForsignature, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(266, 248)
        '
        'ItemForusername
        '
        Me.ItemForusername.Control = Me.usernameTextEdit
        Me.ItemForusername.Location = New System.Drawing.Point(0, 0)
        Me.ItemForusername.Name = "ItemForusername"
        Me.ItemForusername.Size = New System.Drawing.Size(266, 24)
        Me.ItemForusername.Text = "username"
        Me.ItemForusername.TextSize = New System.Drawing.Size(86, 13)
        '
        'ItemForfullname
        '
        Me.ItemForfullname.Control = Me.fullnameTextEdit
        Me.ItemForfullname.Location = New System.Drawing.Point(0, 24)
        Me.ItemForfullname.Name = "ItemForfullname"
        Me.ItemForfullname.Size = New System.Drawing.Size(266, 24)
        Me.ItemForfullname.Text = "fullname"
        Me.ItemForfullname.TextSize = New System.Drawing.Size(86, 13)
        '
        'ItemForpassword
        '
        Me.ItemForpassword.Control = Me.passwordTextEdit
        Me.ItemForpassword.Location = New System.Drawing.Point(0, 48)
        Me.ItemForpassword.Name = "ItemForpassword"
        Me.ItemForpassword.Size = New System.Drawing.Size(266, 24)
        Me.ItemForpassword.Text = "password"
        Me.ItemForpassword.TextSize = New System.Drawing.Size(86, 13)
        '
        'ItemForsignature
        '
        Me.ItemForsignature.Control = Me.signaturePictureEdit
        Me.ItemForsignature.Location = New System.Drawing.Point(0, 96)
        Me.ItemForsignature.Name = "ItemForsignature"
        Me.ItemForsignature.Size = New System.Drawing.Size(266, 152)
        Me.ItemForsignature.StartNewLine = True
        Me.ItemForsignature.Text = "signature"
        Me.ItemForsignature.TextLocation = DevExpress.Utils.Locations.Left
        Me.ItemForsignature.TextSize = New System.Drawing.Size(86, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TextEditRePassword
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(266, 24)
        Me.LayoutControlItem1.Text = "ReType Password"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(86, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 248)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(266, 164)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.MstUserGridControl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(266, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(639, 412)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.DataLayoutControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(929, 454)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "User Detail"
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 479)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.MstUserBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormUser"
        Me.Text = "FormUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstUserBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstUserBindingNavigator.ResumeLayout(False)
        Me.MstUserBindingNavigator.PerformLayout()
        CType(Me.MstUserGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.TextEditRePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idUserTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fullnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signaturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastIPTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastLogonDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastLogonDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isLogonCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isActiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForlastIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForlastLogon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForisLogon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForisActive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForusername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForfullname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForpassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForsignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetUser As DataSetUser
    Friend WithEvents MstUserBindingSource As BindingSource
    Friend WithEvents MstUserTableAdapter As DataSetUserTableAdapters.mstUserTableAdapter
    Friend WithEvents TableAdapterManager As DataSetUserTableAdapters.TableAdapterManager
    Friend WithEvents MstUserBindingNavigator As BindingNavigator
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
    Friend WithEvents MstUserBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstUserGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents DataLayoutControl1 As XtraDataLayout.DataLayoutControl
    Friend WithEvents idUserTextEdit As TextEdit
    Friend WithEvents usernameTextEdit As TextEdit
    Friend WithEvents fullnameTextEdit As TextEdit
    Friend WithEvents passwordTextEdit As TextEdit
    Friend WithEvents signaturePictureEdit As PictureEdit
    Friend WithEvents lastIPTextEdit As TextEdit
    Friend WithEvents lastLogonDateEdit As DateEdit
    Friend WithEvents isLogonCheckEdit As CheckEdit
    Friend WithEvents isActiveCheckEdit As CheckEdit
    Friend WithEvents LayoutControlGroup1 As XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidUser As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForusername As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForfullname As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForpassword As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForsignature As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForlastIP As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForlastLogon As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForisLogon As XtraLayout.LayoutControlItem
    Friend WithEvents ItemForisActive As XtraLayout.LayoutControlItem
    Friend WithEvents colidUser As Columns.GridColumn
    Friend WithEvents colusername As Columns.GridColumn
    Friend WithEvents colfullname As Columns.GridColumn
    Friend WithEvents colpassword As Columns.GridColumn
    Friend WithEvents colsignature As Columns.GridColumn
    Friend WithEvents collastIP As Columns.GridColumn
    Friend WithEvents collastLogon As Columns.GridColumn
    Friend WithEvents colisLogon As Columns.GridColumn
    Friend WithEvents colisActive As Columns.GridColumn
    Friend WithEvents TextEditRePassword As TextEdit
    Friend WithEvents LayoutControlItem1 As XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As XtraLayout.EmptySpaceItem
    Friend WithEvents GroupControl2 As GroupControl
    Friend WithEvents LayoutControlItem2 As XtraLayout.LayoutControlItem
End Class
