Imports MySql.Data.MySqlClient

Module mdl_alimentaListaMYSQL
    Public Sub AlimentaLista(ListaDeRecursos)

        Dim sql As String
        Dim cmd As MySqlCommand
        Dim dt As New DataTable()

        Using con As MySqlConnection = credenciaisMYSQL()
            con.Open()
            Try
                sql = "SELECT codigo_recurso, 
                              descricao_recurso, 
                              quantidade_recurso 
                              FROM db_aloca_recursos.tb_recursos;"

                cmd = New MySqlCommand(sql, con)

                Dim da As New MySqlDataAdapter(cmd)

                da.Fill(dt)

                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim str As String = dt.Rows(i).ToString
                    Dim dados As TipoRecurso = CType(str, TipoRecurso)

                    ListaDeRecursos.inserirLista(dados)
                Next
            Catch ex As Exception
                MsgBox("Erro ao popular lista! " + vbCrLf + vbCrLf + ex.Message)
            End Try
            con.Close()
        End Using

    End Sub
End Module
