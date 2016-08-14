<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormItemList
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
        Me.DataSetItem = New PlymilindoPerdanaFinishingGood.DataSetItem()
        Me.ReportRemainingQuantityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportRemainingQuantityTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetItemTableAdapters.ReportRemainingQuantityTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetItemTableAdapters.TableAdapterManager()
        Me.ReportRemainingQuantityGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colunit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivedItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliveredItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemainingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportRemainingQuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportRemainingQuantityGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetItem
        '
        Me.DataSetItem.DataSetName = "DataSetItem"
        Me.DataSetItem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportRemainingQuantityBindingSource
        '
        Me.ReportRemainingQuantityBindingSource.DataMember = "ReportRemainingQuantity"
        Me.ReportRemainingQuantityBindingSource.DataSource = Me.DataSetItem
        '
        'ReportRemainingQuantityTableAdapter
        '
        Me.ReportRemainingQuantityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.mstItemTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetItemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReportRemainingQuantityGridControl
        '
        Me.ReportRemainingQuantityGridControl.DataSource = Me.ReportRemainingQuantityBindingSource
        Me.ReportRemainingQuantityGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportRemainingQuantityGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ReportRemainingQuantityGridControl.MainView = Me.GridView1
        Me.ReportRemainingQuantityGridControl.Name = "ReportRemainingQuantityGridControl"
        Me.ReportRemainingQuantityGridControl.Size = New System.Drawing.Size(1009, 686)
        Me.ReportRemainingQuantityGridControl.TabIndex = 1
        Me.ReportRemainingQuantityGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colName, Me.colname1, Me.colunit, Me.colReceivedItem, Me.colDeliveredItem, Me.colRemainingQuantity})
        Me.GridView1.GridControl = Me.ReportRemainingQuantityGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'colname1
        '
        Me.colname1.Caption = "Item Name"
        Me.colname1.FieldName = "name1"
        Me.colname1.Name = "colname1"
        Me.colname1.Visible = True
        Me.colname1.VisibleIndex = 1
        '
        'colunit
        '
        Me.colunit.FieldName = "unit"
        Me.colunit.Name = "colunit"
        Me.colunit.Visible = True
        Me.colunit.VisibleIndex = 5
        '
        'colReceivedItem
        '
        Me.colReceivedItem.FieldName = "ReceivedItem"
        Me.colReceivedItem.Name = "colReceivedItem"
        Me.colReceivedItem.Visible = True
        Me.colReceivedItem.VisibleIndex = 2
        '
        'colDeliveredItem
        '
        Me.colDeliveredItem.FieldName = "DeliveredItem"
        Me.colDeliveredItem.Name = "colDeliveredItem"
        Me.colDeliveredItem.Visible = True
        Me.colDeliveredItem.VisibleIndex = 3
        '
        'colRemainingQuantity
        '
        Me.colRemainingQuantity.FieldName = "RemainingQuantity"
        Me.colRemainingQuantity.Name = "colRemainingQuantity"
        Me.colRemainingQuantity.Visible = True
        Me.colRemainingQuantity.VisibleIndex = 4
        '
        'FormItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 686)
        Me.Controls.Add(Me.ReportRemainingQuantityGridControl)
        Me.Name = "FormItemList"
        Me.Text = "FormItemList"
        CType(Me.DataSetItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportRemainingQuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportRemainingQuantityGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSetItem As DataSetItem
    Friend WithEvents ReportRemainingQuantityBindingSource As BindingSource
    Friend WithEvents ReportRemainingQuantityTableAdapter As DataSetItemTableAdapters.ReportRemainingQuantityTableAdapter
    Friend WithEvents TableAdapterManager As DataSetItemTableAdapters.TableAdapterManager
    Friend WithEvents ReportRemainingQuantityBindingNavigator As BindingNavigator
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
    Friend WithEvents ReportRemainingQuantityBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ReportRemainingQuantityGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colName As Columns.GridColumn
    Friend WithEvents colname1 As Columns.GridColumn
    Friend WithEvents colunit As Columns.GridColumn
    Friend WithEvents colReceivedItem As Columns.GridColumn
    Friend WithEvents colDeliveredItem As Columns.GridColumn
    Friend WithEvents colRemainingQuantity As Columns.GridColumn
End Class
