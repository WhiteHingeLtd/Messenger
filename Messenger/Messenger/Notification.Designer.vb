<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notification))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.NotificationTitle = New System.Windows.Forms.Label()
        Me.EntryCoord = New System.Windows.Forms.Timer(Me.components)
        Me.IconBox = New System.Windows.Forms.PictureBox()
        Me.DateBox = New System.Windows.Forms.Label()
        Me.Autokill = New System.Windows.Forms.Timer(Me.components)
        Me.Body2 = New System.Windows.Forms.Label()
        Me.ProperBody = New System.Windows.Forms.RichTextBox()
        CType(Me.IconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Black
        Me.CloseButton.Location = New System.Drawing.Point(538, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(35, 31)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'NotificationTitle
        '
        Me.NotificationTitle.Font = New System.Drawing.Font("Segoe UI Semilight", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotificationTitle.ForeColor = System.Drawing.Color.Black
        Me.NotificationTitle.Location = New System.Drawing.Point(5, 1)
        Me.NotificationTitle.Name = "NotificationTitle"
        Me.NotificationTitle.Size = New System.Drawing.Size(520, 34)
        Me.NotificationTitle.TabIndex = 1
        Me.NotificationTitle.Text = "Notification Title Box"
        Me.NotificationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NotificationTitle.UseMnemonic = False
        '
        'EntryCoord
        '
        Me.EntryCoord.Enabled = True
        Me.EntryCoord.Interval = 10
        '
        'IconBox
        '
        Me.IconBox.Image = Global.LoginModule.My.Resources.Resources.metro_mail
        Me.IconBox.Location = New System.Drawing.Point(6, 37)
        Me.IconBox.Name = "IconBox"
        Me.IconBox.Size = New System.Drawing.Size(114, 109)
        Me.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconBox.TabIndex = 4
        Me.IconBox.TabStop = False
        Me.IconBox.Visible = False
        '
        'DateBox
        '
        Me.DateBox.AutoSize = True
        Me.DateBox.ForeColor = System.Drawing.Color.Black
        Me.DateBox.Location = New System.Drawing.Point(2, 152)
        Me.DateBox.Name = "DateBox"
        Me.DateBox.Size = New System.Drawing.Size(39, 13)
        Me.DateBox.TabIndex = 5
        Me.DateBox.Text = "Label1"
        '
        'Autokill
        '
        Me.Autokill.Interval = 8000
        '
        'Body2
        '
        Me.Body2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Body2.ForeColor = System.Drawing.Color.White
        Me.Body2.Location = New System.Drawing.Point(130, 55)
        Me.Body2.Name = "Body2"
        Me.Body2.Size = New System.Drawing.Size(251, 107)
        Me.Body2.TabIndex = 3
        Me.Body2.Text = resources.GetString("Body2.Text")
        Me.Body2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Body2.UseMnemonic = False
        Me.Body2.Visible = False
        '
        'ProperBody
        '
        Me.ProperBody.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ProperBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProperBody.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProperBody.ForeColor = System.Drawing.Color.Black
        Me.ProperBody.Location = New System.Drawing.Point(126, 35)
        Me.ProperBody.Name = "ProperBody"
        Me.ProperBody.ReadOnly = True
        Me.ProperBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.ProperBody.Size = New System.Drawing.Size(442, 133)
        Me.ProperBody.TabIndex = 6
        Me.ProperBody.Text = ""
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(574, 171)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ProperBody)
        Me.Controls.Add(Me.DateBox)
        Me.Controls.Add(Me.IconBox)
        Me.Controls.Add(Me.Body2)
        Me.Controls.Add(Me.NotificationTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Notification"
        Me.Text = "Notification"
        Me.TopMost = True
        CType(Me.IconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents NotificationTitle As System.Windows.Forms.Label
    Friend WithEvents EntryCoord As System.Windows.Forms.Timer
    Friend WithEvents IconBox As System.Windows.Forms.PictureBox
    Friend WithEvents DateBox As System.Windows.Forms.Label
    Friend WithEvents Autokill As System.Windows.Forms.Timer
    Friend WithEvents Body2 As System.Windows.Forms.Label
    Friend WithEvents ProperBody As System.Windows.Forms.RichTextBox
End Class
