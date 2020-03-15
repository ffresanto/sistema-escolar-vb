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
        dtpDataNascimento.Value = "01/01/2000"
        Listar()
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

                Listar()
                'Limpar()

                Me.Width = 748

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dtpDataNascimento_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataNascimento.ValueChanged
        Dim dataNasc As Date
        Dim idade As Integer

        dataNasc = dtpDataNascimento.Value
        idade = Now.Year - dataNasc.Year

        If dataNasc >= "01/01/2020 " Then
            MsgBox("Idade não permitida para matricula")
            txtIdade.Clear()
            dtpDataNascimento.Value = "01/01/2000"
        Else
            txtIdade.Text = Convert.ToString(idade)
        End If

    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("select * from TBaluno", conexao)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim x As Integer = DataGridView1.Rows.Count
            lblNumeroTotal.Text = CInt(x)
        Catch ex As Exception
            fechar()
            MsgBox(ex.Message)
        End Try

    End Sub
End Class