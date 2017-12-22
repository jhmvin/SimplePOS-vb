Public Class frm_log

    Dim user As String = My.Settings.a_user
    Dim pass As String = My.Settings.a_pass

    Dim secure As New SecurityClass
    'Imports for AsyncKeyState Listener
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Private Sub cmd_sign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sign.Click

        If (user = secure.SHA512(txt_user.Text) And pass = secure.SHA512(txt_pass.Text)) Then
            frm_main.Show()
            Me.Close()
        Else
            lbl_SignInfo.Visible = True
            lbl_up.Visible = True
            lbl_down.Visible = True
            lbl_SignInfo.Text = "Invalid Username or Password !"
        End If

    End Sub

    Private Sub frm_log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Screen Center Alignment
        'Get the working area of the screen and assign it to a rectangle object
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        'Divide the screen in half, and find the center of the form to center it
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        'Start to listen to keypress
        tmr_log.Start()

        'hide warning label thru loading
        lbl_SignInfo.Visible = False
        lbl_up.Visible = False
        lbl_down.Visible = False


        'tool tips
        tip_log.ShowAlways = True

        tip_log.SetToolTip(cmd_sign, "Sign-In Your Account (ENTER)")
        tip_log.SetToolTip(cmd_exit, "Exit Program (Alt + X)")
        tip_log.SetToolTip(LinkLabel1, "If You Forgot Your Password Click This")

        tip_log.SetToolTip(txt_user, "Enter Your Username")
        tip_log.SetToolTip(txt_pass, "Enter Your Password")


    End Sub


    '--------------------------------START Events Listener------------------------
    Private Sub tmr_log_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_log.Tick

        'Sign In info
        If (secure.SHA512(txt_user.Text) = user) Then
            lbl_up.ForeColor = Color.LightGreen
            lbl_up.Text = "O"
        Else
            lbl_up.ForeColor = Color.Red
            lbl_up.Text = "X"
        End If

        If (secure.SHA512(txt_pass.Text) = pass) Then
            lbl_down.ForeColor = Color.LightGreen
            lbl_down.Text = "O"
        Else
            lbl_down.ForeColor = Color.Red
            lbl_down.Text = "X"
        End If
        '-------------------End sign info X and O
        'if credential correct label message visibility set as false
        If (user = secure.SHA512(txt_user.Text) And pass = secure.SHA512(txt_pass.Text)) Then
            lbl_SignInfo.Visible = False
        End If

        'water mark labels for username and password
        If (txt_user.Text = "") Then
            lbl_usermark.Visible = True
        Else
            lbl_usermark.Visible = False
        End If

        If (txt_pass.Text = "") Then
            lbl_passmark.Visible = True
        Else
            lbl_passmark.Visible = False
        End If

    End Sub
    '--------------------------------End Events Listener------------------------

    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        frm_splash.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_forgot.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.Registered = False
        My.Settings.Name = ""
        My.Settings.a_pass = ""
        My.Settings.a_user = ""
        My.Settings.SecretQuestion = ""
        My.Settings.SecretAnswer = ""
        frm_splash.Close()

    End Sub
End Class