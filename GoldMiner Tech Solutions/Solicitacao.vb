Public Class Solicitacao

    Private novoProfessor As Professor = New Professor()
    Private novoRecurso As TipoRecurso = New TipoRecurso()
    Private sala As Integer
    Private FilaEspera As Boolean = False

    Public Sub criarSolicitacao(_prof As Professor, _recurso As TipoRecurso, _sala As Integer, _InteresseFila As Boolean)

        novoProfessor = _prof
        novoRecurso = _recurso
        sala = _sala
        FilaEspera = _InteresseFila

    End Sub

    Public Function imprimirSolicitacao() As String

        Dim msg As String

        msg = ("Professor : " & novoProfessor.imprimirProfessor & vbNewLine &
              "Matricula : " & novoProfessor.obterMatricula & vbNewLine &
              "Kit: " & novoRecurso.imprimirRecurso & vbNewLine &
              "Telefone: " & novoProfessor.obterTelefone & vbNewLine &
              "Sala : " & sala & vbNewLine)

        If (FilaEspera) Then
            msg += "Interesse na fila de espera: Sim "
        Else
            msg += "Interesse na fila de espera: Não "
        End If

        Return msg

    End Function

    Public Function obterProfessor() As Professor

        Return novoProfessor

    End Function


End Class