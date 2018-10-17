Imports MySql.Data.MySqlClient
Imports Dapper
Imports InventoryLibrary
Imports Encryptor
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports System.Text

Module ApplicationModule
    Public code As String
    Public u_acc As String

#Region "User Account"
    Public Sub CreateNewUserAccount(username As String, password As String, position As String, firstname As String, lastname As String, email As String, address As String, contact As String)
        Dim user_account As New UserAccount

        Dim aes As String = Encryption.GenerateSalt
        Dim pass As String = Encryption.HashString(String.Format("{0}{1}", Encryption.HashString(password), aes))

        user_account.Username = username
        user_account.Password = pass
        user_account.AES256 = aes
        user_account.Position = position
        user_account.FirstName = firstname
        user_account.LastName = lastname
        user_account.EmailAddress = email
        user_account.Address = address
        user_account.ContactNumber = contact

        user_account.RegisterUserAccount(user_account)
        MsgBox($"Successfully created new {position} account.", MsgBoxStyle.Information, "Success")
    End Sub

    Public Function PermitUserLogin(ByVal username As String, ByVal password As String) As Boolean
        Dim salt As String = ""
        Using cn = New MySqlConnection(Helper.LoadConnectionString) : cn.Open()
            Dim cmd As New MySqlCommand("select * from UserAccounts where Username = @user", cn)
            cmd.Parameters.AddWithValue("@user", username)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            While dr.Read()
                salt = dr!AES256.ToString
            End While
            dr.Dispose()

            Dim pass = Encryption.HashString(password)
            Dim hashed_salt = Encryption.HashString(String.Format("{0}{1}", pass, salt))
            cmd = New MySqlCommand("select * from UserAccounts where Username = @user and Password = @pass", cn)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", hashed_salt)
            dr = cmd.ExecuteReader

            If dr.HasRows Then Return True Else Return False

            dr.Dispose()
            cn.Close()
        End Using
    End Function

    Public Function UsernameExists(ByVal username As String) As Boolean
        Using cn As New MySqlConnection(Helper.LoadConnectionString) : cn.Open()
            Dim cmd As New MySqlCommand("select * from UserAccounts where Username = @user", cn)
            cmd.Parameters.AddWithValue("@user", username)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If
            dr.Dispose()
            cn.Close()
        End Using
    End Function

    Public Function GetEmailAddress(ByVal username As String) As String
        Using cn As New MySqlConnection(Helper.LoadConnectionString) : cn.Open()
            Dim cmd As New MySqlCommand("select EmailAddress from UserAccounts where Username = @user", cn)
            cmd.Parameters.AddWithValue("@user", username)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            dr.Read()
            Return dr(0).ToString
            dr.Dispose()
            cn.Close()
        End Using
    End Function

    Public Function EmailCheck(ByVal email As String) As Boolean
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailMatch As Match = Regex.Match(email, pattern)
        If emailMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub SendToEmail(ByVal email As String, ByVal subject As String, ByVal message As String)
        Dim emailMessage As New MailMessage
        Try
            emailMessage.From = New MailAddress("iqos.powered@gmail.com")
            emailMessage.To.Add(email)
            emailMessage.Subject = subject
            emailMessage.Body = message
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New Net.NetworkCredential("iqos.powered@gmail.com", "azAZ090913")
            smtp.Send(emailMessage)
        Catch ex As Exception
            MsgBox("Error sending email!" & vbLf & vbLf & ex.Message, 16, "Error: SendToEmail")
        End Try
    End Sub

    Public Function GenerateVerificationCode() As String
        Dim stringBuilder As New StringBuilder
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim code As String = ""
        Dim gen As New Random
        For i = 0 To 5
            stringBuilder.Append(chars(gen.Next(0, chars.Length - 1)))
        Next
        code = stringBuilder.ToString
        Return code
    End Function

    Public Sub ChangeUserPass(ByVal username As String, ByVal password As String)
        Dim aes As String = Encryption.GenerateSalt
        Dim pass As String = Encryption.HashString(String.Format("{0}{1}", Encryption.HashString(password), aes))
        Using cn As New MySqlConnection(Helper.LoadConnectionString) : cn.Open()
            Dim cmd As New MySqlCommand("update UserAccounts set Password = @pass, AES256 = @aes where Username = @user", cn)
            cmd.Parameters.AddWithValue("@pass", pass)
            cmd.Parameters.AddWithValue("@aes", aes)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Successfully changed password. You may now login.", MsgBoxStyle.Information, "Success")
        End Using
    End Sub
#End Region

End Module
