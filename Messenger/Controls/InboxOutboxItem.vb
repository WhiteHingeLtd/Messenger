Imports System.Windows.Forms

Public Class InboxOutboxItem

    Dim TargetConv As Integer


    Private Function rtftotext(ByVal rtfstring As String) As String
        Dim Cool As String
        Cool = rtfstring
        Cool = Cool.Replace("{\rtf1\ansi\ansicpg1252\deff0\deflang2057{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}", "").Replace("\viewkind4\uc1\pard\f0\fs23", "").Replace("\par } ", "").Replace("\par", "")
        Cool = Cool.Replace(vbCrLf, "")

        '-----   -----  -----   -----   -----
        'New formatting apparently exists. Let's kill that, it doesn't need to be in the text.
        Cool = Cool.Replace("{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}\viewkind4\uc1d\lang2057\f0\fs23", "")
        'Turns out there's others. Now here's the problem. How do we tell if a word is from the formatting? Because this is just gonna be a huge list of replacing...
        Cool = Cool.Replace("{\rtf1\ansi\deff0{\fonttbl{\f0\fnil Consolas;}}{\colortbl", "").Replace(";\red0\green0\blue255;\red255\green255\blue255;}\viewkind4\uc1d\cf1\highlight2\lang2057\f0\fs19 ", "").Replace("{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Calibri;}}\viewkind4\uc1d\lang9\f0\fs22 ", "")
        'This removes what I can see on my end.
        'Something to note is the table loading red / green / blue values is pretty variable theoretically.
        'This literally means if we're going to prevent them, that's 255*255*255.
        'Except no, I'm wrong they appear TWICE in that line. So that's 255*255*255 * 255*255*255 ... Basically, bottom line is that's not happening.
        'We'd literally have 6 for loops to go through for every message in the inbox, each loop being 255 long, there's absolutely no way.

        'Instead, let's prevent more from existing beyond today.

        Dim CoolWithoutFormatting As String
        Dim removeFromHere = "--TMBH--"
        Dim killTheFormat As Integer 'Hack the planet

        'Lets get the first instance of TheMessageBeginsHere, then delete everything before it.
        If InStr(Cool, removeFromHere) Then
            killTheFormat = InStr(Cool, removeFromHere)
            CoolWithoutFormatting = Cool.Substring(killTheFormat + removeFromHere.Length - 1)
            'And now we have exactly what we wanted - the message without the formatting. Now we need to put that back into our returning value.
            Cool = CoolWithoutFormatting

        End If
        'Also, that little } at the end needs to quit existing.
        If Cool.EndsWith("}") Then
            Cool = Cool.Substring(0, Cool.Length - 1)
        End If
        '-----   -----  -----   -----   -----


        If Cool.StartsWith(" ") Then
            Cool = Cool.Substring(1)
        End If



        Return Cool
    End Function



    Public Property TargetConvo As Integer
        Get
            Return TargetConv
        End Get
        Set(value As Integer)
            TargetConv = value
        End Set
    End Property
    Public Property Timedate As String
        Get
            Return DateTimeLabel.Text
        End Get
        Set(value As String)
            DateTimeLabel.Text = value
        End Set
    End Property
    Public Property MessageText As String
        Get
            Return MessageBody.Text
        End Get
        Set(value As String)

            Try
                MessageBody.Text = rtftotext(value)
            Catch ex As Exception
                MessageBody.Text = value
            End Try

        End Set
    End Property
    Public Property MessageSender As String
        Get
            Return SenderLabel.Text
        End Get
        Set(value As String)
            SenderLabel.Text = value
        End Set
    End Property
    Public Property HasImage As Boolean
        Get
            Return AttachmentIcon.Visible
        End Get
        Set(value As Boolean)
            AttachmentIcon.Visible = value
        End Set

    End Property


    Private Sub MessageText_Click(sender As Object, e As EventArgs) Handles SenderLabel.Click, DateTimeLabel.Click, MessageBody.Click, MyBase.Click
        MessengerMain.OpenConversation(MessengerMain.EmpList.FindEmployeeByID(TargetConv))
    End Sub

    Private Sub InboxOutboxItem_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If AttachmentIcon.Visible = False Then
            AttachmentIcon.Dispose()
        End If
    End Sub
End Class
