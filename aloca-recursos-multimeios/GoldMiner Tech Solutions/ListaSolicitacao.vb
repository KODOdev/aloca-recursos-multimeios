Public Class ListaSolicitacao

    Private lista As List(Of Solicitacao)

    Public Sub New()

        lista = New List(Of Solicitacao)


    End Sub

    Public Sub inserirLista(solicitacao As Solicitacao)

        lista.Add(solicitacao)

    End Sub




    Public Function buscarSolicitacao(MatriculaProfessor As Integer) As Solicitacao

        Dim solicitacao As Solicitacao = New Solicitacao()

        solicitacao = Nothing

        For Each _solicitacao In lista

            If (_solicitacao.obterProfessor.obterMatricula = MatriculaProfessor) Then

                solicitacao = _solicitacao

            End If

        Next

        Return solicitacao

    End Function


    Public Function impressaoSolic() As String
        Dim msg As String = "A lista está vazia."

        If lista.Count <> 0 Then

            msg = "               Informações do solicitação" & vbNewLine

            For Each _solicitacao In lista

                msg += "------------------ "
                msg += _solicitacao.imprimirSolicitacao & vbNewLine

            Next

        End If


        Return msg

    End Function


End Class
