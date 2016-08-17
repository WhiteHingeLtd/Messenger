<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessengerMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessengerMain))
        Me.IconSwapper = New System.Windows.Forms.Timer(Me.components)
        Me.ContactsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ConversationPanel = New System.Windows.Forms.Panel()
        Me.Messenger_Conversation1 = New LoginModule.Messenger_Conversation()
        Me.InboxPanel = New System.Windows.Forms.Panel()
        Me.InboxOutbox = New LoginModule.InboxOutbox()
        Me.MyInfo = New System.Windows.Forms.Panel()
        Me.OutboxButton = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoggedUserNew = New WHLClasses.Controls.FacebookMessengerStyleHeader()
        Me.MainSettingsButton = New System.Windows.Forms.PictureBox()
        Me.InboxButton = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TenSecUpdates = New System.Windows.Forms.Timer(Me.components)
        Me.MainSettingsContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversationPanel.SuspendLayout()
        Me.InboxPanel.SuspendLayout()
        Me.MyInfo.SuspendLayout()
        Me.OutboxButton.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoggedUserNew.SuspendLayout()
        CType(Me.MainSettingsButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InboxButton.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSettingsContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconSwapper
        '
        Me.IconSwapper.Interval = 600
        '
        'ContactsPanel
        '
        Me.ContactsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ContactsPanel.AutoScroll = True
        Me.ContactsPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ContactsPanel.Location = New System.Drawing.Point(0, 90)
        Me.ContactsPanel.Name = "ContactsPanel"
        Me.ContactsPanel.Size = New System.Drawing.Size(309, 678)
        Me.ContactsPanel.TabIndex = 0
        '
        'ConversationPanel
        '
        Me.ConversationPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConversationPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ConversationPanel.Controls.Add(Me.Messenger_Conversation1)
        Me.ConversationPanel.Location = New System.Drawing.Point(310, 0)
        Me.ConversationPanel.Name = "ConversationPanel"
        Me.ConversationPanel.Size = New System.Drawing.Size(603, 768)
        Me.ConversationPanel.TabIndex = 7
        '
        'Messenger_Conversation1
        '
        Me.Messenger_Conversation1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Messenger_Conversation1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Messenger_Conversation1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Messenger_Conversation1.Location = New System.Drawing.Point(0, 0)
        Me.Messenger_Conversation1.Name = "Messenger_Conversation1"
        Me.Messenger_Conversation1.Size = New System.Drawing.Size(603, 768)
        Me.Messenger_Conversation1.TabIndex = 0
        '
        'InboxPanel
        '
        Me.InboxPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InboxPanel.BackColor = System.Drawing.Color.White
        Me.InboxPanel.Controls.Add(Me.InboxOutbox)
        Me.InboxPanel.Location = New System.Drawing.Point(310, 0)
        Me.InboxPanel.Name = "InboxPanel"
        Me.InboxPanel.Size = New System.Drawing.Size(603, 768)
        Me.InboxPanel.TabIndex = 1
        '
        'InboxOutbox
        '
        Me.InboxOutbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InboxOutbox.Location = New System.Drawing.Point(0, 0)
        Me.InboxOutbox.Name = "InboxOutbox"
        Me.InboxOutbox.Size = New System.Drawing.Size(603, 768)
        Me.InboxOutbox.TabIndex = 0
        '
        'MyInfo
        '
        Me.MyInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MyInfo.Controls.Add(Me.OutboxButton)
        Me.MyInfo.Controls.Add(Me.LoggedUserNew)
        Me.MyInfo.Controls.Add(Me.InboxButton)
        Me.MyInfo.Location = New System.Drawing.Point(0, 0)
        Me.MyInfo.Name = "MyInfo"
        Me.MyInfo.Size = New System.Drawing.Size(309, 93)
        Me.MyInfo.TabIndex = 5
        '
        'OutboxButton
        '
        Me.OutboxButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OutboxButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutboxButton.Controls.Add(Me.PictureBox2)
        Me.OutboxButton.Controls.Add(Me.Label2)
        Me.OutboxButton.Location = New System.Drawing.Point(154, 49)
        Me.OutboxButton.Name = "OutboxButton"
        Me.OutboxButton.Size = New System.Drawing.Size(156, 43)
        Me.OutboxButton.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LoginModule.My.Resources.Resources.Outbox
        Me.PictureBox2.Location = New System.Drawing.Point(24, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Outbox"
        '
        'LoggedUserNew
        '
        Me.LoggedUserNew.BackColor = System.Drawing.Color.Transparent
        Me.LoggedUserNew.BackgroundColor = System.Drawing.Color.White
        Me.LoggedUserNew.BackgroundOpacity = 0.75!
        Me.LoggedUserNew.BaseBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LoggedUserNew.Controls.Add(Me.MainSettingsButton)
        Me.LoggedUserNew.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoggedUserNew.Location = New System.Drawing.Point(0, 0)
        Me.LoggedUserNew.Name = "LoggedUserNew"
        Me.LoggedUserNew.Size = New System.Drawing.Size(310, 50)
        Me.LoggedUserNew.TabIndex = 7
        Me.LoggedUserNew.Titletext = "..."
        '
        'MainSettingsButton
        '
        Me.MainSettingsButton.BackgroundImage = Global.LoginModule.My.Resources.Resources.FB_Settings
        Me.MainSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MainSettingsButton.Location = New System.Drawing.Point(1, 1)
        Me.MainSettingsButton.Name = "MainSettingsButton"
        Me.MainSettingsButton.Size = New System.Drawing.Size(48, 48)
        Me.MainSettingsButton.TabIndex = 0
        Me.MainSettingsButton.TabStop = False
        '
        'InboxButton
        '
        Me.InboxButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.InboxButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InboxButton.Controls.Add(Me.PictureBox1)
        Me.InboxButton.Controls.Add(Me.Label1)
        Me.InboxButton.Location = New System.Drawing.Point(-1, 49)
        Me.InboxButton.Name = "InboxButton"
        Me.InboxButton.Size = New System.Drawing.Size(156, 43)
        Me.InboxButton.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LoginModule.My.Resources.Resources.Inbox
        Me.PictureBox1.Location = New System.Drawing.Point(24, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Inbox"
        '
        'TenSecUpdates
        '
        Me.TenSecUpdates.Enabled = True
        Me.TenSecUpdates.Interval = 10000
        '
        'MainSettingsContextMenu
        '
        Me.MainSettingsContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.MainSettingsContextMenu.Name = "MainSettingsContextMenu"
        Me.MainSettingsContextMenu.Size = New System.Drawing.Size(116, 48)
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'MessengerMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(913, 768)
        Me.Controls.Add(Me.MyInfo)
        Me.Controls.Add(Me.ContactsPanel)
        Me.Controls.Add(Me.InboxPanel)
        Me.Controls.Add(Me.ConversationPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(929, 597)
        Me.Name = "MessengerMain"
        Me.Text = "Messenger"
        Me.ConversationPanel.ResumeLayout(False)
        Me.InboxPanel.ResumeLayout(False)
        Me.MyInfo.ResumeLayout(False)
        Me.OutboxButton.ResumeLayout(False)
        Me.OutboxButton.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoggedUserNew.ResumeLayout(False)
        CType(Me.MainSettingsButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InboxButton.ResumeLayout(False)
        Me.InboxButton.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSettingsContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IconSwapper As System.Windows.Forms.Timer
    Friend WithEvents ConversationPanel As System.Windows.Forms.Panel
    Friend WithEvents MyInfo As System.Windows.Forms.Panel
    Friend WithEvents ContactsPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TenSecUpdates As System.Windows.Forms.Timer
    Friend WithEvents Messenger_Conversation1 As Messenger_Conversation
    Friend WithEvents OutboxButton As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InboxButton As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents InboxPanel As System.Windows.Forms.Panel
    Friend WithEvents InboxOutbox As InboxOutbox
    Friend WithEvents LoggedUserNew As WHLClasses.Controls.FacebookMessengerStyleHeader
    Friend WithEvents MainSettingsButton As System.Windows.Forms.PictureBox
    Friend WithEvents MainSettingsContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
