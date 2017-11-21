Public Class ListaRecurso

    Private lista As List(Of TipoRecurso)

    Public Sub New()

        lista = New List(Of TipoRecurso)


    End Sub

    Public Sub inserirLista(recurso As TipoRecurso)

        lista.Add(recurso)

    End Sub

    Public Function buscarRec(id As Integer) As TipoRecurso

        Dim recurso As TipoRecurso = New TipoRecurso()

        recurso = Nothing

        'caso o id do recurso seja o mesmo informado no parâmtro o OBJETO é retornado.

        For Each rec In lista

            If (rec.obterIdRecurso = id) Then

                recurso = rec

            End If

        Next

        Return recurso

    End Function


    Public Function impressaoRec() As String
        Dim msg As String = "A lista está vazia."

        If lista.Count <> 0 Then

            msg = "ID      |        Descrição " & vbNewLine

            For Each rec In lista

                msg += rec.obterIdRecurso & "   | " & rec.imprimirRecurso & vbNewLine

            Next

        End If


        Return msg

    End Function


    Public Function EstaVazia() As Boolean

        Dim vazia As Boolean = False

        If (lista.Count = 0) Then

            vazia = True

        End If

        Return vazia

    End Function

End Class
