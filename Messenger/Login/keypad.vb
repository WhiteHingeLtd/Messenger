Imports System.Windows.Forms

Public Class keypad

    Public target As String

    Dim strValue As String
    Public ReadOnly Property PinAt() As String
        Get
            Return strValue
        End Get
    End Property

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles key_Back.Click, Label9.Click
        If PinBox.TextLength > 0 Then
            PinBox.Text = PinBox.Text.Remove(PinBox.TextLength - 1)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles key_Cancel.Click, Label5.Click
        PinBox.Text = PinBox.Text + "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles key_Confirm.Click, Label13.Click
        strValue = PinBox.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub key_1_Click(sender As Object, e As EventArgs) Handles key_1.Click, Label2.Click
        PinBox.Text = PinBox.Text + "1"
    End Sub

    Private Sub key_2_Click(sender As Object, e As EventArgs) Handles key_2.Click, Label3.Click
        PinBox.Text = PinBox.Text + "2"
    End Sub

    Private Sub key_3_Click(sender As Object, e As EventArgs) Handles key_3.Click, Label4.Click
        PinBox.Text = PinBox.Text + "3"
    End Sub

    Private Sub key_4_Click(sender As Object, e As EventArgs) Handles key_4.Click, Label6.Click
        PinBox.Text = PinBox.Text + "4"
    End Sub

    Private Sub key_5_Click(sender As Object, e As EventArgs) Handles key_5.Click, Label7.Click
        PinBox.Text = PinBox.Text + "5"
    End Sub

    Private Sub key_6_Click(sender As Object, e As EventArgs) Handles key_6.Click, Label8.Click
        PinBox.Text = PinBox.Text + "6"
    End Sub

    Private Sub key_7_Click(sender As Object, e As EventArgs) Handles key_7.Click, Label10.Click
        PinBox.Text = PinBox.Text + "7"
    End Sub

    Private Sub key_8_Click(sender As Object, e As EventArgs) Handles key_8.Click, Label11.Click
        PinBox.Text = PinBox.Text + "8"
    End Sub

    Private Sub key_9_Click(sender As Object, e As EventArgs) Handles key_9.Click, Label12.Click
        PinBox.Text = PinBox.Text + "9"
    End Sub

    Private Sub keypad_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        PinBox.Focus()
    End Sub

    Private Sub PinBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PinBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button11_Click(sender, e)
        End If
    End Sub

    Private Sub keypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown
        PinBox.Focus()
    End Sub
End Class
