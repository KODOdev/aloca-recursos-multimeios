Imports System.Text.RegularExpressions

Public Class FormSolicitar
    Dim solicitante As Professor = New Professor()
    Dim kitsCadastrados As ListaRecurso = New ListaRecurso
    Dim estaSolicitacao As Solicitacao = New Solicitacao()
    Dim recursoEscolhido As TipoRecurso = New TipoRecurso()
    Dim interesseFila As Boolean = False
    Dim telefone As Integer
    Dim matricula As Integer
    Dim solicitacaoConcluida As Boolean = False

    Public Sub New(_listaDeRecursos As ListaRecurso)
        ' Essa chama é requisitada pelo designer do formulario, quando existe um parâmetro no construtor. 
        InitializeComponent()

        ' é necessário uma lista de kits, para que o usuário consiga imprimí-la
        kitsCadastrados = _listaDeRecursos
    End Sub

    Private Sub ButtonFinalizarSolicitacao_Click(sender As Object, e As EventArgs) Handles ButtonFinalizarSolicitacao.Click
        Try
            If matricula < 1000 Or matricula > 9999 Then
                MsgBox("O numero de matricula informado não é valido.")
                matricula = 0
            Else
                'Cria a solicitação e os professores. Se os dados estiverem corretos a solicitação pode ser concluida.
                solicitante.criarProfessor(matricula, telefone, TextBoxNome.Text)

                'Passa os parametros para o cadastro do professor no banco
                CadastraProfessorMYSQL(matricula, TextBoxNome.Text.ToString(), telefone)

                estaSolicitacao.criarSolicitacao(solicitante, recursoEscolhido, (Int(Sala.Text)), interesseFila)
                solicitacaoConcluida = True

                'Pega o codigo informado para subtrair em 1 a quantidade total do mesmo
                RemoveRecursosMYSQL(Codigo.Value)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Todos os campos precisam ser preenchidos corretamente. Verifique e tente novamente")
        End Try
    End Sub

    Private Sub RecursosImpressos_Click(sender As Object, e As EventArgs) Handles RecursosImpressos.Click
        'MsgBox(kitsCadastrados.impressaoRec())
        frm_mostraRecursos.Show()
    End Sub

    Public Function obterKitEscolhido() As TipoRecurso
        Return recursoEscolhido
    End Function

    Public Function ObterSolicitante() As Professor
        Return solicitante
    End Function

    Public Function obterSolicitacao() As Solicitacao
        If solicitacaoConcluida Then
            Return estaSolicitacao
        Else
            Return Nothing
        End If
    End Function

    Private Sub Codigo_ValueChanged(sender As Object, e As EventArgs) Handles Codigo.ValueChanged
        'Caso o recurso não exista, o botão de finalização é desativado até que o usuário entre com um existente
        ButtonFinalizarSolicitacao.Enabled = 0

        recursoEscolhido = kitsCadastrados.buscarRec(Codigo.Value)
        If (IsNothing(recursoEscolhido)) Then
            MsgBox("Este recurso não existe. Por favor, ecolha um recurso valido.")
        Else
            ButtonFinalizarSolicitacao.Enabled = 1
        End If
    End Sub

    Private Sub TelefoneBox_TextChanged(sender As Object, e As EventArgs) Handles TelefoneBox.TextChanged
        'O tratamento para codigo do recurso foi usado aqui
        ButtonFinalizarSolicitacao.Enabled = 0

        Try
            telefone = Integer.Parse(TelefoneBox.Text)
            ButtonFinalizarSolicitacao.Enabled = 1
        Catch ex As Exception
            MsgBox("O numero informado não é valido.")
        End Try
    End Sub

    Private Sub CheckBoxListaDeEspera_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxListaDeEspera.CheckedChanged
        'Se a checkbox estiver marcada, é porque há interesse na lista de espera.
        If CheckBoxListaDeEspera.Checked Then
            interesseFila = True
        End If
    End Sub

    Private Sub TextBoxMatricula_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMatricula.TextChanged
        ButtonFinalizarSolicitacao.Enabled = 0
        Try
            matricula = Integer.Parse(TextBoxMatricula.Text)
            ButtonFinalizarSolicitacao.Enabled = 1
        Catch ex As Exception
            MsgBox("O numero informado não é valido.")
        End Try
    End Sub
End Class
