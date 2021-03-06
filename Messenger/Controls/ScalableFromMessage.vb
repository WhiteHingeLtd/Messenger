﻿Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class ScalableFromMessage

    Dim pMessageText As String
    Dim pSubText As String
    Dim pImg As String = Nothing
    Dim IgnoreResize As Boolean = False
    Public Property ImagePath As String
        Set(value As String)
            pImg = value
            PictureBoxA.ImageLocation = value
        End Set
        Get
            Return pImg
        End Get
    End Property

    Public Property MessageText() As String
        Set(value As String)
            Dim betterText As String = RTFMurder(value)
            pMessageText = betterText

            Dim RM As New Regex("#frame\|(.+)#")
            Dim match = RM.Match(value)
            If match.Success Then
                ActualMessage.Width = 400
                IgnoreResize = True
                Me.Height = 322
                EmbedBrowser.Visible = True
                EmbedBrowser.Navigate(match.Groups(1).Value)
            Else
                IgnoreResize = False
                ActualMessage.Text = betterText
            End If



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
            SubtextTooltip.SetToolTip(Me, pSubText)
            SubtextTooltip.SetToolTip(ActualMessage, pSubText)
            SubtextTooltip.SetToolTip(PictureBoxA, pSubText)
        End Set
        Get
            Return pSubText
        End Get
    End Property

    Private Sub ScalableFromMessage_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If IsNothing(pImg) Then
            Dim targetrect As New Rectangle((ActualMessage.Location.X - 5), ActualMessage.Location.Y - 11, ActualMessage.Width + 11, ActualMessage.Height + 18)
            WHLClasses.FillRoundedRectangle(e.Graphics, targetrect, 16, New SolidBrush(Color.FromArgb(241, 240, 240)))
            WHLClasses.DrawRoundedRectangle(e.Graphics, targetrect, 16, New Pen(Color.FromArgb(210, 210, 210)))
        Else
            ActualMessage.Size = PictureBoxA.Size
            PictureBoxA.Location = ActualMessage.Location
            Dim targetrect As New Rectangle((ActualMessage.Location.X - 5), ActualMessage.Location.Y - 11, ActualMessage.Width + 11, ActualMessage.Height + 18)
            WHLClasses.FillRoundedRectangle(e.Graphics, targetrect, 16, New SolidBrush(Color.FromArgb(241, 240, 240)))
            WHLClasses.DrawRoundedRectangle(e.Graphics, targetrect, 16, New Pen(Color.FromArgb(210, 210, 210)))
            PictureBoxA.Visible = True
        End If
    End Sub

    Private Sub ActualMessage_ContentsResized(sender As Object, e As System.Windows.Forms.ContentsResizedEventArgs) Handles ActualMessage.ContentsResized

        If IsNothing(pImg) And Not IgnoreResize Then
            Me.Height = e.NewRectangle.Height + 22
            If e.NewRectangle.Width > 400 Then
                ActualMessage.Width = 400
            Else
                ActualMessage.Width = e.NewRectangle.Width
            End If
        End If

    End Sub

    Private Sub PictureBoxA_Click(sender As Object, e As EventArgs) Handles PictureBoxA.Click
        Dim NewBigPic As New BigPictureDialog
        NewBigPic.PictureBox.ImageLocation = PictureBoxA.ImageLocation
        NewBigPic.ShowDialog()
    End Sub

    Private Sub CopySelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySelectionToolStripMenuItem.Click
        If ActualMessage.SelectedText.Length > 0 Then
            My.Computer.Clipboard.SetText(ActualMessage.SelectedText)
        Else
            MsgBox("You have not selected any text!")
        End If
    End Sub

    Private Sub CopyMessageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyMessageToolStripMenuItem1.Click
        My.Computer.Clipboard.SetText(ActualMessage.Text)
    End Sub

    Private Sub ActualMessage_LinkClicked(sender As Object, e As System.Windows.Forms.LinkClickedEventArgs) Handles ActualMessage.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub DateTimeBox_MouseHover(sender As Object, e As EventArgs) Handles DateTimeBox.MouseHover
        DateTimeBox.ForeColor = Color.Black
    End Sub

    Private Sub DateTimeBox_MouseLeave(sender As Object, e As EventArgs) Handles DateTimeBox.MouseLeave
        DateTimeBox.ForeColor = Color.DimGray
    End Sub
End Class
