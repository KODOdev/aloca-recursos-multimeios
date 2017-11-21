Public Class frm_mostraRecursos
    Private Sub frm_mostraRecursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dvgRecursos.DataSource = PesquisaArquivosMYSQL()
    End Sub
End Class