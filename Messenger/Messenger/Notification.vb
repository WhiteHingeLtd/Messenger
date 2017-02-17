Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Notification
    Public EmpId As Integer = 0
    Public Startpos As Integer = 12
    Public NotifID As Integer = 0
    Dim EntryShiftAmt As Single = 58
    Dim imgloc As String

    Private Sub Notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Drawing.Point(My.Computer.Screen.Bounds.Width, Startpos)
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        'Update that it has been seen.
        Dim query As String = "UPDATE whldata.whldata.user_notifications SET notIsRead='False' WHERE notificationId='" + NotifID.ToString + "';"
        Dim response As Object = WHLClasses.MSSQLPublic.insertUpdate(query)
        Try
            Convert.ToInt16(response)

        Catch ex As Exception
            MsgBox(query + vbNewLine + vbNewLine + "Query returned:" + vbNewLine + vbNewLine + response.ToString)
        End Try
        FullscreenLogin.FireNotifications.Enabled = True
        If MessengerMain.Visible Then
            MessengerMain.Notify_Start()
        End If
    End Sub

    Private Sub Notification_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If MessengerMain.Visible Then
            MessengerMain.Notify_Start()
        End If
        EntryCoord.Enabled = True
        Body2.Text = Body2.Text.Replace(vbNewLine + vbNewLine, vbNewLine)
    End Sub

    Private Sub EntryCoord_Tick(sender As Object, e As EventArgs) Handles EntryCoord.Tick
        Me.Location = New Drawing.Point(Me.Location.X - EntryShiftAmt, Startpos)
        EntryShiftAmt = EntryShiftAmt * 0.9
        If EntryShiftAmt < 0.2 Then
            EntryCoord.Enabled = False
        End If
    End Sub

    Private Sub IconBox_Click(sender As Object, e As EventArgs) Handles IconBox.Click
        BigPictureDialog.PictureBox.ImageLocation = IconBox.ImageLocation
        BigPictureDialog.ShowDialog()
    End Sub

    Private Sub Body2_Click(sender As Object, e As EventArgs) Handles Body2.Click, ProperBody.Click
        'CreateNotification.TargetTitle.Text = "Re: " + NotificationTitle.Text
        'CreateNotification.

        If My.FindWindow().Standalone Then
            Me.TopMost = False
            If MessengerMain.Visible = True Then
                MessengerMain.Activate()
            Else
                MessengerMain.Show()
            End If


            MessengerMain.OpenConversation(MessengerMain.EmpList.FindEmployeeByID(EmpId))
        End If

        CloseButton.PerformClick()
    End Sub

    Protected Overrides ReadOnly Property ShowWithoutActivation() As Boolean
        Get
            Return True
        End Get
    End Property

    Private Sub ProperBody_TextChanged(sender As Object, e As EventArgs) Handles ProperBody.TextChanged

    End Sub

    Private Sub Notification_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim betterText As String = RTFMurder(Body2.Text)
        ProperBody.Text = betterText
    End Sub

    Private Function RTFMurder(value As String) As String
        Dim Cool As String
        Cool = value
        'Shitty formatting time
        Cool = Cool.Replace("{\rtf1\ansi\ansicpg1252\deff0\deflang2057{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}", "").Replace("\viewkind4\uc1\pard\f0\fs23", "").Replace("\par } ", "").Replace("\par", "")
        Cool = Cool.Replace(vbCrLf, "")
        Cool = Cool.Replace("{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}\viewkind4\uc1d\lang2057\f0\fs23", "")
        Cool = Cool.Replace("{\rtf1\ansi\deff0{\fonttbl{\f0\fnil Consolas;}}{\colortbl", "").Replace(";\red0\green0\blue255;\red255\green255\blue255;}\viewkind4\uc1d\cf1\highlight2\lang2057\f0\fs19 ", "").Replace("{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Calibri;}}\viewkind4\uc1d\lang9\f0\fs22 ", "")
        Dim CoolWithoutFormatting As String
        Dim removeFromHere = "--TMBH--"
        Dim killTheFormat As Integer
        If InStr(Cool, removeFromHere) Then
            killTheFormat = InStr(Cool, removeFromHere)
            CoolWithoutFormatting = Cool.Substring(killTheFormat + removeFromHere.Length - 1)
            Cool = CoolWithoutFormatting
        End If
        If Cool.EndsWith("}") Then
            Cool = Cool.Substring(0, Cool.Length - 1)
        End If
        Return Cool.Trim
    End Function
End Class