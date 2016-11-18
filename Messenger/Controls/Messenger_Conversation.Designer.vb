<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Messenger_Conversation
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.SendPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MessageTextBox = New System.Windows.Forms.RichTextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.ConvFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.OneSecUpdates = New System.Windows.Forms.Timer(Me.components)
        Me.ConversationHeader = New WHLClasses.Controls.FacebookMessengerStyleHeader()
        Me.SendFile = New System.Windows.Forms.Button()
        Me.SelectFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.ScalableToMsg1 = New LoginModule.ScalableToMsg()
        Me.ScalableFromMessage1 = New LoginModule.ScalableFromMessage()
        Me.ScalableToMsg2 = New LoginModule.ScalableToMsg()
        Me.ScalableToMsg3 = New LoginModule.ScalableToMsg()
        Me.SendPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ConvFlow.SuspendLayout()
        Me.ConversationHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'SendPanel
        '
        Me.SendPanel.Controls.Add(Me.Panel2)
        Me.SendPanel.Controls.Add(Me.SendButton)
        Me.SendPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SendPanel.Location = New System.Drawing.Point(0, 597)
        Me.SendPanel.MinimumSize = New System.Drawing.Size(394, 34)
        Me.SendPanel.Name = "SendPanel"
        Me.SendPanel.Size = New System.Drawing.Size(394, 34)
        Me.SendPanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MessageTextBox)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 34)
        Me.Panel2.TabIndex = 3
        '
        'MessageTextBox
        '
        Me.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageTextBox.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageTextBox.Location = New System.Drawing.Point(0, 0)
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(323, 32)
        Me.MessageTextBox.TabIndex = 0
        Me.MessageTextBox.Text = ""
        '
        'SendButton
        '
        Me.SendButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SendButton.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendButton.Location = New System.Drawing.Point(321, -1)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(73, 36)
        Me.SendButton.TabIndex = 2
        Me.SendButton.Text = "Send"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'ConvFlow
        '
        Me.ConvFlow.AutoScroll = True
        Me.ConvFlow.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ConvFlow.Controls.Add(Me.ScalableToMsg1)
        Me.ConvFlow.Controls.Add(Me.ScalableFromMessage1)
        Me.ConvFlow.Controls.Add(Me.ScalableToMsg2)
        Me.ConvFlow.Controls.Add(Me.ScalableToMsg3)
        Me.ConvFlow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConvFlow.Location = New System.Drawing.Point(0, 50)
        Me.ConvFlow.Name = "ConvFlow"
        Me.ConvFlow.Size = New System.Drawing.Size(394, 547)
        Me.ConvFlow.TabIndex = 8
        '
        'OneSecUpdates
        '
        Me.OneSecUpdates.Interval = 500
        '
        'ConversationHeader
        '
        Me.ConversationHeader.BackColor = System.Drawing.Color.Transparent
        Me.ConversationHeader.BackgroundColor = System.Drawing.Color.White
        Me.ConversationHeader.BackgroundOpacity = 0.3!
        Me.ConversationHeader.BaseBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ConversationHeader.Controls.Add(Me.SendFile)
        Me.ConversationHeader.Controls.Add(Me.SelectFile)
        Me.ConversationHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.ConversationHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConversationHeader.Location = New System.Drawing.Point(0, 0)
        Me.ConversationHeader.Name = "ConversationHeader"
        Me.ConversationHeader.Size = New System.Drawing.Size(394, 50)
        Me.ConversationHeader.TabIndex = 9
        Me.ConversationHeader.Titletext = "Conversation"
        '
        'SendFile
        '
        Me.SendFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SendFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SendFile.Location = New System.Drawing.Point(309, 0)
        Me.SendFile.Name = "SendFile"
        Me.SendFile.Size = New System.Drawing.Size(85, 50)
        Me.SendFile.TabIndex = 5
        Me.SendFile.Text = "Send File"
        Me.SendFile.UseVisualStyleBackColor = True
        '
        'SelectFile
        '
        Me.SelectFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SelectFile.Location = New System.Drawing.Point(0, 0)
        Me.SelectFile.Name = "SelectFile"
        Me.SelectFile.Size = New System.Drawing.Size(89, 50)
        Me.SelectFile.TabIndex = 4
        Me.SelectFile.Text = "Select File"
        Me.SelectFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'ScalableToMsg1
        '
        Me.ScalableToMsg1.AutoSize = True
        Me.ScalableToMsg1.ImagePath = Nothing
        Me.ScalableToMsg1.Location = New System.Drawing.Point(0, 0)
        Me.ScalableToMsg1.Margin = New System.Windows.Forms.Padding(0)
        Me.ScalableToMsg1.MessageText = "This is hopefully a message which spans 2 lines so it should expand a bit."
        Me.ScalableToMsg1.Name = "ScalableToMsg1"
        Me.ScalableToMsg1.Size = New System.Drawing.Size(359, 64)
        Me.ScalableToMsg1.SubText = "RTF"
        Me.ScalableToMsg1.TabIndex = 0
        '
        'ScalableFromMessage1
        '
        Me.ScalableFromMessage1.AutoSize = True
        Me.ScalableFromMessage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScalableFromMessage1.ImagePath = Nothing
        Me.ScalableFromMessage1.Location = New System.Drawing.Point(0, 64)
        Me.ScalableFromMessage1.Margin = New System.Windows.Forms.Padding(0)
        Me.ScalableFromMessage1.MessageText = "\viewkind4\uc1d\f0\fs18 This is hopefully a message which spans 2 lines so it sho" &
    "uld expand a bit."
        Me.ScalableFromMessage1.Name = "ScalableFromMessage1"
        Me.ScalableFromMessage1.Size = New System.Drawing.Size(547, 64)
        Me.ScalableFromMessage1.SubText = "RTF"
        Me.ScalableFromMessage1.TabIndex = 1
        '
        'ScalableToMsg2
        '
        Me.ScalableToMsg2.AutoSize = True
        Me.ScalableToMsg2.ImagePath = Nothing
        Me.ScalableToMsg2.Location = New System.Drawing.Point(0, 128)
        Me.ScalableToMsg2.Margin = New System.Windows.Forms.Padding(0)
        Me.ScalableToMsg2.MessageText = "This is hopefully a message which spans 2 lines so it should expand a bit."
        Me.ScalableToMsg2.Name = "ScalableToMsg2"
        Me.ScalableToMsg2.Size = New System.Drawing.Size(359, 64)
        Me.ScalableToMsg2.SubText = "RTF"
        Me.ScalableToMsg2.TabIndex = 2
        '
        'ScalableToMsg3
        '
        Me.ScalableToMsg3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScalableToMsg3.AutoSize = True
        Me.ScalableToMsg3.ImagePath = Nothing
        Me.ScalableToMsg3.Location = New System.Drawing.Point(0, 192)
        Me.ScalableToMsg3.Margin = New System.Windows.Forms.Padding(0)
        Me.ScalableToMsg3.MessageText = "This is hopefully a message which spans 2 lines so it should expand a bit."
        Me.ScalableToMsg3.Name = "ScalableToMsg3"
        Me.ScalableToMsg3.Size = New System.Drawing.Size(423, 64)
        Me.ScalableToMsg3.SubText = "RTF"
        Me.ScalableToMsg3.TabIndex = 3
        '
        'Messenger_Conversation
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Controls.Add(Me.ConvFlow)
        Me.Controls.Add(Me.SendPanel)
        Me.Controls.Add(Me.ConversationHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Messenger_Conversation"
        Me.Size = New System.Drawing.Size(394, 631)
        Me.SendPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ConvFlow.ResumeLayout(False)
        Me.ConvFlow.PerformLayout()
        Me.ConversationHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SendPanel As System.Windows.Forms.Panel
    Friend WithEvents ConvFlow As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ScalableToMsg1 As ScalableToMsg
    Friend WithEvents ScalableFromMessage1 As ScalableFromMessage
    Friend WithEvents ScalableToMsg2 As ScalableToMsg
    Friend WithEvents ScalableToMsg3 As ScalableToMsg
    Friend WithEvents SendButton As System.Windows.Forms.Button
    Friend WithEvents OneSecUpdates As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MessageTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ConversationHeader As WHLClasses.Controls.FacebookMessengerStyleHeader
    Friend WithEvents SelectFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SendFile As System.Windows.Forms.Button
End Class
