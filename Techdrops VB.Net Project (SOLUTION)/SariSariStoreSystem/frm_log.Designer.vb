<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_log
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_log))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.cmd_sign = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.tmr_log = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.lbl_SignInfo = New System.Windows.Forms.Label()
        Me.lbl_up = New System.Windows.Forms.Label()
        Me.lbl_down = New System.Windows.Forms.Label()
        Me.lbl_usermark = New System.Windows.Forms.Label()
        Me.lbl_passmark = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tip_log = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(252, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(330, 65)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(138, 22)
        Me.txt_user.TabIndex = 1
        '
        'txt_pass
        '
        Me.txt_pass.ForeColor = System.Drawing.Color.Black
        Me.txt_pass.Location = New System.Drawing.Point(330, 94)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_pass.Size = New System.Drawing.Size(138, 23)
        Me.txt_pass.TabIndex = 2
        '
        'cmd_sign
        '
        Me.cmd_sign.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_sign.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_sign.Location = New System.Drawing.Point(292, 143)
        Me.cmd_sign.Name = "cmd_sign"
        Me.cmd_sign.Size = New System.Drawing.Size(166, 33)
        Me.cmd_sign.TabIndex = 3
        Me.cmd_sign.Text = "Sign In"
        Me.cmd_sign.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(303, 217)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 16)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password ?"
        '
        'tmr_log
        '
        '
        'cmd_exit
        '
        Me.cmd_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_exit.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit.ForeColor = System.Drawing.Color.Black
        Me.cmd_exit.Location = New System.Drawing.Point(292, 182)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(166, 32)
        Me.cmd_exit.TabIndex = 4
        Me.cmd_exit.Text = "E&xit"
        Me.cmd_exit.UseVisualStyleBackColor = False
        '
        'lbl_SignInfo
        '
        Me.lbl_SignInfo.AutoSize = True
        Me.lbl_SignInfo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SignInfo.ForeColor = System.Drawing.Color.Red
        Me.lbl_SignInfo.Location = New System.Drawing.Point(267, 125)
        Me.lbl_SignInfo.Name = "lbl_SignInfo"
        Me.lbl_SignInfo.Size = New System.Drawing.Size(104, 16)
        Me.lbl_SignInfo.TabIndex = 7
        Me.lbl_SignInfo.Text = "Invalid User"
        '
        'lbl_up
        '
        Me.lbl_up.AutoSize = True
        Me.lbl_up.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_up.Location = New System.Drawing.Point(465, 60)
        Me.lbl_up.Name = "lbl_up"
        Me.lbl_up.Size = New System.Drawing.Size(25, 28)
        Me.lbl_up.TabIndex = 8
        Me.lbl_up.Text = "O"
        '
        'lbl_down
        '
        Me.lbl_down.AutoSize = True
        Me.lbl_down.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_down.Location = New System.Drawing.Point(465, 92)
        Me.lbl_down.Name = "lbl_down"
        Me.lbl_down.Size = New System.Drawing.Size(25, 28)
        Me.lbl_down.TabIndex = 9
        Me.lbl_down.Text = "O"
        '
        'lbl_usermark
        '
        Me.lbl_usermark.AutoSize = True
        Me.lbl_usermark.BackColor = System.Drawing.Color.White
        Me.lbl_usermark.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usermark.ForeColor = System.Drawing.Color.Silver
        Me.lbl_usermark.Location = New System.Drawing.Point(333, 68)
        Me.lbl_usermark.Name = "lbl_usermark"
        Me.lbl_usermark.Size = New System.Drawing.Size(72, 16)
        Me.lbl_usermark.TabIndex = 10
        Me.lbl_usermark.Text = "Username"
        '
        'lbl_passmark
        '
        Me.lbl_passmark.AutoSize = True
        Me.lbl_passmark.BackColor = System.Drawing.Color.White
        Me.lbl_passmark.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_passmark.ForeColor = System.Drawing.Color.Silver
        Me.lbl_passmark.Location = New System.Drawing.Point(333, 97)
        Me.lbl_passmark.Name = "lbl_passmark"
        Me.lbl_passmark.Size = New System.Drawing.Size(72, 16)
        Me.lbl_passmark.TabIndex = 2
        Me.lbl_passmark.Text = "Password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(510, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 310)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'frm_log
        '
        Me.AcceptButton = Me.cmd_sign
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(547, 306)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_passmark)
        Me.Controls.Add(Me.lbl_usermark)
        Me.Controls.Add(Me.lbl_down)
        Me.Controls.Add(Me.lbl_up)
        Me.Controls.Add(Me.lbl_SignInfo)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cmd_sign)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_log"
        Me.Text = "Sign - In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents cmd_sign As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents tmr_log As System.Windows.Forms.Timer
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents lbl_SignInfo As System.Windows.Forms.Label
    Friend WithEvents lbl_up As System.Windows.Forms.Label
    Friend WithEvents lbl_down As System.Windows.Forms.Label
    Friend WithEvents lbl_usermark As System.Windows.Forms.Label
    Friend WithEvents lbl_passmark As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tip_log As System.Windows.Forms.ToolTip
End Class
