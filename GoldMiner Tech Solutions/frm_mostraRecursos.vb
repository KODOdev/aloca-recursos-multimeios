Public Class frm_mostraRecursos
    Private Sub frm_mostraRecursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'insere a pesquisa no DataGridView
        dvgRecursos.DataSource = PesquisaArquivosMYSQL()
    End Sub
End Class