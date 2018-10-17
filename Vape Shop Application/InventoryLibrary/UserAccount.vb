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

    Public Sub RegisterUserAccount(user_account As UserAccount)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            idbcn.Execute("insert into UserAccounts(Username, Password, AES256, Position, FirstName, LastName, EmailAddress, Address, " &
                          "ContactNumber)values(@Username, @Password, @AES256, @Position, @FirstName, @LastName, @EmailAddress, @Address, @ContactNumber)", user_account)
        End Using
    End Sub

End Class
