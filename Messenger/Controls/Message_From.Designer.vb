<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message_From
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
        Me.Messagetext = New System.Windows.Forms.Label()
        Me.Realtext = New System.Windows.Forms.RichTextBox()
        Me.PictureBoxA = New System.Windows.Forms.PictureBox()
        Me.MessageSubtext = New System.Windows.Forms.Label()
        Me.To_Top = New System.Windows.Forms.PictureBox()
        Me.To_Bottom = New System.Windows.Forms.PictureBox()
        Me.To_Arrow = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.To_Left = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyMessageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageBubble.SuspendLayout()
        CType(Me.PictureBoxA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.To_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.To_Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.To_Arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.To_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageBubble
        '
        Me.MessageBubble.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageBubble.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.MessageBubble.Controls.Add(Me.Messagetext)
        Me.MessageBubble.Controls.Add(Me.Realtext)
        Me.MessageBubble.Controls.Add(Me.PictureBoxA)
        Me.MessageBubble.Location = New System.Drawing.Point(30, 3)
        Me.MessageBubble.Name = "MessageBubble"
        Me.MessageBubble.Size = New System.Drawing.Size(307, 43)
        Me.MessageBubble.TabIndex = 8
        '
        'Messagetext
        '
        Me.Messagetext.Location = New System.Drawing.Point(96, 14)
        Me.Messagetext.Name = "Messagetext"
        Me.Messagetext.Size = New System.Drawing.Size(100, 23)
        Me.Messagetext.TabIndex = 3
        Me.Messagetext.Text = "Label1"
        Me.Messagetext.Visible = False
        '
        'Realtext
        '
        Me.Realtext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Realtext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Realtext.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Realtext.Location = New System.Drawing.Point(1, 1)
        Me.Realtext.Name = "Realtext"
        Me.Realtext.ReadOnly = True
        Me.Realtext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Realtext.Size = New System.Drawing.Size(303, 39)
        Me.Realtext.TabIndex = 2
        Me.Realtext.Text = ""
        '
        'PictureBoxA
        '
        Me.PictureBoxA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.PictureBoxA.InitialImage = Global.LoginModule.My.Resources.Resources.loading_spinner
        Me.PictureBoxA.Location = New System.Drawing.Point(8, -116)
        Me.PictureBoxA.Name = "PictureBoxA"
        Me.PictureBoxA.Size = New System.Drawing.Size(292, 154)
        Me.PictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxA.TabIndex = 1
        Me.PictureBoxA.TabStop = False
        Me.PictureBoxA.Visible = False
        '
        'MessageSubtext
        '
        Me.MessageSubtext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageSubtext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageSubtext.ForeColor = System.Drawing.Color.DimGray
        Me.MessageSubtext.Location = New System.Drawing.Point(38, 50)
        Me.MessageSubtext.Name = "MessageSubtext"
        Me.MessageSubtext.Size = New System.Drawing.Size(294, 22)
        Me.MessageSubtext.TabIndex = 14
        Me.MessageSubtext.Text = "Subtext"
        '
        'To_Top
        '
        Me.To_Top.BackgroundImage = Global.LoginModule.My.Resources.Resources.From_Top
        Me.To_Top.Location = New System.Drawing.Point(26, 0)
        Me.To_Top.Name = "To_Top"
        Me.To_Top.Size = New System.Drawing.Size(313, 5)
        Me.To_Top.TabIndex = 11
        Me.To_Top.TabStop = False
        '
        'To_Bottom
        '
        Me.To_Bottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.To_Bottom.BackgroundImage = Global.LoginModule.My.Resources.Resources.From_Bottom
        Me.To_Bottom.Location = New System.Drawing.Point(45, 43)
        Me.To_Bottom.Name = "To_Bottom"
        Me.To_Bottom.Size = New System.Drawing.Size(294, 4)
        Me.To_Bottom.TabIndex = 10
        Me.To_Bottom.TabStop = False
        '
        'To_Arrow
        '
        Me.To_Arrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.To_Arrow.Image = Global.LoginModule.My.Resources.Resources.From_Arrow
        Me.To_Arrow.Location = New System.Drawing.Point(0, 30)
        Me.To_Arrow.Name = "To_Arrow"
        Me.To_Arrow.Size = New System.Drawing.Size(52, 42)
        Me.To_Arrow.TabIndex = 9
        Me.To_Arrow.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.LoginModule.My.Resources.Resources.From_Left
        Me.PictureBox1.Location = New System.Drawing.Point(26, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 32)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'To_Left
        '
        Me.To_Left.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.To_Left.BackgroundImage = Global.LoginModule.My.Resources.Resources.From_Right
        Me.To_Left.Location = New System.Drawing.Point(336, 0)
        Me.To_Left.Name = "To_Left"
        Me.To_Left.Size = New System.Drawing.Size(4, 46)
        Me.To_Left.TabIndex = 12
        Me.To_Left.TabStop = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyMessageToolStripMenuItem1, Me.CopySelectionToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(154, 70)
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
        'Message_From
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.To_Top)
        Me.Controls.Add(Me.MessageSubtext)
        Me.Controls.Add(Me.MessageBubble)
        Me.Controls.Add(Me.To_Bottom)
        Me.Controls.Add(Me.To_Arrow)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.To_Left)
        Me.Name = "Message_From"
        Me.Size = New System.Drawing.Size(346, 67)
        Me.MessageBubble.ResumeLayout(False)
        CType(Me.PictureBoxA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.To_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.To_Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.To_Arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.To_Left, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MessageBubble As System.Windows.Forms.Panel
    Friend WithEvents To_Arrow As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents To_Left As System.Windows.Forms.PictureBox
    Friend WithEvents To_Top As System.Windows.Forms.PictureBox
    Friend WithEvents To_Bottom As System.Windows.Forms.PictureBox
    Friend WithEvents MessageSubtext As System.Windows.Forms.Label
    Friend WithEvents PictureBoxA As System.Windows.Forms.PictureBox
    Friend WithEvents Realtext As System.Windows.Forms.RichTextBox
    Friend WithEvents Messagetext As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyMessageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopySelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
