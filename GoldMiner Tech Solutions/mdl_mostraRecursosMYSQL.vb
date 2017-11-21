Imports MySql.Data.MySqlClient

Module mdl_mostraRecursosMYSQL
    Public Function PesquisaArquivosMYSQL()

        Dim sql As String
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim dt As DataTable = Nothing

        Using con As MySqlConnection = credenciaisMYSQL()
            con.Open()
            Try
                sql = "SELECT codigo_recurso AS 'Código do Recurso', descricao_recurso AS 'Nome do Recurso', quantidade_recurso AS 'Quantidade' FROM db_aloca_recursos.tb_recursos;"
                cmd = New MySqlCommand(sql, con)
                da = New MySqlDataAdapter(cmd)
                dt = New DataTable

                da.Fill(dt)

                Return dt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End Using
        Return dt
    End Function
End Module
