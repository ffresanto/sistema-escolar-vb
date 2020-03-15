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
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Cpf", txtCpf.Text)
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
                cmd.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text)
                cmd.Parameters.AddWithValue("@Idade", txtIdade.Text)
                cmd.Parameters.AddWithValue("@Sexo", If(rdoMasculino.Checked = True, "M", "F"))
                cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@Data_nascimento", dtpDataNascimento.Value)
                cmd.Parameters.Add("@Mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim mensagem As String = cmd.Parameters("@Mensagem").Value.ToString
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                'Listar()
                'Limpar()

                Me.Width = 748

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class