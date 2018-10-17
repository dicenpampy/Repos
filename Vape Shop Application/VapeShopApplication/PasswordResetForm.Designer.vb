<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordResetForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordResetForm))
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.LabelMessage = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.PanelMessage = New System.Windows.Forms.Panel()
        Me.TextUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ExitApp = New System.Windows.Forms.Label()
        Me.MinimizeForm = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PanelProgress = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LabelProgress = New System.Windows.Forms.Label()
        Me.PanelMessage.SuspendLayout()
        Me.PanelProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ButtonCancel.FlatAppearance.BorderSize = 0
        Me.ButtonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ButtonCancel.ForeColor = System.Drawing.Color.LightGray
        Me.ButtonCancel.Location = New System.Drawing.Point(310, 346)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(100, 23)
        Me.ButtonCancel.TabIndex = 57
        Me.ButtonCancel.TabStop = False
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonBack
        '
        Me.ButtonBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonBack.FlatAppearance.BorderSize = 0
        Me.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ButtonBack.ForeColor = System.Drawing.Color.LightGray
        Me.ButtonBack.Location = New System.Drawing.Point(98, 346)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(100, 23)
        Me.ButtonBack.TabIndex = 55
        Me.ButtonBack.TabStop = False
        Me.ButtonBack.Text = "< BACK"
        Me.ButtonBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'LabelMessage
        '
        Me.LabelMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMessage.ForeColor = System.Drawing.Color.LightGray
        Me.LabelMessage.Location = New System.Drawing.Point(2, 2)
        Me.LabelMessage.Name = "LabelMessage"
        Me.LabelMessage.Size = New System.Drawing.Size(328, 46)
        Me.LabelMessage.TabIndex = 11
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(2, 46)
        Me.Panel10.TabIndex = 10
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(330, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(2, 46)
        Me.Panel9.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(332, 2)
        Me.Panel8.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 48)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(332, 2)
        Me.Panel7.TabIndex = 7
        '
        'ButtonNext
        '
        Me.ButtonNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ButtonNext.FlatAppearance.BorderSize = 0
        Me.ButtonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNext.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ButtonNext.ForeColor = System.Drawing.Color.LightGray
        Me.ButtonNext.Location = New System.Drawing.Point(204, 346)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(100, 23)
        Me.ButtonNext.TabIndex = 56
        Me.ButtonNext.TabStop = False
        Me.ButtonNext.Text = "NEXT >"
        Me.ButtonNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNext.UseVisualStyleBackColor = False
        '
        'PanelMessage
        '
        Me.PanelMessage.Controls.Add(Me.LabelMessage)
        Me.PanelMessage.Controls.Add(Me.Panel10)
        Me.PanelMessage.Controls.Add(Me.Panel9)
        Me.PanelMessage.Controls.Add(Me.Panel8)
        Me.PanelMessage.Controls.Add(Me.Panel7)
        Me.PanelMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMessage.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelMessage.Location = New System.Drawing.Point(42, 221)
        Me.PanelMessage.Name = "PanelMessage"
        Me.PanelMessage.Size = New System.Drawing.Size(332, 50)
        Me.PanelMessage.TabIndex = 54
        Me.PanelMessage.Visible = False
        '
        'TextUser
        '
        Me.TextUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TextUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUser.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TextUser.ForeColor = System.Drawing.Color.LightGray
        Me.TextUser.Location = New System.Drawing.Point(42, 131)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.Size = New System.Drawing.Size(332, 22)
        Me.TextUser.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(39, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Account name"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(39, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(345, 50)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Please enter your username." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A verification code will be sent to your email addre" &
    "ss."
        '
        'ExitApp
        '
        Me.ExitApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitApp.AutoSize = True
        Me.ExitApp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitApp.ForeColor = System.Drawing.Color.LightGray
        Me.ExitApp.Location = New System.Drawing.Point(407, 5)
        Me.ExitApp.Name = "ExitApp"
        Me.ExitApp.Size = New System.Drawing.Size(12, 13)
        Me.ExitApp.TabIndex = 46
        Me.ExitApp.Text = "x"
        '
        'MinimizeForm
        '
        Me.MinimizeForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeForm.AutoSize = True
        Me.MinimizeForm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeForm.ForeColor = System.Drawing.Color.LightGray
        Me.MinimizeForm.Location = New System.Drawing.Point(389, 3)
        Me.MinimizeForm.Name = "MinimizeForm"
        Me.MinimizeForm.Size = New System.Drawing.Size(12, 13)
        Me.MinimizeForm.TabIndex = 45
        Me.MinimizeForm.Text = "_"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(421, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 379)
        Me.Panel4.TabIndex = 44
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 379)
        Me.Panel3.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 380)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(422, 1)
        Me.Panel2.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 1)
        Me.Panel1.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Reset your password"
        '
        'BackgroundWorker1
        '
        '
        'PanelProgress
        '
        Me.PanelProgress.Controls.Add(Me.ProgressBar1)
        Me.PanelProgress.Controls.Add(Me.LabelProgress)
        Me.PanelProgress.Location = New System.Drawing.Point(42, 277)
        Me.PanelProgress.Name = "PanelProgress"
        Me.PanelProgress.Size = New System.Drawing.Size(330, 41)
        Me.PanelProgress.TabIndex = 58
        Me.PanelProgress.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 31)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(330, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 50
        '
        'LabelProgress
        '
        Me.LabelProgress.AutoSize = True
        Me.LabelProgress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProgress.ForeColor = System.Drawing.Color.LightGray
        Me.LabelProgress.Location = New System.Drawing.Point(2, 0)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(191, 13)
        Me.LabelProgress.TabIndex = 49
        Me.LabelProgress.Text = "Sending verification code to email..."
        '
        'PasswordResetForm
        '
        Me.AcceptButton = Me.ButtonNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CancelButton = Me.ButtonBack
        Me.ClientSize = New System.Drawing.Size(422, 381)
        Me.Controls.Add(Me.PanelProgress)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.PanelMessage)
        Me.Controls.Add(Me.TextUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ExitApp)
        Me.Controls.Add(Me.MinimizeForm)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PasswordResetForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recover your password"
        Me.PanelMessage.ResumeLayout(False)
        Me.PanelProgress.ResumeLayout(False)
        Me.PanelProgress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents LabelMessage As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ButtonNext As Button
    Friend WithEvents PanelMessage As Panel
    Friend WithEvents TextUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ExitApp As Label
    Friend WithEvents MinimizeForm As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelProgress As Panel
    Friend WithEvents LabelProgress As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
