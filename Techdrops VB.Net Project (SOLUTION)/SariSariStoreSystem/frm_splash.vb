Public Class frm_splash

    'Progress Bar Loading
    Private Sub tmr_prgbar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_prgbar.Tick
        prgbar_splash.Increment(1)
        lbl_progress.Text = "Loading ... " & prgbar_splash.Value & "%"
        If prgbar_splash.Value = 100 Then
            tmr_prgbar.Enabled = False

            If My.Settings.Registered = True Then
                frm_log.Show()
            Else
                frm_register.Show()
            End If

            Me.Hide()

        End If



    End Sub

    Private Sub frm_splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Screen Center Alignment
        'Get the working area of the screen and assign it to a rectangle object
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        'Divide the screen in half, and find the center of the form to center it
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

    End Sub

End Class
