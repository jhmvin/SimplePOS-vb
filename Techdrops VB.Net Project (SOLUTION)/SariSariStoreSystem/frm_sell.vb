Public Class frm_sell
    'Imports for AsyncKeyState Listener
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Dim connection As New DatabaseConnection
    Dim msg As New Techdrops
    Dim calc As New ComputeClass

    Dim totalPrice As Double

    Private Sub frm_sell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        tip_sell.ShowAlways = True
        tip_sell.SetToolTip(cmd_add, "Add Item: Hotkey: (P)")
        tip_sell.SetToolTip(cmd_remove, "Remove Item Item: Hotkey: (R)")
        tip_sell.SetToolTip(cmd_back, "Main Menu: Hotkey: (F1)")
        tip_sell.SetToolTip(cmd_pay, "Pay Items: Hotkey: (Right Arrow Key)")
        tip_sell.SetToolTip(cbo_pcs, "How Many Pieces: Hotkey: (Q)")
        tip_sell.SetToolTip(txt_cash, "Your Payment: Hotkey: (M)")
        tip_sell.SetToolTip(lst_cart, "Your Cart: Hotkey: (L)")
        tip_sell.SetToolTip(lst_disprod, "Item List: Hotkey: (Home Key)")

        tip_sell.SetToolTip(cmd_all, "Show All: Hotkey: (A)")
        tip_sell.SetToolTip(cmd_food, "Show Food: Hotkey: (F)")
        tip_sell.SetToolTip(cmd_bev, "Show Beverages: Hotkey: (B)")
        tip_sell.SetToolTip(cmd_con, "Show Condements: Hotkey: (C)")
        tip_sell.SetToolTip(cmd_others, "Show Others: Hotkey: (O)")


        'Screen Center Alignment
        'Get the working area of the screen and assign it to a rectangle object
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        'Divide the screen in half, and find the center of the form to center it
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        'sets the label not visible
        lbl_name.Visible = False
        lbl_quantity.Visible = False
        lbl_price.Visible = False

        'Connection to Database using DC (DAtabase Connection class)
        Try
            connection.conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=marichu.accdb"
            connection.myTable = "ProductList"
            connection.connect()
        Catch
            msg.displayError("Cannot Establish Connection With The Database")
            frm_main.Show()
            Me.Close()
        End Try


        'displays the return list in for each statement
        Dim value As String
        For Each value In connection.getList()
            lst_disprod.Items.Add(value.ToUpper)
        Next

        'sets the index of product list to 0
        'checks if the inventory is empty
        Try
            lst_disprod.SelectedIndex = 0
        Catch
            msg.displayInformation("Inventory is Empty")
            grp_cart.Enabled = False
            grp_category.Enabled = False
            grp_info.Enabled = False
            grp_sell.Enabled = False
            grp_pay.Enabled = False
            cmd_back.Enabled = True

            Exit Sub
        End Try

        cmd_all.PerformClick()
        'events listener start
        tmr_sell.Start()

        'disables pay  if theres no item in the cart
        If (calc.cartTotal < 1) Then
            grp_pay.Enabled = False
        Else
            grp_pay.Enabled = True
        End If



    End Sub



    Private Sub lst_disprod_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lst_disprod.SelectedIndexChanged
        'makes the labrld visible
        lbl_name.Visible = True
        lbl_quantity.Visible = True
        lbl_price.Visible = True
        'using the class database it will display the information from the database
        lbl_quantity.Text = connection.getQuantity(lst_disprod.Text.ToUpper)
        lbl_name.Text = lst_disprod.Text
        lbl_price.Text = Format(connection.getPrice(lst_disprod.Text.ToUpper), "0.00")
    End Sub

    'global hotkey f1 to return
    Private Sub tmr_sell_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_sell.Tick
        If (GetAsyncKeyState(Keys.F1)) Then
            Me.Close()
            frm_main.Show()
        ElseIf (GetAsyncKeyState(Keys.A)) Then
            cmd_all.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.F)) Then
            cmd_food.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.B)) Then
            cmd_bev.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.O)) Then
            cmd_others.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.C)) Then
            cmd_con.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.F1)) Then
            cmd_back.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.Right)) Then
            cmd_pay.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.P)) Then
            cmd_add.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.R)) Then
            cmd_remove.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.Q)) Then
            cbo_pcs.Focus()
        ElseIf (GetAsyncKeyState(Keys.M)) Then
            txt_cash.Focus()
        ElseIf (GetAsyncKeyState(Keys.L)) Then
            lst_cart.Focus()
            Try
                lst_cart.SelectedIndex = 0
            Catch
                msg.displayInformation("Cart Is Empty.")
            End Try

        ElseIf (GetAsyncKeyState(Keys.Home)) Then
            lst_disprod.Focus()
            Try
                lst_disprod.SelectedIndex = 0
            Catch
                msg.displayInformation("List Is Empty")
            End Try





        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_add.Click
        'sets the vat rate default is 12%
        calc.vatRate = 0.12

        Try
            'gets the quatity and price
            calc.pcs = CInt(cbo_pcs.Text)
        Catch
            'conversion failed
            msg.displayWarning("Please Enter A Valid Quantity")
            Exit Sub
        End Try

        Try
            calc.itemPrice = CDbl(lbl_price.Text)
        Catch
            msg.displayInformation("Select Item To Add")
            Exit Sub
        End Try

        If calc.pcs < 1 Then
            msg.displayWarning("Invalid Quantity")
            Exit Sub
        End If

        Try
            connection.stockNames = lst_disprod.Text.ToUpper 'name of item
            connection.updateStock = calc.pcs 'pcs to minus
            'updates the database and checks if not negative
            connection.retrieveStock()

            If (connection.operationSuccess = True) Then
                'performs all the process
                'java inspired getter and setter to avoid uneccesary long function inputs
                calc.getPerItemTotal()
                calc.getCartTotal()
                calc.getVat()
                calc.getVatExemptSale()


                'this is and hidden items used as a modified array
                'not visible to the user
                lst_item.Items.Add(lst_disprod.Text.ToUpper)
                lst_price.Items.Add(lbl_price.Text)
                lst_quantity.Items.Add(calc.pcs)
                lst_total.Items.Add(calc.itemPriceTotal)





                'adds the item to cart
                lst_cart.Items.Add(lst_disprod.Text.ToUpper & " --  " & calc.pcs & "pc(s) --  P" & calc.itemPriceTotal)

                'updates the total price
                lbl_totalPrice.Text = Format(calc.cartTotal, "0.00")

            End If
        Catch
            'no item to add
            msg.displayWarning("Please Select An Item To Add")
        End Try

        'updates the label after click
        lbl_quantity.Text = connection.getQuantity(lst_disprod.Text.ToUpper)

        'disables pay  if theres no item in the cart
        If (calc.cartTotal < 1) Then
            grp_pay.Enabled = False
        Else
            grp_pay.Enabled = True
        End If

    End Sub





    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_remove.Click
        'reverse effect of the add item
        'try catch function to avoid unexpected system logic failure
        Try
            calc.pcs = CInt(lst_quantity.Text)
            calc.itemPrice = CDbl(lst_price.Text)
            calc.cartTotal -= CDbl(lst_total.Text)

            lbl_totalPrice.Text = Format(calc.cartTotal, "0.00")

            connection.stockNames = lst_item.Text.ToUpper
            connection.updateStock = calc.pcs

            connection.returnStock()
        Catch
            'just for safety precaution all the inputs here will be from the system
        End Try


        'checks if there is a selected item if
        Try
            lst_item.Items.RemoveAt(lst_item.SelectedIndex)
            lst_price.Items.RemoveAt(lst_price.SelectedIndex)
            lst_quantity.Items.RemoveAt(lst_quantity.SelectedIndex)
            lst_total.Items.RemoveAt(lst_total.SelectedIndex)
            lst_cart.Items.RemoveAt(lst_cart.SelectedIndex)
        Catch
            msg.displayInformation("Please Choose Item To Remove")
        End Try

        'updates the label after click
        lbl_quantity.Text = connection.getQuantity(lst_disprod.Text.ToUpper)

        'disables pay  if theres no item in the cart
        If (calc.cartTotal < 1) Then
            grp_pay.Enabled = False
        Else
            grp_pay.Enabled = True
        End If


    End Sub

    Private Sub lst_cart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_cart.SelectedIndexChanged
        'updates the labels during index change
        lst_item.SelectedIndex = lst_cart.SelectedIndex
        lst_price.SelectedIndex = lst_cart.SelectedIndex
        lst_quantity.SelectedIndex = lst_cart.SelectedIndex
        lst_total.SelectedIndex = lst_cart.SelectedIndex
    End Sub

    '-------------------------------------------------------------------------------
    '                                   Category Sort
    '-------------------------------------------------------------------------------
    'techdrops category sort using getCategory Function

    Private Sub cmd_food_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_food.Click
        lst_disprod.Items.Clear()

        Try
            Dim value As String
            For Each value In connection.getCategory("foods")

                lst_disprod.Items.Add(value.ToUpper)
            Next
            lst_disprod.SelectedIndex = 0

        Catch
            msg.displayInformation("No Items To Display")
        End Try
    End Sub

    Private Sub cmd_bev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_bev.Click
        lst_disprod.Items.Clear()

        Try
            Dim value As String
            For Each value In connection.getCategory("BEVERAGES")

                lst_disprod.Items.Add(value.ToUpper)
            Next
            lst_disprod.SelectedIndex = 0

        Catch
            msg.displayInformation("No Items To Display")
        End Try
    End Sub


    Private Sub cmd_con_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_con.Click
        lst_disprod.Items.Clear()

        Try
            Dim value As String
            For Each value In connection.getCategory("CoNdEmEntS")

                lst_disprod.Items.Add(value.ToUpper)
            Next
            lst_disprod.SelectedIndex = 0

        Catch
            msg.displayInformation("No Items To Display")
        End Try
    End Sub

    Private Sub cmd_others_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_others.Click
        lst_disprod.Items.Clear()
        Try

            Dim value As String
            For Each value In connection.getCategory("others")

                lst_disprod.Items.Add(value.ToUpper)
            Next
            lst_disprod.SelectedIndex = 0

        Catch
            msg.displayInformation("No Items To Display")
        End Try
    End Sub

    Private Sub cmd_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_all.Click
        lst_disprod.Items.Clear()

        Try
            Dim value As String
            For Each value In connection.getList()
                lst_disprod.Items.Add(value.ToUpper)
            Next
            lst_disprod.SelectedIndex = 0

        Catch
            msg.displayInformation("No Items To Display")
        End Try
    End Sub

    '-------------------------------------------------------------------------------
    '                                   End Category Sort
    '-------------------------------------------------------------------------------



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_back.Click
        'disconnects connection when exit
        connection.disconnect()
        frm_main.Show()
        Me.Close()
    End Sub

    Private Sub cmd_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_pay.Click
        'checks if valid amount
        Try
            calc.cashTendered = CDbl(txt_cash.Text)
        Catch
            msg.displayWarning("Please Enter A Valid Amount")
            Exit Sub
        End Try


        'checks if the insufficient payment
        If (calc.cashTendered < calc.cartTotal) Then
            msg.displayWarning("Insufficient Payment !")
            Exit Sub
        Else
            'gets the change
            calc.getChange()

            'display sell item info
            lbl_vate.Text = "P" & Format(calc.vatExemptSale, "0.00")
            lbl_vat.Text = "P" & Format(calc.vat, "0.00")
            lbl_cart.Text = "P" & Format(calc.cartTotal, "0.00")
            lbl_change.Text = "P" & Format(calc.change, "0.00")




            '--------------------------------------------------------
            '                   SALES REPORT BLOCK
            '--------------------------------------------------------
            'Records all sales data and saves into another table

            Dim item As String
            Dim quan As Integer
            Dim total As Double
            For counter As Integer = 0 To (lst_item.Items.Count - 1)

                lst_item.SelectedIndex = counter
                lst_quantity.SelectedIndex = counter
                lst_total.SelectedIndex = counter

                item = lst_item.SelectedItem.ToString
                quan = CInt(lst_quantity.SelectedItem.ToString)
                total = CDbl(lst_total.SelectedItem.ToString)
                Dim time As String = DateTime.Now.ToString("hh:mm:ss tt")
                Dim dateNow As String = DateTime.Now.ToString("MMMM dd yyyy")
                Try
                    'Execute non query takes me so much time to figure this out those @#@#@!@$ [  ]
                    'command builder always takes an error "Insert into syntax"
                    'so i used execute non query to solve this issue
                    Dim rs As New OleDb.OleDbCommand("INSERT INTO [SalesReport]([ItemNAme],[Quantity],[Total],[Time],[dateNow])" & _
                                     " VALUES ('" & item & "'  , '" & quan & "' , '" & total & "', '" & time & "', '" & dateNow & "')", connection.con)
                    'likee update of data adapter
                    rs.ExecuteNonQuery()
                Catch
                    msg.displayError("Cannot Establish Connection To The Database")
                    frm_main.Show()
                    Me.Close()
                    Exit Sub
                End Try
            Next

            '--------------------------------------------------------
            '                   SALES REPORT BLOCK
            '--------------------------------------------------------



            'clears all data after payment
            lst_item.Items.Clear()
            lst_price.Items.Clear()
            lst_quantity.Items.Clear()
            lst_total.Items.Clear()
            lst_cart.Items.Clear()
            calc.cartTotal = 0



            grp_pay.Enabled = False

        End If


        msg.displayInformation("Transaction Complete.")

    End Sub




End Class