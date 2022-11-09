Public Class UsuarioServices

    Private ReadOnly _usuarioRepository As IUsuarioRepository = New SQLUsuarioImplementation()

    Public Sub New()
    End Sub

    Public Sub New(usuarioRepository As IUsuarioRepository)
        _usuarioRepository = usuarioRepository
    End Sub

    Public Function AdicionarUsuario(user As Usuario) As Boolean
        Dim validate = _usuarioRepository.VerificarUsername(user)

        If validate = True Then
            Return False
        Else
            Dim response = _usuarioRepository.CriarUsuario(user)
            Return response
        End If
    End Function

    Public Function BuscarUsuarios() As BindingSource
        Return _usuarioRepository.TodosUsuarios()
    End Function

    Public Function PegarUsuarioPorID(value As String) As DataTable
        Dim _userRepository As IUsuarioRepository = New SQLUsuarioImplementation()
        Return _userRepository.PegarUsuario(value)
    End Function
End Class
