Public Class frmAlunos
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Me.Width = 1000
    End Sub

    Private Sub frmAlunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 748
    End Sub

    Private Sub btnFecharDados_Click(sender As Object, e As EventArgs) Handles btnFecharDados.Click
        Me.Width = 748
    End Sub
End Class