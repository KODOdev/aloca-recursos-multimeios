Imports MySql.Data.MySqlClient

Module mdl_cadastraDadosMYSQL
    Public Sub cadastraDadosMYSQL(cod, quant, desc)

        Dim sql As String
        Dim cmd As MySqlCommand

        Using con As MySqlConnection = credenciaisMYSQL()
            con.Open()
            Try
                sql = "INSERT INTO db_aloca_recursos.tb_recursos(codigo_recurso, quantidade_recurso, descricao_recurso) 
                                     VALUES (@cod,@quant,@desc);"
                cmd = New MySqlCommand(sql, con)

                cmd.Parameters.Add("@cod", MySqlDbType.Int16)
                cmd.Parameters.Add("@quant", MySqlDbType.Int16)
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar, 50)

                cmd.Parameters("@cod").Value = cod
                cmd.Parameters("@quant").Value = quant
                cmd.Parameters("@desc").Value = desc

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End Using
    End Sub
End Module
