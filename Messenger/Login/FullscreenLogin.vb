Imports System.Windows.Forms
Imports System.Deployment
Imports System.Runtime.InteropServices
Imports WHLClasses
Imports System.IO
Imports System.Speech.Synthesis

Public Class FullscreenLogin


    Public AppVerStr As String
    Public AuthdEmpl As Employee
    Dim AuthTimeout As Integer
    Public AuthdLoginTime

    Public Standalone As Boolean = True

    Public Property AuthenticatedUser As Employee
        Get
            Return AuthdEmpl
        End Get
        Set(value As Employee)
            'GO away.
        End Set
    End Property
    Public ReadOnly Property LoginTimeout As Integer
        Get
            Return AuthTimeout
        End Get
    End Property


    Public Authd As Boolean = False 'This is to know whether a person is logged in or not
    Public targetkey As String = ""

    Dim cursorpos As New System.Drawing.Point
    Dim timerout As Integer = 0
    Dim timerprog As Integer = 0
    Dim timertickb As Boolean = False
    Dim EmployeeList As New EmployeeCollection

    Public Sub InitAuth()
        Me.Show()
        AutoLoginMaker.Enabled = True
    End Sub

    Public Sub Autologin()

        'Autologin for users who have the file. 
        Try
            If My.Computer.FileSystem.FileExists("Z:\DomainProfiles\WHL\AutoLogin") Then
                'The file exists, good. 
                Dim ALReader As StreamReader = My.Computer.FileSystem.OpenTextFileReader("Z:\DomainProfiles\WHL\AutoLogin")
                Userbox.Text = ALReader.ReadToEnd()
                Button1_Click(Nothing, Nothing)
            Else
                'Do nothing, the file doesn't exist so we need not panic. 
                Me.Show()
            End If
        Catch ex As Exception
            'Probably didn't have the file. No action needed, they can just login as normal. 
            Me.Show()

        End Try

    End Sub

    Private Sub StartTimer()
        If Authd Then
            timertickb = False
            Idletimer.Start()
            Console.WriteLine(Now.ToLongTimeString + " - Started")
        End If
        timerprog = 0
    End Sub

    Private Sub StopTimer()
        Idletimer.Stop()
        Console.WriteLine("Stopped")

    End Sub

    Public Sub replaceUser(NewUser As String)
        Dim fakesender As New Label
        fakesender.Text = "Replace"
        LogoutUser(fakesender)
        Userbox.Text = NewUser
        LoginButton.PerformClick()
    End Sub

    Public Sub LogoutUser(sender As Object)
        If sender.GetType = (New Timer).GetType Then
            WHLClasses.MySql.insertupdate("INSERT INTO whldata.log_loginout (UserID, UserFullName, WorkstationName, Action, Time) VALUES (" + AuthdEmpl.PayrollId.ToString + ",'" + AuthdEmpl.FullName + "','" + My.Computer.Name + "','" + "LOGOUT TIMEOUT" + "','" + Now.ToShortDateString + " " + Now.ToShortTimeString + "');")
        ElseIf sender.Text = "AppClose" Then
            WHLClasses.MySql.insertupdate("INSERT INTO whldata.log_loginout (UserID, UserFullName, WorkstationName, Action, Time) VALUES (" + AuthdEmpl.PayrollId.ToString + ",'" + AuthdEmpl.FullName + "','" + My.Computer.Name + "','" + "LOGOUT APPCLOSE" + "','" + Now.ToShortDateString + " " + Now.ToShortTimeString + "');")
        Else
            WHLClasses.MySql.insertupdate("INSERT INTO whldata.log_loginout (UserID, UserFullName, WorkstationName, Action, Time) VALUES (" + AuthdEmpl.PayrollId.ToString + ",'" + AuthdEmpl.FullName + "','" + My.Computer.Name + "','" + "LOGOUT GENERIC" + "','" + Now.ToShortDateString + " " + Now.ToShortTimeString + "');")
        End If
        Authd = False
        StopTimer()
        Me.Show()
        If Standalone Then
            Notifyicon.Visible = False
            FireNotifications.Enabled = False
        End If
        FireNotifications.Enabled = False
    End Sub

    Private Sub TimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles Idletimer.Tick
        If Cursor.Position = cursorpos Then
            'Hasn't moved
            If timerprog > timerout Then
                'ITS HAPPENING
                LogoutUser(sender)
            Else
                If Standalone Then
                Else
                    timerprog = timerprog + 1
                End If

            End If
        Else
            cursorpos = Cursor.Position
            timerprog = 0
        End If

    End Sub


    ''' '''''''''''''''''''''''''''''''Awful'''''''''''''''''''''''''''''''


    Private Sub FullscreenLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = My.Computer.Screen.Bounds.Size
        Me.Hide()
        If Standalone Then
            Me.BackColor = Drawing.Color.Magenta
            Me.BackgroundImage = Nothing
            Keypadcover.Visible = False

        End If
        InitAuth()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'Try to find a person in the file.
        Dim userid As String
        Dim CardUsed As Boolean = False
        If Userbox.Text.StartsWith("qzu") Then
            userid = Userbox.Text.Substring(3)
            CardUsed = True
        ElseIf Userbox.TextLength = 0 Then
            userid = 0
        Else
            userid = Userbox.Text
        End If
        Dim target As Employee
        Try
            Try
                target = EmployeeList.FindEmployeeByID(Convert.ToInt16(userid))
                If CardUsed = False Then
                    'Check the pin
                    Dim keyback As DialogResult
                    Dim keypad As New keypad
                    keyback = keypad.ShowDialog
                    If keyback = DialogResult.OK Then
                        Try
                            If target.CheckPin(keypad.PinBox.Text) Then
                                'Success.
                                AuthdEmpl = target
                                LoginSuccess()
                            End If
                        Catch ex As Exception
                            Userbox.Focus()
                            Userbox.Clear()
                            Userbox.Text = ""
                            loginfail.Visible = True
                        End Try
                    Else
                        Userbox.Focus()
                        Userbox.Clear()
                        Userbox.Text = ""
                    End If
                Else
                    AuthdEmpl = target
                    LoginSuccess()
                End If
            Catch eax As Exception
                Dim Speech As New SpeechSynthesizer
                Speech.SetOutputToDefaultAudioDevice()
                Speech.SpeakAsync("Please login before trying to scan something.")
                Userbox.Focus()
                Userbox.Clear()
                Userbox.Text = ""
                loginfail.Visible = True
            End Try
        Catch ex As WHLClasses.Exceptions.EmployeeNotFoundException
            Userbox.Focus()
            Userbox.Clear()
            Userbox.Text = ""
            loginfail.Visible = True
        End Try


    End Sub

    Public Sub HidePanel()
        PanelMain.Visible = False
    End Sub

    Private Sub LoginSuccess()
        Authd = True
        AuthdLoginTime = Now.ToLongTimeString
        Me.Hide()
        timerout = AuthdEmpl.LoginTimeout
        StartTimer()
        FireNotifications.Enabled = True
        If Standalone Then
            Notifyicon.Visible = True
            'Notifyicon.ShowBalloonTip(6000)
            Notifyicon.Text = AuthdEmpl.FullName + " - Online | WHL Messenger"
            MessengerMain.Show()
            MessengerMain.Activate()
        End If

        'And we need to record the login to the login log.
        WHLClasses.MySql.insertupdate("INSERT INTO whldata.log_loginout (UserID, UserFullName, WorkstationName, Action, Time) VALUES (" + AuthdEmpl.PayrollId.ToString + ",'" + AuthdEmpl.FullName + "','" + My.Computer.Name + "','" + "LOGIN" + "','" + Now.ToShortDateString + " " + Now.ToShortTimeString + "');")

    End Sub


    Private Sub FullscreenLogin_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Authd = False Then
            e.Cancel = True
        End If
    End Sub
    Dim FirstLogin As Boolean = True
    Private Sub FullscreenLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown, MyBase.Activated
        loginfail.Visible = False
        Userbox.Focus()
        Userbox.Clear()
        Userbox.Text = ""
        AppVer.Text = My.Application.Info.AssemblyName.ToString + " - v" + AppVerStr
        If Standalone Then
            Keypadcover.Visible = False
            ControlBox.Visible = True
            AppVer.Visible = False
            PowerButton.Visible = False
            FSLoginWindowText.Text = "Messenger Login"
        Else
            Keypadcover.Visible = True
            ControlBox.Visible = False
            AppVer.Visible = True
            PowerButton.Visible = True
            FSLoginWindowText.Text = "Login"
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Userbox.Text = Userbox.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Userbox.Text = Userbox.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Userbox.Text = Userbox.Text + "3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Userbox.Text = Userbox.Text + "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Userbox.Text = Userbox.Text + "5"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Userbox.Text = Userbox.Text + "6"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Userbox.Text = Userbox.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Userbox.Text = Userbox.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Userbox.Text = Userbox.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Userbox.Text = Userbox.Text + "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Userbox.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PowerButton.Click
        If shutdownlabel.Visible = True Then
            Process.Start("C:\Windows\System32\shutdown.exe", "/s /t 120 /f")
            shutdownlabel.Text = "The system will shut down in around 2 Minutes."
        Else
            shutdownlabel.Visible = True
        End If
    End Sub

    Private Sub AppVer_Click(sender As Object, e As EventArgs) Handles AppVer.Click
        Keypadcover.Visible = False
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, MyBase.Click, Keypadcover.Click
        Userbox.Focus()
        Userbox.Clear()
        Userbox.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Dim NewNotifier As New Notification
        NewNotifier.Show()
    End Sub

    Private Sub FireNotifications_Tick(sender As Object, e As EventArgs) Handles FireNotifications.Tick
        Dim ActuallyDidAny As Boolean = False
        FireNotifications.Interval = 5000

        FireNotifications.Enabled = False

        Dim NotifsWaiting As New ArrayList
        Dim startpos As Integer = 12
        NotifsWaiting = WHLClasses.MySql.SelectData("SELECT * FROM whldata.user_notifications WHERE payrollId=" + My.FindWindow().AuthenticatedUser.PayrollId.ToString + " AND notIsRead='True';")
        For Each Notideath As ArrayList In NotifsWaiting
            Dim newNotification As New Notification
            newNotification.NotificationTitle.Text = Notideath(2)
            'newNotification.NotificationBody.Text = Notideath(3) //Dead now
            newNotification.NotifID = Notideath(0)
            newNotification.Startpos = startpos
            newNotification.DateBox.Text = Notideath(5).ToString
            newNotification.EmpId = Notideath(8)
            If Notideath(4).ToString = "Message" Then
                'newNotification.NotificationBody.Visible = False //Dead now
                newNotification.Body2.Visible = True
                newNotification.Body2.Text = Notideath(3)

                '-----   -----  -----   -----   -----
                '07/05/16 - Gotta get rid of the "TheMessageBeginsHere" at the start
                newNotification.Body2.Text = newNotification.Body2.Text.Replace("--TMBH--", "")
                '-----   -----  -----   -----   -----

                newNotification.IconBox.Visible = True
            End If
            If Notideath(7).ToString.Length > 0 Then
                newNotification.IconBox.ImageLocation = Notideath(7)
            End If
            Dim hwnd As Integer
            hwnd = User32.GetActiveWindow
            newNotification.Show()
            User32.SetActiveWindow(hwnd)
            startpos = startpos + 180
            If startpos > 960 Then startpos = 12
            ActuallyDidAny = True
        Next
        If ActuallyDidAny Then
        Else
            FireNotifications.Enabled = True
        End If

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LogoutUser(sender)
    End Sub

    Private Sub SendANotificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendANotificationToolStripMenuItem.Click
        CreateNotification.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem1Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        LogoutUser(sender)
        End
    End Sub

    Private Sub Notifyicon_DoubleClick(sender As Object, e As EventArgs) Handles Notifyicon.DoubleClick
        MessengerMain.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        End
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub AutoLoginMaker_Tick(sender As Object, e As EventArgs) Handles AutoLoginMaker.Tick
        AutoLoginMaker.Enabled = False
        Autologin()

    End Sub

    Private Sub Userbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Userbox.KeyDown, Userbox.KeyUp
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
End Class

Public Class User32

    <DllImport("user32", CharSet:=CharSet.Auto)>
    Public Shared Function GetActiveWindow() As Integer

    End Function

    <DllImport("user32", CharSet:=CharSet.Auto)>
    Public Shared Function SetActiveWindow(ByVal hwnd As Integer) As Integer

    End Function
End Class