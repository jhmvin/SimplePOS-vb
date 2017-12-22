Public Class frm_about

    Private Sub frm_about_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Screen Center Alignment
        'Get the working area of the screen and assign it to a rectangle object
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        'Divide the screen in half, and find the center of the form to center it
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        'display license
        lbl_name.Text = My.Settings.Name
        ToolTip1.ShowAlways = True
        ToolTip1.SetToolTip(cmd_back, "Return To Main Menu (ENTER)")
    End Sub

    Private Sub cmd_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_back.Click
        frm_main.Show()
        Me.Close()

    End Sub
End Class