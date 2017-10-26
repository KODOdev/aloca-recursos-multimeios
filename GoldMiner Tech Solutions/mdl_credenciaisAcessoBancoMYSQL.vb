Imports MySql.Data.MySqlClient

Module mdl_credenciaisAcessoBancoMYSQL
    Public Function credenciaisMYSQL() As MySqlConnection
        'Passa as credenciais para acessar o bd
        Dim sql As String = "server=127.0.0.1;user id=root; password=admin;database=db_aloca_recursos"
        Return New MySqlConnection(sql)
    End Function
End Module
