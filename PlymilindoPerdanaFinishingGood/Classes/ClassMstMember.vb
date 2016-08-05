Public Class ClassMstMember
    Public Property idBranch As Integer
    Public Property listOfId As New DataSet
    Public Property idMember As String


    Public Sub getId()

        If Not dbOpen() Then
            XtraMessageBox.Show("System failed open connection to SQL Server.", "System Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
        sqlCmd = New SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlCnn, .CommandText = "getMemberNumber"}
        With sqlCmd.Parameters
            .Clear()
            .AddWithValue("idBranch", idBranch)
        End With
        listOfId.Dispose()
        listOfId = New DataSet
        sqlDta = New SqlDataAdapter With {.SelectCommand = sqlCmd}
        sqlDta.Fill(listOfId, "listOfId")
        dbClose()
        sqlCmd.Dispose()
        idMember = listOfId.Tables(0).Rows(0)(0)
    End Sub
End Class
