Imports System.Data.SqlClient

Public Class frmAlunos
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Me.Width = 1000
        If rdoCpf.Checked Then
            txtCpf.Text = txtCodigo.Text
            txtCodigo.Text = ""
            txtNome.Text = ""
            txtNome.Focus()
        Else
            txtNome.Text = txtCodigo.Text
            txtCodigo.Text = ""
            txtCpf.Text = ""
            txtCpf.Focus()
        End If
    End Sub

    Private Sub frmAlunos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 748
    End Sub

    Private Sub btnFecharDados_Click(sender As Object, e As EventArgs) Handles btnFecharDados.Click
        Me.Width = 748
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand
        codAluno = txtCpf.Text

        If txtCpf.Text <> "" And txtNome.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("registrarAluno", conexao)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class