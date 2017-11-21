Imports MySql.Data.MySqlClient

Module mdl_mostraRecursosMYSQL
	Public Sub PesquisaArquivosMYSQL()

		Dim sql As String
		Dim cmd As MySqlCommand

		Using con As MySqlConnection = credenciaisMYSQL()
			con.Open()
			Try
				sql = "SELECT * FROM db_aloca_recursos.tb_recursos;"
                cmd = New MySqlCommand(sql, con)
                myAdapter.Fill(myData)
                DataGrid1.DataSource = myData

                cmd.ExecuteNonQuery()
			Catch ex As Exception
				MsgBox(ex.Message)
			End Try
			con.Close()
		End Using
	End Sub
End Module
