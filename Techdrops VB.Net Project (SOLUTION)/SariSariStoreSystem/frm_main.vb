Public Class frm_main

    'Imports for AsyncKeyState Listener
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short




    Dim secure As New SecurityClass

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Screen Center Alignment
        'Get the working area of the screen and assign it to a rectangle object
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        'Divide the screen in half, and find the center of the form to center it
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)


        tmr_hotpress.Start()

        tip_main.ShowAlways = True
        tip_main.SetToolTip(cmd_sell, "Sell Items Here (F5)")
        tip_main.SetToolTip(cmd_inventory, "View Your Inventory (F6)")
        tip_main.SetToolTip(cmd_sales, "View Sales Report (F7)")
        tip_main.SetToolTip(cmd_change, "Change Your Password (F8)")
        tip_main.SetToolTip(cmd_about, "About Techdrops (F9)")
        tip_main.SetToolTip(cmd_signout, "Back To Sign - In (F10)")



    End Sub





    Private Sub tmr_time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_time.Tick
        'Set The Timer For Labels
        lbl_date.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy")
        lbl_time.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sell.Click
        frm_sell.Show()
        Me.Hide()
        Me.KeyPreview = True
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_signout.Click
        frm_log.Show()
        Me.Close()


    End Sub


    Private Sub tmr_hotpress_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_hotpress.Tick
        'Key State Listener  for global Hotkey
        If (GetAsyncKeyState(Keys.F5)) Then
            cmd_sell.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.F6)) Then
            cmd_inventory.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.F7)) Then
            cmd_sales.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.F8)) Then
            cmd_change.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.F9)) Then
            cmd_about.PerformClick()
        ElseIf (GetAsyncKeyState(Keys.F10)) Then
            cmd_signout.PerformClick()


        End If

    End Sub

    Private Sub cmd_inventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_inventory.Click
        Me.Close()
        frm_inventory.Show()
    End Sub

    Private Sub cmd_sales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sales.Click
        frm_sales.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_about.Click
        frm_about.Show()
        Me.Close()

    End Sub

    Private Sub cmd_change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_change.Click
        'change password exception
        frm_forgot.Show()
        frm_forgot.grp_ver.Enabled = False
        frm_forgot.grp_setPass.Enabled = True
        frm_forgot.cmd_back.Enabled = True
        Me.Close()
    End Sub


End Class