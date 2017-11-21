Public Class frm_mostraRecursos
    Private Sub frm_mostraRecursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        PesquisaArquivosMYSQL()
    End Sub
End Class