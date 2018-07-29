<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UninstallDialog
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(225,Byte),Integer), CType(CType(225,Byte),Integer))
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(200,Byte),Integer), CType(CType(200,Byte),Integer))
        Me.OK_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(200,Byte),Integer), CType(CType(200,Byte),Integer))
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.OK_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10,Byte),Integer), CType(CType(10,Byte),Integer), CType(CType(10,Byte),Integer))
        Me.OK_Button.Location = New System.Drawing.Point(315, 343)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(150, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Uninstall Messenger"
        Me.OK_Button.UseVisualStyleBackColor = false
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(225,Byte),Integer), CType(CType(225,Byte),Integer))
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(200,Byte),Integer), CType(CType(200,Byte),Integer))
        Me.Cancel_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(200,Byte),Integer), CType(CType(200,Byte),Integer))
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Cancel_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10,Byte),Integer), CType(CType(10,Byte),Integer), CType(CType(10,Byte),Integer))
        Me.Cancel_Button.Location = New System.Drawing.Point(140, 343)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(150, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Continue Anyway"
        Me.Cancel_Button.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Messenger is no longer in use."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(547, 54)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Messenger is no longer in use. Please install and use teams. If you want, you can"& _ 
    " easily uninstall messenger from here."
        '
        'UninstallDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(85,Byte),Integer), CType(CType(88,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.BackgroundImage = Global.LoginModule.My.Resources.Resources.TeamsMigration
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(587, 390)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "UninstallDialog"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UninstallDialog"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
