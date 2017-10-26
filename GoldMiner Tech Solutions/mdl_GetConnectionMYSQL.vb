Imports MySql.Data.MySqlClient

Module mdl_GetConnectionMYSQL
    Public Function GetConnectionMYSQL() As MySqlConnection
        Dim sql As String = "SERVER=127.0.0.1; database=db_aloca_recursos; Uid=root; Pwd=admin"
        Return New MySqlConnection(sql)
    End Function
End Module
