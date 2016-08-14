<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTraOutHeader
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTraOutHeader))
        Me.DataSetTraOutHeader = New PlymilindoPerdanaFinishingGood.DataSetTraOutHeader()
        Me.TraOutHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraOutHeaderTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetTraOutHeaderTableAdapters.traOutHeaderTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetTraOutHeaderTableAdapters.TableAdapterManager()
        Me.TraOutHeaderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TraOutHeaderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ReportDeliveryPerNumberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCustomer = New PlymilindoPerdanaFinishingGood.DataSetCustomer()
        Me.MstCustomerTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetCustomerTableAdapters.mstCustomerTableAdapter()
        Me.GetCustomerTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetTraOutHeaderTableAdapters.getCustomerTableAdapter()
        Me.ReportReceivePerNumberTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetReceiveHeaderTableAdapters.reportReceivePerNumberTableAdapter()
        Me.ReportDeliveryPerNumberTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetTraOutHeaderTableAdapters.reportDeliveryPerNumberTableAdapter()
        Me.TraOutHeaderGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GetCustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.coldate = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetTraOutHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraOutHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraOutHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TraOutHeaderBindingNavigator.SuspendLayout()
        CType(Me.ReportDeliveryPerNumberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraOutHeaderGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetCustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetTraOutHeader
        '
        Me.DataSetTraOutHeader.DataSetName = "DataSetTraOutHeader"
        Me.DataSetTraOutHeader.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TraOutHeaderBindingSource
        '
        Me.TraOutHeaderBindingSource.DataMember = "traOutHeader"
        Me.TraOutHeaderBindingSource.DataSource = Me.DataSetTraOutHeader
        '
        'TraOutHeaderTableAdapter
        '
        Me.TraOutHeaderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.traOutHeaderTableAdapter = Me.TraOutHeaderTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetTraOutHeaderTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TraOutHeaderBindingNavigator
        '
        Me.TraOutHeaderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TraOutHeaderBindingNavigator.BindingSource = Me.TraOutHeaderBindingSource
        Me.TraOutHeaderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TraOutHeaderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TraOutHeaderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TraOutHeaderBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.TraOutHeaderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TraOutHeaderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TraOutHeaderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TraOutHeaderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TraOutHeaderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TraOutHeaderBindingNavigator.Name = "TraOutHeaderBindingNavigator"
        Me.TraOutHeaderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TraOutHeaderBindingNavigator.Size = New System.Drawing.Size(812, 25)
        Me.TraOutHeaderBindingNavigator.TabIndex = 0
        Me.TraOutHeaderBindingNavigator.Text = "BindingNavigator1"
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
        'TraOutHeaderBindingNavigatorSaveItem
        '
        Me.TraOutHeaderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TraOutHeaderBindingNavigatorSaveItem.Image = CType(resources.GetObject("TraOutHeaderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TraOutHeaderBindingNavigatorSaveItem.Name = "TraOutHeaderBindingNavigatorSaveItem"
        Me.TraOutHeaderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TraOutHeaderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.PlymilindoPerdanaFinishingGood.My.Resources.Resources.Avosoft_Warm_Toolbar_Print
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripButton2.Text = "Print Data Delivered Item"
        '
        'ReportDeliveryPerNumberBindingSource
        '
        Me.ReportDeliveryPerNumberBindingSource.DataMember = "reportDeliveryPerNumber"
        Me.ReportDeliveryPerNumberBindingSource.DataSource = Me.DataSetTraOutHeader
        '
        'GetCustomerBindingSource
        '
        Me.GetCustomerBindingSource.DataMember = "getCustomer"
        Me.GetCustomerBindingSource.DataSource = Me.DataSetTraOutHeader
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
        'MstCustomerTableAdapter
        '
        Me.MstCustomerTableAdapter.ClearBeforeFill = True
        '
        'GetCustomerTableAdapter
        '
        Me.GetCustomerTableAdapter.ClearBeforeFill = True
        '
        'ReportReceivePerNumberTableAdapter
        '
        Me.ReportReceivePerNumberTableAdapter.ClearBeforeFill = True
        '
        'ReportDeliveryPerNumberTableAdapter
        '
        Me.ReportDeliveryPerNumberTableAdapter.ClearBeforeFill = True
        '
        'TraOutHeaderGridControl
        '
        Me.TraOutHeaderGridControl.DataSource = Me.TraOutHeaderBindingSource
        Me.TraOutHeaderGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TraOutHeaderGridControl.Location = New System.Drawing.Point(0, 25)
        Me.TraOutHeaderGridControl.MainView = Me.GridView1
        Me.TraOutHeaderGridControl.Name = "TraOutHeaderGridControl"
        Me.TraOutHeaderGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.TraOutHeaderGridControl.Size = New System.Drawing.Size(812, 549)
        Me.TraOutHeaderGridControl.TabIndex = 1
        Me.TraOutHeaderGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colcode, Me.colidCustomer, Me.coldate})
        Me.GridView1.GridControl = Me.TraOutHeaderGridControl
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
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 0
        '
        'colidCustomer
        '
        Me.colidCustomer.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidCustomer.FieldName = "idCustomer"
        Me.colidCustomer.Name = "colidCustomer"
        Me.colidCustomer.Visible = True
        Me.colidCustomer.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.GetCustomerBindingSource1
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "id"
        '
        'GetCustomerBindingSource1
        '
        Me.GetCustomerBindingSource1.DataMember = "getCustomer"
        Me.GetCustomerBindingSource1.DataSource = Me.DataSetTraOutHeader
        '
        'coldate
        '
        Me.coldate.FieldName = "date"
        Me.coldate.Name = "coldate"
        Me.coldate.Visible = True
        Me.coldate.VisibleIndex = 2
        '
        'FormTraOutHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 574)
        Me.Controls.Add(Me.TraOutHeaderGridControl)
        Me.Controls.Add(Me.TraOutHeaderBindingNavigator)
        Me.Name = "FormTraOutHeader"
        Me.Text = "FormTraOutHeader"
        CType(Me.DataSetTraOutHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraOutHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraOutHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TraOutHeaderBindingNavigator.ResumeLayout(False)
        Me.TraOutHeaderBindingNavigator.PerformLayout()
        CType(Me.ReportDeliveryPerNumberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraOutHeaderGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetCustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetTraOutHeader As DataSetTraOutHeader
    Friend WithEvents TraOutHeaderBindingSource As BindingSource
    Friend WithEvents TraOutHeaderTableAdapter As DataSetTraOutHeaderTableAdapters.traOutHeaderTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTraOutHeaderTableAdapters.TableAdapterManager
    Friend WithEvents TraOutHeaderBindingNavigator As BindingNavigator
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
    Friend WithEvents TraOutHeaderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataSetCustomer As DataSetCustomer
    Friend WithEvents MstCustomerBindingSource As BindingSource
    Friend WithEvents MstCustomerTableAdapter As DataSetCustomerTableAdapters.mstCustomerTableAdapter
    Friend WithEvents GetCustomerBindingSource As BindingSource
    Friend WithEvents GetCustomerTableAdapter As DataSetTraOutHeaderTableAdapters.getCustomerTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ReportReceivePerNumberTableAdapter As DataSetReceiveHeaderTableAdapters.reportReceivePerNumberTableAdapter
    Friend WithEvents ReportDeliveryPerNumberBindingSource As BindingSource
    Friend WithEvents ReportDeliveryPerNumberTableAdapter As DataSetTraOutHeaderTableAdapters.reportDeliveryPerNumberTableAdapter
    Friend WithEvents TraOutHeaderGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colid As Columns.GridColumn
    Friend WithEvents colcode As Columns.GridColumn
    Friend WithEvents colidCustomer As Columns.GridColumn
    Friend WithEvents coldate As Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GetCustomerBindingSource1 As BindingSource
End Class
