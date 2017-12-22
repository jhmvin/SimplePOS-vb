<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_register))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_regname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_reguser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_regpass = New System.Windows.Forms.TextBox()
        Me.txt_regpass2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_regsq = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_regSA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_regSA2 = New System.Windows.Forms.TextBox()
        Me.txt_productKey = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmd_register = New System.Windows.Forms.Button()
        Me.lbl_erName = New System.Windows.Forms.Label()
        Me.lbl_erUser = New System.Windows.Forms.Label()
        Me.lbl_erPass = New System.Windows.Forms.Label()
        Me.lbl_erQuestion = New System.Windows.Forms.Label()
        Me.lbl_erAnswer = New System.Windows.Forms.Label()
        Me.lbl_erSerial = New System.Windows.Forms.Label()
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txt_regname
        '
        Me.txt_regname.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_regname.Location = New System.Drawing.Point(184, 27)
        Me.txt_regname.Name = "txt_regname"
        Me.txt_regname.Size = New System.Drawing.Size(189, 22)
        Me.txt_regname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'txt_reguser
        '
        Me.txt_reguser.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reguser.Location = New System.Drawing.Point(184, 67)
        Me.txt_reguser.Name = "txt_reguser"
        Me.txt_reguser.Size = New System.Drawing.Size(189, 22)
        Me.txt_reguser.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Repeat Password"
        '
        'txt_regpass
        '
        Me.txt_regpass.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_regpass.Location = New System.Drawing.Point(184, 108)
        Me.txt_regpass.Name = "txt_regpass"
        Me.txt_regpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_regpass.Size = New System.Drawing.Size(189, 22)
        Me.txt_regpass.TabIndex = 8
        '
        'txt_regpass2
        '
        Me.txt_regpass2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_regpass2.Location = New System.Drawing.Point(184, 136)
        Me.txt_regpass2.Name = "txt_regpass2"
        Me.txt_regpass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_regpass2.Size = New System.Drawing.Size(189, 22)
        Me.txt_regpass2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Secret Question"
        '
        'txt_regsq
        '
        Me.txt_regsq.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_regsq.Location = New System.Drawing.Point(184, 175)
        Me.txt_regsq.MaxLength = 30
        Me.txt_regsq.Multiline = True
        Me.txt_regsq.Name = "txt_regsq"
        Me.txt_regsq.Size = New System.Drawing.Size(189, 50)
        Me.txt_regsq.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Secret Answer"
        '
        'txt_regSA
        '
        Me.txt_regSA.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_regSA.Location = New System.Drawing.Point(184, 240)
        Me.txt_regSA.Name = "txt_regSA"
        Me.txt_regSA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_regSA.Size = New System.Drawing.Size(189, 22)
        Me.txt_regSA.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(79, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Product Key"
        '
        'txt_regSA2
        '
        Me.txt_regSA2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_regSA2.Location = New System.Drawing.Point(184, 266)
        Me.txt_regSA2.Name = "txt_regSA2"
        Me.txt_regSA2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_regSA2.Size = New System.Drawing.Size(189, 22)
        Me.txt_regSA2.TabIndex = 15
        '
        'txt_productKey
        '
        Me.txt_productKey.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_productKey.Location = New System.Drawing.Point(185, 306)
        Me.txt_productKey.Name = "txt_productKey"
        Me.txt_productKey.Size = New System.Drawing.Size(189, 22)
        Me.txt_productKey.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Repeat Secret Answer"
        '
        'cmd_register
        '
        Me.cmd_register.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_register.Location = New System.Drawing.Point(115, 367)
        Me.cmd_register.Name = "cmd_register"
        Me.cmd_register.Size = New System.Drawing.Size(136, 33)
        Me.cmd_register.TabIndex = 18
        Me.cmd_register.Text = "Register Product"
        Me.cmd_register.UseVisualStyleBackColor = False
        '
        'lbl_erName
        '
        Me.lbl_erName.AutoSize = True
        Me.lbl_erName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_erName.ForeColor = System.Drawing.Color.Red
        Me.lbl_erName.Location = New System.Drawing.Point(181, 49)
        Me.lbl_erName.Name = "lbl_erName"
        Me.lbl_erName.Size = New System.Drawing.Size(92, 16)
        Me.lbl_erName.TabIndex = 19
        Me.lbl_erName.Text = "Message Here"
        '
        'lbl_erUser
        '
        Me.lbl_erUser.AutoSize = True
        Me.lbl_erUser.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_erUser.ForeColor = System.Drawing.Color.Red
        Me.lbl_erUser.Location = New System.Drawing.Point(182, 91)
        Me.lbl_erUser.Name = "lbl_erUser"
        Me.lbl_erUser.Size = New System.Drawing.Size(92, 16)
        Me.lbl_erUser.TabIndex = 20
        Me.lbl_erUser.Text = "Message Here"
        '
        'lbl_erPass
        '
        Me.lbl_erPass.AutoSize = True
        Me.lbl_erPass.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_erPass.ForeColor = System.Drawing.Color.Red
        Me.lbl_erPass.Location = New System.Drawing.Point(182, 158)
        Me.lbl_erPass.Name = "lbl_erPass"
        Me.lbl_erPass.Size = New System.Drawing.Size(92, 16)
        Me.lbl_erPass.TabIndex = 21
        Me.lbl_erPass.Text = "Message Here"
        '
        'lbl_erQuestion
        '
        Me.lbl_erQuestion.AutoSize = True
        Me.lbl_erQuestion.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_erQuestion.ForeColor = System.Drawing.Color.Red
        Me.lbl_erQuestion.Location = New System.Drawing.Point(182, 224)
        Me.lbl_erQuestion.Name = "lbl_erQuestion"
        Me.lbl_erQuestion.Size = New System.Drawing.Size(92, 16)
        Me.lbl_erQuestion.TabIndex = 22
        Me.lbl_erQuestion.Text = "Message Here"
        '
        'lbl_erAnswer
        '
        Me.lbl_erAnswer.AutoSize = True
        Me.lbl_erAnswer.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_erAnswer.ForeColor = System.Drawing.Color.Red
        Me.lbl_erAnswer.Location = New System.Drawing.Point(182, 289)
        Me.lbl_erAnswer.Name = "lbl_erAnswer"
        Me.lbl_erAnswer.Size = New System.Drawing.Size(92, 16)
        Me.lbl_erAnswer.TabIndex = 23
        Me.lbl_erAnswer.Text = "Message Here"
        '
        'lbl_erSerial
        '
        Me.lbl_erSerial.AutoSize = True
        Me.lbl_erSerial.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_erSerial.ForeColor = System.Drawing.Color.Red
        Me.lbl_erSerial.Location = New System.Drawing.Point(182, 330)
        Me.lbl_erSerial.Name = "lbl_erSerial"
        Me.lbl_erSerial.Size = New System.Drawing.Size(92, 16)
        Me.lbl_erSerial.TabIndex = 24
        Me.lbl_erSerial.Text = "Message Here"
        '
        'cmd_exit
        '
        Me.cmd_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_exit.Location = New System.Drawing.Point(257, 367)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(133, 33)
        Me.cmd_exit.TabIndex = 25
        Me.cmd_exit.Text = "E&xit"
        Me.cmd_exit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmd_exit)
        Me.GroupBox1.Controls.Add(Me.txt_regname)
        Me.GroupBox1.Controls.Add(Me.cmd_register)
        Me.GroupBox1.Controls.Add(Me.lbl_erSerial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_erAnswer)
        Me.GroupBox1.Controls.Add(Me.txt_reguser)
        Me.GroupBox1.Controls.Add(Me.lbl_erQuestion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_erPass)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_erUser)
        Me.GroupBox1.Controls.Add(Me.txt_regpass)
        Me.GroupBox1.Controls.Add(Me.lbl_erName)
        Me.GroupBox1.Controls.Add(Me.txt_regpass2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_productKey)
        Me.GroupBox1.Controls.Add(Me.txt_regsq)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_regSA2)
        Me.GroupBox1.Controls.Add(Me.txt_regSA)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(228, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 406)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fill Up"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 431)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'frm_register
        '
        Me.AcceptButton = Me.cmd_register
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_register"
        Me.Text = "Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_regname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_reguser As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_regpass As System.Windows.Forms.TextBox
    Friend WithEvents txt_regpass2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_regsq As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_regSA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_regSA2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_productKey As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_register As System.Windows.Forms.Button
    Friend WithEvents lbl_erName As System.Windows.Forms.Label
    Friend WithEvents lbl_erUser As System.Windows.Forms.Label
    Friend WithEvents lbl_erPass As System.Windows.Forms.Label
    Friend WithEvents lbl_erQuestion As System.Windows.Forms.Label
    Friend WithEvents lbl_erAnswer As System.Windows.Forms.Label
    Friend WithEvents lbl_erSerial As System.Windows.Forms.Label
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
