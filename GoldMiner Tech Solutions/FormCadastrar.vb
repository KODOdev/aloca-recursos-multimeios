Public Class FormCadastrar

    Private recurso As TipoRecurso = New TipoRecurso()

    Private cadastrado As Boolean = False

    Private Sub FormCadastrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CadastrarRec.Enabled = 0

    End Sub

    Private Sub CadastrarRec_Click(sender As Object, e As EventArgs) Handles CadastrarRec.Click


        recurso.criarRecurso(Codigo.Value, Quantidade.Value, TBDescricao.Text)

        cadastrado = True

        Me.Close()


    End Sub

    Private Sub validarCadastro()


        If (Not (String.IsNullOrWhiteSpace(Descricao.Text))) And (Quantidade.Value <> 0) And (Codigo.Value <> 0) Then

            CadastrarRec.Enabled = 1

        Else

            CadastrarRec.Enabled = 0


        End If



    End Sub

    Public Function obterRecurso() As TipoRecurso

        If cadastrado Then
            Return recurso
        Else
            Return Nothing
        End If

    End Function

    ' A partir daqui, toda vez que a quantidade, o codigo e a descrição do recurso é alterada, é feita uma validação.

    Private Sub Quantidade_ValueChanged(sender As Object, e As EventArgs) Handles Quantidade.ValueChanged
        validarCadastro()
    End Sub

    Private Sub Codigo_ValueChanged(sender As Object, e As EventArgs) Handles Codigo.ValueChanged
        validarCadastro()
    End Sub

    Private Sub TBDescricao_TextChanged(sender As Object, e As EventArgs) Handles TBDescricao.TextChanged

        validarCadastro()
    End Sub
End Class