<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InboxOutboxItem
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
        Me.DateLabel = New System.Windows.Forms.Panel()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.SenderLabel = New System.Windows.Forms.Label()
        Me.AttachmentIcon = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MessageBody = New System.Windows.Forms.Label()
        Me.DateLabel.SuspendLayout()
        Me.AttachmentIcon.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateLabel.Controls.Add(Me.DateTimeLabel)
        Me.DateLabel.Location = New System.Drawing.Point(-1, -1)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(116, 26)
        Me.DateLabel.TabIndex = 0
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimeLabel.Location = New System.Drawing.Point(0, 0)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(114, 24)
        Me.DateTimeLabel.TabIndex = 0
        Me.DateTimeLabel.Text = "30/10/2015 12:28:27"
        Me.DateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SenderLabel
        '
        Me.SenderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SenderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SenderLabel.Location = New System.Drawing.Point(113, -1)
        Me.SenderLabel.Name = "SenderLabel"
        Me.SenderLabel.Size = New System.Drawing.Size(113, 26)
        Me.SenderLabel.TabIndex = 1
        Me.SenderLabel.Text = "Sky Grannell-Baker"
        Me.SenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AttachmentIcon
        '
        Me.AttachmentIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttachmentIcon.Controls.Add(Me.Label1)
        Me.AttachmentIcon.Controls.Add(Me.PictureBox1)
        Me.AttachmentIcon.Location = New System.Drawing.Point(541, 0)
        Me.AttachmentIcon.Name = "AttachmentIcon"
        Me.AttachmentIcon.Size = New System.Drawing.Size(48, 31)
        Me.AttachmentIcon.TabIndex = 3
        Me.AttachmentIcon.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.LoginModule.My.Resources.Resources.Attachment
        Me.PictureBox1.Location = New System.Drawing.Point(10, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MessageBody
        '
        Me.MessageBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageBody.Location = New System.Drawing.Point(227, 5)
        Me.MessageBody.Name = "MessageBody"
        Me.MessageBody.Size = New System.Drawing.Size(362, 20)
        Me.MessageBody.TabIndex = 5
        Me.MessageBody.Text = "Label2"
        '
        'InboxOutboxItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.AttachmentIcon)
        Me.Controls.Add(Me.MessageBody)
        Me.Controls.Add(Me.SenderLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "InboxOutboxItem"
        Me.Size = New System.Drawing.Size(588, 24)
        Me.DateLabel.ResumeLayout(False)
        Me.AttachmentIcon.ResumeLayout(False)
        Me.AttachmentIcon.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateLabel As System.Windows.Forms.Panel
    Friend WithEvents DateTimeLabel As System.Windows.Forms.Label
    Friend WithEvents SenderLabel As System.Windows.Forms.Label
    Friend WithEvents AttachmentIcon As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MessageBody As System.Windows.Forms.Label
End Class
