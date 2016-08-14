Module modDescription
    Public crypt As New CryptText("CAMDEN-CLASSIC-GOLDENFISH-CLOUDLONGUE-SAFEHOUSE-POTATOHEADGARAGE")
    Public rConfig As New ReadConfig
    Public aUser As New ActiveUser
    Public oMstMember As New ClassMstMember
    Public oTraReceive As New ClassTraReceive
    Public otraOut As New ClassTraOut
    Public sqlCnn As SqlConnection
    Public sqlCmd As SqlCommand
    Public sqlDta As SqlDataAdapter
    Public sqlDtr As SqlDataReader
    Public sqlTra As SqlTransaction
    Public oReport As New ClassReport
    Public oAccess As New ClassAccessRight
    Public Enum FormOpenMode
        OpenRead
        OpenEdit
    End Enum

    Public Structure FormFlags
        Public canRead As Boolean
        Public canAdd As Boolean
        Public canEdit As Boolean
        Public canDelete As Boolean
        Public canPrint As Boolean
        Public canApprove As Boolean
    End Structure
End Module
