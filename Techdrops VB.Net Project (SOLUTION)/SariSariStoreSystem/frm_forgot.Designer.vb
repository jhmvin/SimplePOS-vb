<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_forgot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_forgot))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_question = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_answer = New System.Windows.Forms.TextBox()
        Me.cmd_recover = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.txt_newpass1 = New System.Windows.Forms.TextBox()
        Me.txt_newpass2 = New System.Windows.Forms.TextBox()
        Me.grp_ver = New System.Windows.Forms.GroupBox()
        Me.lbl_secret = New System.Windows.Forms.Label()
        Me.grp_setPass = New System.Windows.Forms.GroupBox()
        Me.cmd_back = New System.Windows.Forms.Button()
        Me.lbl_erNewPass = New System.Windows.Forms.Label()
        Me.cmd_continue = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tip_secure = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp_ver.SuspendLayout()
        Me.grp_setPass.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Secret Question "
        '
        'lbl_question
        '
        Me.lbl_question.AutoSize = True
        Me.lbl_question.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_question.Location = New System.Drawing.Point(31, 41)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Size = New System.Drawing.Size(136, 16)
        Me.lbl_question.TabIndex = 1
        Me.lbl_question.Text = "Secret Question "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Secret Answer "
        '
        'txt_answer
        '
        Me.txt_answer.Location = New System.Drawing.Point(20, 86)
        Me.txt_answer.Name = "txt_answer"
        Me.txt_answer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_answer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_answer.Size = New System.Drawing.Size(282, 22)
        Me.txt_answer.TabIndex = 3
        '
        'cmd_recover
        '
        Me.cmd_recover.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_recover.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_recover.Location = New System.Drawing.Point(18, 127)
        Me.cmd_recover.Name = "cmd_recover"
        Me.cmd_recover.Size = New System.Drawing.Size(138, 30)
        Me.cmd_recover.TabIndex = 4
        Me.cmd_recover.Text = "&Recover Account"
        Me.cmd_recover.UseVisualStyleBackColor = False
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_cancel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_cancel.ForeColor = System.Drawing.Color.Black
        Me.cmd_cancel.Location = New System.Drawing.Point(174, 127)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(138, 30)
        Me.cmd_cancel.TabIndex = 5
        Me.cmd_cancel.Text = "&Cancel"
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'txt_newpass1
        '
        Me.txt_newpass1.Location = New System.Drawing.Point(190, 26)
        Me.txt_newpass1.Name = "txt_newpass1"
        Me.txt_newpass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_newpass1.Size = New System.Drawing.Size(133, 22)
        Me.txt_newpass1.TabIndex = 6
        '
        'txt_newpass2
        '
        Me.txt_newpass2.Location = New System.Drawing.Point(190, 50)
        Me.txt_newpass2.Name = "txt_newpass2"
        Me.txt_newpass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_newpass2.Size = New System.Drawing.Size(133, 22)
        Me.txt_newpass2.TabIndex = 7
        '
        'grp_ver
        '
        Me.grp_ver.Controls.Add(Me.lbl_secret)
        Me.grp_ver.Controls.Add(Me.cmd_cancel)
        Me.grp_ver.Controls.Add(Me.cmd_recover)
        Me.grp_ver.Controls.Add(Me.Label1)
        Me.grp_ver.Controls.Add(Me.lbl_question)
        Me.grp_ver.Controls.Add(Me.Label3)
        Me.grp_ver.Controls.Add(Me.txt_answer)
        Me.grp_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp_ver.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_ver.Location = New System.Drawing.Point(211, 11)
        Me.grp_ver.Name = "grp_ver"
        Me.grp_ver.Size = New System.Drawing.Size(337, 177)
        Me.grp_ver.TabIndex = 8
        Me.grp_ver.TabStop = False
        Me.grp_ver.Text = "Verification"
        '
        'lbl_secret
        '
        Me.lbl_secret.AutoSize = True
        Me.lbl_secret.ForeColor = System.Drawing.Color.Red
        Me.lbl_secret.Location = New System.Drawing.Point(31, 111)
        Me.lbl_secret.Name = "lbl_secret"
        Me.lbl_secret.Size = New System.Drawing.Size(104, 16)
        Me.lbl_secret.TabIndex = 12
        Me.lbl_secret.Text = "Message Here"
        '
        'grp_setPass
        '
        Me.grp_setPass.Controls.Add(Me.cmd_back)
        Me.grp_setPass.Controls.Add(Me.lbl_erNewPass)
        Me.grp_setPass.Controls.Add(Me.cmd_continue)
        Me.grp_setPass.Controls.Add(Me.Label4)
        Me.grp_setPass.Controls.Add(Me.Label2)
        Me.grp_setPass.Controls.Add(Me.txt_newpass2)
        Me.grp_setPass.Controls.Add(Me.txt_newpass1)
        Me.grp_setPass.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_setPass.Location = New System.Drawing.Point(213, 194)
        Me.grp_setPass.Name = "grp_setPass"
        Me.grp_setPass.Size = New System.Drawing.Size(335, 141)
        Me.grp_setPass.TabIndex = 9
        Me.grp_setPass.TabStop = False
        Me.grp_setPass.Text = "Set New Password"
        '
        'cmd_back
        '
        Me.cmd_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_back.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_back.ForeColor = System.Drawing.Color.Black
        Me.cmd_back.Location = New System.Drawing.Point(172, 94)
        Me.cmd_back.Name = "cmd_back"
        Me.cmd_back.Size = New System.Drawing.Size(138, 28)
        Me.cmd_back.TabIndex = 13
        Me.cmd_back.Text = "C&ancel"
        Me.cmd_back.UseVisualStyleBackColor = False
        '
        'lbl_erNewPass
        '
        Me.lbl_erNewPass.AutoSize = True
        Me.lbl_erNewPass.ForeColor = System.Drawing.Color.Red
        Me.lbl_erNewPass.Location = New System.Drawing.Point(23, 76)
        Me.lbl_erNewPass.Name = "lbl_erNewPass"
        Me.lbl_erNewPass.Size = New System.Drawing.Size(104, 16)
        Me.lbl_erNewPass.TabIndex = 11
        Me.lbl_erNewPass.Text = "Message Here"
        '
        'cmd_continue
        '
        Me.cmd_continue.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_continue.Location = New System.Drawing.Point(21, 94)
        Me.cmd_continue.Name = "cmd_continue"
        Me.cmd_continue.Size = New System.Drawing.Size(133, 28)
        Me.cmd_continue.TabIndex = 10
        Me.cmd_continue.Text = "Continue"
        Me.cmd_continue.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Confirm New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "New Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 348)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'frm_forgot
        '
        Me.AcceptButton = Me.cmd_continue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(561, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grp_ver)
        Me.Controls.Add(Me.grp_setPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_forgot"
        Me.Text = "Security Settings"
        Me.grp_ver.ResumeLayout(False)
        Me.grp_ver.PerformLayout()
        Me.grp_setPass.ResumeLayout(False)
        Me.grp_setPass.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_question As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_answer As System.Windows.Forms.TextBox
    Friend WithEvents cmd_recover As System.Windows.Forms.Button
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_newpass1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_newpass2 As System.Windows.Forms.TextBox
    Friend WithEvents grp_ver As System.Windows.Forms.GroupBox
    Friend WithEvents grp_setPass As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_continue As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_erNewPass As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_secret As System.Windows.Forms.Label
    Friend WithEvents cmd_back As System.Windows.Forms.Button
    Friend WithEvents tip_secure As System.Windows.Forms.ToolTip
End Class
