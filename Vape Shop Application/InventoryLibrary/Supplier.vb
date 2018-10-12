Imports Dapper
Imports MySql.Data.MySqlClient

Public Class Supplier

    Public Property SupplierName As String
    Public Property ContactNumber As String
    Public Property EmailAddress As String
    Public Property Address As String
    Public Property Description As String

    Public Shared Function LoadSuppliers() As List(Of Supplier)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            Dim output = idbcn.Query(Of Supplier)("select * from Suppliers", New DynamicParameters)
            Return output.ToList
        End Using
    End Function

    Public Shared Sub SaveSupplier(supplier As Supplier)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            idbcn.Execute("insert into Suppliers(SupplierName, ContactNumber, EmailAddress, Address, Description)values(" &
                          "@SupplierName, @ContactNumber, @EmailAddress, @Address, @Description", supplier)
        End Using
    End Sub

End Class
