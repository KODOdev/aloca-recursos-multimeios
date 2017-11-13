Public Class Professor

    Private Nome As String
        Private Matricula As Integer
        Private telefone As Integer

        Public Sub New()

            Nome = vbNullString
            Matricula = 0
            telefone = 0

        End Sub

    Public Sub criarProfessor(_Matricula As Integer, _telefone As Integer, _Nome As String)

        Matricula = _Matricula
        Nome = _Nome
        telefone = _telefone

    End Sub

    Public Function imprimirProfessor() As String

            Return Nome

        End Function

        Public Function obterMatricula() As Integer

            Return Matricula

        End Function

    Public Function obterTelefone() As Integer

        Return telefone

    End Function


End Class
