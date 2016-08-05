Public Class FormCrypt
    Private Sub FormCrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MemoEdit1.Text = crypt.EncryptData("GROOT") & vbNewLine & crypt.EncryptData("PlymilindoPerdanaFinishingGood") & vbNewLine & crypt.EncryptData("sa") & vbNewLine & crypt.EncryptData("123") & vbNewLine & crypt.EncryptData("admin")
    End Sub
End Class