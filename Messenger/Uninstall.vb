Imports System.Security.Policy
Imports System.Text
Imports LoginModule.DeploymentUtilities
Imports Microsoft.Win32

Module Uninstall

    Public Sub UninstallMe()
        Dim publicKeyToken As String = GetPublicKeyToken()
        'Find Uninstall string in registry
        Dim DisplayName As String = Nothing
        Dim uninstallString As String = _
                GetUninstallString(publicKeyToken, DisplayName)
        If (uninstallString.Length <= 0) Then
            Return
        End If

        Dim runDLL32 As String = uninstallString.Substring(0, 12)
        Dim args As String = uninstallString.Substring(13)

        'start the uninstall; this will bring up the uninstall dialog
        '  asking if it's ok
        Dim uninstallProcess As Process = Process.Start(runDLL32, args)

        'push the OK button
        PushUninstallOKButton(DisplayName)
    End Sub

    Public Function GetPublicKeyToken() As String
        Dim asi As ApplicationSecurityInfo = _
                New ApplicationSecurityInfo(AppDomain.CurrentDomain.ActivationContext)
        Dim pk As Byte() = asi.ApplicationId.PublicKeyToken
        Dim pkt As StringBuilder = New StringBuilder()
        For i As Integer = 0 To pk.GetLength(0) - 1 Step 1
            pkt.Append(String.Format("{0:x2}", pk(i)))
        Next
        Return pkt.ToString()
    End Function

    Public Function GetUninstallString(ByVal PublicKeyToken As String, _
                                              ByRef DisplayName As String) As String

        Dim uninstallString As String = Nothing

        'set up the string to search for
        Dim searchString As String = "PublicKeyToken=" & PublicKeyToken

        'open the registry key and get the subkey names
        Dim uninstallKey As RegistryKey = _
                Registry.CurrentUser.OpenSubKey("Software\Microsoft\" & _
                                                "Windows\CurrentVersion\Uninstall")
        Dim appKeyNames As String() = uninstallKey.GetSubKeyNames()

        DisplayName = Nothing
        Dim found As Boolean = False

        ''search through the list for one with a match
        For Each appKeyName As String In appKeyNames

            Dim appKey As RegistryKey = uninstallKey.OpenSubKey(appKeyName)
            uninstallString = appKey.GetValue("UninstallString").ToString()
            DisplayName = appKey.GetValue("DisplayName").ToString
            appKey.Close()
            'look for the public key token, and the display name
            '(same as ProductName in the ClickOnce properties)
            If (uninstallString.Contains(PublicKeyToken) _
                AndAlso DisplayName = "TestCertExp_VB") Then
                found = True
                Exit For
            End If

        Next

        uninstallKey.Close()

        If (found) Then
            Return uninstallString
        Else
            Return String.Empty
        End If

    End Function

    Private Function FindUninstallerWindow(ByVal DisplayName As String, _ 
        ByRef success As Boolean) As IntPtr
        ''Max number of times to look for the window,
        ''used to let you out if there's a problem.
        Dim i As Integer = 25
        Dim w32 As New DeploymentUtilsWin32()
        Dim uninstallerWindow As IntPtr = IntPtr.Zero
        Do While (uninstallerWindow = IntPtr.Zero AndAlso i > 0)
            uninstallerWindow = _
                w32.SearchForTopLevelWindow(DisplayName + " Maintenance")
            System.Threading.Thread.Sleep(500)
            i -= 1
        Loop
        If (uninstallerWindow = IntPtr.Zero) Then
            success = False
        Else
            success = True
        End If

        Return uninstallerWindow
    End Function

    Private Sub PushUninstallOKButton(ByVal DisplayName As String)
        Dim success As Boolean = False

        ''Find the uninstall dialog.
        Dim uninstallerWin As IntPtr = _
                FindUninstallerWindow(DisplayName, success)
        Dim OKButton As IntPtr = IntPtr.Zero

        ''If it found the window, look for the button.
        If (success) Then
            OKButton = FindUninstallerOKButton(uninstallerWin, success)
        End If

        ''If it found the button, press it.
        If (success) Then
            DeploymentUtilsWin32.DoButtonClick(OKButton)
        End If
    End Sub

    Private Function FindUninstallerOKButton(ByVal UninstallerWindow _
                                                       As IntPtr, ByRef success As Boolean) As IntPtr
        ''max number of times to look for the button,
        ''lets you out if there's a problem
        Dim i As Integer = 25
        Dim w32 As New DeploymentUtilsWin32()
        Dim OKButton As IntPtr = IntPtr.Zero

        Do While (OKButton = IntPtr.Zero AndAlso i > 0)
            OKButton = w32.SearchForChildWindow(UninstallerWindow, "&OK")
            System.Threading.Thread.Sleep(500)
            i -= 1
        Loop

        If (OKButton = IntPtr.Zero) Then
            success = False
        Else
            success = True
        End If

        Return OKButton
    End Function
End Module
