Public Class frmTelaLogin
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dim confimar = MsgBox("Deseja sair?", vbYesNo + vbExclamation, "Atenção")

        If confimar = vbYes Then
            Me.Close()
        End If

    End Sub
End Class
