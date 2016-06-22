Imports System.Windows.Forms

Public Class CreateNotification
    Public targetempno As Integer = 0

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'If Not targetempno = 0 Then
        For Each selectedtarget As String In TargetEmp.SelectedItems
            Dim empNo As Integer = Convert.ToInt32(selectedtarget.ToString.Split(":")(1))
            Dim responseInsert As Object = WHLClasses.MySql.insertupdate("INSERT INTO whldata.user_notifications (payrollId, notificationTitle, notificationBody, notificationStyle, notExpiryDateTime, notIsRead, notImgLink, UserFromId) VALUES (" +
                                                              empNo.ToString + ",'" + TargetTitle.Text.Replace("\", "\\").Replace("'", "\'") + "','" + TargetBody.Rtf.Replace("\", "\\").Replace("'", "\'") + "','Message','" +
                                                              Now.ToShortDateString + " " + Now.ToLongTimeString + "','True', '" + TargetFileNew.Text.Replace("\", "\\") + "', " + My.FSL.FindWindow().AuthenticatedUser.PayrollId.ToString + ");")
            If Not responseInsert = 1 Then
                MsgBox(responseInsert)
            End If
        Next
        'Else
        'MySql.insertupdate("INSERT INTO whldata.user_notifications (payrollId, notificationTitle, notificationBody, notificationStyle, notExpiryDateTime, notIsRead, notImgLink) VALUES (" + targetempno.ToString + ",'" + TargetTitle.Text + "','" + TargetBody.Text + "','Message','" + Now.ToShortDateString + " " + Now.ToLongTimeString + "','True', '" + TargetFileNew.Text.Replace("\", "\\") + "');")

        'End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

        Me.Dispose()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CreateNotification_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim emplist As New WHLClasses.EmployeeCollection
        For Each employee As WHLClasses.Employee In emplist.Employees
            If employee.Visible Then
                TargetEmp.Items.Add(employee.FullName + ":" + employee.PayrollId.ToString)
            End If

        Next
        TargetEmp.SelectedIndex = 0
        TargetTitle.Text = "Message from " + My.FSL.FindWindow().AuthenticatedUser.FullName

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim newpath As String = "\\WIN-NOHLS1H9ER8\Data Storage\Noti\" + Now.ToLocalTime.Ticks.ToString + "_" + OpenFileDialog1.SafeFileName
        My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, newpath, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
        TargetFileNew.Text = newpath
        PictureBox.ImageLocation = newpath
        PictureBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Filebutton_Click(sender As Object, e As EventArgs) Handles Filebutton.Click
        OpenFileDialog1.ShowDialog()
    End Sub
End Class
