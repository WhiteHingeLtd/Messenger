Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            WHLClasses.Reporting.ReportException(e.Exception)
            e.ExitApplication = False
        End Sub
    End Class

    Public Module FSL
        Public Function FindWindow() As FullscreenLogin
            For Each wind As Form In My.Application.OpenForms
                If wind.Text = "FSLWindow" Then
                    Return wind
                End If
            Next
            Return Nothing
        End Function
    End Module
End Namespace