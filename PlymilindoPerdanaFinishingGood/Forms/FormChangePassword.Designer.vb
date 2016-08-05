<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChangePassword))
        Me.DataSetUser = New PlymilindoPerdanaFinishingGood.DataSetUser()
        Me.GetChangePasswordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetChangePasswordTableAdapter = New PlymilindoPerdanaFinishingGood.DataSetUserTableAdapters.getChangePasswordTableAdapter()
        Me.TableAdapterManager = New PlymilindoPerdanaFinishingGood.DataSetUserTableAdapters.TableAdapterManager()
        Me.GetChangePasswordBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GetChangePasswordBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GetChangePasswordGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.textEditOldPassword = New DevExpress.XtraEditors.TextEdit()
        Me.textEditNewPassword = New DevExpress.XtraEditors.TextEdit()
        Me.textEditNewPassword2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetChangePasswordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetChangePasswordBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GetChangePasswordBindingNavigator.SuspendLayout()
        CType(Me.GetChangePasswordGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditOldPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditNewPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditNewPassword2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetUser
        '
        Me.DataSetUser.DataSetName = "DataSetUser"
        Me.DataSetUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetChangePasswordBindingSource
        '
        Me.GetChangePasswordBindingSource.DataMember = "getChangePassword"
        Me.GetChangePasswordBindingSource.DataSource = Me.DataSetUser
        '
        'GetChangePasswordTableAdapter
        '
        Me.GetChangePasswordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.getChangePasswordTableAdapter = Me.GetChangePasswordTableAdapter
        Me.TableAdapterManager.mstUserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PlymilindoPerdanaFinishingGood.DataSetUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GetChangePasswordBindingNavigator
        '
        Me.GetChangePasswordBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GetChangePasswordBindingNavigator.BindingSource = Me.GetChangePasswordBindingSource
        Me.GetChangePasswordBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GetChangePasswordBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GetChangePasswordBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GetChangePasswordBindingNavigatorSaveItem})
        Me.GetChangePasswordBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GetChangePasswordBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GetChangePasswordBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GetChangePasswordBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GetChangePasswordBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GetChangePasswordBindingNavigator.Name = "GetChangePasswordBindingNavigator"
        Me.GetChangePasswordBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GetChangePasswordBindingNavigator.Size = New System.Drawing.Size(852, 25)
        Me.GetChangePasswordBindingNavigator.TabIndex = 0
        Me.GetChangePasswordBindingNavigator.Text = "BindingNavigator1"
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
        'GetChangePasswordBindingNavigatorSaveItem
        '
        Me.GetChangePasswordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GetChangePasswordBindingNavigatorSaveItem.Image = CType(resources.GetObject("GetChangePasswordBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GetChangePasswordBindingNavigatorSaveItem.Name = "GetChangePasswordBindingNavigatorSaveItem"
        Me.GetChangePasswordBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GetChangePasswordBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GetChangePasswordGridControl
        '
        Me.GetChangePasswordGridControl.DataSource = Me.GetChangePasswordBindingSource
        Me.GetChangePasswordGridControl.Location = New System.Drawing.Point(676, 244)
        Me.GetChangePasswordGridControl.MainView = Me.GridView1
        Me.GetChangePasswordGridControl.Name = "GetChangePasswordGridControl"
        Me.GetChangePasswordGridControl.Size = New System.Drawing.Size(135, 154)
        Me.GetChangePasswordGridControl.TabIndex = 2
        Me.GetChangePasswordGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidUser, Me.colpassword})
        Me.GridView1.GridControl = Me.GetChangePasswordGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colidUser
        '
        Me.colidUser.FieldName = "idUser"
        Me.colidUser.Name = "colidUser"
        Me.colidUser.Visible = True
        Me.colidUser.VisibleIndex = 0
        '
        'colpassword
        '
        Me.colpassword.FieldName = "password"
        Me.colpassword.Name = "colpassword"
        Me.colpassword.Visible = True
        Me.colpassword.VisibleIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(400, 301)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(133, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Change Password"
        '
        'textEditOldPassword
        '
        Me.textEditOldPassword.Location = New System.Drawing.Point(384, 108)
        Me.textEditOldPassword.Name = "textEditOldPassword"
        Me.textEditOldPassword.Size = New System.Drawing.Size(176, 20)
        Me.textEditOldPassword.TabIndex = 4
        '
        'textEditNewPassword
        '
        Me.textEditNewPassword.Location = New System.Drawing.Point(384, 175)
        Me.textEditNewPassword.Name = "textEditNewPassword"
        Me.textEditNewPassword.Size = New System.Drawing.Size(176, 20)
        Me.textEditNewPassword.TabIndex = 5
        '
        'textEditNewPassword2
        '
        Me.textEditNewPassword2.Location = New System.Drawing.Point(384, 241)
        Me.textEditNewPassword2.Name = "textEditNewPassword2"
        Me.textEditNewPassword2.Size = New System.Drawing.Size(176, 20)
        Me.textEditNewPassword2.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(384, 89)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Type Your Old Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(384, 156)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(122, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Type Your New Password"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(384, 222)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(133, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Retype Your New Password"
        '
        'FormChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 452)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.textEditNewPassword2)
        Me.Controls.Add(Me.textEditNewPassword)
        Me.Controls.Add(Me.textEditOldPassword)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GetChangePasswordGridControl)
        Me.Controls.Add(Me.GetChangePasswordBindingNavigator)
        Me.Name = "FormChangePassword"
        Me.Text = "FormChangePassword"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetChangePasswordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetChangePasswordBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GetChangePasswordBindingNavigator.ResumeLayout(False)
        Me.GetChangePasswordBindingNavigator.PerformLayout()
        CType(Me.GetChangePasswordGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditOldPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditNewPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditNewPassword2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetUser As DataSetUser
    Friend WithEvents GetChangePasswordBindingSource As BindingSource
    Friend WithEvents GetChangePasswordTableAdapter As DataSetUserTableAdapters.getChangePasswordTableAdapter
    Friend WithEvents TableAdapterManager As DataSetUserTableAdapters.TableAdapterManager
    Friend WithEvents GetChangePasswordBindingNavigator As BindingNavigator
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
    Friend WithEvents GetChangePasswordBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents GetChangePasswordGridControl As GridControl
    Friend WithEvents GridView1 As Views.Grid.GridView
    Friend WithEvents colidUser As Columns.GridColumn
    Friend WithEvents colpassword As Columns.GridColumn
    Friend WithEvents SimpleButton1 As SimpleButton
    Friend WithEvents textEditOldPassword As TextEdit
    Friend WithEvents textEditNewPassword As TextEdit
    Friend WithEvents textEditNewPassword2 As TextEdit
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents LabelControl3 As LabelControl
End Class
