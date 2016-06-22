Imports WHLClasses

Public Class InboxOutbox



    Public Sub SetInbox()
        ZoneTitle.Titletext = "Inbox"
        ExecuteSearch()
        Updater.Enabled = True
    End Sub
    Public Sub SetOutbox()
        ZoneTitle.Titletext = "Outbox"
        ExecuteSearch()
        Updater.Enabled = True
    End Sub



    Private Sub ExecuteSearch()
        Dim ListOfMsgs As ArrayList
        If ZoneTitle.Titletext = "Inbox" Then
            'Get messages with PayrollID as my ID
            ListOfMsgs = WHLClasses.MySql.SelectData("SELECT * FROM whldata.user_notifications WHERE payrollId=" + My.FSL.FindWindow().AuthenticatedUser.PayrollId.ToString + " ORDER BY notificationId DESC LIMIT 100")
        Else
            'Gte messages with UserFromId as my id.
            ListOfMsgs = WHLClasses.MySql.SelectData("SELECT * FROM whldata.user_notifications WHERE UserFromId=" + My.FSL.FindWindow().AuthenticatedUser.PayrollId.ToString + " ORDER BY notificationId DESC LIMIT 100")
        End If
        BuildList(ListOfMsgs)

        GC.Collect(GC.MaxGeneration)
    End Sub

    Private Sub BuildList(AList As ArrayList)
        FlowPanel.SuspendLayout()
        For Each oldOne As InboxOutboxItem In FlowPanel.Controls
            oldOne.Dispose()
        Next
        FlowPanel.Controls.Clear()

        For Each Message As ArrayList In AList
            Dim NextMessageLine As New InboxOutboxItem
            Dim target As Integer
            If ZoneTitle.Titletext = "Inbox" Then
                target = Message(8)
            Else
                target = Message(1)
            End If
            If Message(7).ToString.Length > 2 Then
                NextMessageLine.HasImage = True
            Else
                NextMessageLine.HasImage = False
            End If
            NextMessageLine.TargetConvo = target
            NextMessageLine.MessageText = Message(3)
            NextMessageLine.MessageSender = MessengerMain.EmpList.FindEmployeeByID(target).FullName
            NextMessageLine.Timedate = Message(5)
            NextMessageLine.Width = FlowPanel.Width - 18
            NextMessageLine.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            FlowPanel.Controls.Add(NextMessageLine)
        Next
        FlowPanel.ResumeLayout()
    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        If Me.Visible Then
            ExecuteSearch()
        End If

    End Sub

    Private Sub FlowPanel_SizeChanged(sender As Object, e As EventArgs) Handles FlowPanel.SizeChanged
        For Each MessageCon As InboxOutboxItem In FlowPanel.Controls
            MessageCon.Width = FlowPanel.Width - 18
        Next
    End Sub
End Class
