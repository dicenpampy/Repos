Imports Dapper
Imports MySql.Data.MySqlClient

Public Class Category

    Public Property CategoryName As String

    Public Shared Function LoadCategories() As List(Of Category)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            Dim output = idbcn.Query(Of Category)("select * from Categories", New DynamicParameters)
            Return output.ToList
        End Using
    End Function

    Public Shared Sub SaveCategory(category As Category)
        Using idbcn As IDbConnection = New MySqlConnection(Helper.LoadConnectionString)
            idbcn.Execute("insert into Categories(CategoryName)values(@CategoryName)", category)
        End Using
    End Sub
End Class
