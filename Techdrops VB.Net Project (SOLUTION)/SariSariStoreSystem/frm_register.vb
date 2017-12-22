Public Class frm_register


    Dim regMe As New Registration
    Dim msg As New Techdrops


    Private Sub fmr_register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Screen Center Alignment
        'Get the working area of the screen and assign it to a rectangle object
        Dim rect As Rectangle = Screen.PrimaryScreen.WorkingArea
        'Divide the screen in half, and find the center of the form to center it
        Me.Top = (rect.Height / 2) - (Me.Height / 2)
        Me.Left = (rect.Width / 2) - (Me.Width / 2)

        'Resets the XML values during load
        My.Settings.Registered = False
        My.Settings.Name = ""
        My.Settings.a_pass = ""
        My.Settings.a_user = ""
        My.Settings.SecretQuestion = ""
        My.Settings.SecretAnswer = ""

        'Makes the warning invisible at start up
        lbl_erName.Visible = False
        lbl_erUser.Visible = False
        lbl_erPass.Visible = False
        lbl_erQuestion.Visible = False
        lbl_erAnswer.Visible = False
        lbl_erSerial.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_register.Click
        'property assignment of values
        regMe.Name = txt_regname.Text
        regMe.User = txt_reguser.Text
        regMe.Pass = txt_regpass2.Text
        regMe.Secret = txt_regsq.Text
        regMe.Answer = txt_regSA2.Text
        regMe.Serial = txt_productKey.Text

        'checks the serial then proceeds if verified
        If (regMe.checkSerial()) Then

            lbl_erSerial.Visible = True
            lbl_erSerial.ForeColor = Color.Blue
            lbl_erSerial.Text = "Serial Verified"

            '---------------------------------------------------------------------
            '                           LABEL CONTROLS
            '---------------------------------------------------------------------
            'mimics the process of error provider using labels

            'Name Verifier
            regMe.saveName()
            If (My.Settings.Name = "") Then
                lbl_erName.Visible = True
                lbl_erName.ForeColor = Color.Red
                lbl_erName.Text = "No Special Characters And Digit (4 Chars Min)"
            Else
                lbl_erName.Visible = True
                lbl_erName.ForeColor = Color.Blue
                lbl_erName.Text = "Name Is Available !"
            End If

            'saves the information
            regMe.saveUser()
            regMe.savePass()
            regMe.saveSecret()
            regMe.saveAnswer()

            'verification processes can be found at registration class

            'if no informatiion is save xml will be empty
            'because it failed to pass the verification block
            If (My.Settings.a_user = "") Then
                lbl_erUser.Visible = True
                lbl_erUser.ForeColor = Color.Red
                lbl_erUser.Text = "Minimum of 4 Characters !"
            Else
                lbl_erUser.Visible = True
                lbl_erUser.ForeColor = Color.Blue
                lbl_erUser.Text = "Username Is Available !"
            End If

            'password verification
            If (txt_regpass.Text = txt_regpass2.Text) Then

                If (My.Settings.a_pass = "") Then
                    lbl_erPass.Visible = True
                    lbl_erPass.ForeColor = Color.Red
                    lbl_erPass.Text = "Minimum of 4 Characters !"
                Else

                    lbl_erPass.Visible = True
                    lbl_erPass.ForeColor = Color.Blue
                    lbl_erPass.Text = "Password is Available !"
                End If

            Else
                My.Settings.a_pass = ""
                ' regMe.displayWarning("Password Mismatch !")
                lbl_erPass.Visible = True
                lbl_erPass.ForeColor = Color.Red
                lbl_erPass.Text = "Password Do Not Match !"
            End If

            'security question
            If (My.Settings.SecretQuestion = "") Then
                lbl_erQuestion.Visible = True
                lbl_erQuestion.ForeColor = Color.Red
                lbl_erQuestion.Text = "Secret Question Should Be 10 Characters Above"
            Else
                lbl_erQuestion.Visible = True
                lbl_erQuestion.ForeColor = Color.Blue
                lbl_erQuestion.Text = "Question is Available !"
            End If


            'secret answer

            If (txt_regSA.Text = txt_regSA2.Text) Then

                If (My.Settings.SecretAnswer = "") Then
                    lbl_erAnswer.Visible = True
                    lbl_erAnswer.ForeColor = Color.Red
                    lbl_erAnswer.Text = "Answer Cannot Be Empty"
                Else
                    lbl_erAnswer.Visible = True
                    lbl_erAnswer.ForeColor = Color.Blue
                    lbl_erAnswer.Text = "Secret Answer Matched !"
                End If

            Else
                My.Settings.SecretAnswer = ""
                lbl_erAnswer.Visible = True
                lbl_erAnswer.ForeColor = Color.Red
                lbl_erAnswer.Text = "Secret Answer Do Not Match !"
            End If

            'invalid serial returns a message
        Else
            lbl_erSerial.Visible = True
            lbl_erSerial.ForeColor = Color.Red
            lbl_erSerial.Text = "Invalid Serial"
        End If


        '---------------------------------------------------------------------
        '                           LABEL CONTROLS END
        '---------------------------------------------------------------------








        '---------------------------------------------------------------------
        '                           Registration Verifier
        '---------------------------------------------------------------------
        ' if true xml properties have been saved properly
        If (regMe.checkRegistration) Then
            msg.displayInformation("Registration Complete")
            frm_splash.prgbar_splash.Value = 0
            frm_splash.tmr_prgbar.Enabled = True
            frm_splash.Show()
            Me.Close()
            'else it will reset again
        Else
            My.Settings.Registered = False
            My.Settings.Name = ""
            My.Settings.a_pass = ""
            My.Settings.a_user = ""
            My.Settings.SecretQuestion = ""
            My.Settings.SecretAnswer = ""
        End If


    End Sub



    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        frm_splash.Close()
    End Sub

    Private Sub txt_regpass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_regpass.GotFocus
        txt_regpass.Clear()
    End Sub

    Private Sub txt_regpass2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_regpass2.GotFocus
        txt_regpass2.Clear()
    End Sub

    Private Sub txt_regSA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_regSA.GotFocus
        txt_regSA.Clear()
    End Sub

    Private Sub txt_regSA2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_regSA2.GotFocus
        txt_regSA2.Clear()
    End Sub




End Class