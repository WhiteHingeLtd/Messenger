Imports System.Drawing
Imports System.Windows.Forms

Public Class Message_To
    Public Sub UpdateMyHeight()
        If PictureBoxA.Visible = True Then
            Try
                RealText.Rtf = MessageText.Text
            Catch ex As Exception
                RealText.Text = MessageText.Text
            End Try
            Me.Height = RealText.Height + 183
        Else
            Try
                RealText.Rtf = MessageText.Text
            Catch ex As Exception
                RealText.Text = MessageText.Text
            End Try
            Me.Height = RealText.Height + 30

        End If
    End Sub

    Private Sub CopyMessageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        My.Computer.Clipboard.SetText(RealText.Text)
    End Sub

    Private Sub PictureBoxA_Click(sender As Object, e As EventArgs) Handles PictureBoxA.Click
        Dim NewBigPic As New BigPictureDialog
        NewBigPic.PictureBox.ImageLocation = PictureBoxA.ImageLocation
        NewBigPic.ShowDialog()
    End Sub

    '// Make the RichTextBox fit its contents.
    Private Sub rchContents_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles RealText.ContentsResized
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


    Private Sub Realtext_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles RealText.LinkClicked
        Try
            Process.Start(e.LinkText)
        Catch ex As Exception
            MsgBox("Error opening link - " + ex.Message)
        End Try

    End Sub


    Private Sub CopySelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopySelectionToolStripMenuItem.Click
        If RealText.SelectedText.Length > 0 Then
            My.Computer.Clipboard.SetText(RealText.SelectedText)
        Else
            MsgBox("You have not selected any text!")
        End If
    End Sub

    Private Sub CopyMessageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyMessageToolStripMenuItem1.Click
        My.Computer.Clipboard.SetText(RealText.Text)
    End Sub

    Private Sub SubtextTooltip_Popup(sender As Object, e As PopupEventArgs) Handles SubtextTooltip.Popup


    End Sub
End Class
