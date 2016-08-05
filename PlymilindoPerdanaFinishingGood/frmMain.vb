Imports System.ComponentModel
Imports System.Text


Partial Public Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ribcMain.Enabled = False
        frmLogin.Show()

    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        lblDateTime.Caption = Format(Now, "HH:mm:ss") + vbCrLf + Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub groupRightsMenu_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs)
        'If Me.MdiChildren.Contains(FrmExpendable) Then
        '    FrmExpendable.Focus()
        'Else
        '    FrmExpendable.MdiParent = Me
        '    FrmExpendable.Show()
        'End If
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
        'frmOpenBranch.Show()
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
    End Sub

    Private Sub memberMenu_ItemClick(sender As Object, e As ItemClickEventArgs) Handles memberMenu.ItemClick
        'If Me.MdiChildren.Contains(frmMember) Then
        '    frmMember.Focus()
        'Else
        '    frmMember.MdiParent = Me
        '    frmMember.Show()
        'End If
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
End Class