Imports MySql.Data.MySqlClient

Module mdl_alimentaListaMYSQL
    Public Function AlimentaLista()

        Dim sql As String
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()
        Dim RecCad As New DataSet

        Using con As MySqlConnection = credenciaisMYSQL()
            con.Open()
            Try
                sql = "SELECT * FROM db_aloca_recursos.tb_recursos;"

                cmd = New MySqlCommand(sql)
                da = New MySqlDataAdapter(cmd)

                RecCad.Load(dt)

                Return dt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End Using

        Return dt
    End Function
End Module
