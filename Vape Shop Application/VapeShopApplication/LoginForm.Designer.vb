<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextUser = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckPassRemem = New System.Windows.Forms.CheckBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonCreateAcc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelMessage = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.MinimizeForm = New System.Windows.Forms.Label()
        Me.ExitApp = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMessage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(72, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(115, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IQOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(28, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Account name"
        '
        'TextUser
        '
        Me.TextUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TextUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextUser.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TextUser.ForeColor = System.Drawing.Color.LightGray
        Me.TextUser.Location = New System.Drawing.Point(120, 91)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.Size = New System.Drawing.Size(332, 22)
        Me.TextUser.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 1)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 329)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 1)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 328)
        Me.Panel3.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(479, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 328)
        Me.Panel4.TabIndex = 8
        '
        'TextPass
        '
        Me.TextPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TextPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextPass.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TextPass.ForeColor = System.Drawing.Color.LightGray
        Me.TextPass.Location = New System.Drawing.Point(120, 121)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextPass.Size = New System.Drawing.Size(332, 22)
        Me.TextPass.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(52, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password"
        '
        'CheckPassRemem
        '
        Me.CheckPassRemem.AutoSize = True
        Me.CheckPassRemem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckPassRemem.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.CheckPassRemem.ForeColor = System.Drawing.Color.DarkGray
        Me.CheckPassRemem.Location = New System.Drawing.Point(120, 154)
        Me.CheckPassRemem.Name = "CheckPassRemem"
        Me.CheckPassRemem.Size = New System.Drawing.Size(147, 17)
        Me.CheckPassRemem.TabIndex = 11
        Me.CheckPassRemem.Text = "Remember my password"
        Me.CheckPassRemem.UseVisualStyleBackColor = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ButtonLogin.FlatAppearance.BorderSize = 0
        Me.ButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ButtonLogin.ForeColor = System.Drawing.Color.LightGray
        Me.ButtonLogin.Location = New System.Drawing.Point(120, 179)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(161, 23)
        Me.ButtonLogin.TabIndex = 12
        Me.ButtonLogin.Text = "LOGIN"
        Me.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.FlatAppearance.BorderSize = 0
        Me.ButtonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ButtonCancel.ForeColor = System.Drawing.Color.LightGray
        Me.ButtonCancel.Location = New System.Drawing.Point(291, 179)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(161, 23)
        Me.ButtonCancel.TabIndex = 13
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(28, 217)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(424, 1)
        Me.Panel5.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(77, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Need help with sign in?"
        '
        'ButtonHelp
        '
        Me.ButtonHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ButtonHelp.FlatAppearance.BorderSize = 0
        Me.ButtonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHelp.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ButtonHelp.ForeColor = System.Drawing.Color.LightGray
        Me.ButtonHelp.Location = New System.Drawing.Point(212, 224)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(240, 23)
        Me.ButtonHelp.TabIndex = 16
        Me.ButtonHelp.Text = "I CAN'T SIGN IN..."
        Me.ButtonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonHelp.UseVisualStyleBackColor = False
        '
        'ButtonCreateAcc
        '
        Me.ButtonCreateAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ButtonCreateAcc.FlatAppearance.BorderSize = 0
        Me.ButtonCreateAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ButtonCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCreateAcc.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ButtonCreateAcc.ForeColor = System.Drawing.Color.LightGray
        Me.ButtonCreateAcc.Location = New System.Drawing.Point(212, 253)
        Me.ButtonCreateAcc.Name = "ButtonCreateAcc"
        Me.ButtonCreateAcc.Size = New System.Drawing.Size(240, 23)
        Me.ButtonCreateAcc.TabIndex = 18
        Me.ButtonCreateAcc.Text = "CREATE NEW ACCOUNT..."
        Me.ButtonCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCreateAcc.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(77, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Don't have an account?"
        '
        'PanelMessage
        '
        Me.PanelMessage.Controls.Add(Me.Label7)
        Me.PanelMessage.Controls.Add(Me.Panel10)
        Me.PanelMessage.Controls.Add(Me.Panel9)
        Me.PanelMessage.Controls.Add(Me.Panel8)
        Me.PanelMessage.Controls.Add(Me.Panel7)
        Me.PanelMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMessage.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelMessage.Location = New System.Drawing.Point(28, 283)
        Me.PanelMessage.Name = "PanelMessage"
        Me.PanelMessage.Size = New System.Drawing.Size(424, 36)
        Me.PanelMessage.TabIndex = 19
        Me.PanelMessage.Visible = False
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(2, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(420, 32)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "You have entered your password or account name incorrectly. Please check your pas" &
    "sword and account name and try again."
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(2, 32)
        Me.Panel10.TabIndex = 10
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(422, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(2, 32)
        Me.Panel9.TabIndex = 9
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(424, 2)
        Me.Panel8.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 34)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(424, 2)
        Me.Panel7.TabIndex = 7
        '
        'MinimizeForm
        '
        Me.MinimizeForm.AutoSize = True
        Me.MinimizeForm.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeForm.ForeColor = System.Drawing.Color.LightGray
        Me.MinimizeForm.Location = New System.Drawing.Point(447, 2)
        Me.MinimizeForm.Name = "MinimizeForm"
        Me.MinimizeForm.Size = New System.Drawing.Size(12, 13)
        Me.MinimizeForm.TabIndex = 20
        Me.MinimizeForm.Text = "_"
        '
        'ExitApp
        '
        Me.ExitApp.AutoSize = True
        Me.ExitApp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitApp.ForeColor = System.Drawing.Color.LightGray
        Me.ExitApp.Location = New System.Drawing.Point(465, 4)
        Me.ExitApp.Name = "ExitApp"
        Me.ExitApp.Size = New System.Drawing.Size(12, 13)
        Me.ExitApp.TabIndex = 21
        Me.ExitApp.Text = "x"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.ButtonLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(480, 330)
        Me.Controls.Add(Me.ExitApp)
        Me.Controls.Add(Me.MinimizeForm)
        Me.Controls.Add(Me.PanelMessage)
        Me.Controls.Add(Me.ButtonCreateAcc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.CheckPassRemem)
        Me.Controls.Add(Me.TextPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 330)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMessage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextUser As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckPassRemem As CheckBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonHelp As Button
    Friend WithEvents ButtonCreateAcc As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelMessage As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents MinimizeForm As Label
    Friend WithEvents ExitApp As Label
End Class
