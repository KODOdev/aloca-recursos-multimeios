Imports GoldMiner_Tech_Solutions

Public Class TipoRecurso

    Private idTipoRecurso As Integer
    Private descricao As String
    Private qtdRecurso As Integer
    Private qtdUso As Integer

    Public Sub New()

        idTipoRecurso = 0
        descricao = vbNullString
        qtdRecurso = 0
        qtdUso = 0

    End Sub

    Public Sub criarRecurso(_id As Integer, _qtd As Integer, _descricao As String)

        idTipoRecurso = _id
        qtdRecurso = _qtd
        descricao = _descricao

    End Sub

    Public Function imprimirRecurso() As String

        Return descricao

    End Function

    Public Function obterIdRecurso() As Integer

        Return idTipoRecurso

    End Function

    Public Sub bloquearRecurso()

        qtdUso = qtdUso + 1

    End Sub

    Public Function obterQtDisponivel() As Integer

        Return (qtdRecurso - qtdUso)

    End Function
End Class
