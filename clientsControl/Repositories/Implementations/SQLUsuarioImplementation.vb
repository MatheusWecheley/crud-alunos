Imports System.Data.SqlClient

Public Class SQLUsuarioImplementation
    Implements IUsuarioRepository

    Public Sub DeletarUsuario(id As Integer) Implements IUsuarioRepository.DeletarUsuario
        Throw New NotImplementedException()
    End Sub

    Public Function CriarUsuario(usuario As Usuario) As Boolean Implements IUsuarioRepository.CriarUsuario

        Dim str = GetStrCon()

        Using conn As New SqlConnection(str)
            Using cmd As New SqlCommand()
                Try
                    conn.Open()
                    cmd.CommandText = "INSERT INTO USUARIOS VALUES (@nome, @sobrenome, @username, @senha"
                    usuario.GetNome = cmd.Parameters.Add("@nome", SqlDbType.NVarChar).ToString
                    usuario.GetSobrenome = cmd.Parameters.Add("@sobrenome", SqlDbType.NVarChar).ToString
                    usuario.GetUsername = cmd.Parameters.Add("@username", SqlDbType.NVarChar).ToString
                    usuario.GetSenha = cmd.Parameters.Add("@senha", SqlDbType.NVarChar).ToString
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MsgBox("Erro ao criar um novo usuario!", vbNewLine, ex.Message)
                    Return False
                End Try

            End Using
        End Using
        Return True
    End Function

    Public Function AtualizarUsuario(id As Integer) As Usuario Implements IUsuarioRepository.AtualizarUsuario
        Throw New NotImplementedException()
    End Function

    Public Function TodosUsuarios() As IEnumerable(Of Usuario) Implements IUsuarioRepository.TodosUsuarios
        Throw New NotImplementedException()
    End Function
End Class
