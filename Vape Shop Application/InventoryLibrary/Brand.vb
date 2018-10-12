Imports Dapper
Imports MySql.Data.MySqlClient

Public Class Brand

    Public Property BrandName As String

    Public Shared Function LoadBrands() As List(Of Brand)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            Dim output = idbcn.Query(Of Brand)("select * from Brands", New DynamicParameters)
            Return output.ToList
        End Using
    End Function

    Public Shared Sub SaveBrand(brand As Brand)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            idbcn.Execute("insert into Brands(BrandName)values(@BrandName)", brand)
        End Using
    End Sub

End Class
