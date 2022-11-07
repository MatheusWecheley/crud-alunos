Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class SQLUsuarioImplementation
    Implements IUsuarioRepository

    Public Sub DeletarUsuario(id As Integer) Implements IUsuarioRepository.DeletarUsuario
        Throw New NotImplementedException()
    End Sub

    Public Function CriarUsuario(usuario As Usuario) As Boolean Implements IUsuarioRepository.CriarUsuario

        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim str As String = "INSERT INTO USUARIOS (nome, sobrenome, username, senha, cargo) VALUES (@nome, @sobrenome, @username, @senha, @cargo)"

            conexao = New SqlConnection(GetStrCon)
            cmd = New SqlCommand(str, conexao)
            cmd.Parameters.AddWithValue("@nome", usuario.GetNome)
            cmd.Parameters.AddWithValue("@sobrenome", usuario.GetSobrenome)
            cmd.Parameters.AddWithValue("@username", usuario.GetUsername)
            cmd.Parameters.AddWithValue("@senha", usuario.GetSenha)
            cmd.Parameters.AddWithValue("@cargo", usuario.GetCargo)
            conexao.Open()
            cmd.ExecuteNonQuery()
            conexao.Close()
            Return True
        Catch ex As Exception
            MsgBox("Erro ao criar um novo usuario!", vbNewLine, ex.Message)
            Return False
        End Try

        Return True
    End Function

    Public Function AtualizarUsuario(id As Integer) As Usuario Implements IUsuarioRepository.AtualizarUsuario
        Throw New NotImplementedException()
    End Function

    Public Function TodosUsuarios() As IEnumerable(Of Usuario) Implements IUsuarioRepository.TodosUsuarios
        Throw New NotImplementedException()
    End Function

    Public Function VerificarUsername(usuario As Usuario) As Boolean Implements IUsuarioRepository.VerificarUsername
        Try
            Dim conexao As SqlConnection
            Dim cmd As SqlCommand
            Dim read As SqlDataReader
            Dim str As String = $"SELECT username FROM Usuarios Where username = @username"

            conexao = New SqlConnection(GetStrCon())
            cmd = New SqlCommand(str, conexao)
            cmd.Parameters.AddWithValue("@username", usuario.GetUsername)
            conexao.Open()
            read = cmd.ExecuteReader()
            If read.Read() = True Then
                Return True
            End If
            Return False
            conexao.Close()
        Catch ex As Exception
            MsgBox("Erro ao consultar usuario!" & vbNewLine & vbNewLine & ex.Message)
        End Try
        Return False
    End Function
End Class
