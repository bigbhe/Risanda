﻿Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            aUser.UpdateStatus()
        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Application.ChangeCulture("id-ID")
            Try
                rConfig.Read()
            Catch ex As Exception

            End Try

            My.Settings.Item("connString") = rConfig.Result

            sqlCnn = New SqlConnection(My.Settings.ConnString)
            'MsgBox(sqlCnn.DataSource.ToString)
        End Sub
    End Class
End Namespace