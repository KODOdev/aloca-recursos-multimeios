Imports MySql.Data.MySqlClient

Module mdl_removeRecursoMYSQL
    Public Sub RemoveRecursosMYSQL(cod)

        Dim sql As String
        Dim cmd As MySqlCommand

        Using con As MySqlConnection = credenciaisMYSQL()
            con.Open()
            Try
                sql = "UPDATE db_aloca_recursos.tb_recursos
                       SET quantidade_recurso = quantidade_recurso - 1
                       WHERE codigo_recurso=@cod;"
                cmd = New MySqlCommand(sql, con)

                cmd.Parameters.Add("@cod", MySqlDbType.Int16)

                cmd.Parameters("@cod").Value = cod

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End Using
    End Sub
End Module
