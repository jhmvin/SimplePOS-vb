Public Class Techdrops
    'Extra Class
    'Class use for information delivery
    'class not counted
    'Techdrops 2015

    Sub displayWarning(ByVal text As String)
        MsgBox(text, MsgBoxStyle.Exclamation, "Warning !")
    End Sub

    Sub displayInformation(ByVal text As String)
        MsgBox(text, MsgBoxStyle.Information, "Information")
    End Sub

    Sub displayError(ByVal text As String)
        MsgBox(text, MsgBoxStyle.Critical, "Warning !")
    End Sub


End Class
