<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message_To
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
        Me.MessageBubble = New System.Windows.Forms.Panel()
        Me.MessageText = New System.Windows.Forms.Label()
        Me.RealText = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyMessageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageSubtext = New System.Windows.Forms.Label()
        Me.PictureBoxA = New System.Windows.Forms.PictureBox()
        Me.To_Arrow = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.To_Left = New System.Windows.Forms.PictureBox()
        Me.To_Top = New System.Windows.Forms.PictureBox()
        Me.To_Bottom = New System.Windows.Forms.PictureBox()
        Me.SubtextTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MessageBubble.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBoxA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.To_Arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.To_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.To_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.To_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MessageBubble
        '
        Me.MessageBubble.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageBubble.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.MessageBubble.Controls.Add(Me.MessageText)
        Me.MessageBubble.Controls.Add(Me.RealText)
        Me.MessageBubble.Controls.Add(Me.PictureBoxA)
        Me.MessageBubble.Location = New System.Drawing.Point(3, 3)
        Me.MessageBubble.Name = "MessageBubble"
        Me.MessageBubble.Size = New System.Drawing.Size(315, 115)
        Me.MessageBubble.TabIndex = 0
        '
        'MessageText
        '
        Me.MessageText.Location = New System.Drawing.Point(37, 54)
        Me.MessageText.Name = "MessageText"
        Me.MessageText.Size = New System.Drawing.Size(100, 23)
        Me.MessageText.TabIndex = 9
        Me.MessageText.Text = "Label1"
        Me.MessageText.Visible = False
        '
        'RealText
        '
        Me.RealText.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.RealText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RealText.ContextMenuStrip = Me.ContextMenuStrip2
        Me.RealText.Cursor = System.Windows.Forms.Cursors.Default
        Me.RealText.Location = New System.Drawing.Point(-2, 0)
        Me.RealText.Name = "RealText"
        Me.RealText.ReadOnly = True
        Me.RealText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RealText.Size = New System.Drawing.Size(310, 39)
        Me.RealText.TabIndex = 8
        Me.RealText.Text = ""
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyMessageToolStripMenuItem1, Me.CopySelectionToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(154, 48)
        '
        'CopyMessageToolStripMenuItem1
        '
        Me.CopyMessageToolStripMenuItem1.Name = "CopyMessageToolStripMenuItem1"
        Me.CopyMessageToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.CopyMessageToolStripMenuItem1.Text = "Copy Message"
        '
        'CopySelectionToolStripMenuItem
        '
        Me.CopySelectionToolStripMenuItem.Name = "CopySelectionToolStripMenuItem"
        Me.CopySelectionToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CopySelectionToolStripMenuItem.Text = "Copy Selection"
        '
        'MessageSubtext
        '
        Me.MessageSubtext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageSubtext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageSubtext.ForeColor = System.Drawing.Color.DimGray
        Me.MessageSubtext.Location = New System.Drawing.Point(4, 122)
        Me.MessageSubtext.Name = "MessageSubtext"
        Me.MessageSubtext.Size = New System.Drawing.Size(294, 22)
        Me.MessageSubtext.TabIndex = 7
        Me.MessageSubtext.Text = "Subtext"
        Me.MessageSubtext.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MessageSubtext.Visible = False
        '
        'PictureBoxA
        '
        Me.PictureBoxA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxA.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PictureBoxA.InitialImage = Global.LoginModule.My.Resources.Resources.loading_spinner
        Me.PictureBoxA.Location = New System.Drawing.Point(10, -46)
        Me.PictureBoxA.Name = "PictureBoxA"
        Me.PictureBoxA.Size = New System.Drawing.Size(292, 154)
        Me.PictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxA.TabIndex = 2
        Me.PictureBoxA.TabStop = False
        Me.PictureBoxA.Visible = False
        '
        'To_Arrow
        '
        Me.To_Arrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.To_Arrow.Image = Global.LoginModule.My.Resources.Resources.To_BubbleArrow
        Me.To_Arrow.Location = New System.Drawing.Point(293, 102)
        Me.To_Arrow.Name = "To_Arrow"
        Me.To_Arrow.Size = New System.Drawing.Size(52, 42)
        Me.To_Arrow.TabIndex = 1
        Me.To_Arrow.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.LoginModule.My.Resources.Resources.To_Right
        Me.PictureBox1.Location = New System.Drawing.Point(309, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 108)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'To_Left
        '
        Me.To_Left.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.To_Left.BackgroundImage = Global.LoginModule.My.Resources.Resources.To_Left
        Me.To_Left.Location = New System.Drawing.Point(0, 3)
        Me.To_Left.Name = "To_Left"
        Me.To_Left.Size = New System.Drawing.Size(4, 115)
        Me.To_Left.TabIndex = 4
        Me.To_Left.TabStop = False
        '
        'To_Top
        '
        Me.To_Top.BackgroundImage = Global.LoginModule.My.Resources.Resources.To_Top
        Me.To_Top.Location = New System.Drawing.Point(0, 0)
        Me.To_Top.Name = "To_Top"
        Me.To_Top.Size = New System.Drawing.Size(313, 5)
        Me.To_Top.TabIndex = 3
        Me.To_Top.TabStop = False
        '
        'To_Bottom
        '
        Me.To_Bottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.To_Bottom.BackgroundImage = Global.LoginModule.My.Resources.Resources.To_Bottom
        Me.To_Bottom.Location = New System.Drawing.Point(0, 115)
        Me.To_Bottom.Name = "To_Bottom"
        Me.To_Bottom.Size = New System.Drawing.Size(294, 4)
        Me.To_Bottom.TabIndex = 2
        Me.To_Bottom.TabStop = False
        '
        'SubtextTooltip
        '
        '
        'Message_To
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.MessageSubtext)
        Me.Controls.Add(Me.MessageBubble)
        Me.Controls.Add(Me.To_Arrow)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.To_Left)
        Me.Controls.Add(Me.To_Top)
        Me.Controls.Add(Me.To_Bottom)
        Me.Name = "Message_To"
        Me.Size = New System.Drawing.Size(346, 140)
        Me.MessageBubble.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBoxA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.To_Arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.To_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.To_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.To_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MessageBubble As System.Windows.Forms.Panel
    Friend WithEvents To_Arrow As System.Windows.Forms.PictureBox
    Friend WithEvents To_Bottom As System.Windows.Forms.PictureBox
    Friend WithEvents To_Top As System.Windows.Forms.PictureBox
    Friend WithEvents To_Left As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MessageSubtext As System.Windows.Forms.Label
    Friend WithEvents PictureBoxA As System.Windows.Forms.PictureBox
    Friend WithEvents RealText As System.Windows.Forms.RichTextBox
    Friend WithEvents MessageText As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyMessageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopySelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubtextTooltip As System.Windows.Forms.ToolTip
End Class
