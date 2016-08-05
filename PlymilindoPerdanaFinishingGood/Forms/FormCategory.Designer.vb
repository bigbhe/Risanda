<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCategory))
        Me.DataSetCategory = New PlymilindoPerdanaFinishingGood.DataSetCategory()
        Me.MstCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstCategoryTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetCategoryTableAdapters.mstCategoryTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetCategoryTableAdapters.TableAdapterManager()
        Me.MstCategoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstCategoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstCategoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstCategoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstCategoryBindingNavigator.SuspendLayout()
        CType(Me.MstCategoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetCategory
        '
        Me.DataSetCategory.DataSetName = "DataSetCategory"
        Me.DataSetCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstCategoryBindingSource
        '
        Me.MstCategoryBindingSource.DataMember = "mstCategory"
        Me.MstCategoryBindingSource.DataSource = Me.DataSetCategory
        '
        'MstCategoryTableAdapter
        '
        Me.MstCategoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstCategoryTableAdapter = Me.MstCategoryTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetCategoryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstCategoryBindingNavigator
        '
        Me.MstCategoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstCategoryBindingNavigator.BindingSource = Me.MstCategoryBindingSource
        Me.MstCategoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstCategoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstCategoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstCategoryBindingNavigatorSaveItem})
        Me.MstCategoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstCategoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstCategoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstCategoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstCategoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstCategoryBindingNavigator.Name = "MstCategoryBindingNavigator"
        Me.MstCategoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstCategoryBindingNavigator.Size = New System.Drawing.Size(788, 25)
        Me.MstCategoryBindingNavigator.TabIndex = 0
        Me.MstCategoryBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MstCategoryBindingNavigatorSaveItem
        '
        Me.MstCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstCategoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstCategoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstCategoryBindingNavigatorSaveItem.Name = "MstCategoryBindingNavigatorSaveItem"
        Me.MstCategoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MstCategoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstCategoryGridControl
        '
        Me.MstCategoryGridControl.DataSource = Me.MstCategoryBindingSource
        Me.MstCategoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstCategoryGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstCategoryGridControl.MainView = Me.GridView1
        Me.MstCategoryGridControl.Name = "MstCategoryGridControl"
        Me.MstCategoryGridControl.Size = New System.Drawing.Size(788, 521)
        Me.MstCategoryGridControl.TabIndex = 1
        Me.MstCategoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colName, Me.colNotes})
        Me.GridView1.GridControl = Me.MstCategoryGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = True
        Me.colNotes.VisibleIndex = 2
        '
        'FormCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 546)
        Me.Controls.Add(Me.MstCategoryGridControl)
        Me.Controls.Add(Me.MstCategoryBindingNavigator)
        Me.Name = "FormCategory"
        Me.Text = "FormCategory"
        CType(Me.DataSetCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstCategoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstCategoryBindingNavigator.ResumeLayout(False)
        Me.MstCategoryBindingNavigator.PerformLayout()
        CType(Me.MstCategoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetCategory As DataSetCategory
    Friend WithEvents MstCategoryBindingSource As BindingSource
    Friend WithEvents MstCategoryTableAdapter As DataSetCategoryTableAdapters.mstCategoryTableAdapter
    Friend WithEvents TableAdapterManager As DataSetCategoryTableAdapters.TableAdapterManager
    Friend WithEvents MstCategoryBindingNavigator As BindingNavigator
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
    Friend WithEvents MstCategoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstCategoryGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colid As Columns.GridColumn
    Friend WithEvents colName As Columns.GridColumn
    Friend WithEvents colNotes As Columns.GridColumn
End Class
