Imports System.Configuration
Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class Helper

    Public Shared Function LoadConnectionString(ByVal Optional id As String = "Default") As String
        Return ConfigurationManager.ConnectionStrings(id).ConnectionString
    End Function

End Class
