Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors


Module modMethods

    Public Function dbOpen() As Boolean
        If sqlCnn.State <> ConnectionState.Open Then
            Try
                sqlCnn.Open()
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function

    Public Function dbClose() As Boolean
        If sqlCnn.State = ConnectionState.Open Then
            Try
                sqlCnn.Close()
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function

    Public Sub AppliedRightsRibbon()

        With frmMain
            .Cursor = Cursors.WaitCursor
            .ribcMain.Enabled = True

            For Each page As RibbonPage In frmMain.ribcMain.Pages
                For Each row As DataRow In aUser.Rights.Rows
                    If Convert.ToInt32(page.Tag) = row("idModule") Then
                        page.Visible = row("canRead")
                    End If
                Next
                If page.Visible = True Then
                    For Each ctrl As Object In .ribcMain.Manager.Items
                        If ctrl.tag Is Nothing Then
                            If TypeOf ctrl Is RibbonPage Then
                                ctrl.visible = True
                            Else
                                ctrl.enabled = True
                            End If
                            Continue For
                        End If
                        For Each row As DataRow In aUser.Rights.Rows
                            Try
                                If Convert.ToInt32(ctrl.tag) = row("idModule") Then
                                    If TypeOf ctrl Is RibbonPage Then
                                        ctrl.visible = row("canRead")
                                    Else
                                        ctrl.Enabled = row("canRead")
                                    End If
                                    Exit For
                                End If
                            Catch ex As Exception

                            End Try

                        Next
                    Next
                End If
            Next

            .Cursor = Cursors.Default
        End With
    End Sub

    Public Sub AppliedFormRights(ByRef f As XtraForm, ByRef flag As FormFlags, ByVal formMode As FormOpenMode)
        If f.Tag Is Nothing Then Exit Sub

        Dim row As DataRow = aUser.Rights.Rows.Find(New Object() {Convert.ToInt32(f.Tag)})

        With flag
            .canRead = row("canRead")
            .canAdd = row("canAdd")
            .canEdit = row("canEdit")
            .canDelete = row("canDelete")
            .canPrint = row("canPrint")
            .canApprove = row("canApprove")
        End With

        For Each ctrl As Control In f.Controls
            rightsControls(ctrl, flag, formMode)
        Next
    End Sub

    Private Sub rightsControls(ByVal c As Control,
                               ByVal flag As FormFlags,
                               ByVal formMode As FormOpenMode)

        c.Enabled = False

        If c.Tag Is Nothing Then
            c.Enabled = True

            If c.HasChildren Then
                For Each ctrl As Control In c.Controls
                    rightsControls(ctrl, flag, formMode)
                Next
            End If
            Exit Sub
        End If

        Select Case c.Tag.ToString.ToUpper
            Case "INPUT"
                If formMode = FormOpenMode.OpenEdit Then
                    If flag.canAdd = True Or flag.canEdit = True Then
                        c.Enabled = True
                    End If
                End If

            Case "VIEW"
                If formMode = FormOpenMode.OpenRead Then
                    c.Enabled = True
                End If

            Case "ADD"
                If formMode = FormOpenMode.OpenRead And flag.canAdd Then
                    c.Enabled = True
                End If
            Case "EDIT"
                If formMode = FormOpenMode.OpenRead And flag.canEdit Then
                    c.Enabled = True
                End If
            Case "DELETE"
                If formMode = FormOpenMode.OpenRead And flag.canDelete Then
                    c.Enabled = True
                End If
            Case "PRINT"
                If formMode = FormOpenMode.OpenRead And flag.canPrint Then
                    c.Enabled = True
                End If
            Case "SAVE"
                If formMode = FormOpenMode.OpenEdit And flag.canAdd Then
                    c.Enabled = True
                End If
            Case "CANCEL"
                If formMode = FormOpenMode.OpenEdit And flag.canAdd Then
                    c.Enabled = True
                End If
            Case "APPROVE"
                If formMode = FormOpenMode.OpenEdit And flag.canApprove Then
                    c.Enabled = True
                End If
        End Select


    End Sub

End Module
