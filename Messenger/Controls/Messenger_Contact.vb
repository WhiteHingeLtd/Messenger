Public Class Messenger_Contact
    Public Employee As WHLClasses.Employee
    Public Property Contact() As WHLClasses.Employee
        Get
            Return Employee
        End Get
        Set(value As WHLClasses.Employee)
            ContactStatusText.Text = value.LoginStatus.FriendlyText
            ContactName.Text = value.FullName
            If value.LoginStatus.LoggedIn Then
                ContactStatusImg.Image = My.Resources.Contact_Online
            Else
                ContactStatusImg.Image = My.Resources.Contact_Offline
            End If
            Employee = value
        End Set
    End Property

    Private Sub ContactName_Click(sender As Object, e As EventArgs) Handles ContactName.Click, ContactStatusText.Click, ContactStatusImg.Click
        MessengerMain.OpenConversation(Employee)
    End Sub

End Class
