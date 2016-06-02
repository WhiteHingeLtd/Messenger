<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FullscreenLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FullscreenLogin))
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.loginfail = New System.Windows.Forms.Label()
        Me.Keypadcover = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.shutdownlabel = New System.Windows.Forms.Label()
        Me.PowerButton = New System.Windows.Forms.PictureBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Userbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ControlBox = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.AppVer = New System.Windows.Forms.Label()
        Me.FSLoginWindowText = New System.Windows.Forms.Label()
        Me.Idletimer = New System.Windows.Forms.Timer(Me.components)
        Me.FireNotifications = New System.Windows.Forms.Timer(Me.components)
        Me.Notifyicon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendANotificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoLoginMaker = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Keypadcover.SuspendLayout()
        CType(Me.PowerButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.ControlBox.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(335, 53)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(102, 34)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'PanelMain
        '
        Me.PanelMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMain.BackColor = System.Drawing.Color.Gray
        Me.PanelMain.Controls.Add(Me.Panel2)
        Me.PanelMain.Location = New System.Drawing.Point(72, 12)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(529, 258)
        Me.PanelMain.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.loginfail)
        Me.Panel2.Controls.Add(Me.Keypadcover)
        Me.Panel2.Controls.Add(Me.shutdownlabel)
        Me.Panel2.Controls.Add(Me.PowerButton)
        Me.Panel2.Controls.Add(Me.Button11)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Userbox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.LoginButton)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(523, 252)
        Me.Panel2.TabIndex = 1
        '
        'loginfail
        '
        Me.loginfail.AutoSize = True
        Me.loginfail.ForeColor = System.Drawing.Color.DarkRed
        Me.loginfail.Location = New System.Drawing.Point(282, 103)
        Me.loginfail.Name = "loginfail"
        Me.loginfail.Size = New System.Drawing.Size(88, 13)
        Me.loginfail.TabIndex = 6
        Me.loginfail.Text = "Couldn't log in!"
        Me.loginfail.Visible = False
        '
        'Keypadcover
        '
        Me.Keypadcover.Controls.Add(Me.Label4)
        Me.Keypadcover.Location = New System.Drawing.Point(141, 35)
        Me.Keypadcover.Name = "Keypadcover"
        Me.Keypadcover.Size = New System.Drawing.Size(380, 202)
        Me.Keypadcover.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Scan your ID card to continue."
        '
        'shutdownlabel
        '
        Me.shutdownlabel.AutoSize = True
        Me.shutdownlabel.ForeColor = System.Drawing.Color.DarkRed
        Me.shutdownlabel.Location = New System.Drawing.Point(40, 238)
        Me.shutdownlabel.Name = "shutdownlabel"
        Me.shutdownlabel.Size = New System.Drawing.Size(138, 13)
        Me.shutdownlabel.TabIndex = 18
        Me.shutdownlabel.Text = "Press again to shut down"
        Me.shutdownlabel.Visible = False
        '
        'PowerButton
        '
        Me.PowerButton.BackgroundImage = Global.LoginModule.My.Resources.Resources._128
        Me.PowerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PowerButton.Location = New System.Drawing.Point(-3, 213)
        Me.PowerButton.Name = "PowerButton"
        Me.PowerButton.Size = New System.Drawing.Size(40, 43)
        Me.PowerButton.TabIndex = 17
        Me.PowerButton.TabStop = False
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(185, 206)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(76, 32)
        Me.Button11.TabIndex = 16
        Me.Button11.Text = "CLEAR"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(144, 206)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(35, 32)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(226, 168)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(35, 32)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(185, 168)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(35, 32)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(185, 130)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(35, 32)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "5"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(144, 168)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(35, 32)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "7"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(144, 130)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 32)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "4"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(226, 130)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 32)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "6"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(226, 92)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 32)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(185, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(144, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(282, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 108)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Userbox
        '
        Me.Userbox.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userbox.Location = New System.Drawing.Point(144, 54)
        Me.Userbox.Name = "Userbox"
        Me.Userbox.Size = New System.Drawing.Size(185, 32)
        Me.Userbox.TabIndex = 4
        Me.Userbox.Text = "$u$22"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Scan your ID card to continue, or type your user ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.LoginModule.My.Resources.Resources.lockicon
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.ControlBox)
        Me.Panel3.Controls.Add(Me.AppVer)
        Me.Panel3.Controls.Add(Me.FSLoginWindowText)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(523, 27)
        Me.Panel3.TabIndex = 1
        '
        'ControlBox
        '
        Me.ControlBox.Controls.Add(Me.Button13)
        Me.ControlBox.Controls.Add(Me.Button12)
        Me.ControlBox.Location = New System.Drawing.Point(444, 0)
        Me.ControlBox.Name = "ControlBox"
        Me.ControlBox.Size = New System.Drawing.Size(80, 27)
        Me.ControlBox.TabIndex = 2
        Me.ControlBox.Visible = False
        '
        'Button13
        '
        Me.Button13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.BackColor = System.Drawing.Color.Maroon
        Me.Button13.BackgroundImage = Global.LoginModule.My.Resources.Resources.Close
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Location = New System.Drawing.Point(40, 0)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(40, 27)
        Me.Button13.TabIndex = 1
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button12.BackgroundImage = Global.LoginModule.My.Resources.Resources.Minimize
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Segoe UI Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(0, 0)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(40, 27)
        Me.Button12.TabIndex = 0
        Me.Button12.UseVisualStyleBackColor = True
        '
        'AppVer
        '
        Me.AppVer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppVer.ForeColor = System.Drawing.SystemColors.Window
        Me.AppVer.Location = New System.Drawing.Point(257, 2)
        Me.AppVer.Name = "AppVer"
        Me.AppVer.Size = New System.Drawing.Size(263, 20)
        Me.AppVer.TabIndex = 1
        Me.AppVer.Text = "Login"
        Me.AppVer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FSLoginWindowText
        '
        Me.FSLoginWindowText.AutoSize = True
        Me.FSLoginWindowText.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FSLoginWindowText.ForeColor = System.Drawing.SystemColors.Window
        Me.FSLoginWindowText.Location = New System.Drawing.Point(2, 2)
        Me.FSLoginWindowText.Name = "FSLoginWindowText"
        Me.FSLoginWindowText.Size = New System.Drawing.Size(46, 20)
        Me.FSLoginWindowText.TabIndex = 0
        Me.FSLoginWindowText.Text = "Login"
        '
        'Idletimer
        '
        Me.Idletimer.Interval = 1000
        '
        'FireNotifications
        '
        Me.FireNotifications.Interval = 1000
        '
        'Notifyicon
        '
        Me.Notifyicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Notifyicon.BalloonTipText = "You can log out from the White Hinge logo which has now appeared in the notificat" &
    "ion area. This little program is running to enable some functions of other progr" &
    "ams to work."
        Me.Notifyicon.BalloonTipTitle = "Login Module Control"
        Me.Notifyicon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Notifyicon.Icon = CType(resources.GetObject("Notifyicon.Icon"), System.Drawing.Icon)
        Me.Notifyicon.Text = "WHL Login Module"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.SendANotificationToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(185, 70)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'SendANotificationToolStripMenuItem
        '
        Me.SendANotificationToolStripMenuItem.Name = "SendANotificationToolStripMenuItem"
        Me.SendANotificationToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SendANotificationToolStripMenuItem.Text = "Send a Notification..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.ToolStripMenuItem1.Text = "Quit"
        '
        'AutoLoginMaker
        '
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 67)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Waiting for tasks to complete..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FullscreenLogin
        '
        Me.AcceptButton = Me.LoginButton
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.LoginModule.My.Resources.Resources.Fushmesh
        Me.ClientSize = New System.Drawing.Size(667, 366)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FullscreenLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FSLWindow"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.PanelMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Keypadcover.ResumeLayout(False)
        Me.Keypadcover.PerformLayout()
        CType(Me.PowerButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ControlBox.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FSLoginWindowText As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Userbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents loginfail As System.Windows.Forms.Label
    Friend WithEvents Idletimer As System.Windows.Forms.Timer
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PowerButton As System.Windows.Forms.PictureBox
    Friend WithEvents shutdownlabel As System.Windows.Forms.Label
    Friend WithEvents AppVer As System.Windows.Forms.Label
    Friend WithEvents Keypadcover As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FireNotifications As System.Windows.Forms.Timer
    Friend WithEvents Notifyicon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendANotificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlBox As System.Windows.Forms.Panel
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents AutoLoginMaker As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
