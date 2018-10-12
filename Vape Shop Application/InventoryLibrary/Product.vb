Imports Dapper
Imports MySql.Data.MySqlClient

Public Class Product

    Public Property ProductCode As String
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

End Class
