Public Class ClassAccessRight
    Public Property idPosition As Integer
    Public Property idUser As Integer
    Public Property userName As String
    Public Property fullName As String
    Public Property position As String

    Public Property dataAccessUser As New DataSet


    Public Sub getUserInfo()
        If Not dbOpen() Then
            Throw New Exception("Can Not Open Database")
        End If

        dataAccessUser.Dispose()
        dataAccessUser = New DataSet

        sqlCmd = New SqlCommand With {.Connection = sqlCnn, .CommandType = CommandType.StoredProcedure, .CommandText = "GetUserAccess"}
        With sqlCmd.Parameters
            .Clear()
            .AddWithValue("@userName", userName)
        End With

        Try
            sqlDta = New SqlDataAdapter With {.SelectCommand = sqlCmd}
            sqlDta.Fill(dataAccessUser, "tableUser")
            sqlDta.Dispose()

            With dataAccessUser.Tables("tableUser")
                idUser = .Rows(0).Item(0)
                userName = .Rows(0).Item(1)
                fullName = .Rows(0).Item(2)
                idPosition = .Rows(0).Item(3)
                position = .Rows(0).Item(4)
            End With

            'idPosition = dataAccessUser.Tables("tableUser").Rows(0).Item(2)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            dbClose()
        End Try
    End Sub
End Class
