Public Class FormChangePassword

    Private id As Integer
    Private decryptedPassword As String
    Private encryptedPassword As String
    Private newDecryptedPassword As String
    Private newEncryptedPassword As String
    Private dataIsValidated As Boolean

    Private Sub GetChangePasswordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GetChangePasswordBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GetChangePasswordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetUser)

    End Sub


    Private Sub FormChangePassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        dataIsValidated = False
        loadData()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        GetExistingData()
        convertExistingData()
        ValidatedData()
        EncryptNewPassword()

        If dataIsValidated = True Then
            Try
                GridView1.SetFocusedRowCellValue(colpassword, newEncryptedPassword)
                Save()

                For Each x As XtraForm In frmMain.MdiChildren
                    x.Close()
                Next

            Catch ex As Exception
            Finally
                Me.Close()
                frmLogin.Show()

            End Try
        End If



    End Sub

    Private Sub loadData()
        Try
            Me.GetChangePasswordTableAdapter.Fill(Me.DataSetUser.getChangePassword, New System.Nullable(Of Integer)(CType(aUser.IDUser, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub GetExistingData()
        encryptedPassword = GridView1.GetFocusedRowCellValue(colpassword)
        id = GridView1.GetFocusedRowCellValue(colidUser)
    End Sub

    Sub convertExistingData()
        decryptedPassword = crypt.DecryptData(encryptedPassword)
    End Sub

    Sub ValidatedData()
        If String.Compare(textEditOldPassword.Text, decryptedPassword) = 0 Then
            If String.Compare(textEditNewPassword.Text, textEditNewPassword2.Text) = 0 Then
                dataIsValidated = True
            Else
                alertDialogUc(Me, "Your New password doesn't match")
                textEditNewPassword2.Text = ""
                textEditNewPassword.Text = ""
                textEditNewPassword.Focus()
                dataIsValidated = False
            End If
        Else
            alertDialogUc(Me, "Your Old Password is not Correct")
            textEditOldPassword.Text = ""
            textEditOldPassword.Focus()
            dataIsValidated = False
        End If
    End Sub

    Sub EncryptNewPassword()
        newEncryptedPassword = crypt.EncryptData(textEditNewPassword.Text)
    End Sub

    Sub Save()
        Me.Validate()
        Me.GetChangePasswordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetUser)
    End Sub
End Class