Imports System.Security.Cryptography
Imports System.Text

Public Class Encryption
    Public Shared Function HashString(ByVal str As String) As String
        Return EncryptString(str)
    End Function

    Public Shared Function GenerateSalt() As String
        Using cryptoServiceProvider As RandomNumberGenerator = RandomNumberGenerator.Create()
            Dim sb = New StringBuilder()
            Dim data As Byte() = New Byte(3) {}

            For i As Integer = 0 To 6
                cryptoServiceProvider.GetBytes(data)
                Dim value As String = BitConverter.ToString(data, 0)
                sb.Append(value)
            Next

            Return EncryptString(sb.ToString())
        End Using
    End Function

    Private Shared Function EncryptString(ByVal str As String) As String
        Dim bytes As Byte() = Encoding.ASCII.GetBytes(str)
        Dim hashed = SHA256.Create().ComputeHash(bytes)
        Return Convert.ToBase64String(hashed)
    End Function
End Class
