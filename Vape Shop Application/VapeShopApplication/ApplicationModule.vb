Imports MySql.Data.MySqlClient
Imports Dapper
Imports InventoryLibrary
Imports Encryptor

Module ApplicationModule

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

End Module
