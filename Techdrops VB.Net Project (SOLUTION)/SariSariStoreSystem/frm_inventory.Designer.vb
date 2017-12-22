<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_inventory))
        Me.grp_category = New System.Windows.Forms.GroupBox()
        Me.cmd_all = New System.Windows.Forms.Button()
        Me.cmd_others = New System.Windows.Forms.Button()
        Me.cmd_con = New System.Windows.Forms.Button()
        Me.cmd_bev = New System.Windows.Forms.Button()
        Me.cmd_food = New System.Windows.Forms.Button()
        Me.lst_disprod = New System.Windows.Forms.ListBox()
        Me.grp_info = New System.Windows.Forms.GroupBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.cmd_addStocks = New System.Windows.Forms.Button()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_addItem = New System.Windows.Forms.Button()
        Me.cbo_category = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_newItem = New System.Windows.Forms.TextBox()
        Me.grp_options = New System.Windows.Forms.GroupBox()
        Me.cmd_back = New System.Windows.Forms.Button()
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tip_inventory = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp_category.SuspendLayout()
        Me.grp_info.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp_options.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_category
        '
        Me.grp_category.Controls.Add(Me.cmd_all)
        Me.grp_category.Controls.Add(Me.cmd_others)
        Me.grp_category.Controls.Add(Me.cmd_con)
        Me.grp_category.Controls.Add(Me.cmd_bev)
        Me.grp_category.Controls.Add(Me.cmd_food)
        Me.grp_category.Controls.Add(Me.lst_disprod)
        Me.grp_category.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_category.Location = New System.Drawing.Point(225, 12)
        Me.grp_category.Name = "grp_category"
        Me.grp_category.Size = New System.Drawing.Size(368, 204)
        Me.grp_category.TabIndex = 1
        Me.grp_category.TabStop = False
        Me.grp_category.Text = "Category"
        '
        'cmd_all
        '
        Me.cmd_all.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_all.Location = New System.Drawing.Point(12, 24)
        Me.cmd_all.Name = "cmd_all"
        Me.cmd_all.Size = New System.Drawing.Size(118, 28)
        Me.cmd_all.TabIndex = 4
        Me.cmd_all.Text = "All"
        Me.cmd_all.UseVisualStyleBackColor = False
        '
        'cmd_others
        '
        Me.cmd_others.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_others.Location = New System.Drawing.Point(12, 159)
        Me.cmd_others.Name = "cmd_others"
        Me.cmd_others.Size = New System.Drawing.Size(118, 28)
        Me.cmd_others.TabIndex = 3
        Me.cmd_others.Text = "Others"
        Me.cmd_others.UseVisualStyleBackColor = False
        '
        'cmd_con
        '
        Me.cmd_con.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_con.Location = New System.Drawing.Point(12, 125)
        Me.cmd_con.Name = "cmd_con"
        Me.cmd_con.Size = New System.Drawing.Size(118, 28)
        Me.cmd_con.TabIndex = 2
        Me.cmd_con.Text = "Condements"
        Me.cmd_con.UseVisualStyleBackColor = False
        '
        'cmd_bev
        '
        Me.cmd_bev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_bev.Location = New System.Drawing.Point(12, 91)
        Me.cmd_bev.Name = "cmd_bev"
        Me.cmd_bev.Size = New System.Drawing.Size(118, 28)
        Me.cmd_bev.TabIndex = 1
        Me.cmd_bev.Text = "Beverages"
        Me.cmd_bev.UseVisualStyleBackColor = False
        '
        'cmd_food
        '
        Me.cmd_food.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_food.Location = New System.Drawing.Point(12, 58)
        Me.cmd_food.Name = "cmd_food"
        Me.cmd_food.Size = New System.Drawing.Size(118, 28)
        Me.cmd_food.TabIndex = 0
        Me.cmd_food.Text = "Food"
        Me.cmd_food.UseVisualStyleBackColor = False
        '
        'lst_disprod
        '
        Me.lst_disprod.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_disprod.FormattingEnabled = True
        Me.lst_disprod.ItemHeight = 18
        Me.lst_disprod.Location = New System.Drawing.Point(136, 21)
        Me.lst_disprod.Name = "lst_disprod"
        Me.lst_disprod.Size = New System.Drawing.Size(222, 166)
        Me.lst_disprod.TabIndex = 1
        '
        'grp_info
        '
        Me.grp_info.Controls.Add(Me.lbl_price)
        Me.grp_info.Controls.Add(Me.cmd_edit)
        Me.grp_info.Controls.Add(Me.lbl_quantity)
        Me.grp_info.Controls.Add(Me.cmd_addStocks)
        Me.grp_info.Controls.Add(Me.lbl_name)
        Me.grp_info.Controls.Add(Me.Label3)
        Me.grp_info.Controls.Add(Me.Label2)
        Me.grp_info.Controls.Add(Me.Label1)
        Me.grp_info.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_info.Location = New System.Drawing.Point(599, 25)
        Me.grp_info.Name = "grp_info"
        Me.grp_info.Size = New System.Drawing.Size(305, 135)
        Me.grp_info.TabIndex = 3
        Me.grp_info.TabStop = False
        Me.grp_info.Text = "Item Info"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(107, 100)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(63, 19)
        Me.lbl_price.TabIndex = 5
        Me.lbl_price.Text = "Label6"
        '
        'cmd_edit
        '
        Me.cmd_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_edit.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_edit.Location = New System.Drawing.Point(186, 93)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(87, 26)
        Me.cmd_edit.TabIndex = 6
        Me.cmd_edit.Text = "&Edit Price"
        Me.cmd_edit.UseVisualStyleBackColor = False
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.Location = New System.Drawing.Point(107, 74)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(63, 19)
        Me.lbl_quantity.TabIndex = 4
        Me.lbl_quantity.Text = "Label7"
        '
        'cmd_addStocks
        '
        Me.cmd_addStocks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_addStocks.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_addStocks.Location = New System.Drawing.Point(186, 65)
        Me.cmd_addStocks.Name = "cmd_addStocks"
        Me.cmd_addStocks.Size = New System.Drawing.Size(87, 26)
        Me.cmd_addStocks.TabIndex = 1
        Me.cmd_addStocks.Text = "&Add Stocks"
        Me.cmd_addStocks.UseVisualStyleBackColor = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.Red
        Me.lbl_name.Location = New System.Drawing.Point(35, 50)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(56, 18)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "Label6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_addItem)
        Me.GroupBox1.Controls.Add(Me.cbo_category)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.txt_newItem)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(599, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 170)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Item"
        '
        'cmd_addItem
        '
        Me.cmd_addItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_addItem.Location = New System.Drawing.Point(98, 126)
        Me.cmd_addItem.Name = "cmd_addItem"
        Me.cmd_addItem.Size = New System.Drawing.Size(136, 37)
        Me.cmd_addItem.TabIndex = 7
        Me.cmd_addItem.Text = "&Save Item"
        Me.cmd_addItem.UseVisualStyleBackColor = False
        '
        'cbo_category
        '
        Me.cbo_category.AutoCompleteCustomSource.AddRange(New String() {"Foods", "Beverages", "Codements", "Others"})
        Me.cbo_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_category.FormattingEnabled = True
        Me.cbo_category.Items.AddRange(New Object() {"Foods", "Beverages", "Condements", "Others"})
        Me.cbo_category.Location = New System.Drawing.Point(127, 88)
        Me.cbo_category.Name = "cbo_category"
        Me.cbo_category.Size = New System.Drawing.Size(136, 26)
        Me.cbo_category.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Item Name"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(127, 57)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(136, 26)
        Me.txt_price.TabIndex = 1
        '
        'txt_newItem
        '
        Me.txt_newItem.Location = New System.Drawing.Point(127, 25)
        Me.txt_newItem.Name = "txt_newItem"
        Me.txt_newItem.Size = New System.Drawing.Size(136, 26)
        Me.txt_newItem.TabIndex = 0
        '
        'grp_options
        '
        Me.grp_options.Controls.Add(Me.cmd_back)
        Me.grp_options.Controls.Add(Me.cmd_delete)
        Me.grp_options.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_options.Location = New System.Drawing.Point(225, 228)
        Me.grp_options.Name = "grp_options"
        Me.grp_options.Size = New System.Drawing.Size(358, 113)
        Me.grp_options.TabIndex = 5
        Me.grp_options.TabStop = False
        Me.grp_options.Text = "Options"
        '
        'cmd_back
        '
        Me.cmd_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_back.Location = New System.Drawing.Point(194, 31)
        Me.cmd_back.Name = "cmd_back"
        Me.cmd_back.Size = New System.Drawing.Size(149, 62)
        Me.cmd_back.TabIndex = 4
        Me.cmd_back.Text = "&Back To Menu"
        Me.cmd_back.UseVisualStyleBackColor = False
        '
        'cmd_delete
        '
        Me.cmd_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_delete.Location = New System.Drawing.Point(12, 30)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(158, 62)
        Me.cmd_delete.TabIndex = 0
        Me.cmd_delete.Text = "&Delete Item"
        Me.cmd_delete.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 355)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'frm_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 355)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grp_options)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_info)
        Me.Controls.Add(Me.grp_category)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_inventory"
        Me.Text = "Inventory"
        Me.grp_category.ResumeLayout(False)
        Me.grp_info.ResumeLayout(False)
        Me.grp_info.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp_options.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_category As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_all As System.Windows.Forms.Button
    Friend WithEvents cmd_others As System.Windows.Forms.Button
    Friend WithEvents cmd_con As System.Windows.Forms.Button
    Friend WithEvents cmd_bev As System.Windows.Forms.Button
    Friend WithEvents cmd_food As System.Windows.Forms.Button
    Friend WithEvents lst_disprod As System.Windows.Forms.ListBox
    Friend WithEvents grp_info As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents lbl_quantity As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_edit As System.Windows.Forms.Button
    Friend WithEvents cbo_category As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_newItem As System.Windows.Forms.TextBox
    Friend WithEvents grp_options As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_back As System.Windows.Forms.Button
    Friend WithEvents cmd_addStocks As System.Windows.Forms.Button
    Friend WithEvents cmd_delete As System.Windows.Forms.Button
    Friend WithEvents cmd_addItem As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tip_inventory As System.Windows.Forms.ToolTip
End Class
