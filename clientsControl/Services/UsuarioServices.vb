Public Class UsuarioServices

    Private ReadOnly _usuarioRepository As IUsuarioRepository

    Public Sub New(usuarioRepository As IUsuarioRepository)
        _usuarioRepository = usuarioRepository
    End Sub

    Public Function AdicionarUsuario(user As Usuario) As Boolean
        _usuarioRepository.CriarUsuario(user)
        Return True
    End Function
End Class
