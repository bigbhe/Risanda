Partial Public Class frmMain
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ribcMain = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarAndDockingController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.lblInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.lblUserInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.lblBranchInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.lblDateTime = New DevExpress.XtraBars.BarStaticItem()
        Me.btnLogout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSwitchBranch = New DevExpress.XtraBars.BarButtonItem()
        Me.btnChangePwd = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.groupMenu = New DevExpress.XtraBars.BarButtonGroup()
        Me.memberMenu = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.rpgMaster = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgTransaction = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgReports = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgSettings = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rsbMain = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.lnfMain = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ttcMain = New DevExpress.Utils.ToolTipController(Me.components)
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.mdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.ribcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribcMain
        '
        Me.ribcMain.Controller = Me.BarAndDockingController
        Me.ribcMain.ExpandCollapseItem.Id = 0
        Me.ribcMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribcMain.ExpandCollapseItem, Me.lblInfo, Me.lblUserInfo, Me.lblBranchInfo, Me.lblDateTime, Me.btnLogout, Me.btnSwitchBranch, Me.btnChangePwd, Me.SkinRibbonGalleryBarItem1, Me.groupMenu, Me.memberMenu, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem1, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11})
        Me.ribcMain.Location = New System.Drawing.Point(0, 0)
        Me.ribcMain.MaxItemId = 31
        Me.ribcMain.Name = "ribcMain"
        Me.ribcMain.PageHeaderItemLinks.Add(Me.btnChangePwd)
        Me.ribcMain.PageHeaderItemLinks.Add(Me.btnSwitchBranch)
        Me.ribcMain.PageHeaderItemLinks.Add(Me.btnLogout)
        Me.ribcMain.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpgMaster, Me.rpgTransaction, Me.rpgReports, Me.rpgSettings})
        Me.ribcMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribcMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribcMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribcMain.Size = New System.Drawing.Size(873, 143)
        Me.ribcMain.StatusBar = Me.rsbMain
        '
        'BarAndDockingController
        '
        Me.BarAndDockingController.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'lblInfo
        '
        Me.lblInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.lblInfo.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.lblInfo.AllowRightClickInMenu = False
        Me.lblInfo.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        Me.lblInfo.Caption = "Test"
        Me.lblInfo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.lblInfo.Id = 1
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblUserInfo
        '
        Me.lblUserInfo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.lblUserInfo.Id = 2
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblBranchInfo
        '
        Me.lblBranchInfo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.lblBranchInfo.Id = 3
        Me.lblBranchInfo.Name = "lblBranchInfo"
        Me.lblBranchInfo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblDateTime
        '
        Me.lblDateTime.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.lblDateTime.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.lblDateTime.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.lblDateTime.Id = 4
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        Me.lblDateTime.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnLogout
        '
        Me.btnLogout.Caption = "Logout"
        Me.btnLogout.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnLogout.Glyph = CType(resources.GetObject("btnLogout.Glyph"), System.Drawing.Image)
        Me.btnLogout.Id = 5
        Me.btnLogout.Name = "btnLogout"
        '
        'btnSwitchBranch
        '
        Me.btnSwitchBranch.Caption = "Change Branch"
        Me.btnSwitchBranch.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnSwitchBranch.Glyph = CType(resources.GetObject("btnSwitchBranch.Glyph"), System.Drawing.Image)
        Me.btnSwitchBranch.Id = 6
        Me.btnSwitchBranch.Name = "btnSwitchBranch"
        '
        'btnChangePwd
        '
        Me.btnChangePwd.Caption = "Change My Password"
        Me.btnChangePwd.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnChangePwd.Glyph = CType(resources.GetObject("btnChangePwd.Glyph"), System.Drawing.Image)
        Me.btnChangePwd.Id = 7
        Me.btnChangePwd.Name = "btnChangePwd"
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 8
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'groupMenu
        '
        Me.groupMenu.Caption = "Groups"
        Me.groupMenu.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.groupMenu.Id = 10
        Me.groupMenu.Name = "groupMenu"
        '
        'memberMenu
        '
        Me.memberMenu.Caption = "Members"
        Me.memberMenu.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.memberMenu.Id = 14
        Me.memberMenu.Name = "memberMenu"
        Me.memberMenu.Tag = "104"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 19
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 20
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "User"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 22
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.Tag = "101"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Change Password"
        Me.BarButtonItem4.Glyph = CType(resources.GetObject("BarButtonItem4.Glyph"), System.Drawing.Image)
        Me.BarButtonItem4.Id = 23
        Me.BarButtonItem4.LargeGlyph = CType(resources.GetObject("BarButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.Tag = "100"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Category"
        Me.BarButtonItem5.Glyph = CType(resources.GetObject("BarButtonItem5.Glyph"), System.Drawing.Image)
        Me.BarButtonItem5.Id = 24
        Me.BarButtonItem5.LargeGlyph = CType(resources.GetObject("BarButtonItem5.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Product"
        Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarButtonItem6.Id = 25
        Me.BarButtonItem6.LargeGlyph = CType(resources.GetObject("BarButtonItem6.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Customer"
        Me.BarButtonItem7.Glyph = CType(resources.GetObject("BarButtonItem7.Glyph"), System.Drawing.Image)
        Me.BarButtonItem7.Id = 26
        Me.BarButtonItem7.LargeGlyph = CType(resources.GetObject("BarButtonItem7.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "List Of Product"
        Me.BarButtonItem8.Glyph = CType(resources.GetObject("BarButtonItem8.Glyph"), System.Drawing.Image)
        Me.BarButtonItem8.Id = 27
        Me.BarButtonItem8.LargeGlyph = CType(resources.GetObject("BarButtonItem8.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "List Of Customer"
        Me.BarButtonItem9.Glyph = CType(resources.GetObject("BarButtonItem9.Glyph"), System.Drawing.Image)
        Me.BarButtonItem9.Id = 28
        Me.BarButtonItem9.LargeGlyph = CType(resources.GetObject("BarButtonItem9.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Unit"
        Me.BarButtonItem10.Glyph = CType(resources.GetObject("BarButtonItem10.Glyph"), System.Drawing.Image)
        Me.BarButtonItem10.Id = 29
        Me.BarButtonItem10.LargeGlyph = CType(resources.GetObject("BarButtonItem10.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Receive Item"
        Me.BarButtonItem11.Glyph = CType(resources.GetObject("BarButtonItem11.Glyph"), System.Drawing.Image)
        Me.BarButtonItem11.Id = 30
        Me.BarButtonItem11.LargeGlyph = CType(resources.GetObject("BarButtonItem11.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'rpgMaster
        '
        Me.rpgMaster.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup2})
        Me.rpgMaster.Name = "rpgMaster"
        Me.rpgMaster.Tag = "100"
        Me.rpgMaster.Text = "Master"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "User Menu"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Customer"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Barang"
        '
        'rpgTransaction
        '
        Me.rpgTransaction.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.rpgTransaction.Name = "rpgTransaction"
        Me.rpgTransaction.Tag = "200"
        Me.rpgTransaction.Text = "Transaction"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem11)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Receive"
        '
        'rpgReports
        '
        Me.rpgReports.Name = "rpgReports"
        Me.rpgReports.Tag = "300"
        Me.rpgReports.Text = "Reports"
        '
        'rpgSettings
        '
        Me.rpgSettings.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.rpgSettings.Name = "rpgSettings"
        Me.rpgSettings.Tag = "400"
        Me.rpgSettings.Text = "Settings"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Theme"
        '
        'rsbMain
        '
        Me.rsbMain.AutoHeight = True
        Me.rsbMain.ItemLinks.Add(Me.lblInfo)
        Me.rsbMain.ItemLinks.Add(Me.lblUserInfo)
        Me.rsbMain.ItemLinks.Add(Me.lblBranchInfo)
        Me.rsbMain.ItemLinks.Add(Me.lblDateTime)
        Me.rsbMain.Location = New System.Drawing.Point(0, 532)
        Me.rsbMain.Name = "rsbMain"
        Me.rsbMain.Ribbon = Me.ribcMain
        Me.rsbMain.Size = New System.Drawing.Size(873, 37)
        '
        'ttcMain
        '
        Me.ttcMain.AllowHtmlText = True
        Me.ttcMain.Appearance.Options.UseTextOptions = True
        Me.ttcMain.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ttcMain.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ttcMain.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ttcMain.AppearanceTitle.Options.UseTextOptions = True
        Me.ttcMain.AppearanceTitle.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ttcMain.AppearanceTitle.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ttcMain.Rounded = True
        Me.ttcMain.ToolTipType = DevExpress.Utils.ToolTipType.Standard
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        Me.tmrMain.Interval = 600
        '
        'mdiManager
        '
        Me.mdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.mdiManager.Controller = Me.BarAndDockingController
        Me.mdiManager.MdiParent = Me
        '
        'frmMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AllowMdiBar = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 569)
        Me.Controls.Add(Me.rsbMain)
        Me.Controls.Add(Me.ribcMain)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribcMain
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.rsbMain
        Me.Tag = "100"
        Me.Text = "Finishing Good "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private rpgMaster As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rsbMain As RibbonStatusBar
    Friend WithEvents lnfMain As LookAndFeel.DefaultLookAndFeel
    Friend WithEvents ttcMain As Utils.ToolTipController
    Public WithEvents lblInfo As XtraBars.BarStaticItem
    Friend WithEvents lblDateTime As XtraBars.BarStaticItem
    Friend WithEvents tmrMain As Timer
    Friend WithEvents BarAndDockingController As XtraBars.BarAndDockingController
    Friend WithEvents mdiManager As XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents btnLogout As XtraBars.BarButtonItem
    Friend WithEvents btnSwitchBranch As XtraBars.BarButtonItem
    Friend WithEvents btnChangePwd As XtraBars.BarButtonItem
    Friend WithEvents rpgTransaction As RibbonPage
    Friend WithEvents rpgReports As RibbonPage
    Friend WithEvents rpgSettings As RibbonPage
    Friend WithEvents SkinRibbonGalleryBarItem1 As XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents RibbonPageGroup6 As RibbonPageGroup
    Friend WithEvents groupMenu As XtraBars.BarButtonGroup
    Friend WithEvents memberMenu As XtraBars.BarButtonItem
    Public WithEvents ribcMain As RibbonControl
    Public WithEvents lblUserInfo As BarStaticItem
    Public WithEvents lblBranchInfo As BarStaticItem
    Friend WithEvents BarButtonItem2 As BarButtonItem
    Friend WithEvents BarButtonItem3 As BarButtonItem
    Friend WithEvents BarButtonItem1 As BarButtonItem
    Friend WithEvents BarButtonItem4 As BarButtonItem
    Friend WithEvents RibbonPageGroup1 As RibbonPageGroup
    Friend WithEvents BarButtonItem5 As BarButtonItem
    Friend WithEvents BarButtonItem6 As BarButtonItem
    Friend WithEvents RibbonPageGroup2 As RibbonPageGroup
    Friend WithEvents BarButtonItem7 As BarButtonItem
    Friend WithEvents BarButtonItem8 As BarButtonItem
    Friend WithEvents RibbonPageGroup3 As RibbonPageGroup
    Friend WithEvents BarButtonItem9 As BarButtonItem
    Friend WithEvents BarButtonItem10 As BarButtonItem
    Friend WithEvents BarButtonItem11 As BarButtonItem
    Friend WithEvents RibbonPageGroup4 As RibbonPageGroup
End Class
