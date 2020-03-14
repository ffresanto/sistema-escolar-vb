Imports System.Data.SqlClient

Public Class frmTelaLogin
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dim confimar = MsgBox("Deseja sair?", vbYesNo + vbExclamation, "Atenção")

        If confimar = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim usuario As String = txtEmail.Text
        Dim senha As String = txtSenha.Text

        If usuario = "" Or senha = "" Then
            MsgBox("Preencha os campos")
        Else
            Dim cmd As New SqlCommand("iniciarSessao", conexao)
            Try

                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@Nome", usuario)
                    .AddWithValue("@Senha", senha)
                    .Add("@Msg", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With

                modUsuario = txtEmail.Text
                Dim msg As String = cmd.Parameters("@Msg").Value
                MsgBox(msg, vbInformation)

                If (msg = "Dados incorretos") Then
                    txtSenha.Clear()
                    txtEmail.Clear()
                    txtEmail.Focus()
                Else
                    Dim frm As New frmPrincipal
                    Me.Hide()
                    frm.ShowDialog()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conexao.Close()

        End If
    End Sub
End Class
