Public Interface IUsuarioRepository
    Function CriarUsuario(usuario As Usuario) As Boolean
    Function AtualizarUsuario(id As Integer) As Usuario
    Sub DeletarUsuario(id As Integer)
    Function TodosUsuarios() As IEnumerable(Of Usuario)

End Interface
