Imports MySql.Data.MySqlClient

Module mdl_CarregaDadosMYSQL
    Private Sub PCarregaDadosMYSSQL()
        Using con As MySqlConnection = GetConnectionMYSQL()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM tb_recurso"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                'dgvDados.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
End Module
