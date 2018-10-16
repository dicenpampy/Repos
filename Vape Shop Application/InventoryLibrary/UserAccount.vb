Imports Dapper
Imports MySql.Data.MySqlClient

Public Class UserAccount

    Public Property Username As String
    Public Property Password As String
    Public Property AES256 As String
    Public Property Position As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property EmailAddress As String
    Public Property Address As String
    Public Property ContactNumber As String

    Public Shared Sub RegisterUserAccount(user_account As UserAccount)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            idbcn.Execute("insert into UserAccounts(Username, Password, AES256, Position, FirstName, LastName, EmailAddress, Address, " &
                          "ContactNumber)values(@Username, @Password, @AES256, @Position, @FirstName, @LastName, EmailAddress, @Address, @ContactNumber)", user_account)
        End Using
    End Sub

    Public Shared Function UserExists(ByVal username As String, ByVal password As String) As Boolean
        Dim salt As String = ""
        Using idbcn = New MySqlConnection(Helper.LoadConnectionString)
            idbcn.Open()
            Dim cmd As New MySqlCommand("select * from UserAccounts where Username = @user", idbcn)
            cmd.Parameters.AddWithValue("@user", username)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            While dr.Read()
                salt = dr!AES256.ToString
            End While
            dr.Dispose()

            Dim pass = Encryptor.Encryption.HashString(password)
            Dim hashed_salt = Encryptor.Encryption.HashString(String.Format("{0}{1}", pass, salt))
            cmd = New MySqlCommand("select * from UserAccounts where Username = @user", idbcn)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", hashed_salt)

            Dim results = Convert.ToInt32(cmd.ExecuteScalar())
            If results = 1 Then Return True Else Return False
            idbcn.Close()
        End Using
    End Function

End Class
