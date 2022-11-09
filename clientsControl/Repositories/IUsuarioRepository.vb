Public Interface IUsuarioRepository

    Function VerificarUsername(usuario As Usuario) As Boolean
    Function CriarUsuario(usuario As Usuario) As Boolean
    Function AtualizarUsuario(id As Integer) As Usuario
    Sub DeletarUsuario(id As Integer)
    Function TodosUsuarios()
    Function PegarUsuario(value As String) As DataTable

End Interface
