Public Class Usuario
    Private nome As String
    Private sobrenome As String
    Private username As String
    Private senha As String

    Public Property GetNome() As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

    Public Property GetSobrenome() As String
        Get
            Return sobrenome
        End Get
        Set(value As String)
            sobrenome = value
        End Set
    End Property

    Public Property GetUsername() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property GetSenha() As String
        Get
            Return senha
        End Get
        Set(value As String)
            senha = value
        End Set
    End Property

End Class
