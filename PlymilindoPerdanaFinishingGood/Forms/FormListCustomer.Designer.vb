<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListCustomer
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.mstCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCustomer1 = New PlymilindoPerdanaFinishingGood.DataSetCustomer()
        Me.MstCustomerTableAdapter1 = New PlymilindoPerdanaFinishingGood.DataSetCustomerTableAdapters.mstCustomerTableAdapter()
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colid = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colphoneNumber = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colfaximile = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colwebsite = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.collogo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.layoutViewField_colid = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colAddress = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colphoneNumber = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colfaximile = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_GridColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colwebsite = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_collogo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mstCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCustomer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colphoneNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colfaximile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_GridColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colwebsite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_collogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.mstCustomerBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.LayoutView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(953, 594)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LayoutView1})
        '
        'mstCustomerBindingSource
        '
        Me.mstCustomerBindingSource.DataMember = "mstCustomer"
        Me.mstCustomerBindingSource.DataSource = Me.DataSetCustomer1
        Me.mstCustomerBindingSource.Sort = "Name ASC"
        '
        'DataSetCustomer1
        '
        Me.DataSetCustomer1.DataSetName = "DataSetCustomer"
        Me.DataSetCustomer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MstCustomerTableAdapter1
        '
        Me.MstCustomerTableAdapter1.ClearBeforeFill = True
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSplitContainer1.Grid = Me.GridControl1
        Me.GridSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        Me.GridSplitContainer1.Panel1.Controls.Add(Me.GridControl1)
        Me.GridSplitContainer1.Size = New System.Drawing.Size(953, 594)
        Me.GridSplitContainer1.TabIndex = 0
        '
        'LayoutView1
        '
        Me.LayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colid, Me.colName, Me.colAddress, Me.colphoneNumber, Me.colfaximile, Me.GridColumn1, Me.colwebsite, Me.collogo})
        Me.LayoutView1.GridControl = Me.GridControl1
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.LayoutViewField = Me.layoutViewField_colid
        Me.colid.Name = "colid"
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.LayoutViewField = Me.layoutViewField_colName
        Me.colName.Name = "colName"
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.LayoutViewField = Me.layoutViewField_colAddress
        Me.colAddress.Name = "colAddress"
        '
        'colphoneNumber
        '
        Me.colphoneNumber.FieldName = "phoneNumber"
        Me.colphoneNumber.LayoutViewField = Me.layoutViewField_colphoneNumber
        Me.colphoneNumber.Name = "colphoneNumber"
        '
        'colfaximile
        '
        Me.colfaximile.FieldName = "faximile"
        Me.colfaximile.LayoutViewField = Me.layoutViewField_colfaximile
        Me.colfaximile.Name = "colfaximile"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "e-mail"
        Me.GridColumn1.LayoutViewField = Me.layoutViewField_GridColumn1
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colwebsite
        '
        Me.colwebsite.FieldName = "website"
        Me.colwebsite.LayoutViewField = Me.layoutViewField_colwebsite
        Me.colwebsite.Name = "colwebsite"
        '
        'collogo
        '
        Me.collogo.FieldName = "logo"
        Me.collogo.LayoutViewField = Me.layoutViewField_collogo
        Me.collogo.Name = "collogo"
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colid, Me.layoutViewField_colName, Me.layoutViewField_colAddress, Me.layoutViewField_colphoneNumber, Me.layoutViewField_colfaximile, Me.layoutViewField_GridColumn1, Me.layoutViewField_colwebsite, Me.layoutViewField_collogo})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        '
        'layoutViewField_colid
        '
        Me.layoutViewField_colid.EditorPreferredWidth = 121
        Me.layoutViewField_colid.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colid.Name = "layoutViewField_colid"
        Me.layoutViewField_colid.Size = New System.Drawing.Size(330, 24)
        Me.layoutViewField_colid.TextSize = New System.Drawing.Size(74, 13)
        '
        'layoutViewField_colName
        '
        Me.layoutViewField_colName.EditorPreferredWidth = 121
        Me.layoutViewField_colName.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_colName.Name = "layoutViewField_colName"
        Me.layoutViewField_colName.Size = New System.Drawing.Size(330, 24)
        Me.layoutViewField_colName.TextSize = New System.Drawing.Size(74, 13)
        '
        'layoutViewField_colAddress
        '
        Me.layoutViewField_colAddress.EditorPreferredWidth = 121
        Me.layoutViewField_colAddress.Location = New System.Drawing.Point(0, 48)
        Me.layoutViewField_colAddress.Name = "layoutViewField_colAddress"
        Me.layoutViewField_colAddress.Size = New System.Drawing.Size(330, 24)
        Me.layoutViewField_colAddress.TextSize = New System.Drawing.Size(74, 13)
        '
        'layoutViewField_colphoneNumber
        '
        Me.layoutViewField_colphoneNumber.EditorPreferredWidth = 121
        Me.layoutViewField_colphoneNumber.Location = New System.Drawing.Point(0, 72)
        Me.layoutViewField_colphoneNumber.Name = "layoutViewField_colphoneNumber"
        Me.layoutViewField_colphoneNumber.Size = New System.Drawing.Size(330, 24)
        Me.layoutViewField_colphoneNumber.TextSize = New System.Drawing.Size(74, 13)
        '
        'layoutViewField_colfaximile
        '
        Me.layoutViewField_colfaximile.EditorPreferredWidth = 121
        Me.layoutViewField_colfaximile.Location = New System.Drawing.Point(0, 96)
        Me.layoutViewField_colfaximile.Name = "layoutViewField_colfaximile"
        Me.layoutViewField_colfaximile.Size = New System.Drawing.Size(330, 24)
        Me.layoutViewField_colfaximile.TextSize = New System.Drawing.Size(74, 13)
        '
        'layoutViewField_GridColumn1
        '
        Me.layoutViewField_GridColumn1.EditorPreferredWidth = 121
        Me.layoutViewField_GridColumn1.Location = New System.Drawing.Point(0, 120)
        Me.layoutViewField_GridColumn1.Name = "layoutViewField_GridColumn1"
        Me.layoutViewField_GridColumn1.Size = New System.Drawing.Size(330, 24)
        Me.layoutViewField_GridColumn1.TextSize = New System.Drawing.Size(74, 13)
        '
        'layoutViewField_colwebsite
        '
        Me.layoutViewField_colwebsite.EditorPreferredWidth = 121
        Me.layoutViewField_colwebsite.Location = New System.Drawing.Point(0, 144)
        Me.layoutViewField_colwebsite.Name = "layoutViewField_colwebsite"
        Me.layoutViewField_colwebsite.Size = New System.Drawing.Size(330, 24)
        Me.layoutViewField_colwebsite.TextSize = New System.Drawing.Size(74, 13)
        '
        'layoutViewField_collogo
        '
        Me.layoutViewField_collogo.EditorPreferredWidth = 121
        Me.layoutViewField_collogo.Location = New System.Drawing.Point(0, 168)
        Me.layoutViewField_collogo.Name = "layoutViewField_collogo"
        Me.layoutViewField_collogo.Size = New System.Drawing.Size(330, 26)
        Me.layoutViewField_collogo.StartNewLine = True
        Me.layoutViewField_collogo.TextSize = New System.Drawing.Size(74, 13)
        '
        'FormListCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 594)
        Me.Controls.Add(Me.GridSplitContainer1)
        Me.Name = "FormListCustomer"
        Me.Text = "FormListCustomer"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mstCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCustomer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colphoneNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colfaximile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_GridColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colwebsite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_collogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As GridControl
    Friend WithEvents mstCustomerBindingSource As BindingSource
    Friend WithEvents DataSetCustomer1 As DataSetCustomer
    Friend WithEvents MstCustomerTableAdapter1 As DataSetCustomerTableAdapters.mstCustomerTableAdapter
    Friend WithEvents LayoutView1 As Views.Layout.LayoutView
    Friend WithEvents colid As Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colid As Views.Layout.LayoutViewField
    Friend WithEvents colName As Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colName As Views.Layout.LayoutViewField
    Friend WithEvents colAddress As Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colAddress As Views.Layout.LayoutViewField
    Friend WithEvents colphoneNumber As Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colphoneNumber As Views.Layout.LayoutViewField
    Friend WithEvents colfaximile As Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colfaximile As Views.Layout.LayoutViewField
    Friend WithEvents GridColumn1 As Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_GridColumn1 As Views.Layout.LayoutViewField
    Friend WithEvents colwebsite As Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colwebsite As Views.Layout.LayoutViewField
    Friend WithEvents collogo As Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_collogo As Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As Views.Layout.LayoutViewCard
    Friend WithEvents GridSplitContainer1 As GridSplitContainer
End Class
