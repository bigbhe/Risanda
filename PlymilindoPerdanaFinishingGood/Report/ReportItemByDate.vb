Imports System.Drawing.Printing

Public Class ReportItemByDate
    Private Sub ReportItemByDate_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        labelStartDate.Text = oReport.StartDate.ToString("dddd dd MMMM", CultureInfo.InvariantCulture)
        labelEndDate.Text = oReport.endDate.ToString("dddd dd MMMM", CultureInfo.InvariantCulture)
    End Sub
End Class