<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTraReceiveHeader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTraReceiveHeader))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DataSetReceiveHeader = New PlymilindoPerdanaFinishingGood.DataSetReceiveHeader()
        Me.TraReceiveHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraReceiveHeaderTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetReceiveHeaderTableAdapters.traReceiveHeaderTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetReceiveHeaderTableAdapters.TableAdapterManager()
        Me.TraReceiveHeaderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TraReceiveHeaderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TraReceiveHeaderGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colreceiveNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.buttonFillDetail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ReportReceivePerNumberGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ReportReceivePerNumberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colreceiveNumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colunit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ReportReceivePerNumberTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetReceiveHeaderTableAdapters.reportReceivePerNumberTableAdapter()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.DataSetReceiveHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraReceiveHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraReceiveHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TraReceiveHeaderBindingNavigator.SuspendLayout()
        CType(Me.TraReceiveHeaderGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonFillDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ReportReceivePerNumberGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportReceivePerNumberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetReceiveHeader
        '
        Me.DataSetReceiveHeader.DataSetName = "DataSetReceiveHeader"
        Me.DataSetReceiveHeader.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TraReceiveHeaderBindingSource
        '
        Me.TraReceiveHeaderBindingSource.DataMember = "traReceiveHeader"
        Me.TraReceiveHeaderBindingSource.DataSource = Me.DataSetReceiveHeader
        '
        'TraReceiveHeaderTableAdapter
        '
        Me.TraReceiveHeaderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.traReceiveHeaderTableAdapter = Me.TraReceiveHeaderTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetReceiveHeaderTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TraReceiveHeaderBindingNavigator
        '
        Me.TraReceiveHeaderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TraReceiveHeaderBindingNavigator.BindingSource = Me.TraReceiveHeaderBindingSource
        Me.TraReceiveHeaderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TraReceiveHeaderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TraReceiveHeaderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TraReceiveHeaderBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripButton2})
        Me.TraReceiveHeaderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TraReceiveHeaderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TraReceiveHeaderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TraReceiveHeaderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TraReceiveHeaderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TraReceiveHeaderBindingNavigator.Name = "TraReceiveHeaderBindingNavigator"
        Me.TraReceiveHeaderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TraReceiveHeaderBindingNavigator.Size = New System.Drawing.Size(942, 25)
        Me.TraReceiveHeaderBindingNavigator.TabIndex = 0
        Me.TraReceiveHeaderBindingNavigator.Text = "BindingNavigator1"
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
        'TraReceiveHeaderBindingNavigatorSaveItem
        '
        Me.TraReceiveHeaderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TraReceiveHeaderBindingNavigatorSaveItem.Image = CType(resources.GetObject("TraReceiveHeaderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TraReceiveHeaderBindingNavigatorSaveItem.Name = "TraReceiveHeaderBindingNavigatorSaveItem"
        Me.TraReceiveHeaderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TraReceiveHeaderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'TraReceiveHeaderGridControl
        '
        Me.TraReceiveHeaderGridControl.DataSource = Me.TraReceiveHeaderBindingSource
        Me.TraReceiveHeaderGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TraReceiveHeaderGridControl.Location = New System.Drawing.Point(2, 20)
        Me.TraReceiveHeaderGridControl.MainView = Me.GridView1
        Me.TraReceiveHeaderGridControl.Name = "TraReceiveHeaderGridControl"
        Me.TraReceiveHeaderGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.buttonFillDetail})
        Me.TraReceiveHeaderGridControl.Size = New System.Drawing.Size(938, 565)
        Me.TraReceiveHeaderGridControl.TabIndex = 1
        Me.TraReceiveHeaderGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colreceiveNumber, Me.coldate})
        Me.GridView1.GridControl = Me.TraReceiveHeaderGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colreceiveNumber
        '
        Me.colreceiveNumber.FieldName = "receiveNumber"
        Me.colreceiveNumber.Name = "colreceiveNumber"
        Me.colreceiveNumber.Visible = True
        Me.colreceiveNumber.VisibleIndex = 0
        '
        'coldate
        '
        Me.coldate.FieldName = "date"
        Me.coldate.Name = "coldate"
        Me.coldate.Visible = True
        Me.coldate.VisibleIndex = 1
        '
        'buttonFillDetail
        '
        Me.buttonFillDetail.AutoHeight = False
        Me.buttonFillDetail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("buttonFillDetail.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.buttonFillDetail.Name = "buttonFillDetail"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TraReceiveHeaderGridControl)
        Me.GroupControl1.Controls.Add(Me.ReportReceivePerNumberGridControl)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(942, 587)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        'ReportReceivePerNumberGridControl
        '
        Me.ReportReceivePerNumberGridControl.DataSource = Me.ReportReceivePerNumberBindingSource
        Me.ReportReceivePerNumberGridControl.Location = New System.Drawing.Point(552, 73)
        Me.ReportReceivePerNumberGridControl.MainView = Me.GridView2
        Me.ReportReceivePerNumberGridControl.Name = "ReportReceivePerNumberGridControl"
        Me.ReportReceivePerNumberGridControl.Size = New System.Drawing.Size(339, 151)
        Me.ReportReceivePerNumberGridControl.TabIndex = 1
        Me.ReportReceivePerNumberGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ReportReceivePerNumberBindingSource
        '
        Me.ReportReceivePerNumberBindingSource.DataMember = "reportReceivePerNumber"
        Me.ReportReceivePerNumberBindingSource.DataSource = Me.DataSetReceiveHeader
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colreceiveNumber1, Me.colname, Me.colamount, Me.colunit, Me.coldate1})
        Me.GridView2.GridControl = Me.ReportReceivePerNumberGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colreceiveNumber1
        '
        Me.colreceiveNumber1.FieldName = "receiveNumber"
        Me.colreceiveNumber1.Name = "colreceiveNumber1"
        Me.colreceiveNumber1.Visible = True
        Me.colreceiveNumber1.VisibleIndex = 0
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 1
        '
        'colamount
        '
        Me.colamount.FieldName = "amount"
        Me.colamount.Name = "colamount"
        Me.colamount.Visible = True
        Me.colamount.VisibleIndex = 2
        '
        'colunit
        '
        Me.colunit.FieldName = "unit"
        Me.colunit.Name = "colunit"
        Me.colunit.Visible = True
        Me.colunit.VisibleIndex = 3
        '
        'coldate1
        '
        Me.coldate1.FieldName = "date"
        Me.coldate1.Name = "coldate1"
        Me.coldate1.Visible = True
        Me.coldate1.VisibleIndex = 4
        '
        'ReportReceivePerNumberTableAdapter
        '
        Me.ReportReceivePerNumberTableAdapter.ClearBeforeFill = True
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'FormTraReceiveHeader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 612)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.TraReceiveHeaderBindingNavigator)
        Me.Name = "FormTraReceiveHeader"
        Me.Text = "FormTraReceiveHeader"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetReceiveHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraReceiveHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraReceiveHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TraReceiveHeaderBindingNavigator.ResumeLayout(False)
        Me.TraReceiveHeaderBindingNavigator.PerformLayout()
        CType(Me.TraReceiveHeaderGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonFillDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.ReportReceivePerNumberGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportReceivePerNumberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetReceiveHeader As DataSetReceiveHeader
    Friend WithEvents TraReceiveHeaderBindingSource As BindingSource
    Friend WithEvents TraReceiveHeaderTableAdapter As DataSetReceiveHeaderTableAdapters.traReceiveHeaderTableAdapter
    Friend WithEvents TableAdapterManager As DataSetReceiveHeaderTableAdapters.TableAdapterManager
    Friend WithEvents TraReceiveHeaderBindingNavigator As BindingNavigator
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
    Friend WithEvents TraReceiveHeaderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TraReceiveHeaderGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colid As Columns.GridColumn
    Friend WithEvents colreceiveNumber As Columns.GridColumn
    Friend WithEvents coldate As Columns.GridColumn
    Friend WithEvents buttonFillDetail As XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ReportReceivePerNumberBindingSource As BindingSource
    Friend WithEvents ReportReceivePerNumberTableAdapter As DataSetReceiveHeaderTableAdapters.reportReceivePerNumberTableAdapter
    Friend WithEvents ReportReceivePerNumberGridControl As GridControl
    Friend WithEvents GridView2 As Views.Grid.GridView
    Friend WithEvents colreceiveNumber1 As Columns.GridColumn
    Friend WithEvents colname As Columns.GridColumn
    Friend WithEvents colamount As Columns.GridColumn
    Friend WithEvents colunit As Columns.GridColumn
    Friend WithEvents coldate1 As Columns.GridColumn
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
