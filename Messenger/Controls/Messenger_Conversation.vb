Imports System.Drawing
Imports System.Windows.Forms

Public Class Messenger_Conversation

    Dim LastMessageID As Integer = 0
    Dim TargetUserId As Integer


    Public Sub InitiateConversation(User As WHLClasses.Employee)
        MessengerMain.InboxPanel.Visible = False
        OneSecUpdates.Enabled = False
        ConvFlow.Controls.Clear()
        ConversationHeader.Titletext = User.FullName
        TargetUserId = User.PayrollId
        Dim RecentMessages As New ArrayList
        RecentMessages = MySql.SelectData("SELECT * FROM whldata.user_notifications WHERE (payrollId=" + TargetUserId.ToString + " AND UserFromId=" + My.FSL.FindWindow().AuthdEmpl.PayrollId.ToString + ") OR (UserFromId=" + TargetUserId.ToString + " AND  payrollId=" + My.FSL.FindWindow().AuthdEmpl.PayrollId.ToString + ") ORDER BY notificationId DESC LIMIT 50;")
        RecentMessages.Reverse()

        For Each Message As ArrayList In RecentMessages
            If Message(1) = TargetUserId Then
                'We sent the message
                Dim NewMessageBubble As New ScalableToMsg
                If Message(7).ToString.Length > 0 Then
                    Dim AnotherBubble As New ScalableToMsg
                    AnotherBubble.SubText = Message(0).ToString + " - " + Message(5)
                    AnotherBubble.ImagePath = Message(7).ToString
                    ConvFlow.Controls.Add(AnotherBubble)
                End If
                NewMessageBubble.SubText = Message(0).ToString + " - " + Message(5)
                NewMessageBubble.MessageText = Message(3)

                '-----   -----  -----   -----   -----
                '07/05/16 - Gotta get rid of the "TheMessageBeginsHere" at the start
                NewMessageBubble.MessageText = NewMessageBubble.MessageText.Replace("--TMBH--", "")
                '-----   -----  -----   -----   -----

                ConvFlow.Controls.Add(NewMessageBubble)
                'ConvFlow.ScrollControlIntoView(NewMessageBubble)   31/12/2015 - Performance Improvement, don't scroll until messages are finished loading, then just scroll to the bottom. 

            Else
                'They sent the message.
                Dim NewMessageBubble As New ScalableFromMessage
                If Message(7).ToString.Length > 0 Then
                    Dim AnotherBubble As New ScalableFromMessage
                    AnotherBubble.SubText = Message(0).ToString + " - " + Message(5)
                    AnotherBubble.ImagePath = Message(7).ToString
                    ConvFlow.Controls.Add(AnotherBubble)
                End If
                NewMessageBubble.SubText = Message(0).ToString + " - " + Message(5)
                NewMessageBubble.MessageText = Message(3)

                '-----   -----  -----   -----   -----
                '07/05/16 - Gotta get rid of the "TheMessageBeginsHere" at the start
                NewMessageBubble.MessageText = NewMessageBubble.MessageText.Replace("--TMBH--", "")
                '-----   -----  -----   -----   -----

                ConvFlow.Controls.Add(NewMessageBubble)
                'ConvFlow.ScrollControlIntoView(NewMessageBubble)  31/12/2015 - Performance Improvement, don't scroll until messages are finished loading, then just scroll to the bottom. 
            End If
            LastMessageID = Message(0)
        Next
        Application.DoEvents()
        ConvFlow.AutoScrollPosition = New Point(0, 99999)
        ConvFlow_SizeChanged(Nothing, Nothing)
        OneSecUpdates.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SendButton.Click

        '-----   -----  -----   -----   -----
        '07/05/16 - Added TheMessageBeginsHere. This ensures formatting is removed.
        MessageTextBox.Text = "--TMBH--" + MessageTextBox.Text
        '-----   -----  -----   -----   -----

        Dim responseInsert As Object = MySql.insertupdate("INSERT INTO whldata.user_notifications (payrollId, notificationTitle, notificationBody, notificationStyle, notExpiryDateTime, notIsRead, notImgLink, UserFromId) VALUES (" + TargetUserId.ToString + ",'" + "Messenger: " + My.FSL.FindWindow().AuthenticatedUser.FullName + "','" + MessageTextBox.Rtf.Replace("\", "\\").Replace("'", "\'") + "', 'Message','" + Now.ToShortDateString + " " + Now.ToLongTimeString + "','True', '" + "" + "', " + My.FSL.FindWindow().AuthenticatedUser.PayrollId.ToString + ");")
        If Not responseInsert = 1 Then
            MsgBox(responseInsert)
        End If

        MessageTextBox.Focus()
        MessageTextBox.Clear()

        UpdateNewMessages()

    End Sub

    Private Sub UpdateNewMessages()
        Dim RecentMessages As Object
        RecentMessages = MySql.SelectData("SELECT * FROM whldata.user_notifications WHERE (payrollId=" + TargetUserId.ToString + " AND UserFromId=" + My.FSL.FindWindow().AuthenticatedUser.PayrollId.ToString + " AND notificationId>" + LastMessageID.ToString + ") OR (UserFromId=" + TargetUserId.ToString + " AND  payrollId=" + My.FSL.FindWindow().AuthenticatedUser.PayrollId.ToString + " AND notificationId>" + LastMessageID.ToString + ") ORDER BY notificationId DESC LIMIT 50;")
        If RecentMessages.GetType = "".GetType Then
            MsgBox(RecentMessages)
        Else


            RecentMessages.Reverse()

            For Each Message As ArrayList In RecentMessages
                If Message(1) = TargetUserId Then
                    'We sent the message
                    Dim NewMessageBubble As New ScalableToMsg
                    If Message(7).ToString.Length > 0 Then
                        Dim AnotherBubble As New ScalableToMsg
                        AnotherBubble.SubText = Message(0).ToString + " - " + Message(5)
                        AnotherBubble.ImagePath = Message(7).ToString
                        ConvFlow.Controls.Add(AnotherBubble)
                    End If
                    NewMessageBubble.SubText = Message(0).ToString + " - " + Message(5)
                    NewMessageBubble.MessageText = Message(3)

                    '-----   -----  -----   -----   -----
                    '07/05/16 - Gotta get rid of the "TheMessageBeginsHere" at the start
                    NewMessageBubble.MessageText = NewMessageBubble.MessageText.Replace("--TMBH--", "")
                    '-----   -----  -----   -----   -----

                    NewMessageBubble.Width = ConvFlow.Width - 20
                    ConvFlow.Controls.Add(NewMessageBubble)
                    ConvFlow.ScrollControlIntoView(NewMessageBubble)

                Else
                    'They sent the message.
                    Dim NewMessageBubble As New ScalableFromMessage
                    If Message(7).ToString.Length > 0 Then
                        Dim AnotherBubble As New ScalableFromMessage
                        AnotherBubble.SubText = Message(0).ToString + " - " + Message(5)
                        AnotherBubble.ImagePath = Message(7).ToString
                        ConvFlow.Controls.Add(AnotherBubble)
                    End If
                    NewMessageBubble.SubText = Message(0).ToString + " - " + Message(5)
                    NewMessageBubble.MessageText = Message(3)

                    '-----   -----  -----   -----   -----
                    '07/05/16 - Gotta get rid of the "TheMessageBeginsHere" at the start
                    NewMessageBubble.MessageText = NewMessageBubble.MessageText.Replace("--TMBH--", "")
                    '-----   -----  -----   -----   -----

                    NewMessageBubble.Width = ConvFlow.Width - 20
                    ConvFlow.Controls.Add(NewMessageBubble)
                    ConvFlow.ScrollControlIntoView(NewMessageBubble)
                End If
                LastMessageID = Message(0)
            Next
        End If
    End Sub

    Private Sub OneSecUpdates_Tick(sender As Object, e As EventArgs) Handles OneSecUpdates.Tick
        UpdateNewMessages()
    End Sub

    Private Sub MessageTextBox_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MessageTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            MessageTextBox_TextChanged_1(Nothing, Nothing)
            SendButton.PerformClick()
        End If
    End Sub

    Private Sub MessageTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles MessageTextBox.Leave
        MessageTextBox.Text = MessageTextBox.Text.Replace("""X:", "file://X:")

    End Sub

    Private Sub MessageTextBox_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles MessageTextBox.ContentsResized
        If e.NewRectangle.Height < 120 Then
            SendPanel.Height = e.NewRectangle.Height + 5
        Else
            SendPanel.Height = 120 + 5

        End If
    End Sub

    Private Sub ConvFlow_SizeChanged(sender As Object, e As EventArgs) Handles ConvFlow.SizeChanged
        Me.SuspendLayout()
        For Each bubble As Control In ConvFlow.Controls
            bubble.Width = ConvFlow.Width - 22
            bubble.Refresh()
        Next
        Me.ResumeLayout()
    End Sub
End Class
