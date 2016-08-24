Imports System.Windows.Forms

Public Class ChangePIN
    Private TargetEmp As New WHLClasses.Employee

    Public Sub New(TEmployee As WHLClasses.Employee)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        TargetEmp = TEmployee
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Not PinTxt.Text.Length = 4 Then
            MsgBox("Please use a 4 digit PIN.")
        Else
            If TargetEmp.SetNewPin(PinTxt.Text) Then
                Me.DialogResult = System.Windows.Forms.DialogResult.Yes
            Else
                Me.DialogResult = System.Windows.Forms.DialogResult.No
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PinTxt.Text = PinTxt.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PinTxt.Text = PinTxt.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PinTxt.Text = PinTxt.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PinTxt.Text = PinTxt.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PinTxt.Text = PinTxt.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PinTxt.Text = PinTxt.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PinTxt.Text = PinTxt.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PinTxt.Text = PinTxt.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        PinTxt.Text = PinTxt.Text + "9"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        PinTxt.Text = PinTxt.Text + "0"
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        PinTxt.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        PinTxt.Text = PinTxt.Text.Substring(0, PinTxt.Text.Length - 1)
    End Sub
End Class
