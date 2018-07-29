Imports System.Drawing
Imports WHLClasses

Public Class MessengerMain

    Public EmpList As New WHLClasses.EmployeeCollection
    Dim IconFlashMode As Integer = 0

    Private Sub MessengerMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Text = My.FSL.FindWindow().AuthenticatedUser.FullName + " - Online | WHL Messenger"
        LoggedUserNew.Titletext = My.FSL.FindWindow().AuthenticatedUser.FullName
        UpdateContactStatus()
        Set_Inbox(sender, e)

        UninstallDialog.Show()
    End Sub

    Public Sub Notify_Start()
        IconSwapper.Enabled = True
    End Sub
    Public Sub Notify_End()
        IconSwapper.Enabled = False
        Me.Icon = My.Resources.chacticon
        IconFlashMode = 0
    End Sub

    Private Sub AddContact(emp As Employee)
        If emp.PayrollId = My.FSL.FindWindow().AuthenticatedUser.PayrollId Then
            'ignore this one, no point chatting to ourself.
        Else
            'This is the one to use.
            Dim NewContactListing As New Messenger_Contact
            NewContactListing.Margin = New System.Windows.Forms.Padding(0)
            emp.LoginStatus.Update()
            NewContactListing.Contact = emp
            ContactsPanel.Controls.Add(NewContactListing)
        End If
    End Sub

    Private Sub UpdateContactStatus()
        Dim MyID As Integer = My.FSL.FindWindow().AuthenticatedUser.PayrollId
        Dim query As String = "SELECT SUBSTRING_INDEX( GROUP_CONCAT(CAST(notificationId AS CHAR) ORDER BY notificationId DESC), ',', 1 ) AS notificationId, userFromId FROM whldata.user_notifications WHERE PayrollId=" + MyID.ToString + " GROUP BY UserFromId ORDER BY notificationId DESC;"
        Dim Response As ArrayList = WHLClasses.MySQL.SelectData(query)

        Dim SortedResponse As New ArrayList
        Dim converterint As Integer = 0
        Dim converterstring As String
        Dim Int2StrList As New List(Of String)
        Dim Fmt As String = "00000000000" 'Magic formatting number thing! ... Gonna need to update this on message 100,000,000,000!! Don't think that's happening anytime soon
        For Each notifData As ArrayList In Response
            converterint = Convert.ToInt32(notifData(0)) 'So lets make our ID an integer
            converterstring = converterint.ToString(Fmt) 'Then format it because PADDING DOESN'T WANNA WORK.
            Int2StrList.Add(converterstring) 'Then add it.
        Next
        Int2StrList.Sort()
        Int2StrList.Reverse()
        For Each intstring As String In Int2StrList 'So for each number in the list
            For Each line As ArrayList In Response 'Check our arrays
                If intstring.EndsWith(line(0)) Then 'If the string ends with the number we have
                    Dim str As String = intstring.Replace(line(0).ToString, "").Replace("0", "") 'We need to check that there's no extra stuff
                    If str = "" Then 'So in removing the number, if this is the right one, all we should have is padding
                        SortedResponse.Add(line) 'If so, add the line, exit the loop. Next number. GO! GO! GO!
                        Exit For
                    End If
                End If
            Next
        Next

        Dim PayrollIds As New List(Of Integer)

        For Each msg As ArrayList In SortedResponse
            PayrollIds.Add(msg(1))
        Next


        ContactsPanel.SuspendLayout()
        ContactsPanel.Controls.Clear()

        'First, add the ones we know.
        For Each cool As Integer In PayrollIds
            Dim emp As Employee = EmpList.FindEmployeeByID(cool)
            If emp.Visible Then AddContact(emp)
        Next

        'Then add trhe rest
        For Each employee As WHLClasses.Employee In EmpList.Employees
            If employee.Visible And Not (PayrollIds.Contains(employee.PayrollId)) Then
                AddContact(employee)
            End If
        Next
        ContactsPanel.ResumeLayout()
    End Sub

    Public Sub OpenConversation(ConvWith As WHLClasses.Employee)
        Messenger_Conversation1.InitiateConversation(ConvWith)
    End Sub

    Private Sub IconSwapper_Tick(sender As Object, e As EventArgs) Handles IconSwapper.Tick
        If IconFlashMode = 0 Then
            IconFlashMode = 1
            Me.Icon = My.Resources.chacticonALT
        Else
            Me.Icon = My.Resources.chacticon
            IconFlashMode = 0

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Notify_End()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Notify_Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        My.FSL.FindWindow().LogoutUser(sender)

    End Sub

    Private Sub TenSecUpdates_Tick(sender As Object, e As EventArgs) Handles TenSecUpdates.Tick
        Try
            UpdateContactStatus()
        Catch ex As TimeoutException
            Try
                UpdateContactStatus()
            Catch ex1 As TimeoutException
                'Updating Contact Status Failed
            End Try
        End Try
    End Sub


    Private Sub MessengerMain_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Notify_End()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        My.FSL.FindWindow().LogoutUser(sender)
        End
    End Sub

    Private Sub Set_Inbox(sender As Object, e As EventArgs) Handles Label1.Click, InboxButton.Click, PictureBox1.Click
        InboxPanel.Visible = True
        InboxOutbox.SetInbox()
    End Sub

    Private Sub Set_Outbox(sender As Object, e As EventArgs) Handles Label2.Click, OutboxButton.Click, PictureBox2.Click
        InboxPanel.Visible = True
        InboxOutbox.SetOutbox()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles MainSettingsButton.Click
        MainSettingsContextMenu.Show(MainSettingsButton, New Point(24, 24))

    End Sub

    Private Sub MessengerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WHLClasses.MiscFunctions.UpgradeWebBrowser()
    End Sub

    Private Sub ChangeLoginPINItem_Click(sender As Object, e As EventArgs) Handles ChangeLoginPINItem.Click
        If MsgBox("Are you sure you want to change your login PIN?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim newpinwindow As New ChangePIN(EmpList.FindEmployeeByID(My.FSL.FindWindow().AuthenticatedUser.PayrollId))
            Dim PinResult As MsgBoxResult = newpinwindow.ShowDialog()

            If PinResult = MsgBoxResult.No Then
                MsgBox("Pin change failed. See your administrator")
            ElseIf PinResult = MsgBoxResult.Yes Then
                MsgBox("Pin change completed successfully.")
                EmpList = New EmployeeCollection(True)
                EmpList.SaveThisCollection()
            End If
        End If
    End Sub
End Class