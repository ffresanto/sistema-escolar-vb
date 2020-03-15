Imports System.Data.SqlClient

Module ModConexao

    Public conexao As New SqlConnection("Server=.; DataBase=DBescola; Integrated Security=SSPI")
    Sub abrir()
        If conexao.State = 0 Then
            conexao.Open()
        End If
    End Sub

    Sub fechar()
        If conexao.State = 1 Then
            conexao.Close()
        End If
    End Sub

    Public modUsuario As String
    Public codAluno As String

End Module
