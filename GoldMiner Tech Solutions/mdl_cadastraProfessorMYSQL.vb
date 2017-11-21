Imports MySql.Data.MySqlClient

Module mdl_cadastraProfessorMYSQL
	Public Sub CadastraProfessorMYSQL(mat, nome, tel)

		Dim sql As String
		Dim cmd As MySqlCommand

		Using con As MySqlConnection = credenciaisMYSQL()
			con.Open()
			Try
				sql = "INSERT INTO db_aloca_recursos.tb_professor(matricula_professor, nome_professor, telefone_professor) 
                                     VALUES (@mat,@nome,@tel);"
				cmd = New MySqlCommand(sql, con)

				cmd.Parameters.Add("@mat", MySqlDbType.Int16)
				cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100)
				cmd.Parameters.Add("@tel", MySqlDbType.Int16)

				cmd.Parameters("@mat").Value = mat
				cmd.Parameters("@nome").Value = nome
				cmd.Parameters("@tel").Value = tel

				cmd.ExecuteNonQuery()
			Catch ex As Exception
				MsgBox(ex.Message)
			End Try
			con.Close()
		End Using
	End Sub
End Module
