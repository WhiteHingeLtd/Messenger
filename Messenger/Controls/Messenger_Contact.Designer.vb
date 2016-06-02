<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messenger_Contact
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContactStatusText = New System.Windows.Forms.Label()
        Me.ContactName = New System.Windows.Forms.Label()
        Me.ContactStatusImg = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ContactStatusImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ContactStatusText)
        Me.Panel1.Controls.Add(Me.ContactName)
        Me.Panel1.Controls.Add(Me.ContactStatusImg)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 53)
        Me.Panel1.TabIndex = 0
        '
        'ContactStatusText
        '
        Me.ContactStatusText.AutoEllipsis = True
        Me.ContactStatusText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactStatusText.ForeColor = System.Drawing.Color.DimGray
        Me.ContactStatusText.Location = New System.Drawing.Point(50, 31)
        Me.ContactStatusText.Name = "ContactStatusText"
        Me.ContactStatusText.Size = New System.Drawing.Size(245, 19)
        Me.ContactStatusText.TabIndex = 2
        Me.ContactStatusText.Text = "Label1"
        Me.ContactStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContactName
        '
        Me.ContactName.Location = New System.Drawing.Point(45, 3)
        Me.ContactName.Name = "ContactName"
        Me.ContactName.Size = New System.Drawing.Size(245, 28)
        Me.ContactName.TabIndex = 1
        Me.ContactName.Text = "Label1"
        '
        'ContactStatusImg
        '
        Me.ContactStatusImg.Image = Global.LoginModule.My.Resources.Resources.Contact_Offline
        Me.ContactStatusImg.Location = New System.Drawing.Point(0, 3)
        Me.ContactStatusImg.Name = "ContactStatusImg"
        Me.ContactStatusImg.Size = New System.Drawing.Size(44, 47)
        Me.ContactStatusImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ContactStatusImg.TabIndex = 0
        Me.ContactStatusImg.TabStop = False
        '
        'Messenger_Contact
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Messenger_Contact"
        Me.Size = New System.Drawing.Size(290, 55)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ContactStatusImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ContactStatusImg As System.Windows.Forms.PictureBox
    Friend WithEvents ContactStatusText As System.Windows.Forms.Label
    Friend WithEvents ContactName As System.Windows.Forms.Label
End Class
