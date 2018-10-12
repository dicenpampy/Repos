Imports Dapper
Imports MySql.Data.MySqlClient

Public Class Product

    Public Property ProductCode As String
    Public Property ProductName As String
    Public Property Brand As Brand
    Public Property SupplierName As Supplier
    Public Property Quantity As Integer
    Public Property SRP As Decimal
    Public Property RSP As Decimal
    Public Property ExpirationDate As Date
    Public Property ProductCategory As Category

    Public Function StringToDate(expDate As String) As Date
        Dim output As Date
        output = DateTime.Parse(expDate).ToString("yyyy-MM-dd")
        Return output
    End Function

    Public Shared Function LoadProducts() As List(Of Product)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            Dim output = idbcn.Query(Of Product)("select * from Products", New DynamicParameters)
            Return output.ToList
        End Using
    End Function

    Public Shared Sub SaveProduct(product As Product)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            idbcn.Execute("insert into Products(ProductCode, ProductName, Brand, SupplierName, Quantity, SRP, RSP, ExpirationDate, ProductCategory)values(" &
                          "@ProductCode, @ProductName, @Brand, @SupplierName, @Quantity, @SRP, @RSP, @ExpirationDate, @ProductCategory)", product)
        End Using
    End Sub

End Class
