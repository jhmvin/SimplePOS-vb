Public Class frm_forgot
    Dim secure As New SecurityClass
    Dim msg As New Techdrops

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        Me.Close()
        frm_log.Show()
    End Sub

    Private Sub cmd_recover_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_recover.Click
        'checks the secret question
        If txt_answer.Text = My.Settings.SecretAnswer Then
            msg.displayInformation("Identity Verified Please Enter New Password")
            lbl_secret.Visible = False
            grp_setPass.Enabled = True
            txt_answer.Enabled = False
        Else
            lbl_secret.Visible = True
            lbl_secret.Text = "Incorrect Answer"
        End If
    End Sub

    Private Sub frm_forgot_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Screen Center Alignment
        'Get the working area of the screen and assign it to a rectangle object
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        'Divide the screen in half, and find the center of the form to center it
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        'disables visibility
        lbl_erNewPass.Visible = False
        lbl_secret.Visible = False
        lbl_question.Text = My.Settings.SecretQuestion
        grp_setPass.Enabled = False
        cmd_back.Enabled = False

        'tool tips
        tip_secure.ShowAlways = True
        tip_secure.SetToolTip(cmd_recover, "Enter Your Secret Answer to Reset Your Password : HotKey: (Alt + R)")
        tip_secure.SetToolTip(cmd_cancel, "Go Back To Sign-In: HotKey: (Alt + C)")
        tip_secure.SetToolTip(grp_ver, "Verify Your Identity To Recover Your Password")
        tip_secure.SetToolTip(grp_setPass, "Set Your New Password")

        tip_secure.SetToolTip(cmd_continue, "Change Your Password: HotKey: (Enter)")
        tip_secure.SetToolTip(cmd_back, "Change Your Password: HotKey: (Alt + A)")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_continue.Click
        'checks if the password is less than 4 characters
        If (txt_newpass1.Text = txt_newpass2.Text) Then
            If (txt_newpass2.Text.Length < 4) Then
                lbl_erNewPass.Visible = True
                lbl_erNewPass.ForeColor = Color.Red
                lbl_erNewPass.Text = "Passowrd too short (4 Chars. Min.)"
                Exit Sub
            End If
            'checks if the password matched
            lbl_erNewPass.Visible = False
            My.Settings.a_pass = secure.SHA512(txt_newpass2.Text)
            msg.displayInformation("New Password Has Been Set.")
            frm_log.Show()

            Me.Close()

        Else
            lbl_erNewPass.Visible = True
            lbl_erNewPass.ForeColor = Color.Red
            lbl_erNewPass.Text = "Password Do Not Match !"

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_back.Click
        'cancel
        frm_main.Show()
        Me.Close()
    End Sub
End Class