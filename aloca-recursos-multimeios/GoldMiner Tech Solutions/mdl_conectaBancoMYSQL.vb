Imports MySql.Data.MySqlClient

Module mdl_conectaBancoMYSQL
    Public Sub conectaBancoMYSQL()
        Using con As MySqlConnection = credenciaisMYSQL()

            'armazena se a conexao foi concluida com sucesso ou nao
            Dim conectado As Boolean

            Try
                'abre a conexao baseada nas credenciais dadas
                con.Open()
                conectado = vbTrue
            Catch ex As Exception
                MsgBox("Erro ao se conectar ao Banco de Dados da aplicação! " + vbCrLf + vbCrLf + ex.Message)
                conectado = vbFalse
            End Try

            If conectado Then
                MsgBox("Conexão ao Banco de Dados Efetuada com Sucesso!")
            End If
        End Using
    End Sub
End Module
