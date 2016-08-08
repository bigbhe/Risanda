<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUnit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUnit))
        Me.DataSetUnit = New PlymilindoPerdanaFinishingGood.DataSetUnit()
        Me.MstUnitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MstUnitTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetUnitTableAdapters.mstUnitTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetUnitTableAdapters.TableAdapterManager()
        Me.MstUnitBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MstUnitBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MstUnitGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colunit = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstUnitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MstUnitBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MstUnitBindingNavigator.SuspendLayout()
        CType(Me.MstUnitGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetUnit
        '
        Me.DataSetUnit.DataSetName = "DataSetUnit"
        Me.DataSetUnit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstUnitBindingSource
        '
        Me.MstUnitBindingSource.DataMember = "mstUnit"
        Me.MstUnitBindingSource.DataSource = Me.DataSetUnit
        '
        'MstUnitTableAdapter
        '
        Me.MstUnitTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mstUnitTableAdapter = Me.MstUnitTableAdapter
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetUnitTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MstUnitBindingNavigator
        '
        Me.MstUnitBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MstUnitBindingNavigator.BindingSource = Me.MstUnitBindingSource
        Me.MstUnitBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MstUnitBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MstUnitBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MstUnitBindingNavigatorSaveItem})
        Me.MstUnitBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MstUnitBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MstUnitBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MstUnitBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MstUnitBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MstUnitBindingNavigator.Name = "MstUnitBindingNavigator"
        Me.MstUnitBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MstUnitBindingNavigator.Size = New System.Drawing.Size(952, 25)
        Me.MstUnitBindingNavigator.TabIndex = 0
        Me.MstUnitBindingNavigator.Text = "BindingNavigator1"
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
        'MstUnitBindingNavigatorSaveItem
        '
        Me.MstUnitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MstUnitBindingNavigatorSaveItem.Image = CType(resources.GetObject("MstUnitBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MstUnitBindingNavigatorSaveItem.Name = "MstUnitBindingNavigatorSaveItem"
        Me.MstUnitBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MstUnitBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MstUnitGridControl
        '
        Me.MstUnitGridControl.DataSource = Me.MstUnitBindingSource
        Me.MstUnitGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MstUnitGridControl.Location = New System.Drawing.Point(0, 25)
        Me.MstUnitGridControl.MainView = Me.GridView1
        Me.MstUnitGridControl.Name = "MstUnitGridControl"
        Me.MstUnitGridControl.Size = New System.Drawing.Size(952, 440)
        Me.MstUnitGridControl.TabIndex = 1
        Me.MstUnitGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colunit})
        Me.GridView1.GridControl = Me.MstUnitGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colunit
        '
        Me.colunit.FieldName = "unit"
        Me.colunit.Name = "colunit"
        Me.colunit.Visible = True
        Me.colunit.VisibleIndex = 0
        '
        'FormUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 465)
        Me.Controls.Add(Me.MstUnitGridControl)
        Me.Controls.Add(Me.MstUnitBindingNavigator)
        Me.Name = "FormUnit"
        Me.Text = "FormUnit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstUnitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MstUnitBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MstUnitBindingNavigator.ResumeLayout(False)
        Me.MstUnitBindingNavigator.PerformLayout()
        CType(Me.MstUnitGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetUnit As DataSetUnit
    Friend WithEvents MstUnitBindingSource As BindingSource
    Friend WithEvents MstUnitTableAdapter As DataSetUnitTableAdapters.mstUnitTableAdapter
    Friend WithEvents TableAdapterManager As DataSetUnitTableAdapters.TableAdapterManager
    Friend WithEvents MstUnitBindingNavigator As BindingNavigator
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
    Friend WithEvents MstUnitBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MstUnitGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colid As Columns.GridColumn
    Friend WithEvents colunit As Columns.GridColumn
End Class
