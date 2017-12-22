<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sell
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sell))
        Me.grp_category = New System.Windows.Forms.GroupBox()
        Me.cmd_all = New System.Windows.Forms.Button()
        Me.cmd_others = New System.Windows.Forms.Button()
        Me.cmd_con = New System.Windows.Forms.Button()
        Me.cmd_bev = New System.Windows.Forms.Button()
        Me.cmd_food = New System.Windows.Forms.Button()
        Me.lst_disprod = New System.Windows.Forms.ListBox()
        Me.grp_info = New System.Windows.Forms.GroupBox()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_cart = New System.Windows.Forms.ListBox()
        Me.tmr_sell = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_add = New System.Windows.Forms.Button()
        Me.lbl_totalPrice = New System.Windows.Forms.Label()
        Me.cbo_pcs = New System.Windows.Forms.ComboBox()
        Me.cmd_remove = New System.Windows.Forms.Button()
        Me.lst_item = New System.Windows.Forms.ListBox()
        Me.lst_price = New System.Windows.Forms.ListBox()
        Me.lst_quantity = New System.Windows.Forms.ListBox()
        Me.lst_total = New System.Windows.Forms.ListBox()
        Me.grp_array = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmd_pay = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grp_cart = New System.Windows.Forms.GroupBox()
        Me.grp_sell = New System.Windows.Forms.GroupBox()
        Me.cmd_back = New System.Windows.Forms.Button()
        Me.grp_pay = New System.Windows.Forms.GroupBox()
        Me.txt_cash = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_change = New System.Windows.Forms.Label()
        Me.lbl_vate = New System.Windows.Forms.Label()
        Me.lbl_cart = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_vat = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tip_sell = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp_category.SuspendLayout()
        Me.grp_info.SuspendLayout()
        Me.grp_array.SuspendLayout()
        Me.grp_cart.SuspendLayout()
        Me.grp_sell.SuspendLayout()
        Me.grp_pay.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.grp_category.Location = New System.Drawing.Point(215, 6)
        Me.grp_category.Name = "grp_category"
        Me.grp_category.Size = New System.Drawing.Size(366, 204)
        Me.grp_category.TabIndex = 0
        Me.grp_category.TabStop = False
        Me.grp_category.Text = "Category"
        '
        'cmd_all
        '
        Me.cmd_all.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_all.Location = New System.Drawing.Point(12, 24)
        Me.cmd_all.Name = "cmd_all"
        Me.cmd_all.Size = New System.Drawing.Size(120, 28)
        Me.cmd_all.TabIndex = 4
        Me.cmd_all.Text = "All"
        Me.cmd_all.UseVisualStyleBackColor = False
        '
        'cmd_others
        '
        Me.cmd_others.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_others.Location = New System.Drawing.Point(12, 159)
        Me.cmd_others.Name = "cmd_others"
        Me.cmd_others.Size = New System.Drawing.Size(120, 28)
        Me.cmd_others.TabIndex = 3
        Me.cmd_others.Text = "Others"
        Me.cmd_others.UseVisualStyleBackColor = False
        '
        'cmd_con
        '
        Me.cmd_con.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_con.Location = New System.Drawing.Point(12, 125)
        Me.cmd_con.Name = "cmd_con"
        Me.cmd_con.Size = New System.Drawing.Size(120, 28)
        Me.cmd_con.TabIndex = 2
        Me.cmd_con.Text = "Condements"
        Me.cmd_con.UseVisualStyleBackColor = False
        '
        'cmd_bev
        '
        Me.cmd_bev.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_bev.Location = New System.Drawing.Point(12, 91)
        Me.cmd_bev.Name = "cmd_bev"
        Me.cmd_bev.Size = New System.Drawing.Size(120, 28)
        Me.cmd_bev.TabIndex = 1
        Me.cmd_bev.Text = "Beverages"
        Me.cmd_bev.UseVisualStyleBackColor = False
        '
        'cmd_food
        '
        Me.cmd_food.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_food.Location = New System.Drawing.Point(12, 58)
        Me.cmd_food.Name = "cmd_food"
        Me.cmd_food.Size = New System.Drawing.Size(120, 28)
        Me.cmd_food.TabIndex = 0
        Me.cmd_food.Text = "Food"
        Me.cmd_food.UseVisualStyleBackColor = False
        '
        'lst_disprod
        '
        Me.lst_disprod.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_disprod.FormattingEnabled = True
        Me.lst_disprod.ItemHeight = 18
        Me.lst_disprod.Location = New System.Drawing.Point(138, 21)
        Me.lst_disprod.Name = "lst_disprod"
        Me.lst_disprod.Size = New System.Drawing.Size(222, 166)
        Me.lst_disprod.TabIndex = 1
        '
        'grp_info
        '
        Me.grp_info.Controls.Add(Me.lbl_price)
        Me.grp_info.Controls.Add(Me.lbl_quantity)
        Me.grp_info.Controls.Add(Me.lbl_name)
        Me.grp_info.Controls.Add(Me.Label3)
        Me.grp_info.Controls.Add(Me.Label2)
        Me.grp_info.Controls.Add(Me.Label1)
        Me.grp_info.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_info.Location = New System.Drawing.Point(587, 6)
        Me.grp_info.Name = "grp_info"
        Me.grp_info.Size = New System.Drawing.Size(225, 127)
        Me.grp_info.TabIndex = 2
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
        'lst_cart
        '
        Me.lst_cart.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_cart.FormattingEnabled = True
        Me.lst_cart.ItemHeight = 17
        Me.lst_cart.Location = New System.Drawing.Point(13, 31)
        Me.lst_cart.Name = "lst_cart"
        Me.lst_cart.Size = New System.Drawing.Size(337, 123)
        Me.lst_cart.TabIndex = 2
        '
        'tmr_sell
        '
        '
        'cmd_add
        '
        Me.cmd_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_add.Location = New System.Drawing.Point(21, 59)
        Me.cmd_add.Name = "cmd_add"
        Me.cmd_add.Size = New System.Drawing.Size(177, 31)
        Me.cmd_add.TabIndex = 5
        Me.cmd_add.Text = "Add Item"
        Me.cmd_add.UseVisualStyleBackColor = False
        '
        'lbl_totalPrice
        '
        Me.lbl_totalPrice.AutoSize = True
        Me.lbl_totalPrice.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalPrice.ForeColor = System.Drawing.Color.Lime
        Me.lbl_totalPrice.Location = New System.Drawing.Point(111, 144)
        Me.lbl_totalPrice.Name = "lbl_totalPrice"
        Me.lbl_totalPrice.Size = New System.Drawing.Size(68, 32)
        Me.lbl_totalPrice.TabIndex = 6
        Me.lbl_totalPrice.Text = "0.00"
        '
        'cbo_pcs
        '
        Me.cbo_pcs.FormattingEnabled = True
        Me.cbo_pcs.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbo_pcs.Location = New System.Drawing.Point(111, 25)
        Me.cbo_pcs.Name = "cbo_pcs"
        Me.cbo_pcs.Size = New System.Drawing.Size(87, 26)
        Me.cbo_pcs.TabIndex = 7
        Me.cbo_pcs.Text = "1"
        '
        'cmd_remove
        '
        Me.cmd_remove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_remove.Location = New System.Drawing.Point(21, 95)
        Me.cmd_remove.Name = "cmd_remove"
        Me.cmd_remove.Size = New System.Drawing.Size(177, 31)
        Me.cmd_remove.TabIndex = 8
        Me.cmd_remove.Text = "Remove Item"
        Me.cmd_remove.UseVisualStyleBackColor = False
        '
        'lst_item
        '
        Me.lst_item.FormattingEnabled = True
        Me.lst_item.Location = New System.Drawing.Point(24, 14)
        Me.lst_item.Name = "lst_item"
        Me.lst_item.Size = New System.Drawing.Size(64, 43)
        Me.lst_item.TabIndex = 9
        '
        'lst_price
        '
        Me.lst_price.FormattingEnabled = True
        Me.lst_price.Location = New System.Drawing.Point(24, 63)
        Me.lst_price.Name = "lst_price"
        Me.lst_price.Size = New System.Drawing.Size(64, 43)
        Me.lst_price.TabIndex = 10
        '
        'lst_quantity
        '
        Me.lst_quantity.FormattingEnabled = True
        Me.lst_quantity.Location = New System.Drawing.Point(24, 117)
        Me.lst_quantity.Name = "lst_quantity"
        Me.lst_quantity.Size = New System.Drawing.Size(64, 43)
        Me.lst_quantity.TabIndex = 11
        '
        'lst_total
        '
        Me.lst_total.FormattingEnabled = True
        Me.lst_total.Location = New System.Drawing.Point(24, 166)
        Me.lst_total.Name = "lst_total"
        Me.lst_total.Size = New System.Drawing.Size(64, 43)
        Me.lst_total.TabIndex = 12
        '
        'grp_array
        '
        Me.grp_array.Controls.Add(Me.lst_total)
        Me.grp_array.Controls.Add(Me.lst_quantity)
        Me.grp_array.Controls.Add(Me.lst_price)
        Me.grp_array.Controls.Add(Me.lst_item)
        Me.grp_array.Location = New System.Drawing.Point(1200, 22)
        Me.grp_array.Name = "grp_array"
        Me.grp_array.Size = New System.Drawing.Size(113, 256)
        Me.grp_array.TabIndex = 13
        Me.grp_array.TabStop = False
        Me.grp_array.Text = "modifiedArray"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Quantity"
        '
        'cmd_pay
        '
        Me.cmd_pay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_pay.Location = New System.Drawing.Point(13, 81)
        Me.cmd_pay.Name = "cmd_pay"
        Me.cmd_pay.Size = New System.Drawing.Size(177, 31)
        Me.cmd_pay.TabIndex = 15
        Me.cmd_pay.Text = "Pay"
        Me.cmd_pay.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total"
        '
        'grp_cart
        '
        Me.grp_cart.Controls.Add(Me.lst_cart)
        Me.grp_cart.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_cart.Location = New System.Drawing.Point(225, 217)
        Me.grp_cart.Name = "grp_cart"
        Me.grp_cart.Size = New System.Drawing.Size(364, 170)
        Me.grp_cart.TabIndex = 17
        Me.grp_cart.TabStop = False
        Me.grp_cart.Text = "Customer's Cart"
        '
        'grp_sell
        '
        Me.grp_sell.Controls.Add(Me.Label7)
        Me.grp_sell.Controls.Add(Me.Label6)
        Me.grp_sell.Controls.Add(Me.lbl_totalPrice)
        Me.grp_sell.Controls.Add(Me.cbo_pcs)
        Me.grp_sell.Controls.Add(Me.cmd_remove)
        Me.grp_sell.Controls.Add(Me.cmd_add)
        Me.grp_sell.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_sell.Location = New System.Drawing.Point(587, 139)
        Me.grp_sell.Name = "grp_sell"
        Me.grp_sell.Size = New System.Drawing.Size(225, 184)
        Me.grp_sell.TabIndex = 18
        Me.grp_sell.TabStop = False
        Me.grp_sell.Text = "Sell Item"
        '
        'cmd_back
        '
        Me.cmd_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_back.Location = New System.Drawing.Point(608, 333)
        Me.cmd_back.Name = "cmd_back"
        Me.cmd_back.Size = New System.Drawing.Size(189, 47)
        Me.cmd_back.TabIndex = 17
        Me.cmd_back.Text = "Back To Menu"
        Me.cmd_back.UseVisualStyleBackColor = False
        '
        'grp_pay
        '
        Me.grp_pay.Controls.Add(Me.txt_cash)
        Me.grp_pay.Controls.Add(Me.Label4)
        Me.grp_pay.Controls.Add(Me.cmd_pay)
        Me.grp_pay.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_pay.Location = New System.Drawing.Point(824, 6)
        Me.grp_pay.Name = "grp_pay"
        Me.grp_pay.Size = New System.Drawing.Size(212, 131)
        Me.grp_pay.TabIndex = 19
        Me.grp_pay.TabStop = False
        Me.grp_pay.Text = "Payment"
        '
        'txt_cash
        '
        Me.txt_cash.Location = New System.Drawing.Point(13, 51)
        Me.txt_cash.Name = "txt_cash"
        Me.txt_cash.Size = New System.Drawing.Size(177, 26)
        Me.txt_cash.TabIndex = 17
        Me.txt_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Cash"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_change)
        Me.GroupBox1.Controls.Add(Me.lbl_vate)
        Me.GroupBox1.Controls.Add(Me.lbl_cart)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_vat)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(824, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 248)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Info"
        '
        'lbl_change
        '
        Me.lbl_change.AutoSize = True
        Me.lbl_change.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_change.ForeColor = System.Drawing.Color.Blue
        Me.lbl_change.Location = New System.Drawing.Point(48, 199)
        Me.lbl_change.Name = "lbl_change"
        Me.lbl_change.Size = New System.Drawing.Size(87, 36)
        Me.lbl_change.TabIndex = 39
        Me.lbl_change.Text = "P0.00"
        '
        'lbl_vate
        '
        Me.lbl_vate.AutoSize = True
        Me.lbl_vate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vate.ForeColor = System.Drawing.Color.Black
        Me.lbl_vate.Location = New System.Drawing.Point(56, 47)
        Me.lbl_vate.Name = "lbl_vate"
        Me.lbl_vate.Size = New System.Drawing.Size(59, 23)
        Me.lbl_vate.TabIndex = 38
        Me.lbl_vate.Text = "P0.00"
        '
        'lbl_cart
        '
        Me.lbl_cart.AutoSize = True
        Me.lbl_cart.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cart.ForeColor = System.Drawing.Color.Black
        Me.lbl_cart.Location = New System.Drawing.Point(56, 143)
        Me.lbl_cart.Name = "lbl_cart"
        Me.lbl_cart.Size = New System.Drawing.Size(59, 23)
        Me.lbl_cart.TabIndex = 40
        Me.lbl_cart.Text = "P0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 18)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Change"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 18)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Cart Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Vat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Vat Exempt Sale"
        '
        'lbl_vat
        '
        Me.lbl_vat.AutoSize = True
        Me.lbl_vat.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vat.ForeColor = System.Drawing.Color.Black
        Me.lbl_vat.Location = New System.Drawing.Point(56, 91)
        Me.lbl_vat.Name = "lbl_vat"
        Me.lbl_vat.Size = New System.Drawing.Size(59, 23)
        Me.lbl_vat.TabIndex = 33
        Me.lbl_vat.Text = "P0.00"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 407)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'frm_sell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1048, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_pay)
        Me.Controls.Add(Me.grp_array)
        Me.Controls.Add(Me.cmd_back)
        Me.Controls.Add(Me.grp_info)
        Me.Controls.Add(Me.grp_category)
        Me.Controls.Add(Me.grp_cart)
        Me.Controls.Add(Me.grp_sell)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_sell"
        Me.Text = "Sell Items"
        Me.grp_category.ResumeLayout(False)
        Me.grp_info.ResumeLayout(False)
        Me.grp_info.PerformLayout()
        Me.grp_array.ResumeLayout(False)
        Me.grp_cart.ResumeLayout(False)
        Me.grp_sell.ResumeLayout(False)
        Me.grp_sell.PerformLayout()
        Me.grp_pay.ResumeLayout(False)
        Me.grp_pay.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_category As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_con As System.Windows.Forms.Button
    Friend WithEvents cmd_bev As System.Windows.Forms.Button
    Friend WithEvents cmd_food As System.Windows.Forms.Button
    Friend WithEvents lst_disprod As System.Windows.Forms.ListBox
    Friend WithEvents grp_info As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lst_cart As System.Windows.Forms.ListBox
    Friend WithEvents cmd_others As System.Windows.Forms.Button
    Friend WithEvents tmr_sell As System.Windows.Forms.Timer
    Friend WithEvents lbl_quantity As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents cmd_add As System.Windows.Forms.Button
    Friend WithEvents lbl_totalPrice As System.Windows.Forms.Label
    Friend WithEvents cbo_pcs As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_remove As System.Windows.Forms.Button
    Friend WithEvents lst_item As System.Windows.Forms.ListBox
    Friend WithEvents lst_price As System.Windows.Forms.ListBox
    Friend WithEvents lst_quantity As System.Windows.Forms.ListBox
    Friend WithEvents lst_total As System.Windows.Forms.ListBox
    Friend WithEvents grp_array As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmd_pay As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmd_all As System.Windows.Forms.Button
    Friend WithEvents grp_cart As System.Windows.Forms.GroupBox
    Friend WithEvents grp_sell As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_back As System.Windows.Forms.Button
    Friend WithEvents grp_pay As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cash As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_change As System.Windows.Forms.Label
    Friend WithEvents lbl_vate As System.Windows.Forms.Label
    Friend WithEvents lbl_cart As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_vat As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tip_sell As System.Windows.Forms.ToolTip
End Class
