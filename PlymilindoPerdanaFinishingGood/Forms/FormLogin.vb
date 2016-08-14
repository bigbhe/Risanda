Public Class frmLogin
    Private isApproved As Boolean

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Me.MdiParent = frmMain
        frmMain.lblUserInfo.Caption = ""
        frmMain.lblBranchInfo.Caption = ""
        isApproved = False
        'Login()
    End Sub

    Private Sub _GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus, txtPassword.GotFocus
        Dim c As TextEdit = sender

        If c.Text.Length > 0 Then c.SelectAll()

        If c.ToolTip.Length > 0 Then
            frmMain.lblInfo.Caption = c.ToolTip
        End If
    End Sub

    Private Sub _LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus, txtPassword.LostFocus
        Try
            frmMain.lblInfo.Caption = ""
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Login()
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If isApproved Then
            '
            ' call form for choosing branch
            '
            'frmOpenBranch.Show()
            'AppliedRightsRibbon()

        Else
            Application.ExitThread()
        End If
    End Sub
    Sub Login()
        '
        ' UI level validation
        '
        'txtUsername.Text = "Dian"
        'txtPassword.Text = "admin"

        If txtUsername.Text.Length = 0 Then
            XtraMessageBox.Show("Your account name still empty.", "Data Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text.Length = 0 Then
            XtraMessageBox.Show("Your password still empty.", "Data Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If

        aUser.Username = txtUsername.Text
        aUser.Password = txtPassword.Text 'it will be encrypted in class UserActive
        Select Case aUser.DoValidation
            Case 0

                oAccess.userName = txtUsername.Text
                oAccess.getUserInfo()

                frmMain.getRightAccess()


                isApproved = True
                Me.Close()
            Case 1
                XtraMessageBox.Show("Your username not valid.", "Data Unmatched", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
                Exit Sub
            Case 2
                XtraMessageBox.Show("Your password not valid.", "Data Unmatched", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()
                Exit Sub
            Case 3
                XtraMessageBox.Show("Your account is currently loggon from other terminal.", "Account Logged On", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsername.Focus()
                Exit Sub
            Case 4
                XtraMessageBox.Show("Your account has been blocked by Administrator.", "Account Blocked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsername.Focus()
                Exit Sub
            Case Else
                Exit Sub
        End Select
    End Sub
End Class