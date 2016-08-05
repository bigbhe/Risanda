Imports DevExpress.XtraBars.Alerter
Module ModuleAdditional
#Region "Dialog"
    Public Function deleteDialog(ByVal deleteObject As String) As Integer
        If XtraMessageBox.Show("Do You want to Delete this data: " & deleteObject, "Attention", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Sub alertDialog(Frm As Form, alertObject As String, condition As String)
        Dim e As New AlertControl
        e.Show(Frm, "Attention", "Data " & alertObject & "has been " & condition & " Database")
        '  e.AlertFormList(e.AlertFormList.Count - 1).OpacityLevel = 0.05
    End Sub

    Public Sub alertDialogUc(frm As Form, condition As String)
        Dim e As New AlertControl
        e.Show(frm, "Attention", condition)
    End Sub
    Public Sub alertDialogDuplicate(Frm As Form, alertObject As String, condition As String)
        Dim e As New AlertControl
        Beep()
        e.Show(Frm, "Attention", "Cannot Insert:  " & alertObject & " into Database " & condition)

    End Sub
#End Region

#Region "Clear"
    Public Sub EmptyTxt(ByVal Frm As Form)
        Dim Ctl As Control
        For Each Ctl In Frm.Controls
            If TypeOf Ctl Is DevExpress.XtraEditors.TextEdit Then CType(Ctl, DevExpress.XtraEditors.TextEdit).EditValue = ""
            If TypeOf Ctl Is DevExpress.XtraEditors.GroupControl Then
                Dim Ctl1 As Control
                For Each Ctl1 In Ctl.Controls
                    If TypeOf Ctl1 Is DevExpress.XtraEditors.TextEdit Then
                        Ctl1.Text = ""
                    End If
                Next
            End If



            If TypeOf Ctl Is DevExpress.XtraLayout.LayoutControl Then
                Dim Ctl1 As Control
                For Each Ctl1 In Ctl.Controls
                    If TypeOf Ctl1 Is DevExpress.XtraEditors.TextEdit Then
                        Ctl1.Text = ""
                    End If
                    If TypeOf Ctl1 Is DevExpress.XtraEditors.SpinEdit Then
                        Ctl1.Text = ""
                    End If
                    If TypeOf Ctl1 Is DevExpress.XtraEditors.LookUpEdit Then
                        Ctl1.Text = ""
                    End If
                Next
            End If
        Next
    End Sub
#End Region
#Region "Form State"
    Public Sub editMode(ByVal container As Control)
        '    If TypeOf container Is BaseEdit Then
        '        'subscribe to the current control's events
        '        Enabled = False

        '    Else
        '        'process all child controls recursively
        '        For Each c As Control In container.Controls
        '            Enabled = False

        '        Next c
        '    End If
    End Sub
#End Region

End Module
