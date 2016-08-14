Imports System.ComponentModel
Imports System.Text
Imports DevExpress.LookAndFeel
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Data
Imports System.Drawing

Imports System.Windows.Forms
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors


Partial Public Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.Skins

    End Sub
    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ribcMain.Enabled = False
        frmLogin.ShowDialog()

        getRightAccess()
    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        lblDateTime.Caption = Format(Now, "HH:mm:ss") + vbCrLf + Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub btnSwitchBranch_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnSwitchBranch.ItemClick
        If Me.MdiChildren.Count > 0 Then
            If (XtraMessageBox.Show(String.Format("Not all forms has been saved.{0} If you continue this action, you will lost all unsaved data.{0} Will you continue?", vbNewLine), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.No Then
                Exit Sub
            End If
            For Each f As XtraForm In Me.MdiChildren
                f.Close()
            Next
        End If
        ribcMain.Enabled = False
    End Sub

    Private Sub btnLogout_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnLogout.ItemClick
        If Me.MdiChildren.Count > 0 Then
            If (XtraMessageBox.Show(String.Format("Not all forms has been saved.{0} If you continue this action, you will lost all unsaved data.{0} Will you continue?", vbNewLine), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.No Then
                Exit Sub
            End If
            For Each f As XtraForm In Me.MdiChildren
                f.Close()
            Next
        End If

        ribcMain.Enabled = False
        frmLogin.Show()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.MdiChildren.Count > 0 Then
            If (XtraMessageBox.Show(String.Format("Not all forms has been saved.{0} If you continue this action, you will lost all unsaved data.{0} Will you continue?", vbNewLine), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.No Then
                e.Cancel = True
            End If
        End If


        My.Settings.Skins = UserLookAndFeel.Default.SkinName




    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If Me.MdiChildren.Contains(FrmExpendable) Then
            FrmExpendable.Focus()
        Else
            FrmExpendable.MdiParent = Me
            FrmExpendable.Show()
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If Me.MdiChildren.Contains(FormUser) Then
            FormUser.Focus()
        Else
            FormUser.MdiParent = Me
            FormUser.Show()
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If Me.MdiChildren.Contains(FormChangePassword) Then
            FormChangePassword.Focus()
        Else
            FormChangePassword.MdiParent = Me
            FormChangePassword.Show()
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If Me.MdiChildren.Contains(FormCategory) Then
            FormCategory.Focus()
        Else
            FormCategory.MdiParent = Me
            FormCategory.Show()
        End If
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If Me.MdiChildren.Contains(FormCustomer) Then
            FormCustomer.Focus()
        Else
            FormCustomer.MdiParent = Me
            FormCustomer.Show()
        End If
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        If Me.MdiChildren.Contains(FormListCustomer) Then
            FormListCustomer.Focus()
        Else
            FormListCustomer.MdiParent = Me
            FormListCustomer.Show()
        End If
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If Me.MdiChildren.Contains(FormUnit) Then
            FormUnit.Focus()
        Else
            FormUnit.MdiParent = Me
            FormUnit.Show()
        End If
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If Me.MdiChildren.Contains(FormItem) Then
            FormItem.Focus()
        Else
            FormItem.MdiParent = Me
            FormItem.Show()
        End If
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        If Me.MdiChildren.Contains(FormTraReceiveHeader) Then
            FormTraReceiveHeader.Focus()
        Else
            FormTraReceiveHeader.MdiParent = Me
            FormTraReceiveHeader.Show()
        End If
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        If Me.MdiChildren.Contains(FormTraOutHeader) Then
            FormTraOutHeader.Focus()
        Else
            FormTraOutHeader.MdiParent = Me
            FormTraOutHeader.Show()
        End If
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If Me.MdiChildren.Contains(FormItemList) Then
            FormItemList.Focus()
        Else
            FormItemList.MdiParent = Me
            FormItemList.Show()
        End If
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        If Me.MdiChildren.Contains(FormReportItemByDate) Then
            FormReportItemByDate.Focus()
        Else
            'FormReportItemByDate.MdiParent = Me
            FormReportItemByDate.ShowDialog()
        End If
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        If Me.MdiChildren.Contains(FormMappingUserPosition) Then
            FormMappingUserPosition.Focus()
        Else
            FormMappingUserPosition.MdiParent = Me
            FormMappingUserPosition.Show()
        End If
    End Sub

    Public Sub getRightAccess()

        ribcMain.Enabled = True

        If oAccess.idPosition = 1 Then 'Admin
            BarButtonItem1.Enabled = False
            BarButtonItem14.Enabled = False
        End If
        If oAccess.idPosition = 2 Then 'CEO
            BarButtonItem1.Enabled = False
            BarButtonItem4.Enabled = True
            BarButtonItem7.Enabled = False
            BarButtonItem9.Enabled = True
            BarButtonItem10.Enabled = False
            BarButtonItem5.Enabled = False
            BarButtonItem6.Enabled = False
            BarButtonItem8.Enabled = False

            BarButtonItem13.Enabled = True
            BarButtonItem14.Enabled = False
        End If
        If oAccess.idPosition = 3 Then 'SuperAdmin

            BarButtonItem7.Enabled = False
            BarButtonItem9.Enabled = False
            BarButtonItem10.Enabled = False
            BarButtonItem5.Enabled = False
            BarButtonItem6.Enabled = False
            BarButtonItem8.Enabled = False
            BarButtonItem11.Enabled = False
            BarButtonItem12.Enabled = False
            BarButtonItem13.Enabled = False


        End If
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem15.ItemClick

        MsgBox(UserLookAndFeel.Default.SkinName)
        'My.Settings.Default("ApplicationSkinName") = UserLookAndFeel.Default.SkinName
        'My.Settings.Default.Save()
    End Sub
End Class