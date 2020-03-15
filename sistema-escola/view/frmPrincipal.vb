Public Class frmPrincipal
    Private Sub btnAlunos_Click(sender As Object, e As EventArgs) Handles btnAlunos.Click
        Dim form = New frmAlunos
        form.ShowDialog()
    End Sub
End Class