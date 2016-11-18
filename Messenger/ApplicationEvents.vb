Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices
Imports WHLClasses

Namespace My

    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Public AuthdEmpl As Employee
        Public Property AuthenticatedUser As Employee
            Get
                Return AuthdEmpl
            End Get
            Set(value As Employee)
                'GO away.
            End Set
        End Property
        Public Sub LogoutUser(sender As Object)
            If sender.GetType = (New Timer).GetType Then
                WHLClasses.MySQL.insertUpdate("INSERT INTO whldata.log_loginout (UserID, UserFullName, WorkstationName, Action, Time) VALUES (" + AuthdEmpl.PayrollId.ToString + ",'" + AuthdEmpl.FullName + "','" + My.Computer.Name + "','" + "LOGOUT TIMEOUT" + "','" + Now.ToShortDateString + " " + Now.ToShortTimeString + "');")
            ElseIf sender.Text = "AppClose" Then
                WHLClasses.MySQL.insertUpdate("INSERT INTO whldata.log_loginout (UserID, UserFullName, WorkstationName, Action, Time) VALUES (" + AuthdEmpl.PayrollId.ToString + ",'" + AuthdEmpl.FullName + "','" + My.Computer.Name + "','" + "LOGOUT APPCLOSE" + "','" + Now.ToShortDateString + " " + Now.ToShortTimeString + "');")
            Else
                WHLClasses.MySQL.insertUpdate("INSERT INTO whldata.log_loginout (UserID, UserFullName, WorkstationName, Action, Time) VALUES (" + AuthdEmpl.PayrollId.ToString + ",'" + AuthdEmpl.FullName + "','" + My.Computer.Name + "','" + "LOGOUT GENERIC" + "','" + Now.ToShortDateString + " " + Now.ToShortTimeString + "');")
            End If
        End Sub
        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            LogoutUser(sender)
        End Sub
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