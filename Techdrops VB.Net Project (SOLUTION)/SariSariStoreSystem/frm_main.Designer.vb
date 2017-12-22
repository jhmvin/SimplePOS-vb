<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.cmd_sell = New System.Windows.Forms.Button()
        Me.cmd_inventory = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.tmr_time = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_signout = New System.Windows.Forms.Button()
        Me.tmr_hotpress = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_sales = New System.Windows.Forms.Button()
        Me.cmd_change = New System.Windows.Forms.Button()
        Me.cmd_about = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tip_main = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_sell
        '
        Me.cmd_sell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_sell.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_sell.Location = New System.Drawing.Point(262, 43)
        Me.cmd_sell.Name = "cmd_sell"
        Me.cmd_sell.Size = New System.Drawing.Size(250, 50)
        Me.cmd_sell.TabIndex = 1
        Me.cmd_sell.Text = "Sell Items"
        Me.cmd_sell.UseVisualStyleBackColor = False
        '
        'cmd_inventory
        '
        Me.cmd_inventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_inventory.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_inventory.Location = New System.Drawing.Point(262, 99)
        Me.cmd_inventory.Name = "cmd_inventory"
        Me.cmd_inventory.Size = New System.Drawing.Size(250, 50)
        Me.cmd_inventory.TabIndex = 2
        Me.cmd_inventory.Text = "Inventory"
        Me.cmd_inventory.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(353, 434)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(374, 23)
        Me.lbl_date.TabIndex = 3
        Me.lbl_date.Text = "Thursday, September 29, 2015"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(256, 9)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(110, 31)
        Me.lbl_time.TabIndex = 4
        Me.lbl_time.Text = "Label1"
        '
        'tmr_time
        '
        Me.tmr_time.Enabled = True
        Me.tmr_time.Interval = 30
        '
        'cmd_signout
        '
        Me.cmd_signout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_signout.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_signout.ForeColor = System.Drawing.Color.Black
        Me.cmd_signout.Location = New System.Drawing.Point(262, 323)
        Me.cmd_signout.Name = "cmd_signout"
        Me.cmd_signout.Size = New System.Drawing.Size(250, 50)
        Me.cmd_signout.TabIndex = 5
        Me.cmd_signout.Text = "Sign Out"
        Me.cmd_signout.UseVisualStyleBackColor = False
        '
        'tmr_hotpress
        '
        '
        'cmd_sales
        '
        Me.cmd_sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_sales.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_sales.Location = New System.Drawing.Point(262, 155)
        Me.cmd_sales.Name = "cmd_sales"
        Me.cmd_sales.Size = New System.Drawing.Size(250, 50)
        Me.cmd_sales.TabIndex = 6
        Me.cmd_sales.Text = "Sales Report"
        Me.cmd_sales.UseVisualStyleBackColor = False
        '
        'cmd_change
        '
        Me.cmd_change.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_change.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_change.Location = New System.Drawing.Point(262, 211)
        Me.cmd_change.Name = "cmd_change"
        Me.cmd_change.Size = New System.Drawing.Size(250, 50)
        Me.cmd_change.TabIndex = 7
        Me.cmd_change.Text = "Change Password"
        Me.cmd_change.UseVisualStyleBackColor = False
        '
        'cmd_about
        '
        Me.cmd_about.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_about.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_about.Location = New System.Drawing.Point(262, 267)
        Me.cmd_about.Name = "cmd_about"
        Me.cmd_about.Size = New System.Drawing.Size(250, 50)
        Me.cmd_about.TabIndex = 8
        Me.cmd_about.Text = "About Us"
        Me.cmd_about.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 404)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(533, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_about)
        Me.Controls.Add(Me.cmd_change)
        Me.Controls.Add(Me.cmd_sales)
        Me.Controls.Add(Me.cmd_signout)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.cmd_inventory)
        Me.Controls.Add(Me.cmd_sell)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_main"
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_sell As System.Windows.Forms.Button
    Friend WithEvents cmd_inventory As System.Windows.Forms.Button
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents tmr_time As System.Windows.Forms.Timer
    Friend WithEvents cmd_signout As System.Windows.Forms.Button
    Friend WithEvents tmr_hotpress As System.Windows.Forms.Timer
    Friend WithEvents cmd_sales As System.Windows.Forms.Button
    Friend WithEvents cmd_change As System.Windows.Forms.Button
    Friend WithEvents cmd_about As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tip_main As System.Windows.Forms.ToolTip
End Class
