Imports System.Text
Imports System.Security.Cryptography
Public Class SecurityClass
    'Techdrops Extra Class
    'For additional security converts important credentials to US Standard SHA-512 Algorithm
    'Not Counted for Class Count
    'Techdrops 2015



    Function SHA512(ByVal SourceText As String)
        Dim a() As Byte = Encoding.UTF8.GetBytes(SourceText)
        Dim b As Byte()
        Dim c As New SHA512Managed
        b = c.ComputeHash(a)
        Dim d As String = Convert.ToBase64String(b)
        d = d + "TeChDrOpSsEcUrItYfUnCtIoN"
        Return d

    End Function





End Class
