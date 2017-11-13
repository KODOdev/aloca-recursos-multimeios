Public Class FormMain

    Public ListaDeRecursos As ListaRecurso
    Public ListaDeSolicitacoes As ListaSolicitacao

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicializando listas através do método construtor
        ListaDeRecursos = New ListaRecurso
        ListaDeSolicitacoes = New ListaSolicitacao

        'Incializando conexao com o banco
        conectaBancoMYSQL()
    End Sub


    Private Sub Cadastrar_Click(sender As Object, e As EventArgs) Handles Cadastrar.Click
        Dim novoRec As TipoRecurso = New TipoRecurso
        Dim novoCadastro As FormCadastrar = New FormCadastrar

        'Show dialog permite que a app só prossiga caso o novo form seja fechado
        'O form permitirá com que o usuário preencha os dados 
        novoCadastro.ShowDialog()

        'O método preenche informações no form e retorna o recurso ou NULO (nothing)

        novoRec = novoCadastro.obterRecurso

        If Not (IsNothing(novoRec)) Then

            ListaDeRecursos.inserirLista(novoRec)

            MsgBox("Recurso cadastrado! ")

        End If

    End Sub

    Private Sub Sair_Click(sender As Object, e As EventArgs) Handles Sair.Click
        fechaConexaoMYSQL()
        Application.Exit()
    End Sub

    Private Sub Solicitar_Click(sender As Object, e As EventArgs) Handles Solicitar.Click

        Dim novaSolicitacao As Solicitacao = New Solicitacao
        Dim novoFormSolicitacao As FormSolicitar = New FormSolicitar(ListaDeRecursos)

        If (ListaDeRecursos.EstaVazia) Then
            MsgBox("Nenhum recurso foi cadastrado.")

        Else

            novoFormSolicitacao.ShowDialog()

            novaSolicitacao = novoFormSolicitacao.obterSolicitacao

            If Not (IsNothing(novaSolicitacao)) Then

                ListaDeSolicitacoes.inserirLista(novaSolicitacao)

                'Obtem o kit escolhido e verifica se todas as unidades foram solicitadas

                If (novoFormSolicitacao.obterKitEscolhido.obterQtDisponivel = 0) Then

                    MsgBox("Recurso Indisponível no momento." & vbNewLine & novaSolicitacao.imprimirSolicitacao,, "             Solicitação concluída! ")
                Else

                    MsgBox("Recurso Disponível!" & vbNewLine & novaSolicitacao.imprimirSolicitacao,, "             Solicitação concluída! ")
                    novoFormSolicitacao.obterKitEscolhido.bloquearRecurso()

                End If

            End If

        End If



    End Sub

End Class