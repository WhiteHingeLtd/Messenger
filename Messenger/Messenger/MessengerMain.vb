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
        Dim Response As ArrayList = SelectData(query)

        Dim PayrollIds As New List(Of Integer)

        For Each msg As ArrayList In Response
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
        UpdateContactStatus()

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

    End Sub
End Class