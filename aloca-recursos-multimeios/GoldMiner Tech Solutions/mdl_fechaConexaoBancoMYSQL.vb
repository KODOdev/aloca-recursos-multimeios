Imports MySql.Data.MySqlClient

Module mdl_fechaConexaoBancoMYSQL
    Public Sub fechaConexaoMYSQL()
        Using con As MySqlConnection = credenciaisMYSQL()
            con.Close()
        End Using
    End Sub
End Module
