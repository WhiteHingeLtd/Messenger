<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InboxOutbox
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
        Me.components = New System.ComponentModel.Container()
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.ZoneTitle = New WHLClasses.Controls.FacebookMessengerStyleHeader()
        Me.SuspendLayout()
        '
        'FlowPanel
        '
        Me.FlowPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowPanel.AutoScroll = True
        Me.FlowPanel.Location = New System.Drawing.Point(3, 48)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(591, 503)
        Me.FlowPanel.TabIndex = 5
        '
        'Updater
        '
        Me.Updater.Interval = 45000
        '
        'ZoneTitle
        '
        Me.ZoneTitle.BackColor = System.Drawing.Color.Transparent
        Me.ZoneTitle.BackgroundColor = System.Drawing.Color.White
        Me.ZoneTitle.BackgroundOpacity = 0.75!
        Me.ZoneTitle.BaseBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ZoneTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.ZoneTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneTitle.Location = New System.Drawing.Point(0, 0)
        Me.ZoneTitle.Name = "ZoneTitle"
        Me.ZoneTitle.Size = New System.Drawing.Size(597, 50)
        Me.ZoneTitle.TabIndex = 6
        Me.ZoneTitle.Titletext = "Inbox"
        '
        'InboxOutbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ZoneTitle)
        Me.Controls.Add(Me.FlowPanel)
        Me.Name = "InboxOutbox"
        Me.Size = New System.Drawing.Size(597, 554)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Updater As System.Windows.Forms.Timer
    Friend WithEvents ZoneTitle As WHLClasses.Controls.FacebookMessengerStyleHeader
End Class
