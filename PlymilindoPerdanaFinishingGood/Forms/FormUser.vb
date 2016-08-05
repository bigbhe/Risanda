Imports DevExpress.XtraGrid.Views.Base

Public Class FormUser
    Private afterDelete As Boolean

    Private lockPasswordField As Boolean

    Private Sub MstUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MstUserBindingNavigatorSaveItem.Click

        If afterDelete = True Then
            Me.Validate()
            Me.MstUserBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSetUser)
            afterDelete = False
        Else
            If CheckPassword() = False Then
                alertDialogUc(Me, "Password Not Match")
                Exit Sub
            End If
            Try

                Dim cryptedPassword As String = crypt.EncryptData(passwordTextEdit.Text)
                GridView1.SetFocusedRowCellValue(colpassword, cryptedPassword)
                Me.Validate()
                Me.MstUserBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataSetUser)
            Catch ex As Exception
            Finally
                passwordTextEdit.Enabled = False
                TextEditRePassword.Enabled = False
                lockPasswordField = True
            End Try
        End If






    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetUser.mstUser' table. You can move, or remove it, as needed.

        lockPasswordField = True
        passwordTextEdit.Enabled = False

        Me.MstUserTableAdapter.Fill(Me.DataSetUser.mstUser)
        'GridView1.BestFitColumns(True)
    End Sub

    Private Sub passwordTextEdit_Click(sender As Object, e As EventArgs) Handles passwordTextEdit.Click
        If lockPasswordField = True Then
            alertDialogUc(Me, "Password Field Cannot be edited through this Form")
            usernameTextEdit.Focus()

        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        lockPasswordField = False

        passwordTextEdit.Enabled = True
        TextEditRePassword.Enabled = True

        usernameTextEdit.Focus()

    End Sub
    Function CheckPassword() As Boolean
        Dim pass1 As String
        Dim pass2 As String

        pass1 = passwordTextEdit.Text
        pass2 = TextEditRePassword.Text

        If String.Compare(pass1, pass2) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        afterDelete = True

        lockPasswordField = False

        passwordTextEdit.Enabled = False
        TextEditRePassword.Enabled = False
    End Sub

    Private Sub TextEditRePassword_TextChanged(sender As Object, e As EventArgs) Handles TextEditRePassword.TextChanged
        If lockPasswordField = True Then
            passwordTextEdit.Text = TextEditRePassword.Text
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        passwordTextEdit.Text = TextEditRePassword.Text
    End Sub
End Class