<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScalableToMsg
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
        Me.ActualMessage = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyMessageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubTextTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DateTimeBox = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActualMessage
        '
        Me.ActualMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActualMessage.AutoSize = True
        Me.ActualMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ActualMessage.ContextMenuStrip = Me.ContextMenuStrip2
        Me.ActualMessage.Cursor = System.Windows.Forms.Cursors.Default
        Me.ActualMessage.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.ActualMessage.ForeColor = System.Drawing.Color.Black
        Me.ActualMessage.Location = New System.Drawing.Point(181, 11)
        Me.ActualMessage.Name = "ActualMessage"
        Me.ActualMessage.Size = New System.Drawing.Size(58, 21)
        Me.ActualMessage.TabIndex = 1
        Me.ActualMessage.Text = "asdasd"
        Me.SubTextTooltip.SetToolTip(Me.ActualMessage, "ChangeMe")
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyMessageToolStripMenuItem1, Me.CopySelectionToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(154, 48)
        Me.SubTextTooltip.SetToolTip(Me.ContextMenuStrip2, "ChangeMe")
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
        'SubTextTooltip
        '
        Me.SubTextTooltip.AutomaticDelay = 250
        '
        'DateTimeBox
        '
        Me.DateTimeBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeBox.ForeColor = System.Drawing.Color.DimGray
        Me.DateTimeBox.Location = New System.Drawing.Point(3, 3)
        Me.DateTimeBox.Name = "DateTimeBox"
        Me.DateTimeBox.Size = New System.Drawing.Size(155, 31)
        Me.DateTimeBox.TabIndex = 6
        Me.DateTimeBox.Text = "12/12/2012 00:00:00"
        Me.DateTimeBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ScalableToMsg
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.DateTimeBox)
        Me.Controls.Add(Me.ActualMessage)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ScalableToMsg"
        Me.Size = New System.Drawing.Size(593, 227)
        Me.SubTextTooltip.SetToolTip(Me, "ChangeMe")
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ActualMessage As System.Windows.Forms.Label
    Friend WithEvents SubTextTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyMessageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopySelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimeBox As System.Windows.Forms.Label
End Class
