Public Class Registration
    '----------------------------------------------------------
    '                   REGISTRATION CLASS
    '----------------------------------------------------------
    'This is our FIRST CLASS following the guidelines of the project
    'that includes three main classes
    'the purpose of this class is to save necessary information from the client
    'the class then saves all the gathered information after verification
    'it is saved under My,Settings in project configuration
    'THIS CLASS CONTAINS
    '10 Properties in Accordance with the guidelines
    ' 7 FUNCTIONS/SUBS
    'TECHDROPS 2015


    'techdrops class for displaying messages
    Inherits Techdrops

    'for SHA-512 Algorithm in saving information
    Dim secure As New SecurityClass

    '---------------------------------------
    '       Property Return Values
    '---------------------------------------
    Dim prodName As String 'PROPERTY # 1
    Dim prodUser As String 'PROPERTY # 2
    Dim prodPass As String 'PROPERTY # 3
    Dim prodSecret As String 'PROPERTY # 4
    Dim prodAnswer As String 'PROPERTY # 5
    Dim prodKey As String 'PROPERTY # 6

    '---------------------------------------
    '       My.Settings Properties 
    '---------------------------------------
    'this will be saved to My.Settings as xml pre app configuration

    Property Name As String
        Set(ByVal value As String)
            prodName = value
        End Set
        Get
            Return prodName
        End Get
    End Property

    Property User As String
        Set(ByVal value As String)
            prodUser = value
        End Set
        Get
            Return prodUser
        End Get
    End Property

    Property Pass As String
        Set(ByVal value As String)
            prodPass = value
        End Set
        Get
            Return prodPass
        End Get
    End Property

    Property Secret As String
        Set(ByVal value As String)
            prodSecret = value
        End Set
        Get
            Return prodSecret
        End Get
    End Property

    Property Answer As String
        Set(ByVal value As String)
            prodAnswer = value
        End Set
        Get
            Return prodAnswer
        End Get
    End Property

    Property Serial As String
        Set(ByVal value As String)
            prodKey = value
        End Set
        Get
            Return prodKey
        End Get
    End Property

    'Process Properties

    Property nameNotDigit As Boolean 'PROPERTY # 7
    Property checkSer As Boolean 'PROPERTY # 8
    Property checkProperties As Boolean 'PROPERTY # 9
    Property registered As Boolean 'PROPERTY # 10
    '--------------------------------End Property List------------------------


    ' SUB/FUNCTION # 1
    Sub saveName()
        If (prodName.Length >= 4) Then
            'Flag if string has any characters other than letters


            'loop to check if the string contains letters only
            For i As Integer = 0 To (prodName.Length - 1) Step 1
                If Char.IsLetter(prodName.Chars(i)) Then
                    nameNotDigit = True
                ElseIf prodName.Chars(i) = " " Then
                    nameNotDigit = True
                Else
                    nameNotDigit = False
                    Exit For
                End If
            Next
            'End of Loop

            If (nameNotDigit) Then
                My.Settings.Name = prodName
                'displayInformation("Name Save Successfully")

            Else
                'displayWarning("Name Must Not Contain Numbers or Special Characters")
            End If
        Else
            'displayWarning("Name Must Not Be Less Than 4 Characters")
        End If

    End Sub


    ' SUB/FUNCTION # 2
    Sub saveUser()

        If prodUser.Length >= 4 Then
            My.Settings.a_user = secure.SHA512(prodUser)
        Else
            'displayWarning("Username Must Not Be Less Than 4 Characters")

        End If

    End Sub

    ' SUB/FUNCTION # 3
    Sub savePass()
        If prodPass.Length >= 4 Then
            My.Settings.a_pass = secure.SHA512(prodPass)
        Else
            'displayWarning("Password Should Not Be Less Than 4 Characters")


        End If
    End Sub


    ' SUB/FUNCTION # 4
    Sub saveSecret()
        If prodSecret.Length >= 10 Then
            My.Settings.SecretQuestion = prodSecret
        Else
            'displayWarning("Secret Question Should Not Be Less Than 10 Characters")
        End If
    End Sub


    ' SUB/FUNCTION # 5
    'saves the secret answer to my.settings
    Sub saveAnswer()
        My.Settings.SecretAnswer = prodAnswer
    End Sub

    ' SUB/FUNCTION # 6
    'checks if the user entered correct serial
    Function checkSerial()
        If (secure.SHA512(prodKey) = My.Settings.Serial) Then
            checkSer = True
        Else
            checkSer = False
        End If

        Return checkSer
    End Function

    ' SUB/FUNCTION # 7
    'checks if the user has finished registration
    Function checkRegistration()
        registered = False

        If (My.Settings.a_pass = "" Or My.Settings.a_user = "" Or My.Settings.Name = "" Or _
           My.Settings.SecretQuestion = "" Or My.Settings.SecretAnswer = "") Then
            checkProperties = False
        Else
            checkProperties = True
            My.Settings.Registered = True
            registered = True
        End If
        Return checkProperties
    End Function





End Class
