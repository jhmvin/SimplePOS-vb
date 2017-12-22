Public Class frm_inventory

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Dim connection As New DatabaseConnection
    Dim msg As New Techdrops

    Private Sub frm_inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            msg.displayError("Cannot Connect To Database Please Contact The Developer")
            Me.Close()
        End Try

        'displays the return list in for each statement
        Dim value As String
        For Each value In connection.getList()
            lst_disprod.Items.Add(value.ToUpper)
        Next

        'sets the index of product list to 0
        Try
            lst_disprod.SelectedIndex = 0
        Catch
            cmd_edit.Enabled = False
            cmd_addStocks.Enabled = False
            cmd_delete.Enabled = False
        End Try

        'tool tips
        tip_inventory.ShowAlways = True
        tip_inventory.SetToolTip(cmd_all, "Show All")
        tip_inventory.SetToolTip(cmd_food, "Show Food")
        tip_inventory.SetToolTip(cmd_bev, "Show Beverages")
        tip_inventory.SetToolTip(cmd_con, "Shows Condements")
        tip_inventory.SetToolTip(cmd_others, "Show Others")

        tip_inventory.SetToolTip(cmd_delete, "Permanently Deletes An Items: Hotkey: (Alt + D)")
        tip_inventory.SetToolTip(cmd_back, "Back To Main Menu: Hotkey: (Alt + B)")
        tip_inventory.SetToolTip(cmd_addItem, "Saves A New Item: Hotkey: (Alt + S)")
        tip_inventory.SetToolTip(cmd_addStocks, "Add Stocks To Your Inventory: Hotkey: (Alt + A)")
        tip_inventory.SetToolTip(cmd_edit, "Edit Price of Current Selected Item: Hotkey: (Alt + E)")

        'for start up value
        cbo_category.Text = "Foods"



    End Sub

    Private Sub lst_disprod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_disprod.SelectedIndexChanged
        'makes the labrld visible
        lbl_name.Visible = True
        lbl_quantity.Visible = True
        lbl_price.Visible = True
        'using the class database it will display the information from the database
        lbl_quantity.Text = connection.getQuantity(lst_disprod.Text.ToUpper)
        lbl_name.Text = lst_disprod.Text
        lbl_price.Text = Format(connection.getPrice(lst_disprod.Text.ToUpper), "0.00")

    End Sub

    '-------------------------------------------------------------------------------
    '                                   Category Sort
    '-------------------------------------------------------------------------------
    'techdrops category sort using getCategory Function

    'gets all the items under food category
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

    'gets all item under beverages category
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

    'gets all item under condemetns category
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

    'gets all items under others category
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

    'get all items in all categories
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
            cmd_edit.Enabled = False
            cmd_addStocks.Enabled = False
            cmd_delete.Enabled = False
        End Try
    End Sub

    '-------------------------------------------------------------------------------
    '                                   End Category Sort
    '-------------------------------------------------------------------------------

    'adding stock for the item
    Private Sub cmd_addStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addStocks.Click
        'Add stock

        'shows an inputbox
        Dim i = InputBox("Enter Stocks To Add")
        If i = "" Then Exit Sub ' if no input do nothing

        'traps the error if no item was selected or inventory is empty
        Try
            connection.stockNames = lst_disprod.SelectedItem
        Catch
            msg.displayInformation("No Item Is Selected")
        End Try

        'updates the stock using update stock method more
        Try
            connection.updateStock = CInt(i) 'value to add

            If (CInt(i) < 1) Then
                msg.displayWarning("Invalid Add Stock Value")
                Exit Sub
            End If

            connection.returnStock() 'excutes add of stocks
        Catch
            msg.displayWarning("Invalid Add Stock Value")
        End Try


        'updates the label after click
        lbl_quantity.Text = connection.getQuantity(lst_disprod.Text.ToUpper)
    End Sub

    'back to main menu disconnects the database
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_back.Click
        connection.disconnect()
        Me.Close()
        frm_main.Show()
    End Sub

    Private Sub cmd_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(connection.da)
        'message box to prompt
        If MessageBox.Show("Are you Really Sure To Delete This Item ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) _
            = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        'Traps the error if something was modified during runtime
        Try
            connection.findItem(lst_disprod.SelectedItem.ToString)


            connection.ds.Tables("pnTemp").Rows(connection.location).Delete()

            connection.da.Update(connection.ds, "pnTemp")

            msg.displayInformation("Item Deleted.")

            connection.rowCount -= 1
        Catch
            msg.displayError("Cannot Establish Connection To The Database")
            frm_main.Show()
            Me.Close()
        End Try


        cmd_all.PerformClick()

    End Sub
    '
    Private Sub cmd_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit.Click
        'edit price block
        Dim cb As New OleDb.OleDbCommandBuilder(connection.da)

        Dim i = InputBox("Enter New Price")
        If i = "" Then Exit Sub

        Dim p As Double = 0
        Try
            p = CDbl(i)

        Catch

            msg.displayWarning("Invalid Price")
            Exit Sub
        End Try

        If (p < 1) Then
            msg.displayWarning("Invalid Price")
            Exit Sub
        End If

        'udpdates the database
        Try
            connection.findItem(lbl_name.Text.ToUpper)
            connection.ds.Tables("pnTemp").Rows(connection.location).Item(3) = Format(p, "0.00")
            connection.da.Update(connection.ds, "pnTemp")

            lbl_price.Text = Format(p, "0.00")
        Catch
            msg.displayError("Cannot Establish Connection To The Database")
            frm_main.Show()
            Me.Close()
        End Try


    End Sub

    Private Sub cmd_addItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_addItem.Click
        If (txt_newItem.Text.Length < 4) Then
            msg.displayWarning("Item Name Should be 4 Characters and Above")
            Exit Sub
        End If


        'Local Declaration
        Dim newName As String
        Dim inQuan As Integer = 0
        Dim newPrice As Double
        Dim newCategory As String

        'finds if item already existing
        connection.findItem(txt_newItem.Text.ToUpper)
        If connection.foundItem = True Then
            msg.displayInformation("Item Is Already Existing . . .")
            Exit Sub
        Else
            'if no item it will create the item
            newName = txt_newItem.Text.ToUpper
            'error trapping for invalid characters
            Try
                newPrice = CDbl(txt_price.Text)
            Catch
                msg.displayError("You Have Entered An Invalid Amount !")
                Exit Sub
            End Try
            'negative or zero price
            If (newPrice < 1) Then
                msg.displayWarning("Item Price Must Not be Zero or Negative")
                Exit Sub
            End If
            'gets the category
            newCategory = cbo_category.Text.ToUpper

            'filter if its a valid category exit sub if not
            Select Case newCategory
                Case "FOODS"
                Case "BEVERAGES"
                Case "CONDEMENTS"
                Case "OTHERS"
                Case Else
                    msg.displayWarning("An Invalid Category Has Been Selected !")
                    Exit Sub
            End Select

            'execute query to insert the new entry
            Try
                Dim rs As New OleDb.OleDbCommand("INSERT INTO [ProductList]([PRODUCTNAME],[QUANTITY],[PRICE],[CATEGORY])" & _
                                                  " VALUES ('" & newName & "'  , '" & inQuan & "' , '" & newPrice & "', '" & newCategory & "')", connection.con)
                'just like data adapter update
                rs.ExecuteNonQuery()

            Catch
                msg.displayError("Cannot Execute Query Database Connection Lost ... Closing Form")
                frm_main.Show()
                Me.Close()
            End Try

            'to update the dataset
            Try
                connection.disconnect()
                connection.ds.Clear()
                connection.connect()
            Catch
                msg.displayError("An Error Occured While Trying To Reconnect Please Restart The Program")
                frm_main.Show()
                Me.Close()

            End Try

            'checks if the item made here
            cmd_edit.Enabled = True
            cmd_addStocks.Enabled = True
            cmd_delete.Enabled = True
            msg.displayInformation("Item Added Successfully !")


            'reclick after command
            cmd_all.PerformClick()



        End If
    End Sub


End Class