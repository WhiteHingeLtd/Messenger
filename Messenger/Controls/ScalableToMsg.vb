Imports System.Drawing

Public Class ScalableToMsg

    Dim pMessageText As String
    Dim pSubText As String
    Dim pImg As String = Nothing

    Public Property MessageText() As String
        Set(value As String)
            Dim betterText As String = RTFMurder(value)
            pMessageText = betterText
            ActualMessage.Text = betterText
            GC.Collect()
        End Set
        Get
            Return pMessageText
        End Get
    End Property

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

    Public Property SubText() As String
        Set(value As String)
            pSubText = value
            SubTextTooltip.SetToolTip(Me, pSubText)
            SubTextTooltip.SetToolTip(ActualMessage, pSubText)
        End Set
        Get
            Return pSubText
        End Get
    End Property



    'Private Sub ActualMessage_ContentsResized(sender As Object, e As System.Windows.Forms.ContentsResizedEventArgs) Handles ActualMessage.ContentsResized
    '    If IsNothing(pImg) Then
    '        Me.Height = e.NewRectangle.Height + 22
    '        If e.NewRectangle.Width > 400 Then
    '            ActualMessage.Width = 400
    '        Else
    '            ActualMessage.Width = e.NewRectangle.Width
    '        End If

    '    Else
    '        ActualMessage.Width = 400
    '    End If


    'End Sub

    Private Sub CopyMessageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyMessageToolStripMenuItem1.Click
        My.Computer.Clipboard.SetText(ActualMessage.Text)
    End Sub

    Private Sub DateTimeBox_MouseHover(sender As Object, e As EventArgs) Handles DateTimeBox.MouseHover
        DateTimeBox.ForeColor = Color.Black
    End Sub

    Private Sub DateTimeBox_MouseLeave(sender As Object, e As EventArgs) Handles DateTimeBox.MouseLeave
        DateTimeBox.ForeColor = Color.DimGray
    End Sub
End Class
