Imports System.Drawing
Imports System.Windows.Forms

Public Class Message_From
    Public Sub UpdateMyHeight()
        If PictureBoxA.Visible = True Then
            Try
                Realtext.Rtf = Messagetext.Text
            Catch ex As Exception
                Realtext.Text = Messagetext.Text
            End Try
            Me.Height = Realtext.Height + 183
        Else
            Try
                Realtext.Rtf = Messagetext.Text
            Catch ex As Exception
                Realtext.Text = Messagetext.Text
            End Try
            Me.Height = Realtext.Height + 30
            Realtext.Refresh()
            Realtext.Invalidate()
        End If
    End Sub

    Private Sub CopyMessageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        My.Computer.Clipboard.SetText(Realtext.Text)
    End Sub

    Private Sub PictureBoxA_Click(sender As Object, e As EventArgs) Handles PictureBoxA.Click
        Dim NewBigPic As New BigPictureDialog
        NewBigPic.PictureBox.ImageLocation = PictureBoxA.ImageLocation
        NewBigPic.ShowDialog()
    End Sub

    '// Make the RichTextBox fit its contents.
    Private Sub RchContents_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles Realtext.ContentsResized
        Dim rch As RichTextBox = sender
        rch.ClientSize = New Size(303, e.NewRectangle.Height)
    End Sub

    Private Sub MessageSubtext_Click(sender As Object, e As EventArgs) Handles MessageSubtext.Click
        UpdateMyHeight()
    End Sub
    Dim RepaintedAlready As Boolean = False
    Private Sub PaintHandler(Sender As Object, evsent As EventArgs) Handles Me.Paint
        If RepaintedAlready Then
        Else
            UpdateMyHeight()
            RepaintedAlready = True
        End If
    End Sub


    Private Sub Realtext_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles Realtext.LinkClicked
        Try
            Process.Start(e.LinkText)
        Catch ex As Exception
            MsgBox("Error opening link - " + ex.Message)
        End Try

    End Sub

    Private Sub CopySelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySelectionToolStripMenuItem.Click
        If Realtext.SelectedText.Length > 0 Then
            My.Computer.Clipboard.SetText(Realtext.SelectedText)
        Else
            MsgBox("You have not selected any text!")
        End If
    End Sub

    Private Sub CopyMessageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyMessageToolStripMenuItem1.Click
        My.Computer.Clipboard.SetText(Realtext.Text)
    End Sub
End Class
