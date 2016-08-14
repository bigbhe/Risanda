<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportItemByDate
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
        Me.ReportDeliveryPerNumberTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetTraOutHeaderTableAdapters.reportDeliveryPerNumberTableAdapter()
        Me.DataSetReportItem = New PlymilindoPerdanaFinishingGood.DataSetReportItem()
        Me.ReportTransactionByDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportTransactionByDateTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetReportItemTableAdapters.ReportTransactionByDateTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetReportItemTableAdapters.TableAdapterManager()
        Me.ReportTransactionByDateGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.DataSetReportItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTransactionByDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTransactionByDateGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportDeliveryPerNumberTableAdapter
        '
        Me.ReportDeliveryPerNumberTableAdapter.ClearBeforeFill = True
        '
        'DataSetReportItem
        '
        Me.DataSetReportItem.DataSetName = "DataSetReportItem"
        Me.DataSetReportItem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportTransactionByDateBindingSource
        '
        Me.ReportTransactionByDateBindingSource.DataMember = "ReportTransactionByDate"
        Me.ReportTransactionByDateBindingSource.DataSource = Me.DataSetReportItem
        '
        'ReportTransactionByDateTableAdapter
        '
        Me.ReportTransactionByDateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetReportItemTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReportTransactionByDateGridControl
        '
        Me.ReportTransactionByDateGridControl.DataSource = Me.ReportTransactionByDateBindingSource
        Me.ReportTransactionByDateGridControl.Location = New System.Drawing.Point(645, 334)
        Me.ReportTransactionByDateGridControl.MainView = Me.GridView1
        Me.ReportTransactionByDateGridControl.Name = "ReportTransactionByDateGridControl"
        Me.ReportTransactionByDateGridControl.Size = New System.Drawing.Size(149, 168)
        Me.ReportTransactionByDateGridControl.TabIndex = 2
        Me.ReportTransactionByDateGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.ReportTransactionByDateGridControl
        Me.GridView1.Name = "GridView1"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(26, 60)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 3
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(179, 60)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(100, 117)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Load Report"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(29, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Start Date"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(179, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "End Date"
        '
        'FormReportItemByDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 168)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.DateEdit2)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.ReportTransactionByDateGridControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReportItemByDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReportItemByDate"
        CType(Me.DataSetReportItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTransactionByDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTransactionByDateGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportDeliveryPerNumberTableAdapter As DataSetTraOutHeaderTableAdapters.reportDeliveryPerNumberTableAdapter
    Friend WithEvents DataSetReportItem As DataSetReportItem
    Friend WithEvents ReportTransactionByDateBindingSource As BindingSource
    Friend WithEvents ReportTransactionByDateTableAdapter As DataSetReportItemTableAdapters.ReportTransactionByDateTableAdapter
    Friend WithEvents TableAdapterManager As DataSetReportItemTableAdapters.TableAdapterManager
    Friend WithEvents ReportTransactionByDateGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents DateEdit1 As DateEdit
    Friend WithEvents DateEdit2 As DateEdit
    Friend WithEvents SimpleButton1 As SimpleButton
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
End Class
